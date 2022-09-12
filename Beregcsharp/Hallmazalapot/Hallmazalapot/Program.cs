using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hallmazalapot
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double halmazalapot = 0;
            Console.WriteLine("Add meg a víz hőmérsékletét!");
            halmazalapot = Convert.ToDouble(Console.ReadLine());
            if (halmazalapot < 0)
            {
                Console.WriteLine("A beírt hőmérséklet alapján a víz szilárd halmazálapotú, azaz jég.");
            }
            else if (halmazalapot < 100)
            {
                Console.WriteLine("A beírt hőmérséklet alapján a víz folyékony halmazálapotú, azaz víz.");
            }
            else if (halmazalapot > 100)
            {
                Console.WriteLine("A beírt hőmérséklet alapján a víz gáz halmazálapotú, azaz gőz.");
            }
            Console.ReadKey();

        }
    }
}
