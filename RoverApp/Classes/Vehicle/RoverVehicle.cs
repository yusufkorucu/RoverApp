using RoverApp.Classes.Plato.Interface;
using RoverApp.Classes.Position.Interface;
using RoverApp.Classes.Vehicle.Interface;
using RoverApp.Enums;
using RoverApp.Validators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoverApp.Classes.Vehicle
{
    public class RoverVehicle : IRoverVehicle
    {
       IValidator validator;

        public IPlato plato;

        public IPosition vehiclePosition;

        public Navigate vehicleNavige { get; set; }

        public string ErrorMesage { get; set; }

        public RoverVehicle(IPlato plato,IPosition vehiclePosition,Navigate vehicleNavige, IValidator validator)
        {
            this.plato = plato;
            this.vehiclePosition = vehiclePosition;
            this.vehicleNavige = vehicleNavige;
            this.validator = validator;
        }

        public void Proc(string commadList)
        {
            //Validator validator = new Validator();

            foreach (char command in commadList)
            {
                if (validator.CommandValidate(command))
                {
                    // valide command Run
                    switch (command)
                    {
                        case ('L'):
                            RunLeft();
                            break;
                        case ('R'):
                            RunRight();
                            break;
                        case ('M'):
                            Run();
                            break;
                    }
                }
                else
                {

                    ErrorMesage = "Error Command Request";
                }

               
                
            }

        }

        /// <summary>
        /// Rover RunLeft Method
        /// </summary>
        private void RunLeft()
        {
            vehicleNavige =( vehicleNavige - 1) < Navigate.N ? Navigate.W :
                vehicleNavige - 1;

        }
        /// <summary>
        /// Rover RunRight Method
        /// </summary>
        private void RunRight()
        {
            vehicleNavige = (vehicleNavige + 1) > Navigate.W ? Navigate.N : vehicleNavige + 1;
        }
        /// <summary>
        /// Rover Run Method
        /// </summary>
        private void Run()
        {
            if (vehicleNavige == Navigate.N)
            {
                vehiclePosition.Y++;
            }
            else if (vehicleNavige == Navigate.W)
            {
                vehiclePosition.X--;
            }
            else if (vehicleNavige == Navigate.S)
            {
                vehiclePosition.Y--;
            }
            else if (vehicleNavige == Navigate.E)
            {
                vehiclePosition.X++;
            }
            
           
        }

        public override string ToString()
        {
            string message=$"{vehiclePosition.X} , {vehiclePosition.Y}  {vehicleNavige}";
            return message;
        }
    }
}
