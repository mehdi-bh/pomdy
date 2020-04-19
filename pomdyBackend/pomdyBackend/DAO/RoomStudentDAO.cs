using System.Data.SqlClient;
using pomdyBackend.Model;

namespace pomdyBackend.DAO
{
    public class RoomStudentDAO
    {
        /***** Constants *****/
        private static readonly string TABLE_NAME = "room_student";
        
        public static readonly string FIELD_IDROOM = "idRoom";
        public static readonly string FIELD_IDSTUDENT = "idStudent";
        
        /***** Requests *****/
        private static readonly string REQ_POST
            = $"INSERT INTO {TABLE_NAME} ({FIELD_IDROOM}, {FIELD_IDSTUDENT}) VALUES (@{FIELD_IDROOM}, @{FIELD_IDSTUDENT})";

        private static string REQ_DELETE
            = $"DELETE FROM {TABLE_NAME} WHERE {FIELD_IDROOM} = @{FIELD_IDROOM} AND {FIELD_IDSTUDENT} = @{FIELD_IDSTUDENT}";
        
        /***** Methods *****/
        public static bool Post(RoomStudent roomStudent)
        {
            using (var connection = Database.GetConnection())
            {
                connection.Open();
                SqlCommand command = connection.CreateCommand();

                command.CommandText = REQ_POST;
                command.Parameters.AddWithValue($"@{FIELD_IDROOM}", roomStudent.IdRoom);
                command.Parameters.AddWithValue($"@{FIELD_IDSTUDENT}", roomStudent.IdStudent);
                
                return command.ExecuteNonQuery() == 1;
            }
        }

        public static bool Delete(RoomStudent roomStudent)
        {
            using (var connection = Database.GetConnection())
            {
                connection.Open();
                SqlCommand command = connection.CreateCommand();

                command.CommandText = REQ_DELETE;
                command.Parameters.AddWithValue($"@{FIELD_IDROOM}", roomStudent.IdRoom);
                command.Parameters.AddWithValue($"@{FIELD_IDSTUDENT}", roomStudent.IdStudent);

                return command.ExecuteNonQuery() == 1;
            }
        }
    }
}