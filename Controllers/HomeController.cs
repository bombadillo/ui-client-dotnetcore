﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ui_client_dotnetcore.Models;
using ui_client_dotnetcore.Services;

namespace ui_client_dotnetcore.Controllers
{
    public class HomeController : Controller
    {
        private readonly IUIRetrieveService _iUIRetrieverService;

        public HomeController(IUIRetrieveService iUIRetrieverService)
        {
            _iUIRetrieverService = iUIRetrieverService;
        }

        public async Task<IActionResult> Index()
        {
            var ui = await _iUIRetrieverService.RetrieveByToken("2bca1032-4700-45db-975c-30dae65de7ae");

            var viewModel = new ViewModel 
            {
                UI = ui
            };

            return View(viewModel);
        }
        

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}