using System.Collections.Generic;
using System.Data.SqlClient;
using pomdyBackend.Model;

namespace pomdyBackend.DAO
{
    public class ProjectDAO
    {
        // Const
        private static readonly string TABLE_NAME = "project";
        
        public static readonly string FIELD_ID = "id";
        public static readonly string FIELD_IDSTUDENT = "idStudent";
        public static readonly string FIELD_IDTEAM = "idTeam";
        public static readonly string FIELD_NAME = "name";
        public static readonly string FIELD_DESCRIPTION = "description";
        
        // GET ALL | /extrabreaks
        private static readonly string REQ_GET_ALL = $"SELECT * FROM {TABLE_NAME}";
        public static IEnumerable<Project> GetAll()
        {
            List<Project> projects = new List<Project>();
            using (var connection = Database.GetConnection())
            {
                connection.Open();

                SqlCommand command = connection.CreateCommand();
                command.CommandText = REQ_GET_ALL;

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    projects.Add(new Project(reader));
                }
            }
            return projects;
        }
    }
}