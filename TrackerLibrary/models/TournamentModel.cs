using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary.models
{
    /// <summary>
    /// Represents an tournament - class
    /// </summary>
    public class TournamentModel
    {
        /// <summary>
        /// Representes the unique ID of an tournament
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Representes the tournamentname
        /// </summary>
        public string TournamentName { get; set; }
        /// <summary>
        /// Represents the tournament fee
        /// </summary>
        public decimal EntryFee { get; set; }
        /// <summary>
        /// List of teams in this tournament
        /// </summary>
        public List<TeamModel> EnteredTeams { get; set; } = new List<TeamModel>();
        /// <summary>
        /// List of prizes in this tournament
        /// </summary>
        public List<PrizeModel> Prizes { get; set; } = new List<PrizeModel> ();
        /// <summary>
        /// List of prizes in this tournament
        /// </summary>
        public List<List<MatchupModel>> Rounds { get; set; } = new List<List<MatchupModel>>();
    }
}
