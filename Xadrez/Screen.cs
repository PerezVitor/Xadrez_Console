using Board;
using System;
using Board.Enums;

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
                    if(tray.Part(x,y) == null)
                    {
                        Console.Write("- ");
                    }
                    else
                    {
                        PrintPart(tray.Part(x, y));
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine("  A B C D E F G H");
        }

        public static void PrintPart(Part part)
        {
            if(part.Color == Color.White)
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
        }
    }
}
