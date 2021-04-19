using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BaiLam.Models
{
    public class Project
    {
        [Key]
        [Required]
        public int ProjectID { get; set; }
        [Column(TypeName = "nvarchar(100)")]
        [Required]
        public string ProjectName { get; set; }
        [Column(TypeName ="date")]
        public DateTime DateCreated { get; set; }
        [Column(TypeName = "date")]
        public DateTime Deadline { get; set; }
        public virtual ICollection<ProjectDetail> projectdetail { get; set; }
        public virtual TimesheetEntrie entries { get; set; }
    }
}
