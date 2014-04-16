using System;
using System.Configuration;
using System.Collections.Specialized;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace LogBB
{
    public class Log
    {
        private string logFilesDirectory = @"D:\CBSLogs\";
        /// <summary>
        /// naam van logfile
        /// </summary>
        private string logFile;
        private List<LogMessage> _messages = new List<LogMessage>();
    
        public Log(string name)
        {
            string File = logFilesDirectory+name+"-"+DateTime.Now.ToShortDateString()+".log";
            this.logFile = File;
            if(!System.IO.File.Exists(File))
            {
                //als pad niet bestaat maak het
                if(!System.IO.Directory.Exists(this.logFilesDirectory))
                {
                    System.IO.Directory.CreateDirectory(this.logFilesDirectory);
                }
                var b = System.IO.File.Create(File);
                b.Close();//sluit et weer af anders onstaan er conflicten
            }
        }

        public List<LogMessage> Messages
        {
            get
            {
                return this._messages;
            }
            set
            {
                this._messages = value;
            }
        }

        public string LogFile
        {
            get { return this.logFile; }
        }

        /// <summary>
        /// Functie om meldingen weg te schrijven naar een log
        /// </summary>
        /// <param name="type">geef de ernst van de melding weer kan je late kiezen om bepaalde meldingen uit te schakkelen</param>
        /// <param name="message">melding die weggeschreven moet worden.</param>
        public void AddLog(LogType type, string message)
        {
            LogMessage tempMessage = new LogMessage(type, message);
            this._messages.Add(tempMessage);
            this._writeToLog(tempMessage);
        }

        public void AddLog(LogMessage logMessage)
        {
            this._messages.Add(logMessage);
            this._writeToLog(logMessage);
        }

        /// <summary>
        /// hier wordt de message weer uit elkaar gehaald en zo opgemaakt dat het naar een bestand kan worden geschreven
        /// </summary>
        /// <param name="bericht"></param>
        public bool DeleteLogFile()
        {
            if(System.IO.File.Exists(this.logFile))
            {
                System.IO.File.Delete(this.logFile);
                return true;
            }
            return false;
        }

        private void _writeToLog(LogMessage bericht)
        {
            using (StreamWriter w = File.AppendText(this.logFile))
            {
                w.Write("\r\nLog Entry : ");
                w.Write("type: {0}\n", bericht.Type.ToString());
                w.WriteLine("{0}", bericht.Time.ToLongTimeString());
                w.WriteLine("  :");
                w.WriteLine("  :{0}", bericht.Message);
                w.WriteLine("-------------------------------");
            }
        }
    }
}
