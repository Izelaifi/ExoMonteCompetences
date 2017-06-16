
using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqExo2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Querry #1
            List<int> numbers = new List<int>() { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            IEnumerable<int> filteringQuery = from num in numbers
                                              where num < 3 || num > 7
                                              select num;


            foreach (var num in filteringQuery)
            {
                Console.WriteLine(num);
            }
            Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");

            //Querry #2
            IEnumerable<int> OrderingQuerry = from num in numbers
                                              where num < 3 || num > 7
                                              orderby num ascending
                                              select num;
            foreach (var num in OrderingQuerry)
            {
                Console.WriteLine(num);
            }
            Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");



            //Querry #3
            String[] groupinQuery = { "Brocoli", "Carrots", "caarley", "cabbage", "beans"};
           var  QueryGroupFood = from item in groupinQuery
                                                                  group item by item[0];

            foreach (var num in QueryGroupFood)
            {
                Array test = num.ToArray();
                for (int i = 0; i < test.Length; i++)
                {
                    Console.WriteLine(test.GetValue(i).ToString());

                }
                
            }


            Console.ReadKey();
        }
    }
}
