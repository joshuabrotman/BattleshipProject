using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battleship
{
    class Board
    {
        public Player1 FirstPlayer;
        public Player2 SecondPlayer;

        public int[,] p1ShipLocations = new int[19, 19];
        public int[,] p2ShipLocations = new int[19, 19];

 

        public Board()
        {

        

        }
        public int[] ConvertCoords(string userInput)
        {
            int[] convertedCoords = new int[2];
            string firstCoord = userInput.Substring(1);
            string secondCoord = userInput.Substring(0, 1).ToLower();


            convertedCoords[0] = Convert.ToInt32(firstCoord)*3;

            switch (secondCoord)
            {
                case "a":
                    convertedCoords[1] = 0;
                    break;
                case "b":
                    convertedCoords[1] = 1;
                    break;
                case "c":
                    convertedCoords[1] = 2;
                    break;
                case "d":
                    convertedCoords[1] = 3;
                    break;
                case "e":
                    convertedCoords[1] = 4;
                    break;
                case "f":
                    convertedCoords[1] = 5;
                    break;
                case "g":
                    convertedCoords[1] = 6;
                    break;
                case "h":
                    convertedCoords[1] = 7;
                    break;
                case "i":
                    convertedCoords[1] = 8;
                    break;
                case "j":
                    convertedCoords[1] = 9;
                    break;
                case "k":
                    convertedCoords[1] = 10;
                    break;
                case "l":
                    convertedCoords[1] = 11;
                    break;
                case "m":
                    convertedCoords[1] = 12;
                    break;
                case "n":
                    convertedCoords[1] = 13;
                    break;
                case "o":
                    convertedCoords[1] = 14;
                    break;
                case "p":
                    convertedCoords[1] = 15;
                    break;
                case "q":
                    convertedCoords[1] = 16;
                    break;
                case "r":
                    convertedCoords[1] = 17;
                    break;
                case "s":
                    convertedCoords[1] = 18;
                    break;
                case "t":
                    convertedCoords[1] = 19;
                    break;
            }
            Console.SetCursorPosition(67, 2);
            Console.WriteLine(convertedCoords[0] + " , " + convertedCoords[1]);
            return convertedCoords;
        }

        public void SetShipLocations()
        {
            string userInput;
            FirstPlayer = new Player1();
            SecondPlayer = new Player2();

            Console.SetCursorPosition(67, 24);
            Console.WriteLine("Player 1 :\n");

            //enter Destroyer            
            Console.SetCursorPosition(67, 25);
            Console.WriteLine("Enter Destroyer Coords: ");
            Console.SetCursorPosition(67, 26);
            userInput = Console.ReadLine();
            FirstPlayer.SetDestroyerLocation(ConvertCoords(userInput),0);
            Console.SetCursorPosition(67, 26);
            Console.WriteLine("                         ");

            FirstPlayer.DrawDestroyer(ConvertCoords(userInput));
            
            //enter Sub
            Console.SetCursorPosition(67, 25);
            Console.WriteLine("Enter Submarine Coords: ");
            Console.SetCursorPosition(67, 26);
            userInput = Console.ReadLine();
            FirstPlayer.SetSubmarineLocation(ConvertCoords(userInput), 0);
            Console.SetCursorPosition(67, 26);
            Console.WriteLine("                         ");

            FirstPlayer.DrawSubmarine(ConvertCoords(userInput));

            //enter Battleship
            Console.SetCursorPosition(67, 25);
            Console.WriteLine("Enter Battleship Coords:");
            Console.SetCursorPosition(67, 26);
            userInput = Console.ReadLine();
            FirstPlayer.SetBattleshipLocation(ConvertCoords(userInput), 0);
            Console.SetCursorPosition(67, 26);
            Console.WriteLine("                         ");

            FirstPlayer.DrawBattleship(ConvertCoords(userInput));

            //enter Carrier
            Console.SetCursorPosition(67, 25);
            Console.WriteLine("Enter Carrier Coords:   ");
            Console.SetCursorPosition(67, 26);
            userInput = Console.ReadLine();
            FirstPlayer.SetCarrierLocation(ConvertCoords(userInput), 0);
            Console.SetCursorPosition(67, 26);
            Console.WriteLine("                         ");

            FirstPlayer.DrawCarrier(ConvertCoords(userInput));
        }
        public void DrawBoard(int x, int y)
        {
            string sqr = " ■ ";


            Console.SetCursorPosition(x, y);
            Console.Write($"     0  1  2  3  4  5  6  7  8  9 10 11 12 13 14 15 16 17 18 19");
            Console.SetCursorPosition(x, y + 1);
            Console.Write($"   ╔════════════════════════════════════════════════════════════╗");
            Console.SetCursorPosition(x, y + 2);
            Console.Write($" A ║{sqr}{sqr}{sqr}{sqr}{sqr}{sqr}{sqr}{sqr}{sqr}{sqr}{sqr}{sqr}{sqr}{sqr}{sqr}{sqr}{sqr}{sqr}{sqr}{sqr}║");
            Console.SetCursorPosition(x, y + 3);
            Console.Write($" B ║{sqr}{sqr}{sqr}{sqr}{sqr}{sqr}{sqr}{sqr}{sqr}{sqr}{sqr}{sqr}{sqr}{sqr}{sqr}{sqr}{sqr}{sqr}{sqr}{sqr}║");
            Console.SetCursorPosition(x, y + 4);
            Console.Write($" C ║{sqr}{sqr}{sqr}{sqr}{sqr}{sqr}{sqr}{sqr}{sqr}{sqr}{sqr}{sqr}{sqr}{sqr}{sqr}{sqr}{sqr}{sqr}{sqr}{sqr}║");
            Console.SetCursorPosition(x, y + 5);
            Console.Write($" D ║{sqr}{sqr}{sqr}{sqr}{sqr}{sqr}{sqr}{sqr}{sqr}{sqr}{sqr}{sqr}{sqr}{sqr}{sqr}{sqr}{sqr}{sqr}{sqr}{sqr}║");
            Console.SetCursorPosition(x, y + 6);
            Console.Write($" E ║{sqr}{sqr}{sqr}{sqr}{sqr}{sqr}{sqr}{sqr}{sqr}{sqr}{sqr}{sqr}{sqr}{sqr}{sqr}{sqr}{sqr}{sqr}{sqr}{sqr}║");
            Console.SetCursorPosition(x, y + 7);
            Console.Write($" F ║{sqr}{sqr}{sqr}{sqr}{sqr}{sqr}{sqr}{sqr}{sqr}{sqr}{sqr}{sqr}{sqr}{sqr}{sqr}{sqr}{sqr}{sqr}{sqr}{sqr}║");
            Console.SetCursorPosition(x, y + 8);
            Console.Write($" G ║{sqr}{sqr}{sqr}{sqr}{sqr}{sqr}{sqr}{sqr}{sqr}{sqr}{sqr}{sqr}{sqr}{sqr}{sqr}{sqr}{sqr}{sqr}{sqr}{sqr}║");
            Console.SetCursorPosition(x, y + 9);
            Console.Write($" H ║{sqr}{sqr}{sqr}{sqr}{sqr}{sqr}{sqr}{sqr}{sqr}{sqr}{sqr}{sqr}{sqr}{sqr}{sqr}{sqr}{sqr}{sqr}{sqr}{sqr}║");
            Console.SetCursorPosition(x, y + 10);
            Console.Write($" I ║{sqr}{sqr}{sqr}{sqr}{sqr}{sqr}{sqr}{sqr}{sqr}{sqr}{sqr}{sqr}{sqr}{sqr}{sqr}{sqr}{sqr}{sqr}{sqr}{sqr}║");
            Console.SetCursorPosition(x, y + 11);
            Console.Write($" J ║{sqr}{sqr}{sqr}{sqr}{sqr}{sqr}{sqr}{sqr}{sqr}{sqr}{sqr}{sqr}{sqr}{sqr}{sqr}{sqr}{sqr}{sqr}{sqr}{sqr}║");
            Console.SetCursorPosition(x, y + 12);
            Console.Write($" K ║{sqr}{sqr}{sqr}{sqr}{sqr}{sqr}{sqr}{sqr}{sqr}{sqr}{sqr}{sqr}{sqr}{sqr}{sqr}{sqr}{sqr}{sqr}{sqr}{sqr}║");
            Console.SetCursorPosition(x, y + 13);
            Console.Write($" L ║{sqr}{sqr}{sqr}{sqr}{sqr}{sqr}{sqr}{sqr}{sqr}{sqr}{sqr}{sqr}{sqr}{sqr}{sqr}{sqr}{sqr}{sqr}{sqr}{sqr}║");
            Console.SetCursorPosition(x, y + 14);
            Console.Write($" M ║{sqr}{sqr}{sqr}{sqr}{sqr}{sqr}{sqr}{sqr}{sqr}{sqr}{sqr}{sqr}{sqr}{sqr}{sqr}{sqr}{sqr}{sqr}{sqr}{sqr}║");
            Console.SetCursorPosition(x, y + 15);
            Console.Write($" N ║{sqr}{sqr}{sqr}{sqr}{sqr}{sqr}{sqr}{sqr}{sqr}{sqr}{sqr}{sqr}{sqr}{sqr}{sqr}{sqr}{sqr}{sqr}{sqr}{sqr}║");
            Console.SetCursorPosition(x, y + 16);
            Console.Write($" O ║{sqr}{sqr}{sqr}{sqr}{sqr}{sqr}{sqr}{sqr}{sqr}{sqr}{sqr}{sqr}{sqr}{sqr}{sqr}{sqr}{sqr}{sqr}{sqr}{sqr}║");
            Console.SetCursorPosition(x, y + 17);
            Console.Write($" P ║{sqr}{sqr}{sqr}{sqr}{sqr}{sqr}{sqr}{sqr}{sqr}{sqr}{sqr}{sqr}{sqr}{sqr}{sqr}{sqr}{sqr}{sqr}{sqr}{sqr}║");
            Console.SetCursorPosition(x, y + 18);
            Console.Write($" Q ║{sqr}{sqr}{sqr}{sqr}{sqr}{sqr}{sqr}{sqr}{sqr}{sqr}{sqr}{sqr}{sqr}{sqr}{sqr}{sqr}{sqr}{sqr}{sqr}{sqr}║");
            Console.SetCursorPosition(x, y + 19);
            Console.Write($" R ║{sqr}{sqr}{sqr}{sqr}{sqr}{sqr}{sqr}{sqr}{sqr}{sqr}{sqr}{sqr}{sqr}{sqr}{sqr}{sqr}{sqr}{sqr}{sqr}{sqr}║");
            Console.SetCursorPosition(x, y + 20);
            Console.Write($" S ║{sqr}{sqr}{sqr}{sqr}{sqr}{sqr}{sqr}{sqr}{sqr}{sqr}{sqr}{sqr}{sqr}{sqr}{sqr}{sqr}{sqr}{sqr}{sqr}{sqr}║");
            Console.SetCursorPosition(x, y + 21);
            Console.Write($" T ║{sqr}{sqr}{sqr}{sqr}{sqr}{sqr}{sqr}{sqr}{sqr}{sqr}{sqr}{sqr}{sqr}{sqr}{sqr}{sqr}{sqr}{sqr}{sqr}{sqr}║");
            Console.SetCursorPosition(x, y + 22);
            Console.Write($"   ╚════════════════════════════════════════════════════════════╝");


        }
    }
}
