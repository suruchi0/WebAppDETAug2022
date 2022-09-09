using Microsoft.AspNetCore.Mvc;
using MVCDemo.Models;

using MVCDemo.Services;
using MVCDemo.Servics;

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
        public IActionResult Details(int id)
        {
            Pizza p = PizzaService.Get(id);
            return View(p);
        }

        public IActionResult Create()
        {

            return View();
        }
        [HttpPost]
        //public IActionResult Create(int id,string name,int size,decimal price,bool Isglutenfreee)
        public IActionResult Create(Pizza p)
        {
            PizzaService.Add(p);
            return RedirectToAction("List");
        }
        public IActionResult Delete(int id)
        {
            Friend f = FriendService.Get(id);
            if (f != null)
                return View(f);
            else
                return RedirectToAction("List");
        }


        [HttpPost]
        public IActionResult Delete(Pizza p)
        {
            FriendService.Delete(p.Id);
            return RedirectToAction("Delete");
        }
    }
}


