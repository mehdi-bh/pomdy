using System;
using System.Data.SqlClient;
using pomdyBackend.Model;

namespace pomdyBackend.DAO
{
    public class FriendStudentDAO
    {
        /***** Constants *****/
        private static readonly string TABLE_NAME = "friend_student";
        
        public static readonly string FIELD_IDFIRSTSTUDENT = "idFirstStudent";
        public static readonly string FIELD_IDSECONDSTUDENT = "idSecondStudent";
        
        /***** Requests *****/
        private static readonly string REQ_POST
            = $"INSERT INTO {TABLE_NAME} ({FIELD_IDFIRSTSTUDENT}, {FIELD_IDSECONDSTUDENT}) VALUES (@{FIELD_IDFIRSTSTUDENT}, @{FIELD_IDSECONDSTUDENT})";

        private static string REQ_DELETE
            = $"DELETE FROM {TABLE_NAME} WHERE {FIELD_IDFIRSTSTUDENT} = @{FIELD_IDFIRSTSTUDENT} AND {FIELD_IDSECONDSTUDENT} = @{FIELD_IDSECONDSTUDENT}";
        
        /***** Methods *****/
        public static bool Post(FriendStudent[] friendStudents)
        {
            using (var connection = Database.GetConnection())
            {
                connection.Open();
                SqlCommand command = connection.CreateCommand();
                SqlTransaction transaction;
                
                transaction = connection.BeginTransaction("SaveFriends");
                command.Transaction = transaction;
                
                command.CommandText = REQ_POST;
                command.Parameters.AddWithValue($"@{FIELD_IDFIRSTSTUDENT}", friendStudents[0].IdFirstStudent);
                command.Parameters.AddWithValue($"@{FIELD_IDSECONDSTUDENT}", friendStudents[0].IdSecondStudent);
                command.ExecuteNonQuery();
                
                command.Parameters.Clear();
                    
                command.CommandText = REQ_POST;
                command.Parameters.AddWithValue($"@{FIELD_IDFIRSTSTUDENT}", friendStudents[1].IdFirstStudent);
                command.Parameters.AddWithValue($"@{FIELD_IDSECONDSTUDENT}", friendStudents[1].IdSecondStudent);
                command.ExecuteNonQuery();

                try
                {
                    transaction.Commit();
                    return true;
                }
                catch (Exception e)
                {
                    return false;
                }
            }
        }

        public static bool Delete(FriendStudent[] friendStudents)
        {
            using (var connection = Database.GetConnection())
            {
                connection.Open();
                SqlCommand command = connection.CreateCommand();
                SqlTransaction transaction;
                
                transaction = connection.BeginTransaction("DeleteFriends");
                command.Transaction = transaction;

                command.CommandText = REQ_DELETE;
                command.Parameters.AddWithValue($"@{FIELD_IDFIRSTSTUDENT}", friendStudents[0].IdFirstStudent);
                command.Parameters.AddWithValue($"@{FIELD_IDSECONDSTUDENT}", friendStudents[0].IdSecondStudent);
                command.ExecuteNonQuery();
                
                command.Parameters.Clear();
                    
                command.CommandText = REQ_DELETE;
                command.Parameters.AddWithValue($"@{FIELD_IDFIRSTSTUDENT}", friendStudents[1].IdFirstStudent);
                command.Parameters.AddWithValue($"@{FIELD_IDSECONDSTUDENT}", friendStudents[1].IdSecondStudent);
                command.ExecuteNonQuery();

                try
                {
                    transaction.Commit();
                    return true;
                }
                catch (Exception e)
                {
                    return false;
                }
            }
        }
    }
}