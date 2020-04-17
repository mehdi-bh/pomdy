using System.Collections.Generic;
using System.Data.SqlClient;
using pomdyBackend.Model;

namespace pomdyBackend.DAO
{
    public class TeamDAO
    {
        // Const
        private static readonly string TABLE_NAME = "team";
        
        public static readonly string FIELD_ID = "id";
        public static readonly string FIELD_NAME = "name";
        public static readonly string FIELD_ISARCHIVED = "isArchived";
        
        // GET ALL | /groups
        private static readonly string REQ_GET_ALL = $"SELECT * FROM {TABLE_NAME}";
        public static IEnumerable<Team> GetAll()
        {
            List<Team> groups = new List<Team>();
            using (var connection = Database.GetConnection())
            {
                connection.Open();

                SqlCommand command = connection.CreateCommand();
                command.CommandText = REQ_GET_ALL;

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    groups.Add(new Team(reader));
                }
            }
            return groups;
        }
    }
}