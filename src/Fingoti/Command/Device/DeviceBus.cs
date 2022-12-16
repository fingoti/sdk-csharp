using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fingoti.Command
{
    public enum BusMode
    {
        UART,
        I2C
    }

    public class DeviceBus : Command
    {
        public DeviceBus(CommandOperation operation, DeviceBusPayload? payload)
        {
            Property = "deviceBus";
            Operation = operation;
            Payload = payload;
        }
    }

    public class DeviceBusPayload : IPayload
    {
        public DeviceBusPayload() { }

        public DeviceBusPayload(BusMode protocol)
        {
            Protocol = protocol;
        }

        public BusMode Protocol { get; set; }
    }

    public partial class Builder
    {
        /// <summary>
        /// Adds a deviceBus read command to the builder
        /// </summary>
        public void AddDeviceBus()
        {
            this.Request.Add(new DeviceBus(CommandOperation.Read, null));
        }

        /// <summary>
        /// Adds a deviceBus write command to the builder
        /// </summary>
        /// <param name="protocol"></param>
        public void AddDeviceBus(BusMode protocol)
        {
            this.Request.Add(new DeviceBus(CommandOperation.Write, new DeviceBusPayload(protocol)));
        }

        /// <summary>
        /// An alternative way to add a deviceBus command to the builder
        /// </summary>
        /// <param name="operation"></param>
        /// <param name="payload"></param>
        public void AddDeviceBus(CommandOperation operation, DeviceBusPayload? payload)
        {
            this.Request.Add(new DeviceBus(operation, payload));
        }
    }
}
