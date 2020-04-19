using System;
using System.Data.SqlClient;
using pomdyBackend.DAO;

namespace pomdyBackend.Model
{
    public class RoomStudent
    {
        public int IdRoom { get; set; }
        public int IdStudent { get; set; }

        public RoomStudent(){}

        public RoomStudent(int idRoom, int idStudent)
        {
            IdRoom = idRoom;
            IdStudent = idStudent;
        }

        public RoomStudent(SqlDataReader sqlDataReader)
        {
            IdRoom = Convert.ToInt32(sqlDataReader[RoomStudentDAO.FIELD_IDROOM].ToString());
            IdStudent = Convert.ToInt32(sqlDataReader[RoomStudentDAO.FIELD_IDSTUDENT].ToString());
        }
    }
}