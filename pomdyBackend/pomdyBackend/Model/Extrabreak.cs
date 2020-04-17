using System;
using System.Data.SqlClient;
using pomdyBackend.DAO;

namespace pomdyBackend.Model
{
    public class Extrabreak
    {
        public int Id { get; set; }
        public int IdSession { get; set; }
        public bool IsArchived { get; set; }
        public string Reason { get; set; }
        public int Duration { get; set; }
        public DateTime StartDate { get; set; }

        public Extrabreak(){}

        public Extrabreak(int id, int idSession, bool isArchived, string reason, int duration, DateTime startDate)
        {
            Id = id;
            IdSession = idSession;
            IsArchived = isArchived;
            Reason = reason;
            Duration = duration;
            StartDate = startDate;
        }

        public Extrabreak(SqlDataReader sqlDataReader)
        {
            Id = Convert.ToInt32(sqlDataReader[ExtrabreakDAO.FIELD_ID].ToString());
            IdSession = Convert.ToInt32(sqlDataReader[ExtrabreakDAO.FIELD_IDSESSION].ToString());
            IsArchived = Convert.ToBoolean(sqlDataReader[ExtrabreakDAO.FIELD_ISARCHIVED].ToString());
            Reason = sqlDataReader[ExtrabreakDAO.FIELD_REASON].ToString();
            Duration = Convert.ToInt32(sqlDataReader[ExtrabreakDAO.FIELD_DURATION].ToString());
            StartDate = Convert.ToDateTime(sqlDataReader[ExtrabreakDAO.FIELD_STARTDATE].ToString());
        }
    }
}