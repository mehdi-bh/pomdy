using System.Collections.Generic;
using System.Data.SqlClient;
using pomdyBackend.Model;

namespace pomdyBackend.DAO
{
    public class SessionDAO
    {
        // Const
        private static readonly string TABLE_NAME = "session";
        
        public static readonly string FIELD_ID = "id";
        public static readonly string FIELD_ISARCHIVED = "isArchived";
        public static readonly string FIELD_IDSTUDENT = "idStudent";
        public static readonly string FIELD_IDPROJECT = "idProject";
        public static readonly string FIELD_NAME = "name";
        public static readonly string FIELD_DESCRIPTION = "description";
        public static readonly string FIELD_STARTDATE = "startDate";
        public static readonly string FIELD_ENDDATE = "endDate";
        public static readonly string FIELD_WORKTIME = "workTime";
        public static readonly string FIELD_BREAKTIME = "breakTime";
        public static readonly string FIELD_SCORE = "score";
        
        // GET ALL
        private static readonly string REQ_GET_ALL = $"SELECT * FROM {TABLE_NAME}";
        
        // POST WITH PROJECT
        private static readonly string REQ_POST_WITH_PROJECT
            = string.Format(
                "INSERT INTO {0} ({1}, {2}, {3}, {4}, {5}, {6}, {7}, {8}, {9}, {10}) OUTPUT Inserted.{11} VALUES (@{1}, @{2}, @{3}, @{4}, @{5}, @{6}, @{7}, @{8}, @{9}, @{10})",
                TABLE_NAME, 
                FIELD_ISARCHIVED,
                FIELD_IDSTUDENT,
                FIELD_IDPROJECT,
                FIELD_NAME,
                FIELD_DESCRIPTION,
                FIELD_STARTDATE,
                FIELD_ENDDATE,
                FIELD_WORKTIME,
                FIELD_BREAKTIME,
                FIELD_SCORE,
                FIELD_ID
            );
        
        // POST WITHOUT PROJECT
        private static readonly string REQ_POST_WITHOUT_PROJECT
            = string.Format(
                "INSERT INTO {0} ({1}, {2}, {3}, {4}, {5}, {6}, {7}, {8}, {9}) OUTPUT Inserted.{10} VALUES (@{1}, @{2}, @{3}, @{4}, @{5}, @{6}, @{7}, @{8}, @{9})",
                TABLE_NAME, 
                FIELD_ISARCHIVED,
                FIELD_IDSTUDENT,
                FIELD_NAME,
                FIELD_DESCRIPTION,
                FIELD_STARTDATE,
                FIELD_ENDDATE,
                FIELD_WORKTIME,
                FIELD_BREAKTIME,
                FIELD_SCORE,
                FIELD_ID
            );
        
        public static IEnumerable<Session> GetAll()
        {
            List<Session> sessions = new List<Session>();
            using (var connection = Database.GetConnection())
            {
                connection.Open();

                SqlCommand command = connection.CreateCommand();
                command.CommandText = REQ_GET_ALL;

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    sessions.Add(new Session(reader));
                }
            }
            return sessions;
        }

        public static Session Post(Session session)
        {
            using (SqlConnection connection = Database.GetConnection())
            {
                connection.Open();

                SqlCommand command = connection.CreateCommand();

                // Optional rules
                if (session.IdProject == 0)
                {
                    command.CommandText = REQ_POST_WITHOUT_PROJECT;
                }
                else
                {
                    command.CommandText = REQ_POST_WITH_PROJECT;
                    command.Parameters.AddWithValue($"@{FIELD_IDPROJECT}", session.IdProject);
                }
                
                command.Parameters.AddWithValue($"@{FIELD_ISARCHIVED}", session.IsArchived);
                command.Parameters.AddWithValue($"@{FIELD_IDSTUDENT}", session.IdStudent);
                command.Parameters.AddWithValue($"@{FIELD_NAME}", session.Name);
                command.Parameters.AddWithValue($"@{FIELD_DESCRIPTION}", session.Description);
                command.Parameters.AddWithValue($"@{FIELD_STARTDATE}", session.StartDate);
                command.Parameters.AddWithValue($"@{FIELD_ENDDATE}", session.EndDate);
                command.Parameters.AddWithValue($"@{FIELD_WORKTIME}", session.WorkTime);
                command.Parameters.AddWithValue($"@{FIELD_BREAKTIME}", session.BreakTime);
                command.Parameters.AddWithValue($"@{FIELD_SCORE}", session.Score);

                session.Id = (int) command.ExecuteScalar();

                return session;
            }
        }
    }
}