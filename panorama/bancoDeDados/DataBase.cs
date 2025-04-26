using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace panorama.bancoDeDados
{
    internal class DataBase
    {
        private static readonly string ConnectionString = "datasource=localhost;username=root;password=;database=panorama;";

        public static MySqlConnection GetConnection()
        {
            return new MySqlConnection(ConnectionString);
        }
    }
}
