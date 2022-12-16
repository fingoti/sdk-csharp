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
    /// EngineWebhookDto
    /// </summary>
    [DataContract(Name = "EngineWebhookDto")]
    public partial class EngineWebhookDto : IEquatable<EngineWebhookDto>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EngineWebhookDto" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="organisationId">organisationId.</param>
        /// <param name="disabled">disabled.</param>
        /// <param name="webhookNumber">webhookNumber.</param>
        /// <param name="createdBy">createdBy.</param>
        /// <param name="createdOn">createdOn.</param>
        /// <param name="triggers">triggers.</param>
        /// <param name="properties">properties.</param>
        /// <param name="webhookUrl">webhookUrl.</param>
        /// <param name="webhookHeaders">webhookHeaders.</param>
        /// <param name="devices">devices.</param>
        /// <param name="count">count.</param>
        /// <param name="pageNumber">pageNumber.</param>
        /// <param name="lastCall">lastCall.</param>
        /// <param name="calls">calls.</param>
        public EngineWebhookDto(Guid id = default(Guid), Guid organisationId = default(Guid), bool disabled = default(bool), string webhookNumber = default(string), Guid createdBy = default(Guid), DateTime createdOn = default(DateTime), int triggers = default(int), List<string> properties = default(List<string>), string webhookUrl = default(string), List<WebhookHeaders> webhookHeaders = default(List<WebhookHeaders>), List<string> devices = default(List<string>), long count = default(long), long pageNumber = default(long), DateTime? lastCall = default(DateTime?), List<WebhookCallDto> calls = default(List<WebhookCallDto>))
        {
            this.Id = id;
            this.OrganisationId = organisationId;
            this.Disabled = disabled;
            this.WebhookNumber = webhookNumber;
            this.CreatedBy = createdBy;
            this.CreatedOn = createdOn;
            this.Triggers = triggers;
            this.Properties = properties;
            this.WebhookUrl = webhookUrl;
            this.WebhookHeaders = webhookHeaders;
            this.Devices = devices;
            this.Count = count;
            this.PageNumber = pageNumber;
            this.LastCall = lastCall;
            this.Calls = calls;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public Guid Id { get; set; }

        /// <summary>
        /// Gets or Sets OrganisationId
        /// </summary>
        [DataMember(Name = "organisationId", EmitDefaultValue = false)]
        public Guid OrganisationId { get; set; }

        /// <summary>
        /// Gets or Sets Disabled
        /// </summary>
        [DataMember(Name = "disabled", EmitDefaultValue = true)]
        public bool Disabled { get; set; }

        /// <summary>
        /// Gets or Sets WebhookNumber
        /// </summary>
        [DataMember(Name = "webhookNumber", EmitDefaultValue = true)]
        public string WebhookNumber { get; set; }

        /// <summary>
        /// Gets or Sets CreatedBy
        /// </summary>
        [DataMember(Name = "createdBy", EmitDefaultValue = false)]
        public Guid CreatedBy { get; set; }

        /// <summary>
        /// Gets or Sets CreatedOn
        /// </summary>
        [DataMember(Name = "createdOn", EmitDefaultValue = false)]
        public DateTime CreatedOn { get; set; }

        /// <summary>
        /// Gets or Sets Triggers
        /// </summary>
        [DataMember(Name = "triggers", EmitDefaultValue = false)]
        public int Triggers { get; set; }

        /// <summary>
        /// Gets or Sets Properties
        /// </summary>
        [DataMember(Name = "properties", EmitDefaultValue = true)]
        public List<string> Properties { get; set; }

        /// <summary>
        /// Gets or Sets WebhookUrl
        /// </summary>
        [DataMember(Name = "webhookUrl", EmitDefaultValue = true)]
        public string WebhookUrl { get; set; }

        /// <summary>
        /// Gets or Sets WebhookHeaders
        /// </summary>
        [DataMember(Name = "webhookHeaders", EmitDefaultValue = true)]
        public List<WebhookHeaders> WebhookHeaders { get; set; }

        /// <summary>
        /// Gets or Sets Devices
        /// </summary>
        [DataMember(Name = "devices", EmitDefaultValue = true)]
        public List<string> Devices { get; set; }

        /// <summary>
        /// Gets or Sets Count
        /// </summary>
        [DataMember(Name = "count", EmitDefaultValue = false)]
        public long Count { get; set; }

        /// <summary>
        /// Gets or Sets PageNumber
        /// </summary>
        [DataMember(Name = "pageNumber", EmitDefaultValue = false)]
        public long PageNumber { get; set; }

        /// <summary>
        /// Gets or Sets LastCall
        /// </summary>
        [DataMember(Name = "lastCall", EmitDefaultValue = true)]
        public DateTime? LastCall { get; set; }

        /// <summary>
        /// Gets or Sets Calls
        /// </summary>
        [DataMember(Name = "calls", EmitDefaultValue = true)]
        public List<WebhookCallDto> Calls { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class EngineWebhookDto {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  OrganisationId: ").Append(OrganisationId).Append("\n");
            sb.Append("  Disabled: ").Append(Disabled).Append("\n");
            sb.Append("  WebhookNumber: ").Append(WebhookNumber).Append("\n");
            sb.Append("  CreatedBy: ").Append(CreatedBy).Append("\n");
            sb.Append("  CreatedOn: ").Append(CreatedOn).Append("\n");
            sb.Append("  Triggers: ").Append(Triggers).Append("\n");
            sb.Append("  Properties: ").Append(Properties).Append("\n");
            sb.Append("  WebhookUrl: ").Append(WebhookUrl).Append("\n");
            sb.Append("  WebhookHeaders: ").Append(WebhookHeaders).Append("\n");
            sb.Append("  Devices: ").Append(Devices).Append("\n");
            sb.Append("  Count: ").Append(Count).Append("\n");
            sb.Append("  PageNumber: ").Append(PageNumber).Append("\n");
            sb.Append("  LastCall: ").Append(LastCall).Append("\n");
            sb.Append("  Calls: ").Append(Calls).Append("\n");
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
            return this.Equals(input as EngineWebhookDto);
        }

        /// <summary>
        /// Returns true if EngineWebhookDto instances are equal
        /// </summary>
        /// <param name="input">Instance of EngineWebhookDto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EngineWebhookDto input)
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
                    this.OrganisationId == input.OrganisationId ||
                    (this.OrganisationId != null &&
                    this.OrganisationId.Equals(input.OrganisationId))
                ) && 
                (
                    this.Disabled == input.Disabled ||
                    this.Disabled.Equals(input.Disabled)
                ) && 
                (
                    this.WebhookNumber == input.WebhookNumber ||
                    (this.WebhookNumber != null &&
                    this.WebhookNumber.Equals(input.WebhookNumber))
                ) && 
                (
                    this.CreatedBy == input.CreatedBy ||
                    (this.CreatedBy != null &&
                    this.CreatedBy.Equals(input.CreatedBy))
                ) && 
                (
                    this.CreatedOn == input.CreatedOn ||
                    (this.CreatedOn != null &&
                    this.CreatedOn.Equals(input.CreatedOn))
                ) && 
                (
                    this.Triggers == input.Triggers ||
                    this.Triggers.Equals(input.Triggers)
                ) && 
                (
                    this.Properties == input.Properties ||
                    this.Properties != null &&
                    input.Properties != null &&
                    this.Properties.SequenceEqual(input.Properties)
                ) && 
                (
                    this.WebhookUrl == input.WebhookUrl ||
                    (this.WebhookUrl != null &&
                    this.WebhookUrl.Equals(input.WebhookUrl))
                ) && 
                (
                    this.WebhookHeaders == input.WebhookHeaders ||
                    this.WebhookHeaders != null &&
                    input.WebhookHeaders != null &&
                    this.WebhookHeaders.SequenceEqual(input.WebhookHeaders)
                ) && 
                (
                    this.Devices == input.Devices ||
                    this.Devices != null &&
                    input.Devices != null &&
                    this.Devices.SequenceEqual(input.Devices)
                ) && 
                (
                    this.Count == input.Count ||
                    this.Count.Equals(input.Count)
                ) && 
                (
                    this.PageNumber == input.PageNumber ||
                    this.PageNumber.Equals(input.PageNumber)
                ) && 
                (
                    this.LastCall == input.LastCall ||
                    (this.LastCall != null &&
                    this.LastCall.Equals(input.LastCall))
                ) && 
                (
                    this.Calls == input.Calls ||
                    this.Calls != null &&
                    input.Calls != null &&
                    this.Calls.SequenceEqual(input.Calls)
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
                if (this.OrganisationId != null)
                {
                    hashCode = (hashCode * 59) + this.OrganisationId.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Disabled.GetHashCode();
                if (this.WebhookNumber != null)
                {
                    hashCode = (hashCode * 59) + this.WebhookNumber.GetHashCode();
                }
                if (this.CreatedBy != null)
                {
                    hashCode = (hashCode * 59) + this.CreatedBy.GetHashCode();
                }
                if (this.CreatedOn != null)
                {
                    hashCode = (hashCode * 59) + this.CreatedOn.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Triggers.GetHashCode();
                if (this.Properties != null)
                {
                    hashCode = (hashCode * 59) + this.Properties.GetHashCode();
                }
                if (this.WebhookUrl != null)
                {
                    hashCode = (hashCode * 59) + this.WebhookUrl.GetHashCode();
                }
                if (this.WebhookHeaders != null)
                {
                    hashCode = (hashCode * 59) + this.WebhookHeaders.GetHashCode();
                }
                if (this.Devices != null)
                {
                    hashCode = (hashCode * 59) + this.Devices.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Count.GetHashCode();
                hashCode = (hashCode * 59) + this.PageNumber.GetHashCode();
                if (this.LastCall != null)
                {
                    hashCode = (hashCode * 59) + this.LastCall.GetHashCode();
                }
                if (this.Calls != null)
                {
                    hashCode = (hashCode * 59) + this.Calls.GetHashCode();
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
