using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fingoti.Command
{
    public class NetworkMAC : Command
    {
        public NetworkMAC()
        {
            Property = "networkMac";
            Operation = CommandOperation.Read;
        }
    }

    public partial class Builder 
    {
        /// <summary>
        /// Adds a networkMac read command to the builder
        /// </summary>
        public void AddNetworkMAC()
        {
            this.Request.Add(new NetworkMAC());
        }
    }
}
