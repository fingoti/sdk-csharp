using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fingoti.Command
{
    public class UARTData : Command
    {
        public UARTData(UARTDataPayload payload)
        {
            Property = "uartData";
            Operation = CommandOperation.Write;
            Payload = payload;
        }
    }

    public class UARTDataPayload : IPayload
    {
        public UARTDataPayload() { }

        public UARTDataPayload(IEnumerable<int> data)
        {
            Data = data;
        }

        [MaxLength(1024)]
        public IEnumerable<int> Data { get; set; }
    }

    public partial class Builder
    {
        /// <summary>
        /// Adds a uartData write commmand to the builder
        /// </summary>
        /// <param name="data"></param>
        public void AddUARTData(IEnumerable<int> data)
        {
            var payload = new UARTDataPayload(data);

            Validate(payload);

            this.Request.Add(new UARTData(payload));
        }
    }
}
