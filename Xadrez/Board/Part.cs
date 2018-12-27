using Board.Enums;

namespace Board
{
    abstract  class Part
    {
        public Position Position { get; set; }
        public Color Color { get; protected set; }
        public int Moves { get; protected set; }
        public Tray Tray { get; protected set; }

        public Part(Tray tray, Color color)
        {
            Position = null;
            Moves = 0;
            Tray = tray;
            Color = color;
        }

        public void IncrementMove()
        {
            Moves++;
        }

        public abstract bool[,] PossibleMoves();
    }
}
