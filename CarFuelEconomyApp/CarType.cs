using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarFuelEconomyApp
{
    
    public  class CarType : CarTypeBase
    {
        private List<float> values = new List<float>();
        public CarType(string brand, string plate, float distance, float volume)
            :base(brand, plate, distance, volume)
        {
            this.Brand = brand;
            this.Plate = plate;
            this.Distance = distance;
            this.Volume= volume;
        }




        public string Brand { get; private set; }
        public string Plate { get; private set; }
        public float Distance { get; private set; } 
        public double Volume { get; private set; }  

       

        public override void AddGrade(float grade)
        {
            float result = (float)grade;
            this.AddGrade(result);
        }
        public override void AddGrade(decimal grade)
        {
            float result = (float)grade;
            this.AddGrade(result);
        }



        public override Statistics GetStatistics()
        {
            var statistics = new Statistics();


            foreach (var grade in values)
            {
                if (grade > 0)
                {
                    continue;
                }

            }

            return statistics;
        }

        public override Statistics RememberTheCollectedPoints()
        {
            throw new NotImplementedException();
        }
    }
}
