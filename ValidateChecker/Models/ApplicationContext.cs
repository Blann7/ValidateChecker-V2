using Microsoft.EntityFrameworkCore;

namespace ValidateChecker
{
    public partial class ApplicationContext : DbContext
    {
        public virtual DbSet<User> Users { get; set; } = null!;
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=31.31.196.234;Database=u1690754_bp;User Id=u1690754_admin;Password=LenaGolovach777");
        }
    }
}
