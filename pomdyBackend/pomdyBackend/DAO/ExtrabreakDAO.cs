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
    }
}