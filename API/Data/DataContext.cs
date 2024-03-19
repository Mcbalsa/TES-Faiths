using API;
using API.Models;
using Microsoft.EntityFrameworkCore;
using System.Net;
public class DataContext : DbContext
{
    public DataContext(DbContextOptions<DataContext> options) : base(options)
    {
        
    }
    public DbSet<Pantheon> Pantheon { get; set; }
    public DbSet<Divine> Divines { get; set; }

   
}
