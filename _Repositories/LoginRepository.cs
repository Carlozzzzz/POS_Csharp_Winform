using POS_V1.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace POS_V1._Repositories
{
    public class LoginRepository : BaseRepository, ILoginRepository
    {
        public LoginRepository(string connectionString) {
            this.connectionString = connectionString;
        }

        public LoginModel ValidateUser(string username, string password)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT username, role from Users_Tbl WHERE username = @username AND password = @password";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@username", username);
                    command.Parameters.AddWithValue("@password", password);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            LoginModel model = new LoginModel();
                            model.Username = reader["username"].ToString();
                            model.Role = (UserRole)reader["role"];
                            return model;
                        }
                        else
                        {
                            throw new Exception("Invalid username or password.");
                        }
                    }
                }

            }

        }
    }
}
