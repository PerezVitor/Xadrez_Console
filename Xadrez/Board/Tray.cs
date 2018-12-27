using Board.Exceptions;

namespace Board
{
    class Tray
    {
        public int Lines { get; set; }
        public int Columns { get; set; }
        public Part[,] Parts { get; set; }

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

        public Part Part(Position position)
        {
            return Parts[position.Line, position.Column];
        }

        public bool PartExists(Position position)
        {
            ValidatePosition(position);
            return Part(position) != null;
        }

        public void PutPart(Part part, Position position)
        {
            if(PartExists(position))
            {
                throw new TrayExceptions("There is already a part in this positon");
            }
            Parts[position.Line, position.Column] = part;
            part.Position = position;
        }

        public Part RemovePart(Position position)
        {
            if(Part(position) == null)
            {
                return null;
            }

            Part aux = Part(position);
            aux.Position = null;
            Parts[position.Line, position.Column] = null;
            return aux;
        }

        public bool PositionValidate(Position position)
        {
            if(position.Line < 0 || 
               position.Line >= Lines ||
               position.Column < 0 ||
               position.Column >= Columns)
            {
                return false;
            }

            return true;
        }

        public void ValidatePosition(Position position)
        {
            if(!PositionValidate(position))
            {
                throw new TrayExceptions("Invalid Position!");
            }
        }
    }
}
