using Microsoft.EntityFrameworkCore;

namespace APICinema.Models
{
    public class AccountTypeContext : DbContext
    {
        public AccountTypeContext(DbContextOptions<AccountTypeContext> options) : base(options)
        {
        }

        public DbSet<AccountType> AccountTypes { get; set; }
    }



}
