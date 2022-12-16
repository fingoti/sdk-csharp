using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fingoti.Command
{
    public class DeviceTime : Command
    {
        public DeviceTime()
        {
            Property = "deviceTime";
            Operation = CommandOperation.Read;
        }
    }

    public partial class Builder
    {
        /// <summary>
        /// Adds a deviceTime read command to the builder
        /// </summary>
        public void AddDeviceTime()
        {
            this.Request.Add(new DeviceTime());
        }
    }
}
