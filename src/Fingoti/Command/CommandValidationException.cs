using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fingoti.Command
{
    public class CommandValidationException : Exception
    {
        public CommandValidationException(string message)
        {
            Message = message;
        }

        public override string Message { get; }
    }
}
