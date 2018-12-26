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
    }
}
