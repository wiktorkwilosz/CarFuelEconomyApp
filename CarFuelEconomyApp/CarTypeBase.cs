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
        public CarTypeBase(string brand, string plate)
        {
            this.Brand = brand;
            this.Plate = plate;
            

        }
        
        public string Brand { get;  set;}
        public string Plate { get;  set;}
        public float Distance { get; set; }
        
      
        public abstract void AddGrade(float grade);

        public abstract void AddGrade(int grade);


        public abstract Statistics GetStatistics();
        public abstract void AddGrade(string grade);
        
        public abstract Statistics RememberTheCollectedPoints();

    }
    }

