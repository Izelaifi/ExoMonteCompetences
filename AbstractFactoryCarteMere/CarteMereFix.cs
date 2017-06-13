using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryCarteMere
{
    public class CarteMereFix : CarteMere
    {
        public CarteMereFix(string modele, string chipset) : base(modele, chipset) 
        {
            this.modele = modele;
            this.chipset = chipset;
        }

        public override void afficheDetail()
        {
            Console.WriteLine("Carte mère pour fix crée : " + modele + ", chipset integre : " + chipset);
        }
    }
}
