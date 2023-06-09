﻿using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TP4Bis_Yukelson_steimberg.Models;

namespace TP4Bis_Yukelson_steimberg.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        ViewBag.ListaPaises = Info.ListarPaises();
        ViewBag.cant = Info.CantPaises();
        return View();
    }

    public IActionResult DetallePais(int idPais)
    {
        ViewBag.id = idPais;
        ViewBag.Pais = Info.DetallePais(idPais);
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
