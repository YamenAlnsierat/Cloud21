using System;
using System.Data.SqlClient;

namespace SqlDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            string connectionString = "Server = GIN7; Database = everyloop; Trusted_Connection = True";
            string quary = "Select top 10 * from Users";

            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            SqlCommand command = new SqlCommand(quary, connection);

            SqlDataReader reader = command.ExecuteReader();
            for (int c = 0; c < reader.FieldCount; c++)
            {
                Console.Write(reader.GetName(c).PadRight(50));
            }

            Console.WriteLine();

            while (reader.Read())
            {
                for (int c = 0; c < reader.FieldCount; c++)
                {
                Console.Write(reader.GetValue(c).ToString().PadRight(50)); 
                }

                Console.WriteLine();
            }
        }
    }
}
