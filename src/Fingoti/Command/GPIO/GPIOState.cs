using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fingoti.Command
{
    public enum State
    {
        Off,
        On
    }

    public class GPIOState : Command
    {
        public GPIOState(CommandOperation operation, GPIOStatePayload? payload) 
        {
            Property = "gpioState";
            Operation = operation;
            Payload = payload;
        }

        public GPIOState(CommandOperation operation, GPIOAllStatePayload? payload)
        {
            Property = "gpioState";
            Operation = operation;
            Payload = payload;
        }

        public GPIOState(GPIOSaveStatePayload payload)
        {
            Property = "gpioState";
            Operation = CommandOperation.Write;
            Payload = payload;
        }
    }

    public class GPIOStatePayload : IPayload
    {
        public GPIOStatePayload() { }

        public GPIOStatePayload(int gpio, State value, bool save)
        {
            GPIO = gpio;
            Value = value;
            Save = save;
        }

        [Range(1, 4)]
        public int GPIO { get; set; }
        public State Value { get; set; }
        public bool Save { get; set; }
    }

    public class GPIOAllStatePayload : IPayload
    {
        public GPIOAllStatePayload() { }

        public GPIOAllStatePayload(IEnumerable<State> state, bool save)
        {
            State = state;
            Save = save;
        }

        [MaxLength(4)]
        public IEnumerable<State> State { get; set; }
        public bool Save { get; set; }
    }

    public class GPIOSaveStatePayload : IPayload 
    {
        public GPIOSaveStatePayload() { }

        public GPIOSaveStatePayload (bool save)
        {
            Save = save;
        }

        public bool Save { get; set; }  
    }

    public partial class Builder
    {
        /// <summary>
        /// Adds a gpioState read command to the builder
        /// </summary>
        public void AddGPIOState()
        {
            this.Request.Add(new GPIOState(CommandOperation.Read, null as GPIOStatePayload));
        }

        /// <summary>
        /// Adds a gpioState write command to the builder
        /// <para>
        /// Use this fucntion to set the state of a single GPIO
        /// </para>
        /// </summary>
        /// <param name="gpio"></param>
        /// <param name="value"></param>
        /// <param name="save"></param>
        public void AddGPIOState(int gpio, State value, bool save = false)
        {
            var payload = new GPIOStatePayload(gpio, value, save);

            Validate(payload);

            this.Request.Add(new GPIOState(CommandOperation.Write, payload));
        }

        /// <summary>
        /// An alternative way to add a gpioState command to the builder
        /// <para>
        /// Use this function to set the state of a single GPIO
        /// </para>
        /// </summary>
        /// <param name="operation"></param>
        /// <param name="payload"></param>
        public void AddGPIOState(CommandOperation operation, GPIOStatePayload? payload = null)
        {
            Validate(payload);

            this.Request.Add(new GPIOState(operation, payload));
        }

        /// <summary>
        /// Adds a gpioState write command to the builder
        /// <para>
        /// Use this function to set the state of multiple GPIO in a single command
        /// </para>
        /// </summary>
        /// <param name="state"></param>
        /// <param name="save"></param>
        public void AddGPIOState(IEnumerable<State> state, bool save = false)
        {
            var payload = new GPIOAllStatePayload(state, save);

            Validate(payload);

            this.Request.Add(new GPIOState(CommandOperation.Write, payload));
        }

        /// <summary>
        /// An alternative way to add a gpioState command to the builder
        /// <para>
        /// Use this function to set the state of multiple GPIO in a single command
        /// </para>
        /// </summary>
        /// <param name="operation"></param>
        /// <param name="payload"></param>
        public void AddGPIOState(CommandOperation operation, GPIOAllStatePayload? payload = null)
        {
            Validate(payload);

            this.Request.Add(new GPIOState(operation, payload));
        }

        public void AddGPIOState(bool save)
        {
            var payload = new GPIOSaveStatePayload(save);

            Validate(payload);

            this.Request.Add(new GPIOState(payload));
        }
    }
}
