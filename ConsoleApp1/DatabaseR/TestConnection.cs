//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Data.SqlClient;
//using System.Windows.Forms;
//using System.IO;
//using Microsoft.VisualBasic.FileIO;

//namespace MLMSpellingReader
//{
//    class SpellingReader
//    {
//        static void Main(string[] args)
//        {
//            SpellingReader.readCSV();
//            MessageBox.Show("Evaluation is complete, press OK to continue");
//        }

//        public static void readCSV(){

//            string filePath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
//            string outputFile = filePath + @"\outputFile.txt";
//            string queryString = null;
//            using (TextFieldParser parser = new TextFieldParser(@"c:\users\myuser\Documents\spellcheck.csv"))
//            {
//                parser.TextFieldType = FieldType.Delimited;
//                parser.SetDelimiters(",");                
//                while(!parser.EndOfData)
//                {
//                    string[] fields = parser.ReadFields();
//                    foreach(string field in fields)
//                    {
//                        string eval = field;
//                        queryString = "select Name from myTable where Logic like '%" + eval + "%' and active = '1'";
//                        SpellingReader.connectToDB(outputFile, queryString, eval);
//                    }                    
//                }             
//            }
//        }

//        public static void connectToDB(string outputFile, string queryString, string eval)
//        {
//            string connectionString = "Server=myServer;Database=myDBTable;Integrated Security=True;";
//            string checkSpellingQuery = queryString;
//            SqlConnection conn;            
//            conn = new SqlConnection(connectionString);
//            try
//            {
//                SqlCommand command = new SqlCommand(checkSpellingQuery, conn);
//                conn.Open();
//                SqlDataReader reader = command.ExecuteReader();
//                using(StreamWriter file = new StreamWriter(outputFile, true))
//                {
//                    while(reader.Read())
//                    {
//                        file.WriteLine("The misspelling " + eval + " was found in: " + reader["Name"]);
//                    }
//                }
//                reader.Close();
//                conn.Close();
//            }
//            catch(Exception ex)
//            {
//                MessageBox.Show("Cannot open connection: " + ex.ToString());
//            }
//        }      

//    }
//}