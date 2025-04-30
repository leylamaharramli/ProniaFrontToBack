using Dapper;
using Microsoft.Data.SqlClient;
using Pronia.Constants;
using Pronia.Models;
using Pronia.Repositories.Abstractions;
using System.Data;

namespace Pronia.Repositories.Implementations
{
    public class SliderRepository : ISliderRepository
    {
        private IDbConnection _connection { get => new SqlConnection(ConnectionString.SqlConnectionString); }
        public async Task AddAsync(Slider entity)
        {
            using var db = _connection;
            await db.ExecuteAsync("INSERT INTO Sliders VALUES (@Title, @Description, @Price, @ImagePath)", entity);
        }

        public Task UpdateAsync(Slider entity)
        {
            using var db = _connection;
            var service = db.ExecuteAsync("UPDATE Sliders SET Name=@Name, Description=@Description, Price=@Price, ImagePath=@ImagePath Where Id=@Id", entity);
            return service;
        }

        public async Task DeleteAsync(int id)
        {
            using var db = _connection;
            await db.ExecuteAsync("DELETE * FROM Sliders WHERE Id=@Id", new { Id = id });
        }

        public Task<Slider?> GetByIdAsync(int id)
        {
            using var db = _connection;
            var service = db.QueryFirstOrDefaultAsync<Slider>("SELECT * FROM Sliders WHERE Id = @Id", new { Id = id });
            return service;
        }

        public async Task<List<Slider>> GetAllAsync()
        {
            using var db = _connection;
            var list = await db.QueryAsync<Slider>("SELECT * FROM Sliders");
            return list.ToList();
        }
    }
}
