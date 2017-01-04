using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tibia.API.Exceptions
{
    public class InvalidWorldException : Exception
    {
        public InvalidWorldException() 
            : base ()
        {

        }

        public InvalidWorldException(string message) 
            : base (message)
        {

        }

        public InvalidWorldException(string message, Exception exception) 
            : base (message, exception)
        {

        }
    }
}
