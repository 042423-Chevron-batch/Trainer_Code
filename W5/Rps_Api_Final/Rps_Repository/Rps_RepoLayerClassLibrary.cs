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

        public Person GetUserByUnamePword(string userName, string password)
        {
            // check to see if thise username/password combo is in the Db.
            SqlCommand comm = new SqlCommand("SELECT TOP 1 * FROM Customers WHERE UserName = @username AND Password = @password;", flubby);
            comm.Parameters.AddWithValue("@username", userName);
            comm.Parameters.AddWithValue("@password", password);
            flubby.Open();
            Person? p = null;
            SqlDataReader res;
            try
            {
                res = comm.ExecuteReader();
                if (res.Read())
                {
                    p = new Person(res.GetGuid(0), res.GetString(1), res.GetString(2), res.GetDateTime(3), res.GetString(4), res.GetString(5), res.GetString(6));
                }
                flubby.Close();
                return p!;
            }
            catch (SqlException ex)
            {
                // write this exception to a file, exception.
                Console.WriteLine($"the exception was {ex.Message} - {ex.InnerException}");
                flubby.Close();
                return p!;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"the exception was {ex.Message} - {ex.InnerException}");
                flubby.Close();
                return p!;
            }
        }


        public int RegisterNewCustomer(Person p)
        {
            // create the query
            SqlCommand comm = new SqlCommand("INSERT INTO Customers values(@cid, @fn, @ln, @lod, @r, @un, @pw);", flubby);
            comm.Parameters.AddWithValue("@fn", p.FirstName);
            comm.Parameters.AddWithValue("@ln", p.LastName);
            comm.Parameters.AddWithValue("@cid", p.CustomerId);
            comm.Parameters.AddWithValue("@r", p.Remarks);
            comm.Parameters.AddWithValue("@lod", p.LastOrderDate);
            comm.Parameters.AddWithValue("@un", p.UserName);
            comm.Parameters.AddWithValue("@pw", p.Password);
            flubby.Open();
            int res;
            try
            {
                res = comm.ExecuteNonQuery();
                if (res == 1)
                {
                    flubby.Close();
                    return res;
                }
                else
                {
                    flubby.Close();
                    return 0;
                }
            }
            catch (SqlException ex)
            {
                // write this exception to a file, exception.
                Console.WriteLine($"the exception was {ex.Message} - {ex.InnerException}");
                flubby.Close();
                return 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"the exception was {ex.Message} - {ex.InnerException}");
                flubby.Close();
                return 0;
            }
        }

        /// <summary>
        /// takes a username and password combination.
        /// Returns false of that combination is not in the Db.
        /// Otherwise, returns true
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public bool UserNamePasswordInDb(string username, string password)
        {
            // check to see if thise username/password combo is in the Db.
            SqlCommand comm = new SqlCommand("SELECT * FROM Customers WHERE UserName = @username AND Password = @password;", flubby);
            comm.Parameters.AddWithValue("@username", username);
            comm.Parameters.AddWithValue("@password", password);
            flubby.Open();
            SqlDataReader res;
            try
            {
                res = comm.ExecuteReader();
                if (!res.Read())
                {
                    flubby.Close();
                    return false;
                }
                else
                {
                    flubby.Close();
                    return true;
                }
            }
            catch (SqlException ex)
            {
                // write this exception to a file, exception.
                Console.WriteLine($"the exception was {ex.Message} - {ex.InnerException}");
                flubby.Close();
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"the exception was {ex.Message} - {ex.InnerException}");
                flubby.Close();
                return false;
            }
        }


    }// EoC
}// EoN