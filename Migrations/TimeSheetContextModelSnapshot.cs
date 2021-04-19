﻿// <auto-generated />
using System;
using BaiLam.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BaiLam.Migrations
{
    [DbContext(typeof(TimeSheetContext))]
    partial class TimeSheetContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.5")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("BaiLam.Models.Employee", b =>
                {
                    b.Property<int>("EmployeeID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(16)");

                    b.Property<int>("RoleID")
                        .HasColumnType("int");

                    b.HasKey("EmployeeID");

                    b.HasIndex("RoleID");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("BaiLam.Models.Project", b =>
                {
                    b.Property<int>("ProjectID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("date");

                    b.Property<DateTime>("Deadline")
                        .HasColumnType("date");

                    b.Property<string>("ProjectName")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("ProjectID");

                    b.ToTable("Projects");
                });

            modelBuilder.Entity("BaiLam.Models.ProjectDetail", b =>
                {
                    b.Property<int>("detailID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("EmployeeID")
                        .HasColumnType("int");

                    b.Property<double>("Fri")
                        .HasColumnType("float");

                    b.Property<double>("Mon")
                        .HasColumnType("float");

                    b.Property<int>("ProjectID")
                        .HasColumnType("int");

                    b.Property<double>("Thur")
                        .HasColumnType("float");

                    b.Property<double>("Tue")
                        .HasColumnType("float");

                    b.Property<double>("Wed")
                        .HasColumnType("float");

                    b.HasKey("detailID");

                    b.HasIndex("EmployeeID");

                    b.HasIndex("ProjectID");

                    b.ToTable("ProjectDetails");
                });

            modelBuilder.Entity("BaiLam.Models.Role", b =>
                {
                    b.Property<int?>("RolesID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("RolesName")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("RolesID");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("BaiLam.Models.TimesheetEntrie", b =>
                {
                    b.Property<int>("EntryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("EmployeeID")
                        .HasColumnType("int");

                    b.Property<double>("HoursWorked")
                        .HasColumnType("float");

                    b.Property<int>("ProjectID")
                        .HasColumnType("int");

                    b.HasKey("EntryId");

                    b.HasIndex("EmployeeID")
                        .IsUnique();

                    b.HasIndex("ProjectID")
                        .IsUnique();

                    b.ToTable("TimesheetEntries");
                });

            modelBuilder.Entity("BaiLam.Models.Employee", b =>
                {
                    b.HasOne("BaiLam.Models.Role", "role")
                        .WithMany("employee")
                        .HasForeignKey("RoleID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("role");
                });

            modelBuilder.Entity("BaiLam.Models.ProjectDetail", b =>
                {
                    b.HasOne("BaiLam.Models.Employee", "employee")
                        .WithMany("projectdetails")
                        .HasForeignKey("EmployeeID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BaiLam.Models.Project", "project")
                        .WithMany("projectdetail")
                        .HasForeignKey("ProjectID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("employee");

                    b.Navigation("project");
                });

            modelBuilder.Entity("BaiLam.Models.TimesheetEntrie", b =>
                {
                    b.HasOne("BaiLam.Models.Employee", "employee")
                        .WithOne("entries")
                        .HasForeignKey("BaiLam.Models.TimesheetEntrie", "EmployeeID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BaiLam.Models.Project", "project")
                        .WithOne("entries")
                        .HasForeignKey("BaiLam.Models.TimesheetEntrie", "ProjectID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("employee");

                    b.Navigation("project");
                });

            modelBuilder.Entity("BaiLam.Models.Employee", b =>
                {
                    b.Navigation("entries");

                    b.Navigation("projectdetails");
                });

            modelBuilder.Entity("BaiLam.Models.Project", b =>
                {
                    b.Navigation("entries");

                    b.Navigation("projectdetail");
                });

            modelBuilder.Entity("BaiLam.Models.Role", b =>
                {
                    b.Navigation("employee");
                });
#pragma warning restore 612, 618
        }
    }
}
