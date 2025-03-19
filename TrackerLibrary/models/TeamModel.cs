using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary.models
{
    /// <summary>
    /// Represent a team - class
    /// </summary>
    public class TeamModel
    {
        /// <summary>
        /// Representes the unique ID of an team
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Representes the members of the team
        /// </summary>
        public List<PersonModel> TeamMembers { get; set; } = new List<PersonModel>(); //criar a variavel e ja inicia ela
        /// <summary>
        /// Representes the team name
        /// </summary>
        public string TeamName { get; set; }

        //public TeamModel() { TeamMembers = new List<Person>(); } //segunda forma de inicializar uma variavel é usando constructors
    }
}
