using System.Collections.Generic;
using System.Data.SqlClient;
using pomdyBackend.Model;

namespace pomdyBackend.DAO
{
    public class TeamDAO
    {
        /***** Constants *****/
        private static readonly string TABLE_NAME = "team";
        
        public static readonly string FIELD_ID = "id";
        public static readonly string FIELD_NAME = "name";
        public static readonly string FIELD_ISARCHIVED = "isArchived";
        
        /***** Requests *****/
        private static readonly string REQ_GET_ALL = $"SELECT * FROM {TABLE_NAME}";
        
        private static readonly string REQ_GET_BY_ID = REQ_GET_ALL + $" WHERE {FIELD_ID} = @{FIELD_ID}";
        
        private static readonly string REQ_POST
            = string.Format(
                "INSERT INTO {0} ({1}, {2}) OUTPUT Inserted.{3} VALUES (@{1}, @{2})",
                TABLE_NAME, 
                FIELD_ISARCHIVED,
                FIELD_NAME,
                FIELD_ID
            );
        
        private static readonly string REQ_PUT = $"UPDATE {TABLE_NAME} SET {FIELD_ISARCHIVED} = @{FIELD_ISARCHIVED}," +
                                                 $" {FIELD_NAME} = @{FIELD_NAME} " +
                                                 $" WHERE {FIELD_ID} = @{FIELD_ID}";
        
        private static readonly string REQ_DELETE = $"DELETE FROM {TABLE_NAME} WHERE {FIELD_ID} = @{FIELD_ID}";
        
        /***** Methods *****/
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
        
        public static Team Get(int id)
        {
            using (var connection = Database.GetConnection())
            {
                connection.Open();
        
                SqlCommand command = connection.CreateCommand();
                command.CommandText = REQ_GET_BY_ID;
        
                command.Parameters.AddWithValue($"@{FIELD_ID}", id);
        
                SqlDataReader reader = command.ExecuteReader();
        
                return reader.Read() ? new Team(reader) : null;
            }
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
        
        public static bool Put(Team team)
        {
            bool hasBeenChanged = false;

            using (SqlConnection connection = Database.GetConnection())
            {
                connection.Open();
                SqlCommand command = connection.CreateCommand();
                command.CommandText = REQ_PUT;
                
                command.Parameters.AddWithValue($"@{FIELD_ISARCHIVED}", team.IsArchived);
                command.Parameters.AddWithValue($"@{FIELD_NAME}", team.Name);

                command.Parameters.AddWithValue($"@{FIELD_ID}", team.Id);

                hasBeenChanged = command.ExecuteNonQuery() == 1;
            }
            return hasBeenChanged;
        }
        
        public static bool Delete(int id)
        {
            bool hasBeenDeleted = false;

            using (SqlConnection connection = Database.GetConnection())
            {
                connection.Open();
                SqlCommand command = connection.CreateCommand();
                command.CommandText = REQ_DELETE;

                command.Parameters.AddWithValue($@"{FIELD_ID}", id);
                
                hasBeenDeleted = command.ExecuteNonQuery() == 1;
            }
            
            return hasBeenDeleted;
        }
    }
}