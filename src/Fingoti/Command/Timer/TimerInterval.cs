using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fingoti.Command
{
    public class TimerInterval : Command
    {
        public TimerInterval(CommandOperation operation, TimerIntervalPayload? payload)
        {
            Property = "timerInterval";
            Operation = operation;
            Payload = payload;
        }
    }

    public class TimerIntervalPayload : IPayload
    {
        public TimerIntervalPayload() { }

        public TimerIntervalPayload(int interval)
        {
            Interval = interval;
        }

        [Range(1, 86400)]
        public int Interval { get; set; }
    }

    public partial class Builder 
    { 
        /// <summary>
        /// Adds a timerInterval read command to the builder
        /// </summary>
        public void AddTimerInterval()
        {
            this.Request.Add(new TimerInterval(CommandOperation.Read, null));
        }

        /// <summary>
        /// Adds a timerInterval write command to the builder
        /// </summary>
        /// <param name="interval"></param>
        public void AddTimerInterval(int interval)
        {
            var payload = new TimerIntervalPayload(interval);

            Validate(payload);

            this.Request.Add(new TimerInterval(CommandOperation.Write, payload));
        }

        /// <summary>
        /// An alternative way to add a timerInterval command to the builder 
        /// </summary>
        /// <param name="operation"></param>
        /// <param name="payload"></param>
        public void AddTimerInterval(CommandOperation operation, TimerIntervalPayload? payload = null)
        {
            Validate(payload);

            this.Request.Add(new TimerInterval(operation, payload));
        }
    }
}
