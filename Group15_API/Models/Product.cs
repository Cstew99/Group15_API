using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
namespace Group15_API.Models
{
	public abstract class Product:Entity
	{
		protected string name;
		protected double price;

		public Product():base()
		{
			name = string.Empty;
			price = 0;
		}
		public Product(int id,string name,double price):base(id)
		{
			this.name = name;
			this.price = price;
		}

		[XmlAttribute("Name")]
		public string Name
		{
			get { return name; }
			set { name = value; }
		}

		[XmlAttribute("Price")]
		public double Price
		{
			get { return price; }
			set { price = value; }
		}
	}
}
