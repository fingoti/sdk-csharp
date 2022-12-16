using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fingoti.Command
{
    public enum Parity
    {
        None,
        Odd,
        Even
    }

    public enum Stopbits 
    {
        One,
        OneHalf,
        Two,
    }

    public class UARTSetup : Command
    {
        public UARTSetup(CommandOperation operation, UARTSetupPayload? payload)
        {
            Property = "uartSetup";
            Operation = operation;
            Payload = payload;
        }
    }

    public class UARTSetupPayload : IPayload
    {
        public UARTSetupPayload() { }

        public UARTSetupPayload(int baudrate, int databits, Parity parity, Stopbits stopbits)
        {
            Baudrate = baudrate;
            Databits = databits;
            Parity = parity;
            Stopbits = stopbits;
        }

        [Range(300, 3686400)]
        public int Baudrate { get; set; }
        [Range(5, 8)]
        public int Databits { get; set; }
        public Parity Parity { get; set; } 
        public Stopbits Stopbits { get; set; }
    }

    public partial class Builder
    {
        /// <summary>
        /// Adds a uartSetup read command to the builder
        /// </summary>
        public void AddUARTSetup()
        {
            this.Request.Add(new UARTSetup(CommandOperation.Read, null));
        }

        /// <summary>
        /// Adds a uartSetup write command to the builder
        /// </summary>
        /// <param name="baudrate"></param>
        /// <param name="databits"></param>
        /// <param name="parity"></param>
        /// <param name="stopbits"></param>
        public void AddUARTSetup(int baudrate, int databits, Parity parity, Stopbits stopbits)
        {
            var payload = new UARTSetupPayload(baudrate, databits, parity, stopbits);

            Validate(payload);

            this.Request.Add(new UARTSetup(CommandOperation.Write, payload));
        }

        /// <summary>
        /// An alternative way to add a uartSetup command to the builder
        /// </summary>
        /// <param name="operation"></param>
        /// <param name="payload"></param>
        public void AddUARTSetup(CommandOperation operation, UARTSetupPayload? payload = null)
        {
            Validate(payload);

            this.Request.Add(new UARTSetup(operation, payload));
        }
    }
}
