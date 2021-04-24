using BaiLam.Interfaces;
using BaiLam.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BaiLam.Repositories
{
    public class RoleRepository : GenericRepository<Role>,IRoleRepository
    {
        public RoleRepository(TimeSheetContext context) : base(context)
        {

        }
    }

}
