namespace Dyreinternat_Library
{
    public class Blog
    {
        //Instance Variables
        private string _titel;
        private string _description;
        private DateTime _datetime;
        private string _img;
        private string _author;
        private int _blogID;

        //Properties
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
        public Blog(string titel, string description, DateTime datetime, string image, string author, int blogID) 
        { 
            Titel = titel;
            Description = description;
            DateTime = datetime;
            Image = image;
            Author = author;
            BlogID = blogID;
        
        }

    }
}
