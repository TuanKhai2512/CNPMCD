using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BaiLam.Migrations.TimeSheet
{
    public partial class InitCreateBase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Contacts",
                columns: table => new
                {
                    contactID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    Message = table.Column<string>(type: "nvarchar(255)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contacts", x => x.contactID);
                });

            migrationBuilder.CreateTable(
                name: "Projects",
                columns: table => new
                {
                    ProjectID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProjectName = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "date", nullable: false),
                    Deadline = table.Column<DateTime>(type: "date", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Projects", x => x.ProjectID);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    RolesID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RolesName = table.Column<string>(type: "nvarchar(100)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.RolesID);
                });

            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    EmployeeID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleID = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    Phone = table.Column<string>(type: "nvarchar(16)", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(100)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.EmployeeID);
                    table.ForeignKey(
                        name: "FK_Employees_Roles_RoleID",
                        column: x => x.RoleID,
                        principalTable: "Roles",
                        principalColumn: "RolesID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProjectDetails",
                columns: table => new
                {
                    detailID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProjectID = table.Column<int>(type: "int", nullable: false),
                    EmployeeID = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    Mon = table.Column<double>(type: "float", nullable: false),
                    Tue = table.Column<double>(type: "float", nullable: false),
                    Wed = table.Column<double>(type: "float", nullable: false),
                    Thur = table.Column<double>(type: "float", nullable: false),
                    Fri = table.Column<double>(type: "float", nullable: false),
                    HoursWorked = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProjectDetails", x => x.detailID);
                    table.ForeignKey(
                        name: "FK_ProjectDetails_Employees_EmployeeID",
                        column: x => x.EmployeeID,
                        principalTable: "Employees",
                        principalColumn: "EmployeeID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProjectDetails_Projects_ProjectID",
                        column: x => x.ProjectID,
                        principalTable: "Projects",
                        principalColumn: "ProjectID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Projects",
                columns: new[] { "ProjectID", "DateCreated", "Deadline", "ProjectName" },
                values: new object[,]
                {
                    { 1, new DateTime(2021, 4, 25, 0, 31, 3, 21, DateTimeKind.Local).AddTicks(2958), new DateTime(2021, 4, 25, 0, 31, 3, 21, DateTimeKind.Local).AddTicks(2965), "Finding Bug" },
                    { 2, new DateTime(2021, 4, 25, 0, 31, 3, 21, DateTimeKind.Local).AddTicks(3567), new DateTime(2021, 4, 25, 0, 31, 3, 21, DateTimeKind.Local).AddTicks(3569), "Shopping website" },
                    { 3, new DateTime(2021, 4, 25, 0, 31, 3, 21, DateTimeKind.Local).AddTicks(3574), new DateTime(2021, 4, 25, 0, 31, 3, 21, DateTimeKind.Local).AddTicks(3576), "Gym website" }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "RolesID", "RolesName" },
                values: new object[,]
                {
                    { 1, "Developer" },
                    { 2, "Business Analyst" },
                    { 3, "Quality Assurance" }
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "EmployeeID", "Address", "Email", "Name", "Phone", "RoleID" },
                values: new object[] { 1, "Chân cầu 3/2", "trankhai2512.ttk@gmail.com", "Tran Tuan Khai", "0705167772", 1 });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "EmployeeID", "Address", "Email", "Name", "Phone", "RoleID" },
                values: new object[] { 2, "Giữa cầu 3/2", "minhphat.cmp@gmail.com", "Cao Minh Phat", "0705113115", 1 });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "EmployeeID", "Address", "Email", "Name", "Phone", "RoleID" },
                values: new object[] { 3, "Cuối cầu 3/2", "thanhhung.nth@gmail.com", "Nguyen Thanh Hung", "0705117118", 1 });

            migrationBuilder.CreateIndex(
                name: "IX_Employees_RoleID",
                table: "Employees",
                column: "RoleID");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectDetails_EmployeeID",
                table: "ProjectDetails",
                column: "EmployeeID");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectDetails_ProjectID",
                table: "ProjectDetails",
                column: "ProjectID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Contacts");

            migrationBuilder.DropTable(
                name: "ProjectDetails");

            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.DropTable(
                name: "Projects");

            migrationBuilder.DropTable(
                name: "Roles");
        }
    }
}
