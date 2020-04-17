using System.Collections.Generic;
using System.Data.SqlClient;
using pomdyBackend.Model;

namespace pomdyBackend.DAO
{
    public class RoomDAO
    {
        // Const
        private static readonly string TABLE_NAME = "room";
        
        public static readonly string FIELD_ID = "id";
        public static readonly string FIELD_NAME = "name";
        public static readonly string FIELD_ISARCHIVED = "isArchived";
        
        // GET ALL | /rooms
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
        public static IEnumerable<Room> GetAll()
        {
            List<Room> rooms = new List<Room>();
            using (var connection = Database.GetConnection())
            {
                connection.Open();

                SqlCommand command = connection.CreateCommand();
                command.CommandText = REQ_GET_ALL;

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    rooms.Add(new Room(reader));
                }
            }
            return rooms;
        }
        
        public static Room Post(Room room)
        {
            using (SqlConnection connection = Database.GetConnection())
            {
                connection.Open();

                SqlCommand command = connection.CreateCommand();
                
                command.CommandText = REQ_POST;

                command.Parameters.AddWithValue($"@{FIELD_ISARCHIVED}", room.IsArchived);
                command.Parameters.AddWithValue($"@{FIELD_NAME}", room.Name);

                room.Id = (int) command.ExecuteScalar();

                return room;
            }
        }
    }
}