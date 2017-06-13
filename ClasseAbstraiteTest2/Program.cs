using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasseAbstraiteTest2
{
    class Program
    {
        static void Main(string[] args)
        {
            DerivedCkasse o = new DerivedCkasse();
            o.abstractMethode();
            Console.WriteLine("x={0}, y={1}", o.X, o.Y);
            Console.ReadLine();
        }
    }
}
