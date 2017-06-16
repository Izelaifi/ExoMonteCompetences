 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ennum
{
    class Program
    {

        public enum FrencWeekDay
        {
            Lundi,
            Mardi,
            Mercredi,
            Jeudi,
            Vendredi,
            Samedi,
            Dimanche
        }

        static void Main(string[] args)
        {

            const FrencWeekDay Today = FrencWeekDay.Samedi;
            if (IsWeekEndDay(Today))
            {
                Console.WriteLine("Youpi c'est le weekend");
                Console.ReadLine();
            }
            else
                Console.WriteLine("Metro boulot dodo ...");
            Console.ReadLine();


        }
      
        private static bool IsWeekEndDay(FrencWeekDay day)
        {
            if (day == FrencWeekDay.Samedi || day == FrencWeekDay.Dimanche)
            {
                return true;
            }
            return false; 
        }

        
       
    }
}
