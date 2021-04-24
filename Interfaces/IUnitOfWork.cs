using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BaiLam.Interfaces
{
    public interface IUnitOfWork: IDisposable
    {
        IEmployeeRepository Employees { get; }
        IRoleRepository Roles { get; }
        int Complete();
    }
}
