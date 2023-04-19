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
        public CarType(string brand, string plate)
            :base(brand, plate)
        {
            this.Brand = brand;
            this.Plate = plate;
            
        }




        public string Brand { get; private set; }
        public string Plate { get; private set; }
        public float Distance { get; private set; } 
       

       

        public override void AddGrade(float grade)
        {
            float result = (float)grade;
            this.AddGrade(result);
        }
       

        public override void AddGrade(int grade)
        {
            throw new NotImplementedException();
        }
        public override void AddGrade(string grade)
        {
            if (float.TryParse(grade, out float result))
            {
                this.AddGrade(result);
            }
            else
            {
                throw new Exception("Niepoprawna wartość");
            }

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
