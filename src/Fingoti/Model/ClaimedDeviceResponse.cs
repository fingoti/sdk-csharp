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
    /// ClaimedDeviceResponse
    /// </summary>
    [DataContract(Name = "ClaimedDeviceResponse")]
    public partial class ClaimedDeviceResponse : IEquatable<ClaimedDeviceResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ClaimedDeviceResponse" /> class.
        /// </summary>
        /// <param name="success">success.</param>
        /// <param name="pebl">pebl.</param>
        /// <param name="vyne">vyne.</param>
        public ClaimedDeviceResponse(bool success = default(bool), DevicePeblDto pebl = default(DevicePeblDto), DeviceVyneDto vyne = default(DeviceVyneDto))
        {
            this.Success = success;
            this.Pebl = pebl;
            this.Vyne = vyne;
        }

        /// <summary>
        /// Gets or Sets Success
        /// </summary>
        [DataMember(Name = "success", EmitDefaultValue = true)]
        public bool Success { get; set; }

        /// <summary>
        /// Gets or Sets Pebl
        /// </summary>
        [DataMember(Name = "pebl", EmitDefaultValue = false)]
        public DevicePeblDto Pebl { get; set; }

        /// <summary>
        /// Gets or Sets Vyne
        /// </summary>
        [DataMember(Name = "vyne", EmitDefaultValue = false)]
        public DeviceVyneDto Vyne { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ClaimedDeviceResponse {\n");
            sb.Append("  Success: ").Append(Success).Append("\n");
            sb.Append("  Pebl: ").Append(Pebl).Append("\n");
            sb.Append("  Vyne: ").Append(Vyne).Append("\n");
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
            return this.Equals(input as ClaimedDeviceResponse);
        }

        /// <summary>
        /// Returns true if ClaimedDeviceResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of ClaimedDeviceResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ClaimedDeviceResponse input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Success == input.Success ||
                    this.Success.Equals(input.Success)
                ) && 
                (
                    this.Pebl == input.Pebl ||
                    (this.Pebl != null &&
                    this.Pebl.Equals(input.Pebl))
                ) && 
                (
                    this.Vyne == input.Vyne ||
                    (this.Vyne != null &&
                    this.Vyne.Equals(input.Vyne))
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
                hashCode = (hashCode * 59) + this.Success.GetHashCode();
                if (this.Pebl != null)
                {
                    hashCode = (hashCode * 59) + this.Pebl.GetHashCode();
                }
                if (this.Vyne != null)
                {
                    hashCode = (hashCode * 59) + this.Vyne.GetHashCode();
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
