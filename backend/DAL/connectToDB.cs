using DAL.models;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class connectToDB
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
        //just for trail-this function is unnecessary
        public List<User> GetAllUsers()
        {
            var userCollection = ConnectToMongo<User>("Users");
            var result = userCollection.Find(_ => true);
            List<User> r = result.ToList();
            return r;
        }
        public List<Song> GetAllSongs()
        {
            var songCollection = ConnectToMongo<Song>("Songs");
            var result = songCollection.Find(_ => true);
            return result.ToList();
        }
        public bool FindUser(User u)
        {
            var userCollection = ConnectToMongo<User>("Users");
            var result = userCollection.Find(us => us.Name==u.Name && us.Password==u.Password);
            if(result.ToList().Count()>0)
                 return true;
            return false;
        }
        public Song FindSong(string songname, string creator)
        {
            var songcollection = ConnectToMongo<Song>("Songs");
            var result = songcollection.Find(s => s.Name == songname && s.Creator == creator);
            return result.First();
        }
        //public List<Song> GetAllSongsOfUser(User currentUser)
        //{
        //    User u = FindUser(currentUser.Id);
        //    List<Song> s = u.Songs;
        //    return s;
        //}
        public async Task<bool> CheckUserAdd(User user)
        {
            var collection = ConnectToMongo<User>("users");
            var answer = await collection.FindAsync<User>(u => u.Email == user.Email).ConfigureAwait(false);
            if (answer.ToList().Count() > 0)
            {
                return true;
            }
            return false;
        }
        public void InsertUser(User user)
        {
            var userCollection = ConnectToMongo<User>("Users");
            userCollection.InsertOne(user);
        }
        public void InsertSong(string songname, string songcreator, string maker)
        {
            var songcollection = ConnectToMongo<Song>("Songs");
            Song s = FindSong(songname, songcreator);
            if (s == null)
            {
                Song song = new Song(songname, maker, songcreator);
                //add the new song to the songs collection
                songcollection.InsertOne(song);
               // return song;
            }
            //return s;
        }
        //public void AddSong(User currentUser, Song s)
        //{
        //    //check if the song is exist in the songs collection
        //    Song findsong = FindSong(s.Name, s.Creator);
        //    //find the current user to add the song to his songs list
        //    User user = FindUser(currentUser.Id);
        //    var usercollection = ConnectToMongo<User>("Users");
        //    if (findsong == null)
        //    {
        //        //create a new song
        //            InsertSong(s.Name, currentUser.Name, s.Creator);
        //        //add the song to the songs list of this current user
        //        findsong = FindSong(s.Name, s.Creator);
        //        user.Songs.Add(findsong);
        //        var filter = Builders<User>.Filter.Eq("_id", currentUser.Id);
        //        usercollection.ReplaceOne(filter, user);
        //    }
        //    else
        //    {
        //        //add this song to the songs list of this user
        //        user.Songs.Add(findsong);
        //        var filter = Builders<User>.Filter.Eq("_id", currentUser.Id);
        //        usercollection.ReplaceOne(filter, user);
        //    }
        //}
        public void addMusicNotesToSong(Song song, List<double> notes)
        {
            var songcollection = ConnectToMongo<Song>("Songs");
            Song s = FindSong(song.Name, song.Creator);
            foreach (double note in notes)
            {
                s.Notes.Append(note);
            }
        }
        //just if the user is exist in the users collection
        public void updateUserDetails(User user)
        {
            var usercollection = ConnectToMongo<User>("Users");
            //var u = FindUser(user.Id);
            var filter = Builders<User>.Filter.Eq("_id", user.Id);
            usercollection.ReplaceOne(u=>u.Id==user.Id,user);
            //usercollection.ReplaceOne(filter,user);
        }
    }
}
