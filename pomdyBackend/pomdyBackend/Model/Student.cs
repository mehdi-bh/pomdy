using System;
using System.Data.SqlClient;
using pomdyBackend.DAO;

namespace pomdyBackend.Model
{
    public class Student
    {
        public int Id { get; set; }
        public bool IsArchived { get; set; }
        public bool IsGhostMode { get; set; }
        public string NickName { get; set; }
        public string Password { get; set; }
        public string Mail { get; set; }
        public string Token { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Description { get; set; }
        public DateTime BirthDate { get; set; }
        public string DiplomaName { get; set; }
        public string School { get; set; }
        public string Photo { get; set; }

        public Student(){}

        public Student(int id, bool isArchived, bool isGhostMode, string nickName, string password, string mail, string token, string firstName, string lastName, string description, DateTime birthDate, string diplomaName, string school, string photo)
        {
            Id = id;
            IsArchived = isArchived;
            IsGhostMode = isGhostMode;
            NickName = nickName;
            Password = password;
            Mail = mail;
            Token = token;
            FirstName = firstName;
            LastName = lastName;
            Description = description;
            BirthDate = birthDate;
            DiplomaName = diplomaName;
            School = school;
            Photo = photo;
        }

        public Student(SqlDataReader sqlDataReader)
        {
            Id = Convert.ToInt32(sqlDataReader[StudentDAO.FIELD_ID].ToString());
            IsArchived = Convert.ToBoolean(sqlDataReader[StudentDAO.FIELD_ISARCHIVED].ToString());
            IsGhostMode = Convert.ToBoolean(sqlDataReader[StudentDAO.FIELD_ISGHOSTMODE].ToString());
            NickName = sqlDataReader[StudentDAO.FIELD_NICKNAME].ToString();
            Password = sqlDataReader[StudentDAO.FIELD_PASSWORD].ToString();
            Mail = sqlDataReader[StudentDAO.FIELD_MAIL].ToString();
            Token = sqlDataReader[StudentDAO.FIELD_TOKEN].ToString();
            FirstName = sqlDataReader[StudentDAO.FIELD_FIRSTNAME].ToString();
            LastName = sqlDataReader[StudentDAO.FIELD_LASTNAME].ToString();
            Description = sqlDataReader[StudentDAO.FIELD_DESCRIPTION].ToString();
            BirthDate = Convert.ToDateTime(sqlDataReader[StudentDAO.FIELD_BIRTHDATE].ToString());
            DiplomaName = sqlDataReader[StudentDAO.FIELD_DIPLOMANAME].ToString();
            School = sqlDataReader[StudentDAO.FIELD_SCHOOL].ToString();
            Photo = sqlDataReader[StudentDAO.FIELD_PHOTO].ToString();
        }
    }
}