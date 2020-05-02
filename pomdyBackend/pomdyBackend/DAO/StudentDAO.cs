using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using pomdyBackend.Model;
using pomdyBackend.Utility;

namespace pomdyBackend.DAO
{
    public class StudentDAO
    {
        /***** Constants *****/
        public static readonly string TABLE_NAME = "student";
        
        public static readonly string FIELD_ID = "id";
        public static readonly string FIELD_ISARCHIVED = "isArchived";
        public static readonly string FIELD_ISGHOSTMODE = "isGhostMode";
        public static readonly string FIELD_NICKNAME = "nickName";
        public static readonly string FIELD_PASSWORD = "password";
        public static readonly string FIELD_MAIL = "mail";
        public static readonly string FIELD_FIRSTNAME = "firstName";
        public static readonly string FIELD_LASTNAME = "lastName";
        public static readonly string FIELD_DESCRIPTION = "description";
        public static readonly string FIELD_BIRTHDATE = "birthDate";
        public static readonly string FIELD_DIPLOMANAME = "diplomaName";
        public static readonly string FIELD_SCHOOL = "school";
        public static readonly string FIELD_PHOTO = "photo";
        
        /***** Requests *****/
        private static readonly string REQ_GET_ALL = $"SELECT * FROM {TABLE_NAME}";
        
        private static readonly string REQ_GET_BY_ID = REQ_GET_ALL + $" WHERE {FIELD_ID} = @{FIELD_ID}";
        
        private static readonly string REQ_GET_BY_NICKNAME = REQ_GET_ALL + $" WHERE {FIELD_NICKNAME} = @{FIELD_NICKNAME}";
        
        private static readonly string REQ_GET_BY_MAIL = REQ_GET_ALL + $" WHERE {FIELD_MAIL} = @{FIELD_MAIL}";
        
        private static readonly string REQ_POST
            = string.Format(
                "INSERT INTO {0} ({1}, {2}, {3}, {4}, {5}, {6}) OUTPUT Inserted.{7} VALUES (@{1}, @{2}, @{3}, @{4}, @{5}, @{6})",
                TABLE_NAME, 
                FIELD_ISARCHIVED,
                FIELD_ISGHOSTMODE,
                FIELD_NICKNAME,
                FIELD_PASSWORD,
                FIELD_MAIL,
                FIELD_BIRTHDATE,
                FIELD_ID
            );
        
        private static readonly string REQ_PUT = $"UPDATE {TABLE_NAME} SET {FIELD_ISARCHIVED} = @{FIELD_ISARCHIVED}," +
                                                    $" {FIELD_ISGHOSTMODE} = @{FIELD_ISGHOSTMODE}," +
                                                    $" {FIELD_NICKNAME} = @{FIELD_NICKNAME}," +
                                                    $" {FIELD_PASSWORD} = @{FIELD_PASSWORD}," +
                                                    $" {FIELD_MAIL} = @{FIELD_MAIL}," +
                                                    $" {FIELD_FIRSTNAME} = @{FIELD_FIRSTNAME}," +
                                                    $" {FIELD_LASTNAME} = @{FIELD_LASTNAME}," +
                                                    $" {FIELD_DESCRIPTION} = @{FIELD_DESCRIPTION}," +
                                                    $" {FIELD_BIRTHDATE} = @{FIELD_BIRTHDATE}," +
                                                    $" {FIELD_DIPLOMANAME} = @{FIELD_DIPLOMANAME}," +
                                                    $" {FIELD_SCHOOL} = @{FIELD_SCHOOL}," +
                                                    $" {FIELD_PHOTO} = @{FIELD_PHOTO}" +
                                                    $" WHERE {FIELD_ID} = @{FIELD_ID}";
        
