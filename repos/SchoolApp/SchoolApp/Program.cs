using System;
using MySql.Data.MySqlClient;

namespace SchoolApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var connectionstring = "server=localhost;user=root;database=SchoolApp;password=p1h2a3r4o5u6k7";
            using (MySqlConnection sqlconnection = new MySqlConnection(connectionstring))
            {
                sqlconnection.Open();
                MySqlCommand mySqlCommand1 = new MySqlCommand("insert into Student (firstName," +
                    "lastName,Email,phoneNumber,regNumber,Gender) value ('trent','arnold','trent234@mail.com'," +
                    "'090897654','997256fj','Male')", sqlconnection);
                var result = mySqlCommand1.ExecuteNonQuery();
                Console.WriteLine("Reader of rows affected.{result}");
                sqlconnection.Close();








                Console.WriteLine("connection successfully created. ");
                MySqlCommand mySqlCommand = new MySqlCommand("select * from Student", sqlconnection);
                var reader = mySqlCommand.ExecuteReader();
                while (reader.Read())
                {
                    Console.WriteLine("{0} {1} {2} {3} {4} {5} {6}", reader["StudentID"], reader["FirstName"],
                        reader["LastName"], reader["Email"], reader["phoneNumber"], reader["regNumber"], 
                        reader["Gender"]);

                    //   Console.WriteLine($"{reader["StudentID"]},{reader["FirstName"]},{reader["LastName"]},
                    //   {reader["Email"]},{reader["phoneNumber"]},{reader["regNumber"]},{reader["Gender"]}");
                }
            }  
                           
        }
    }
}
