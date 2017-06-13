using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryCarteMere
{
    public abstract class CarteMere
    {
        protected string modele;
        protected string chipset;

        public CarteMere(string modele, string chipset)
        {
            this.modele = modele;
            this.chipset = chipset;
        }

        public abstract void afficheDetail();

    }
}