        private static readonly string REQ_PUT_WITHOUT_PASSWORD = $"UPDATE {TABLE_NAME} SET {FIELD_ISARCHIVED} = @{FIELD_ISARCHIVED}," +
                                                 $" {FIELD_ISGHOSTMODE} = @{FIELD_ISGHOSTMODE}," +
                                                 $" {FIELD_NICKNAME} = @{FIELD_NICKNAME}," +
                                                 $" {FIELD_MAIL} = @{FIELD_MAIL}," +
                                                 $" {FIELD_FIRSTNAME} = @{FIELD_FIRSTNAME}," +
                                                 $" {FIELD_LASTNAME} = @{FIELD_LASTNAME}," +
                                                 $" {FIELD_DESCRIPTION} = @{FIELD_DESCRIPTION}," +
                                                 $" {FIELD_BIRTHDATE} = @{FIELD_BIRTHDATE}," +
                                                 $" {FIELD_DIPLOMANAME} = @{FIELD_DIPLOMANAME}," +
                                                 $" {FIELD_SCHOOL} = @{FIELD_SCHOOL}," +
                                                 $" {FIELD_PHOTO} = @{FIELD_PHOTO}" +
                                                 $" WHERE {FIELD_ID} = @{FIELD_ID}";
        
        private static readonly string REQ_DELETE = $"DELETE FROM {TABLE_NAME} WHERE {FIELD_ID} = @{FIELD_ID}";
        
        private static readonly string REQ_LOGIN = 
            string.Format("SELECT * FROM {0} WHERE {1} = @{1} AND {2} = @{2}", TABLE_NAME, FIELD_NICKNAME, FIELD_PASSWORD);
        
