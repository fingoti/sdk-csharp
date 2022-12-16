using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fingoti.Command
{
    public class GPIOToggle : Command
    {
        public GPIOToggle(GPIOTogglePayload payload)
        {
            Property = "gpioToggle";
            Operation = CommandOperation.Write;
            Payload = payload;
        }
    }

    public class GPIOTogglePayload : IPayload
    {
        public GPIOTogglePayload() { }

        public GPIOTogglePayload(int gpio)
        {
            GPIO = gpio;
        }

        [Range(1, 4)]
        public int GPIO { get; set; }
    }

    public partial class Builder
    {
        /// <summary>
        /// Adds a gpioToggle write command to the builder
        /// </summary>
        /// <param name="gpio"></param>
        public void AddGPIOToggle(int gpio)
        {
            var payload = new GPIOTogglePayload(gpio);

            Validate(payload);

            this.Request.Add(new GPIOToggle(payload));
        }

        /// <summary>
        /// An alternative way to add a gpioToggle command to the builder
        /// </summary>
        /// <param name="payload"></param>
        public void AddGPIOToggle(GPIOTogglePayload payload)
        {
            Validate(payload);

            this.Request.Add(new GPIOToggle(payload));
        }
    }

}
