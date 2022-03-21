using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace ChessTools
{
    //internal class PGNReader
    public class PGNReader
    {
        private List<string> gameData;
        private List<ChessGame> chessGames = new List<ChessGame>();

        public List<ChessGame> ChessGames { get => chessGames; private set => chessGames = value; }

        public List<ChessGame> ReadPGN(string path)
        {
            //string[] temp = File.ReadAllLines(path);
            gameData = new List<string>(File.ReadAllLines(path));
            ChessGame game = new ChessGame();
            string moveList = "";
            int newLineCount = 0;
            foreach (string line in gameData)
            {
                if (line.StartsWith("[Event "))
                {
                    game.EventName = GetSubstringInQuotes(line);
                }
                else if (line.StartsWith("[Site "))
                {
                    game.Site = GetSubstringInQuotes(line);
                }
                else if (line.StartsWith("[Date "))
                {
                    continue;
                }
                else if (line.StartsWith("[Round "))
                {
                    game.Round = GetSubstringInQuotes(line);
                }
                else if (line.StartsWith("[White "))
                {
                    game.WhitePlayer = GetSubstringInQuotes(line);
                }
                else if (line.StartsWith("[Black "))
                {
                    game.BlackPlayer = GetSubstringInQuotes(line);
                }
                else if (line.StartsWith("[Result "))
                {
                    string result = GetSubstringInQuotes(line);
                    switch (result)
                    {
                        case "1/2-1/2":
                            game.Result = 'D';
                            break;
                        case "1-0":
                            game.Result = 'W';
                            break;
                        case "0-1":
                            game.Result = 'D';
                            break;
                    }

                }
                else if (line.StartsWith("[WhiteElo "))
                {
                    string whiteElo = GetSubstringInQuotes(line);
                    game.WhiteElo = Convert.ToUInt32(whiteElo);
                }
                else if (line.StartsWith("[BlackElo "))
                {
                    string blackElo = GetSubstringInQuotes(line);
                    game.BlackElo = Convert.ToUInt32(blackElo);
                }

                else if (line.StartsWith("[ECO "))
                {
                    continue;
                }

                else if (line.StartsWith("[EventDate "))
                {
                    string eventDate = GetSubstringInQuotes(line);
                    try
                    {
                        game.EventDate = Convert.ToDateTime(eventDate);
                    }
                    catch
                    {
                        game.EventDate = DateTime.MinValue;
                    }
                }

                else if (line.Length == 0)
                {
                    ++newLineCount;
                    if (newLineCount == 2)
                    {
                        game.Moves = moveList;
                        ChessGames.Add(game);
                        newLineCount = 0;
                        game = new ChessGame();
                        moveList = "";
                    }
                    continue;
                }

                else
                {
                    moveList += line;
                }
            }

            return chessGames;
        }

        private string GetSubstringInQuotes(string s)
        {
            int start = s.IndexOf('"') + 1;
            int end = s.LastIndexOf('"') - start;
            return s.Substring(start, end);
        }
    }
}
