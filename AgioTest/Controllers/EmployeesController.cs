using AgioTest.Models;
using System.Web.Mvc;
using AgioTest.ViewModels;

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
            {
                return HttpNotFound();
            }

            return View(employee);
        }
    }
}