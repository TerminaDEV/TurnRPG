using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurnRPG
{
    public class Player : Battler
    {
        protected override void SetDefaults()
        {
            Name = "Игрок";
            MaxHitPoints = 100;
            Attack = 5;
            Defence = 2;
        }

        public void SetName(string name)
        {
            Name = name;
        }
    }
}
