using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tanks.Classes;

namespace Tanks
{
    class Program
    {

        static void Main(string[] args)
        {
            List<Tank> t34 = new List<Tank>(5);
            List<Tank> panteras = new List<Tank>(5);
            for (int i = 0; i < t34.Capacity; i++)
            {
                Tank temp1 = new Tank($"T-34  " + i);
                t34.Add(temp1);
                Tank temp2 = new Tank($"Pantera " + i);
                panteras.Add(temp2);
            }
            for (int i = 0; i < t34.Count; i++)
            {
                Console.WriteLine(t34[i]);
                Console.WriteLine(panteras[i]);
                Console.WriteLine(t34[i] * panteras[i]);
            }

        }
    }
}
