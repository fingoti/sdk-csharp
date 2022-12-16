/*
 * Fingoti API
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: v1
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Fingoti.Client.OpenAPIDateConverter;

namespace Fingoti.Model
{
    /// <summary>
    /// VyneGateway
    /// </summary>
    [DataContract(Name = "VyneGateway")]
    public partial class VyneGateway : IEquatable<VyneGateway>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VyneGateway" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="partNumber">partNumber.</param>
        /// <param name="systemOs">systemOs.</param>
        /// <param name="systemVersion">systemVersion.</param>
        /// <param name="lastUpdated">lastUpdated.</param>
        /// <param name="lastMessage">lastMessage.</param>
        /// <param name="claim">claim.</param>
        /// <param name="gpio">gpio.</param>
        /// <param name="timer">timer.</param>
        /// <param name="wifi">wifi.</param>
        /// <param name="mqtt">mqtt.</param>
        /// <param name="network">network.</param>
        /// <param name="schedule">schedule.</param>
        /// <param name="device">device.</param>
        /// <param name="node">node.</param>
        public VyneGateway(string id = default(string), string partNumber = default(string), string systemOs = default(string), string systemVersion = default(string), DateTime? lastUpdated = default(DateTime?), AzureMessage lastMessage = default(AzureMessage), GatewayClaim claim = default(GatewayClaim), GatewayGpio gpio = default(GatewayGpio), GatewayTimer timer = default(GatewayTimer), GatewayWifi wifi = default(GatewayWifi), GatewayMqtt mqtt = default(GatewayMqtt), GatewayNetwork network = default(GatewayNetwork), GatewaySchedule schedule = default(GatewaySchedule), VyneDevice device = default(VyneDevice), GatewayNode node = default(GatewayNode))
        {
            this.Id = id;
            this.PartNumber = partNumber;
            this.SystemOs = systemOs;
            this.SystemVersion = systemVersion;
            this.LastUpdated = lastUpdated;
            this.LastMessage = lastMessage;
            this.Claim = claim;
            this.Gpio = gpio;
            this.Timer = timer;
            this.Wifi = wifi;
            this.Mqtt = mqtt;
            this.Network = network;
            this.Schedule = schedule;
            this.Device = device;
            this.Node = node;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = true)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets PartNumber
        /// </summary>
        [DataMember(Name = "partNumber", EmitDefaultValue = true)]
        public string PartNumber { get; set; }

        /// <summary>
        /// Gets or Sets SystemOs
        /// </summary>
        [DataMember(Name = "systemOs", EmitDefaultValue = true)]
        public string SystemOs { get; set; }

        /// <summary>
        /// Gets or Sets SystemVersion
        /// </summary>
        [DataMember(Name = "systemVersion", EmitDefaultValue = true)]
        public string SystemVersion { get; set; }

        /// <summary>
        /// Gets or Sets LastUpdated
        /// </summary>
        [DataMember(Name = "lastUpdated", EmitDefaultValue = true)]
        public DateTime? LastUpdated { get; set; }

        /// <summary>
        /// Gets or Sets LastMessage
        /// </summary>
        [DataMember(Name = "lastMessage", EmitDefaultValue = false)]
        public AzureMessage LastMessage { get; set; }

        /// <summary>
        /// Gets or Sets Claim
        /// </summary>
        [DataMember(Name = "claim", EmitDefaultValue = false)]
        public GatewayClaim Claim { get; set; }

        /// <summary>
        /// Gets or Sets Gpio
        /// </summary>
        [DataMember(Name = "gpio", EmitDefaultValue = false)]
        public GatewayGpio Gpio { get; set; }

        /// <summary>
        /// Gets or Sets Timer
        /// </summary>
        [DataMember(Name = "timer", EmitDefaultValue = false)]
        public GatewayTimer Timer { get; set; }

        /// <summary>
        /// Gets or Sets Wifi
        /// </summary>
        [DataMember(Name = "wifi", EmitDefaultValue = false)]
        public GatewayWifi Wifi { get; set; }

        /// <summary>
        /// Gets or Sets Mqtt
        /// </summary>
        [DataMember(Name = "mqtt", EmitDefaultValue = false)]
        public GatewayMqtt Mqtt { get; set; }

        /// <summary>
        /// Gets or Sets Network
        /// </summary>
        [DataMember(Name = "network", EmitDefaultValue = false)]
        public GatewayNetwork Network { get; set; }

        /// <summary>
        /// Gets or Sets Schedule
        /// </summary>
        [DataMember(Name = "schedule", EmitDefaultValue = false)]
        public GatewaySchedule Schedule { get; set; }

        /// <summary>
        /// Gets or Sets Device
        /// </summary>
        [DataMember(Name = "device", EmitDefaultValue = false)]
        public VyneDevice Device { get; set; }

        /// <summary>
        /// Gets or Sets Node
        /// </summary>
        [DataMember(Name = "node", EmitDefaultValue = false)]
        public GatewayNode Node { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class VyneGateway {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  PartNumber: ").Append(PartNumber).Append("\n");
            sb.Append("  SystemOs: ").Append(SystemOs).Append("\n");
            sb.Append("  SystemVersion: ").Append(SystemVersion).Append("\n");
            sb.Append("  LastUpdated: ").Append(LastUpdated).Append("\n");
            sb.Append("  LastMessage: ").Append(LastMessage).Append("\n");
            sb.Append("  Claim: ").Append(Claim).Append("\n");
            sb.Append("  Gpio: ").Append(Gpio).Append("\n");
            sb.Append("  Timer: ").Append(Timer).Append("\n");
            sb.Append("  Wifi: ").Append(Wifi).Append("\n");
            sb.Append("  Mqtt: ").Append(Mqtt).Append("\n");
            sb.Append("  Network: ").Append(Network).Append("\n");
            sb.Append("  Schedule: ").Append(Schedule).Append("\n");
            sb.Append("  Device: ").Append(Device).Append("\n");
            sb.Append("  Node: ").Append(Node).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as VyneGateway);
        }

        /// <summary>
        /// Returns true if VyneGateway instances are equal
        /// </summary>
        /// <param name="input">Instance of VyneGateway to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(VyneGateway input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.PartNumber == input.PartNumber ||
                    (this.PartNumber != null &&
                    this.PartNumber.Equals(input.PartNumber))
                ) && 
                (
                    this.SystemOs == input.SystemOs ||
                    (this.SystemOs != null &&
                    this.SystemOs.Equals(input.SystemOs))
                ) && 
                (
                    this.SystemVersion == input.SystemVersion ||
                    (this.SystemVersion != null &&
                    this.SystemVersion.Equals(input.SystemVersion))
                ) && 
                (
                    this.LastUpdated == input.LastUpdated ||
                    (this.LastUpdated != null &&
                    this.LastUpdated.Equals(input.LastUpdated))
                ) && 
                (
                    this.LastMessage == input.LastMessage ||
                    (this.LastMessage != null &&
                    this.LastMessage.Equals(input.LastMessage))
                ) && 
                (
                    this.Claim == input.Claim ||
                    (this.Claim != null &&
                    this.Claim.Equals(input.Claim))
                ) && 
                (
                    this.Gpio == input.Gpio ||
                    (this.Gpio != null &&
                    this.Gpio.Equals(input.Gpio))
                ) && 
                (
                    this.Timer == input.Timer ||
                    (this.Timer != null &&
                    this.Timer.Equals(input.Timer))
                ) && 
                (
                    this.Wifi == input.Wifi ||
                    (this.Wifi != null &&
                    this.Wifi.Equals(input.Wifi))
                ) && 
                (
                    this.Mqtt == input.Mqtt ||
                    (this.Mqtt != null &&
                    this.Mqtt.Equals(input.Mqtt))
                ) && 
                (
                    this.Network == input.Network ||
                    (this.Network != null &&
                    this.Network.Equals(input.Network))
                ) && 
                (
                    this.Schedule == input.Schedule ||
                    (this.Schedule != null &&
                    this.Schedule.Equals(input.Schedule))
                ) && 
                (
                    this.Device == input.Device ||
                    (this.Device != null &&
                    this.Device.Equals(input.Device))
                ) && 
                (
                    this.Node == input.Node ||
                    (this.Node != null &&
                    this.Node.Equals(input.Node))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.Id != null)
                {
                    hashCode = (hashCode * 59) + this.Id.GetHashCode();
                }
                if (this.PartNumber != null)
                {
                    hashCode = (hashCode * 59) + this.PartNumber.GetHashCode();
                }
                if (this.SystemOs != null)
                {
                    hashCode = (hashCode * 59) + this.SystemOs.GetHashCode();
                }
                if (this.SystemVersion != null)
                {
                    hashCode = (hashCode * 59) + this.SystemVersion.GetHashCode();
                }
                if (this.LastUpdated != null)
                {
                    hashCode = (hashCode * 59) + this.LastUpdated.GetHashCode();
                }
                if (this.LastMessage != null)
                {
                    hashCode = (hashCode * 59) + this.LastMessage.GetHashCode();
                }
                if (this.Claim != null)
                {
                    hashCode = (hashCode * 59) + this.Claim.GetHashCode();
                }
                if (this.Gpio != null)
                {
                    hashCode = (hashCode * 59) + this.Gpio.GetHashCode();
                }
                if (this.Timer != null)
                {
                    hashCode = (hashCode * 59) + this.Timer.GetHashCode();
                }
                if (this.Wifi != null)
                {
                    hashCode = (hashCode * 59) + this.Wifi.GetHashCode();
                }
                if (this.Mqtt != null)
                {
                    hashCode = (hashCode * 59) + this.Mqtt.GetHashCode();
                }
                if (this.Network != null)
                {
                    hashCode = (hashCode * 59) + this.Network.GetHashCode();
                }
                if (this.Schedule != null)
                {
                    hashCode = (hashCode * 59) + this.Schedule.GetHashCode();
                }
                if (this.Device != null)
                {
                    hashCode = (hashCode * 59) + this.Device.GetHashCode();
                }
                if (this.Node != null)
                {
                    hashCode = (hashCode * 59) + this.Node.GetHashCode();
                }
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        public IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}