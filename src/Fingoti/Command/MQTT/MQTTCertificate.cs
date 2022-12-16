using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fingoti.Command
{
    public class MQTTCertificate : Command
    {
        public MQTTCertificate(CommandOperation operation, MQTTCertificatePayload? payload)
        {
            Property = "mqttCertificate";
            Operation = operation;
            Payload = payload;
        }
    }

    public class MQTTCertificatePayload : IPayload
    {
        public MQTTCertificatePayload() { }

        public MQTTCertificatePayload(string? pem, bool? clear)
        {
            PEM = pem;
            Clear = clear;
        }

        public string? PEM { get; set; }
        public bool? Clear { get; set; }
    }

    public partial class Builder
    {
        /// <summary>
        /// Adds a mqttCertificate read command to the builder
        /// </summary>
        public void AddMQTTCertificate()
        {
            this.Request.Add(new MQTTCertificate(CommandOperation.Read, null));
        }

        /// <summary>
        /// Adds a mqttCertificate write command to the builder
        /// <para>
        /// Use this function to set the PEM string
        /// </para>
        /// </summary>
        /// <param name="pem"></param>
        public void AddMQTTCertificate(string pem)
        {
            var payload = new MQTTCertificatePayload(pem, null);

            Validate(payload);

            this.Request.Add(new MQTTCertificate(CommandOperation.Write, payload));
        }

        /// <summary>
        /// Adds a mqttCertificate write commmand to the builder
        /// <para>
        /// Use this function to clear the current certificate
        /// </para>
        /// </summary>
        /// <param name="clear"></param>
        public void AddMQTTCertificate(bool clear)
        {
            var payload = new MQTTCertificatePayload(null, clear);

            Validate(payload);

            this.Request.Add(new MQTTCertificate(CommandOperation.Write, payload));
        }

        /// <summary>
        /// An alternative way to add a mqttCertificate command to the builder
        /// </summary>
        /// <param name="operation"></param>
        /// <param name="payload"></param>
        public void AddMQTTCertificate(CommandOperation operation, MQTTCertificatePayload? payload)
        {
            Validate(payload);

            this.Request.Add(new MQTTCertificate(operation, payload));
        }
    }
}
