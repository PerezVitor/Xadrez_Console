using Board.Enums;

namespace Board
{
    class Part
    {
        public Position Position { get; set; }
        public Color Color { get; protected set; }
        public int Moves { get; protected set; }
        public Tray Tabuleiro { get; protected set; }

        public Part(Tray tabuleiro, Color color)
        {
            Position = null;
            Moves = 0;
            Tabuleiro = tabuleiro;
            Color = color;
        }
    }
}
