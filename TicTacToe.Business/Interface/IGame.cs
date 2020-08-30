using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicTacToe.Business.Entities;

namespace TicTacToe.Business.Interface
{
    public interface IGame
    {
        Player Play(List<Position> playerPositions);

    }
}
