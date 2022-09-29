using DAL.models;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
   public class connection
    {
        private IMongoCollection<T> ConnectToMongo<T>(in string collection)
        {
            const string connectionString = "mongodb://localhost:27017";

            // Create a MongoClient object by using the connection string
            MongoClient client = new MongoClient(connectionString);

            //Use the MongoClient to access the server
            var database = client.GetDatabase("MUSICLYZER");

            //get mongodb collection
            return database.GetCollection<T>(collection);
        }

        public bool findUser(User u)
        {
            var userCollection = ConnectToMongo<User>("Users");
            var result = userCollection.Find(us => us.Name == u.Name && us.Password == u.Password);
            if (result.ToList().Count() > 0)
                return true;
            return false;
        }
        public bool insert(User u)
        {
            var userCollection = ConnectToMongo<User>("Users");
            userCollection.InsertOne(u);
            return findUser(u);
        }
        public bool findSong(Song s)
        {
            return true;
        }
        public void insertSong(Song s)
        {

        }
    }
}
