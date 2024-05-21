using System;

namespace OOP
{
    class Osoba
    {
        private string meno;
        private int vek;

        public Osoba(string meno, int vek)
        {
            this.meno = meno;
            this.vek = vek;
        }

        public void Vypis()
        {
            Console.WriteLine("Meno: " + meno + ", Vek: " + vek);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Osoba osoba = new Osoba("Janko", 25);
            osoba.Vypis();
        }
    }
}
