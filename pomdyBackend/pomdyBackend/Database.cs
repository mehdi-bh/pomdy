﻿﻿﻿using System.Data.SqlClient;
namespace pomdyBackend
{
    public class Database
    {
        private static readonly string DATABASE_NAME = "Pomdy";
        private static readonly string USER_NAME = "DESKTOP-I66418F";
        private static readonly string CONNECTION_STRING = $"Server={USER_NAME};Integrated Security=SSPI;Database={DATABASE_NAME}";
        
        public static SqlConnection GetConnection()
        {
            return new SqlConnection(CONNECTION_STRING);
        }
    }
}