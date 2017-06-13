using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryCarteMere
{
    class CarteGraphiqueProtable : CarteGraphique
    {
        public CarteGraphiqueProtable(string model, string memoire, string chipset) : base(model, memoire, chipset)
        {
            this.model = model;
            this.chipset = chipset;
            this.memoire = memoire;

        }

        public override void afficheDetail()
        {
            Console.WriteLine("Carte graphique pour portable crée : " + model + "," + memoire + "MO de Ram, chipset integre : " + chipset);

        }
    }
}
