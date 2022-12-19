using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace DataAccess
{
    public abstract class ConnectionSql
    {
        private readonly string connectionstring;
        public ConnectionSql() {

            connectionstring = "Server= DESKTOP-85RF926; Database= SERVECHAPP;user id=Zack;password=Simb12345;";
        }

        protected SqlConnection GetConnection() {

            return new SqlConnection(connectionstring);
        }
    }
}