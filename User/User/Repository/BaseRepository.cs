using System;
using System.Data.SqlClient;
using System.Configuration;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace User.Repository
{
    public class BaseRepository
    {
        public SqlConnection GetSqlConnection(bool open = true)
        {

            string cs = ConfigurationManager.ConnectionStrings["soccerdb"].ConnectionString;
            var conn = new SqlConnection(cs);
            if (open) conn.Open();
            return conn;
        }
    }
}