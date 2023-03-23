

namespace CarFuelEconomyApp
{
    public interface ICarType
    {
        public string Brand { get; set; }
        public string Plate { get; set; }
        public void AddGrade (float grade);
        public void AddGrade(double grade);
        public void AddGrade(decimal grade);
        public  void AddGrade(string grade);
        
        Statistics GetStatistics();
    }
}
