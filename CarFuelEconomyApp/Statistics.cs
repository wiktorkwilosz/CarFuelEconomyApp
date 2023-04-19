

namespace CarFuelEconomyApp
{
    public class Statistics
    {

        public float Min { get; private set; }

        public float Max { get; private set; }

        public float Sum { get; private set; }

        public int Count { get; private set; }

        public float Distance { get; set; }




        public Statistics()
        {
            this.Distance = 0;
            this.Count = 0;
            this.Sum = 0;
            this.Min = float.MaxValue;
            this.Max = float.MinValue;

        }
        public float Average
        {
            get
            {
                if(Count ==0)
                {
                    return 0;
                }
                else
                {
                    return this.Sum/ this.Count;
                }

            }
        }

        public void AddGrade(float grade)
        {
            this.Distance += grade;
            this.Count++;
            this.Sum += grade;
            this.Min = Math.Min(grade, this.Min);
            this.Max = Math.Max(grade, this.Max);
        }

        public string PointsCollected { get; internal set; }
    }

}
    
    

