using API;
using Microsoft.EntityFrameworkCore;
using System.Net;
public class DataContext : DbContext
{
    public DataContext(DbContextOptions<DataContext> options) : base(options)
    {

    }
  

   
}
