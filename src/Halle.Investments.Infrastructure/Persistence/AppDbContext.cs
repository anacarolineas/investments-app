using Microsoft.EntityFrameworkCore;

namespace Halle.Investments.Infrastructure.Persistence;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions options): base(options) { }
    
    //Db set
}