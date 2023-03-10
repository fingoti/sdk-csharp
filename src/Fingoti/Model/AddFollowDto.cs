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
    /// AddFollowDto
    /// </summary>
    [DataContract(Name = "AddFollowDto")]
    public partial class AddFollowDto : IEquatable<AddFollowDto>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AddFollowDto" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AddFollowDto() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AddFollowDto" /> class.
        /// </summary>
        /// <param name="disabled">disabled.</param>
        /// <param name="followName">followName (required).</param>
        /// <param name="sourceDevice">sourceDevice (required).</param>
        /// <param name="sourcePin">sourcePin (required).</param>
        /// <param name="destinationDevice">destinationDevice (required).</param>
        /// <param name="destinationPin">destinationPin (required).</param>
        /// <param name="mirror">mirror.</param>
        public AddFollowDto(bool disabled = default(bool), string followName = default(string), string sourceDevice = default(string), int sourcePin = default(int), string destinationDevice = default(string), int destinationPin = default(int), bool mirror = default(bool))
        {
            // to ensure "followName" is required (not null)
            if (followName == null)
            {
                throw new ArgumentNullException("followName is a required property for AddFollowDto and cannot be null");
            }
            this.FollowName = followName;
            // to ensure "sourceDevice" is required (not null)
            if (sourceDevice == null)
            {
                throw new ArgumentNullException("sourceDevice is a required property for AddFollowDto and cannot be null");
            }
            this.SourceDevice = sourceDevice;
            this.SourcePin = sourcePin;
            // to ensure "destinationDevice" is required (not null)
            if (destinationDevice == null)
            {
                throw new ArgumentNullException("destinationDevice is a required property for AddFollowDto and cannot be null");
            }
            this.DestinationDevice = destinationDevice;
            this.DestinationPin = destinationPin;
            this.Disabled = disabled;
            this.Mirror = mirror;
        }

        /// <summary>
        /// Gets or Sets Disabled
        /// </summary>
        [DataMember(Name = "disabled", EmitDefaultValue = true)]
        public bool Disabled { get; set; }

        /// <summary>
        /// Gets or Sets FollowName
        /// </summary>
        [DataMember(Name = "followName", IsRequired = true, EmitDefaultValue = true)]
        public string FollowName { get; set; }

        /// <summary>
        /// Gets or Sets SourceDevice
        /// </summary>
        [DataMember(Name = "sourceDevice", IsRequired = true, EmitDefaultValue = true)]
        public string SourceDevice { get; set; }

        /// <summary>
        /// Gets or Sets SourcePin
        /// </summary>
        [DataMember(Name = "sourcePin", IsRequired = true, EmitDefaultValue = true)]
        public int SourcePin { get; set; }

        /// <summary>
        /// Gets or Sets DestinationDevice
        /// </summary>
        [DataMember(Name = "destinationDevice", IsRequired = true, EmitDefaultValue = true)]
        public string DestinationDevice { get; set; }

        /// <summary>
        /// Gets or Sets DestinationPin
        /// </summary>
        [DataMember(Name = "destinationPin", IsRequired = true, EmitDefaultValue = true)]
        public int DestinationPin { get; set; }

        /// <summary>
        /// Gets or Sets Mirror
        /// </summary>
        [DataMember(Name = "mirror", EmitDefaultValue = true)]
        public bool Mirror { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AddFollowDto {\n");
            sb.Append("  Disabled: ").Append(Disabled).Append("\n");
            sb.Append("  FollowName: ").Append(FollowName).Append("\n");
            sb.Append("  SourceDevice: ").Append(SourceDevice).Append("\n");
            sb.Append("  SourcePin: ").Append(SourcePin).Append("\n");
            sb.Append("  DestinationDevice: ").Append(DestinationDevice).Append("\n");
            sb.Append("  DestinationPin: ").Append(DestinationPin).Append("\n");
            sb.Append("  Mirror: ").Append(Mirror).Append("\n");
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
            return this.Equals(input as AddFollowDto);
        }

        /// <summary>
        /// Returns true if AddFollowDto instances are equal
        /// </summary>
        /// <param name="input">Instance of AddFollowDto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AddFollowDto input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Disabled == input.Disabled ||
                    this.Disabled.Equals(input.Disabled)
                ) && 
                (
                    this.FollowName == input.FollowName ||
                    (this.FollowName != null &&
                    this.FollowName.Equals(input.FollowName))
                ) && 
                (
                    this.SourceDevice == input.SourceDevice ||
                    (this.SourceDevice != null &&
                    this.SourceDevice.Equals(input.SourceDevice))
                ) && 
                (
                    this.SourcePin == input.SourcePin ||
                    this.SourcePin.Equals(input.SourcePin)
                ) && 
                (
                    this.DestinationDevice == input.DestinationDevice ||
                    (this.DestinationDevice != null &&
                    this.DestinationDevice.Equals(input.DestinationDevice))
                ) && 
                (
                    this.DestinationPin == input.DestinationPin ||
                    this.DestinationPin.Equals(input.DestinationPin)
                ) && 
                (
                    this.Mirror == input.Mirror ||
                    this.Mirror.Equals(input.Mirror)
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
                hashCode = (hashCode * 59) + this.Disabled.GetHashCode();
                if (this.FollowName != null)
                {
                    hashCode = (hashCode * 59) + this.FollowName.GetHashCode();
                }
                if (this.SourceDevice != null)
                {
                    hashCode = (hashCode * 59) + this.SourceDevice.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.SourcePin.GetHashCode();
                if (this.DestinationDevice != null)
                {
                    hashCode = (hashCode * 59) + this.DestinationDevice.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.DestinationPin.GetHashCode();
                hashCode = (hashCode * 59) + this.Mirror.GetHashCode();
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
