using System;
using System.IO;

namespace Praca_so_subormi
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "example.txt";
            if (File.Exists(path))
            {
                string[] lines = File.ReadAllLines(path);
                foreach (string line in lines)
                {
                    Console.WriteLine(line);
                }
            }
        }
    }
}
