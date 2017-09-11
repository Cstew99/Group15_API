using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
namespace Group15_API.Models.Products
{
	public class Pizza : Product
	{
		protected string type_field;

		public Pizza() : base()
		{
			type_field = string.Empty;
		}
		public Pizza(int id,string name,double price,string type):base(id,name,price)
		{
			this.type_field = type;
		}

		[XmlAttribute("Type")]
		public string Type
		{
			get { return type_field; }
			set { type_field = value; }
		}
	}
}
