﻿using Battleship.Core.Models;
using System.Collections.Generic;

namespace Battleship.Logic
{
    public interface IGameController
    {
        GameStatus PrepareNewGame(IEnumerable<PlayerGrid> playerGrids);
        ShotResponse Shoot(Point coordinates);
    }
}