using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW_DesignPatterns
{
	public interface IWarehouse
	{
		List<Product> GetProducts();
		void AddProduct(Product product);
		Product FindProduct(String BARCODE);
		void EditProduct(Product oldProduct, Product newProduct);
		void RemoveProduct(Product product);
		void PrintProducts();
	}
}
