
using arabakiralaapi.Models;
using Microsoft.EntityFrameworkCore;

namespace arackiralaapi.Data
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options)
        {
        }
        public DbSet<Colors> Colors { get; set; }   
    }
}
