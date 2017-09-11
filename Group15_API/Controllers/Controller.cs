using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;
using Group15_API.Models;
namespace Group15_API.Controllers
{
	public abstract class Controller<T>
	{
		protected List<T> collection;
		protected XmlSerializer serializer = new XmlSerializer(typeof(List<T>));

		public Controller()
		{
			collection = new List<T>();
		}
		public Controller(IEnumerable<T> newCollection):this()
		{
			foreach (T item in newCollection)
			{
				collection.Add(item);
			}
		}

		public virtual void Add(T T)
		{
			collection.Add(T);
		}
		public virtual void Remove(T T)
		{
			collection.Remove(T);
		}
		public virtual void RemoveAt(int index)
		{
			collection.RemoveAt(index);
		}
		public virtual void Clear()
		{
			collection.Clear();
		}

		public int IndexOf(T T)
		{
			return collection.IndexOf(T);
		}
		public bool Contains(T T)
		{
			return collection.Contains(T);
		}

		[XmlIgnore]
		public int Count
		{
			get { return collection.Count; }
		}
		[XmlElement]
		public List<T> Collection
		{
			get { return collection; }
			set { collection = value; }
		}

		public virtual void Save(string filepath)
		{
			try
			{
				using (FileStream stream=new FileStream(filepath, FileMode.Create))
				{
					serializer.Serialize(stream, collection);
				}
			} catch { }
		}
		public virtual void Load(string filepath)
		{
			try
			{
				using (FileStream stream=new FileStream(filepath, FileMode.Open))
				{
					collection = (List<T>)serializer.Deserialize(stream);
				}
			} catch { collection = new List<T>(); }
		}

	}
}
