using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fingoti.Command
{
    public class DeviceVersion : Command
    {
        public DeviceVersion()
        {
            Property = "deviceVersion";
            Operation = CommandOperation.Read;
        }
    }

    public partial class Builder 
    {
        /// <summary>
        /// Adds a deviceVersion read command to the builder
        /// </summary>
        public void AddDeviceVersion()
        {
            this.Request.Add(new DeviceVersion());
        }
    }
}
