using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Board;
using Board.Enums;
using Chess;

namespace Xadrez
{
    class Program
    {
        static void Main(string[] args)
        {
            Tray tray = new Tray(8, 8);

            tray.PutPart(new Tower(tray, Color.Black), new Position(0, 0));
            Screen.PrintBoard(tray);


        }
    }
}
