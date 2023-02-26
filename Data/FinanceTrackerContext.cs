using Microsoft.EntityFrameworkCore;

using FinanceTrackerAPI.Model;

namespace FinanceTrackerAPI.Data
{
    public class FinanceTrackerContext: DbContext
    {
        public DbSet<User> User { get; set; }

        public  DbSet<CashBook> CashBook { get; set; }

        public DbSet<Entry> Entries { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=FinanceTracker;Integrated Security=True;");
        }

    }
}

//Server=(localdb)\\mssqllocaldb;Database=PersonalFinanceTracker;Trusted_Connection=True;MultipleActiveResultSets=true
