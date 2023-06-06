using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurnRPG
{
    public class Game
    {
        public static Game GetInstance() 
        {
            Instance ??= new Game(); 
            return Instance;
        }
        private static Game Instance;
        private Game() { }

        public void Start()
        { 
            
        }
    }
}
