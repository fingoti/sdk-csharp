using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fingoti.Command
{
    public class DeviceUptime : Command
    {
        public DeviceUptime()
        {
            Property = "deviceUptime";
            Operation = CommandOperation.Read;
        }
    }

    public partial class Builder
    {
        /// <summary>
        /// Adds a deviceUptime read command to the builder
        /// </summary>
        public void AddDeviceUptime()
        {
            this.Request.Add(new DeviceUptime());
        }
    }
}
