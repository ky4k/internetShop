using internetShop.Interfaces;
using internetShop.Models;
using Microsoft.AspNetCore.Mvc;

namespace internetShop.Controllers
{
    public class OrderController :Controller
    {
        private readonly IAllOrders _allOrders;
        private readonly ShopCart _shopCart;

        public OrderController(IAllOrders allOrders, ShopCart shopCart)
        {
            _allOrders = allOrders;
            _shopCart = shopCart;
        }

        public IActionResult Checkout()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Checkout(Order order)
        {
            _shopCart.listShopItems = _shopCart.GetCartItems();

            if(_shopCart.listShopItems.Count == 0)
            {
                ModelState.AddModelError("","You must have items");
            }

            if(ModelState.IsValid)
            {
                _allOrders.createOrder(order);
                return RedirectToAction("Complete");
            }

            return View(order);
        }

        public IActionResult Complete()
        {
            ViewBag.Message = "Your order successfully processed";
            return View();
        }
    }
}
