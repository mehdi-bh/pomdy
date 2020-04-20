using System.Collections.Generic;
using System.Data.SqlClient;
using pomdyBackend.Model;

namespace pomdyBackend.DAO
{
    public class RoomStudentDAO
    {
        /***** Constants *****/
        public static readonly string TABLE_NAME = "room_student";
        
        public static readonly string FIELD_IDROOM = "idRoom";
        public static readonly string FIELD_IDSTUDENT = "idStudent";
        
        /***** Requests *****/
        private static readonly string REQ_GET_STUDENT_ROOMS
            = string.Format("SELECT * FROM {1} INNER JOIN {0} ON {1}.{2} = {0}.{3} where {0}.{4} = @{5}"
                ,TABLE_NAME, RoomDAO.TABLE_NAME, RoomDAO.FIELD_ID, FIELD_IDROOM, FIELD_IDSTUDENT, StudentDAO.FIELD_ID);
        
        private static readonly string REQ_GET_ROOM_STUDENTS
            = string.Format("SELECT * FROM {1} INNER JOIN {0} ON {1}.{2} = {0}.{3} where {0}.{4} = @{5}"
                ,TABLE_NAME, StudentDAO.TABLE_NAME, StudentDAO.FIELD_ID, FIELD_IDSTUDENT, FIELD_IDROOM, RoomDAO.FIELD_ID);
        
        private static readonly string REQ_POST
            = $"INSERT INTO {TABLE_NAME} ({FIELD_IDROOM}, {FIELD_IDSTUDENT}) VALUES (@{FIELD_IDROOM}, @{FIELD_IDSTUDENT})";

        private static string REQ_DELETE
            = $"DELETE FROM {TABLE_NAME} WHERE {FIELD_IDROOM} = @{FIELD_IDROOM} AND {FIELD_IDSTUDENT} = @{FIELD_IDSTUDENT}";
        
        /***** Methods *****/
        public static List<Room> GetStudentRooms(int id)
        {
            List<Room> rooms = new List<Room>();
            
            using (var connection = Database.GetConnection())
            {
                connection.Open();
                SqlCommand command = connection.CreateCommand();
                
                command.CommandText = REQ_GET_STUDENT_ROOMS;
                command.Parameters.AddWithValue($"@{StudentDAO.FIELD_ID}", id);
                
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    rooms.Add(new Room(reader));
                }
            }
            return rooms;
        }
        
        public static List<Student> GetRoomStudents(int id)
        {
            List<Student> students = new List<Student>();
            
            using (var connection = Database.GetConnection())
            {
                connection.Open();
                SqlCommand command = connection.CreateCommand();
                
                command.CommandText = REQ_GET_ROOM_STUDENTS;
                command.Parameters.AddWithValue($"@{RoomDAO.FIELD_ID}", id);
                
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    students.Add(new Student(reader));
                }
            }
            return students;
        }
        
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