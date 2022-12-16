using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fingoti.Command
{
    public class NetworkIP : Command
    {
        public NetworkIP(CommandOperation operation, NetworkIPPayload? payload)
        {
            Property = "networkIp";
            Operation = operation;
            Payload = payload;
        }
    }

    public class NetworkIPPayload : IPayload
    { 
        public NetworkIPPayload() { }

        public NetworkIPPayload(bool dHCP, string? local, string? mask, string? gateway, string? dNS)
        {
            DHCP = dHCP;
            Local = local;
            Mask = mask;
            Gateway = gateway;
            DNS = dNS;
        }

        public bool DHCP { get; set; }
        public string? Local { get; set; }
        public string? Mask { get; set; }
        public string? Gateway { get; set; }
        public string? DNS { get; set; }
    }

    public partial class Builder 
    { 
        /// <summary>
        /// Adds a networkIp read command to the builder
        /// </summary>
        public void AddNetworkIP()
        {
            this.Request.Add(new NetworkIP(CommandOperation.Read, null));
        }

        /// <summary>
        /// Adds a networkIp write command to the builder
        /// </summary>
        /// <param name="dhcp"></param>
        /// <param name="local"></param>
        /// <param name="mask"></param>
        /// <param name="gateway"></param>
        /// <param name="dns"></param>
        public void AddNetworkIP(bool dhcp, string? local, string? mask, string? gateway, string? dns)
        {
            var payload = new NetworkIPPayload(dhcp, local, mask, gateway, dns);

            Validate(payload);

            this.Request.Add(new NetworkIP(CommandOperation.Write, payload));
        }

        /// <summary>
        /// An alternative way to add a networkIp command to the builder
        /// </summary>
        /// <param name="operation"></param>
        /// <param name="payload"></param>
        public void AddNetworkIP(CommandOperation operation, NetworkIPPayload? payload = null)
        {
            Validate(payload);

            this.Request.Add(new NetworkIP(operation, payload));
        }
    }
}
