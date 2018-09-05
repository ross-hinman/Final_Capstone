using FinalCapstone.Models;
using MVC.Cars.Clients;
using MVC.Cars.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace MVC.Cars.Controllers
{
    public class CarController : Controller
    {
        private readonly CarClient _carClient;
        public CarController()
        {
            _carClient = new CarClient();
        }
        public ActionResult Index()
        {
            return View();
        }
        public async Task<ActionResult> GetCars()
        {
            var cars = await _carClient.GetCars();
            return View(cars);
        }
    }
}