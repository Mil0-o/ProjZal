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

            public ShopManager GetShop(int id)
            {
                return null;
            }

            public List<ShopModel> GetShops()
            {
                return null;
            }
        }
}
