using System;
using System.Collections.Generic;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Data;
using Microsoft.Data; //ajuste tecnico por estar usando versão nova do .net
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackerLibrary.models;
using Dapper;

namespace TrackerLibrary.DataAccess
{
    public class SqlConnector : IDataConnection //aplicando o conceito de herança na pratica >:)
    {
        // TODO - Make the createprize method actually save to the database
        /// <summary>
        /// Saves a new prize in the databaase
        /// </summary>
        /// <param name="model">Prize Info</param>
        /// <returns>Prize info + unique ID</returns>
        public PrizeModel CreatePrize(PrizeModel model)
        {
            using (IDbConnection connection = new Microsoft.Data.SqlClient.SqlConnection(GlobalConfig.CnnString("Tournaments")))
            {
                 var p = new DynamicParameters();
                p.Add("@PlaceNumber", model.PlaceNumber);
                p.Add("@PlaceName", model.PlaceName);
                p.Add("@PrizeAmount", model.PrizeAmount);
                p.Add("@PrizePercentage", model.PrizePercentage);
                p.Add("@id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                connection.Execute("dbo.spPrizes_Insert", p, commandType: CommandType.StoredProcedure);

                model.Id = p.Get<int>("@id");

                connection.Close();
                return model;
            }
        }

        public PersonModel CreatePerson(PersonModel model) 
        {
            using (IDbConnection connection = new Microsoft.Data.SqlClient.SqlConnection(GlobalConfig.CnnString("Tournaments")))
            {
                var p = new DynamicParameters();
                p.Add("@FirstName", model.FirstName);
                p.Add("@LastName", model.LastName);
                p.Add("@EmailAddress", model.EmailAddress);
                p.Add("@CellphoneNumber", model.CellphoneNumber);
                p.Add("@id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                connection.Execute("dbo.spPeople_Insert", p, commandType: CommandType.StoredProcedure);

                model.Id = p.Get<int>("@id");

                connection.Close();
                return model;
            }
            return null;
        }
    }
}
