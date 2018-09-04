using Cars.Data.Maps;
using FinalCapstone.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars.Data
{
    public class CarDbContext : DbContext
    {
        public CarDbContext() : base("CarsDb")
        {
            Database.SetInitializer(new DropCreateDatabaseIfModelChanges<CarDbContext>());
        }

        public DbSet<Car> Cars { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new CarMap());
            base.OnModelCreating(modelBuilder);
        }
    }
}
