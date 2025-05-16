namespace Dyreinternat_Library
{
    public class DoctorVisit

    {
        private DateTime _datetime;
        private string _description;
        private int _animalID;
        private int _createdByEmployeeID;

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


        public DoctorVisit(DateTime dateTime, string description, int animalID, int createdByEmployeeID) 
        {
            Datetime = dateTime;
            Description = description;
            AnimalID = animalID;
            CreatedByEmployeeID = createdByEmployeeID;
        
        
        }

    }
}
