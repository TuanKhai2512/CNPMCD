using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BaiLam.Models
{
    public class Employee
    {
        [Key]
        [Required]
        public int EmployeeID { get; set; }
        [Required]
        [ForeignKey("Role")]
        public int RoleID { get; set; }
        [Column(TypeName = "nvarchar(100)")]
        public string Name { get; set; }
        [Column(TypeName = "nvarchar(16)")]
        public string Phone { get; set; }
        [Column(TypeName = "nvarchar(100)")]
        public string Address { get; set; }
        [Column(TypeName = "nvarchar(100)")]
        public string Email { get; set; }

        public virtual Role role { get; set; }
        public virtual ICollection<ProjectDetail> projectdetails { get; set; }
        public virtual TimesheetEntrie entries { get; set; }
    }
}
