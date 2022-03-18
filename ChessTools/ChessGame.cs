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
        private int whiteElo;
        private int blackElo;
        private string result;
        private DateTime eventDate;
        private string moves;

        public string EventName { get => eventName; set => eventName = value; }
        public string Site { get => site; set => site = value; }
        public string Round { get => round; set => round = value; }
        public string WhitePlayer { get => whitePlayer; set => whitePlayer = value; }
        public string BlackPlayer { get => blackPlayer; set => blackPlayer = value; }
        public int WhiteElo { get => whiteElo; set => whiteElo = value; }
        public int BlackElo { get => blackElo; set => blackElo = value; }
        public string Result { get => result; set => result = value; }
        public DateTime EventDate { get => eventDate; set => eventDate = value; }
        public string Moves { get => moves; set => moves = value; }
    }
}
