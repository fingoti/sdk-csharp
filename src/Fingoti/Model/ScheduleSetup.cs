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
    /// ScheduleSetup
    /// </summary>
    [DataContract(Name = "ScheduleSetup")]
    public partial class ScheduleSetup : IEquatable<ScheduleSetup>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ScheduleSetup" /> class.
        /// </summary>
        /// <param name="slot">slot.</param>
        /// <param name="status">status.</param>
        /// <param name="cron">cron.</param>
        /// <param name="request">request.</param>
        public ScheduleSetup(int slot = default(int), ScheduleStatus status = default(ScheduleStatus), string cron = default(string), List<TimerRequest> request = default(List<TimerRequest>))
        {
            this.Slot = slot;
            this.Status = status;
            this.Cron = cron;
            this.Request = request;
        }

        /// <summary>
        /// Gets or Sets Slot
        /// </summary>
        [DataMember(Name = "slot", EmitDefaultValue = false)]
        public int Slot { get; set; }

        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name = "status", EmitDefaultValue = false)]
        public ScheduleStatus Status { get; set; }

        /// <summary>
        /// Gets or Sets Cron
        /// </summary>
        [DataMember(Name = "cron", EmitDefaultValue = true)]
        public string Cron { get; set; }

        /// <summary>
        /// Gets or Sets Request
        /// </summary>
        [DataMember(Name = "request", EmitDefaultValue = true)]
        public List<TimerRequest> Request { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ScheduleSetup {\n");
            sb.Append("  Slot: ").Append(Slot).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Cron: ").Append(Cron).Append("\n");
            sb.Append("  Request: ").Append(Request).Append("\n");
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
            return this.Equals(input as ScheduleSetup);
        }

        /// <summary>
        /// Returns true if ScheduleSetup instances are equal
        /// </summary>
        /// <param name="input">Instance of ScheduleSetup to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ScheduleSetup input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Slot == input.Slot ||
                    this.Slot.Equals(input.Slot)
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.Cron == input.Cron ||
                    (this.Cron != null &&
                    this.Cron.Equals(input.Cron))
                ) && 
                (
                    this.Request == input.Request ||
                    this.Request != null &&
                    input.Request != null &&
                    this.Request.SequenceEqual(input.Request)
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
                hashCode = (hashCode * 59) + this.Slot.GetHashCode();
                if (this.Status != null)
                {
                    hashCode = (hashCode * 59) + this.Status.GetHashCode();
                }
                if (this.Cron != null)
                {
                    hashCode = (hashCode * 59) + this.Cron.GetHashCode();
                }
                if (this.Request != null)
                {
                    hashCode = (hashCode * 59) + this.Request.GetHashCode();
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
