using CQRSBasic.DataModel;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace CQRSBasic.CommandData
{
    public class CommandDbContext : DbContext
    {
        public CommandDbContext() : base("Name=CQRSBasicDb") { }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<ProductCategory> ProductCategories { get; set; }

        public DbSet<Product> Products { get; set; }
    }
}
