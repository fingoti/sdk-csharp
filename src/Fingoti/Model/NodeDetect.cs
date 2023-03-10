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
    /// NodeDetect
    /// </summary>
    [DataContract(Name = "NodeDetect")]
    public partial class NodeDetect : IEquatable<NodeDetect>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NodeDetect" /> class.
        /// </summary>
        /// <param name="serial">serial.</param>
        /// <param name="address">address.</param>
        public NodeDetect(string serial = default(string), int address = default(int))
        {
            this.Serial = serial;
            this.Address = address;
        }

        /// <summary>
        /// Gets or Sets Serial
        /// </summary>
        [DataMember(Name = "serial", EmitDefaultValue = true)]
        public string Serial { get; set; }

        /// <summary>
        /// Gets or Sets Address
        /// </summary>
        [DataMember(Name = "address", EmitDefaultValue = false)]
        public int Address { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class NodeDetect {\n");
            sb.Append("  Serial: ").Append(Serial).Append("\n");
            sb.Append("  Address: ").Append(Address).Append("\n");
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
            return this.Equals(input as NodeDetect);
        }

        /// <summary>
        /// Returns true if NodeDetect instances are equal
        /// </summary>
        /// <param name="input">Instance of NodeDetect to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NodeDetect input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Serial == input.Serial ||
                    (this.Serial != null &&
                    this.Serial.Equals(input.Serial))
                ) && 
                (
                    this.Address == input.Address ||
                    this.Address.Equals(input.Address)
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
                if (this.Serial != null)
                {
                    hashCode = (hashCode * 59) + this.Serial.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Address.GetHashCode();
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
