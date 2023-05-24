using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using Rps_Models;

namespace Rps_Repository
{
    public class Rps_RepoLayerClassLibrary
    {

        private static SqlConnection flubby { get; set; } = new SqlConnection("Server=tcp:022223-batch-server.database.windows.net,1433;Initial Catalog=022223-batch-db;Persist Security Info=False;User ID=batch-022223;Password=2peachtrees!;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");


        public bool UserNamePasswordInDb(Person p)
        {
            // check to see if thise username/password combo is in the Db.
            SqlCommand comm = new SqlCommand("SELECT * FROM Customers WHERE UserName = @username AND Password == @password;", flubby);
            comm.Parameters.AddWithValue("@username", p.UserName);
            comm.Parameters.AddWithValue("@password", p.Password);
            flubby.Open();
            SqlDataReader res;
            try
            {
                res = comm.ExecuteReader();
                if (!res.Read())
                {
                    return false;
                }
                else return true;
            }
            catch (SqlException ex)
            {
                // write this exception to a file, exception.
                Console.WriteLine($"the exception was {ex.Message} - {ex.InnerException}");
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"the exception was {ex.Message} - {ex.InnerException}");
                return false;
            }
        }


    }// EoC
}// EoN