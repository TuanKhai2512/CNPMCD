using BaiLam.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BaiLam.Seeds
{
    public static class DataSeeding
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Role>().HasData(
                new Role { RolesName = "Developer", RolesID=1},
                new Role { RolesName = "Business Analyst", RolesID = 2},
                new Role { RolesName = "Quality Assurance", RolesID = 3}

            );
            modelBuilder.Entity<Project>().HasData(
                new Project { ProjectName = "Finding Bug", DateCreated = DateTime.Now, Deadline = DateTime.Now, ProjectID=1},
                new Project { ProjectName = "Shopping website", DateCreated = DateTime.Now, Deadline = DateTime.Now, ProjectID = 2},
                new Project { ProjectName = "Gym website", DateCreated = DateTime.Now, Deadline = DateTime.Now, ProjectID = 3}
                );
            modelBuilder.Entity<Employee>().HasData(
                new Employee { Name = "Tran Tuan Khai", Email = "trankhai2512.ttk@gmail.com", Phone = "0705167772", Address = "Chân cầu 3/2", RoleID = 1 ,EmployeeID=1},
                new Employee { Name = "Cao Minh Phat", Email = "minhphat.cmp@gmail.com", Phone = "0705113115", Address = "Giữa cầu 3/2", RoleID = 1, EmployeeID = 2 },
                new Employee { Name = "Nguyen Thanh Hung", Email = "thanhhung.nth@gmail.com", Phone = "0705117118", Address = "Cuối cầu 3/2", RoleID = 1, EmployeeID = 3 }
                );
        }

    }
}
