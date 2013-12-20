using System;
using System.Data.SqlClient;

public class GetNumberOfRowsInCategories
{
    static void Main(string[] args)
    {
        int counter = 0;
                                               //enter the name of your server instance
        SqlConnection conn = new SqlConnection("Server=.\\......;" + "Database=Northwind; Integrated Security=true");
        conn.Open();
        using (conn)
        {
            SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM Categories", conn);
            counter = (int)cmd.ExecuteScalar();
            Console.WriteLine("The number of rows in Categories table is: {0}", counter);
        }  
    }  
}

