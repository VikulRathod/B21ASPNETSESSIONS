using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace _5_ADONETIntro
{
    public sealed class SqlHelper
    {
        private static string _connectionString = null;
        private static SqlConnection _connection = null;

        private SqlHelper() { }

        public static SqlConnection DbConnection
        {
            get
            {
                if(_connection == null)
                {
                    _connectionString = ConfigurationManager.ConnectionStrings["B21AdoNetDB"].ConnectionString;
                    _connection = new SqlConnection(_connectionString);
                }
                return _connection;
            }
        }

    }
}