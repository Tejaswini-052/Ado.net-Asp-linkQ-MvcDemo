using System.Data.SqlClient;
using System.Data;
using System.Configuration;
using System.Xml.Linq;

namespace AdoConnectionDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            connection();
        }
        static void connection()
        {
            string connectionstring = "Data Source= LAPTOP-JAO9IL68\\SQLEXPRESS;Initial Catalog=College;Integrated Security=true;";
            SqlConnection connection=new SqlConnection(connectionstring);
            try
            {
               //Console.WriteLine("Enter the Student name");
               // string name = Console.ReadLine();
                string query = "select * from totalmarks;";
                SqlCommand cmd = new SqlCommand(query, connection);
               // cmd.Parameters.AddWithValue("@name", name);
                // cmd.CommandType = CommandType.StoredProcedure;
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                /* DataSet dataset = new DataSet();
                 adapter.Fill(dataset);
                 foreach(DataRow row in dataset.Tables[0].Rows)
                 {
                     Console.WriteLine(row[0]+" " + row[1]);
                 }*/

                /* DataTable datatable = new DataTable();
                 adapter.Fill(datatable);
                 foreach (DataRow row in datatable.Rows)
                 {
                     Console.WriteLine(row[0]+" Scored " + row[1]);
                 }*/



                //copy method dataset
                DataTable originalDataTable = new DataTable();
                adapter.Fill(originalDataTable);
               /* Console.WriteLine("Original Data Table :");
                foreach (DataRow row in originalDataTable.Rows)
                {
                    Console.WriteLine(row[0]);
                }
                Console.WriteLine("Copy Data Table : ");
                DataTable copyDataTable = originalDataTable.Copy();
                if (copyDataTable != null)
                {
                    foreach (DataRow row in copyDataTable.Rows)
                    {
                        Console.WriteLine(row[0]);
                    }
                }*/
                Console.WriteLine("Clone Data Table :");
                DataTable cloneDataTable = originalDataTable.Clone();
                Console.WriteLine(cloneDataTable.Rows.Count);
                 if (cloneDataTable.Rows.Count>0 )
                 {
                    
                    foreach (DataRow row in cloneDataTable.Rows)
                    {
                        Console.WriteLine(row["Studentname"]);
                    }
                 }
                else
                 {
                    Console.WriteLine("cloneDataTable is Empty");
                 }


                /*
                  string query1 = "select * from totalmarks;";
                  SqlCommand cmd1 = new SqlCommand(query1, connection);
                  connection.Open();
                  SqlDataAdapter adapter1 = new SqlDataAdapter(cmd1);
                  DataSet originalDataSet1 = new DataSet();
                  adapter1.Fill(originalDataSet1);
                  Console.WriteLine("Before Deletion");
                  foreach (DataRow row in originalDataSet1.Tables[0].Rows)
                  {
                      Console.WriteLine(row[0]);
                  }
                  Console.WriteLine();
                  foreach (DataRow row in originalDataSet1.Tables[0].Rows)
                  {
                     if (row["Studentname"].Equals( "Tejaswini"))
                      {
                          row.Delete();

                          Console.WriteLine("Row with name Tejaswini deleted");
                      }

                  }
                  originalDataSet1.AcceptChanges();

                  Console.WriteLine();
                  Console.WriteLine("After Deletion");
                  foreach (DataRow row in originalDataSet1.Tables[0].Rows)
                  {
                      Console.WriteLine(row[0]);
                  }


               */




                /* using (SqlDataReader reader = cmd.ExecuteReader())
                {

                    while (reader.Read())
                    {
                        Console.WriteLine(reader[0]);
                    }
                    Console.WriteLine("------------------------------------------");
                    if (reader.NextResult())
                    {
                        while (reader.Read())
                        {
                            Console.WriteLine(reader[3] );
                        }
                    }
                    Console.WriteLine("------------------------------------------");
                    if (reader.NextResult())
                    {
                        while (reader.Read())
                        {
                            Console.WriteLine(reader[0]);
                        }
                    }  */


                /* Console.WriteLine(reader.FieldCount);
                Console.WriteLine(reader.HasRows);
                Console.WriteLine(reader.GetName(0)+ " and "+ reader.GetName(1));
            }*/


                /*Console.WriteLine("Enter the Student name");
                string name = Console.ReadLine();
                Console.WriteLine("Enter the Marks");
                string marks = Console.ReadLine();
                string query = "insert into totalmarks values(@name,@marks)";
                SqlCommand cmd = new SqlCommand(query,connection);
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@marks", marks);
                connection.Open();
                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                {
                    Console.WriteLine("Insert Successfull");
                }
                else
                {
                    Console.WriteLine("Insert Failed");
                }*/


                /*Console.WriteLine("Enter the name to update marks");
                string name1 = Console.ReadLine();
                Console.WriteLine("Enter the marks to update marks");
                string marks1 = Console.ReadLine();
                string query1 = "UPDATE totalmarks SET marks =@marks WHERE name = @name";
                SqlCommand command = new SqlCommand(query1, connection);
                    command.Parameters.AddWithValue("@name", name1);
                    command.Parameters.AddWithValue("@marks", marks1);
                connection.Open();
                    int update = command.ExecuteNonQuery();
                    if (update > 0)
                    {
                        Console.WriteLine("Update successful");
                    }
                    else
                    {
                        Console.WriteLine("Update failed");
                    }

                Console.WriteLine("Enter the name to update marks");
                string name2 = Console.ReadLine();
                string query2 = "delete from totalmarks WHERE name = @name";
                SqlCommand command1 = new SqlCommand(query1, connection);
                command1.Parameters.AddWithValue("@name", name1);
                connection.Open();
                int delete = command.ExecuteNonQuery();
                if (delete > 0)
                {
                    Console.WriteLine("delete successful");
                }
                else
                {
                    Console.WriteLine("delete failed");
                }*/

                /* string query = "select count(Studentname) from totalmarks";
                 SqlCommand cmd = new SqlCommand(query, connection);
                 connection.Open();
                 int countrecords = (int)cmd.ExecuteScalar();
                 Console.WriteLine(countrecords);

                 string query1 = "select sum(marks) from totalmarks";
                 SqlCommand cmd1 = new SqlCommand(query1, connection);
                 connection.Open();
                 int countrecords1 = (int)cmd.ExecuteScalar();
                 Console.WriteLine(countrecords1);

                 string query2 = "select min(marks) from totalmarks";
                 SqlCommand cmd2 = new SqlCommand(query2, connection);
                 connection.Open();
                 int countrecords2 = (int)cmd.ExecuteScalar();
                 Console.WriteLine(countrecords2);

                 string query3 = "select max(marks) from totalmarks";
                 SqlCommand cmd3 = new SqlCommand(query3, connection);
                 connection.Open();
                 int countrecords3 = (int)cmd.ExecuteScalar();
                 Console.WriteLine(countrecords3);

                 string query4 = "select sum(marks) from totalmarks";
                 SqlCommand cmd4 = new SqlCommand(query4, connection);
                 connection.Open();
                 int countrecords4 = (int)cmd.ExecuteScalar();
                 Console.WriteLine(countrecords4); */

            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally { connection.Close(); }
        }
    
    }
}