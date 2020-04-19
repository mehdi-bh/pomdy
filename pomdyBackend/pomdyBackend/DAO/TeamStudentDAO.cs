using System.Collections.Generic;
using System.Data.SqlClient;
using pomdyBackend.Model;

namespace pomdyBackend.DAO
{
    public class TeamStudentDAO
    {
        /***** Constants *****/
        private static readonly string TABLE_NAME = "team_student";
        
        public static readonly string FIELD_IDTEAM = "idTeam";
        public static readonly string FIELD_IDSTUDENT = "idStudent";
        
        /***** Requests *****/
        private static readonly string REQ_POST
            = $"INSERT INTO {TABLE_NAME} ({FIELD_IDTEAM}, {FIELD_IDSTUDENT}) VALUES (@{FIELD_IDTEAM}, @{FIELD_IDSTUDENT})";

        private static string REQ_DELETE
            = $"DELETE FROM {TABLE_NAME} WHERE {FIELD_IDTEAM} = @{FIELD_IDTEAM} AND {FIELD_IDSTUDENT} = @{FIELD_IDSTUDENT}";
        
        /***** Methods *****/
        public static bool Post(TeamStudent teamStudent)
        {
            using (var connection = Database.GetConnection())
            {
                connection.Open();
                SqlCommand command = connection.CreateCommand();

                command.CommandText = REQ_POST;
                command.Parameters.AddWithValue($"@{FIELD_IDTEAM}", teamStudent.IdTeam);
                command.Parameters.AddWithValue($"@{FIELD_IDSTUDENT}", teamStudent.IdStudent);
                
                return command.ExecuteNonQuery() == 1;
            }
        }

        public static bool Delete(TeamStudent teamStudent)
        {
            using (var connection = Database.GetConnection())
            {
                connection.Open();
                SqlCommand command = connection.CreateCommand();

                command.CommandText = REQ_DELETE;
                command.Parameters.AddWithValue($"@{FIELD_IDTEAM}", teamStudent.IdTeam);
                command.Parameters.AddWithValue($"@{FIELD_IDSTUDENT}", teamStudent.IdStudent);

                return command.ExecuteNonQuery() == 1;
            }
        }
    }
}