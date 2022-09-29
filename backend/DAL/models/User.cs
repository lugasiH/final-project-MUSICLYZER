using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace DAL.models
{
    public class User
    {
        private static connection connection = new connection();

        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        public string Name { get; set; }

        public string Password { get; set; }

        public string Email { get; set; }

        public List<Song> Songs { get; set; }
        public User() { }
        public User(string name,string password,string email)
        {
            this.Name = name;
            this.Password = password;
            this.Email = email;
            this.Songs = new List<Song>();
        }
        
        public bool CheckUser(User u)
        {
            return connection.findUser(u);
        }
        public bool AddUser(User u)
        {
            return connection.insert(u);
        }
    }
}
