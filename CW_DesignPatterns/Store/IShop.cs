using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW_DesignPatterns.Store
{
	public interface IShop
	{
		void AddToShelf(Product product);
		void ReplaceOnShelf(Product oldProduct, Product newProduct);
		Product LocateProduct(String BARCODE);
		void RemoveFromShelf(Product product);
		List<Product> CheckAllProducts();
	}
}
