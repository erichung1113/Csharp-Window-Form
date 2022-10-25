using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess
{
    class RoleA : Characteristic
    {
        public RoleA(int _LorR)
        {
            HP = 100;
            MP = 15;
            ATK = 30;
            ATK_Range = 1;
            MOVE_Range = 2;
            character = "戰士";
        }
    }
}
