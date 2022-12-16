using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fingoti.Command
{
    public class I2CDetect : Command
    {
        public I2CDetect()
        {
            Property = "i2cDetect";
            Operation = CommandOperation.Read;
        }
    }

    public partial class Builder
    { 
        /// <summary>
        /// Adds a i2cDetect read command to the builder
        /// </summary>
        public void AddI2CDetect()
        {
            this.Request.Add(new I2CDetect());
        }
    }
}
