using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fingoti.Command
{
    public class UARTTrigger : Command
    {
        public UARTTrigger(CommandOperation operation, UARTTriggerPayload? payload)
        {
            Property = "uartTrigger";
            Operation = operation;
            Payload = payload;
        }
    }

    public class UARTTriggerPayload : IPayload
    {
        public UARTTriggerPayload() { }

        public UARTTriggerPayload(int length)
        {
            Length = length;
            Terminator = null;
        }

        public UARTTriggerPayload(IEnumerable<int>? terminator)
        {
            Length = 0;
            Terminator = terminator;
        }

        [Range(0, 256)]
        public int? Length { get; set; }
        [MaxLength(16)]
        public IEnumerable<int>? Terminator { get; set; }
    }

    public partial class Builder
    {
        /// <summary>
        /// Adds a uartTrigger read command to the builder
        /// </summary>
        public void AddUARTTrigger()
        {
            this.Request.Add(new UARTTrigger(CommandOperation.Read, null));
        }

        /// <summary>
        /// Adds a uartTrigger write command to the builder
        /// <para>
        /// Use this function to set the length of the UART trigger
        /// </para>
        /// </summary>
        /// <param name="length"></param>
        public void AddUARTTrigger(int length)
        {
            var payload = new UARTTriggerPayload(length);

            Validate(payload);

            this.Request.Add(new UARTTrigger(CommandOperation.Write, payload));
        }

        /// <summary>
        /// Adds a uartTrigger write command to the builder
        /// <para>
        /// Use this function to set the terminator UART trigger
        /// </para>
        /// </summary>
        /// <param name="terminator"></param>
        public void AddUARTTrigger(IEnumerable<int> terminator)
        {
            var payload = new UARTTriggerPayload(terminator);

            Validate(payload);

            this.Request.Add(new UARTTrigger(CommandOperation.Write, payload));
        }

        /// <summary>
        /// An alternative way to add a uartTrigger command to the builder
        /// </summary>
        /// <param name="operation"></param>
        /// <param name="payload"></param>
        public void AddUARTTrigger(CommandOperation operation, UARTTriggerPayload? payload = null)
        {
            Validate(payload);

            this.Request.Add(new UARTTrigger(operation, payload));
        }
    }
}
