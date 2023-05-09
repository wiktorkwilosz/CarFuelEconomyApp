

using System.Reflection.Metadata.Ecma335;

namespace CarFuelEconomyApp
{
    public class CarTypeInMemory : CarTypeBase
    {
        public delegate void CarTypeAddedDelegate(object sender, EventArgs args);
        public event CarTypeAddedDelegate AddedValue;

        public const string fileName = "CarTypeAppValues.txt";

        

       

        public CarTypeInMemory(string brand,string plate)
            :base(brand, plate) 
            
        {
            Brand = brand;
            Plate = plate;
            

        }

        

        public override void AddGrade(float grade)
        {
            using (var writer = File.AppendText(fileName))
            {
                if (grade > 0)

                {

                    writer.WriteLine(grade);
                    if (AddedValue != null)
                    {
                        AddedValue(this, new EventArgs());
                    }
                    


                }

            }
        }
        public override void AddGrade(int grade)
        {
            float gradeAsFloat = (int)grade;
            this.AddGrade(gradeAsFloat);
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
        public override Statistics GetStatistics()
        {
            var gradesFromFile = this.ReadGradesFromFile();
            var result = this.CountStatistics(gradesFromFile);

            return result;
        }
        private List<float> ReadGradesFromFile()
        {
            var grades = new List<float>();
            if (File.Exists(fileName))
            {
                using (var reader = File.OpenText(fileName))
                {
                    var line = reader.ReadLine();
                    while (line != null)
                    {
                        var number = float.Parse(line);
                        grades.Add(number);
                        line = reader.ReadLine();

                    }
                }
            } return grades;
        }
        private Statistics CountStatistics(List<float> grades)
        {
            var statistics = new Statistics();
            {


                foreach (var grade in grades)
                {

                    statistics.AddGrade(grade);
                    statistics.PointsCollected += grade;
                }

            }
            return statistics;
        }

       

       

        public override Statistics RememberTheCollectedPoints()
        {
            var gradesFromFile = this.ReadGradesFromFile();
            var result = this.CountStatistics(gradesFromFile);
            return result;
        }
    }
}




      