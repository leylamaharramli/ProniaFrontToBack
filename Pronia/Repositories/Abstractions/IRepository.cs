﻿using Pronia.Models;

namespace Pronia.Repositories.Abstractions
{
    public interface IRepository<T> where T : BaseEntity
    {
        Task AddAsync(T entity);
        Task UpdateAsync(T entity);
        Task DeleteAsync(int id);
        Task<T?> GetByIdAsync(int id);
        Task<List<T>> GetAllAsync();
    }
}
