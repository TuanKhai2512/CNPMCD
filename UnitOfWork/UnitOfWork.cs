using BaiLam.Interfaces;
using BaiLam.Models;
using BaiLam.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BaiLam.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly TimeSheetContext _context;
        public UnitOfWork(TimeSheetContext context)
        {
            _context = context;
            Employees = new EmployeeRepository(_context);
            Roles = new RoleRepository(_context);
        }
        public IEmployeeRepository Employees { get; private set; }
        public IRoleRepository Roles { get; private set; }
        public int Complete()
        {
            return _context.SaveChanges();
        }
        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
