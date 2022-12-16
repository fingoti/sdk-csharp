using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fingoti.Command
{
    public class GPIOPulse : Command
    {
        public GPIOPulse(GPIOPulsePayload payload)
        {
            Property = "gpioPulse";
            Operation = CommandOperation.Write;
            Payload = payload;
        }
    }

    public class GPIOPulsePayload : IPayload
    {
        public GPIOPulsePayload () { }

        public GPIOPulsePayload (int gpio, int duration)
        {
            GPIO = gpio;
            Duration = duration;
        }

        [Range(1, 4)]
        public int GPIO { get; set; }

        [Range(1, 30)]
        public int Duration { get; set; }
    }

    public partial class Builder
    { 
        /// <summary>
        /// Adds a gpioPulse write command to the builder
        /// </summary>
        /// <param name="gpio"></param>
        /// <param name="duration"></param>
        public void AddGPIOPulse(int gpio, int duration)
        {
            var payload = new GPIOPulsePayload(gpio, duration);

            Validate(payload);

            this.Request.Add(new GPIOPulse(payload));
        }

        /// <summary>
        /// An alternative way to add a gpioPulse write command to the builder 
        /// </summary>
        /// <param name="payload"></param>
        public void AddGPIOPulse(GPIOPulsePayload payload)
        {
            Validate(payload);

            this.Request.Add(new GPIOPulse(payload));
        }
    }
}
