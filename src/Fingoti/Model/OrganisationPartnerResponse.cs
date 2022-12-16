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
    /// OrganisationPartnerResponse
    /// </summary>
    [DataContract(Name = "OrganisationPartnerResponse")]
    public partial class OrganisationPartnerResponse : IEquatable<OrganisationPartnerResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OrganisationPartnerResponse" /> class.
        /// </summary>
        /// <param name="success">success.</param>
        /// <param name="organisationNumber">organisationNumber.</param>
        /// <param name="organisationName">organisationName.</param>
        /// <param name="address">address.</param>
        /// <param name="contact">contact.</param>
        public OrganisationPartnerResponse(bool success = default(bool), string organisationNumber = default(string), string organisationName = default(string), PartnerAddress address = default(PartnerAddress), PartnerContact contact = default(PartnerContact))
        {
            this.Success = success;
            this.OrganisationNumber = organisationNumber;
            this.OrganisationName = organisationName;
            this.Address = address;
            this.Contact = contact;
        }

        /// <summary>
        /// Gets or Sets Success
        /// </summary>
        [DataMember(Name = "success", EmitDefaultValue = true)]
        public bool Success { get; set; }

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
        /// Gets or Sets Address
        /// </summary>
        [DataMember(Name = "address", EmitDefaultValue = false)]
        public PartnerAddress Address { get; set; }

        /// <summary>
        /// Gets or Sets Contact
        /// </summary>
        [DataMember(Name = "contact", EmitDefaultValue = false)]
        public PartnerContact Contact { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class OrganisationPartnerResponse {\n");
            sb.Append("  Success: ").Append(Success).Append("\n");
            sb.Append("  OrganisationNumber: ").Append(OrganisationNumber).Append("\n");
            sb.Append("  OrganisationName: ").Append(OrganisationName).Append("\n");
            sb.Append("  Address: ").Append(Address).Append("\n");
            sb.Append("  Contact: ").Append(Contact).Append("\n");
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
            return this.Equals(input as OrganisationPartnerResponse);
        }

        /// <summary>
        /// Returns true if OrganisationPartnerResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of OrganisationPartnerResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OrganisationPartnerResponse input)
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
                    this.Address == input.Address ||
                    (this.Address != null &&
                    this.Address.Equals(input.Address))
                ) && 
                (
                    this.Contact == input.Contact ||
                    (this.Contact != null &&
                    this.Contact.Equals(input.Contact))
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
                if (this.OrganisationNumber != null)
                {
                    hashCode = (hashCode * 59) + this.OrganisationNumber.GetHashCode();
                }
                if (this.OrganisationName != null)
                {
                    hashCode = (hashCode * 59) + this.OrganisationName.GetHashCode();
                }
                if (this.Address != null)
                {
                    hashCode = (hashCode * 59) + this.Address.GetHashCode();
                }
                if (this.Contact != null)
                {
                    hashCode = (hashCode * 59) + this.Contact.GetHashCode();
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
