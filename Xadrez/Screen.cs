using Board;
using System;
using Board.Enums;
using Chess;

namespace Xadrez
{
    class Screen
    {
        public static void PrintBoard(Tray tray)
        {
            for(int x = 0; x < tray.Lines; x++)
            {
                Console.Write(8 - x + " ");
                for(int y = 0; y < tray.Columns; y++)
                {
                    PrintPart(tray.Part(x, y));
                }
                Console.WriteLine();
            }
            Console.WriteLine("  A B C D E F G H");
        }

        public static void PrintBoard(Tray tray, bool[,] possiblePositions)
        {
            ConsoleColor originalColor = Console.BackgroundColor;
            ConsoleColor alteredColor = ConsoleColor.DarkGray;

            for (int x = 0; x < tray.Lines; x++)
            {
                Console.Write(8 - x + " ");
                for (int y = 0; y < tray.Columns; y++)
                {
                    if(possiblePositions[x,y])
                    {
                        Console.BackgroundColor = alteredColor;
                    }
                    else
                    {
                        Console.BackgroundColor = originalColor;
                    }
                    PrintPart(tray.Part(x, y));
                    Console.BackgroundColor = originalColor;
                }
                Console.WriteLine();
            }
            Console.WriteLine("  A B C D E F G H");
            Console.BackgroundColor = originalColor;
        }

        public static PositionChess ReadPositionChess()
        {
            string s = Console.ReadLine();
            char column = s[0];
            int line = int.Parse(s[1] + "");
            return new PositionChess(column, line);

        }

        public static void PrintPart(Part part)
        {
            if (part == null)
            {
                Console.Write("- ");
            }
            else
            {
                if (part.Color == Color.White)
                {
                    Console.Write(part);
                }
                else
                {
                    ConsoleColor aux = Console.ForegroundColor;
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write(part);
                    Console.ForegroundColor = aux;
                }
                Console.Write(" ");
            }
        }
    }
}
