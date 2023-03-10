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
    /// WifiDetect
    /// </summary>
    [DataContract(Name = "WifiDetect")]
    public partial class WifiDetect : IEquatable<WifiDetect>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WifiDetect" /> class.
        /// </summary>
        /// <param name="ssid">ssid.</param>
        /// <param name="signal">signal.</param>
        public WifiDetect(string ssid = default(string), int signal = default(int))
        {
            this.Ssid = ssid;
            this.Signal = signal;
        }

        /// <summary>
        /// Gets or Sets Ssid
        /// </summary>
        [DataMember(Name = "ssid", EmitDefaultValue = true)]
        public string Ssid { get; set; }

        /// <summary>
        /// Gets or Sets Signal
        /// </summary>
        [DataMember(Name = "signal", EmitDefaultValue = false)]
        public int Signal { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class WifiDetect {\n");
            sb.Append("  Ssid: ").Append(Ssid).Append("\n");
            sb.Append("  Signal: ").Append(Signal).Append("\n");
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
            return this.Equals(input as WifiDetect);
        }

        /// <summary>
        /// Returns true if WifiDetect instances are equal
        /// </summary>
        /// <param name="input">Instance of WifiDetect to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WifiDetect input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Ssid == input.Ssid ||
                    (this.Ssid != null &&
                    this.Ssid.Equals(input.Ssid))
                ) && 
                (
                    this.Signal == input.Signal ||
                    this.Signal.Equals(input.Signal)
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
                if (this.Ssid != null)
                {
                    hashCode = (hashCode * 59) + this.Ssid.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Signal.GetHashCode();
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
