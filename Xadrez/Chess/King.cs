using Board;
using Board.Enums;

namespace Chess
{
    class King : Part
    {
        public King(Tray tray, Color color) : base(tray, color)
        {
        }

        public override string ToString()
        {
            return "K";
        }

        private bool CanMove(Position position)
        {
            Part p = Tray.Part(position);
            return p == null || p.Color != Color;
        }

        public override bool[,] PossibleMoves()
        {
            bool[,] mat = new bool[Tray.Lines, Tray.Columns];

            Position position = new Position(0, 0);

            //acima
            position.DefineValue(Position.Line - 1, Position.Column);
            if(Tray.PositionValidate(position) && CanMove(position))
            {
                mat[position.Line, position.Column] = true;
            }
            //ne
            position.DefineValue(Position.Line - 1, Position.Column + 1);
            if (Tray.PositionValidate(position) && CanMove(position))
            {
                mat[position.Line, position.Column] = true;
            }
            //direita
            position.DefineValue(Position.Line, Position.Column + 1);
            if (Tray.PositionValidate(position) && CanMove(position))
            {
                mat[position.Line, position.Column] = true;
            }
            //se
            position.DefineValue(Position.Line + 1, Position.Column + 1);
            if (Tray.PositionValidate(position) && CanMove(position))
            {
                mat[position.Line, position.Column] = true;
            }
            //abaixo
            position.DefineValue(Position.Line + 1, Position.Column);
            if (Tray.PositionValidate(position) && CanMove(position))
            {
                mat[position.Line, position.Column] = true;
            }
            //so
            position.DefineValue(Position.Line + 1, Position.Column - 1);
            if (Tray.PositionValidate(position) && CanMove(position))
            {
                mat[position.Line, position.Column] = true;
            }
            //esquerda
            position.DefineValue(Position.Line, Position.Column - 1);
            if (Tray.PositionValidate(position) && CanMove(position))
            {
                mat[position.Line, position.Column] = true;
            }
            //no
            position.DefineValue(Position.Line - 1, Position.Column - 1);
            if (Tray.PositionValidate(position) && CanMove(position))
            {
                mat[position.Line, position.Column] = true;
            }

            return mat;
        }
    }
}
