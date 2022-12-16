using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fingoti.Command
{
    public class DevicePoke : Command
    {
        public DevicePoke()
        {
            Property = "devicePoke";
            Operation = CommandOperation.Read;
        }
    }

    public partial class Builder
    {
        /// <summary>
        /// Adds a devicePoke read command to the builder
        /// </summary>
        public void AddDevicePoke()
        {
            this.Request.Add(new DevicePoke());
        }
    }
}
