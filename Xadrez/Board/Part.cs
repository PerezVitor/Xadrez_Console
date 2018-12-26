using Board.Enums;

namespace Board
{
    class Part
    {
        public Position Position { get; set; }
        public Color Color { get; protected set; }
        public int Moves { get; set; }
        public Tray Tabuleiro { get; set; }

        public Part(Position position, int moves, Tray tabuleiro)
        {
            Position = position;
            Moves = moves;
            Tabuleiro = tabuleiro;
        }
    }
}
