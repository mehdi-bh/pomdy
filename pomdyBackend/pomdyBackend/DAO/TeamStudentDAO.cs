using System.Collections.Generic;
using System.Data.SqlClient;
using pomdyBackend.Model;

namespace pomdyBackend.DAO
{
    public class TeamStudentDAO
    {
        /***** Constants *****/
        public static readonly string TABLE_NAME = "team_student";
        
        public static readonly string FIELD_IDTEAM = "idTeam";
        public static readonly string FIELD_IDSTUDENT = "idStudent";
        
        /***** Requests *****/
        private static readonly string REQ_GET_STUDENT_TEAMS
            = string.Format("SELECT * FROM {1} INNER JOIN {0} ON {1}.{2} = {0}.{3} where {0}.{4} = @{5}"
                ,TABLE_NAME, TeamDAO.TABLE_NAME, TeamDAO.FIELD_ID, FIELD_IDTEAM, FIELD_IDSTUDENT, StudentDAO.FIELD_ID);
        
        private static readonly string REQ_GET_TEAM_STUDENTS
            = string.Format("SELECT * FROM {1} INNER JOIN {0} ON {1}.{2} = {0}.{3} where {0}.{4} = @{5}"
                ,TABLE_NAME, StudentDAO.TABLE_NAME, StudentDAO.FIELD_ID, FIELD_IDSTUDENT, FIELD_IDTEAM, TeamDAO.FIELD_ID);
        
        private static readonly string REQ_POST
            = $"INSERT INTO {TABLE_NAME} ({FIELD_IDTEAM}, {FIELD_IDSTUDENT}) VALUES (@{FIELD_IDTEAM}, @{FIELD_IDSTUDENT})";

        private static string REQ_DELETE
            = $"DELETE FROM {TABLE_NAME} WHERE {FIELD_IDTEAM} = @{FIELD_IDTEAM} AND {FIELD_IDSTUDENT} = @{FIELD_IDSTUDENT}";
        
        /***** Methods *****/
        public static List<Team> GetStudentTeams(int id)
        {
            List<Team> teams = new List<Team>();
            
            using (var connection = Database.GetConnection())
            {
                connection.Open();
                SqlCommand command = connection.CreateCommand();
                
                command.CommandText = REQ_GET_STUDENT_TEAMS;
                command.Parameters.AddWithValue($"@{StudentDAO.FIELD_ID}", id);
                
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    teams.Add(new Team(reader));
                }
            }
            return teams;
        }
        
        public static List<Student> GetTeamStudents(int id)
        {
            List<Student> students = new List<Student>();
            
            using (var connection = Database.GetConnection())
            {
                connection.Open();
                SqlCommand command = connection.CreateCommand();
                
                command.CommandText = REQ_GET_TEAM_STUDENTS;
                command.Parameters.AddWithValue($"@{TeamDAO.FIELD_ID}", id);
                
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    students.Add(new Student(reader));
                }
            }
            return students;
        }
        
        public static bool Post(TeamStudent teamStudent)
        {
            using (var connection = Database.GetConnection())
            {
                connection.Open();
                SqlCommand command = connection.CreateCommand();

                command.CommandText = REQ_POST;
                command.Parameters.AddWithValue($"@{FIELD_IDTEAM}", teamStudent.IdTeam);
                command.Parameters.AddWithValue($"@{FIELD_IDSTUDENT}", teamStudent.IdStudent);
                
                return command.ExecuteNonQuery() == 1;
            }
        }

        public static bool Delete(TeamStudent teamStudent)
        {
            using (var connection = Database.GetConnection())
            {
                connection.Open();
                SqlCommand command = connection.CreateCommand();

                command.CommandText = REQ_DELETE;
                command.Parameters.AddWithValue($"@{FIELD_IDTEAM}", teamStudent.IdTeam);
                command.Parameters.AddWithValue($"@{FIELD_IDSTUDENT}", teamStudent.IdStudent);

                return command.ExecuteNonQuery() == 1;
            }
        }
    }
}