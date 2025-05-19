namespace Dyreinternat_Library.Models
{
    public class Animal
    {
        //Instance Variables
        private string _name;
        private string _race;
        private string _species;
        private int _chipNumber;
        private string _characteristics;
        private string _size;
        private int _birthYear;
        private string _medicalHistory;
        private string _visitorLog;

        //Properties
        public string Name
        {
            get => _name;
            set => _name = value;
        }

        public string Race
        {
            get => _race;
            set => _race = value;
        }

        public string Species
        {
            get => _species;
            set => _species = value;
        }

        public int ChipNumber
        {
            get => _chipNumber;
            set => _chipNumber = value;
        }

        public string Characteristics
        {
            get => _characteristics;
            set => _characteristics = value;
        }

        public string Size
        {
            get => _size;
            set => _size = value;
        }

        public int BirthYear
        {
            get => _birthYear;
            set => _birthYear = value;
        }

        public string MedicalHistory
        {
            get => _medicalHistory;
            set => _medicalHistory = value;
        }

        public string VisitorLog
        {
            get => _visitorLog;
            set => _visitorLog = value;
        }

        //Constructor
        public Animal(string nameValue, string raceValue, string speciesValue, int chipNumberValue,
              string characteristicsValue, string sizeValue, int birthYearValue,
              string medicalHistoryValue, string visitorLogValue)
        {
            _name = nameValue;
            _race = raceValue;
            _species = speciesValue;
            _chipNumber = chipNumberValue;
            _characteristics = characteristicsValue;
            _size = sizeValue;
            _birthYear = birthYearValue;
            _medicalHistory = medicalHistoryValue;
            _visitorLog = visitorLogValue;
        }
    }
}
