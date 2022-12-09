using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class OrderController : Controller
    {
        private IOrderRepository repository;
        private Cart cart;
        public OrderController(IOrderRepository repoService, Cart cartService)
        {
            repository = repoService;
            cart = cartService;
        }
        public IActionResult  Checkout()
        {
            ViewBag.ToplamUcret = CartBilgileri.Cart.ComputeTotalValue().ToString("c");
            if (CartBilgileri.Cart.ComputeTotalValue() == 0)
            {
                return RedirectToPage("/Cart"); ;
            }
            else
            {
                return View(new Order());
            }
        }
        [HttpPost]
        public IActionResult Checkout(Order order)
        {
            ViewBag.ToplamUcret = CartBilgileri.Cart.ComputeTotalValue().ToString("c");
            if (CartBilgileri.Cart.Lines.Count() == 0)
            {
                ViewBag.Durum = null;
                ModelState.AddModelError("Üzgünüm, Sepenitiniz boş!", "Üzgünüm, Sepenitiniz boş!");
                return RedirectToPage("/Cart");
            }
            else if (ModelState.IsValid)
            {
                ViewBag.Durum = true;
                order.Lines = cart.Lines.ToArray();
                repository.SaveOrder(order);
                CartBilgileri.Cart.Clear();
                return RedirectToPage("/Completed", new { orderId = order.OrderID });
            }
            else
            {
                return View();
            }
        }
    }
}
