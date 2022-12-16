using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fingoti.Command
{
    public class I2CData : Command
    {
        public I2CData(I2CDataPayload payload)
        {
            Property = "i2cData";
            Operation = CommandOperation.Write;
            Payload = payload;
        }
    }

    public class I2CDataPayload : IPayload
    {
        public I2CDataPayload() { }

        public I2CDataPayload(int address, IEnumerable<string> profile)
        {
            Address = address;
            Profile = profile;
        }

        [Range(0, 127)]
        public int Address { get; set; }
        public IEnumerable<string> Profile { get; set; }
    }

    public partial class Builder
    {
        /// <summary>
        /// Adds an i2cData write command to the builder
        /// </summary>
        /// <param name="address"></param>
        /// <param name="profile"></param>
        public void AddI2CData(int address, IEnumerable<string> profile)
        {
            var paylaod = new I2CDataPayload(address, profile);

            Validate(paylaod);

            this.Request.Add(new I2CData(paylaod));
        }

        /// <summary>
        /// An alternative way to add a i2cData command to the builder
        /// </summary>
        /// <param name="payload"></param>
        public void AddI2CData(I2CDataPayload payload)
        {
            Validate(payload);

            this.Request.Add(new I2CData(payload));
        }
    }
}
