using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
namespace Group15_API.Models
{
	[XmlRoot("Entity")]
	public abstract class Entity
	{
		protected int id;

		public Entity()
		{
			id = 0;
		}
		public Entity(int id)
		{
			this.id = id;
		}

		[XmlAttribute("ID")]
		public int ID
		{
			get { return id;}
			set { id = value; }
		}
	}
}
