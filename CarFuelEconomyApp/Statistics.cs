

namespace CarFuelEconomyApp
{
    public class Statistics
    {
        public float Volume { get; private set; }

        public float Distance { get;  private set; }
        



        public Statistics()
        {
            this.Distance = 0;
            this.Volume = 0;

        }
        public double Average
        {
            get
            {
                return Volume * 100 / Distance;

            }
        }

        public void AddGrade(float grade)
        {
            this.Distance += grade;
            this.Volume += grade;
        }

        public string PointsCollected { get; internal set; }
    }

}
    
    

