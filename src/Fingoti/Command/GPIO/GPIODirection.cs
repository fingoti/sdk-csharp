using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fingoti.Command
{
    public enum Direction 
    {
        Output, 
        Input
    }

    public class GPIODirection : Command
    {
        public GPIODirection(CommandOperation operation, GPIODirectionPayload? payload)
        {
            Property = "gpioDirection";
            Operation = operation;
            Payload = payload;
        }

        public GPIODirection(CommandOperation operation, GPIOAllDirectionPayload? payload)
        {
            Property = "gpioDirection";
            Operation = operation;
            Payload = payload;
        }

        public GPIODirection(GPIOSaveDirectionPayload payload)
        {
            Property = "gpioDirection";
            Operation = CommandOperation.Write;
            Payload = payload;
        }

    }

    public class GPIODirectionPayload : IPayload
    {
        public GPIODirectionPayload() { }

        public GPIODirectionPayload(int gpio, Direction value, bool save)
        {
            GPIO = gpio;
            Value = value;
            Save = save;
        }

        [Range(1, 4)]
        public int GPIO { get; set; }
        public Direction Value { get; set; }
        public bool Save { get; set; }
    }

    public class GPIOAllDirectionPayload : IPayload
    {
        public GPIOAllDirectionPayload() { }

        public GPIOAllDirectionPayload(IEnumerable<Direction> direction, bool save)
        {
            Direction = direction;
            Save = save;
        }

        [MaxLength(4)]
        public IEnumerable<Direction> Direction { get; set; }
        public bool Save { get; set; }  
    }

    public class GPIOSaveDirectionPayload : IPayload
    {
        public GPIOSaveDirectionPayload() { }

        public GPIOSaveDirectionPayload(bool save)
        {
            Save = save;
        }

        public bool Save { get; set; }
    }

    public partial class Builder
    {
        /// <summary>
        /// Adds a gpioDirection read command to the builder
        /// </summary>
        public void AddGPIODirection()
        {
            this.Request.Add(new GPIODirection(CommandOperation.Read, null as GPIODirectionPayload));
        }

        /// <summary>
        /// Adds a gpioDirection write command to the builder
        /// <para>
        /// Use this function the set the direction of a single GPIO
        /// </para>
        /// </summary>
        /// <param name="gpio"></param>
        /// <param name="value"></param>
        /// <param name="save"></param>
        public void AddGPIODirection(int gpio, Direction value, bool save = false)
        {
            var payload = new GPIODirectionPayload(gpio, value, save);

            Validate(payload);

            this.Request.Add(new GPIODirection(CommandOperation.Write, payload));   
        }

        /// <summary>
        /// An alternative way to add a gpioDirection command to the builder
        /// <para>
        /// Use this function to set the direction of a single GPIO
        /// </para>
        /// </summary>
        /// <param name="operation"></param>
        /// <param name="payload"></param>
        public void AddGPIODirection(CommandOperation operation, GPIODirectionPayload payload = null)
        {
            Validate(payload);

            this.Request.Add(new GPIODirection(operation, payload));
        }

        /// <summary>
        /// Adds a gpioDirection write command to the builder
        /// <para>
        /// Use this function to set the direction of multiple GPIO in a single command
        /// </para>
        /// </summary>
        /// <param name="direction"></param>
        /// <param name="save"></param>
        public void AddGPIODirection(IEnumerable<Direction> direction, bool save = false)
        {
            var payload = new GPIOAllDirectionPayload(direction, save);

            Validate(payload);

            this.Request.Add(new GPIODirection(CommandOperation.Write, payload));
        }

        /// <summary>
        /// An alternative way to add a gpioDirection command to the builder
        /// <para>
        /// Use this function to set the direction of multiple GPIO in a single command
        /// </para>
        /// </summary>
        /// <param name="operation"></param>
        /// <param name="payload"></param>
        public void AddGPIODirection(CommandOperation operation, GPIOAllDirectionPayload payload = null)
        {
            Validate(payload);

            this.Request.Add(new GPIODirection(operation, payload));
        }

        /// <summary>
        /// Adds a gpioDirection write command to the builder
        /// <para>
        /// Use this function to maintain current GPIO direction and make that direction persistant over device restarts 
        /// </para>
        /// </summary>
        /// <param name="save"></param>
        public void AddGPIODirection(bool save)
        {
            var payload = new GPIOSaveDirectionPayload(save);

            Validate(payload);

            this.Request.Add(new GPIODirection(payload));
        }
    }
 }
