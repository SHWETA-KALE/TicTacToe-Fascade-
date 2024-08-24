
using TICTACTOE_FASCADE.Controller;
using TICTACTOE_FASCADE.Enums;

namespace TICTACTOE_FASCADE.Models
{
    internal class Game
    {
        public Board Board { get; set; }
        public Player Player1 { get; set; }
        public Player Player2 { get; set; }
        public ResultAnalyzer ResultAnalyzer { get; set; }
        public Player CurrentPlayer { get; set; }

        public Game(Player player1, Player player2, Board board)
        {
            Player1 = player1;
            Player2 = player2;
            CurrentPlayer = player1;
            Board = board;
            ResultAnalyzer = new ResultAnalyzer(board);
        }

        public void PlayGame()
        {
            MainMenu.Display(Player1, Player2);
            while (ResultAnalyzer.AnalyzeResult() == ResultType.PROGRESS && !Board.IsBoardFull())
            {
                DisplayBoard(); // Display the board before each move

                Console.WriteLine($"CurrentPlayer: {CurrentPlayer.Name}, Mark: {CurrentPlayer.Mark}");
                int choice = MainMenu.GetPlayerChoice();

                try
                {
                    Board.SetCellMark(choice, CurrentPlayer.Mark);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    continue; 
                }

                if (ResultAnalyzer.AnalyzeResult() == ResultType.WIN)
                {
                    DisplayBoard(); 
                    Console.WriteLine($"..........................{CurrentPlayer.Name} Wins!................");
                    Console.WriteLine();
                    return;
                }

                CurrentPlayer = CurrentPlayer == Player1 ? Player2 : Player1;
            }

            if (Board.IsBoardFull())
            {
                DisplayBoard(); // Display the board at the end of the game
                Console.WriteLine("It's a Draw!");
            }
        }

        private void DisplayBoard()
        {
            Console.WriteLine("Board:");
            for (int i = 0; i < 9; i += 3)
            {
                Console.WriteLine($" {GetMarkSymbol(Board.GetCell(i).Mark)} | {GetMarkSymbol(Board.GetCell(i + 1).Mark)} | {GetMarkSymbol(Board.GetCell(i + 2).Mark)} ");
                if (i < 6) Console.WriteLine("---|---|---");
            }
            Console.WriteLine();
        }

        private string GetMarkSymbol(MarkType mark)
        {
            return mark == MarkType.EMPTY ? " " : mark.ToString();
        }
    }
}
