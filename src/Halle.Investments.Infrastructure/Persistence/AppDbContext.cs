using Halle.Investments.Application.Data;
using Microsoft.EntityFrameworkCore;

namespace Halle.Investments.Infrastructure.Persistence;

public class AppDbContext : DbContext, IAppDbContext
{
    public AppDbContext(DbContextOptions options): base(options) { }
    
    //Db set
}