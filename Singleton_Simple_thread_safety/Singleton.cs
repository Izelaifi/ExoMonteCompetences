using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton_Simple_thread_safety
{
    public sealed class Singleton
    {
        private static Singleton instance = null;
        private static readonly object padlock = new object();

        Singleton()
        {
        }

        public static Singleton Instance
        {
            get
            {
                lock (padlock)
                {
                    if (instance == null)
                    {
                        instance = new Singleton();
                    }
                    return instance;
                }
            }
        }
    }
}

/*
 * Cette implemntation est bonne car le thread met un verrou sur un objet partagé
 * et ensuite verifi si l'instance a été crée ou non avant de crée l'instance. 
 * le verouillage permet de s'assurer que toutes les lectures se font logiquement après aquisition 
 * de verrou, et le deverrouillage s'assure que toutes les ecritures se font logiquement
 * avant la liberation du verrou. 
 * cette implementation s'assure donc que seul un thread créera une instance. 
 * les performance seront tres touché par cette methode car un verrou est obtenu a chaque fois que
 * l'instance est requise. 
 */
