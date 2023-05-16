namespace CarFuelEconomyApp.Tests
{
    public class Tests
    {

        [Test]
        public void CheckCarTypeStatisticsMax()
        {
            //arrange

            var cartype = new CarTypeInMemory("Mercedes", "Clk");
            cartype.AddGrade(655f);
            cartype.AddGrade(500);
            cartype.AddGrade(425);

            //act

            var result = cartype.GetStatistics();
            //assert

            Assert.AreEqual(655f, cartype.GetStatistics().Max);

        }
        [Test]
        public void CheckCarTypeStatisticsMin()
        {
            //arrange

            var cartype = new CarTypeInMemory("Mercedes", "Clk");
            cartype.AddGrade(655);
            cartype.AddGrade(500);
            cartype.AddGrade(1);

            //act

            var result = cartype.GetStatistics();
            //assert

            Assert.AreEqual(1, cartype.GetStatistics().Min);
        }

    }

 }


   
