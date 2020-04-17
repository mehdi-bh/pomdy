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
    }
}