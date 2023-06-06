using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurnRPG
{
    public class Goblin : Battler
    {
        protected override void SetDefaults()
        {
            Name = "Гоблин";
            MaxHitPoints = 50;
            Attack = 3;
            Defence = 2;
        }
    }
}
