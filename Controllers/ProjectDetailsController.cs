using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using BaiLam.Models;
using Microsoft.AspNetCore.Authorization;
using ClosedXML.Excel;
using System.IO;

namespace BaiLam.Controllers
{
    [Authorize]
    public class ProjectDetailsController : Controller
    {
        private readonly TimeSheetContext _context;

        public ProjectDetailsController(TimeSheetContext context)
        {
            _context = context;
        }

        // GET: ProjectDetails
        public async Task<IActionResult> Index(int? id)
        {

            if (id == null) { return NotFound(); }
            ViewBag.ProID = id;
            var timeSheetContext = _context.ProjectDetails.Where(m => m.ProjectID == id).Include(p => p.employee).Include(p => p.project).Include(e => e.employee.role).Where(m => m.ProjectID == id);
            return View(await timeSheetContext.ToListAsync());
        }

        // GET: ProjectDetails/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            ViewBag.Url = _context.ProjectDetails.Where(p=>p.detailID==id).Include(m=>m.project).FirstOrDefault().ProjectID;
            var projectDetail = await _context.ProjectDetails
                .Include(p => p.employee)
                .Include(p => p.project)
                .FirstOrDefaultAsync(m => m.detailID == id);
            if (projectDetail == null)
            {
                return NotFound();
            }

            return View(projectDetail);
        }

        // GET: ProjectDetails/Create
        public IActionResult Create(int? id)
        {
            if (id == null) { return NotFound(); }
            ViewBag.returnUrl = Request.Headers["Referer"].ToString();
            ViewData["EmployeeID"] = new SelectList(_context.Employees, "EmployeeID", "Name");
            ViewData["ProjectID"] = new SelectList(_context.Projects.Where(p => p.ProjectID == id), "ProjectID", "ProjectName");
            return View();
        }

        // POST: ProjectDetails/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("detailID,ProjectID,EmployeeID,Name,Description,Mon,Tue,Wed,Thur,Fri,HoursWorked")] ProjectDetail projectDetail)
        {
            if (ModelState.IsValid)
            {
                _context.Add(projectDetail);
                await _context.SaveChangesAsync();

                return RedirectToAction(nameof(Index), new { id = projectDetail.ProjectID });
            }
            ViewBag.returnUrl = Request.Headers["Referer"].ToString();
            ViewData["EmployeeID"] = new SelectList(_context.Employees, "EmployeeID", "Name", projectDetail.EmployeeID);
            ViewData["ProjectID"] = new SelectList(_context.Projects, "ProjectID", "ProjectName", projectDetail.ProjectID);
            return View(projectDetail);
        }

        // GET: ProjectDetails/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var projectDetail = await _context.ProjectDetails.FindAsync(id);
            if (projectDetail == null)
            {
                return NotFound();
            }
            ViewBag.EmployeeName = _context.ProjectDetails.Where(p => p.detailID == id).Include(e=>e.employee).FirstOrDefault().employee.Name;
            ViewBag.returnUrl = Request.Headers["Referer"].ToString();
            ViewData["EmployeeID"] = new SelectList(_context.Employees, "EmployeeID", "Name", projectDetail.EmployeeID);
            ViewData["ProjectID"] = new SelectList(_context.Projects, "ProjectID", "ProjectName", projectDetail.ProjectID);
            return View(projectDetail);
        }

        // POST: ProjectDetails/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("detailID,ProjectID,EmployeeID,Name,Description,Mon,Tue,Wed,Thur,Fri,HoursWorked")] ProjectDetail projectDetail)
        {
            if (id != projectDetail.detailID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(projectDetail);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProjectDetailExists(projectDetail.detailID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index),new { id=projectDetail.ProjectID});
            }
            ViewBag.returnUrl = Request.Headers["Referer"].ToString();
            
            ViewData["EmployeeID"] = new SelectList(_context.Employees, "EmployeeID", "Name", projectDetail.EmployeeID);
            ViewData["ProjectID"] = new SelectList(_context.Projects, "ProjectID", "ProjectName", projectDetail.ProjectID);
            return View(projectDetail);
        }

        // GET: ProjectDetails/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            ViewBag.returnUrl = Request.Headers["Referer"].ToString();

            var projectDetail = await _context.ProjectDetails
                .Include(p => p.employee)
                .Include(p => p.project)
                .FirstOrDefaultAsync(m => m.detailID == id);
            if (projectDetail == null)
            {
                return NotFound();
            }

            return View(projectDetail);
        }

        // POST: ProjectDetails/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var projectDetail = await _context.ProjectDetails.FindAsync(id);
            _context.ProjectDetails.Remove(projectDetail);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index), new { id = projectDetail.ProjectID });
        }

        private bool ProjectDetailExists(int id)
        {
            return _context.ProjectDetails.Any(e => e.detailID == id);
        }

        public IActionResult Excel(int? id)
        {
            if (id == null) { return NotFound(); }
            var Employee = _context.ProjectDetails.Where(p => p.detailID == id).Include(e=>e.employee).Include(r=>r.employee.role).Include(b=>b.project).FirstOrDefault();

            using (var workbook = new XLWorkbook())
            {

                var worksheet = workbook.Worksheets.Add(Employee.employee.Name);
                var currentRow = 1;
                worksheet.Cell(currentRow, 1).Value = "Name";
                worksheet.Cell(currentRow, 2).Value = "Role";
                worksheet.Cell(currentRow, 3).Value = "Monday";
                worksheet.Cell(currentRow, 4).Value = "Tuesday";
                worksheet.Cell(currentRow, 5).Value = "Wednesday ";
                worksheet.Cell(currentRow, 6).Value = "Thursday  ";
                worksheet.Cell(currentRow, 7).Value = "Friday  ";
                worksheet.Cell(currentRow, 8).Value = "Hours Worked";
                worksheet.Cell(currentRow, 9).Value = "Project";
                worksheet.Cell(currentRow, 10).Value = "Description";

                currentRow++;
                worksheet.Cell(currentRow, 1).Value = Employee.employee.Name;
                worksheet.Cell(currentRow, 2).Value = Employee.employee.role.RolesName;
                worksheet.Cell(currentRow, 3).Value = Employee.Mon;
                worksheet.Cell(currentRow, 4).Value = Employee.Tue;
                worksheet.Cell(currentRow, 5).Value = Employee.Wed;
                worksheet.Cell(currentRow, 6).Value = Employee.Thur;
                worksheet.Cell(currentRow, 7).Value = Employee.Fri;
                worksheet.Cell(currentRow, 8).Value = Employee.HoursWorked;
                worksheet.Cell(currentRow, 9).Value = Employee.project.ProjectName;
                if (Employee.project.ProjectName == null)
                {
                    worksheet.Cell(currentRow, 10).Value = "";
                }
                else
                {
                    worksheet.Cell(currentRow, 10).Value = Employee.Description;
                }
                    
              

                using (var stream = new MemoryStream())
                {
                    workbook.SaveAs(stream);
                    var content = stream.ToArray();

                    return File(
                        content,
                        "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet",
                        "users.xlsx");
                }
            }
        }
    }
}
