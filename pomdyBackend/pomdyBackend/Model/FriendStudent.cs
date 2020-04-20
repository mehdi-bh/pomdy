using System;
using System.Data.SqlClient;
using pomdyBackend.DAO;

namespace pomdyBackend.Model
{
    public class FriendStudent
    {
        public int IdFirstStudent { get; set; }
        public int IdSecondStudent { get; set; }

        public FriendStudent(){}

        public FriendStudent(int idFirstStudent, int idSecondStudent)
        {
            IdFirstStudent = idFirstStudent;
            IdSecondStudent = idSecondStudent;
        }

        public FriendStudent(SqlDataReader sqlDataReader)
        {
            IdFirstStudent = Convert.ToInt32(sqlDataReader[FriendStudentDAO.FIELD_IDFIRSTSTUDENT].ToString());
            IdSecondStudent = Convert.ToInt32(sqlDataReader[FriendStudentDAO.FIELD_IDSECONDSTUDENT].ToString());
        }
    }
}