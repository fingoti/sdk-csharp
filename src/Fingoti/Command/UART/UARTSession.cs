using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fingoti.Command
{
    public class UARTSession : Command
    {
        public UARTSession(CommandOperation operation, UARTSessionPayload? payload)
        {
            Property = "uartSession";
            Operation = operation;
            Payload = payload;
        }
    }

    public class UARTSessionPayload : IPayload
    {
        public UARTSessionPayload() { }

        public UARTSessionPayload (int duration)
        {
            Duration = duration;
        }

        [Range(0, 1440)]
        public int Duration { get; set; }
    }

    public partial class Builder
    { 
        /// <summary>
        /// Adds a uartSession read command to the builder
        /// </summary>
        public void AddUARTSession()
        {
            this.Request.Add(new UARTSession(CommandOperation.Read, null));
        }

        /// <summary>
        /// Adds a uartSession write command to the builder
        /// </summary>
        /// <param name="duration"></param>
        public void AddUARTSession(int duration)
        {
            var payload = new UARTSessionPayload(duration);

            Validate(payload);

            this.Request.Add(new UARTSession(CommandOperation.Write, payload));
        }

        /// <summary>
        /// An alternative way to add a uartSession command to the builder
        /// </summary>
        /// <param name="operation"></param>
        /// <param name="payload"></param>
        public void AddUARTSession(CommandOperation operation, UARTSessionPayload? payload = null)
        {
            Validate(payload);

            this.Request.Add(new UARTSession(operation, payload));  
        }
    }
}
