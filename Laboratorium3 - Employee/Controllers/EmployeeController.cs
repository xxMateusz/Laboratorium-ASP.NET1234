using Microsoft.AspNetCore.Mvc;
using Laboratorium3___Employee.Models;

namespace Laboratorium3___Employee.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly IEmployeeService _employeeService;

        public EmployeeController(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }

        public IActionResult Index()
        {
            return View(_employeeService.FindAll());
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Employee model)
        {
            if (ModelState.IsValid) // validation of "Employee model"
            {
                _employeeService.Add(model);
                return RedirectToAction("Index");
            }

            return View(model); // show form again - with errors
        }

        [HttpGet]
        public IActionResult Update(int id)
        {
            return View(_employeeService.FindById(id));
        }

        [HttpPost]
        public IActionResult Update(Employee model)
        {
            if (ModelState.IsValid)
            {
                _employeeService.Update(model);
                return RedirectToAction("Index");
            }

            return View();
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            return View(_employeeService.FindById(id));
        }

        [HttpPost]
        public IActionResult Delete(Employee model)
        {
            _employeeService.Delete(model.Id);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Details(int id)
        {
            return View(_employeeService.FindById(id));
        }
    }
}
