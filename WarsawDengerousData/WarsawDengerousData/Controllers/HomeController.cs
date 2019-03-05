using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System.Diagnostics;
using WarsawDengerousData.Models;
using WarsawDengerousData.Services;

namespace WarsawDengerousData.Controllers
{
    public class HomeController : Controller
    {
        private readonly IWarsawDataService _apiService;
        private readonly string _defaultResourceId;

        public HomeController(IWarsawDataService apiService, IConfiguration configuration)
        {
            _apiService = apiService;
            _defaultResourceId = configuration["DefaultResourceId"];
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult GetWarsawData()
        {
            var result = _apiService.GetIncydentForAsync("Wola", _defaultResourceId).Result;
            ViewBag.Message = result;
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}