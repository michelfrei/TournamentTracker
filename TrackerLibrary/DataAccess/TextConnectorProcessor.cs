using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using TrackerLibrary.models;

namespace TrackerLibrary.DataAccess.TextHelpers //is bcuz i dont want everyone to get quarter up
                                                  //- apenas pessoas que fazer parte desse name space
                                                  //conseguem usar o que está contido nessa classe
{
    public static class TextConnectorProcessor
    {
        public static string FullFilePath(this string fileName) //PrizeModels.csv // this 
        {
            return $"{ConfigurationManager.AppSettings["filePath"]}\\{ fileName }";
        }

        public static List<String> LoadFile(this string file)
        {
            if (!File.Exists(file))
            {
                return new List<string> ();
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
            foreach(string line in lines)
            {
                string [] cols = line.Split(",");
                PersonModel p = new PersonModel();
                p.Id= int.Parse(cols[0]);
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

    }
}
