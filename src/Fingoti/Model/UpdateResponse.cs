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
    /// UpdateResponse
    /// </summary>
    [DataContract(Name = "UpdateResponse")]
    public partial class UpdateResponse : IEquatable<UpdateResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateResponse" /> class.
        /// </summary>
        /// <param name="success">success.</param>
        /// <param name="message">message.</param>
        /// <param name="successfulDevices">successfulDevices.</param>
        /// <param name="failedDevices">failedDevices.</param>
        public UpdateResponse(bool success = default(bool), string message = default(string), List<string> successfulDevices = default(List<string>), List<string> failedDevices = default(List<string>))
        {
            this.Success = success;
            this.Message = message;
            this.SuccessfulDevices = successfulDevices;
            this.FailedDevices = failedDevices;
        }

        /// <summary>
        /// Gets or Sets Success
        /// </summary>
        [DataMember(Name = "success", EmitDefaultValue = true)]
        public bool Success { get; set; }

        /// <summary>
        /// Gets or Sets Message
        /// </summary>
        [DataMember(Name = "message", EmitDefaultValue = true)]
        public string Message { get; set; }

        /// <summary>
        /// Gets or Sets SuccessfulDevices
        /// </summary>
        [DataMember(Name = "successfulDevices", EmitDefaultValue = true)]
        public List<string> SuccessfulDevices { get; set; }

        /// <summary>
        /// Gets or Sets FailedDevices
        /// </summary>
        [DataMember(Name = "failedDevices", EmitDefaultValue = true)]
        public List<string> FailedDevices { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class UpdateResponse {\n");
            sb.Append("  Success: ").Append(Success).Append("\n");
            sb.Append("  Message: ").Append(Message).Append("\n");
            sb.Append("  SuccessfulDevices: ").Append(SuccessfulDevices).Append("\n");
            sb.Append("  FailedDevices: ").Append(FailedDevices).Append("\n");
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
            return this.Equals(input as UpdateResponse);
        }

        /// <summary>
        /// Returns true if UpdateResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of UpdateResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UpdateResponse input)
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
                    this.Message == input.Message ||
                    (this.Message != null &&
                    this.Message.Equals(input.Message))
                ) && 
                (
                    this.SuccessfulDevices == input.SuccessfulDevices ||
                    this.SuccessfulDevices != null &&
                    input.SuccessfulDevices != null &&
                    this.SuccessfulDevices.SequenceEqual(input.SuccessfulDevices)
                ) && 
                (
                    this.FailedDevices == input.FailedDevices ||
                    this.FailedDevices != null &&
                    input.FailedDevices != null &&
                    this.FailedDevices.SequenceEqual(input.FailedDevices)
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
                if (this.Message != null)
                {
                    hashCode = (hashCode * 59) + this.Message.GetHashCode();
                }
                if (this.SuccessfulDevices != null)
                {
                    hashCode = (hashCode * 59) + this.SuccessfulDevices.GetHashCode();
                }
                if (this.FailedDevices != null)
                {
                    hashCode = (hashCode * 59) + this.FailedDevices.GetHashCode();
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
