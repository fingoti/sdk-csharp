using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fingoti.Command
{
    public class DeviceInformation : Command
    {
        public DeviceInformation()
        {
            Property = "deviceInformation";
            Operation = CommandOperation.Read;
        }
    }

    public partial class Builder
    { 
        /// <summary>
        /// Adds a deviceInformation read command to the builder
        /// </summary>
        public void AddDeviceInformation()
        {
            this.Request.Add(new DeviceInformation());
        }
    }
}
