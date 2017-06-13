using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryCarteMere
{
    public class OrdinateurProtable : Ordinateur
    {
        public CarteGraphique creeCarteGraphique(string modele, string memoire, string chipset)
        {
            return new CarteGraphiqueProtable(modele, memoire, chipset);
            
        }

        public CarteMere creeCarteMere(string modele, string chipset)
        {
            return new CarteMereProtable(modele, chipset);
                
        }
    }
}
