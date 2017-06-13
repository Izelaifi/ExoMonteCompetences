using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryCarteMere
{
    class CarteGraphiqueFix : CarteGraphique
    {
        public CarteGraphiqueFix(string model, string memoire, string chipset) : base(model, memoire, chipset)
        {
            this.model = model;
            this.memoire = memoire;
            this.chipset = chipset;
        }

        public override void afficheDetail()
        {
            Console.WriteLine("Carte graphique fix crée : " + model + "," + memoire + "MO de Ram, chipset integre : " + chipset);
        }
    }
}
