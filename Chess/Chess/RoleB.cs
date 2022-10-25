using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess
{
    class RoleB : Characteristic
    {
        int LorR;
        public RoleB(int _LorR)
        {
            HP = 70;
            MP = 25;
            ATK = 20;
            ATK_Range = 2;
            MOVE_Range = 2;
            character = "法師";
        }
    }
}
