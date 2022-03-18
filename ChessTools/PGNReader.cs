using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace ChessTools
{
    internal class PGNReader
    {
        private string[] gameData;
        public void ReadPGN(string path)
        {
            gameData = File.ReadAllLines(path);
            foreach (string line in gameData)
            {
                if (line.StartsWith("[Event "))
                {

                }
            }
        }
    }
}
