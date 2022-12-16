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
    /// EngineWebhookResponse
    /// </summary>
    [DataContract(Name = "EngineWebhookResponse")]
    public partial class EngineWebhookResponse : IEquatable<EngineWebhookResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EngineWebhookResponse" /> class.
        /// </summary>
        /// <param name="success">success.</param>
        /// <param name="pageNumber">pageNumber.</param>
        /// <param name="webhooks">webhooks.</param>
        public EngineWebhookResponse(bool success = default(bool), long pageNumber = default(long), List<EngineWebhookDto> webhooks = default(List<EngineWebhookDto>))
        {
            this.Success = success;
            this.PageNumber = pageNumber;
            this.Webhooks = webhooks;
        }

        /// <summary>
        /// Gets or Sets Success
        /// </summary>
        [DataMember(Name = "success", EmitDefaultValue = true)]
        public bool Success { get; set; }

        /// <summary>
        /// Gets or Sets PageNumber
        /// </summary>
        [DataMember(Name = "pageNumber", EmitDefaultValue = false)]
        public long PageNumber { get; set; }

        /// <summary>
        /// Gets or Sets Count
        /// </summary>
        [DataMember(Name = "count", EmitDefaultValue = false)]
        public long Count { get; private set; }

        /// <summary>
        /// Returns false as Count should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeCount()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets Webhooks
        /// </summary>
        [DataMember(Name = "webhooks", EmitDefaultValue = true)]
        public List<EngineWebhookDto> Webhooks { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class EngineWebhookResponse {\n");
            sb.Append("  Success: ").Append(Success).Append("\n");
            sb.Append("  PageNumber: ").Append(PageNumber).Append("\n");
            sb.Append("  Count: ").Append(Count).Append("\n");
            sb.Append("  Webhooks: ").Append(Webhooks).Append("\n");
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
            return this.Equals(input as EngineWebhookResponse);
        }

        /// <summary>
        /// Returns true if EngineWebhookResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of EngineWebhookResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EngineWebhookResponse input)
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
                    this.PageNumber == input.PageNumber ||
                    this.PageNumber.Equals(input.PageNumber)
                ) && 
                (
                    this.Count == input.Count ||
                    this.Count.Equals(input.Count)
                ) && 
                (
                    this.Webhooks == input.Webhooks ||
                    this.Webhooks != null &&
                    input.Webhooks != null &&
                    this.Webhooks.SequenceEqual(input.Webhooks)
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
                hashCode = (hashCode * 59) + this.PageNumber.GetHashCode();
                hashCode = (hashCode * 59) + this.Count.GetHashCode();
                if (this.Webhooks != null)
                {
                    hashCode = (hashCode * 59) + this.Webhooks.GetHashCode();
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
