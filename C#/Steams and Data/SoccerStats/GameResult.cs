using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace SoccerStats
{
    class GameResult
    {
        //GoalAttempts,ShotsOnGoal,ShotsOffGoal,PosessionPercent
        public DateTime GameDate { get; set; }
        public string TeamName { get; set; }
        public HomeOrAway HomeOrAway { get; set; }
        public int Goals { get; set; }
        public int GoalAttempts { get; set; }
        public int ShotsOnGoal { get; set; }
        public int ShotsOffGoal { get; set; }
        public double PossesionPercent { get; set; }

    }
    public enum HomeOrAway
    {
        Home,
        Away
    }
}
