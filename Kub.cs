using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Övning03_04
{
    class Kub
    {
        public double sida { get; set; }
        public double Volym { get; set; }
        public double Yta { get; set; }

        public Kub(double sida)
        {
            this.sida = sida;
        }
        public void VolymBeräkning()
        {
            Volym = (Math.Pow(sida, 3));
            Console.WriteLine("\tKubens Volym är {0}", Volym);
        }
        public void YteBeräkning()
        {
            Yta = 6 * (Math.Pow(sida, 2));
            Console.WriteLine("\tKubens Yta är {0}", Yta);
        }
    }
}
