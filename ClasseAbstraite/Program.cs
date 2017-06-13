using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasseAbstraite
{
    class Program
    {
        static void Main(string[] args)
        {
            Square sq = new Square(12);
            Console.WriteLine("Area of the square = {0}", sq.Area());
            Console.ReadLine();
        }
    }
}

/* une classe abstraite ne pas pas etre instanciée
 * la classe abstraite peut contenir des methodes et accesseurs abstraits. 
 * une classe non abstraite doit inclure une implementation réelles de toutes les methodes et accesseur abstrait
 * 
 * une Methode abstraite est implicitement une methodes virtuelle. 
 * les methodes abstraite ne sont autorisées uniquement dans les classe abstraite
 * 
*/
