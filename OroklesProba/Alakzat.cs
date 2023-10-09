using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OroklesProba
{
    public abstract class Alakzat
    {
        public int X { get; private set; }
        public int Y { get; private set; }

        public abstract void Rajzol();

        public Alakzat(int x, int y)
        {
            X = x;
            Y = y;
        }
    }

    public class Teglalap : Alakzat
    {
        public int Szelesseg { get; private set; }
        public int Magassag { get; private set; }

        public Teglalap(int x, int y, int szelesseg, int magassag) : base(x, y)
        {
            Szelesseg = szelesseg;
            Magassag = magassag;
        }

        public override void Rajzol()
        {
            Console.SetCursorPosition(X, Y);
            for (int i = 0; i < Magassag; i++)
            {
                for (int j = 0; j < Szelesseg; j++)
                {
                    if (i == 0 || i == Magassag - 1) Console.Write("+");
                    else
                    {
                        if (j == 0 || j == Szelesseg - 1) Console.Write("+");
                        else Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }
    }

    public sealed class Negyzet : Teglalap
    {
        public Negyzet(int x, int y, int meret) : base(x, y, meret, meret) { }
    }
}
