
using System.Reflection.Metadata.Ecma335;

namespace CarFuelEconomyApp
{
    
    
    internal class CarTypeinMemory : CarTypeBase
    {
        public delegate void CarTypeAddedDelegate(object sender, EventArgs args);

        private IEnumerable<object> grades;
        private byte grade;


        public string Brand;
        private string Plate;
        private float Distance;
        private float Volume;

        public event CarTypeAddedDelegate AddedValue;
        public CarTypeinMemory(string brand, string plate, float distance, float volume)
            : base(brand, plate, distance, volume)
        {

        }

        public override void AddGrade(float grade)
        {
            if (grade >= 0 )
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
                    throw new Exception("Niepoprawna wartość");
                }

            }
        }
       

        public override void AddGrade(decimal grade)
        {
            throw new NotImplementedException();
        }

        public override Statistics GetStatistics()
        {
            throw new NotImplementedException();
        }

        public override Statistics RememberTheCollectedPoints()
        {
            var statistics = new Statistics();

            foreach (var grade in this.grades)
            {
                statistics.PointsCollected += grade + ",";
            }
            return statistics;
        }
    }
}
