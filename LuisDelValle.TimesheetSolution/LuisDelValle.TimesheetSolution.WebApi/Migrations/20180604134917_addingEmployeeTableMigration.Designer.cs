﻿// <auto-generated />
using LuisDelValle.TimesheetSolution.WebApi.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace LuisDelValle.TimesheetSolution.WebApi.Migrations
{
    [DbContext(typeof(TimesheetDbContext))]
    [Migration("20180604134917_addingEmployeeTableMigration")]
    partial class addingEmployeeTableMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.3-rtm-10026")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("LuisDelValle.TimesheetSolution.WebApi.Models.Employee", b =>
                {
                    b.Property<string>("EmployeeId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("FirstName")
                        .IsRequired();

                    b.Property<string>("LastName")
                        .IsRequired();

                    b.Property<string>("ManagerId");

                    b.Property<string>("MangerId");

                    b.HasKey("EmployeeId");

                    b.HasIndex("ManagerId");

                    b.HasIndex("MangerId");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("LuisDelValle.TimesheetSolution.WebApi.Models.Timesheet", b =>
                {
                    b.Property<int>("TimesheetId")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("Date");

                    b.Property<string>("EmployeeId");

                    b.Property<double>("Hours");

                    b.HasKey("TimesheetId");

                    b.HasIndex("EmployeeId");

                    b.ToTable("Timesheets");
                });

            modelBuilder.Entity("LuisDelValle.TimesheetSolution.WebApi.Models.Employee", b =>
                {
                    b.HasOne("LuisDelValle.TimesheetSolution.WebApi.Models.Employee", "Manager")
                        .WithMany()
                        .HasForeignKey("ManagerId");

                    b.HasOne("LuisDelValle.TimesheetSolution.WebApi.Models.Employee")
                        .WithMany("ManagedEmployees")
                        .HasForeignKey("MangerId");
                });

            modelBuilder.Entity("LuisDelValle.TimesheetSolution.WebApi.Models.Timesheet", b =>
                {
                    b.HasOne("LuisDelValle.TimesheetSolution.WebApi.Models.Employee")
                        .WithMany("Timesheets")
                        .HasForeignKey("EmployeeId");
                });
#pragma warning restore 612, 618
        }
    }
}
