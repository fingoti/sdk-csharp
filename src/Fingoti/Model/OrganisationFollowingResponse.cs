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
    /// OrganisationFollowingResponse
    /// </summary>
    [DataContract(Name = "OrganisationFollowingResponse")]
    public partial class OrganisationFollowingResponse : IEquatable<OrganisationFollowingResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OrganisationFollowingResponse" /> class.
        /// </summary>
        /// <param name="success">success.</param>
        /// <param name="pageNumber">pageNumber.</param>
        /// <param name="count">count.</param>
        /// <param name="followings">followings.</param>
        public OrganisationFollowingResponse(bool success = default(bool), long pageNumber = default(long), long count = default(long), List<OrganisationFollowing> followings = default(List<OrganisationFollowing>))
        {
            this.Success = success;
            this.PageNumber = pageNumber;
            this.Count = count;
            this.Followings = followings;
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
        public long Count { get; set; }

        /// <summary>
        /// Gets or Sets Followings
        /// </summary>
        [DataMember(Name = "followings", EmitDefaultValue = true)]
        public List<OrganisationFollowing> Followings { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class OrganisationFollowingResponse {\n");
            sb.Append("  Success: ").Append(Success).Append("\n");
            sb.Append("  PageNumber: ").Append(PageNumber).Append("\n");
            sb.Append("  Count: ").Append(Count).Append("\n");
            sb.Append("  Followings: ").Append(Followings).Append("\n");
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
            return this.Equals(input as OrganisationFollowingResponse);
        }

        /// <summary>
        /// Returns true if OrganisationFollowingResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of OrganisationFollowingResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OrganisationFollowingResponse input)
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
                    this.Followings == input.Followings ||
                    this.Followings != null &&
                    input.Followings != null &&
                    this.Followings.SequenceEqual(input.Followings)
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
                if (this.Followings != null)
                {
                    hashCode = (hashCode * 59) + this.Followings.GetHashCode();
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