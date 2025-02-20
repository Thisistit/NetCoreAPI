﻿using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MvcMovie.Models;

namespace MvcMovie.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }
[HttpPost]
public IActionResult Index(String FullNam, String Address)
{
        string strOutput ="xin chào" + FullName +"đến từ" +Address;
        ViewBag.Message =strOutput;
        return View();
}
}
