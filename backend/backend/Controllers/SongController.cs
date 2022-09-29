using BL;
using BL.Algorithm;
using DAL;
using DAL.models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using System.Web.Http.Cors;

namespace backend.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    [RoutePrefix("api/song")]

    public class SongController : ApiController
    {
        //[Route("Addsong")]
        //[HttpPost]

        //public bool Addsong(Song song)
        //{
        //    try
        //    {
        //        var files = HttpContext.Current.Request.Files;
        //        var folderName = Path.Combine("Resources", "Songs");
        //        var pathToSave = Path.Combine(Directory.GetCurrentDirectory(), folderName);
        //        //if we got a file
        //        if (files.Count > 0)
        //        {
        //            var wavfiles = new List<string>();
        //            foreach (string item in files)
        //            {
        //                var postedFile = files[item];
        //                var fullPath = Path.Combine(pathToSave, postedFile.FileName);
        //                var dbPath = Path.Combine(folderName, postedFile.FileName);
        //                var filePath = HttpContext.Current.Server.MapPath("~/" + folderName + "//" + postedFile.FileName);
        //                postedFile.SaveAs(filePath);
        //                wavfiles.Add(filePath);

        //                //connect to db and search for the song-if the song isn't exist:
        //                //add it to the songs collection and send it to full process fuction that analyze it
        //                // else:send the song to draw it's notes.
        //                ConnectToPython c = new ConnectToPython();
        //                connection c1 = new connection();
        //                bool ans = c1.findSong(song);
        //                if (ans == false)
        //                {
        //                    c1.insertSong(song);
        //                    //add the global current user this song to his songs list
        //                    //---
        //                    //call the full algorithm
        //                    c.fullProcess(filePath);
        //                    //if file path doesn't work try with postedFile.FileName
        //                }
        //                else
        //                    c.drowNotes(song.Notes);
        //            }
        //            return true;
        //        }
        //        else
        //        {
        //            return false;
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        return false;
        //    }

        //    return true;
        //}
    }
}