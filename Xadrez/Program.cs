using System;
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
                ChessGame game = new ChessGame();

                while(!game.GameFinished)
                {
                    Console.Clear();
                    Screen.PrintBoard(game.Tray);

                    Console.Write("\nOrigin: ");
                    Position origin = Screen.ReadPositionChess().ToPosition();

                    bool[,] possiblePositions = game.Tray.Part(origin).PossibleMoves();

                    Console.Clear();
                    Screen.PrintBoard(game.Tray, possiblePositions);

                    Console.Write("Destiny: ");
                    Position destiny = Screen.ReadPositionChess().ToPosition();

                    game.PerformsMotion(origin, destiny);
                }
                
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
