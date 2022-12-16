using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fingoti.Command
{
    public class MQTTStatus : Command
    {
        public MQTTStatus(CommandOperation operation, MQTTStatusPayload? payload)
        {
            Property = "mqttStatus";
            Operation = operation;
            Payload = payload;
        }
    }

    public class MQTTStatusPayload : IPayload 
    {
        public MQTTStatusPayload() { }

        public MQTTStatusPayload(bool enabled)
        {
            Enabled = enabled;
        }

        public bool Enabled { get; set; }
    }

    public partial class Builder 
    {
        /// <summary>
        /// Adds a mqttStatus read command to the builder
        /// </summary>
        public void AddMQTTStatus()
        {
            this.Request.Add(new MQTTStatus(CommandOperation.Read, null));
        }

        /// <summary>
        /// Adds a mqttStatus write command to the builder
        /// </summary>
        /// <param name="enabled"></param>
        public void AddMQTTStatus(bool enabled)
        {
            var payload = new MQTTStatusPayload(enabled);

            Validate(payload);

            this.Request.Add(new MQTTStatus(CommandOperation.Write, payload));
        }

        /// <summary>
        /// An alternative way to add a mqttStatus command to the builder
        /// </summary>
        /// <param name="operation"></param>
        /// <param name="payload"></param>
        public void AddMQTTStatus(CommandOperation operation, MQTTStatusPayload payload = null)
        {
            Validate(payload);

            this.Request.Add(new MQTTStatus(operation, payload));  
        }
    }
}
