using RoverApp.Classes.Vehicle.Interface;
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

        public RoverVehicle(IValidator validator)
        {
            this.validator = validator;
        }

        public void Proc(string commadList)
        {

            foreach (char command in commadList)
            {
                if (validator.CommandValidate(command))
                {
                    // valide command Run
                }
            }

        }
    }
}
