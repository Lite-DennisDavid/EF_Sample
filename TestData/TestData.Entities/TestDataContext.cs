using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestData.Entities
{
    public class TestDataContext : DbContext
    {
        public DbSet<TestDataL1> TestDatas { get; set; }
        public DbSet<MeasurementParameter> MeasTable { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB; Database = TestData; Trusted_Connection=True; Connect Timeout=30;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TestDataL1>()
                .HasData(new
                {
                    TestDataId = 1,
                    SerialNumber = "NJ123456789",
                    CustomerSerialNumber = "Cisco12345",
                    BatchNumber = "J123",
                    PartNumber = "64000236"
                });
        }
    }
}
