using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battleship
{

   

    public abstract class Player
    {
        int[] battleship = new int[3];
        int[] carrier = new int[3];
        int[] destroyer = new int[3];
        int[] submarine = new int[3];


        public void DrawBattleship(int[] coords)
        {
            Console.SetCursorPosition(coords[0] + 7,coords[1]+3);
            Console.Write("█");
            Console.SetCursorPosition(coords[0] + 7, coords[1] + 4);
            Console.Write("█");
            Console.SetCursorPosition(coords[0] + 7, coords[1] + 5);
            Console.Write("█");
            Console.SetCursorPosition(coords[0] + 7, coords[1] + 6);
            Console.Write("█");
        }

        public void DrawCarrier(int[] coords)
        {
            Console.SetCursorPosition(coords[0] + 7, coords[1] + 3);
            Console.Write("█");
            Console.SetCursorPosition(coords[0] + 7, coords[1] + 4);
            Console.Write("█");
            Console.SetCursorPosition(coords[0] + 7, coords[1] + 5);
            Console.Write("█");
            Console.SetCursorPosition(coords[0] + 7, coords[1] + 6);
            Console.Write("█"); 
            Console.SetCursorPosition(coords[0] + 7, coords[1] + 7);
            Console.Write("█");
        }

        public void DrawDestroyer(int[] coords)
        {
            Console.SetCursorPosition(coords[0] + 7, coords[1] + 3);
            Console.Write("█"); 
            Console.SetCursorPosition(coords[0] + 7, coords[1] + 4);
            Console.Write("█");

        }

        public void DrawSubmarine(int[] coords)
        {
            Console.SetCursorPosition(coords[0] + 7, coords[1] + 3);
            Console.Write("█");
            Console.SetCursorPosition(coords[0] + 7, coords[1] + 4);
            Console.Write("█");
            Console.SetCursorPosition(coords[0] + 7, coords[1] + 5);
            Console.Write("█");

        }


        public void SetBattleshipLocation(int[] coords,int rotation)
        {
            battleship[0] = coords[0];
            battleship[1] = coords[1];
            battleship[2] = rotation;

        }

        public void SetDestroyerLocation(int[] coords, int rotation)
        {
            destroyer[0] = coords[0];
            destroyer[1] = coords[1];
            destroyer[2] = rotation;

        }

        public void SetCarrierLocation(int[] coords, int rotation)
        {
            carrier[0] = coords[0];
            carrier[1] = coords[1];
            carrier[2] = rotation;
        }

        public void SetSubmarineLocation(int[] coords, int rotation)
        {
            submarine[0] = coords[0];
            submarine[1] = coords[1];
            submarine[2] = rotation;
        }
    }
}
