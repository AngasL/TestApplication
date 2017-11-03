using Amazon.Runtime;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DynamicTest
{
	class Program
	{
		static void Main(string[] args)
		{
			var child = new ChildClass("32345");
			var type = typeof(AmazonServiceClient);
			var properties = type.GetProperty("Credentials", BindingFlags.NonPublic | BindingFlags.Instance);

			var name = child.GetType().BaseType.GetProperty("Name", BindingFlags.NonPublic | BindingFlags.Instance);

			Console.WriteLine(name);
		}
	}

	public abstract class BaseClass
	{
		protected internal string Name { get; set; }
	}

	public class ChildClass : BaseClass
	{
		public ChildClass(string name)
		{
			this.Name = name;
		}
	}
}
