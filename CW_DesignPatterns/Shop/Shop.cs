using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW_DesignPatterns.Store
{
	public class Shop
	{
		private List<Product> productsOnShelf;
		public Shop()
		{
			this.productsOnShelf = new List<Product>();
		}

		public void AddToShelf(Product product)
		{
			if (product != null)
			{
				productsOnShelf.Add(product);
			}
		}

		public void ReplaceOnShelf(Product oldProduct, Product newProduct)
		{
			oldProduct = LocateProduct(oldProduct.BARCODE);
			if (oldProduct != null && newProduct != null)
			{
				productsOnShelf.Remove(oldProduct);
				productsOnShelf.Add(newProduct);
			}
		}

		public Product LocateProduct(string BARCODE)
		{
			return productsOnShelf.Find(x => x.BARCODE == BARCODE);
		}

		public List<Product> CheckAllProducts()
		{
			return productsOnShelf;
		}

		public void RemoveFromShelf(Product product)
		{
			if (product == LocateProduct(product.BARCODE))
			{
				productsOnShelf.Remove(product);
			}
		}
		public void PrintProducts()
		{
			for (int i = 0; i < productsOnShelf.Count(); i++)
			{
				Console.WriteLine(productsOnShelf.ElementAt(i));
			}
		}
	}
}
