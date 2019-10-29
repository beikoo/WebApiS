using Data.Migrations;
using Models;
using System;
using System.Data.Entity;
using System.Linq;

namespace Data
{


    public class StoreDbContext : DbContext
    {

        public StoreDbContext()
            : base("StoreDbContext")
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<StoreDbContext, Configuration>());

        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Person> People { get; set; }
        public DbSet<Photo> Photos { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<SalesOrder> Sales { get; set; }

        public override int SaveChanges()
        {
            this.ApplyEntityChanges();
            return base.SaveChanges();
        }

        private void ApplyEntityChanges()
        {
            var entries = this.ChangeTracker.Entries().Where(x => x.Entity is BaseModel && x.State == EntityState.Added || x.State == EntityState.Deleted || x.State == EntityState.Modified).ToList();

            foreach (var entry in entries)
            {
                var entity = (BaseModel)entry.Entity;

                if (entry.State == EntityState.Added)
                {
                    entity.CreatedAt = DateTime.Now;
                }
                else if (entry.State == EntityState.Deleted)
                {
                    entity.DeletedAt = DateTime.Now;

                }
                else
                {
                    entity.ModifiedAt = DateTime.Now;
                }
            }
        }
    }
}