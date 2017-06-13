using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasseAbstraiteTest2
{
    class DerivedCkasse : BaseClass
    {
       

        public override void abstractMethode()
        {
            _x++;
            _y++;
        }
        public override int X
        {
            get
            {
                return _x + 10;
            }
        }
        public override int Y
        {
            get
            {
                return _y + 10;
            }
        }
    }
}
