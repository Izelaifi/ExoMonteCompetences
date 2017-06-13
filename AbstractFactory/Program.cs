using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            AbstractFactory factory1 = new ConcreteFactory1();
            Client C1 = new Client(factory1);
            C1.run();



            AbstractFactory factory2 = new ConcretFactory2();
            Client C2 = new Client(factory2);
            C2.run();

            Console.ReadLine();
        }
    }
}
