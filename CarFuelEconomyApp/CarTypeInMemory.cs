
using System.Reflection.Metadata.Ecma335;

namespace CarFuelEconomyApp
{
    
    
    internal class CarTypeinMemory : CarTypeBase
    {
        public delegate void CarTypeAddedDelegate(object sender, EventArgs args);
        
        public string Brand;
        private string Plate;
        private float Distance;
        private double Volume;

        public event CarTypeAddedDelegate AddedValue;
        public CarTypeinMemory(string brand, string plate, float distance, double volume)
            : base(brand, plate, distance, volume)
        {

        }

        public override void AddGrade(float grade)
        {
            if (grade >= 0 && grade <= 100)
            {
                this.AddGrade(grade);
                if (AddedValue != null)
                {
                    AddedValue(this, new EventArgs());
                }
            }
        }

        public virtual void AddGrade(string grade)
        {
            {
                if (float.TryParse(grade, out float result))
                {
                    this.AddGrade(result);
                }
                else
                {
                    throw new Exception("Invalid number");
                }

            }
        }
        public override void AddGrade(double grade)
        {
            
        }

        public override void AddGrade(decimal grade)
        {
            throw new NotImplementedException();
        }

        public override Statistics GetStatistics()
        {
            throw new NotImplementedException();
        }
    }
}
