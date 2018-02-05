using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Övning03_04
{
    class Program
    {
        static void Main()
        {
            //Här ska användaren bestämma hur lång sidan ska vara
            Console.WriteLine("\n\tAnge hur lång kubens sida är:\t\t");

            double sida = Convert.ToDouble(Console.ReadLine()); /*Variabeldeklarering*/

            //Här skapas det ett nytt kub-objekt där dess yta och volym beräknas genom en metod med hjälp av sidlängden
            Kub kub1 = new Kub(sida);
            kub1.VolymBeräkning();
            kub1.YteBeräkning();

            Console.ReadKey();

        }
    }
}
