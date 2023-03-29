using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarFuelEconomyApp
{
    public abstract class CarTypeBase : ICarType
    {
        
        public delegate void CarTypeAddedDelegate(object sender, EventArgs args);
        public event CarTypeAddedDelegate CarTypeAdded;
        public CarTypeBase(string brand, string plate, float distance, float volume)
        {
            this.Brand = brand;
            this.Plate = plate;
            this.Distance = distance;
            this.Volume= volume;

        }
        
        public string Brand { get;  set;}
        public string Plate { get;  set;}
        public float Distance { get; set; }
        public float Volume { get; set; }  
        string ICarType.Brand { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        string ICarType.Plate { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public abstract void AddGrade(float grade);
       
        public abstract void AddGrade(decimal grade);
        public abstract Statistics GetStatistics();
        public  void AddGrade(string grade)
        {
            if (float.TryParse(grade, out float result))
            {
                this.AddGrade(result);
            }
            else
            {
                throw new Exception("Wprowadzona wartość musi być liczbą");
            }
        }
        public abstract Statistics RememberTheCollectedPoints();

    }
    }

