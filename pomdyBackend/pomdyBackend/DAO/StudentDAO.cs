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
        
        // POST | without optional | account creating
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
        
        // PUT | with all fields | modify account
        private static readonly string REQ_PUT = $"UPDATE {TABLE_NAME} SET {FIELD_ISARCHIVED} = @{FIELD_ISARCHIVED}," +
                                                    $" {FIELD_ISGHOSTMODE} = @{FIELD_ISGHOSTMODE}," +
                                                    $" {FIELD_NICKNAME} = @{FIELD_NICKNAME}," +
                                                    $" {FIELD_PASSWORD} = @{FIELD_PASSWORD}," +
                                                    $" {FIELD_MAIL} = @{FIELD_MAIL}," +
                                                    $" {FIELD_TOKEN} = @{FIELD_TOKEN}," +
                                                    $" {FIELD_FIRSTNAME} = @{FIELD_FIRSTNAME}," +
                                                    $" {FIELD_LASTNAME} = @{FIELD_LASTNAME}," +
                                                    $" {FIELD_DESCRIPTION} = @{FIELD_DESCRIPTION}," +
                                                    $" {FIELD_BIRTHDATE} = @{FIELD_BIRTHDATE}," +
                                                    $" {FIELD_DIPLOMANAME} = @{FIELD_DIPLOMANAME}," +
                                                    $" {FIELD_SCHOOL} = @{FIELD_SCHOOL}," +
                                                    $" {FIELD_PHOTO} = @{FIELD_PHOTO}" +
                                                    $" WHERE {FIELD_ID} = @{FIELD_ID}";
        
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
        
        public static bool Put(Student student)
        {
            bool hasBeenChanged = false;

            using (SqlConnection connection = Database.GetConnection())
            {
                connection.Open();
                SqlCommand command = connection.CreateCommand();
                command.CommandText = REQ_PUT;
                
                command.Parameters.AddWithValue($"@{FIELD_ISARCHIVED}", student.IsArchived);
                command.Parameters.AddWithValue($"@{FIELD_ISGHOSTMODE}", student.IsGhostMode);
                command.Parameters.AddWithValue($"@{FIELD_NICKNAME}", student.NickName);
                command.Parameters.AddWithValue($"@{FIELD_PASSWORD}", student.Password);
                command.Parameters.AddWithValue($"@{FIELD_MAIL}", student.Mail);
                command.Parameters.AddWithValue($"@{FIELD_TOKEN}", student.Token);
                command.Parameters.AddWithValue($"@{FIELD_FIRSTNAME}", student.FirstName);
                command.Parameters.AddWithValue($"@{FIELD_LASTNAME}", student.LastName);
                command.Parameters.AddWithValue($"@{FIELD_DESCRIPTION}", student.Description);
                command.Parameters.AddWithValue($"@{FIELD_BIRTHDATE}", student.BirthDate);
                command.Parameters.AddWithValue($"@{FIELD_DIPLOMANAME}", student.DiplomaName);
                command.Parameters.AddWithValue($"@{FIELD_SCHOOL}", student.School);
                command.Parameters.AddWithValue($"@{FIELD_PHOTO}", student.Photo);
                
                command.Parameters.AddWithValue($"@{FIELD_ID}", student.Id);

                hasBeenChanged = command.ExecuteNonQuery() == 1;
            }
            return hasBeenChanged;
        }
    }
}