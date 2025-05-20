using System.Xml.Linq;

namespace Dyreinternat_Library
{
    public class Activity
    {

        //Instance Variables
        private string _title;
        private string _description;
        private DateTime _datetime;
        private int _numberOfPerticipants;
        private string _author;
        private int _activityID;

        //Properties
        public string Title
        {
            get => _title;
            set => _title = value;
        }

        public string Description
        {
            get => _description;
            set => _description = value;
        }
        public DateTime DateTime 
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
            get
            {
                return _activityID;
            }
            set => _activityID = value;
        }


        //Constructor
        public Activity(string title, string description, DateTime datetime, int numberOfPerticipants, string author, int activityID) 
        { 
        
            _title = title;
            _description = description;
            _datetime = datetime;
            _numberOfPerticipants = numberOfPerticipants;
            _author = author;
            _activityID = activityID;
        }

        public Activity()
        {

        }

    }
}
