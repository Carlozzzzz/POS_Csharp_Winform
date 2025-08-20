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
            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"INSERT INTO Users_Tbl
                                        VALUES (@username, @password, @first_name, @last_name, @role, @email, @phone, @is_active, @created_at, @updated_at)";
                command.Parameters.Add("@username", System.Data.SqlDbType.NVarChar).Value = userModel.Username;
                command.Parameters.Add("@password", System.Data.SqlDbType.NVarChar).Value = userModel.Password;
                command.Parameters.Add("@first_name", System.Data.SqlDbType.NVarChar).Value = userModel.First_name;
                command.Parameters.Add("@last_name", System.Data.SqlDbType.NVarChar).Value = userModel.Last_name;
                command.Parameters.Add("@role", System.Data.SqlDbType.Int).Value = (int)userModel.Role;
                command.Parameters.Add("@email", System.Data.SqlDbType.NVarChar).Value = userModel.Email;
                command.Parameters.Add("@phone", System.Data.SqlDbType.NVarChar).Value = userModel.Phone;
                command.Parameters.Add("@is_active", System.Data.SqlDbType.NVarChar).Value = userModel.Is_active;
                command.Parameters.Add("@phone", System.Data.SqlDbType.NVarChar).Value = userModel.Created_at;
                command.Parameters.Add("@phone", System.Data.SqlDbType.NVarChar).Value = userModel.Updated_at;
                command.ExecuteNonQuery();
            }
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
                        model.Id = Convert.ToInt32(reader["id"]);
                        model.Username = reader["username"].ToString();
                        model.First_name = reader["first_name"].ToString();
                        model.Last_name = reader["last_name"].ToString();
                        model.Role = (UserRole)reader["role"];
                        model.Email = reader["email"].ToString();
                        model.Phone = reader["phone"].ToString();
                        model.Is_active = (bool)reader["is_active"];
                        model.Is_deleted = (bool)reader["is_deleted"];
                        model.Created_at = (DateTime)reader["created_at"];
                        model.Updated_at = (DateTime)reader["updated_at"];
                        userList.Add(model);
                    }
                    return userList;

                }
            }
        }

        public IEnumerable<UserModel> GetByValue(string value)
        {
            var userList = new List<UserModel>();
            int userId = int.TryParse(value, out _) ? Convert.ToInt32(value) : 0;
            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"Select * from Users_Tbl 
                                        WHERE id=@id 
                                            OR username LIKE '%'+@value+'%'
                                            OR first_name LIKE '%'+@value+'%'
                                            OR last_name LIKE '%'+@value+'%'
                                            OR email LIKE '%'+@value+'%'
                                            OR phone LIKE '%'+@value+'%'
                                        ORDER BY id desc";
                command.Parameters.Add("@id", System.Data.SqlDbType.Int).Value = userId;
                command.Parameters.Add("@value", System.Data.SqlDbType.NVarChar).Value = value;
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        UserModel model = new UserModel();
                        model.Id = Convert.ToInt32(reader["id"]);
                        model.Username = reader["username"].ToString();
                        model.First_name = reader["first_name"].ToString();
                        model.Last_name = reader["last_name"].ToString();
                        model.Role = (UserRole)reader["role"];
                        model.Email = reader["email"].ToString();
                        model.Phone = reader["phone"].ToString();
                        model.Is_active = (bool)reader["is_active"];
                        model.Is_deleted = (bool)reader["is_deleted"];
                        model.Created_at = (DateTime)reader["created_at"];
                        model.Updated_at = (DateTime)reader["updated_at"];
                        userList.Add(model);
                    }
                    return userList;
                }
            }
        }
    }
}
