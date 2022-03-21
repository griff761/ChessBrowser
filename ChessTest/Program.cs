// See https://aka.ms/new-console-template for more information
using ChessTools;
using System.Diagnostics;
PGNReader reader = new PGNReader();
List<ChessGame> games = reader.ReadPGN("C:/Users/grodgers/CS5530/ChessTools/kb3.pgn");
Debug.WriteLine(games.Count.ToString());

foreach (ChessGame game in games)
{
    Debug.WriteLine("Event: " + game.EventName);
    Debug.WriteLine("Site: " + game.Site);
    Debug.WriteLine("Round: " + game.Round);
    Debug.WriteLine("White: " + game.WhitePlayer);
    Debug.WriteLine("Black: " + game.BlackPlayer);
    Debug.WriteLine("White ELO: " + game.WhiteElo);
    Debug.WriteLine("Black ELO: " + game.BlackElo);
    Debug.WriteLine("Result: " + game.Result);
    Debug.WriteLine("Date: " + game.EventDate.ToShortDateString());
    Debug.WriteLine(game.Moves);
    Debug.WriteLine(null);
}
