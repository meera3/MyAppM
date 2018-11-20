using Microsoft.EntityFrameworkCore;
using MyAppM.API.Models;

namespace MyAppM.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options): base(options){}
     
     public DbSet <Value> Values { get; set; }
    }
}