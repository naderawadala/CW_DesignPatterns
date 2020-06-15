using CW_DesignPatterns.Iterator;
using CW_DesignPatterns.Warehouse;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW_DesignPatterns
{
	class FoodIterator : ObjectIterator
	{
		private FoodWarehouse collection;
		private int position;

		public FoodIterator(FoodWarehouse warehouse)
		{
			this.collection = warehouse;
			this.position = -1;
		}

		public override object Current()
		{
			return this.collection.GetProducts()[position];
		}

		public override int Key()
		{
			return this.position;
		}

		public override bool MoveNext()
		{
			int updatedPosition = this.position + 1;
			if (updatedPosition < this.collection.GetProducts().Count)
			{
				this.position = updatedPosition;
				return true;
			}
			return false;
		}

		public override void Reset()
		{
			this.position = 0;
		}
	}
}
