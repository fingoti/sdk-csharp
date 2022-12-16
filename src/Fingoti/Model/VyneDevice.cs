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
    /// VyneDevice
    /// </summary>
    [DataContract(Name = "VyneDevice")]
    public partial class VyneDevice : IEquatable<VyneDevice>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets Session
        /// </summary>
        [DataMember(Name = "session", EmitDefaultValue = false)]
        public DeviceSession? Session { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="VyneDevice" /> class.
        /// </summary>
        /// <param name="name">name.</param>
        /// <param name="key">key.</param>
        /// <param name="support">support.</param>
        /// <param name="cloud">cloud.</param>
        /// <param name="uptime">uptime.</param>
        /// <param name="activity">activity.</param>
        /// <param name="temperature">temperature.</param>
        /// <param name="brightness">brightness.</param>
        /// <param name="power">power.</param>
        /// <param name="session">session.</param>
        /// <param name="version">version.</param>
        /// <param name="location">location.</param>
        public VyneDevice(string name = default(string), string key = default(string), DeviceSupport support = default(DeviceSupport), DeviceCloud cloud = default(DeviceCloud), DeviceUptime uptime = default(DeviceUptime), bool activity = default(bool), int temperature = default(int), int brightness = default(int), DevicePower power = default(DevicePower), DeviceSession? session = default(DeviceSession?), DeviceVersion version = default(DeviceVersion), DeviceLocation location = default(DeviceLocation))
        {
            this.Name = name;
            this.Key = key;
            this.Support = support;
            this.Cloud = cloud;
            this.Uptime = uptime;
            this.Activity = activity;
            this.Temperature = temperature;
            this.Brightness = brightness;
            this.Power = power;
            this.Session = session;
            this._Version = version;
            this.Location = location;
        }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Key
        /// </summary>
        [DataMember(Name = "key", EmitDefaultValue = true)]
        public string Key { get; set; }

        /// <summary>
        /// Gets or Sets Support
        /// </summary>
        [DataMember(Name = "support", EmitDefaultValue = false)]
        public DeviceSupport Support { get; set; }

        /// <summary>
        /// Gets or Sets Cloud
        /// </summary>
        [DataMember(Name = "cloud", EmitDefaultValue = false)]
        public DeviceCloud Cloud { get; set; }

        /// <summary>
        /// Gets or Sets Uptime
        /// </summary>
        [DataMember(Name = "uptime", EmitDefaultValue = false)]
        public DeviceUptime Uptime { get; set; }

        /// <summary>
        /// Gets or Sets Activity
        /// </summary>
        [DataMember(Name = "activity", EmitDefaultValue = true)]
        public bool Activity { get; set; }

        /// <summary>
        /// Gets or Sets Temperature
        /// </summary>
        [DataMember(Name = "temperature", EmitDefaultValue = false)]
        public int Temperature { get; set; }

        /// <summary>
        /// Gets or Sets Brightness
        /// </summary>
        [DataMember(Name = "brightness", EmitDefaultValue = false)]
        public int Brightness { get; set; }

        /// <summary>
        /// Gets or Sets Power
        /// </summary>
        [DataMember(Name = "power", EmitDefaultValue = false)]
        public DevicePower Power { get; set; }

        /// <summary>
        /// Gets or Sets _Version
        /// </summary>
        [DataMember(Name = "version", EmitDefaultValue = false)]
        public DeviceVersion _Version { get; set; }

        /// <summary>
        /// Gets or Sets Location
        /// </summary>
        [DataMember(Name = "location", EmitDefaultValue = false)]
        public DeviceLocation Location { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class VyneDevice {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Key: ").Append(Key).Append("\n");
            sb.Append("  Support: ").Append(Support).Append("\n");
            sb.Append("  Cloud: ").Append(Cloud).Append("\n");
            sb.Append("  Uptime: ").Append(Uptime).Append("\n");
            sb.Append("  Activity: ").Append(Activity).Append("\n");
            sb.Append("  Temperature: ").Append(Temperature).Append("\n");
            sb.Append("  Brightness: ").Append(Brightness).Append("\n");
            sb.Append("  Power: ").Append(Power).Append("\n");
            sb.Append("  Session: ").Append(Session).Append("\n");
            sb.Append("  _Version: ").Append(_Version).Append("\n");
            sb.Append("  Location: ").Append(Location).Append("\n");
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
            return this.Equals(input as VyneDevice);
        }

        /// <summary>
        /// Returns true if VyneDevice instances are equal
        /// </summary>
        /// <param name="input">Instance of VyneDevice to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(VyneDevice input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Key == input.Key ||
                    (this.Key != null &&
                    this.Key.Equals(input.Key))
                ) && 
                (
                    this.Support == input.Support ||
                    (this.Support != null &&
                    this.Support.Equals(input.Support))
                ) && 
                (
                    this.Cloud == input.Cloud ||
                    (this.Cloud != null &&
                    this.Cloud.Equals(input.Cloud))
                ) && 
                (
                    this.Uptime == input.Uptime ||
                    (this.Uptime != null &&
                    this.Uptime.Equals(input.Uptime))
                ) && 
                (
                    this.Activity == input.Activity ||
                    this.Activity.Equals(input.Activity)
                ) && 
                (
                    this.Temperature == input.Temperature ||
                    this.Temperature.Equals(input.Temperature)
                ) && 
                (
                    this.Brightness == input.Brightness ||
                    this.Brightness.Equals(input.Brightness)
                ) && 
                (
                    this.Power == input.Power ||
                    (this.Power != null &&
                    this.Power.Equals(input.Power))
                ) && 
                (
                    this.Session == input.Session ||
                    this.Session.Equals(input.Session)
                ) && 
                (
                    this._Version == input._Version ||
                    (this._Version != null &&
                    this._Version.Equals(input._Version))
                ) && 
                (
                    this.Location == input.Location ||
                    (this.Location != null &&
                    this.Location.Equals(input.Location))
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
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                if (this.Key != null)
                {
                    hashCode = (hashCode * 59) + this.Key.GetHashCode();
                }
                if (this.Support != null)
                {
                    hashCode = (hashCode * 59) + this.Support.GetHashCode();
                }
                if (this.Cloud != null)
                {
                    hashCode = (hashCode * 59) + this.Cloud.GetHashCode();
                }
                if (this.Uptime != null)
                {
                    hashCode = (hashCode * 59) + this.Uptime.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Activity.GetHashCode();
                hashCode = (hashCode * 59) + this.Temperature.GetHashCode();
                hashCode = (hashCode * 59) + this.Brightness.GetHashCode();
                if (this.Power != null)
                {
                    hashCode = (hashCode * 59) + this.Power.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Session.GetHashCode();
                if (this._Version != null)
                {
                    hashCode = (hashCode * 59) + this._Version.GetHashCode();
                }
                if (this.Location != null)
                {
                    hashCode = (hashCode * 59) + this.Location.GetHashCode();
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