using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BaiLam.Models
{
    public class Role
    {
        [Key]
        [Required]
        public int? RolesID { get; set; }
        [Required]
        [Column(TypeName ="nvarchar(100)")]
        public string RolesName { get; set; }
        public virtual ICollection<Employee> employee { get; set; }
    }
}
