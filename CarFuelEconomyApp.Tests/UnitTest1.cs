namespace CarFuelEconomyApp.Tests
{
    public class Tests
    {

        [Test]
        public void CheckCarTypeStatisticsCount()
        {
            //arrange
            
            var cartype = new CarType("Merc","CLK");
            cartype.AddGrade(600);
            cartype.AddGrade(500);
            cartype.AddGrade(400);

            //act

            var statistics = cartype.GetStatistics();
            //assert

            //Assert.AreEqual(600, statistics.Max);
            Assert.AreEqual(400, statistics.Min);
            //Assert.AreEqual(500, cartype.GetStatistics().Average);
            //Assert.AreEqual(3, statistics.Count);
            //Assert.AreEqual(150, statistics.Sum);
        }
        [Test]
        public void CheckCarType()
        {
            var cartype = new CarType("Mercedes","CLK");

            Assert.That("Mercedes",Is.EqualTo(cartype.Brand));
            Assert.That("CLK", Is.EqualTo(cartype.Plate));

        }
    }
}