using CW_DesignPatterns.Iterator;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW_DesignPatterns.Warehouse
{
	public class FoodWarehouse: IteratorAggregate
	{
		private IWarehouse warehouse;
		public FoodWarehouse(IWarehouse warehouse)
		{
			this.warehouse = warehouse;
		}

		public void AddProduct(Product product)
		{
			warehouse.AddProduct(product);
		}

		public void EditProduct(Product oldProduct, Product newProduct)
		{
			warehouse.EditProduct(oldProduct, newProduct);
		}

		public Product FindProduct(string BARCODE)
		{
			return warehouse.FindProduct(BARCODE);
		}

		public List<Product> GetProducts()
		{
			return warehouse.GetProducts();
		}

		public void RemoveProduct(Product product)
		{
			warehouse.RemoveProduct(product);
		}
		public void PrintProducts()
		{
			warehouse.PrintProducts();
		}
		public override IEnumerator GetEnumerator()
		{
			return new FoodIterator(this);
		}
	}
}
