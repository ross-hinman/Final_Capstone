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
        public async Task<ActionResult> GetColor(string color)
        {
            var cars = await _carClient.GetColor(color);
            return View(cars);
        }
        public async Task<ActionResult> GetMake(string make)
        {
            var cars = await _carClient.GetMake(make);
            return View(cars);
        }
        public async Task<ActionResult> GetModel(string model)
        {
            var cars = await _carClient.GetModel(model);
            return View(cars);
        }
        public async Task<ActionResult> GetYear(int year)
        {
            var cars = await _carClient.GetYear(year);
            return View(cars);
        }
    }
}