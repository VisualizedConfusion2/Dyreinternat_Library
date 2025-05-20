namespace Dyreinternat_Library
{
    public class Blog
    {
        //Instance Variables
        private string _title;
        private string _description;
        private DateTime _datetime;
        private string _img;
        private string _author;
        private int _blogID;

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

        public string Image
        {
            get => _img;
            set => _img = value;
        }

        public string Author
        {
            get => _author;
            set => _author = value;
        }

        public int BlogID
        {
            get
            {
                return _blogID;
            }
            set => _blogID = value;
        }


        //Constructor
        public Blog(string title, string description, DateTime dateTime, string image, string author, int blogID) 
        { 
            _title = title;
            _description = description;
            _datetime = dateTime;
            _img = image;
            _author = author;
            _blogID = blogID;
        
        }

    }
}
