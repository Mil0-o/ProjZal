using Microsoft.AspNetCore.Mvc;
using ProjZal.Logic;
using ProjZal.Models;

namespace ProjZal.Controllers
{
    public class ShopController : Controller
    {
        ShopManager shopManager = new ShopManager();
        public IActionResult Index()
        {
            var shop = shopManager.GetShops();
            return View(shop);
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(ShopModel shopModel)
        {
            shopManager.AddShop(shopModel);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Remove(int id)
        {
            var shop = shopManager.GetShop(id);
            return View(shop);
        }

        [HttpPost]
        public IActionResult RemoveConfirm(int id)
        {
            shopManager.RemoveShop(id);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            var shop = shopManager.GetShop(id);
            return View(shop);
        }

        [HttpPost]
        public IActionResult Edit(ShopModel shop)
        {
            shopManager.UpdateShop(shop);
            return RedirectToAction("Index");
        }
    }
}