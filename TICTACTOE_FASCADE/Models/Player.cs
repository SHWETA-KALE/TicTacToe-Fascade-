using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TICTACTOE_FASCADE.Enums;

namespace TICTACTOE_FASCADE.Models
{
    internal class Player
    {
        public string Name { get; set; }
        public MarkType Mark { get; set; }

        public Player(string name, MarkType mark)
        {
            Name = name;
            Mark = mark;
        }
    }
}
