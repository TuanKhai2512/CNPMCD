using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace BaiLam.Models
{
    public class ProjectDetail
    {
        [Key]
        public int detailID { get; set; }
        [Required]
        [ForeignKey("Project")]
        public int ProjectID { get; set; }
        [Required]
        [ForeignKey("Employee")]
        public int EmployeeID { get; set; }
        [Column(TypeName ="nvarchar(100)")]
        public string Description { get; set; }
        public double Mon { get; set; }
        public double Tue { get; set; }
        public double Wed { get; set; }
        public double Thur { get; set; }
        public double Fri { get; set; }


        public virtual Project project { get; set; }
        public virtual Employee employee { get; set; }
    }
}
