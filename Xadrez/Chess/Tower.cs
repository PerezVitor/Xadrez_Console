using Board;
using Board.Enums;

namespace Chess
{
    class Tower : Part
    {
        public Tower(Tray tray, Color color) : base(tray, color)
        {
        }

        public override string ToString()
        {
            return "T";
        }

        private bool CanMove(Position position)
        {
            Part p = Tray.Part(position);
            return p == null || p.Color != Color;
        }

        public override bool[,] PossibleMoves()
        {
            bool[,] mat = new bool[Tray.Lines, Tray.Columns];

            Position pos = new Position(0, 0);

            //acima
            pos.DefineValue(Position.Line - 1, Position.Column);
            while(Tray.PositionValidate(pos) && CanMove(pos))
            {
                mat[pos.Line, pos.Column] = true;
                if(Tray.Part(pos) != null && Tray.Part(pos).Color != Color)
                {
                    break;
                }
                pos.Line = pos.Line -  1;                
            }

            //abaixo
            pos.DefineValue(Position.Line + 1, Position.Column);
            while (Tray.PositionValidate(pos) && CanMove(pos))
            {
                mat[pos.Line, pos.Column] = true;
                if (Tray.Part(pos) != null && Tray.Part(pos).Color != Color)
                {
                    break;
                }
                pos.Line = pos.Line + 1;
            }

            //direita
            pos.DefineValue(Position.Line , Position.Column + 1);
            while (Tray.PositionValidate(pos) && CanMove(pos))
            {
                mat[pos.Line, pos.Column] = true;
                if (Tray.Part(pos) != null && Tray.Part(pos).Color != Color)
                {
                    break;
                }
                pos.Column = pos.Column + 1;
            }

            //esquerda
            pos.DefineValue(Position.Line, Position.Column - 1);
            while (Tray.PositionValidate(pos) && CanMove(pos))
            {
                mat[pos.Line, pos.Column] = true;
                if (Tray.Part(pos) != null && Tray.Part(pos).Color != Color)
                {
                    break;
                }
                pos.Column = pos.Column - 1;
            }

            return mat;
        }
    }
}
