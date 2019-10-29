namespace Data.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Data.StoreDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(Data.StoreDbContext context)
        {
            var modelPerson = new Models.Person()
            {
                Id = 2,
                FirstName = "Ivan",
                LastName = "Ivanov",
                Email = "ivanIvanov@yahoo.com ",
                Password = "0123"
            };
            context.Customers.AddOrUpdate(x => x.Id,
                new Models.Customer()
                {
                    Person = modelPerson
                }
                );

            context.Departments.AddOrUpdate(x => x.Id, new Models.Department()
            {
                Id = 2,
                Name = "Ivan Ivanov"
            });

            context.Employees.AddOrUpdate(x => x.Id,
                new Models.Employee()
                {
                    Id = 2,
                    EmployeeNumber = "123",
                    PhoneNumber = "0899606063",
                    PersonId = 2,
                    DepartmentId = 2
                });


        }
    }
}
