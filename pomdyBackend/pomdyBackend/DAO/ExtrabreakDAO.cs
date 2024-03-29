﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using pomdyBackend.Model;

namespace pomdyBackend.DAO
{
    public class ExtrabreakDAO
    {
        /***** Constants *****/
        public static readonly string TABLE_NAME = "extrabreak";
        
        public static readonly string FIELD_ID = "id";
        public static readonly string FIELD_IDSESSION = "idSession";
        public static readonly string FIELD_ISARCHIVED = "isArchived";
        public static readonly string FIELD_REASON = "reason";
        public static readonly string FIELD_DURATION = "duration";
        public static readonly string FIELD_STARTDATE = "startDate";
        
        /***** Requests *****/
        private static readonly string REQ_GET_ALL = $"SELECT * FROM {TABLE_NAME}";
        
        private static readonly string REQ_GET_BY_ID = REQ_GET_ALL + $" WHERE {FIELD_ID} = @{FIELD_ID}";
        
        private static readonly string REQ_GET_SESSION_EXTRABREAKS = REQ_GET_ALL + $" WHERE {FIELD_IDSESSION} = @{FIELD_IDSESSION}";
        
        private static readonly string REQ_GET_STUDENT_EXTRABREAKS
            = string.Format("SELECT * FROM {1} INNER JOIN {0} ON {1}.{2} = {0}.{3} where {1}.{4} = @{5}"
                ,TABLE_NAME, SessionDAO.TABLE_NAME, SessionDAO.FIELD_ID, FIELD_IDSESSION, SessionDAO.FIELD_IDSTUDENT, StudentDAO.FIELD_ID);
        
        private static readonly string REQ_POST
            = string.Format(
                "INSERT INTO {0} ({1}, {2}, {3}, {4}, {5}) OUTPUT Inserted.{6} VALUES (@{1}, @{2}, @{3}, @{4}, @{5})",
                TABLE_NAME, 
                FIELD_REASON,
                FIELD_DURATION,
                FIELD_IDSESSION,
                FIELD_STARTDATE,
                FIELD_ISARCHIVED,
                FIELD_ID
            );
        
        private static readonly string REQ_PUT = $"UPDATE {TABLE_NAME} SET {FIELD_ISARCHIVED} = @{FIELD_ISARCHIVED}," +
                                                 $" {FIELD_IDSESSION} = @{FIELD_IDSESSION}," +
                                                 $" {FIELD_REASON} = @{FIELD_REASON}," +
                                                 $" {FIELD_DURATION} = @{FIELD_DURATION}," +
                                                 $" {FIELD_STARTDATE} = @{FIELD_STARTDATE} " +
                                                 $" WHERE {FIELD_ID} = @{FIELD_ID}";

        private static readonly string REQ_DELETE = $"DELETE FROM {TABLE_NAME} WHERE {FIELD_ID} = @{FIELD_ID}";

        /***** Methods *****/
        public static IEnumerable<Extrabreak> GetAll()
        {
            List<Extrabreak> extrabreaks = new List<Extrabreak>();
            using (var connection = Database.GetConnection())
            {
                connection.Open();

                SqlCommand command = connection.CreateCommand();
                command.CommandText = REQ_GET_ALL;

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    extrabreaks.Add(new Extrabreak(reader));
                }
            }
            return extrabreaks;
        }
        
        public static Extrabreak Get(int id)
        {
            using (var connection = Database.GetConnection())
            {
                connection.Open();
        
                SqlCommand command = connection.CreateCommand();
                command.CommandText = REQ_GET_BY_ID;
        
                command.Parameters.AddWithValue($"@{FIELD_ID}", id);
        
                SqlDataReader reader = command.ExecuteReader();
        
                return reader.Read() ? new Extrabreak(reader) : null;
            }
        }
        
        public static IEnumerable<Extrabreak> GetSessionExtrabreaks(int idSession)
        {
            List<Extrabreak> extrabreaks = new List<Extrabreak>();
            using (var connection = Database.GetConnection())
            {
                connection.Open();

                SqlCommand command = connection.CreateCommand();
                command.CommandText = REQ_GET_SESSION_EXTRABREAKS;
                
                command.Parameters.AddWithValue($"@{FIELD_IDSESSION}", idSession);

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    extrabreaks.Add(new Extrabreak(reader));
                }
            }
            return extrabreaks;
        }
        
        public static IEnumerable<Extrabreak> GetStudentExtrabreaks(int idStudent)
        {
            List<Extrabreak> extrabreaks = new List<Extrabreak>();
            using (var connection = Database.GetConnection())
            {
                connection.Open();

                SqlCommand command = connection.CreateCommand();
                command.CommandText = REQ_GET_STUDENT_EXTRABREAKS;
                
                command.Parameters.AddWithValue($"@{StudentDAO.FIELD_ID}", idStudent);

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    extrabreaks.Add(new Extrabreak(reader));
                }
            }
            return extrabreaks;
        }
        
        public static Extrabreak Post(Extrabreak extrabreak)
        {
            using (SqlConnection connection = Database.GetConnection())
            {
                connection.Open();

                SqlCommand command = connection.CreateCommand();
                
                command.CommandText = REQ_POST;
                
                // Optional rules
                bool reasonIsBlank = string.IsNullOrEmpty(extrabreak.Reason);
                command.Parameters.AddWithValue($"@{FIELD_REASON}", reasonIsBlank ? "" : extrabreak.Reason);

                command.Parameters.AddWithValue($"@{FIELD_DURATION}", extrabreak.Duration);
                command.Parameters.AddWithValue($"@{FIELD_IDSESSION}", extrabreak.IdSession);
                command.Parameters.AddWithValue($"@{FIELD_STARTDATE}", extrabreak.StartDate);
                command.Parameters.AddWithValue($"@{FIELD_ISARCHIVED}", extrabreak.IsArchived);

                extrabreak.Id = (int) command.ExecuteScalar();

                return extrabreak;
            }
        }
        
        public static bool Put(Extrabreak extrabreak)
        {
            bool hasBeenChanged = false;

            using (SqlConnection connection = Database.GetConnection())
            {
                connection.Open();
                SqlCommand command = connection.CreateCommand();
                command.CommandText = REQ_PUT;
                
                command.Parameters.AddWithValue($"@{FIELD_ISARCHIVED}", extrabreak.IsArchived);
                command.Parameters.AddWithValue($"@{FIELD_IDSESSION}", extrabreak.IdSession);
                command.Parameters.AddWithValue($"@{FIELD_REASON}", extrabreak.Reason);
                command.Parameters.AddWithValue($"@{FIELD_DURATION}", extrabreak.Duration);
                command.Parameters.AddWithValue($"@{FIELD_STARTDATE}", extrabreak.StartDate);

                command.Parameters.AddWithValue($"@{FIELD_ID}", extrabreak.Id);

                hasBeenChanged = command.ExecuteNonQuery() == 1;
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
    }
}