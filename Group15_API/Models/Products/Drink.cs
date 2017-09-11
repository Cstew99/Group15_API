using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group15_API.Models.Products
{
	public class Drink:Product
	{
		public Drink() : base()
		{

		}

		public Drink(int id,string name,double price) : base(id, name, price)
		{

		}
	}
}
