using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryCarteMere
{
    class CarteMereProtable : CarteMere
    {
        public CarteMereProtable(string modele, string chipset) : base(modele, chipset)
        {
            this.modele = modele;
            this.chipset = chipset;
        }

        public override void afficheDetail()
        {
            Console.WriteLine("Carte mère pour protable crée : " + modele + ", chipset integre " + chipset);
        }
    }
}
