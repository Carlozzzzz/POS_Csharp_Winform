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
    public class UserRepository : BaseRepository, IUserRepository
    {
        public UserRepository(string connectionString) 
        {
            this.connectionString = connectionString;
        }
        public void Add(UserModel userModel)
        {
            throw new NotImplementedException();
        }

        public void Edit(UserModel userModel)
        {
            throw new NotImplementedException();
        }

        public void SoftDelete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<UserModel> GetAll()
        {
            var userList = new List<UserModel>();
            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "Select * from Users_Tbl ORDER BY id desc";
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        UserModel model = new UserModel();
                        model.Id = (int)reader[0];
                        model.Username = reader[1].ToString();
                        model.First_name = reader[3].ToString();
                        model.Last_name = reader[4].ToString();
                        model.Role = (UserRole)reader[5];
                        model.Email = reader[6].ToString();
                        model.Phone = reader[7].ToString();
                        model.Is_active = model.Is_active = (bool)reader["is_active"];
                        model.Is_deleted = model.Is_active = (bool)reader["is_deleted"];
                        model.Created_at = (DateTime)reader[10];
                        model.Updated_at = (DateTime)reader[11];
                        userList.Add(model);
                    }
                    return userList;

                }
            }
        }

        public IEnumerable<UserModel> GetByValue(string value)
        {
            throw new NotImplementedException();
        }

       
    }
}
