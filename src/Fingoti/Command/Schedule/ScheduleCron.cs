using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fingoti.Command
{
    public class ScheduleCron : Command
    {
        public ScheduleCron(CommandOperation operation, ScheduleCronPayload payload)
        {
            Property = "scheduleCron";
            Operation = operation;
            Payload = payload;
        }
    }

    public class ScheduleCronPayload : IPayload
    {
        public ScheduleCronPayload() { }

        public ScheduleCronPayload(int slot)
        {
            Slot = slot;
            Cron = null;
        }

        public ScheduleCronPayload(int slot, string? cron)
        {
            Slot = slot;
            Cron = cron;
        }

        [Range(1, 4)]
        public int Slot { get; set; }
        public string? Cron { get; set; }
    }

    public partial class Builder 
    {
        /// <summary>
        /// Adds a scheduleCron read command to the builder
        /// </summary>
        /// <param name="slot"></param>
        public void AddScheduleCron(int slot)
        {
            var payload = new ScheduleCronPayload(slot);

            Validate(payload);

            this.Request.Add(new ScheduleCron(CommandOperation.Read, payload));
        }

        /// <summary>
        /// Adds a scheduleCron write command to the builder
        /// </summary>
        /// <param name="slot"></param>
        /// <param name="cron"></param>
        public void AddScheduleCron(int slot, string cron)
        {
            var payload = new ScheduleCronPayload(slot, cron);

            Validate(payload);

            this.Request.Add(new ScheduleCron(CommandOperation.Write, payload));
        }

        /// <summary>
        /// An alternative way to add a scheduleCron command to the builder
        /// </summary>
        /// <param name="operation"></param>
        /// <param name="payload"></param>
        public void AddScheduleCron(CommandOperation operation, ScheduleCronPayload payload)
        {
            Validate(payload);

            this.Request.Add(new ScheduleCron(operation, payload));
        }
    }
}
