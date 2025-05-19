namespace Dyreinternat_Library
{
    public class DoctorVisit

    {
        //Instance Variables
        private DateTime _datetime;
        private string _description;
        private int _animalID;
        private int _createdByEmployeeID;

        //Properties
        public DateTime Datetime
        {
            get { return _datetime; }
            set { _datetime = value; }
        }

        public string Description
        {
            get => _description;
            set
            {
                _description = value;
            }
        }

        public int AnimalID
        {
            get { return _animalID; }
            set { _animalID = value; }
        }
        public int CreatedByEmployeeID
        {
            get { return _createdByEmployeeID; }
            set { _createdByEmployeeID = value; }
        }


        //Constructor
        public DoctorVisit(DateTime dateTime, string description, int animalID, int createdByEmployeeID) 
        {
            _datetime = dateTime;
            _description = description;
            _animalID = animalID;
            _createdByEmployeeID = createdByEmployeeID;
        
        
        }

    }
}
