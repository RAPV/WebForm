using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace App.Data
{
    public class BaseConnection
    {
        public IDbConnection GetConnection()
        {
            var strConnection = ConfigurationManager.ConnectionStrings["dbColegio"].ConnectionString;

            return new SqlConnection(strConnection);
        }
    }
}