        /***** Methods *****/
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
                    Student student = new Student(reader);
                    students.Add(student);
                }
            }
            return students;
        }
        
        public static Student Get(int id)
        {
            using (var connection = Database.GetConnection())
            {
                connection.Open();
        
                SqlCommand command = connection.CreateCommand();
                command.CommandText = REQ_GET_BY_ID;
        
                command.Parameters.AddWithValue($"@{FIELD_ID}", id);
        
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    Student student = new Student(reader);
                    student.Token = Security.GenerateToken(student.Id.ToString());
                    return student;
                }
                return null;
            }
        }
        
        public static Student GetByNickName(string nickName)
        {
            using (var connection = Database.GetConnection())
            {
                connection.Open();
        
                SqlCommand command = connection.CreateCommand();
                command.CommandText = REQ_GET_BY_NICKNAME;
        
                command.Parameters.AddWithValue($"@{FIELD_NICKNAME}", nickName);
        
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    Student student = new Student(reader);
                    student.Token = Security.GenerateToken(student.Id.ToString());
                    return student;
                }
                return null;
            }
        }
        
        public static Student GetByMail(string mail)
        {
            using (var connection = Database.GetConnection())
            {
                connection.Open();
        
                SqlCommand command = connection.CreateCommand();
                command.CommandText = REQ_GET_BY_MAIL;
        
                command.Parameters.AddWithValue($"@{FIELD_MAIL}", mail);
        
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    Student student = new Student(reader);
                    student.Token = Security.GenerateToken(student.Id.ToString());
                    return student;
                }
                return null;
            }
        }

        public static Student Post(Student student)
        {
            using (SqlConnection connection = Database.GetConnection())
            {
                connection.Open();

                SqlCommand command = connection.CreateCommand();
                
                command.CommandText = REQ_POST;
                
                student.Password = Security.Encrypt(student.Password);

                command.Parameters.AddWithValue($"@{FIELD_ISARCHIVED}", student.IsArchived);
                command.Parameters.AddWithValue($"@{FIELD_ISGHOSTMODE}", student.IsGhostMode);
                command.Parameters.AddWithValue($"@{FIELD_NICKNAME}", student.NickName);
                command.Parameters.AddWithValue($"@{FIELD_PASSWORD}", student.Password);
                command.Parameters.AddWithValue($"@{FIELD_MAIL}", student.Mail);
                command.Parameters.AddWithValue($"@{FIELD_BIRTHDATE}", student.BirthDate);
                
                student.Id = (int) command.ExecuteScalar();
                student.Token = Security.GenerateToken(student.Id.ToString());
                
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

                bool passwordModified = !student.Password.Equals(Get(Security.RetrieveIdFromToken(student.Token)).Password);
                
                if (passwordModified)
                {
                    command.CommandText = REQ_PUT;
                
                    command.Parameters.AddWithValue($"@{FIELD_ISARCHIVED}", student.IsArchived);
                    command.Parameters.AddWithValue($"@{FIELD_ISGHOSTMODE}", student.IsGhostMode);
                    command.Parameters.AddWithValue($"@{FIELD_NICKNAME}", student.NickName);
                    command.Parameters.AddWithValue($"@{FIELD_PASSWORD}", Security.Encrypt(student.Password));
                    command.Parameters.AddWithValue($"@{FIELD_MAIL}", student.Mail);
                    command.Parameters.AddWithValue($"@{FIELD_FIRSTNAME}", student.FirstName);
                    command.Parameters.AddWithValue($"@{FIELD_LASTNAME}", student.LastName);
                    command.Parameters.AddWithValue($"@{FIELD_DESCRIPTION}", student.Description);
                    command.Parameters.AddWithValue($"@{FIELD_BIRTHDATE}", student.BirthDate);
                    command.Parameters.AddWithValue($"@{FIELD_DIPLOMANAME}", student.DiplomaName);
                    command.Parameters.AddWithValue($"@{FIELD_SCHOOL}", student.School);
                    command.Parameters.AddWithValue($"@{FIELD_PHOTO}", student.Photo);
                
                    command.Parameters.AddWithValue($"@{FIELD_ID}", Security.RetrieveIdFromToken(student.Token));

                    hasBeenChanged = command.ExecuteNonQuery() == 1;
                }
                else
                {
                    command.CommandText = REQ_PUT_WITHOUT_PASSWORD;
                
                    command.Parameters.AddWithValue($"@{FIELD_ISARCHIVED}", student.IsArchived);
                    command.Parameters.AddWithValue($"@{FIELD_ISGHOSTMODE}", student.IsGhostMode);
                    command.Parameters.AddWithValue($"@{FIELD_NICKNAME}", student.NickName);
                    command.Parameters.AddWithValue($"@{FIELD_MAIL}", student.Mail);
                    command.Parameters.AddWithValue($"@{FIELD_FIRSTNAME}", student.FirstName);
                    command.Parameters.AddWithValue($"@{FIELD_LASTNAME}", student.LastName);
                    command.Parameters.AddWithValue($"@{FIELD_DESCRIPTION}", student.Description);
                    command.Parameters.AddWithValue($"@{FIELD_BIRTHDATE}", student.BirthDate);
                    command.Parameters.AddWithValue($"@{FIELD_DIPLOMANAME}", student.DiplomaName);
                    command.Parameters.AddWithValue($"@{FIELD_SCHOOL}", student.School);
                    command.Parameters.AddWithValue($"@{FIELD_PHOTO}", student.Photo);
                
                    command.Parameters.AddWithValue($"@{FIELD_ID}", Security.RetrieveIdFromToken(student.Token));

                    hasBeenChanged = command.ExecuteNonQuery() == 1;
                }
                
            }
            return hasBeenChanged;
        }
        
        public static bool Delete(int id)
        {
            bool hasBeenDeleted = false;

            using (SqlConnection connection = Database.GetConnection())
            {
                connection.Open();
                SqlCommand command = connection.CreateCommand();
                command.CommandText = REQ_DELETE;

                command.Parameters.AddWithValue($@"{FIELD_ID}", id);
                
                hasBeenDeleted = command.ExecuteNonQuery() == 1;
            }
            
            return hasBeenDeleted;
        }
        
        public static Student Authenticate(string nickName, string password)
        {
            using (SqlConnection connection = Database.GetConnection())
            {
                connection.Open();
                SqlCommand command = connection.CreateCommand();
                command.CommandText = REQ_LOGIN;

                command.Parameters.AddWithValue($"@{FIELD_NICKNAME}", nickName);
                command.Parameters.AddWithValue($"@{FIELD_PASSWORD}", Security.Encrypt(password));

                SqlDataReader reader = command.ExecuteReader();

                if (!reader.Read())
                { return null; }
                
                Student student = new Student(reader);
                
                student.Token = Security.GenerateToken(student.Id.ToString());

                return student;
            }
        }
    }
}