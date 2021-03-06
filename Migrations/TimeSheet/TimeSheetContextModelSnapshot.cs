// <auto-generated />
using System;
using BaiLam.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BaiLam.Migrations.TimeSheet
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

            modelBuilder.Entity("BaiLam.Models.Contact", b =>
                {
                    b.Property<int>("contactID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Message")
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("contactID");

                    b.ToTable("Contacts");
                });

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

                    b.HasData(
                        new
                        {
                            EmployeeID = 1,
                            Address = "Chân cầu 3/2",
                            Email = "trankhai2512.ttk@gmail.com",
                            Name = "Tran Tuan Khai",
                            Phone = "0705167772",
                            RoleID = 1
                        },
                        new
                        {
                            EmployeeID = 2,
                            Address = "Giữa cầu 3/2",
                            Email = "minhphat.cmp@gmail.com",
                            Name = "Cao Minh Phat",
                            Phone = "0705113115",
                            RoleID = 1
                        },
                        new
                        {
                            EmployeeID = 3,
                            Address = "Cuối cầu 3/2",
                            Email = "thanhhung.nth@gmail.com",
                            Name = "Nguyen Thanh Hung",
                            Phone = "0705117118",
                            RoleID = 1
                        });
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

                    b.HasData(
                        new
                        {
                            ProjectID = 1,
                            DateCreated = new DateTime(2021, 4, 25, 0, 31, 3, 21, DateTimeKind.Local).AddTicks(2958),
                            Deadline = new DateTime(2021, 4, 25, 0, 31, 3, 21, DateTimeKind.Local).AddTicks(2965),
                            ProjectName = "Finding Bug"
                        },
                        new
                        {
                            ProjectID = 2,
                            DateCreated = new DateTime(2021, 4, 25, 0, 31, 3, 21, DateTimeKind.Local).AddTicks(3567),
                            Deadline = new DateTime(2021, 4, 25, 0, 31, 3, 21, DateTimeKind.Local).AddTicks(3569),
                            ProjectName = "Shopping website"
                        },
                        new
                        {
                            ProjectID = 3,
                            DateCreated = new DateTime(2021, 4, 25, 0, 31, 3, 21, DateTimeKind.Local).AddTicks(3574),
                            Deadline = new DateTime(2021, 4, 25, 0, 31, 3, 21, DateTimeKind.Local).AddTicks(3576),
                            ProjectName = "Gym website"
                        });
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

                    b.Property<double>("HoursWorked")
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

                    b.HasData(
                        new
                        {
                            RolesID = 1,
                            RolesName = "Developer"
                        },
                        new
                        {
                            RolesID = 2,
                            RolesName = "Business Analyst"
                        },
                        new
                        {
                            RolesID = 3,
                            RolesName = "Quality Assurance"
                        });
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

            modelBuilder.Entity("BaiLam.Models.Employee", b =>
                {
                    b.Navigation("projectdetails");
                });

            modelBuilder.Entity("BaiLam.Models.Project", b =>
                {
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
