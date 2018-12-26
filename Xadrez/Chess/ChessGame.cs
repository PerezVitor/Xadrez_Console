using System;
using Board;
using Board.Enums;

namespace Chess
{
    class ChessGame
    {
        public Tray Tray { get; private set; }
        public int Turn { get; private set; }
        public Color Gamer { get; set; }
        public bool GameFinished { get; private set; }

        public ChessGame()
        {
            Tray = new Tray(8, 8);
            Turn = 1;
            Gamer = Color.White;
            InsertParts();
        }

        public void PerformsMotion(Position origin, Position destiny)
        {
            Part p = Tray.RemovePart(origin);
            p.IncrementMove();
            Part capturePart = Tray.RemovePart(destiny);
            Tray.PutPart(p, destiny);
        }

        public void InsertParts()
        {
            Tray.PutPart(new Tower(Tray, Color.White), new PositionChess('c', 1).ToPosition());
            Tray.PutPart(new Tower(Tray, Color.White), new PositionChess('c', 2).ToPosition());
            Tray.PutPart(new Tower(Tray, Color.White), new PositionChess('d', 2).ToPosition());
            Tray.PutPart(new Tower(Tray, Color.White), new PositionChess('e', 2).ToPosition());
            Tray.PutPart(new Tower(Tray, Color.White), new PositionChess('e', 1).ToPosition());
            Tray.PutPart(new King(Tray, Color.White), new PositionChess('d', 1).ToPosition());

            Tray.PutPart(new Tower(Tray, Color.Black), new PositionChess('c', 8).ToPosition());
            Tray.PutPart(new Tower(Tray, Color.Black), new PositionChess('c', 7).ToPosition());
            Tray.PutPart(new Tower(Tray, Color.Black), new PositionChess('d', 7).ToPosition());
            Tray.PutPart(new Tower(Tray, Color.Black), new PositionChess('e', 7).ToPosition());
            Tray.PutPart(new Tower(Tray, Color.Black), new PositionChess('e', 8).ToPosition());
            Tray.PutPart(new King(Tray, Color.Black), new PositionChess('d', 8).ToPosition());
        }
    }
}
