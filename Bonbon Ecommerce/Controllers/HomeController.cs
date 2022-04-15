﻿using Bonbon_Ecommerce.Models;
using Bonbon_Ecommerce.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Bonbon_Ecommerce.Controllers
{
    public class HomeController : Controller
    {
        private readonly ICandyRepository _candyRepository;
        public HomeController(ICandyRepository candyRepository)
        {
            _candyRepository = candyRepository;
        }
        public IActionResult Index()
        {
            var homeViewModel = new HomeViewModel
            {
                CandyOnSale = _candyRepository.GetCandyOnSale
            };
            return View(homeViewModel);
        }
    }
}
