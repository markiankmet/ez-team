using FullApp.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace FullApp.Repositories
{
    public class UserRepository : RepositoryBase, IUserRepository
    {
        public void Add(UserModel userModel)
        {
            throw new NotImplementedException();
        }

        public bool Authenticate(NetworkCredential credential)
        {
            bool validUser;
            using (var connection = GetConnection())
            using (var command = new NpgsqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "SELECT * FROM \"Users\" WHERE username=@username AND \"password\"=@password";
                command.Parameters.Add("@username", NpgsqlTypes.NpgsqlDbType.Text).Value = credential.UserName;
                command.Parameters.Add("@password", NpgsqlTypes.NpgsqlDbType.Text).Value = credential.Password;
                validUser = command.ExecuteScalar() != null;
            }
            return validUser;
        }

        public void Edit(UserModel userModel)
        {
            throw new NotImplementedException();
        }
        public IEnumerable<UserModel> GetByAll()
        {
            throw new NotImplementedException();
        }
        public UserModel GetById(int id)
        {
            throw new NotImplementedException();
        }
        

        public UserModel GetByUsername(string username)
        {
        UserModel user = null;
        using (var connection = GetConnection())
        using (var command = new NpgsqlCommand())
        {
            connection.Open();
            command.Connection = connection;
            command.CommandText = "SELECT * FROM \"Users\" WHERE username=@username";
            command.Parameters.Add("@username", NpgsqlTypes.NpgsqlDbType.Text).Value = username;
            using (var reader = command.ExecuteReader())
            {
                if (reader.Read())
                {
                    user = new UserModel()
                    {
                        Id = reader[0].ToString(),
                        Username = reader[1].ToString(),
                        Password = string.Empty,
                        Name = reader[3].ToString(),
                        LastName = reader[4].ToString(),
                        Email = reader[5].ToString(),
                    };
                }
            }
        }
        return user;
    }

    public void Remove(int id)
        {
            throw new NotImplementedException();
        }
    }
}
