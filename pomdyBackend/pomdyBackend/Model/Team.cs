using System;
using System.Data.SqlClient;
using pomdyBackend.DAO;

namespace pomdyBackend.Model
{
    public class Team
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsArchived { get; set; }

        public Team(){}

        public Team(int id, string name, bool isArchived)
        {
            Id = id;
            Name = name;
            IsArchived = isArchived;
        }

        public Team(SqlDataReader sqlDataReader)
        {
            Id = Convert.ToInt32(sqlDataReader[TeamDAO.FIELD_ID].ToString());
            Name = sqlDataReader[TeamDAO.FIELD_NAME].ToString();
            IsArchived = Convert.ToBoolean(sqlDataReader[TeamDAO.FIELD_ISARCHIVED].ToString());
        }
    }
}