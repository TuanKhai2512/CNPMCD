using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BaiLam.Models
{
    public class ViewModel
    {
        public IEnumerable<Employee> emp { get; set; }
        public IEnumerable<Project> pro { get; set; }
        public IEnumerable<Contact> con { get; set; }
    }
}
