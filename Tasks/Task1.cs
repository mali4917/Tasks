using System.Security.Cryptography.Xml;

namespace Tasks
{
    public enum Preferance
    { 
        max, midium, min
    }
    public class Task1
    { 
        public DateTime Time { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public Preferance Pref { get; set; }

        public Task1(DateTime time,string title, string description, Preferance pref)
        {
            Time = time;
            Title = title;
            Description = description;
            Pref = pref;
        }
    }
}