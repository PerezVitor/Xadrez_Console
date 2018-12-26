using Board;
using System;

namespace Xadrez
{
    class Screen
    {
        public static void PrintBoard(Tray tray)
        {
            for(int x = 0; x < tray.Lines; x++)
            {
                for(int y = 0; y < tray.Columns; y++)
                {
                    if(tray.Part(x,y) == null)
                    {
                        Console.Write("- ");
                    }
                    else
                    {
                        Console.Write(tray.Part(x, y) + " ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
