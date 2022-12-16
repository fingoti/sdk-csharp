using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fingoti.Command
{
    public class NetworkInternet : Command
    {
        public NetworkInternet()
        {
            Property = "networkInternet";
            Operation = CommandOperation.Read;
        }
    }

    public partial class Builder
    {
        /// <summary>
        /// Adds a networkInternet read command to the builder
        /// </summary>
        public void AddNetworkInternet()
        {
            this.Request.Add(new NetworkInternet());
        }
    }
}
