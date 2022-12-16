using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fingoti.Command
{
    public class WifiStatus : Command
    {
        public WifiStatus(CommandOperation operation, WifiStatusPayload? payload)
        {
            Property = "wifiStatus";
            Operation = operation;
            Payload = payload;
        }
    }

    public class WifiStatusPayload : IPayload
    {
        public WifiStatusPayload() { }

        public WifiStatusPayload(bool restart)
        {
            Restart = restart;
        }

        public bool Restart { get; set; }
    }

    public partial class Builder 
    {
        /// <summary>
        /// Adds a wifiStatus read command to the builder
        /// </summary>
        public void AddWifiStatus()
        {
            this.Request.Add(new WifiStatus(CommandOperation.Read, null));
        }
        
        /// <summary>
        /// Adds a wifiStatus write command to the builder
        /// </summary>
        /// <param name="restart"></param>
        public void AddWifiStatus(bool restart)
        {
            var payload = new WifiStatusPayload(restart);

            Validate(payload);

            this.Request.Add(new WifiStatus(CommandOperation.Write, payload));
        }

        /// <summary>
        /// An alternative way to add a wifiStatus command to the builder
        /// </summary>
        /// <param name="operation"></param>
        /// <param name="payload"></param>
        public void AddWifiStatus(CommandOperation operation, WifiStatusPayload? payload = null)
        {
            Validate(payload);

            this.Request.Add(new WifiStatus(operation, payload));
        }
    }
}
