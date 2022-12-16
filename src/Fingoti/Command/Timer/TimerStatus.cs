using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fingoti.Command
{
    public class TimerStatus : Command
    {
        public TimerStatus(CommandOperation operation, TimerStatusPayload? payload)
        {
            Property = "timerStatus";
            Operation = operation;
            Payload = payload;
        }
    }

    public class TimerStatusPayload : IPayload
    {
        public TimerStatusPayload() { }

        public TimerStatusPayload(bool enabled, bool repeat)
        {
            Enabled = enabled;
            Repeat = repeat;
        }

        public bool Enabled { get; set; }
        public bool Repeat { get; set; }
    }

    public partial class Builder
    {
        /// <summary>
        /// Adds a timerStatus read command to the builder
        /// </summary>
        public void AddTimerStatus()
        {
            this.Request.Add(new TimerStatus(CommandOperation.Read, null));
        }

        /// <summary>
        /// Adds a timerStatus write command to the builder
        /// </summary>
        /// <param name="enabled"></param>
        /// <param name="repeat"></param>
        public void AddTimerStatus(bool enabled, bool repeat)
        {
            var payload = new TimerStatusPayload(enabled, repeat);

            Validate(payload);

            this.Request.Add(new TimerStatus(CommandOperation.Write, payload));
        }

        /// <summary>
        /// An alternative way to add a timerStatus command to the builder
        /// </summary>
        /// <param name="operation"></param>
        /// <param name="payload"></param>
        public void AddTimerStatus(CommandOperation operation, TimerStatusPayload? payload = null)
        {
            Validate(payload);

            this.Request.Add(new TimerStatus(operation, payload)); 
        }
    }
}
