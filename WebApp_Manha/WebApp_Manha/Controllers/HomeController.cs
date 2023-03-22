﻿using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebApp_Manha.Models;

namespace WebApp_Manha.Controllers
{
    public class HomeController : Controller
    {
        //atributo da classe HomeControle
        private readonly ILogger<HomeController> _logger;

        //Construtor de classe
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        //Action Result devolve uma tela (Html)
        public IActionResult Index()
        {
            return View();
        }

        //Mais uma Tela no sistema
        public IActionResult BemVindo()
        {
            return View();
        }


        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}