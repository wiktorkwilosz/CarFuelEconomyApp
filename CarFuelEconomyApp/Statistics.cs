

namespace CarFuelEconomyApp
{
    public class Statistics
    {
        public double Volume { get;  set; }

        public float Distance { get;  set; }
        public int Count { get;  set; }



        public Statistics()
        {
            this.Distance = 0;
            this.Volume = 0.0;

        }
        public double Average
        {
            get
            {
                return Volume * 100 / Distance;

            }
        }

        internal void AddGrade(float grade)
        {
            throw new NotImplementedException();
        }
    }
}
    
    

