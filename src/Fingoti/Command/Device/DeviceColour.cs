using System.Collections.Generic;

namespace Fingoti.Command
{
    public class DeviceColour : Command
    {
        public DeviceColour(CommandOperation operation, DeviceColourPayload? payload)
        {
            Property = "deviceColour";
            Operation = operation;
            Payload = payload;
        }
    }

    public class DeviceColourPayload : IPayload
    {
        public DeviceColourPayload() { }

        public DeviceColourPayload(int r, int g, int b)
        {
            Colour = new List<int>() { r, g, b };
        }

        public List<int> Colour { get; set; }
    }

    public partial class Builder
    {
        /// <summary>
        /// Adds a deviceColour read command to the builder
        /// </summary>
        public void AddDeviceColour()
        {
            this.Request.Add(new DeviceColour(CommandOperation.Read, null));
        }

        /// <summary>
        /// Adds a deviceColour write command to the builder
        /// </summary>
        /// <param name="r"></param>
        /// <param name="g"></param>
        /// <param name="b"></param>
        public void AddDeviceColour(int r, int g, int b)
        {
            this.Request.Add(new DeviceColour(CommandOperation.Write, new DeviceColourPayload(r, g, b)));
        }

        /// <summary>
        /// An alternative way to add a deviceColour command to the builder
        /// </summary>
        /// <param name="operation"></param>
        /// <param name="payload"></param>
        public void AddDeviceColour(CommandOperation operation, DeviceColourPayload? payload = null)
        {
            this.Request.Add(new DeviceColour(operation, payload));
        }
    }
}
