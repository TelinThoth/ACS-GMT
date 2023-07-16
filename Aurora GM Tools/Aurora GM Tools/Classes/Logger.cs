using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Aurora_GM_Tools.Classes
{
    class Logger
    {
        string fileName;
        string querryFile;

        public Logger()
        {
            string home = AppDomain.CurrentDomain.BaseDirectory;
            fileName = home + "/Logs/GMTools.Log";
            querryFile = home + "/Logs/GMQuerry.Log";

            CheckLogFile(fileName);
            CheckLogFile(querryFile);
        }

        public void LogQuerry(string CommandText)
        {
            using (StreamWriter ghostWriter = File.AppendText(querryFile))
            {
                ghostWriter.WriteLine(CommandText);
            }
        }

        public void LogLine(string Line)
        {
            using (StreamWriter ghostWriter = File.AppendText(fileName))
            {
                ghostWriter.WriteLine(Line);
            }
            
        }

        public void AddBreaks()
        {
            string breaks = "\n-----  -----  -----\n";
            using (StreamWriter breakAdder = File.AppendText(fileName))
            {
                breakAdder.WriteLine(breaks);
            }
            using (StreamWriter breakAdder = File.AppendText(querryFile))
            {
                breakAdder.WriteLine(breaks);
            }
        }

        private void CheckLogFile(string name)
        {
            string home = AppDomain.CurrentDomain.BaseDirectory + "/Logs";
            if (!Directory.Exists(home))
            {
                Directory.CreateDirectory(home);
            }

            if (File.Exists(name))
            {
                FileInfo meta = new FileInfo(name);

                string newName = name + "." + meta.CreationTime.ToString("yyyymmddHHmmssfff");
                File.Move(name, newName);
            }
            using (File.Create(name));
        }
    }
}
