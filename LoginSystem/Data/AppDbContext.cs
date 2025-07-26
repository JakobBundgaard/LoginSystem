using LoginSystem.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;


namespace LoginSystem.Data {
    public class AppDbContext : IdentityDbContext<Users> {
        public AppDbContext(DbContextOptions options) : base(options) { }
    }
}
