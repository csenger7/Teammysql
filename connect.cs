using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Team
{
    public class connect
    {
        public MySqlConnection Connection;
        public string Host;
        public string Database;
        public string User;
        public string Password;
        public string ConnectionString;

        public connect() 
        {
            Host = "localhost";
            Database = "Team";
            User = "root";
            Password = "";

            ConnectionString = "SERVER=" + Host + ";DATABASE=" + Database + ";UID=" + User + ";PASSWORD=" + Password + ";SslMode=None";

            Connection = new MySqlConnection(ConnectionString);
        }
    }
    
    }

