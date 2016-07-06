using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExplicitInterfaceImplementation
{
    class Program
    {
        static void Main(string[] args)
        {
            Base b1 = new B();
            Console.WriteLine((b1.GetName()));

            IA b2 = new B();
            Console.WriteLine(b2.GetName());
        }
    }

    public interface IA
    {
        string GetName();
    }

    public class Base : IA
    {
        public virtual string GetName()
        {
            return "this is from base class";
        }
    }

    public class B : Base, IA
    {
        public override string GetName()
        {
            return "this is from override method";
        }

        string IA.GetName()
        {
            return "this is from Explicit interface";
        }
    }
}
