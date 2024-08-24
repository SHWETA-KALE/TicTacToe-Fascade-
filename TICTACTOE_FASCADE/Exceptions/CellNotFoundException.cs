using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TICTACTOE_FASCADE.Exceptions
{
    internal class CellNotFoundException : Exception
    {
        public CellNotFoundException(string message) : base(message) { }
    }
}
