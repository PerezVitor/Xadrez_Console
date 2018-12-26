using Board;
using Board.Enums;

namespace Chess
{
    class Bishop : Part
    {
        public Bishop(Tray tray, Color color) : base(tray, color)
        {
        }

        public override string ToString()
        {
            return "B";
        }
    }
}
