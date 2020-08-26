using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton_Pattern
{
    public class Team
    {
        public Team(Trainer trainer)
        {
            this.Players = new List<Player>();
            this.trainer = trainer;
        }
        public List<Player> Players { get; set; }
        public Trainer trainer { get; set; }
    }
}
