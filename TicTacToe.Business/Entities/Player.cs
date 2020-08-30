using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicTacToe.Business.Interface;

namespace TicTacToe.Business.Entities
{
    public class Player
    {
        public string PlayerName { get; set; }
        public bool Winner { get; set; }
    }
}
