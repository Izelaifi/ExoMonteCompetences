using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryCarteMere
{
    class Program
    {
        static void Main(string[] args)
        {

            Ordinateur ordinateur;

            //Stock
            CarteGraphique[] carteGraphique = new CarteGraphique[10];
            CarteMere[] carteMere = new CarteMere[10];


            //Commande CLient
            Console.WriteLine("Vous voulez commander un " +
                "ordinateur fix(1) ou portable (2) ?");
            String choix = Console.ReadLine();

            if (choix.Equals("1"))
            {
                ordinateur = new OrdinateurFix();

            }
            else
            {
                ordinateur = new OrdinateurProtable();
            }

            carteGraphique[0] = ordinateur.creeCarteGraphique("modele1", "512", "chipset32");
            carteMere[0] = ordinateur.creeCarteMere("modele1", "chipset32");

            Console.WriteLine("Votre commande à été pris en charge.");
            carteGraphique[0].afficheDetail();
            carteMere[0].afficheDetail();
            Console.ReadKey();
        }
    }
}
