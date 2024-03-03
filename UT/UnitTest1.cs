using Pruebas;

namespace SaveTheOceanUT
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ToStringRescue()
        {
            Rescue rescue = new Rescue("RES123", "17-06-2024", "Tortuga marina", 23, "Barcelona");
            string expected = "+-------------------------------------------------------------+\n" +
                              "|                       RESCAT                                |\n" +
                              "+-------------------------------------------------------------+\n" +
                              "| # Rescat | Data rescat | Superfamília  | GA | Localització |\n" +
                              "+-------------------------------------------------------------+\n" +
                              "|  RES123  | 17-06-2024  |   Tortuga marina   | 23 |   Barcelona  |\n" +
                              "+-------------------------------------------------------------+\n";

            string actual = rescue.ToString();  

            Assert.AreEqual(expected.Trim(), actual.Trim());
        }

        [TestMethod]
        public void ToStringCetacean()
        {
            Cetacean cetacean = new Cetacean();
            string expected = "+-------------------------------------------------------------+\n" +
                  "|                       FITXA                                 |\n" +
                  "+-------------------------------------------------------------+\n" +
                  "| # Nom | Superfamília |    Espècie     |    Pes aproximat    |\n" +
                  "+-------------------------------------------------------------+\n" +
                  "| Oumou |    Cetaci    |  Dofí llistat  |       20,5kg        |\n" +
                  "+-------------------------------------------------------------+\n";

            string actual = cetacean.ToString();

            Assert.AreEqual(expected.Trim(), actual.Trim());
        }

        [TestMethod]
        public void CetaceanTreatmentChoice1()
        {
            Cetacean cetacean = new Cetacean();

            int expected = 43;

            int actual = cetacean.Treatment(20, 1);

            Assert.AreEqual(expected, actual);  
        }

        [TestMethod]
        public void CetaceanTreatmentChoice2()
        {
            Cetacean cetacean = new Cetacean();

            int expected = 18;

            int actual = cetacean.Treatment(20, 2);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TurtleTreatment()
        {
            Turtle turtle = new Turtle();

            int expected = 769;

            int actual = turtle.Treatment(20, 1);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SeaBirdTreatmentChoice1()
        {
            SeaBird seaBird = new SeaBird();

            int expected = -385;

            int actual = seaBird.Treatment(20, 1);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SeaBirdTreatmentChoice2()
        {
            SeaBird seaBird = new SeaBird();

            int expected = -380;

            int actual = seaBird.Treatment(20, 2);

            Assert.AreEqual(expected, actual);
        }
    }
}