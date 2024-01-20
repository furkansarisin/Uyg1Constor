using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uyg1Constructor
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = new int();
            Console.WriteLine(a);
            bool b = new bool();
            Console.WriteLine(b);

            // Zaman z1 = new Zaman();
            //z1.gun = 18;
            //z1.ay = 01;
            //z1.yil = 2024;
            //z1.zamaniYaz();

            Zaman z2 = new Zaman(18, 01, 2024);
            z2.zamaniYaz();

            Zaman z3 = new Zaman();
            z3.zamaniYaz();

            Zaman z4 = new Zaman();
            
        }

    }

    

}
