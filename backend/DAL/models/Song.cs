using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.models
{
    public class Song
    {
        private static connectToDB connection = new connectToDB();
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]

        public string Id { get; set; }
        public string Name { get; set; }
        public string Creator { get; set; }
        public string Maker { get; set; }
        public DateTime UploadDate { get; set; }
        public List<double> Notes { get; set; }

        public Song(string name,string maker,string creator)
        {
            this.Name = name;
            this.Maker = maker;
            this.Creator = creator;
            this.UploadDate = DateTime.Now;
        }
        
    }
}
