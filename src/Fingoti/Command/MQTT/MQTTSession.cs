using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fingoti.Command
{
    public class MQTTSession : Command
    {
        public MQTTSession(CommandOperation operation, MQTTSessionPayload? payload)
        {
            Property = "mqttSession";
            Operation = operation;
            Payload = payload;
        }
    }

    public class MQTTSessionPayload : IPayload
    {
        public MQTTSessionPayload() { }

        public MQTTSessionPayload(int duration)
        {
            Duration = duration;
        }

        [Range(0, 1440)]
        public int Duration { get; set; }
    }

    public partial class Builder 
    {
        /// <summary>
        /// Adds a mqttSession read command to the builder
        /// </summary>
        public void AddMQTTSession()
        {
            this.Request.Add(new MQTTSession(CommandOperation.Read, null));
        }

        /// <summary>
        /// Adds a mqttSession write command to the builder
        /// </summary>
        /// <param name="duration"></param>
        public void AddMQTTSession(int duration)
        {
            var payload = new MQTTSessionPayload(duration);

            Validate(payload);

            this.Request.Add(new MQTTSession(CommandOperation.Write, payload));
        }

        /// <summary>
        /// An alternative way to add a mqttSession command to the builder
        /// </summary>
        /// <param name="operation"></param>
        /// <param name="payload"></param>
        public void AddMQTTSession(CommandOperation operation, MQTTSessionPayload payload = null)
        {
            Validate(payload);

            this.Request.Add(new MQTTSession(operation, payload));
        }
    }
}
