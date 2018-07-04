using System;
namespace web.Models
{
    public class Database
    {
        private string _server;
        private string _database_name;
        private string _uid;
        private string _password;

        public string Server { get => _server; set => _server = value; }

        public string Uid { get => _uid; set => _uid = value; }
        public string Password { get => _password; set => _password = value; }
        public string Database_name { get => _database_name; set => _database_name = value; }
    }
}