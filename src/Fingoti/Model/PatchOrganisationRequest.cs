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
    /// PatchOrganisationRequest
    /// </summary>
    [DataContract(Name = "PatchOrganisationRequest")]
    public partial class PatchOrganisationRequest : IEquatable<PatchOrganisationRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PatchOrganisationRequest" /> class.
        /// </summary>
        /// <param name="organisationName">organisationName.</param>
        /// <param name="vatNumber">vatNumber.</param>
        /// <param name="mainContact">mainContact.</param>
        /// <param name="mainAddress">mainAddress.</param>
        /// <param name="billingContact">billingContact.</param>
        /// <param name="billingAddress">billingAddress.</param>
        /// <param name="deliveryContact">deliveryContact.</param>
        /// <param name="deliveryAddress">deliveryAddress.</param>
        public PatchOrganisationRequest(string organisationName = default(string), string vatNumber = default(string), Guid? mainContact = default(Guid?), Guid? mainAddress = default(Guid?), Guid? billingContact = default(Guid?), Guid? billingAddress = default(Guid?), Guid? deliveryContact = default(Guid?), Guid? deliveryAddress = default(Guid?))
        {
            this.OrganisationName = organisationName;
            this.VatNumber = vatNumber;
            this.MainContact = mainContact;
            this.MainAddress = mainAddress;
            this.BillingContact = billingContact;
            this.BillingAddress = billingAddress;
            this.DeliveryContact = deliveryContact;
            this.DeliveryAddress = deliveryAddress;
        }

        /// <summary>
        /// Gets or Sets OrganisationName
        /// </summary>
        [DataMember(Name = "organisationName", EmitDefaultValue = true)]
        public string OrganisationName { get; set; }

        /// <summary>
        /// Gets or Sets VatNumber
        /// </summary>
        [DataMember(Name = "vatNumber", EmitDefaultValue = true)]
        public string VatNumber { get; set; }

        /// <summary>
        /// Gets or Sets MainContact
        /// </summary>
        [DataMember(Name = "mainContact", EmitDefaultValue = true)]
        public Guid? MainContact { get; set; }

        /// <summary>
        /// Gets or Sets MainAddress
        /// </summary>
        [DataMember(Name = "mainAddress", EmitDefaultValue = true)]
        public Guid? MainAddress { get; set; }

        /// <summary>
        /// Gets or Sets BillingContact
        /// </summary>
        [DataMember(Name = "billingContact", EmitDefaultValue = true)]
        public Guid? BillingContact { get; set; }

        /// <summary>
        /// Gets or Sets BillingAddress
        /// </summary>
        [DataMember(Name = "billingAddress", EmitDefaultValue = true)]
        public Guid? BillingAddress { get; set; }

        /// <summary>
        /// Gets or Sets DeliveryContact
        /// </summary>
        [DataMember(Name = "deliveryContact", EmitDefaultValue = true)]
        public Guid? DeliveryContact { get; set; }

        /// <summary>
        /// Gets or Sets DeliveryAddress
        /// </summary>
        [DataMember(Name = "deliveryAddress", EmitDefaultValue = true)]
        public Guid? DeliveryAddress { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PatchOrganisationRequest {\n");
            sb.Append("  OrganisationName: ").Append(OrganisationName).Append("\n");
            sb.Append("  VatNumber: ").Append(VatNumber).Append("\n");
            sb.Append("  MainContact: ").Append(MainContact).Append("\n");
            sb.Append("  MainAddress: ").Append(MainAddress).Append("\n");
            sb.Append("  BillingContact: ").Append(BillingContact).Append("\n");
            sb.Append("  BillingAddress: ").Append(BillingAddress).Append("\n");
            sb.Append("  DeliveryContact: ").Append(DeliveryContact).Append("\n");
            sb.Append("  DeliveryAddress: ").Append(DeliveryAddress).Append("\n");
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
            return this.Equals(input as PatchOrganisationRequest);
        }

        /// <summary>
        /// Returns true if PatchOrganisationRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of PatchOrganisationRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PatchOrganisationRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.OrganisationName == input.OrganisationName ||
                    (this.OrganisationName != null &&
                    this.OrganisationName.Equals(input.OrganisationName))
                ) && 
                (
                    this.VatNumber == input.VatNumber ||
                    (this.VatNumber != null &&
                    this.VatNumber.Equals(input.VatNumber))
                ) && 
                (
                    this.MainContact == input.MainContact ||
                    (this.MainContact != null &&
                    this.MainContact.Equals(input.MainContact))
                ) && 
                (
                    this.MainAddress == input.MainAddress ||
                    (this.MainAddress != null &&
                    this.MainAddress.Equals(input.MainAddress))
                ) && 
                (
                    this.BillingContact == input.BillingContact ||
                    (this.BillingContact != null &&
                    this.BillingContact.Equals(input.BillingContact))
                ) && 
                (
                    this.BillingAddress == input.BillingAddress ||
                    (this.BillingAddress != null &&
                    this.BillingAddress.Equals(input.BillingAddress))
                ) && 
                (
                    this.DeliveryContact == input.DeliveryContact ||
                    (this.DeliveryContact != null &&
                    this.DeliveryContact.Equals(input.DeliveryContact))
                ) && 
                (
                    this.DeliveryAddress == input.DeliveryAddress ||
                    (this.DeliveryAddress != null &&
                    this.DeliveryAddress.Equals(input.DeliveryAddress))
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
                if (this.OrganisationName != null)
                {
                    hashCode = (hashCode * 59) + this.OrganisationName.GetHashCode();
                }
                if (this.VatNumber != null)
                {
                    hashCode = (hashCode * 59) + this.VatNumber.GetHashCode();
                }
                if (this.MainContact != null)
                {
                    hashCode = (hashCode * 59) + this.MainContact.GetHashCode();
                }
                if (this.MainAddress != null)
                {
                    hashCode = (hashCode * 59) + this.MainAddress.GetHashCode();
                }
                if (this.BillingContact != null)
                {
                    hashCode = (hashCode * 59) + this.BillingContact.GetHashCode();
                }
                if (this.BillingAddress != null)
                {
                    hashCode = (hashCode * 59) + this.BillingAddress.GetHashCode();
                }
                if (this.DeliveryContact != null)
                {
                    hashCode = (hashCode * 59) + this.DeliveryContact.GetHashCode();
                }
                if (this.DeliveryAddress != null)
                {
                    hashCode = (hashCode * 59) + this.DeliveryAddress.GetHashCode();
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
