using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumExo2
{
    class Program
    {
        static void Main(string[] args)
        {
            ConnexionResult connexionResult = new ConnexionResult();
            Console.WriteLine(connexionResult.UserCanConnect("toto", "toto"));
            Console.ReadLine();
        }
    }
}
