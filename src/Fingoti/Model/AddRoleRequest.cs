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
    /// AddRoleRequest
    /// </summary>
    [DataContract(Name = "AddRoleRequest")]
    public partial class AddRoleRequest : IEquatable<AddRoleRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AddRoleRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AddRoleRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AddRoleRequest" /> class.
        /// </summary>
        /// <param name="roleName">roleName (required).</param>
        /// <param name="device">device.</param>
        /// <param name="organisation">organisation.</param>
        /// <param name="follow">follow.</param>
        /// <param name="rule">rule.</param>
        /// <param name="schedule">schedule.</param>
        /// <param name="user">user.</param>
        /// <param name="webhook">webhook.</param>
        /// <param name="partner">partner.</param>
        /// <param name="billing">billing.</param>
        public AddRoleRequest(string roleName = default(string), int device = default(int), int organisation = default(int), int follow = default(int), int rule = default(int), int schedule = default(int), int user = default(int), int webhook = default(int), int partner = default(int), int billing = default(int))
        {
            // to ensure "roleName" is required (not null)
            if (roleName == null)
            {
                throw new ArgumentNullException("roleName is a required property for AddRoleRequest and cannot be null");
            }
            this.RoleName = roleName;
            this.Device = device;
            this.Organisation = organisation;
            this.Follow = follow;
            this.Rule = rule;
            this.Schedule = schedule;
            this.User = user;
            this.Webhook = webhook;
            this.Partner = partner;
            this.Billing = billing;
        }

        /// <summary>
        /// Gets or Sets RoleName
        /// </summary>
        [DataMember(Name = "roleName", IsRequired = true, EmitDefaultValue = true)]
        public string RoleName { get; set; }

        /// <summary>
        /// Gets or Sets Device
        /// </summary>
        [DataMember(Name = "device", EmitDefaultValue = false)]
        public int Device { get; set; }

        /// <summary>
        /// Gets or Sets Organisation
        /// </summary>
        [DataMember(Name = "organisation", EmitDefaultValue = false)]
        public int Organisation { get; set; }

        /// <summary>
        /// Gets or Sets Follow
        /// </summary>
        [DataMember(Name = "follow", EmitDefaultValue = false)]
        public int Follow { get; set; }

        /// <summary>
        /// Gets or Sets Rule
        /// </summary>
        [DataMember(Name = "rule", EmitDefaultValue = false)]
        public int Rule { get; set; }

        /// <summary>
        /// Gets or Sets Schedule
        /// </summary>
        [DataMember(Name = "schedule", EmitDefaultValue = false)]
        public int Schedule { get; set; }

        /// <summary>
        /// Gets or Sets User
        /// </summary>
        [DataMember(Name = "user", EmitDefaultValue = false)]
        public int User { get; set; }

        /// <summary>
        /// Gets or Sets Webhook
        /// </summary>
        [DataMember(Name = "webhook", EmitDefaultValue = false)]
        public int Webhook { get; set; }

        /// <summary>
        /// Gets or Sets Partner
        /// </summary>
        [DataMember(Name = "partner", EmitDefaultValue = false)]
        public int Partner { get; set; }

        /// <summary>
        /// Gets or Sets Billing
        /// </summary>
        [DataMember(Name = "billing", EmitDefaultValue = false)]
        public int Billing { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AddRoleRequest {\n");
            sb.Append("  RoleName: ").Append(RoleName).Append("\n");
            sb.Append("  Device: ").Append(Device).Append("\n");
            sb.Append("  Organisation: ").Append(Organisation).Append("\n");
            sb.Append("  Follow: ").Append(Follow).Append("\n");
            sb.Append("  Rule: ").Append(Rule).Append("\n");
            sb.Append("  Schedule: ").Append(Schedule).Append("\n");
            sb.Append("  User: ").Append(User).Append("\n");
            sb.Append("  Webhook: ").Append(Webhook).Append("\n");
            sb.Append("  Partner: ").Append(Partner).Append("\n");
            sb.Append("  Billing: ").Append(Billing).Append("\n");
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
            return this.Equals(input as AddRoleRequest);
        }

        /// <summary>
        /// Returns true if AddRoleRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of AddRoleRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AddRoleRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.RoleName == input.RoleName ||
                    (this.RoleName != null &&
                    this.RoleName.Equals(input.RoleName))
                ) && 
                (
                    this.Device == input.Device ||
                    this.Device.Equals(input.Device)
                ) && 
                (
                    this.Organisation == input.Organisation ||
                    this.Organisation.Equals(input.Organisation)
                ) && 
                (
                    this.Follow == input.Follow ||
                    this.Follow.Equals(input.Follow)
                ) && 
                (
                    this.Rule == input.Rule ||
                    this.Rule.Equals(input.Rule)
                ) && 
                (
                    this.Schedule == input.Schedule ||
                    this.Schedule.Equals(input.Schedule)
                ) && 
                (
                    this.User == input.User ||
                    this.User.Equals(input.User)
                ) && 
                (
                    this.Webhook == input.Webhook ||
                    this.Webhook.Equals(input.Webhook)
                ) && 
                (
                    this.Partner == input.Partner ||
                    this.Partner.Equals(input.Partner)
                ) && 
                (
                    this.Billing == input.Billing ||
                    this.Billing.Equals(input.Billing)
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
                if (this.RoleName != null)
                {
                    hashCode = (hashCode * 59) + this.RoleName.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Device.GetHashCode();
                hashCode = (hashCode * 59) + this.Organisation.GetHashCode();
                hashCode = (hashCode * 59) + this.Follow.GetHashCode();
                hashCode = (hashCode * 59) + this.Rule.GetHashCode();
                hashCode = (hashCode * 59) + this.Schedule.GetHashCode();
                hashCode = (hashCode * 59) + this.User.GetHashCode();
                hashCode = (hashCode * 59) + this.Webhook.GetHashCode();
                hashCode = (hashCode * 59) + this.Partner.GetHashCode();
                hashCode = (hashCode * 59) + this.Billing.GetHashCode();
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
