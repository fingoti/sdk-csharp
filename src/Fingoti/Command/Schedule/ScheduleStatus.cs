using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fingoti.Command
{
    public class ScheduleStatus : Command
    {
        public ScheduleStatus(CommandOperation operation, ScheduleStatusPayload payload)
        {
            Property = "scheduleStatus";
            Operation = operation;
            Payload = payload;  
        }
    }

    public class ScheduleStatusPayload : IPayload 
    {
        public ScheduleStatusPayload() { }

        public ScheduleStatusPayload(int slot)
        {
            Slot = slot;
            Enabled = null;
        }

        public ScheduleStatusPayload(int slot, bool enabled)
        {
            Slot = slot;
            Enabled = enabled;
        }

        [Range(1,4)]
        public int Slot { get; set; }
        public bool? Enabled { get; set; }
    }

    public partial class Builder
    {
        /// <summary>
        /// Adds a scheduleStatus read command to the builder
        /// </summary>
        /// <param name="slot"></param>
        public void AddScheduleStatus(int slot)
        {
            var payload = new ScheduleStatusPayload(slot);

            Validate(payload);

            this.Request.Add(new ScheduleStatus(CommandOperation.Read, payload));
        }
        
        /// <summary>
        /// Adds a scheduleStatus write command to the builder
        /// </summary>
        /// <param name="slot"></param>
        /// <param name="enabled"></param>
        public void AddScheduleStatus(int slot, bool enabled)
        {
            var payload = new ScheduleStatusPayload(slot, enabled);

            Validate(payload);

            this.Request.Add(new ScheduleStatus(CommandOperation.Write, payload));
        }

        /// <summary>
        /// An alternative way to add a scheduleStatus command to the builder
        /// </summary>
        /// <param name="operation"></param>
        /// <param name="payload"></param>
        public void AddScheduleStatus(CommandOperation operation, ScheduleStatusPayload payload)
        {
            Validate(payload);

            this.Request.Add(new ScheduleStatus(operation, payload));
        }
    }
}
