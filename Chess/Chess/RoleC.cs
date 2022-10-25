using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess
{
    class RoleC : Characteristic
    {
        int LorR;
        public RoleC(int _LorR)
        {
            HP = 90;
            MP = 10;
            ATK = 30;
            ATK_Range = 3;
            MOVE_Range = 1;
            character = "遊俠";
        }
    }
}
