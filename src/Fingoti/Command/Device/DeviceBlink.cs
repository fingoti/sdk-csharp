using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fingoti.Command
{
    public enum BlinkSpeed 
    {
        Off,
        Slow,
        Medium,
        Fast,
        Fastest
    }

    public class DeviceBlink : Command
    {
        public DeviceBlink(CommandOperation operation, DeviceBlinkPayload? payload)
        {
            Property = "deviceBlink";
            Operation = operation;
            Payload = payload;
        }
    }

    public class DeviceBlinkPayload : IPayload
    {
        public DeviceBlinkPayload() { }

        public DeviceBlinkPayload(BlinkSpeed state)
        {
            State = state;
        }

        public BlinkSpeed State { get; set; }
    }

    public partial class Builder
    {
        /// <summary>
        /// Adds a deviceBlink read command to the builder
        /// </summary>
        public void AddDeviceBlink()
        {
            this.Request.Add(new DeviceBlink(CommandOperation.Read, null));
        }

        /// <summary>
        /// Adds a deviceBlink write command to the builder
        /// </summary>
        /// <param name="state"></param>
        public void AddDeviceBlink(BlinkSpeed state)
        {
            this.Request.Add(new DeviceBlink(CommandOperation.Write, new DeviceBlinkPayload(state)));
        }

        /// <summary>
        /// An alternative way to add a deviceBlink command to the builder
        /// </summary>
        /// <param name="operation"></param>
        /// <param name="payload"></param>
        public void AddDeviceBlink(CommandOperation operation, DeviceBlinkPayload? payload = null)
        {
            this.Request.Add(new DeviceBlink(operation, payload)); 
        }
    }
}
