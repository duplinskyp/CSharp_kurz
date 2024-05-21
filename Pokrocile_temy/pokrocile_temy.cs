using System;
using System.Collections.Generic;

namespace Pokrocile_temy
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> zoznam = new List<string> { "jeden", "dva", "tri" };
            foreach (string item in zoznam)
            {
                Console.WriteLine(item);
            }
        }
    }
}
