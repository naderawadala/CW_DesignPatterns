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
			Food food = new Food("ADGDGDAREQ", "Abc", 53);

			StoreWarehouse warehouse = new StoreWarehouse(new BaseWarehouse());
		}
	}
}
