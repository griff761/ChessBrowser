using System;

namespace ChessTools
{
    public class ChessGame
    {
        private string eventName;
        private string site;
        private string round;
        private string whitePlayer;
        private string blackPlayer;
        private uint whiteElo;
        private uint blackElo;
        private char result;
        private DateTime eventDate;
        private string moves;

        public string EventName { get => eventName; set => eventName = value; }
        public string Site { get => site; set => site = value; }
        public string Round { get => round; set => round = value; }
        public string WhitePlayer { get => whitePlayer; set => whitePlayer = value; }
        public string BlackPlayer { get => blackPlayer; set => blackPlayer = value; }
        public uint WhiteElo { get => whiteElo; set => whiteElo = value; }
        public uint BlackElo { get => blackElo; set => blackElo = value; }
        public char Result { get => result; set => result = value; }
        public DateTime EventDate { get => eventDate; set => eventDate = value; }
        public string Moves { get => moves; set => moves = value; }
    }
}
