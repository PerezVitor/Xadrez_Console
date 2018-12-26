namespace Board
{
    class Tray
    {
        public int Lines { get; set; }
        public int Columns { get; set; }
        private Part[,] Parts { get; set; }

        public Tray(int lines, int columns)
        {
            Lines = lines;
            Columns = columns;
            Parts = new Part[lines, columns];
        }

        public Part Part(int line, int column)
        {
            return Parts[line, column];
        }

        public void PutPart(Part part, Position position)
        {
            Parts[position.Line, position.Column] = part;
            part.Position = position;
        }
    }
}
