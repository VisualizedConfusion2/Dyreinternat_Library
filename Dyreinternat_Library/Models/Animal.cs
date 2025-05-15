namespace Dyreinternat_Library.Models
{
    public class Animal
    {
        private string name;
        private string race;
        private string species;
        private int chipNumber;
        private string characteristics;
        private string size;
        private int birthYear;
        private string medicalHistory;
        private string visitorLog;

        public string Name
        {
            get => name;
            set => name = value;
        }

        public string Race
        {
            get => race;
            set => race = value;
        }

        public string Species
        {
            get => species;
            set => species = value;
        }

        public int ChipNumber
        {
            get => chipNumber;
            set => chipNumber = value;
        }

        public string Characteristics
        {
            get => characteristics;
            set => characteristics = value;
        }

        public string Size
        {
            get => size;
            set => size = value;
        }

        public int BirthYear
        {
            get => birthYear;
            set => birthYear = value;
        }

        public string MedicalHistory
        {
            get => medicalHistory;
            set => medicalHistory = value;
        }

        public string VisitorLog
        {
            get => visitorLog;
            set => visitorLog = value;
        }

        public Animal(string nameValue, string raceValue, string speciesValue, int chipNumberValue,
              string characteristicsValue, string sizeValue, int birthYearValue,
              string medicalHistoryValue, string visitorLogValue)
        {
            name = nameValue;
            race = raceValue;
            species = speciesValue;
            chipNumber = chipNumberValue;
            characteristics = characteristicsValue;
            size = sizeValue;
            birthYear = birthYearValue;
            medicalHistory = medicalHistoryValue;
            visitorLog = visitorLogValue;
        }
    }
}
