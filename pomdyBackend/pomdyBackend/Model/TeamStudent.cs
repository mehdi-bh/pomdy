using System;
using System.Data.SqlClient;
using pomdyBackend.DAO;

namespace pomdyBackend.Model
{
    public class TeamStudent
    {
        public int IdTeam { get; set; }
        public int IdStudent { get; set; }

        public TeamStudent(){}

        public TeamStudent(int idTeam, int idStudent)
        {
            IdTeam = idTeam;
            IdStudent = idStudent;
        }

        public TeamStudent(SqlDataReader sqlDataReader)
        {
            IdTeam = Convert.ToInt32(sqlDataReader[TeamStudentDAO.FIELD_IDTEAM].ToString());
            IdStudent = Convert.ToInt32(sqlDataReader[TeamStudentDAO.FIELD_IDSTUDENT].ToString());
        }
    }
}