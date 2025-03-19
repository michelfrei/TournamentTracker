using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackerLibrary.models;
using TrackerLibrary.DataAccess.TextHelpers;

namespace TrackerLibrary.DataAccess
{
    public class TextConnector : IDataConnection
    {
        // TODO - Wire up the createprize for text files
        private const string PrizesFile = "PrizeModels.csv"; //private const == never changes >:)
        private const string PersonFile = "PersonModels.csv";
        private const string TeamFile = "TeamModels.csv";
        private const string TournamentFile = "TournamentModels.csv";

        public PrizeModel CreatePrize(PrizeModel model)
        {
            // load the text file; converthe text to list; 
            List<PrizeModel> prizes = PrizesFile.FullFilePath().LoadFile().ConvertToPrizeModels();
            //isso aqui foi insano, PrizesFIle que carrega consigo "PrizeModels.csv", invoca o fullfilepath que tem o path
            //que chama a função de carregar o arquivo que chama a função de transformar em lista - Loucura das brabas

            //find the last id; 
            int currentId = 1;

            if (prizes.Count > 0)
            {
                currentId = prizes.OrderByDescending(x => x.Id).First().Id + 1;
            }
            model.Id = currentId;
            //add new record with new id (max + 1);
            prizes.Add(model);
            // convert the prizes to a list of string; save the list of string to the text file
            prizes.SaveToPrizeFile(PrizesFile);
            return model;
        }
        public PersonModel CreatePerson(PersonModel model) 
        {
            List<PersonModel> persons = PersonFile.FullFilePath().LoadFile().ConvertToPersonModels();
            int currentId = 1;
            if (persons.Count > 0)
            {
                currentId = persons.OrderByDescending(x => x.Id).First().Id + 1;
            }
            model.Id = currentId;
            persons.Add(model);
            persons.SaveToPersonFIle(PersonFile);
            return model;
        }

        public List<PersonModel> GetPerson_All()
        {
            return PersonFile.FullFilePath().LoadFile().ConvertToPersonModels();
        }

        public TeamModel CreateTeam(TeamModel model)
        {
            List<TeamModel> teams = TeamFile.FullFilePath().LoadFile().ConvertToTeamModels(PersonFile);

            int currentId = 1;

            if (teams.Count > 0)
            {
                currentId = teams.OrderByDescending(x => x.Id).First().Id + 1;
            }
            model.Id = currentId;
            teams.Add(model);

            teams.SaveToTeamFile(TeamFile);
            return model;

        }

        public List<TeamModel> GetTeam_All()
        {
            return TeamFile.FullFilePath().LoadFile().ConvertToTeamModels(PersonFile);
        }

        public void CreateTournament(TournamentModel model)
        {
            List<TournamentModel> tournaments = TournamentFile.FullFilePath().LoadFile().ConvertToTournamentModels(TeamFile, PersonFile, PrizesFile);
            int currentId = 1;

            if (tournaments.Count > 0)
            {
                currentId = tournaments.OrderByDescending(x => x.Id).First().Id + 1;
            }
            model.Id = currentId;
            tournaments.Add(model);

            tournaments.SaveToTournamentFile(TournamentFile);
        }
    }
}
