

using System;
using System.Data.SqlClient;
using pomdyBackend.DAO;

namespace pomdyBackend.Model
{
    public class Session
    {
        public int Id { get; set; }
        public bool IsArchived { get; set; }
        public int IdStudent { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int WorkTime { get; set; }
        public int BreakTime { get; set; }
        public int Score { get; set; }

        public Session(){}

        public Session(int id, bool isArchived, int idStudent, int idProject, string name, string description, DateTime startDate, DateTime endDate, int workTime, int breakTime, int score)
        {
            Id = id;
            IsArchived = isArchived;
            IdStudent = idStudent;
            Name = name;
            Description = description;
            StartDate = startDate;
            EndDate = endDate;
            WorkTime = workTime;
            BreakTime = breakTime;
            Score = score;
        }
        

        public Session(SqlDataReader sqlDataReader)
        {
            Id = Convert.ToInt32(sqlDataReader[SessionDAO.FIELD_ID].ToString());
            IsArchived = Convert.ToBoolean(sqlDataReader[SessionDAO.FIELD_ISARCHIVED].ToString());
            IdStudent = Convert.ToInt32(sqlDataReader[SessionDAO.FIELD_IDSTUDENT].ToString());
            Name = sqlDataReader[SessionDAO.FIELD_NAME].ToString();
            Description = sqlDataReader[SessionDAO.FIELD_DESCRIPTION].ToString();
            StartDate = Convert.ToDateTime(sqlDataReader[SessionDAO.FIELD_STARTDATE].ToString());
            EndDate = Convert.ToDateTime(sqlDataReader[SessionDAO.FIELD_ENDDATE].ToString());
            WorkTime = Convert.ToInt32(sqlDataReader[SessionDAO.FIELD_WORKTIME].ToString());
            BreakTime = Convert.ToInt32(sqlDataReader[SessionDAO.FIELD_BREAKTIME].ToString());
            Score = Convert.ToInt32(sqlDataReader[SessionDAO.FIELD_SCORE].ToString());
        }
    }
}
