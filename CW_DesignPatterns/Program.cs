using CW_DesignPatterns.Store;
using CW_DesignPatterns.Warehouse;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW_DesignPatterns
{
	class Program
	{
		static void Main(string[] args)
		{
			FoodWarehouse warehouse = new FoodWarehouse(new BaseWarehouse());
			Food food = new Food("ADGDGDAREQ", "Abc", 53);
			warehouse.AddProduct(new Food("AAA", "AAA", 40));

			Shop store = new Shop();
			IWarehouse storeAdapter = new ShopAdapter(store);

			storeAdapter.AddProduct(new Food("FADF", "EEE", 3441));
		}
	}
}
