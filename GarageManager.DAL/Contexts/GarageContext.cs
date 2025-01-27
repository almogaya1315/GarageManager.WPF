using GarageManager.Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Media3D;

namespace GarageManager.DAL.Contexts
{
    public class GarageContext : DbContext
    {
        private readonly string _connectionString;

        public GarageContext(DbContextOptions<GarageContext> options) : base(options)
        {
            _connectionString = @"Data Source=DESKTOP-I9GEGTE\MSSQLSERVER1;Initial Catalog=LocalDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;";
        }

        public DbSet<CarEntity> Cars { get; set; }
        public DbSet<CustomerEntity> Customers { get; set; }
        public DbSet<ServiceEntity> Services { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_connectionString);

            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //FLUENT API
            //modelBuilder.

            base.OnModelCreating(modelBuilder);
        }

        public CarEntity GetCar(int id) 
        {
            return Cars.FirstOrDefault(f => f.Id == id);
        }

        public bool SaveCar(CarEntity entity)
        {
            var success = false;
            try
            {
                var car = Cars.FirstOrDefault(f => f.Id == entity.Id);
                car.Name = entity.Name;
                car.Type = entity.Type;
                success = SaveChanges() > 1; // SaveChanges() returns 'The number of state entries written to the database'

            }
            catch (Exception e) 
            {

            }
            return success;
        }
    }
}
