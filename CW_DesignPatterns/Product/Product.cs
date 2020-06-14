using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW_DesignPatterns
{
	public abstract class Product
	{
		public string BARCODE { get; set; }
		public string Name { get; set; }
		public double Price { get; set; }

		public Product(string BARCODE, string Name, double Price)
		{
			this.BARCODE = BARCODE;
			this.Name = Name;
			this.Price = Price;
		}

	}
}
