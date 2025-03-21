﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary.models
{
    /// <summary>
    /// Represents one match in the tournament - class
    /// </summary>
    public class MatchupModel
    {
        /// <summary>
        /// Representes the unique ID of an matchup
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// The set of teams were involved in this match
        /// </summary>
        public List<MatchupEntryModel> Entries { get; set; } = new List<MatchupEntryModel> ();
        /// <summary>
        /// The winner of the match
        /// </summary>
        public TeamModel Winner { get; set; }
        /// <summary>
        /// Which round this match is a part of
        /// </summary>
        public int MatchupRound { get; set; }

    }
}
