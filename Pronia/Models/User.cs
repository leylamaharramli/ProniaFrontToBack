using Microsoft.AspNetCore.Identity;

namespace Pronia.Models
{
    public class User : IdentityUser<Guid>
    {
        public string Fullname { get; set; } = null!;
        public string? ImageUrl { get; set; } = "default.jpg";
    }
}
