using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryCarteMere
{
    public interface Ordinateur
    {
        CarteMere creeCarteMere(string modele, string chipset);

        CarteGraphique creeCarteGraphique(string modele, string memoire, string chipset);
    }
}
