using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SigletonTest
{
	class Program
	{
		static void Main(string[] args)
		{
		}
	}

	public sealed class Singleton
	{
		private static Singleton instance;

		private Singleton()
		{

		}

		public static Singleton GetInstance()
		{
			if(instance==null)
			{
				instance = new Singleton();
			}

			return instance;
		}
	}

	public class SubSingleton : Singleton
	{

	}
}
