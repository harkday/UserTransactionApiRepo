using FinancialApiModel.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace FinancialApiDataAccess
{
    public class FinancialApiDbContext : IdentityDbContext<User>
    {
        public FinancialApiDbContext(DbContextOptions<FinancialApiDbContext> options) : base(options) 
        {

        }
        public DbSet<UserTransaction> UserTransactions { get; set; }
    }
}
