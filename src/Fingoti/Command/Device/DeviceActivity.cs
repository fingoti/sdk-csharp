using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fingoti.Command
{
    public class DeviceActivity : Command
    {
        public DeviceActivity(CommandOperation operation, DeviceActivityPayload? payload)
        {
            Property = "deviceActivity";
            Operation = operation;
            Payload = payload;
        }
    }

    public class DeviceActivityPayload : IPayload
    {
        public DeviceActivityPayload() { }

        public DeviceActivityPayload(bool enabled)
        {
            Enabled = enabled;
        }

        public bool Enabled { get; set; }
    }

    public partial class Builder
    {
        /// <summary>
        /// Adds a deviceActivity read command to the builder
        /// </summary>
        public void AddDeviceActivity()
        {
            this.Request.Add(new DeviceActivity(CommandOperation.Read, null));
        }

        /// <summary>
        /// Adds a deviceActivity write command to the builder
        /// </summary>
        /// <param name="enabled"></param>
        public void AddDeviceActivity(bool enabled)
        {
            this.Request.Add(new DeviceActivity(CommandOperation.Write, new DeviceActivityPayload(enabled)));
        }

        /// <summary>
        /// An alternative way to add a deviceActivity command to the builder
        /// </summary>
        /// <param name="operation"></param>
        /// <param name="payload"></param>
        public void AddDeviceActivity(CommandOperation operation, DeviceActivityPayload? payload = null)
        {
            this.Request.Add(new DeviceActivity(operation, payload));
        }
    }
}
