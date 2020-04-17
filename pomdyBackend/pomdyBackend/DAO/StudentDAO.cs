using System.Collections.Generic;
using System.Data.SqlClient;
using pomdyBackend.Model;

namespace pomdyBackend.DAO
{
    public class StudentDAO
    {
        // Const
        private static readonly string TABLE_NAME = "student";
        
        public static readonly string FIELD_ID = "id";
        public static readonly string FIELD_ISARCHIVED = "isArchived";
        public static readonly string FIELD_ISGHOSTMODE = "isGhostMode";
        public static readonly string FIELD_NICKNAME = "nickName";
        public static readonly string FIELD_PASSWORD = "password";
        public static readonly string FIELD_MAIL = "mail";
        public static readonly string FIELD_TOKEN = "token";
        public static readonly string FIELD_FIRSTNAME = "firstName";
        public static readonly string FIELD_LASTNAME = "lastName";
        public static readonly string FIELD_DESCRIPTION = "description";
        public static readonly string FIELD_BIRTHDATE = "birthDate";
        public static readonly string FIELD_DIPLOMANAME = "diplomaName";
        public static readonly string FIELD_SCHOOL = "school";
        public static readonly string FIELD_PHOTO = "photo";
        
        // GET ALL | /students
        private static readonly string REQ_GET_ALL = $"SELECT * FROM {TABLE_NAME}";
        
        // POST | without optional
        private static readonly string REQ_POST
            = string.Format(
                "INSERT INTO {0} ({1}, {2}, {3}, {4}, {5}, {6}, {7}) OUTPUT Inserted.{8} VALUES (@{1}, @{2}, @{3}, @{4}, @{5}, @{6}, @{7})",
                TABLE_NAME, 
                FIELD_ISARCHIVED,
                FIELD_ISGHOSTMODE,
                FIELD_NICKNAME,
                FIELD_PASSWORD,
                FIELD_MAIL,
                FIELD_TOKEN,
                FIELD_BIRTHDATE,
                FIELD_ID
            );
        
        public static IEnumerable<Student> GetAll()
        {
            List<Student> students = new List<Student>();
            using (var connection = Database.GetConnection())
            {
                connection.Open();

                SqlCommand command = connection.CreateCommand();
                command.CommandText = REQ_GET_ALL;

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    students.Add(new Student(reader));
                }
            }
            return students;
        }
        
        
        
        public static Student Post(Student student)
        {
            using (SqlConnection connection = Database.GetConnection())
            {
                connection.Open();

                SqlCommand command = connection.CreateCommand();
                
                command.CommandText = REQ_POST;

                command.Parameters.AddWithValue($"@{FIELD_ISARCHIVED}", student.IsArchived);
                command.Parameters.AddWithValue($"@{FIELD_ISGHOSTMODE}", student.IsGhostMode);
                command.Parameters.AddWithValue($"@{FIELD_NICKNAME}", student.NickName);
                command.Parameters.AddWithValue($"@{FIELD_PASSWORD}", student.Password);
                command.Parameters.AddWithValue($"@{FIELD_MAIL}", student.Mail);
                command.Parameters.AddWithValue($"@{FIELD_TOKEN}", student.Token);
                command.Parameters.AddWithValue($"@{FIELD_BIRTHDATE}", student.BirthDate);
                
                student.Id = (int) command.ExecuteScalar();

                return student;
            }
        }
            
        
    }
}