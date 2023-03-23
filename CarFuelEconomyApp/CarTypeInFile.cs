

using System.Reflection.Metadata.Ecma335;

namespace CarFuelEconomyApp
{
    public class CarTypeInFile : CarTypeBase
    {
        public delegate void CarTypeAddedDelegate(object sender, EventArgs args);
        public event CarTypeAddedDelegate CarTypeAdded;

        public const string fileName = "CarTypeAppValues.txt";

        public object AddedValue { get; private set; }

       

        public CarTypeInFile(string brand, string plate, float distance, double volume)
            
        {
            Brand = brand;
            Plate = plate;
            Distance = distance;
            Volume = volume;

        }

       
        public override void AddGrade(float grade)
        {
            using (var writer = File.AppendText(fileName))
            {

                writer.WriteLine(grade);
            }
                    //        if (AddedValue != null)
                    //        {
                    //            AddedValue(this, new EventArgs());
                    //        }
                    //    }
                    //    else
                    //    {
                    //        throw new Exception("Błędna wartość, wartość musi być wieksza od zera");
                    //    }
                    //}
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
                        var namber = float.Parse(line);
                        grades.Add(namber);
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
                }

            }
            return statistics;
        }

        public override void AddGrade(double grade)
        {
            throw new NotImplementedException();
        }

        public override void AddGrade(decimal grade)
        {
            throw new NotImplementedException();
        }
    }
}




      