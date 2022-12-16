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
    /// DeviceCloud
    /// </summary>
    [DataContract(Name = "DeviceCloud")]
    public partial class DeviceCloud : IEquatable<DeviceCloud>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets Reason
        /// </summary>
        [DataMember(Name = "reason", EmitDefaultValue = false)]
        public CloudReason? Reason { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="DeviceCloud" /> class.
        /// </summary>
        /// <param name="enabled">enabled.</param>
        /// <param name="connected">connected.</param>
        /// <param name="reason">reason.</param>
        public DeviceCloud(bool enabled = default(bool), bool connected = default(bool), CloudReason? reason = default(CloudReason?))
        {
            this.Enabled = enabled;
            this.Connected = connected;
            this.Reason = reason;
        }

        /// <summary>
        /// Gets or Sets Enabled
        /// </summary>
        [DataMember(Name = "enabled", EmitDefaultValue = true)]
        public bool Enabled { get; set; }

        /// <summary>
        /// Gets or Sets Connected
        /// </summary>
        [DataMember(Name = "connected", EmitDefaultValue = true)]
        public bool Connected { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DeviceCloud {\n");
            sb.Append("  Enabled: ").Append(Enabled).Append("\n");
            sb.Append("  Connected: ").Append(Connected).Append("\n");
            sb.Append("  Reason: ").Append(Reason).Append("\n");
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
            return this.Equals(input as DeviceCloud);
        }

        /// <summary>
        /// Returns true if DeviceCloud instances are equal
        /// </summary>
        /// <param name="input">Instance of DeviceCloud to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DeviceCloud input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Enabled == input.Enabled ||
                    this.Enabled.Equals(input.Enabled)
                ) && 
                (
                    this.Connected == input.Connected ||
                    this.Connected.Equals(input.Connected)
                ) && 
                (
                    this.Reason == input.Reason ||
                    this.Reason.Equals(input.Reason)
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
                hashCode = (hashCode * 59) + this.Enabled.GetHashCode();
                hashCode = (hashCode * 59) + this.Connected.GetHashCode();
                hashCode = (hashCode * 59) + this.Reason.GetHashCode();
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