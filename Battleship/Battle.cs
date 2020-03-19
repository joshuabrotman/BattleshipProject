using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battleship
{
    class Battle
    {

        public Battle()
        {

        }

        //player chooses where to place their ships
        //must not overlap
        //must rotate?
        //ships are destroyer (2) Submarine(3) Battleship(4) carrier(5)
        //for each turn, show opponents board, obscured to their knowledge (and their own board?)
        //keep score by tracking which ships have been destroyed


        public void Start()
        {
            Console.SetWindowSize(100, 56);
            Board Board1 = new Board();
            Board1.DrawBoard(2, 1);
            Board1.DrawBoard(2, 26);
            Console.ReadKey();
        }
        
    }
}
