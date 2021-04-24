using BaiLam.Models;
using BaiLam.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace BaiLam.Interfaces
{
    public class EmployeeRepository : GenericRepository<Employee>, IEmployeeRepository
    {
        public EmployeeRepository(TimeSheetContext context) : base(context)
        {

        }
        public IEnumerable<Employee> GetPopularEmployee(int count)
        {
            return _context.Employees.OrderByDescending(p => p.EmployeeID).Take(count).ToList();
        }
        public void createEmployee(Employee employee)
        {
            _context.Employees.Add(employee);
        }
    }

}
