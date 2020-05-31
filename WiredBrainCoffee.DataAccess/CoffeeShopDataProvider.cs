using System.Collections.Generic;
using WiredBrainCoffee.DataAccess.Model;

namespace WiredBrainCoffee.DataAccess
{
    class CoffeeShopDataProvider
    {
        public IEnumerable<CoffeeShop> LoadCoffeeShops()
        {
            yield return new CoffeeShop { location = "Cocoa", beansInStockInKg = 12 };
            yield return new CoffeeShop { location = "Titusville", beansInStockInKg = 23 };
            yield return new CoffeeShop { location = "Orlando", beansInStockInKg = 62 };
        }
    }
}
