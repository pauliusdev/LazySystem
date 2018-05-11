using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LazyService.DatabaseR
{
    class Connection
    {
        public object ConnectingDb()
        {
            List<string> movieList = new List<string>();
            DataTable movieTable = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter();
            //SqlConnection conn = new SqlConnection("Server=PF1280ZE\\PRACPRACSQL;Database=Books;Integrated Security=true;Trusted_Connection=true;");
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Server=PF1280ZE\\PRACPRACSQL;Database=Books;Integrated Security=true;";
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT BooksID, Book_Author, Book_Age, Book_Price FROM [dbo].[Book_List]", conn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                //Console.WriteLine("First Name: {0}", reader.GetString(0));
                Console.WriteLine("Book ID: {0} || Book Author: {1} || Book Age: {2} || Book Price: {3}" +
                    "", reader.GetInt32(0).ToString(), reader.GetString(1), reader.GetInt32(2).ToString(),
                    reader.GetInt32(3).ToString());
                //sda.Fill(movieTable);

            }
            reader.Close();
            conn.Close();

            if (Debugger.IsAttached)
            {
                Console.ReadLine();
            }
            return conn;
        }
    }
}
