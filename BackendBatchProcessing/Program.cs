using System;
using Npgsql;
namespace BackendBatchProcessing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1.Array of IDs:
            int[] userIdsToUpdate = { 102, 245, 360, 233 };

            // 2. Raw SQL query
            // = ANY(@ids) is array parameter syntax in PostgreSQL
            string query = "UPDATE users SET status = 'active' WHERE id = ANY(@ids)";


            // 3. Real Database Connection & Execution Code
            //using(var connection = new NpgsqlConnection("Host=localhost;Username=tousif;Database=test_db")
            //{
            //    connection.Open();

            //    using(var cmd = new NpgsqlCommand(query, connection))
            //    {
            //        cmd.Parameters.AddWithValue("ids", userIdsToUpdate);

            //    int rowsAffected = cmd.ExecuteNonQuery();
            //    }
            //}

            // 4. Output
            Console.WriteLine("--- Backend Batch Update ---");
            Console.WriteLine("Executing Query: " + query);
            Console.WriteLine($"Passing Array Size: {userIdsToUpdate.Length} IDs at once.");
        }
    }
}
