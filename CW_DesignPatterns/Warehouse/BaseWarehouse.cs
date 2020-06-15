using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW_DesignPatterns.Warehouse
{
	public class BaseWarehouse : IWarehouse
	{
		private List<Product> inventory;
		public BaseWarehouse()
		{
			this.inventory = new List<Product>();
		}

		public void AddProduct(Product product)
		{
			if (product != null)
			{
				inventory.Add(product);
			}
		}

		public void EditProduct(Product oldProduct, Product newProduct)
		{
			oldProduct = FindProduct(oldProduct.BARCODE);
			if (oldProduct != null && newProduct != null)
			{
				inventory.Remove(oldProduct);
				inventory.Add(newProduct);
			}
		}

		public Product FindProduct(string BARCODE)
		{
			return inventory.Find(x => x.BARCODE == BARCODE);
		}

	

		public List<Product> GetProducts()
		{
			return inventory;
		}

		public void PrintProducts()
		{
			for(int i = 0; i < inventory.Count(); i++)
			{
				Console.WriteLine(inventory.ElementAt(i));
			}
		}

		public void RemoveProduct(Product product)
		{
			if (product == FindProduct(product.BARCODE))
			{
				inventory.Remove(product);
			}
		}
	}
}
