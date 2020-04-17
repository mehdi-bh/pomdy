using System;
using System.Data.SqlClient;
using pomdyBackend.DAO;

namespace pomdyBackend.Model
{
    public class Room
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsArchived { get; set; }

        public Room(){}

        public Room(int id, string name, bool isArchived)
        {
            Id = id;
            Name = name;
            IsArchived = isArchived;
        }

        public Room(SqlDataReader sqlDataReader)
        {
            Id = Convert.ToInt32(sqlDataReader[RoomDAO.FIELD_ID].ToString());
            Name = sqlDataReader[SessionDAO.FIELD_NAME].ToString();
            IsArchived = Convert.ToBoolean(sqlDataReader[SessionDAO.FIELD_ISARCHIVED].ToString());
        }
    }
}