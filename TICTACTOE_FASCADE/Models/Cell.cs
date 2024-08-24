using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TICTACTOE_FASCADE.Enums;
using TICTACTOE_FASCADE.Exceptions;

namespace TICTACTOE_FASCADE.Models
{
    internal class Cell
    {
        public MarkType Mark { get; private set; }

        public Cell()
        {
            Mark = MarkType.EMPTY;
        }

        public bool IsEmpty()
        {
            return Mark == MarkType.EMPTY;
        }

        public void SetMark(MarkType mark)
        {
            if (!IsEmpty())
            {
                throw new CellAlreadyMarkedException("This Cell is already marked");
            }
            this.Mark = mark;

        }
    }
}
