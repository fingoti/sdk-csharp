using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fingoti.Command
{
    public class ScheduleSetup : Command
    {
        public ScheduleSetup(CommandOperation operation, ScheduleSetupPayload payload)
        {
            Property = "scheduleSetup";
            Operation = operation;
            Payload = payload;
        }
    }

    public class ScheduleSetupPayload : IPayload
    {
        public ScheduleSetupPayload() { }

        public ScheduleSetupPayload(int slot)
        {
            Slot = slot;
            Clear = null;
        }

        public ScheduleSetupPayload(int slot, bool clear)
        {
            Slot = slot;
            Clear = clear;
        }

        [Range(1,4)]
        public int Slot { get; set; }
        public bool? Clear { get; set; }
    }

    public partial class Builder 
    { 
        /// <summary>
        /// Adds a scheduleSetup read command to the builder
        /// </summary>
        /// <param name="slot"></param>
        public void AddScheduleSetup(int slot)
        {
            var payload = new ScheduleSetupPayload(slot);

            Validate(payload);

            this.Request.Add(new ScheduleSetup(CommandOperation.Read, payload));
        }

        /// <summary>
        /// Adds a scheduleSetup write command to the builder
        /// </summary>
        /// <param name="slot"></param>
        /// <param name="clear"></param>
        public void AddScheduleSetup(int slot, bool clear)
        {
            var payload = new ScheduleSetupPayload(slot, clear);

            Validate(payload);

            this.Request.Add(new ScheduleSetup(CommandOperation.Write, payload));
        }

        /// <summary>
        /// An alternative way to add a scheduleSetup command to the builder
        /// </summary>
        /// <param name="operation"></param>
        /// <param name="payload"></param>
        public void AddScheduleSetup(CommandOperation operation, ScheduleSetupPayload payload)
        {
            Validate(payload);

            this.Request.Add(new ScheduleSetup(operation, payload));
        }
    }
}
