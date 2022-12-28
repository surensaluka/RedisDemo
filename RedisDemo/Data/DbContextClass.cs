using Microsoft.EntityFrameworkCore;
using RedisDemo.Models;

namespace RedisDemo.Data
{
    public class DbContextClass : DbContext
    {
        protected readonly IConfiguration Configuration;

        //public DbContextClass(DbContextOptions<DbContextClass> options) : base(options)
        //{
        //}

        public DbContextClass(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(Configuration.GetConnectionString("DefaultConnection"));
        }

        public DbSet<Product> Products { get; set; }
    }
}
