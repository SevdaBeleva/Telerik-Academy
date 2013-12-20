using System;
using System.Data.SqlClient;

class GetNamesDescriptionsOfCategories
{
    static void Main(string[] args)
    {                                            //enter the name of your server instance
        SqlConnection conn = new SqlConnection("Server=.\\.......;" + "Database=Northwind; Integrated Security=true");
        conn.Open();
        using(conn)
        {
            SqlCommand cmd = new SqlCommand("SELECT CategoryName, Description FROM Categories", conn);
            SqlDataReader reader = cmd.ExecuteReader();
            using (reader)
            {
                while (reader.Read())
                {
                    string name = (string)reader["CategoryName"];
                    string description = (string)reader["Description"];
                    Console.WriteLine("{0}: {1}", name, description);
                }
            }
        }
    }
}

