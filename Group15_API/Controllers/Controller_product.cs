using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group15_API.Controllers
{
	public class Controller_product : Controller<Models.Product>
	{
		public string[] Product_Cards(Type type)
		{
			try
			{
				var list = new List<string>();
				foreach (Models.Product product in collection)
				{
					if (product.GetType()==type)
					{
						list.Add(product.To_HTMLCard());
					}
				}
				return list.ToArray();
			} catch { return null; }
		}
	}
}
