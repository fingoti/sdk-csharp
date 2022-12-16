using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fingoti.Command
{
    public class DeviceSleep : Command
    {
        public DeviceSleep(DeviceSleepPayload payload)
        {
            Property = "deviceSleep";
            Operation = CommandOperation.Write;
            Payload = payload;
        }
    }

    public class DeviceSleepPayload : IPayload 
    {
        public DeviceSleepPayload() { }

        public DeviceSleepPayload(int period)
        {
            Duration = period;
        }

        public int Duration { get; set; }
    }

    public partial class Builder 
    { 
        /// <summary>
        /// Adds a deviceSleep write command to the builder
        /// </summary>
        /// <param name="period"></param>
        public void AddDeviceSleep(int period)
        {
            this.Request.Add(new DeviceSleep(new DeviceSleepPayload(period)));
        }

        /// <summary>
        /// An alternative way to add a deviceSleep command to the builder
        /// </summary>
        /// <param name="payload"></param>
        public void AddDeviceSleep(DeviceSleepPayload payload)
        {
            this.Request.Add(new DeviceSleep(payload));
        }
    }
}
