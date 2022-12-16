using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fingoti.Command
{
    public class WifiDetect : Command
    {
        public WifiDetect()
        {
            Property = "wifiDetect";
            Operation = CommandOperation.Read;
        }
    }

    public partial class Builder
    {
        /// <summary>
        /// Adds a wifiDetect read command to the builder
        /// </summary>
        public void AddWifiDetect()
        {
            this.Request.Add(new WifiDetect());
        }
    }
}
