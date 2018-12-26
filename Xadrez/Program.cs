using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Board;

namespace Xadrez
{
    class Program
    {
        static void Main(string[] args)
        {
            Tray tray = new Tray(8, 8);

            Screen.PrintBoard(tray);


        }
    }
}
