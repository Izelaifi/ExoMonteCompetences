﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata.Starcraft
{
    public class Marine
    {

        public int Hp { get; private set; }
        public int Speed { get; private set; }
        public int Attack { get; private set; }

        public Marine()
        {
            Hp = 50;
            Speed = 7;
            Attack = 3;
        }

        public void GetDamage(int damage)
        {

        }
    }
}