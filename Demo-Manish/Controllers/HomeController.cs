using Demo_Manish.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Demo_Manish.Controllers
{
    public class HomeController : Controller
    {

        private readonly IEmployeeRepo _employeerepo;

        public HomeController(IEmployeeRepo employeerepo)
        {
            _employeerepo = employeerepo;
        }
        public IActionResult Index()
        {
            List<EmployeeModel> list = _employeerepo.EmployeeGet();
            return View(list);
        }
        public ActionResult AddEmployee()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddEmployee(EmployeeModel model)
        {
            if (ModelState.IsValid)
            {
                var res = _employeerepo.AddEmployee(model);

                //if (res.Status == "success")
                //{
                //    TempData["massage"] = "Employee Add successfully";
                //    return RedirectToAction("Index");
                //}
            }
            return RedirectToAction("Index");
        }
        public ActionResult update(int id)
        {
            EmployeeModel employee = _employeerepo.GetEmployeeinfo(id);
            return View(employee);
        }
        [HttpPost]
        public ActionResult update(EmployeeModel model)
        {
            if (ModelState.IsValid)
            {
                var res = _employeerepo.UpdateEmployee(model);

                //if (res.Status == "success")
                //{
                //    TempData["massage"] = "Employee update successfully";
                //    return RedirectToAction("Index");
                //}
            }
            return View();
        }
        public IActionResult details(int id)
        {
            EmployeeModel employee = _employeerepo.GetEmployeeinfo(id);
            return View(employee);
        }
        
        public IActionResult Delete(int id)
        {
            var res = _employeerepo.DeleteEmployee(id);
            //if (res.Status == "success")
            //{
            //    TempData["massage"] = "Employee delete successfully";
            //    return RedirectToAction("Index");
            //}
            return RedirectToAction("Index");
        }
    }
}
