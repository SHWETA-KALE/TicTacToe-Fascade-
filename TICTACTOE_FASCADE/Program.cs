using TICTACTOE_FASCADE.Enums;
using TICTACTOE_FASCADE.Models;

namespace TICTACTOE_FASCADE
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StartGame();
        }

        private static void StartGame()
        {
            Player player1 = new Player("Allen", MarkType.X);
            Player player2 = new Player("Mary", MarkType.O);

            Board board = new Board();

            Game game = new Game(player1, player2, board);

            game.PlayGame();
        }
    }
}
