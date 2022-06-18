using RoverApp.Classes.Plato;
using RoverApp.Classes.Position;
using RoverApp.Classes.Vehicle;
using RoverApp.Enums;
using RoverApp.Validators;

namespace RoverAppTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

      
        [Test]
        public void TestInvalidRequest()
        {
            Validator validator = new Validator();
            Plato plato = new Plato(new Position(5, 5));
            RoverVehicle vehicle = new RoverVehicle(plato, new Position(1, 2), Navigate.N, validator);
            vehicle.Proc("asdasdasdasd");
            Assert.AreEqual(vehicle.ErrorMesage, "Error Command Request");
        }
        [Test]
        public void FirstRoverVehicle()
        {
            Validator validator = new Validator();
            Plato plato = new Plato(new Position(5, 5));
            RoverVehicle vehicle = new RoverVehicle(plato, new Position(1, 2), Navigate.N, validator);
            vehicle.Proc("LMLMLMLMM");
            
            Assert.AreEqual(vehicle.ToString(), "1 , 3  N");
        }

        [Test]
        public void SecondRoverVehicle()
        {
            Validator validator = new Validator();
            Plato plato1 = new Plato(new Position(5, 5));
            RoverVehicle vehicle1 = new RoverVehicle(plato1, new Position(3, 3), Navigate.E, validator);
            vehicle1.Proc("MMRMMRMRRM");
            Assert.AreEqual(vehicle1.ToString(), "5 , 1  E");
        }


    }
}