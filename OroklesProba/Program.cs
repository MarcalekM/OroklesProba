using System;

namespace OroklesProba
{
    class Program
    {
        static void Main(string[] args)
        {
            var t = new Teglalap(0, 0, 20, 12);
            var n = new Negyzet(0, 15, 10);
            t.Rajzol();
            n.Rajzol();
            Console.ReadLine();
        }
    }
}
