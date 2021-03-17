using Microsoft.EntityFrameworkCore;
using VS_CRM.Models;

namespace VS_CRM.Services
{
    public class ASUPSQLContext : DbContext
    {
        public ASUPSQLContext(DbContextOptions<ASUPSQLContext> options)
            : base(options)
        {
            //Database.EnsureCreated();
        }

        public DbSet<Det1> FactoryComponents { get; set; }
    }
}