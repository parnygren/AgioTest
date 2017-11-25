using AgioTest.Models;
using AgioTest.ViewModels;
using System.Net;
using System.Web.Mvc;

namespace AgioTest.Controllers
{
    public class EmployeesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public EmployeesController()
        {
            _context = new ApplicationDbContext();
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(EmployeeFormViewModel viewModel)
        {
            if (!ModelState.IsValid)
                return View("Create", viewModel);

            var employee = new Employee()
            {
                FirstName = viewModel.FirstName,
                LastName = viewModel.LastName,
                PersonalNumber = viewModel.PersonalNumber,
                EmployeeNumber = viewModel.EmployeeNumber
            };

            _context.Employees.Add(employee);
            _context.SaveChanges();

            return RedirectToAction("Index", "Home");
        }

        public ActionResult Edit(int id = 0)
        {
            Employee employee = _context.Employees.Find(id);
            if (employee == null)
                return HttpNotFound();

            return View(employee);
        }

        [HttpPost]
        public ActionResult Edit(Employee employee)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _context.Entry(employee).State = System.Data.Entity.EntityState.Modified;
                    _context.SaveChanges();

                    return RedirectToAction("Index", "Home");
                }
                return View(employee);
            }
            catch
            {
                return View();
            }
        }

        public ActionResult Delete(int? id)
        {
            Employee employee = new Employee();
            try
            {
                if (ModelState.IsValid)
                {
                    if (id == null)
                        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);

                    employee = _context.Employees.Find(id);
                    if (employee == null) return HttpNotFound();

                    _context.Employees.Remove(employee);
                    _context.SaveChanges();
                    return RedirectToAction("Index", "Home");
                }
                return View(employee);
            }
            catch
            {
                return View();
            }
        }
    }
}