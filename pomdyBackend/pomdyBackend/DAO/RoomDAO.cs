using System.Collections.Generic;
using System.Data.SqlClient;
using pomdyBackend.Model;

namespace pomdyBackend.DAO
{
    public class RoomDAO
    {
        /***** Constants *****/
        public static readonly string TABLE_NAME = "room";
        
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
        
        public static Room Get(int id)
        {
            using (var connection = Database.GetConnection())
            {
                connection.Open();
        
                SqlCommand command = connection.CreateCommand();
                command.CommandText = REQ_GET_BY_ID;
        
                command.Parameters.AddWithValue($"@{FIELD_ID}", id);
        
                SqlDataReader reader = command.ExecuteReader();
        
                return reader.Read() ? new Room(reader) : null;
            }
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
        
        public static bool Put(Room room)
        {
            bool hasBeenChanged = false;

            using (SqlConnection connection = Database.GetConnection())
            {
                connection.Open();
                SqlCommand command = connection.CreateCommand();
                command.CommandText = REQ_PUT;
                
                command.Parameters.AddWithValue($"@{FIELD_ISARCHIVED}", room.IsArchived);
                command.Parameters.AddWithValue($"@{FIELD_NAME}", room.Name);

                command.Parameters.AddWithValue($"@{FIELD_ID}", room.Id);

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