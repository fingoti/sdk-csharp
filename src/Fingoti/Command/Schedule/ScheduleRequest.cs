using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fingoti.Command
{
    public class ScheduleRequest : Command
    {
        public ScheduleRequest(CommandOperation operation, ScheduleRequestPayload payload)
        {
            Property = "scheduleRequest";
            Operation = operation;
            Payload = payload;
        }
    }

    public class ScheduleRequestPayload : IPayload 
    {
        public ScheduleRequestPayload() { }

        public ScheduleRequestPayload(int slot)
        {
            Slot = slot;
        }

        public ScheduleRequestPayload(int slot, IEnumerable<Command> request)
        {
            Slot = slot;
            Request = request;
        }

        [Range(1, 4)]
        public int Slot { get; set; }
        [MaxLength(1)]
        public IEnumerable<Command> Request { get; set; }
    }

    public partial class Builder 
    {
        /// <summary>
        /// Adds a scheduleRequest read command to the builder
        /// </summary>
        /// <param name="slot"></param>
        public void AddScheduleRequest(int slot)
        {
            var payload = new ScheduleRequestPayload(slot);

            Validate(payload);

            this.Request.Add(new ScheduleRequest(CommandOperation.Read, payload));
        }

        /// <summary>
        /// Adds a scheduleRequest write command to the builder
        /// </summary>
        /// <param name="slot"></param>
        /// <param name="request"></param>
        public void AddScheduleRequest(int slot, IEnumerable<Command> request)
        {
            var payload = new ScheduleRequestPayload(slot, request);

            Validate(payload);

            this.Request.Add(new ScheduleRequest(CommandOperation.Write, payload));
        }

        /// <summary>
        /// An alternative way to add a scheduleRequest command to the builder
        /// </summary>
        /// <param name="operationm"></param>
        /// <param name="payload"></param>
        public void AddScheduleRequest(CommandOperation operationm, ScheduleRequestPayload payload) 
        {
            Validate(payload);

            this.Request.Add(new ScheduleRequest(operationm, payload));
        }
    }
}
