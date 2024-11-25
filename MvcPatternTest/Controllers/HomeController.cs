using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using MvcPatternTest.Interfaces;
using MvcPatternTest.Models;
using MvcPatternTest.Models.StaticModels;
using System.Diagnostics;

namespace MvcPatternTest.Controllers
{
    public class HomeController : Controller
    {
        private ICarRepository _carRepository;
        public HomeController(ICarRepository carRepository)
        {
            _carRepository = carRepository;
        }
        public IActionResult Index()
        {
            ViewBag.ListYear = SelectYearListItem.SelectListItems();

            ViewBag.ListCarType = _carRepository.GetCarTypes().Result
                .Select(ct => new SelectListItem
                {
                    Text = ct.Type,
                    Value = ct.Type.ToString()
                }).ToList();

            ViewBag.ListCarCompany = _carRepository.GetCarCompanyNames().Result
                .Select(cn => new SelectListItem
                {
                    Text = cn.CompanyName,
                    Value = cn.CompanyName.ToString()
                }).ToList();

            ViewBag.ListCarModels = _carRepository.GetCarModels().Result
                .Select(cm => new SelectListItem
                {
                    Text = cm.Model,
                    Value = cm.Model.ToString()
                }).ToList();

            ViewBag.ListCarPrices = _carRepository.GetCarPrices().Result
                .Select(cp => new SelectListItem
                {
                    Text = cp.Price.ToString(),
                    Value = cp.Price.ToString()
                }).ToList();

            ViewBag.ListCarConditions = _carRepository.GetCarConditions().Result
                .Select(cc => new SelectListItem
                {
                    Text = cc.Condition,
                    Value = cc.Condition.ToString()
                }).ToList();

            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
