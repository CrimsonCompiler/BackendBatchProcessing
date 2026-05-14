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
        }
    }
}
