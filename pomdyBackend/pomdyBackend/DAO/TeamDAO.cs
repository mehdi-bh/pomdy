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
        
        // GET ALL | /teams
        private static readonly string REQ_GET_ALL = $"SELECT * FROM {TABLE_NAME}";
        
        // POST
        private static readonly string REQ_POST
            = string.Format(
                "INSERT INTO {0} ({1}, {2}) OUTPUT Inserted.{3} VALUES (@{1}, @{2})",
                TABLE_NAME, 
                FIELD_ISARCHIVED,
                FIELD_NAME,
                FIELD_ID
            );
        public static IEnumerable<Team> GetAll()
        {
            List<Team> teams = new List<Team>();
            using (var connection = Database.GetConnection())
            {
                connection.Open();

                SqlCommand command = connection.CreateCommand();
                command.CommandText = REQ_GET_ALL;

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    teams.Add(new Team(reader));
                }
            }
            return teams;
        }
        
        public static Team Post(Team team)
        {
            using (SqlConnection connection = Database.GetConnection())
            {
                connection.Open();

                SqlCommand command = connection.CreateCommand();
                
                command.CommandText = REQ_POST;

                command.Parameters.AddWithValue($"@{FIELD_ISARCHIVED}", team.IsArchived);
                command.Parameters.AddWithValue($"@{FIELD_NAME}", team.Name);

                team.Id = (int) command.ExecuteScalar();

                return team;
            }
        }
    }
}