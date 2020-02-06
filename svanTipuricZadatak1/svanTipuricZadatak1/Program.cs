using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace svanTipuricZadatak1
{
    
    class Program
    {
        static void Main(string[] args)
        {
            double a;
            double b;
            double c;
            double prosjek;
            Console.WriteLine("Upisite a: " );
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Upisite b: " );
            b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Upisite c: " );
            c = Convert.ToDouble(Console.ReadLine());

            prosjek = (a + b + c) / 3;
            Console.WriteLine("Prosjek je: " + prosjek);

            Console.ReadKey();
        }

    }
}
