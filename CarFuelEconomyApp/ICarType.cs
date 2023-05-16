

namespace CarFuelEconomyApp
{
    public interface ICarType
    {
        public string Brand { get; set; }
        public string Plate { get; set; }
        public void AddGrade (float grade);

        public void AddGrade(int grade);
        public void AddGrade(string grade);

        
        Statistics GetStatistics();
    }
}
