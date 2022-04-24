﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entity
{
    public class GameScore
    {
        public int Id { get; set; }
        public int GameId { get; set; }
        public Game Game { get; set; }
        public int PlayerId { get; set; }
        public Player Player { get; set; }
        public byte Minute { get; set; }
        public bool OwnGoal { get; set; }

    }
}
