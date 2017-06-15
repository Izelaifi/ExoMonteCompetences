using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LestypesPremitif
{
    class Program
    {
        static void Main(string[] args)
        {

            int [] numbers ;
            // creation d'un tableau de type int avec 7 lignes.

            string[,] names ;
            // Creation d'un tableau de chaine de carractère  de deux dimensions.

            byte[][] score;
            // Creation d'un tableau de tableau. 


            //instation des tableau deja crée : car un la déclaration plus haut ne permet pas de crée de tableau car ce sont des objets et des objets et les objet doivent etre instancié. 
            // instation 

            numbers = new int[7];
            names = new string[5, 4];

            // Instation d'un tableau de tableau : 
            score = new byte[5][];
            for (int i = 0; i < score.Length; i++)
            {
                score[i] = new byte[4];
            }


            //Single-Dimmensional array
            int[] number = new int[5];

            // Multi dim array
            string[,] name = new string[5, 4];

            //Array of array
            byte[][] scores = new byte[5][];

            //Create the jagged (dechictée) array
            for (int i = 0; i < scores.Length; i++)
            {
                scores[i] = new byte[i + 3];
            }
            //print lenght of each row
            for (int i = 0; i <scores.Length; i++)
            {
                Console.WriteLine("Lenght of row {0} is {1}", i, scores[i].Length);
                Console.ReadLine();
            }
            //name = {new string[] { "un", "deux", "Trois", "Quarte", "cinq" }, new string[] { "un", "deux", "Trois", }};

            //foreach (var namesof in name)
           
            //{
            //    Console.WriteLine(namesof);
            //    Console.ReadLine();
            //}


        }
    }
}
