using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4evszak
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Adj meg egy hónap számot és a program megmondja milyen évszakhoz tartozik!");
            string evszakok = "";
            int honapszam = 0;
            int[] honapok = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };

            while (!int.TryParse(Console.ReadLine(), out honapszam) || honapszam > 12 || honapszam < 1) ;

            if (honapszam == honapok[0] || honapszam == honapok[1] || honapszam == honapok[11])
            {
                evszakok = "Tél";
            }
            else if (honapszam == honapok[2] || honapszam == honapok[3] || honapszam == honapok[4])
            {
                evszakok = "Tavasz";
            }
            else if (honapszam == honapok[5] || honapszam == honapok[6] || honapszam == honapok[7])
            {
                evszakok = "Nyár";
            }
            else if (honapszam
                == honapok[8] || honapszam == honapok[9] || honapszam == honapok[10])
            {
                evszakok = "Ősz";
            }
            Console.WriteLine("A megadott hónapod: {0} alapján a jelenlegi évszak: {1}", honapszam, evszak);
            Console.ReadKey();
        }
    }
}
