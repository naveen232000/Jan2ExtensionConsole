using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Jan2ClassLibrary;
namespace Jan2ExtensionConsole
{
   static class AddCourse
    {
        public static void Csc(this College college)
        {
            Console.WriteLine("Available CSC Course Now!");
        }
        public static void Mtech(this College college)
        {
            Console.WriteLine("Available Mtech Course Now!");
        }
    }
    internal class Program
    {
      
        static void Main(string[] args)
        {
            College college = new College();
            college.Ece();
            college.Eee();
            college.Mech();
            college.Csc();
            college.Mtech();
            Console.ReadLine();
        }
    }
}
