using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fingoti.Command
{
    public class MQTTSetup : Command
    {
        public MQTTSetup(CommandOperation operation, MQTTSetupPayload? payload)
        {
            Property = "mqttSetup";
            Operation = operation;
            Payload = payload;
        }
    }

    public class MQTTSetupPayload : IPayload 
    {
        public MQTTSetupPayload() { }

        public MQTTSetupPayload(string host, int port, int qOS, bool secure, bool retain)
        {
            Host = host;
            Port = port;
            QOS = qOS;
            Secure = secure;
            Retain = retain;
        }

        public string Host { get; set; }
        [Range(1, 65535)]
        public int Port { get; set; }
        [Range(0, 2)]
        public int QOS { get; set; }
        public bool Secure { get; set; }
        public bool Retain { get; set; }
    }

    public partial class Builder
    {
        /// <summary>
        /// Adds a mqttSetup read command to the builder
        /// </summary>
        public void AddMQTTSetup()
        {
            this.Request.Add(new MQTTSetup(CommandOperation.Read, null));
        }

        /// <summary>
        /// Adds a mqttSetup write command to the builder
        /// </summary>
        /// <param name="host"></param>
        /// <param name="port"></param>
        /// <param name="qos"></param>
        /// <param name="secure"></param>
        /// <param name="retain"></param>
        public void AddMQTTSetup(string host, int port, int qos, bool secure, bool retain)
        {
            var paylaod = new MQTTSetupPayload(host, port, qos, secure, retain);

            Validate(paylaod);

            this.Request.Add(new MQTTSetup(CommandOperation.Write, paylaod));
        }

        /// <summary>
        /// An alternative way to add a mqttSetup command to the builder
        /// </summary>
        /// <param name="operation"></param>
        /// <param name="payload"></param>
        public void AddMQTTSetup(CommandOperation operation, MQTTSetupPayload payload = null)
        {
            Validate(payload);

            this.Request.Add(new MQTTSetup(operation, payload));
        }
    }

}
