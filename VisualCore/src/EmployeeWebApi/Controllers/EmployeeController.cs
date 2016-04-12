using System.Linq;
using Microsoft.AspNet.Mvc;
using Microsoft.AspNet.Mvc.Rendering;
using Microsoft.Data.Entity;
using EmployeeWebApi.Models;

namespace EmployeeWebApi.Controllers
{
    public class EmployeeController : Controller
    {
        //private EmployeeDbContext _context;

        //public EmployeeController(EmployeeDbContext context)
        //{
        //    _context = context;    
        //}

        // GET: Employee
        public IActionResult Details()
        {
           return View("Details");
        }

        //// GET: Employee/Details/5
        //public IActionResult Details(int? id)
        //{
        //    if (id == null)
        //    {
        //        return HttpNotFound();
        //    }

        //    EmployeeMasters employeeMasters = _context.Employees.Single(m => m.EmpID == id);
        //    if (employeeMasters == null)
        //    {
        //        return HttpNotFound();
        //    }

        //    return View(employeeMasters);
        //}

        // GET: Employee/Create
        public IActionResult Create()
        {
            return View();
        }

        //// POST: Employee/Create
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public IActionResult Create(EmployeeMasters employeeMasters)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        _context.Employees.Add(employeeMasters);
        //        _context.SaveChanges();
        //        return RedirectToAction("Index");
        //    }
        //    return View(employeeMasters);
        //}

        //// GET: Employee/Edit/5
        //public IActionResult Edit(int? id)
        //{
        //    if (id == null)
        //    {
        //        return HttpNotFound();
        //    }

        //    EmployeeMasters employeeMasters = _context.Employees.Single(m => m.EmpID == id);
        //    if (employeeMasters == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View(employeeMasters);
        //}

        //// POST: Employee/Edit/5
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public IActionResult Edit(EmployeeMasters employeeMasters)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        _context.Update(employeeMasters);
        //        _context.SaveChanges();
        //        return RedirectToAction("Index");
        //    }
        //    return View(employeeMasters);
        //}

        //// GET: Employee/Delete/5
        //[ActionName("Delete")]
        //public IActionResult Delete(int? id)
        //{
        //    if (id == null)
        //    {
        //        return HttpNotFound();
        //    }

        //    EmployeeMasters employeeMasters = _context.Employees.Single(m => m.EmpID == id);
        //    if (employeeMasters == null)
        //    {
        //        return HttpNotFound();
        //    }

        //    return View(employeeMasters);
        //}

        //// POST: Employee/Delete/5
        //[HttpPost, ActionName("Delete")]
        //[ValidateAntiForgeryToken]
        //public IActionResult DeleteConfirmed(int id)
        //{
        //    EmployeeMasters employeeMasters = _context.Employees.Single(m => m.EmpID == id);
        //    _context.Employees.Remove(employeeMasters);
        //    _context.SaveChanges();
        //    return RedirectToAction("Index");
        //}
    }
}
