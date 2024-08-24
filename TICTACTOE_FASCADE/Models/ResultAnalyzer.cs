using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TICTACTOE_FASCADE.Enums;

namespace TICTACTOE_FASCADE.Models
{
    internal class ResultAnalyzer
    {
        private Board board { get; set; }


        public ResultAnalyzer(Board board)
        {
            this.board = board;
        }

        public ResultType AnalyzeResult()
        {
            //checking for winning cond
            if (HorizontalWinCheck() || VerticalWinCheck() || DiagonalWinCheck())
            {
                return ResultType.WIN;
            }

            if (board.IsBoardFull())
            {
                return ResultType.DRAW;
            }
            return ResultType.PROGRESS;
        }


        private bool HorizontalWinCheck()
        {
            for (int i = 0; i <= 6; i += 3)
            {
                if (board.GetCell(i).Mark != MarkType.EMPTY &&
                    board.GetCell(i).Mark == board.GetCell(i + 1).Mark &&
                    board.GetCell(i).Mark == board.GetCell(i + 2).Mark)
                {
                    return true;
                }
            }
            return false;
            //if ()
            //{
            //    bool row1 = cell[0] == cell[1] && cell[1] == cell[2];
            //    bool row2 = grid[3] == grid[4] && grid[4] == grid[5];
            //    bool row3 = grid[6] == grid[7] && grid[7] == grid[8];
            //}

        }
        private bool VerticalWinCheck()
        {
            for (int i = 0; i <= 2; i++)
            {
                if (board.GetCell(i).Mark != MarkType.EMPTY &&
                    board.GetCell(i).Mark == board.GetCell(i + 3).Mark &&
                    board.GetCell(i).Mark == board.GetCell(i + 6).Mark)
                {
                    return true;
                }
            }
            return false;
        }

        private bool DiagonalWinCheck()
        {
            //check first diagonal(0, 4, 8)
            if (board.GetCell(0).Mark != MarkType.EMPTY &&
                board.GetCell(0).Mark == board.GetCell(4).Mark &&
                board.GetCell(0).Mark == board.GetCell(8).Mark)
            {
                return true;
            }
            //check second diagonal(2, 4, 6)
            if (board.GetCell(2).Mark != MarkType.EMPTY &&
                board.GetCell(2).Mark == board.GetCell(4).Mark &&
                board.GetCell(2).Mark == board.GetCell(6).Mark)
            {
                return true;
            }
            return false;
        }
    }
}
