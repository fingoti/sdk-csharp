using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fingoti.Command
{
    public class NetworkTraffic : Command
    {
        public NetworkTraffic()
        {
            Property = "networkTraffic";
            Operation = CommandOperation.Read;
        }
    }

    public partial class Builder
    {
        /// <summary>
        /// Adds a networkTraffic read command to the builder
        /// </summary>
        public void AddNetworkTraffic()
        {
            this.Request.Add(new NetworkTraffic());
        }
    }
}
