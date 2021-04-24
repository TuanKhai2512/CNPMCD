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
        public Project()
        {
            this.DateCreated = DateTime.Now;
            this.Deadline = DateTime.Now;
        }
        [Key]
        [Required]
        public int ProjectID { get; set; }
        [Column(TypeName = "nvarchar(100)")]
        [Required]
        public string ProjectName { get; set; }
        [DisplayFormat(DataFormatString = "{0:d}")]
        [Column(TypeName ="date")]
        public DateTime DateCreated { get; set; }
        [DisplayFormat(DataFormatString = "{0:d}")]
        [Column(TypeName = "date")]
        public DateTime Deadline { get; set; }

        public virtual ICollection<ProjectDetail> projectdetail { get; set; }
        
    }
}
