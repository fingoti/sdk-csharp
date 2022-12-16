using Fingoti.Api;
using Fingoti.Client;
using Fingoti.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace Fingoti.Command
{
    public partial class Builder
    {
        [JsonIgnore]
        private Configuration _configuration;
        public string Serial { get; set; }
        public bool Response { get; set; }
        public List<Command> Request { get; set; }

        /// <summary>
        /// The command builder provides and easy way to assemble messages to send to devices
        /// </summary>
        /// <param name="config"></param>
        /// <param name="serial"></param>
        /// <returns>A configured instance of the command builder</returns>
        public Builder(Configuration config, string serial)
        {
            _configuration = config;

            Serial = serial;
            Response = true;
            Request = new List<Command>();
        }

        /// <summary>
        /// Adds a command to the builders request list
        /// </summary>
        /// <param name="command"></param>
        public void Add(Command command)
        {
            this.Request.Add(command);
        }

        /// <summary>
        /// Log the current state of the builder to the console, useful for debugging
        /// </summary>
        public void Log()
        {

            _ = (JsonConvert.SerializeObject(new { Serial = this.Serial, Response = this.Response }));

            foreach (var command in this.Request)
            {
                Console.WriteLine(JsonConvert.SerializeObject(command));
            }
        }

        /// <summary>
        /// Send the assembled commands to the device
        /// </summary>
        /// <returns>The result of the requested commands or an error</returns>
        public MqttDeviceResponse Send()
        {
            ValidateRequest();

            var deviceApi = new DeviceApi(_configuration);

            var deviceRequest = new DeviceRequest(this.Response, this.Serial, this.Request.Cast<object>().ToList());

            return deviceApi.PostDeviceSendrequest(deviceRequest);
        }

        /// <summary>
        /// Send the assembled commands to the device asynchronously
        /// </summary>
        /// <returns>The task which when completed will contain the result of the requested commands or an error</returns>
        public async Task<MqttDeviceResponse> SendAsync()
        {
            ValidateRequest();

            var deviceApi = new DeviceApi(_configuration);

            var deviceRequest = new DeviceRequest()
            {
                Serial = this.Serial,
                Response = this.Response,
                Request = this.Request.Cast<object>().ToList()
            };

            return await deviceApi.PostDeviceSendrequestAsync(deviceRequest);
        }

        private void ValidateRequest()
        {
            if(this.Request.Count > 8)
            {
                throw new ApplicationException("Too many commands, maximum of 8 commands per request");
            }
        }

        private static void Validate<T>(T obj)
        {
            List<ValidationResult>results = new List<ValidationResult>();

            bool isValid = Validator.TryValidateObject(obj, new ValidationContext(obj), results, true);

            if(!isValid)
            {
                foreach(ValidationResult result in results)
                {
                    throw new CommandValidationException(result.ErrorMessage);
                }
            }
        }
    }

    public abstract class Command
    {
        public string? Property { get; set; }
        public CommandOperation Operation { get; set; }
        public IPayload? Payload { get; set; }
    }

    public interface ICommand
    {
        public string? Property { get; set; }
        public CommandOperation Operation { get; set; }
        public IPayload? Payload { get; set; }
    }

    public enum CommandOperation
    {
        Read,
        Write
    }

    public interface IPayload { }
}
