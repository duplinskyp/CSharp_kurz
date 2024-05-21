using System;

namespace Vynimky_a_chybove_hlasenia
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int result = 10 / 0;
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("Chyba: Delenie nulou");
            }
        }
    }
}
