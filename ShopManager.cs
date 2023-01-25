using ProjZal.Models;
using System.Collections.Generic;
using System.Linq;

namespace ProjZal.Logic
{
    public class ShopManager
    {
        public ShopManager AddShop(ShopModel shopModel)
        {
            using (var context = new ShopContext())
            {
                context.Shops.Add(shopModel);
                context.SaveChanges();
            }
            return this;
        }

        public ShopManager RemoveShop(int id)
        {
            using (var contex = new ShopContext())
            {
                var ShopToDelete = contex.Shops.SingleOrDefault(x => x.ID == id);
                contex.Shops.Remove(ShopToDelete);
                contex.SaveChanges();
            }
            return this;
        }

        public ShopManager UpdateShop(ShopModel shopModel)
        {
            using (var context = new ShopContext())
            {
                context.Shops.Update(shopModel);
                context.SaveChanges();
            }
            return this;
        }

        public ShopManager ChangeNameOfShop(int id, string newName)
        {
            using (var context = new ShopContext())
            {
                var itemToChangeName = context.Shops.Single(x => x.ID == id);
                if (string.IsNullOrEmpty(newName))
                {
                    newName = "Brak Nazwy";
                }
                itemToChangeName.Name = newName;
                this.UpdateShop(itemToChangeName);
            }
            return this;
        }

        public ShopModel GetShop(int id)
        {
            using (var context = new ShopContext())
            {
                var shop = context.Shops.Single(x => x.ID == id);
                return shop;
            }

        }

        public List<ShopModel> GetShops()
        {
            using (var context = new ShopContext())
            {
                var ItemList = context.Shops.ToList();
                return ItemList;
            }
        }
    }
}
