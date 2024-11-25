using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MvcPatternTest.Interfaces;
using MvcPatternTest.Models;

namespace CarAdmin.Controllers
{

    public class AdminController : Controller
    {
        private readonly ICarRepository _carRepository;
        public AdminController(ICarRepository carRepository)
        {
            _carRepository = carRepository;
        }
        public IActionResult LoginPage()
        {
            return View();
        }

        public IActionResult CheckLogin(string login, string pass)
        {
            if (login == "admin" && pass == "admin")
            {
                return RedirectToAction("Index", "Admin");
            }
            return RedirectToAction("LoginPage", "Admin");
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult CreateCar()
        
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreateCar(Car car)
        {
            try
            {
                _carRepository.AddCar(car);
                return RedirectToAction("Index", "Admin");
            }
            catch (Exception ex)
            {
                return View(ex.Message);
            }
        }
        public IActionResult ReadCar()
        {
            try
            {
                var result = _carRepository.GetCars();
                return View(result);
            }
            catch(Exception ex)
            {
                return View(ex.Message);    
            }
        }
    }
}
