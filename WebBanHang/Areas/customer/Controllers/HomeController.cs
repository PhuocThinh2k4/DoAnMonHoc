﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using WebBanHang.Helpers;
using WebBanHang.Models;

namespace WebBanHang.Controllers
{
    [Area("Customer")]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDbContext _db;

        public HomeController(ILogger<HomeController> logger, ApplicationDbContext db)
        {
            _logger = logger;
            _db = db;
        }
        public IActionResult Index(int? page, string textsearch = "")
        {
            var pageIndex = (int)(page != null ? page : 1);
            var pageSize = 8;
            var productList = _db.Products.Include(x => x.Category).Where(p => p.Name.ToLower().Contains(textsearch.ToLower())).ToList();
            var pageSum = productList.Count() / pageSize + (productList.Count() % pageSize > 0 ? 1 : 0);
            ViewBag.pageSum = pageSum;
            ViewBag.pageIndex = pageIndex;
            return View(productList.Skip((pageIndex - 1) * pageSize).Take(pageSize).ToList());

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
