using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcApplication1.ViewModel;
using MvcApplication1.Models;


namespace MvcApplication1.Controllers
{
    public class TestController : Controller
    {

        public ActionResult GetView()
        {
            Employee emp = new Employee()
            {
                FirstName = "Satish",
                LastName = "Patel",
                Salary = 5000
            };

            EmployeeViewModel empView = new EmployeeViewModel();
            empView.EmployeeName = emp.FirstName + " " + emp.LastName;
            empView.Salary = emp.Salary;

            if (emp.Salary > 10)
            {
                empView.SalaryColor = "Yellow";
            }
            else
            {
                empView.SalaryColor = "Grey";
            }
           

            return View(empView); 
        }

      

    }
}
