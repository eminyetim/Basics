using System.Security.Cryptography;
using Basics.Models;
using Microsoft.AspNetCore.Mvc;

namespace Basics.Controllers
{
    public class EmployeeController : Controller
    {

        public IActionResult Index1()
        {
            string message = $"Hello World {DateTime.Now.ToString()}";
            return View("Index1",message); 
        }        

        public ViewResult Index2()  // View Sayfası Doner
        {
            var names = new string[]
            {
                "Ahmet",
                "Muhammed",
                "Can"
            };
            return View(names);
        }

        public IActionResult Index3() // Content ve View geri dönüş değeri olur
        {
            var list = new List<Employee>
            {
                new Employee(){Id = 1 , FirstName = "Muhammed Emin" , LastName="Yetim",Age=20},
                new Employee(){Id = 2 , FirstName = "Azra" , LastName="Yetim",Age=19},
                new Employee(){Id = 3 , FirstName = "Ceren" , LastName="Yetim",Age=1}

                
            };         
            return View("Index3",list);
        }

    }
}