﻿using Microsoft.AspNetCore.Mvc;
using MVCDemo.Models;
using MVCDemo.Services;



namespace MVCDemo.Controllers
{
    public class PizzaController : Controller
    {
        public IActionResult Index()
        {
            List<Pizza> pizzas = PizzaService.GetAll();



            return View(pizzas);
        }
        public IActionResult List()
        {
            List<Pizza> pizzas = PizzaService.GetAll();



            return View(pizzas);
        }
        public IActionResult Detail(int id)
        {
            Pizza p = PizzaService.Get(id);
            return View(p);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Pizza p)
        {
            PizzaService.Add(p);
            return RedirectToAction("List");
        }

    }
}