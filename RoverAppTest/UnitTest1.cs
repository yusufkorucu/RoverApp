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
    }
}