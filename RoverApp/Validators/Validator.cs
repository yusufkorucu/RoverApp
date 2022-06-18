using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoverApp.Validators
{
    public class Validator : IValidator
    {
        /// <summary>
        /// Send to Command Validate İs valid command  True or False Return
        /// </summary>
        /// <param name="command"></param>
        /// <returns>true,false</returns>
        public bool CommandValidate(char command)
        {
            bool commandCheck = false;
            
            char[] commands = { 'L', 'R', 'M'};

            foreach (var item in commands)
            {
                if (command.Equals(item))
                {
                    commandCheck=true;
                    break;

                }
            }
            
            if (commandCheck)
                return true;
            return false;

            
        }
    }
}
