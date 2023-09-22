using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//MAIN 
namespace OPTATIVO_III
{
    class Program
    {
        static void Main(string[] args)
        {
            //CONEXION A LOCAL SV
            SqlConnection sqlConnection;
            string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=WendysProject;Integrated Security=True";
            sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();
            try
            {
                //TRY CONNECTION
                Console.WriteLine("Database connected successfully");
                string answer;

                do
                {
                    //MENU
                    Menu start = new Menu();
                    start.iniciar();

                    Console.WriteLine("Do you want to continue?");
                    answer = Console.ReadLine();
                } while (answer != "No");


            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                sqlConnection.Close();
            }
            

            
        }
    }
}
