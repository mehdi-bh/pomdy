using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using pomdyBackend.Model;

namespace pomdyBackend.DAO
{
    public class ExtrabreakDAO
    {
        // Const
        private static readonly string TABLE_NAME = "extrabreak";
        
        public static readonly string FIELD_ID = "id";
        public static readonly string FIELD_IDSESSION = "idSession";
        public static readonly string FIELD_ISARCHIVED = "isArchived";
        public static readonly string FIELD_REASON = "reason";
        public static readonly string FIELD_DURATION = "duration";
        public static readonly string FIELD_STARTDATE = "startDate";
        
        // GET ALL | /extrabreaks
        private static readonly string REQ_GET_ALL = $"SELECT * FROM {TABLE_NAME}";
        
        // POST
        private static readonly string REQ_POST
            = string.Format(
                "INSERT INTO {0} ({1}, {2}, {3}, {4}, {5}) OUTPUT Inserted.{6} VALUES (@{1}, @{2}, @{3}, @{4}, @{5})",
                TABLE_NAME, 
                FIELD_REASON,
                FIELD_DURATION,
                FIELD_IDSESSION,
                FIELD_STARTDATE,
                FIELD_ISARCHIVED,
                FIELD_ID
            );

        public static IEnumerable<Extrabreak> GetAll()
        {
            List<Extrabreak> extrabreaks = new List<Extrabreak>();
            using (var connection = Database.GetConnection())
            {
                connection.Open();

                SqlCommand command = connection.CreateCommand();
                command.CommandText = REQ_GET_ALL;

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    extrabreaks.Add(new Extrabreak(reader));
                }
            }
            return extrabreaks;
        }
        
        public static Extrabreak Post(Extrabreak extrabreak)
        {
            using (SqlConnection connection = Database.GetConnection())
            {
                connection.Open();

                SqlCommand command = connection.CreateCommand();
                
                command.CommandText = REQ_POST;
                
                // Optional rules
                bool reasonIsBlank = string.IsNullOrEmpty(extrabreak.Reason);
                command.Parameters.AddWithValue($"@{FIELD_REASON}", reasonIsBlank ? "" : extrabreak.Reason);

                command.Parameters.AddWithValue($"@{FIELD_DURATION}", extrabreak.Duration);
                command.Parameters.AddWithValue($"@{FIELD_IDSESSION}", extrabreak.IdSession);
                command.Parameters.AddWithValue($"@{FIELD_STARTDATE}", extrabreak.StartDate);
                command.Parameters.AddWithValue($"@{FIELD_ISARCHIVED}", extrabreak.IsArchived);

                extrabreak.Id = (int) command.ExecuteScalar();

                return extrabreak;
            }
        }
    }
}