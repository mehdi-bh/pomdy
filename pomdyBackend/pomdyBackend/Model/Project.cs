using System;
using System.Data.SqlClient;
using pomdyBackend.DAO;

namespace pomdyBackend.Model
{
    public class Project
    {
        public int Id { get; set; }
        public int IdStudent { get; set; }
        public int IdTeam { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public Project(){}

        public Project(int id, int idStudent, int idTeam, string name, string description)
        {
            Id = id;
            IdStudent = idStudent;
            IdTeam = idTeam;
            Name = name;
            Description = description;
        }

        public Project(SqlDataReader sqlDataReader)
        {
            Id = Convert.ToInt32(sqlDataReader[ProjectDAO.FIELD_ID].ToString());
            IdStudent = Convert.ToInt32(sqlDataReader[ProjectDAO.FIELD_IDSTUDENT].ToString());
            IdTeam = Convert.ToInt32(sqlDataReader[ProjectDAO.FIELD_IDTEAM].ToString());
            Name = sqlDataReader[ProjectDAO.FIELD_NAME].ToString();
            Description = sqlDataReader[ProjectDAO.FIELD_DESCRIPTION].ToString();
        }
    }
}