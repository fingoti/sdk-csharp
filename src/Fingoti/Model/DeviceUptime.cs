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
    /// DeviceUptime
    /// </summary>
    [DataContract(Name = "DeviceUptime")]
    public partial class DeviceUptime : IEquatable<DeviceUptime>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DeviceUptime" /> class.
        /// </summary>
        /// <param name="boot">boot.</param>
        public DeviceUptime(DateTime? boot = default(DateTime?))
        {
            this.Boot = boot;
        }

        /// <summary>
        /// Gets or Sets Boot
        /// </summary>
        [DataMember(Name = "boot", EmitDefaultValue = true)]
        public DateTime? Boot { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DeviceUptime {\n");
            sb.Append("  Boot: ").Append(Boot).Append("\n");
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
            return this.Equals(input as DeviceUptime);
        }

        /// <summary>
        /// Returns true if DeviceUptime instances are equal
        /// </summary>
        /// <param name="input">Instance of DeviceUptime to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DeviceUptime input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Boot == input.Boot ||
                    (this.Boot != null &&
                    this.Boot.Equals(input.Boot))
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
                if (this.Boot != null)
                {
                    hashCode = (hashCode * 59) + this.Boot.GetHashCode();
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
