using System;
using System.Data.SqlClient;
class Program
{
    static void Main(string[] args)
    {                                               //enter the name of your server instance
        SqlConnection conn = new SqlConnection("Server=.\\.........;" + "Database=Northwind; Integrated Security=true");
        conn.Open();
        SqlCommand cmd = new SqlCommand(
                "SELECT c.CategoryName, p.ProductName FROM Products p JOIN Categories c ON c.CategoryId = p.CategoryId", conn);
        SqlDataReader reader = cmd.ExecuteReader();
        using (reader)
        {
            while (reader.Read())
            {
                string name = (string)reader["CategoryName"];
                string description = (string)reader["ProductName"];
                Console.WriteLine("{0}: {1}", name, description);
            }
        }
    }
}

