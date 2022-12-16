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
    /// OrganisationAddressesDto
    /// </summary>
    [DataContract(Name = "OrganisationAddressesDto")]
    public partial class OrganisationAddressesDto : IEquatable<OrganisationAddressesDto>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OrganisationAddressesDto" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected OrganisationAddressesDto() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="OrganisationAddressesDto" /> class.
        /// </summary>
        /// <param name="line1">line1 (required).</param>
        /// <param name="line2">line2.</param>
        /// <param name="city">city.</param>
        /// <param name="county">county.</param>
        /// <param name="postcode">postcode (required).</param>
        /// <param name="country">country (required).</param>
        /// <param name="id">id.</param>
        public OrganisationAddressesDto(string line1 = default(string), string line2 = default(string), string city = default(string), string county = default(string), string postcode = default(string), string country = default(string), Guid id = default(Guid))
        {
            // to ensure "line1" is required (not null)
            if (line1 == null)
            {
                throw new ArgumentNullException("line1 is a required property for OrganisationAddressesDto and cannot be null");
            }
            this.Line1 = line1;
            // to ensure "postcode" is required (not null)
            if (postcode == null)
            {
                throw new ArgumentNullException("postcode is a required property for OrganisationAddressesDto and cannot be null");
            }
            this.Postcode = postcode;
            // to ensure "country" is required (not null)
            if (country == null)
            {
                throw new ArgumentNullException("country is a required property for OrganisationAddressesDto and cannot be null");
            }
            this.Country = country;
            this.Line2 = line2;
            this.City = city;
            this.County = county;
            this.Id = id;
        }

        /// <summary>
        /// Gets or Sets Line1
        /// </summary>
        [DataMember(Name = "line1", IsRequired = true, EmitDefaultValue = true)]
        public string Line1 { get; set; }

        /// <summary>
        /// Gets or Sets Line2
        /// </summary>
        [DataMember(Name = "line2", EmitDefaultValue = true)]
        public string Line2 { get; set; }

        /// <summary>
        /// Gets or Sets City
        /// </summary>
        [DataMember(Name = "city", EmitDefaultValue = true)]
        public string City { get; set; }

        /// <summary>
        /// Gets or Sets County
        /// </summary>
        [DataMember(Name = "county", EmitDefaultValue = true)]
        public string County { get; set; }

        /// <summary>
        /// Gets or Sets Postcode
        /// </summary>
        [DataMember(Name = "postcode", IsRequired = true, EmitDefaultValue = true)]
        public string Postcode { get; set; }

        /// <summary>
        /// Gets or Sets Country
        /// </summary>
        [DataMember(Name = "country", IsRequired = true, EmitDefaultValue = true)]
        public string Country { get; set; }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public Guid Id { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class OrganisationAddressesDto {\n");
            sb.Append("  Line1: ").Append(Line1).Append("\n");
            sb.Append("  Line2: ").Append(Line2).Append("\n");
            sb.Append("  City: ").Append(City).Append("\n");
            sb.Append("  County: ").Append(County).Append("\n");
            sb.Append("  Postcode: ").Append(Postcode).Append("\n");
            sb.Append("  Country: ").Append(Country).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
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
            return this.Equals(input as OrganisationAddressesDto);
        }

        /// <summary>
        /// Returns true if OrganisationAddressesDto instances are equal
        /// </summary>
        /// <param name="input">Instance of OrganisationAddressesDto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OrganisationAddressesDto input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Line1 == input.Line1 ||
                    (this.Line1 != null &&
                    this.Line1.Equals(input.Line1))
                ) && 
                (
                    this.Line2 == input.Line2 ||
                    (this.Line2 != null &&
                    this.Line2.Equals(input.Line2))
                ) && 
                (
                    this.City == input.City ||
                    (this.City != null &&
                    this.City.Equals(input.City))
                ) && 
                (
                    this.County == input.County ||
                    (this.County != null &&
                    this.County.Equals(input.County))
                ) && 
                (
                    this.Postcode == input.Postcode ||
                    (this.Postcode != null &&
                    this.Postcode.Equals(input.Postcode))
                ) && 
                (
                    this.Country == input.Country ||
                    (this.Country != null &&
                    this.Country.Equals(input.Country))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
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
                if (this.Line1 != null)
                {
                    hashCode = (hashCode * 59) + this.Line1.GetHashCode();
                }
                if (this.Line2 != null)
                {
                    hashCode = (hashCode * 59) + this.Line2.GetHashCode();
                }
                if (this.City != null)
                {
                    hashCode = (hashCode * 59) + this.City.GetHashCode();
                }
                if (this.County != null)
                {
                    hashCode = (hashCode * 59) + this.County.GetHashCode();
                }
                if (this.Postcode != null)
                {
                    hashCode = (hashCode * 59) + this.Postcode.GetHashCode();
                }
                if (this.Country != null)
                {
                    hashCode = (hashCode * 59) + this.Country.GetHashCode();
                }
                if (this.Id != null)
                {
                    hashCode = (hashCode * 59) + this.Id.GetHashCode();
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
            // Country (string) maxLength
            if (this.Country != null && this.Country.Length > 2)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Country, length must be less than 2.", new [] { "Country" });
            }

            // Country (string) minLength
            if (this.Country != null && this.Country.Length < 2)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Country, length must be greater than 2.", new [] { "Country" });
            }

            yield break;
        }
    }

}