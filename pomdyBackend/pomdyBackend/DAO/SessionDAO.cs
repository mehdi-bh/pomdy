﻿using System.Collections.Generic;
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
        public static readonly string FIELD_NAME = "name";
        public static readonly string FIELD_DESCRIPTION = "description";
        public static readonly string FIELD_STARTDATE = "startDate";
        public static readonly string FIELD_ENDDATE = "endDate";
        public static readonly string FIELD_WORKTIME = "workTime";
        public static readonly string FIELD_BREAKTIME = "breakTime";
        public static readonly string FIELD_SCORE = "score";
        
        // GET ALL
        private static readonly string REQ_GET_ALL = $"SELECT * FROM {TABLE_NAME}";
        
        // POST
        private static readonly string REQ_POST
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
        
        // PUT
        private static readonly string REQ_PUT = $"UPDATE {TABLE_NAME} SET {FIELD_ISARCHIVED} = @{FIELD_ISARCHIVED}," +
                                                 $" {FIELD_IDSTUDENT} = @{FIELD_IDSTUDENT}," +
                                                 $" {FIELD_NAME} = @{FIELD_NAME}," +
                                                 $" {FIELD_DESCRIPTION} = @{FIELD_DESCRIPTION}," +
                                                 $" {FIELD_STARTDATE} = @{FIELD_STARTDATE}," +
                                                 $" {FIELD_ENDDATE} = @{FIELD_ENDDATE}," +
                                                 $" {FIELD_WORKTIME} = @{FIELD_WORKTIME}," +
                                                 $" {FIELD_BREAKTIME} = @{FIELD_BREAKTIME}," +
                                                 $" {FIELD_SCORE} = @{FIELD_SCORE} " +
                                                 $" WHERE {FIELD_ID} = @{FIELD_ID}";

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

                command.CommandText = REQ_POST;
                
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
        
        public static bool Put(Session session)
        {
            bool hasBeenChanged = false;

            using (SqlConnection connection = Database.GetConnection())
            {
                connection.Open();
                SqlCommand command = connection.CreateCommand();
                command.CommandText = REQ_PUT;
                
                command.Parameters.AddWithValue($"@{FIELD_ISARCHIVED}", session.IsArchived);
                command.Parameters.AddWithValue($"@{FIELD_IDSTUDENT}", session.IdStudent);
                command.Parameters.AddWithValue($"@{FIELD_NAME}", session.Name);
                command.Parameters.AddWithValue($"@{FIELD_DESCRIPTION}", session.Description);
                command.Parameters.AddWithValue($"@{FIELD_STARTDATE}", session.StartDate);
                command.Parameters.AddWithValue($"@{FIELD_ENDDATE}", session.EndDate);
                command.Parameters.AddWithValue($"@{FIELD_WORKTIME}", session.WorkTime);
                command.Parameters.AddWithValue($"@{FIELD_BREAKTIME}", session.BreakTime);
                command.Parameters.AddWithValue($"@{FIELD_SCORE}", session.Score);

                command.Parameters.AddWithValue($"@{FIELD_ID}", session.Id);

                hasBeenChanged = command.ExecuteNonQuery() == 1;
            }
            return hasBeenChanged;
        }
    }
}