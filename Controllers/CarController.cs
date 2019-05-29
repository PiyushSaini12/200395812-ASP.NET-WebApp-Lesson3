using ASP.NET_Lesson_Final_200395812.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASP.NET_Lesson_Final_200395812.Controllers
{
    public class CarController : Controller
    {
        // GET: Car
        List<Car> carList = new List<Car>()
        {
            new Car {Id=1, Brand = "BMW", Model="I8", Type="Coupe", Year = 2020},
            new Car {Id=2, Brand = "BMW", Model="I6", Type="HatchBack", Year = 2021},
            new Car {Id=3, Brand = "BMW", Model="I7", Type="Sedan", Year = 2022}
        };
        // GET: Car
        public ActionResult Index()
        {
            return View(carList);

        }

        public ActionResult Details(int? id)
        {
            if (id == null || id > carList.Count)
            {
                return Content("Invalid car id");
            }
            var ind = Convert.ToInt32(id) - 1;
            var car = carList[ind];

            return View(car);
        }
    }
}