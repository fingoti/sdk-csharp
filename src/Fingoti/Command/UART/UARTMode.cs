using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fingoti.Command
{
    public enum UartMode
    {
        Interpreter,
        Passthrough
    }

    public class UARTMode : Command
    {
        public UARTMode(CommandOperation operation, UARTModePayload? payload) 
        {
            Property = "uartMode";
            Operation = operation;
            Payload = payload;
        }
    }

    public class UARTModePayload : IPayload
    {
        public UARTModePayload() { }

        public UARTModePayload(UartMode mode)
        {
            Mode = mode;
        }

        public UartMode Mode { get; set; }
    }

    public partial class Builder
    {
        /// <summary>
        /// Adds a uartMode read commnad to the builder
        /// </summary>
        public void AddUARTMode()
        {
            this.Request.Add(new UARTMode(CommandOperation.Read, null));
        }

        /// <summary>
        /// Adds a uartMode write command to the builder
        /// </summary>
        /// <param name="mode"></param>
        public void AddUARTMode(UartMode mode)
        {
            var payload = new UARTModePayload(mode);

            Validate(payload);

            this.Request.Add(new UARTMode(CommandOperation.Write, payload));
        }

        /// <summary>
        /// An alternative way to add a uartMode command to the builder
        /// </summary>
        /// <param name="operation"></param>
        /// <param name="payload"></param>
        public void AddUARTMode(CommandOperation operation, UARTModePayload? payload = null)
        {
            Validate(payload);

            this.Request.Add(new UARTMode(operation, payload));
        }
    }
}
