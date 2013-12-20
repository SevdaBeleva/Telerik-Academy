using System;
using System.Data.SqlClient;

class Program
{
    static void Main(string[] args)
    {
        InsertProduct("Chocofreddo", 1);
    }
    
    private static void InsertProduct(string productName, int catId)
    {                                               //enter the name of your server instance
        SqlConnection conn = new SqlConnection("Server=.\\.........;" + "Database=Northwind; Integrated Security=true");
        conn.Open();
        using (conn)
        {
            SqlCommand cmd = new SqlCommand("INSERT INTO Products(ProductName, CategoryID)" + "VALUES(@productName, @catId);", conn);
            cmd.Parameters.AddWithValue("@productName", productName);
            cmd.Parameters.AddWithValue("@catId", catId);
            cmd.ExecuteNonQuery();
        }
    }     
}
