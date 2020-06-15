using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW_DesignPatterns.Store
{
	public class ShopAdapter : IWarehouse
	{
		IShop shop;
		public ShopAdapter(IShop shop)
		{
			this.shop = shop;
		}
		public void AddProduct(Product product)
		{
			shop.AddToShelf(product);
		}

		public void EditProduct(Product oldProduct, Product newProduct)
		{
			shop.ReplaceOnShelf(oldProduct, newProduct);
		}

		public Product FindProduct(string BARCODE)
		{
			return shop.LocateProduct(BARCODE);
		}

		public List<Product> GetProducts()
		{
			return shop.CheckAllProducts();
		}

		public void RemoveProduct(Product product)
		{
			shop.RemoveFromShelf(product);
		}
	}
}
