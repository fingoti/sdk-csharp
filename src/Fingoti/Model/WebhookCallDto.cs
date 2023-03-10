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
    /// WebhookCallDto
    /// </summary>
    [DataContract(Name = "WebhookCallDto")]
    public partial class WebhookCallDto : IEquatable<WebhookCallDto>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name = "status", EmitDefaultValue = false)]
        public WebhookStatus? Status { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookCallDto" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="status">status.</param>
        /// <param name="timestamp">timestamp.</param>
        /// <param name="requestUrl">requestUrl.</param>
        /// <param name="requestHeaders">requestHeaders.</param>
        /// <param name="requestBody">requestBody.</param>
        /// <param name="attempts">attempts.</param>
        public WebhookCallDto(Guid id = default(Guid), WebhookStatus? status = default(WebhookStatus?), DateTime? timestamp = default(DateTime?), string requestUrl = default(string), List<WebhookHeaders> requestHeaders = default(List<WebhookHeaders>), Object requestBody = default(Object), List<WebhookAttempts> attempts = default(List<WebhookAttempts>))
        {
            this.Id = id;
            this.Status = status;
            this.Timestamp = timestamp;
            this.RequestUrl = requestUrl;
            this.RequestHeaders = requestHeaders;
            this.RequestBody = requestBody;
            this.Attempts = attempts;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public Guid Id { get; set; }

        /// <summary>
        /// Gets or Sets Timestamp
        /// </summary>
        [DataMember(Name = "timestamp", EmitDefaultValue = true)]
        public DateTime? Timestamp { get; set; }

        /// <summary>
        /// Gets or Sets RequestUrl
        /// </summary>
        [DataMember(Name = "requestUrl", EmitDefaultValue = true)]
        public string RequestUrl { get; set; }

        /// <summary>
        /// Gets or Sets RequestHeaders
        /// </summary>
        [DataMember(Name = "requestHeaders", EmitDefaultValue = true)]
        public List<WebhookHeaders> RequestHeaders { get; set; }

        /// <summary>
        /// Gets or Sets RequestBody
        /// </summary>
        [DataMember(Name = "requestBody", EmitDefaultValue = true)]
        public Object RequestBody { get; set; }

        /// <summary>
        /// Gets or Sets Count
        /// </summary>
        [DataMember(Name = "count", EmitDefaultValue = false)]
        public int Count { get; private set; }

        /// <summary>
        /// Returns false as Count should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeCount()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets Attempts
        /// </summary>
        [DataMember(Name = "attempts", EmitDefaultValue = true)]
        public List<WebhookAttempts> Attempts { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class WebhookCallDto {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Timestamp: ").Append(Timestamp).Append("\n");
            sb.Append("  RequestUrl: ").Append(RequestUrl).Append("\n");
            sb.Append("  RequestHeaders: ").Append(RequestHeaders).Append("\n");
            sb.Append("  RequestBody: ").Append(RequestBody).Append("\n");
            sb.Append("  Count: ").Append(Count).Append("\n");
            sb.Append("  Attempts: ").Append(Attempts).Append("\n");
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
            return this.Equals(input as WebhookCallDto);
        }

        /// <summary>
        /// Returns true if WebhookCallDto instances are equal
        /// </summary>
        /// <param name="input">Instance of WebhookCallDto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WebhookCallDto input)
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
                    this.Status == input.Status ||
                    this.Status.Equals(input.Status)
                ) && 
                (
                    this.Timestamp == input.Timestamp ||
                    (this.Timestamp != null &&
                    this.Timestamp.Equals(input.Timestamp))
                ) && 
                (
                    this.RequestUrl == input.RequestUrl ||
                    (this.RequestUrl != null &&
                    this.RequestUrl.Equals(input.RequestUrl))
                ) && 
                (
                    this.RequestHeaders == input.RequestHeaders ||
                    this.RequestHeaders != null &&
                    input.RequestHeaders != null &&
                    this.RequestHeaders.SequenceEqual(input.RequestHeaders)
                ) && 
                (
                    this.RequestBody == input.RequestBody ||
                    (this.RequestBody != null &&
                    this.RequestBody.Equals(input.RequestBody))
                ) && 
                (
                    this.Count == input.Count ||
                    this.Count.Equals(input.Count)
                ) && 
                (
                    this.Attempts == input.Attempts ||
                    this.Attempts != null &&
                    input.Attempts != null &&
                    this.Attempts.SequenceEqual(input.Attempts)
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
                hashCode = (hashCode * 59) + this.Status.GetHashCode();
                if (this.Timestamp != null)
                {
                    hashCode = (hashCode * 59) + this.Timestamp.GetHashCode();
                }
                if (this.RequestUrl != null)
                {
                    hashCode = (hashCode * 59) + this.RequestUrl.GetHashCode();
                }
                if (this.RequestHeaders != null)
                {
                    hashCode = (hashCode * 59) + this.RequestHeaders.GetHashCode();
                }
                if (this.RequestBody != null)
                {
                    hashCode = (hashCode * 59) + this.RequestBody.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Count.GetHashCode();
                if (this.Attempts != null)
                {
                    hashCode = (hashCode * 59) + this.Attempts.GetHashCode();
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
