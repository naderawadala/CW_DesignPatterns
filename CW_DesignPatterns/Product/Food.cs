using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW_DesignPatterns
{
	public class Food : Product
	{
		public Food(string BARCODE, string Name, double Price) : base(BARCODE, Name, Price) { }

	}
}
