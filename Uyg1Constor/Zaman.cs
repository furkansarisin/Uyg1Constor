using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uyg1Constructor
{
    class Zaman
    {
        public int gun;
        public int ay;
        public int yil;
        
        public void zamaniYaz()
        {
            Console.WriteLine("{0}/{1}/{2}", gun, ay, yil);
        }
        public Zaman(int g, int a, int y)
        {
            gun = g;
            ay = a;
            yil = y;
            Console.WriteLine("Parametreli constructor çalıştı");
        }

        public Zaman()
        {
            gun = DateTime.Now.Day;
            ay = DateTime.Now.Month;
            yil = DateTime.Now.Year;
            Console.WriteLine("Parametresiz construcktor çalıştı");
        }
        static Zaman()
        {
            //statik const.larda erişim seviyesi tanımlanmaz(public,private)
            //statik const. parametresiz olmaslı, parametre alamaz(int a )
            Console.WriteLine("statik const. calisti.");
        }
    }
    
}
