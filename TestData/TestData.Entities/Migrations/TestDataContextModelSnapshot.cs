﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TestData.Entities;

namespace TestData.Entities.Migrations
{
    [DbContext(typeof(TestDataContext))]
    partial class TestDataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.1-servicing-10028")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("TestData.Entities.MeasurementParameter", b =>
                {
                    b.Property<int>("MeasurementParameterId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("Max");

                    b.Property<double>("Min");

                    b.Property<string>("Name");

                    b.Property<string>("Pass");

                    b.Property<string>("Source");

                    b.Property<string>("Units");

                    b.HasKey("MeasurementParameterId");

                    b.ToTable("MeasTable");
                });

            modelBuilder.Entity("TestData.Entities.TestDataL1", b =>
                {
                    b.Property<int>("TestDataId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("BatchNumber");

                    b.Property<string>("CustomerSerialNumber");

                    b.Property<string>("PartNumber");

                    b.Property<string>("SerialNumber");

                    b.Property<int?>("TestMeasMeasurementParameterId");

                    b.HasKey("TestDataId");

                    b.HasIndex("TestMeasMeasurementParameterId");

                    b.ToTable("TestDatas");

                    b.HasData(
                        new
                        {
                            TestDataId = 1,
                            BatchNumber = "J123",
                            CustomerSerialNumber = "Cisco12345",
                            PartNumber = "64000236",
                            SerialNumber = "NJ123456789"
                        });
                });

            modelBuilder.Entity("TestData.Entities.TestDataL1", b =>
                {
                    b.HasOne("TestData.Entities.MeasurementParameter", "TestMeas")
                        .WithMany()
                        .HasForeignKey("TestMeasMeasurementParameterId");
                });
#pragma warning restore 612, 618
        }
    }
}
