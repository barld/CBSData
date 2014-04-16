using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LogBB
{
    public class LogMessage
    {
        private string _message;
        private LogType _type;
        private DateTime _time = DateTime.Now;
        /// <summary>
        /// Maak een nieuwe logMessage bericht aan je geeft aan welke bericht en de urgentie er van.
        /// </summary>
        public LogMessage(LogType type, string message)
        {
            this._type = type;
            this._message = message;
        }

        /// <summary>
        /// kijken of deze constructor echt nuttig blijkt
        /// </summary>
        public LogMessage()
        {
            
        }

        public string Message
        {
            get
            {
                return this._message;
            }
            set
            {
                this._message = value;
            }
        }

        public DateTime Time
        {
            get
            {
                return this._time;
            }
            set
            {
                this._time = value;
            }
        }

        public LogType Type
        {
            get
            {
                return this._type;
            }
            set
            {
                this._type = value;
            }
        }
    }
}
