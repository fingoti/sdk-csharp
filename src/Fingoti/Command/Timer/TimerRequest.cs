using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fingoti.Command
{
    public class TimerRequest : Command
    {
        public TimerRequest(CommandOperation operation, TimerRequestPayload? payload)
        {
            Property = "timerRequest";
            Operation = operation;
            Payload = payload;
        }
    }

    public class TimerRequestPayload : IPayload 
    {
        public TimerRequestPayload() { }

        public TimerRequestPayload(IEnumerable<Command> request)
        {
            Request = request;
        }

        public IEnumerable<Command> Request { get; set; }
    }

    public partial class Builder 
    {
        /// <summary>
        /// Adds a timerRequest read command to the builder
        /// </summary>
        public void AddTimerRequest()
        {
            this.Request.Add(new TimerRequest(CommandOperation.Read, null));
        }

        /// <summary>
        /// Adds a timerRequest write command to the builder
        /// </summary>
        /// <param name="request"></param>
        public void AddTimerRequest(IEnumerable<Command> request)
        {
            var payload = new TimerRequestPayload(request);

            Validate(payload);

            this.Request.Add(new TimerRequest(CommandOperation.Write, payload));
        }

        /// <summary>
        /// An alternative way to add a timerRequest command to the builder
        /// </summary>
        /// <param name="operation"></param>
        /// <param name="payload"></param>
        public void AddTimerRequest(CommandOperation operation, TimerRequestPayload? payload = null)
        {
            Validate(payload);

            this.Request.Add(new TimerRequest(operation, payload));
        }
    }
}
