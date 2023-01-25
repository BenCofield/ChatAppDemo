using System;
using ChatApp.Data;
using System.Data;
using Dapper;
using MySql.Data;

namespace ChatApp.SqlDb
{
    public class UserDataRepo
    {
        private readonly IDbConnection _connection;
        public UserDataRepo(IDbConnection connection)
        {
            this._connection = connection;
        }

        //public IEnumerable<UserData> TryLogin(string username, string password)
        //{
            
        //}

        public void CreateNewAccount(string username, string password)
        {
            _connection.Execute("INSERT INTO userdata (username, password) VALUES (@username, @password)",
                                new { username, password });
        }
    }
}

