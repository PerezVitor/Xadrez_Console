using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Board;
using Board.Enums;
using Chess;
using Board.Exceptions;

namespace Xadrez
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Tray tray = new Tray(8, 8);

                tray.PutPart(new Tower(tray, Color.Black), new Position(0, 0));
                tray.PutPart(new Tower(tray, Color.Black), new Position(0, 7));
                tray.PutPart(new King(tray, Color.White), new Position(0, 4));
                tray.PutPart(new Queen(tray, Color.White), new Position(0, 3));

                Screen.PrintBoard(tray);
            }
            catch(TrayExceptions e)
            {
                Console.WriteLine(e.Message);
            }

            /*PositionChess position = new PositionChess('c', 7);

            Console.WriteLine(position);
            Console.WriteLine(position.ToPosition());*/
        }
    }
}
