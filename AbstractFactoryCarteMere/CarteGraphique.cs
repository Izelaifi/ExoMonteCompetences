using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryCarteMere
{
    public abstract class CarteGraphique
    {
        protected string model;
        protected string memoire;
        protected string chipset;

        public CarteGraphique(string model, string memoire, string chipset)
        {
            this.model = model;
            this.memoire = memoire;
            this.chipset = chipset;

        }

        public abstract void afficheDetail();

    }
}
