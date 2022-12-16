using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fingoti.Command
{
    public class DevicePower : Command
    {
        public DevicePower()
        {
            Property = "devicePower";
            Operation = CommandOperation.Read;
        }
    }

    public partial class Builder
    {
        /// <summary>
        /// Adds a devicePower read command to the builder
        /// </summary>
        public void AddDevicePower()
        {
            this.Request.Add(new DevicePower());
        }
    }
}
