using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fingoti.Command
{
    public enum I2CSpeed 
    {
        Slow = 100000,
        Fast = 400000,
        Superfast = 1000000,
    }

    public class I2CSetup : Command
    {
        public I2CSetup(CommandOperation operation, I2CSetupPayload? payload)
        {
            Property = "i2cSetup";
            Operation = operation;
            Payload = payload;
        }
    }

    public class I2CSetupPayload : IPayload
    { 
        public I2CSetupPayload() { }

        public I2CSetupPayload(int speed, bool scan)
        {
            Speed = speed;
            Scan = scan;
        }

        [Range(2500, 1000000)]
        public int Speed { get; set; }
        public bool Scan { get; set; }
    }

    public partial class Builder 
    {
        /// <summary>
        /// Adds a i2cSetup read command to the builder
        /// </summary>
        public void AddI2CSetup()
        {
            this.Request.Add(new I2CSetup(CommandOperation.Read, null));
        }

        /// <summary>
        /// Adds a i2cSetup write command to the builder
        /// </summary>
        /// <param name="speed"></param>
        /// <param name="scan"></param>
        public void AddI2CSetup(I2CSpeed speed, bool scan)
        {
            var payload = new I2CSetupPayload((int)speed, scan);

            Validate(payload);

            this.Request.Add(new I2CSetup(CommandOperation.Write, payload));
        }

        /// <summary>
        /// An alternative way to add a i2cSetup command to the builder
        /// </summary>
        /// <param name="operation"></param>
        /// <param name="payload"></param>
        public void AddI2CSetup(CommandOperation operation, I2CSetupPayload? payload = null)
        {
            Validate(payload);

            this.Request.Add(new I2CSetup(operation, payload));
        }
    }
}
