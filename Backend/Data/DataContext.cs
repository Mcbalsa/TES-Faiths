
using Backend.Models;
using Microsoft.EntityFrameworkCore;
using System.Net;
public class DataContext : DbContext
{
    public DataContext(DbContextOptions<DataContext> options) : base(options)
    {

    }
    public DbSet<Pantheon> Pantheons { get; set; }
    public DbSet<Divine> Divines { get; set; }


}
