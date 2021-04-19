using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BaiLam.Models
{
    public class TimesheetEntrie
    {
        [Key]
        public int EntryId { get; set; }
        [ForeignKey("Employee")]
        public int EmployeeID { get; set; }
        [ForeignKey("Project")]
        public int ProjectID { get; set; }
        public double HoursWorked { get; set; }
        

        public virtual Employee employee { get; set; }
        public virtual Project project { get; set; }
    }
}
