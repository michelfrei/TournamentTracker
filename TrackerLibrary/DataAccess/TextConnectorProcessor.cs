using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.IO.Enumeration;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using Microsoft.AspNetCore.Components;
using TrackerLibrary.models;

namespace TrackerLibrary.DataAccess.TextHelpers //is bcuz i dont want everyone to get quarter up
                                                  //- apenas pessoas que fazer parte desse name space
                                                  //conseguem usar o que está contido nessa classe
{
    public static class TextConnectorProcessor
    {
        public static string FullFilePath(this string fileName) //PrizeModels.csv // this 
        {
            return $"{ConfigurationManager.AppSettings["filePath"]}\\{fileName}";
        }

        public static List<String> LoadFile(this string file)
        {
            if (!File.Exists(file))
            {
                return new List<string>();
            }
            return File.ReadLines(file).ToList();
        }

        /*-------------------------- prize stuff ---------------------*/
        public static List<PrizeModel> ConvertToPrizeModels(this List<string> lines)
        {
            List<PrizeModel> output = new List<PrizeModel>();

            foreach (string line in lines)
            {
                string[] cols = line.Split(','); //todas as linhas de lines vão ser inseridas em um array de string chamado cols
                PrizeModel p = new PrizeModel();
                p.Id = int.Parse(cols[0]);
                p.PlaceNumber = int.Parse(cols[1]);
                p.PlaceName = cols[2];
                p.PrizeAmount = decimal.Parse(cols[3]);
                p.PrizePercentage = double.Parse(cols[4]);

                output.Add(p);
            }
            return output;
        }

        public static void SaveToPrizeFile(this List<PrizeModel> models, string fileName)
        {
            List<string> lines = new List<string>();

            foreach (PrizeModel p in models)
            {
                lines.Add($"{p.Id},{p.PlaceNumber},{p.PlaceName},{p.PrizeAmount},{p.PrizePercentage}");
            }

            File.WriteAllLines(fileName.FullFilePath(), lines);
        }

        /*-----------------------------Person Stuff----------------------------------*/
        public static List<PersonModel> ConvertToPersonModels(this List<string> lines)
        {
            List<PersonModel> output = new List<PersonModel>();
            foreach (string line in lines)
            {
                string[] cols = line.Split(",");
                PersonModel p = new PersonModel();
                p.Id = int.Parse(cols[0]);
                p.FirstName = cols[1];
                p.LastName = cols[2];
                p.EmailAddress = cols[3];
                p.CellphoneNumber = cols[4];
                output.Add(p);
            }
            return output;
        }
        public static void SaveToPersonFIle(this List<PersonModel> models, string fileName)
        {
            List<string> lines = new List<string>();

            foreach (PersonModel p in models)
            {
                lines.Add($"{p.Id},{p.FirstName},{p.LastName},{p.EmailAddress},{p.CellphoneNumber}");
            }

            File.WriteAllLines(fileName.FullFilePath(), lines);
        }
        /*-----------------------------Team Stuff----------------------------------*/
        public static List<TeamModel> ConvertToTeamModels(this List<string> lines, string PersonFileName)
        {
            List<TeamModel> output = new List<TeamModel>();
            List<PersonModel> people = PersonFileName.FullFilePath().LoadFile().ConvertToPersonModels();

            foreach (string line in lines)
            {
                string[] cols = line.Split(',');
                TeamModel p = new TeamModel();
                p.Id = int.Parse(cols[0]);
                p.TeamName = cols[1];

                string[] personIds = cols[2].Split('|');

                foreach (string Id in personIds)
                {
                    p.TeamMembers.Add(people.Where(x => x.Id == int.Parse(Id)).First());
                    //pega todas as pessoas da lista e correlacione ela com os Ids distribuidos pelo loop foreach
                }
                output.Add(p);
            }
            return output;
        }

        public static void SaveToTeamFile(this List<TeamModel> models, string FileName)
        {
            List<string> lines = new List<string>();
            foreach (TeamModel p in models)
            {
                lines.Add($"{p.Id},{p.TeamName},{ConvertPeopleListToString(p.TeamMembers)}");
            }

            File.WriteAllLines(FileName.FullFilePath(), lines);
        }
        private static string ConvertPeopleListToString(List<PersonModel> people)
        {
            string output = "";

            if (people.Count == 0)
            {
                return "";
            }

            foreach (PersonModel p in people)
            {
                output += $"{p.Id}|";
            }
            output = output.Substring(0, output.Length - 1);
            return output;
        }
        /*-----------------------------Tournament Stuff----------------------------------*/
        public static List<TournamentModel> ConvertToTournamentModels(this List<string> lines, string teamFileName, string personFileName, string prizeFileName)
        {
            //id, tournamentname, entryfee, (id|id|id -> Entered Teams), (id|id|id -> Prizes), (Rounds - id^id^id^id|id^id|id^id)
            List<TournamentModel> output = new List<TournamentModel>();
            List<TeamModel> teams = teamFileName.FullFilePath().LoadFile().ConvertToTeamModels(personFileName);
            List<PrizeModel> prizes = prizeFileName.FullFilePath().LoadFile().ConvertToPrizeModels();

            foreach (string line in lines)
            {
                string[] cols = line.Split(',');

                TournamentModel tm = new TournamentModel();
                tm.Id = int.Parse(cols[0]);
                tm.TournamentName = cols[1];
                tm.EntryFee = decimal.Parse(cols[2]);
                string[] teamIds = cols[3].Split("|");
                foreach (string id in teamIds)
                {
                    tm.EnteredTeams.Add(teams.Where(x => x.Id == int.Parse(id)).First());
                } 
                string[] prizeIds = cols[4].Split("|");
                foreach (string id in prizeIds)
                {
                    tm.Prizes.Add(prizes.Where(x => x.Id == int.Parse(id)).First());
                }
                output.Add(tm);
            }
            return output;
        }
        public static void SaveToTournamentFile(this List<TournamentModel> models, string fileName)
        {
            List<string> lines = new List<string>();
            foreach (TournamentModel p in models)
            {
                lines.Add($@"{p.Id},
                            {p.TournamentName},
                            {p.EntryFee},
                            {ConvertTeamListToString(p.EnteredTeams)},
                            {ConvertPrizeListToString(p.Prizes)},
                            {ConvertRoundListToString(p.Rounds)}");
            }
            File.WriteAllLines(fileName.FullFilePath(), lines);
        }
        private static string ConvertTeamListToString(List<TeamModel> teams) 
        {
            string output = "";

            if (teams.Count == 0)
            {
                return "";
            }

            foreach (TeamModel t in teams)
            {
                output += $"{t.Id}|";
            }
            output = output.Substring(0, output.Length - 1);
            return output;
        }
        private static string ConvertPrizeListToString(List<PrizeModel> prizes)
        {
            string output = "";

            if (prizes.Count == 0)
            {
                return "";
            }

            foreach (PrizeModel p in prizes)
            {
                output += $"{p.Id}|";
            }
            output = output.Substring(0, output.Length - 1);
            return output;
        }
        private static string ConvertRoundListToString(List<List<MatchupModel>> rounds)
        {
            string output = "";

            if (rounds.Count == 0)
            {
                return "";
            }

            foreach (List<MatchupModel> r in rounds)
            {
                output += $"{ConvertMatchupListToString(r)}|";
            }
            output = output.Substring(0, output.Length - 1);
            return output;
        }
        private static string ConvertMatchupListToString(List<MatchupModel> matchups)
        {
            string output = "";

            if (matchups.Count == 0)
            {
                return "";
            }

            foreach (MatchupModel m in matchups)
            {
                output += $"{m.Id}^";
            }
            output = output.Substring(0, output.Length - 1);
            return output;
        }
    }
}
