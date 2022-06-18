using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoverApp.Validators
{
    public interface IValidator
    {
        public bool CommandValidate(char command);
    }
}
