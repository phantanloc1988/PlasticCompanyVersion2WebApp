﻿
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PlasticCompany.Areas.Admin.Services.BannerServices;


namespace PlasticCompany.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IBanner _bannerServices;
        public HomeController(ILogger<HomeController> logger, IBanner bn)
        {
            _logger = logger;
            _bannerServices = bn;
        }

        public IActionResult Index()
        {
            ViewBag.Banner = _bannerServices.GetAll();
            return View();
        }



    
    }
}
