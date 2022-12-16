using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fingoti.Command
{
    public enum WifiSlot
    {
        Primary,
        Secondary,
    }

    public class WifiCredentials : Command
    {
        public WifiCredentials(CommandOperation operation, WifiCredentialsPayload? payload)
        {
            Property = "wifiCredentials";
            Operation = operation;
            Payload = payload;
        }
    }

    public class WifiCredentialsPayload : IPayload
    {
        public WifiCredentialsPayload() { }

        public WifiCredentialsPayload(WifiSlot slot, string sSID, string password)
        {
            Slot = slot;
            SSID = sSID;
            Password = password;
        }

        public WifiSlot Slot { get; set; }
        public string SSID { get; set; }
        public string Password { get; set; }
    }

    public partial class Builder
    {
        /// <summary>
        /// Adds a wifiCredentials read command to the builder
        /// </summary>
        public void AddWifiCredentials()
        {
            this.Request.Add(new WifiCredentials(CommandOperation.Read, null));
        }

        /// <summary>
        /// Adds a wifiCredentials write comamnd to the builder
        /// </summary>
        /// <param name="slot"></param>
        /// <param name="ssid"></param>
        /// <param name="passowrd"></param>
        public void AddWifiCredentials(WifiSlot slot, string ssid, string passowrd)
        {
            var payload = new WifiCredentialsPayload(slot, ssid, passowrd);

            Validate(payload);

            this.Request.Add(new WifiCredentials(CommandOperation.Write, payload));
        }

        /// <summary>
        /// An alternative way to add a wifiCredentials command to the builder
        /// </summary>
        /// <param name="operation"></param>
        /// <param name="payload"></param>
        public void AddWifiCredentials(CommandOperation operation, WifiCredentialsPayload? payload = null)
        {
            Validate(payload);

            this.Request.Add(new WifiCredentials(operation, payload));  
        }
    }
}
