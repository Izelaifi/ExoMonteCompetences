using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton_Non_thread_safe
{
   public sealed class Singleton
    {
        private static Singleton instance = null;

        private Singleton()
        {
        }

        public static Singleton Instance
        {
            get
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

/*
 * Movaise utilisation du code : 
 * Deux Thread differents pourrai tous les deux evalué le test et 
 * obtenir vrai comme résultat, les deux créeront donc une instance 
 * ce qui viole le pattern singleton. 
     */
