using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ElektroninisDienynas
{
    [Serializable]
    public struct Entry : IComparable, IEquatable<Entry>
    {
        public DateTime dateTime { get; set; }
        public string message { get; set; }
        public Lazy<EntryList> requirements;
        public string person { get; set; }

        public EntryList Requirements
        {
            get
            {
                return requirements.Value;
            }
        }

        public Entry(DateTime dateTime, string message, string person, EntryList requirements = null)
        {
            if (requirements == null)
                this.requirements = new Lazy<EntryList>();
            else this.requirements = new Lazy<EntryList>(() =>
            {
                return requirements;
            });    
            DateTime now = DateTime.Now;
            if (dateTime < now) throw new BeforeNowException("Entry date has to be later then current date!");
            this.person = person;
            this.dateTime = dateTime;           
            this.message = message;
        }

        public override string ToString()
        {
            if (dateTime.Minute < 10 && dateTime.Hour < 10)
                return dateTime.Year.ToString() + "/" + dateTime.Month.ToString() + "/" + dateTime.Day.ToString() + " 0" + dateTime.Hour.ToString() + ":0" + dateTime.Minute.ToString() + " - " + message;
            if (dateTime.Minute < 10)
                return dateTime.Year.ToString() + "/" + dateTime.Month.ToString() + "/" + dateTime.Day.ToString() + " " + dateTime.Hour.ToString() + ":0" + dateTime.Minute.ToString() + " - " + message;
            if (dateTime.Hour < 10)
                return dateTime.Year.ToString() + "/" + dateTime.Month.ToString() + "/" + dateTime.Day.ToString() + " 0" + dateTime.Hour.ToString() + ":" + dateTime.Minute.ToString() + " - " + message;
            return dateTime.Year.ToString() + "/" + dateTime.Month.ToString() + "/" + dateTime.Day.ToString() + " " + dateTime.Hour.ToString() + ":" + dateTime.Minute.ToString() + " - " + message;
        }

        public int CompareTo(Object entry)
        {
            if (dateTime > ((Entry)entry).dateTime) return 1;
            if (dateTime == ((Entry)entry).dateTime) return 0;
            return -1;
        }

        public bool Equals(Entry other)
        {
            if (dateTime == other.dateTime && message == other.message) return true;
            else return false;
        }
    }
}
