using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battleship
{
    class Board
    {
        public void DrawBoard(int x, int y)
        {
            string sqr = "■";

            Console.SetCursorPosition(x, y);
            Console.Write($"     1  2  3  4  5  6  7  8  9 10 11 12 13 14 15 16 17 18 19 20");
            Console.SetCursorPosition(x, y + 1);
            Console.Write($"   ╔════════════════════════════════════════════════════════════╗");
            Console.SetCursorPosition(x, y + 2);
            Console.Write($" A ║ {sqr}  {sqr}  {sqr}  {sqr}  {sqr}  {sqr}  {sqr}  {sqr}  {sqr}  {sqr}  {sqr}  {sqr}  {sqr}  {sqr}  {sqr}  {sqr}  {sqr}  {sqr}  {sqr}  {sqr} ║");
            Console.SetCursorPosition(x, y + 3);
            Console.Write($" B ║ {sqr}  {sqr}  {sqr}  {sqr}  {sqr}  {sqr}  {sqr}  {sqr}  {sqr}  {sqr}  {sqr}  {sqr}  {sqr}  {sqr}  {sqr}  {sqr}  {sqr}  {sqr}  {sqr}  {sqr} ║");
            Console.SetCursorPosition(x, y + 4);
            Console.Write($" C ║ {sqr}  {sqr}  {sqr}  {sqr}  {sqr}  {sqr}  {sqr}  {sqr}  {sqr}  {sqr}  {sqr}  {sqr}  {sqr}  {sqr}  {sqr}  {sqr}  {sqr}  {sqr}  {sqr}  {sqr} ║");
            Console.SetCursorPosition(x, y + 5);
            Console.Write($" D ║ {sqr}  {sqr}  {sqr}  {sqr}  {sqr}  {sqr}  {sqr}  {sqr}  {sqr}  {sqr}  {sqr}  {sqr}  {sqr}  {sqr}  {sqr}  {sqr}  {sqr}  {sqr}  {sqr}  {sqr} ║");
            Console.SetCursorPosition(x, y + 6);
            Console.Write($" E ║ {sqr}  {sqr}  {sqr}  {sqr}  {sqr}  {sqr}  {sqr}  {sqr}  {sqr}  {sqr}  {sqr}  {sqr}  {sqr}  {sqr}  {sqr}  {sqr}  {sqr}  {sqr}  {sqr}  {sqr} ║");
            Console.SetCursorPosition(x, y + 7);
            Console.Write($" F ║ {sqr}  {sqr}  {sqr}  {sqr}  {sqr}  {sqr}  {sqr}  {sqr}  {sqr}  {sqr}  {sqr}  {sqr}  {sqr}  {sqr}  {sqr}  {sqr}  {sqr}  {sqr}  {sqr}  {sqr} ║");
            Console.SetCursorPosition(x, y + 8);
            Console.Write($" G ║ {sqr}  {sqr}  {sqr}  {sqr}  {sqr}  {sqr}  {sqr}  {sqr}  {sqr}  {sqr}  {sqr}  {sqr}  {sqr}  {sqr}  {sqr}  {sqr}  {sqr}  {sqr}  {sqr}  {sqr} ║");
            Console.SetCursorPosition(x, y + 9);
            Console.Write($" H ║ {sqr}  {sqr}  {sqr}  {sqr}  {sqr}  {sqr}  {sqr}  {sqr}  {sqr}  {sqr}  {sqr}  {sqr}  {sqr}  {sqr}  {sqr}  {sqr}  {sqr}  {sqr}  {sqr}  {sqr} ║");
            Console.SetCursorPosition(x, y + 10);
            Console.Write($" I ║ {sqr}  {sqr}  {sqr}  {sqr}  {sqr}  {sqr}  {sqr}  {sqr}  {sqr}  {sqr}  {sqr}  {sqr}  {sqr}  {sqr}  {sqr}  {sqr}  {sqr}  {sqr}  {sqr}  {sqr} ║");
            Console.SetCursorPosition(x, y + 11);
            Console.Write($" J ║ {sqr}  {sqr}  {sqr}  {sqr}  {sqr}  {sqr}  {sqr}  {sqr}  {sqr}  {sqr}  {sqr}  {sqr}  {sqr}  {sqr}  {sqr}  {sqr}  {sqr}  {sqr}  {sqr}  {sqr} ║");
            Console.SetCursorPosition(x, y + 12);
            Console.Write($" K ║ {sqr}  {sqr}  {sqr}  {sqr}  {sqr}  {sqr}  {sqr}  {sqr}  {sqr}  {sqr}  {sqr}  {sqr}  {sqr}  {sqr}  {sqr}  {sqr}  {sqr}  {sqr}  {sqr}  {sqr} ║");
            Console.SetCursorPosition(x, y + 13);
            Console.Write($" L ║ {sqr}  {sqr}  {sqr}  {sqr}  {sqr}  {sqr}  {sqr}  {sqr}  {sqr}  {sqr}  {sqr}  {sqr}  {sqr}  {sqr}  {sqr}  {sqr}  {sqr}  {sqr}  {sqr}  {sqr} ║");
            Console.SetCursorPosition(x, y + 14);
            Console.Write($" M ║ {sqr}  {sqr}  {sqr}  {sqr}  {sqr}  {sqr}  {sqr}  {sqr}  {sqr}  {sqr}  {sqr}  {sqr}  {sqr}  {sqr}  {sqr}  {sqr}  {sqr}  {sqr}  {sqr}  {sqr} ║");
            Console.SetCursorPosition(x, y + 15);
            Console.Write($" N ║ {sqr}  {sqr}  {sqr}  {sqr}  {sqr}  {sqr}  {sqr}  {sqr}  {sqr}  {sqr}  {sqr}  {sqr}  {sqr}  {sqr}  {sqr}  {sqr}  {sqr}  {sqr}  {sqr}  {sqr} ║");
            Console.SetCursorPosition(x, y + 16);
            Console.Write($" O ║ {sqr}  {sqr}  {sqr}  {sqr}  {sqr}  {sqr}  {sqr}  {sqr}  {sqr}  {sqr}  {sqr}  {sqr}  {sqr}  {sqr}  {sqr}  {sqr}  {sqr}  {sqr}  {sqr}  {sqr} ║");
            Console.SetCursorPosition(x, y + 17);
            Console.Write($" P ║ {sqr}  {sqr}  {sqr}  {sqr}  {sqr}  {sqr}  {sqr}  {sqr}  {sqr}  {sqr}  {sqr}  {sqr}  {sqr}  {sqr}  {sqr}  {sqr}  {sqr}  {sqr}  {sqr}  {sqr} ║");
            Console.SetCursorPosition(x, y + 18);
            Console.Write($" Q ║ {sqr}  {sqr}  {sqr}  {sqr}  {sqr}  {sqr}  {sqr}  {sqr}  {sqr}  {sqr}  {sqr}  {sqr}  {sqr}  {sqr}  {sqr}  {sqr}  {sqr}  {sqr}  {sqr}  {sqr} ║");
            Console.SetCursorPosition(x, y + 19);
            Console.Write($" R ║ {sqr}  {sqr}  {sqr}  {sqr}  {sqr}  {sqr}  {sqr}  {sqr}  {sqr}  {sqr}  {sqr}  {sqr}  {sqr}  {sqr}  {sqr}  {sqr}  {sqr}  {sqr}  {sqr}  {sqr} ║");
            Console.SetCursorPosition(x, y + 20);
            Console.Write($" S ║ {sqr}  {sqr}  {sqr}  {sqr}  {sqr}  {sqr}  {sqr}  {sqr}  {sqr}  {sqr}  {sqr}  {sqr}  {sqr}  {sqr}  {sqr}  {sqr}  {sqr}  {sqr}  {sqr}  {sqr} ║");
            Console.SetCursorPosition(x, y + 21);
            Console.Write($" T ║ {sqr}  {sqr}  {sqr}  {sqr}  {sqr}  {sqr}  {sqr}  {sqr}  {sqr}  {sqr}  {sqr}  {sqr}  {sqr}  {sqr}  {sqr}  {sqr}  {sqr}  {sqr}  {sqr}  {sqr} ║");
            Console.SetCursorPosition(x, y + 22);
            Console.Write($"   ╚════════════════════════════════════════════════════════════╝");


        }
    }
}
