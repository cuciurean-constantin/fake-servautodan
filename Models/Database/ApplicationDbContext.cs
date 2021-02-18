using System.Data.Entity;

namespace InputsOutputs.Models.Database
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext()
            : base("InputsOutputs.Properties.Settings.DefaultConnection")
        {
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }

        public DbSet<DataModel> AllData { get; set; }
    }
}
