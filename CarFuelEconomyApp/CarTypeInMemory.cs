
using System.Reflection.Metadata.Ecma335;

namespace CarFuelEconomyApp
{
    
    
    internal class CarTypeinMemory : CarTypeBase
    {
        public delegate void CarTypeAddedDelegate(object sender, EventArgs args);

        private IEnumerable<object> grades;
        private byte grade;


   

        public event CarTypeAddedDelegate AddedValue;
        public CarTypeinMemory(string brand, string plate)
            : base(brand, plate)
        {

        }

        public override void AddGrade(float grade)
        {
            if (grade > 0 )
            {
                this.AddGrade(grade);
                if (AddedValue != null)
                {
                    AddedValue(this, new EventArgs());
                }
            }
            else
            {
                throw new Exception("Błędna wartość. Wartość musi być większa od zera");
            }
        }

        public override void AddGrade(string grade)
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


        public override void AddGrade(int grade)
        {
            float gradeAsFloat = (int)grade;
            this.AddGrade(gradeAsFloat);
        }

        public override Statistics GetStatistics()
        {
            var statistics = new Statistics();

            {

                {
                    foreach (var grade in this.grades) ;

                    statistics.AddGrade(grade);

                }



            }
            return statistics;
        }

        
    }
}
