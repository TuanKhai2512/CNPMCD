using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BaiLam.Models
{
    public class TimeSheetContext:DbContext
    {
        public TimeSheetContext()
        {

        }
        public TimeSheetContext(DbContextOptions<TimeSheetContext> options) : base(options)
        {

        }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<ProjectDetail> ProjectDetails { get; set; }
        /*public DbSet<TimesheetEntrie> TimesheetEntries { get; set; }*/
        
    }
}
