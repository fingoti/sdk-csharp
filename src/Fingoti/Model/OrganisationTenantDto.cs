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
    /// OrganisationTenantDto
    /// </summary>
    [DataContract(Name = "OrganisationTenantDto")]
    public partial class OrganisationTenantDto : IEquatable<OrganisationTenantDto>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OrganisationTenantDto" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="organisationNumber">organisationNumber.</param>
        /// <param name="organisationName">organisationName.</param>
        /// <param name="subscriptionId">subscriptionId.</param>
        /// <param name="isBusiness">isBusiness.</param>
        /// <param name="trialUsed">trialUsed.</param>
        /// <param name="disabled">disabled.</param>
        public OrganisationTenantDto(Guid id = default(Guid), string organisationNumber = default(string), string organisationName = default(string), string subscriptionId = default(string), bool isBusiness = default(bool), bool trialUsed = default(bool), bool disabled = default(bool))
        {
            this.Id = id;
            this.OrganisationNumber = organisationNumber;
            this.OrganisationName = organisationName;
            this.SubscriptionId = subscriptionId;
            this.IsBusiness = isBusiness;
            this.TrialUsed = trialUsed;
            this.Disabled = disabled;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public Guid Id { get; set; }

        /// <summary>
        /// Gets or Sets OrganisationNumber
        /// </summary>
        [DataMember(Name = "organisationNumber", EmitDefaultValue = true)]
        public string OrganisationNumber { get; set; }

        /// <summary>
        /// Gets or Sets OrganisationName
        /// </summary>
        [DataMember(Name = "organisationName", EmitDefaultValue = true)]
        public string OrganisationName { get; set; }

        /// <summary>
        /// Gets or Sets SubscriptionId
        /// </summary>
        [DataMember(Name = "subscriptionId", EmitDefaultValue = true)]
        public string SubscriptionId { get; set; }

        /// <summary>
        /// Gets or Sets IsBusiness
        /// </summary>
        [DataMember(Name = "isBusiness", EmitDefaultValue = true)]
        public bool IsBusiness { get; set; }

        /// <summary>
        /// Gets or Sets TrialUsed
        /// </summary>
        [DataMember(Name = "trialUsed", EmitDefaultValue = true)]
        public bool TrialUsed { get; set; }

        /// <summary>
        /// Gets or Sets Disabled
        /// </summary>
        [DataMember(Name = "disabled", EmitDefaultValue = true)]
        public bool Disabled { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class OrganisationTenantDto {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  OrganisationNumber: ").Append(OrganisationNumber).Append("\n");
            sb.Append("  OrganisationName: ").Append(OrganisationName).Append("\n");
            sb.Append("  SubscriptionId: ").Append(SubscriptionId).Append("\n");
            sb.Append("  IsBusiness: ").Append(IsBusiness).Append("\n");
            sb.Append("  TrialUsed: ").Append(TrialUsed).Append("\n");
            sb.Append("  Disabled: ").Append(Disabled).Append("\n");
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
            return this.Equals(input as OrganisationTenantDto);
        }

        /// <summary>
        /// Returns true if OrganisationTenantDto instances are equal
        /// </summary>
        /// <param name="input">Instance of OrganisationTenantDto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OrganisationTenantDto input)
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
                    this.OrganisationNumber == input.OrganisationNumber ||
                    (this.OrganisationNumber != null &&
                    this.OrganisationNumber.Equals(input.OrganisationNumber))
                ) && 
                (
                    this.OrganisationName == input.OrganisationName ||
                    (this.OrganisationName != null &&
                    this.OrganisationName.Equals(input.OrganisationName))
                ) && 
                (
                    this.SubscriptionId == input.SubscriptionId ||
                    (this.SubscriptionId != null &&
                    this.SubscriptionId.Equals(input.SubscriptionId))
                ) && 
                (
                    this.IsBusiness == input.IsBusiness ||
                    this.IsBusiness.Equals(input.IsBusiness)
                ) && 
                (
                    this.TrialUsed == input.TrialUsed ||
                    this.TrialUsed.Equals(input.TrialUsed)
                ) && 
                (
                    this.Disabled == input.Disabled ||
                    this.Disabled.Equals(input.Disabled)
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
                if (this.OrganisationNumber != null)
                {
                    hashCode = (hashCode * 59) + this.OrganisationNumber.GetHashCode();
                }
                if (this.OrganisationName != null)
                {
                    hashCode = (hashCode * 59) + this.OrganisationName.GetHashCode();
                }
                if (this.SubscriptionId != null)
                {
                    hashCode = (hashCode * 59) + this.SubscriptionId.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.IsBusiness.GetHashCode();
                hashCode = (hashCode * 59) + this.TrialUsed.GetHashCode();
                hashCode = (hashCode * 59) + this.Disabled.GetHashCode();
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
