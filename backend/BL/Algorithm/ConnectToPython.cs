using DAL;
using DAL.models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Algorithm
{
    public class ConnectToPython
    {
        connectToDB c = new connectToDB();
        public ConnectToPython() { }
        public void addMusicNotesToSong(Song song, List<double> notes)
        {
            c.addMusicNotesToSong(song, notes);
        }
        public void fullProcess(string path)
        {
            // full path of python interpreter 
            string pythonPath = @"C:\Python39\python.exe";

            // python app to call 
            string pythonFile = "analyzer.py";

            //get the path of the song from the angular and there is no reason to save it in the db.
            //the result of the process will be saved in the db.
            string SongPath = path;
            ProcessStartInfo start = new ProcessStartInfo();
            start.FileName = pythonPath;
            start.Arguments = string.Format("{0} {1}", pythonFile,SongPath);
            start.UseShellExecute = false;
            start.RedirectStandardOutput = true;
            using (Process process = Process.Start(start))
            {
                using (StreamReader reader = process.StandardOutput)
                {
                    string result = reader.ReadToEnd();
                    Console.Write(result);
                    //add the result to the song notes list
                    //---
                }
            }
        }
        public void drowNotes(List<double> Notes) {
            Process process = new Process();
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.WindowStyle = ProcessWindowStyle.Hidden;
            startInfo.FileName = "Python.exe";
            startInfo.Arguments = string.Format("{0} {1}","drawNotes.py", Notes);
            process.StartInfo = startInfo;
            process.Start();
        }
    }
}
