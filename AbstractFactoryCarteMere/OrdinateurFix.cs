using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryCarteMere
{
    public class OrdinateurFix : Ordinateur
    {
        public CarteGraphique creeCarteGraphique(string modele, string memoire, string chipset)
        {
            return new CarteGraphiqueFix(modele, memoire, chipset);
        }

        public CarteMere creeCarteMere(string modele, string chipset)
        {
            return new CarteMereFix(modele, chipset);
            
        }
    }
}
