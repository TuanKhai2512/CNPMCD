using BaiLam.Interfaces;
using BaiLam.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BaiLam.Controllers
{
    [Authorize]
    public class AdminController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly TimeSheetContext _context;
        public AdminController(IUnitOfWork unitOfWork, TimeSheetContext context)
        {
            this._unitOfWork = unitOfWork;
            this._context = context;
        }
        public IActionResult Index()
        {
            ViewBag.TotalContact = _context.Contacts.Count();
            ViewBag.TotalUser = _context.Employees.Count();
            ViewBag.TotalProject = _context.Projects.Count();
            ViewModel mymodel = new ViewModel();
            mymodel.emp = _context.Employees.ToList();
            mymodel.pro = _context.Projects.ToList();
            mymodel.con = _context.Contacts.ToList();
            return View(mymodel);
        }

        public ActionResult TableEmployee()
        {
            var employee = _context.Employees.Include(e => e.role);
            return PartialView("_TableEmployee",employee);
        }
    }
}
