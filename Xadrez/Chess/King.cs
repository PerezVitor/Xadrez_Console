using Board;
using Board.Enums;

namespace Chess
{
    class King : Part
    {
        public King (Tray tray, Color color) : base(tray, color)
        {
        }

        public override string ToString()
        {
            return "K";
        }
    }
}
