using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary.models
{
    /// <summary>
    /// Representes one team in a matchup - class
    /// </summary>
    public class MatchupEntryModel
    {
        /// <summary>
        /// Representes one team in the matchs
        /// </summary>
        public TeamModel TeamCompeting { get; set; }
        /// <summary>
        /// Representes the score for this particular team
        /// </summary>
        public double Score { get; set; }
        /// <summary>
        /// Representes the matchup that this team came from as the winner
        /// </summary>
        public MatchupModel ParentMatchup { get; set; }
    }
}
