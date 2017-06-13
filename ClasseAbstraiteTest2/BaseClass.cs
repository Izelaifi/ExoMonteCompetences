using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasseAbstraiteTest2
{
    public abstract class BaseClass
    {
        protected int _x = 100;
        protected int _y = 150;
        public abstract void abstractMethode();
        public abstract int X { get; }
        public abstract int Y { get; }
    }
}
