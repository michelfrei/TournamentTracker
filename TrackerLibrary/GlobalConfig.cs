using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackerLibrary.DataAccess;

namespace TrackerLibrary
{
    //static class implica que você não consegue instanciar essa classe mas ainda sim ela está visivel para todos
    public static class GlobalConfig 
    {
        public static IDataConnection Connection { get; private set; }
        // Connections = new List<IDataConnection> ();
        //quando usa o private, apenas os metodos dentro de GlobalConfig consegue fazer alterações nos valores de Connections

        public static void InitializeConnections(DatabaseType db)
        {
            //como o valor database é booleano, o C# já o entende como true or false, ent n preciso fazer o condicional dessa forma (database == true) 
            if (db == DatabaseType.Sql) 
            {
                // TODO  = Setup the SQL connector
                SqlConnector sql = new SqlConnector();
                Connection = sql;
            }
            else if (db == DatabaseType.TextFile)
            {
                // TODO  = create the text file connection
                TextConnector text = new TextConnector();
                Connection = text;
            }
        }

        public static string CnnString(string name)
        {
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }

    }
}
