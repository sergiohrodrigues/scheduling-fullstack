﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebApi8_Scheduling.Data;

#nullable disable

namespace WebApi8_Scheduling.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("WebApi8_Scheduling.Models.ClientModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("EnterpriseId")
                        .HasColumnType("int");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Tel")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("EnterpriseId");

                    b.ToTable("Clients");
                });

            modelBuilder.Entity("WebApi8_Scheduling.Models.EnterpriseModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Login")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Enterprise");
                });

            modelBuilder.Entity("WebApi8_Scheduling.Models.SchedulingModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("ClientId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateHour")
                        .HasColumnType("datetime2");

                    b.Property<int>("EnterpriseId")
                        .HasColumnType("int");

                    b.Property<string>("Observation")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ServiceId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ClientId");

                    b.HasIndex("EnterpriseId");

                    b.HasIndex("ServiceId");

                    b.ToTable("Scheduling");
                });

            modelBuilder.Entity("WebApi8_Scheduling.Models.ServiceModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasPrecision(18, 2)
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.ToTable("Services");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Penteado pétala, contendo taltal",
                            Name = "Penteado Pétala",
                            Price = 1099.99m
                        },
                        new
                        {
                            Id = 2,
                            Description = "Penteado rosa, contendo taltal",
                            Name = "Penteado Rosa",
                            Price = 1199.99m
                        },
                        new
                        {
                            Id = 3,
                            Description = "Penteado bouquet, contendo taltal",
                            Name = "Penteado Bouquet",
                            Price = 1299.99m
                        },
                        new
                        {
                            Id = 4,
                            Description = "Penteado premium, contendo taltal",
                            Name = "Penteado Premium",
                            Price = 1399.99m
                        });
                });

            modelBuilder.Entity("WebApi8_Scheduling.Models.ClientModel", b =>
                {
                    b.HasOne("WebApi8_Scheduling.Models.EnterpriseModel", "Enterprise")
                        .WithMany("Clients")
                        .HasForeignKey("EnterpriseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Enterprise");
                });

            modelBuilder.Entity("WebApi8_Scheduling.Models.SchedulingModel", b =>
                {
                    b.HasOne("WebApi8_Scheduling.Models.ClientModel", "Client")
                        .WithMany("Schedulings")
                        .HasForeignKey("ClientId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("WebApi8_Scheduling.Models.EnterpriseModel", "Enterprise")
                        .WithMany("Schedulings")
                        .HasForeignKey("EnterpriseId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("WebApi8_Scheduling.Models.ServiceModel", "Service")
                        .WithMany("Schedulings")
                        .HasForeignKey("ServiceId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Client");

                    b.Navigation("Enterprise");

                    b.Navigation("Service");
                });

            modelBuilder.Entity("WebApi8_Scheduling.Models.ClientModel", b =>
                {
                    b.Navigation("Schedulings");
                });

            modelBuilder.Entity("WebApi8_Scheduling.Models.EnterpriseModel", b =>
                {
                    b.Navigation("Clients");

                    b.Navigation("Schedulings");
                });

            modelBuilder.Entity("WebApi8_Scheduling.Models.ServiceModel", b =>
                {
                    b.Navigation("Schedulings");
                });
#pragma warning restore 612, 618
        }
    }
}
