using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace _7teloszthato
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Add meg az első számot!");
            int elso = 0;
            int masodik = 0;
            int hibak1 = 0; 
            int hibak2 = 0;
            do
            {
                if (hibak1 > 0)
                { Console.WriteLine("Csak egész számokat adj meg!"); }
                hibak1++;
            } while (!int.TryParse(Console.ReadLine(), out elso));
            Console.WriteLine("Add meg a második számot!");
            do
            {
                if (hibak2 > 0){ 
                Console.WriteLine("Csak egész számokat adj meg!"); }
                hibak2++;
            } 
            while (!int.TryParse(Console.ReadLine(), out masodik));
            if (elso < masodik)
            {
                int x = elso;
                elso = masodik;
                masodik = x;
            }
            int[] szams = new int[elso - masodik + 1];
            for (int i = 0; i < szams.Length; i++)
            {
                szams[i] = masodik;
                masodik++;
            }
            Console.WriteLine("Héttel osztható számok:");
            foreach (var szamok in szams)
            {
                if (szamok % 7 == 0)
                {
                    Console.WriteLine(szamok);
                }
            }
            Console.ReadKey();
        }
    }
}
