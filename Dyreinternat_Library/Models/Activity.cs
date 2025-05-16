using System.Xml.Linq;

namespace Dyreinternat_Library
{
    public class Activity
    {
        private string _titel;
        private string _description;
        private string _datetime;
        private int _numberOfPerticipants;
        private string _author;
        private int _activityID;


        public string Titel
        {
            get => _titel;
            set => _titel = value;
        }

        public string Description
        {
            get => _description;
            set => _description = value;
        }
        public string DateTime 
        {
           get => _datetime;
           set => _datetime = value;
        
        }

        public int NumberOfPerticipants 
        { 
            get => _numberOfPerticipants;
            set => _numberOfPerticipants = value;
        
        }

        public string Author
        {
            get => _author;
            set => _author = value;
        }

        public int ActivityID
        {
            get => _activityID;
            set => _activityID = value;
        }

        public Activity(string titel, string description, string datetime, int numberOfPerticipants, string author, int activityID) 
        { 
        
            Titel = titel;
            Description = description;
            DateTime = datetime;
            NumberOfPerticipants = numberOfPerticipants;
            Author = author;
            ActivityID = activityID;
        
        
        
        }


    }
}
