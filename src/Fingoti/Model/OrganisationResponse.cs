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
    /// OrganisationResponse
    /// </summary>
    [DataContract(Name = "OrganisationResponse")]
    public partial class OrganisationResponse : IEquatable<OrganisationResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OrganisationResponse" /> class.
        /// </summary>
        /// <param name="success">success.</param>
        /// <param name="id">id.</param>
        /// <param name="disabled">disabled.</param>
        /// <param name="organisationNumber">organisationNumber.</param>
        /// <param name="organisationName">organisationName.</param>
        /// <param name="organisationHandle">organisationHandle.</param>
        /// <param name="isBusiness">isBusiness.</param>
        /// <param name="isPartner">isPartner.</param>
        /// <param name="partnerId">partnerId.</param>
        /// <param name="mainContact">mainContact.</param>
        /// <param name="mainAddress">mainAddress.</param>
        /// <param name="billingContact">billingContact.</param>
        /// <param name="billingAddress">billingAddress.</param>
        /// <param name="deliveryContact">deliveryContact.</param>
        /// <param name="deliveryAddress">deliveryAddress.</param>
        /// <param name="vatNumber">vatNumber.</param>
        /// <param name="credit">credit.</param>
        /// <param name="registeredOn">registeredOn.</param>
        /// <param name="adminRole">adminRole.</param>
        /// <param name="readRole">readRole.</param>
        public OrganisationResponse(bool success = default(bool), Guid id = default(Guid), bool disabled = default(bool), string organisationNumber = default(string), string organisationName = default(string), string organisationHandle = default(string), bool isBusiness = default(bool), bool isPartner = default(bool), Guid? partnerId = default(Guid?), Guid mainContact = default(Guid), Guid mainAddress = default(Guid), Guid billingContact = default(Guid), Guid billingAddress = default(Guid), Guid deliveryContact = default(Guid), Guid deliveryAddress = default(Guid), string vatNumber = default(string), double credit = default(double), DateTime? registeredOn = default(DateTime?), Guid adminRole = default(Guid), Guid readRole = default(Guid))
        {
            this.Success = success;
            this.Id = id;
            this.Disabled = disabled;
            this.OrganisationNumber = organisationNumber;
            this.OrganisationName = organisationName;
            this.OrganisationHandle = organisationHandle;
            this.IsBusiness = isBusiness;
            this.IsPartner = isPartner;
            this.PartnerId = partnerId;
            this.MainContact = mainContact;
            this.MainAddress = mainAddress;
            this.BillingContact = billingContact;
            this.BillingAddress = billingAddress;
            this.DeliveryContact = deliveryContact;
            this.DeliveryAddress = deliveryAddress;
            this.VatNumber = vatNumber;
            this.Credit = credit;
            this.RegisteredOn = registeredOn;
            this.AdminRole = adminRole;
            this.ReadRole = readRole;
        }

        /// <summary>
        /// Gets or Sets Success
        /// </summary>
        [DataMember(Name = "success", EmitDefaultValue = true)]
        public bool Success { get; set; }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public Guid Id { get; set; }

        /// <summary>
        /// Gets or Sets Disabled
        /// </summary>
        [DataMember(Name = "disabled", EmitDefaultValue = true)]
        public bool Disabled { get; set; }

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
        /// Gets or Sets OrganisationHandle
        /// </summary>
        [DataMember(Name = "organisationHandle", EmitDefaultValue = true)]
        public string OrganisationHandle { get; set; }

        /// <summary>
        /// Gets or Sets IsBusiness
        /// </summary>
        [DataMember(Name = "isBusiness", EmitDefaultValue = true)]
        public bool IsBusiness { get; set; }

        /// <summary>
        /// Gets or Sets IsPartner
        /// </summary>
        [DataMember(Name = "isPartner", EmitDefaultValue = true)]
        public bool IsPartner { get; set; }

        /// <summary>
        /// Gets or Sets PartnerId
        /// </summary>
        [DataMember(Name = "partnerId", EmitDefaultValue = true)]
        public Guid? PartnerId { get; set; }

        /// <summary>
        /// Gets or Sets MainContact
        /// </summary>
        [DataMember(Name = "mainContact", EmitDefaultValue = false)]
        public Guid MainContact { get; set; }

        /// <summary>
        /// Gets or Sets MainAddress
        /// </summary>
        [DataMember(Name = "mainAddress", EmitDefaultValue = false)]
        public Guid MainAddress { get; set; }

        /// <summary>
        /// Gets or Sets BillingContact
        /// </summary>
        [DataMember(Name = "billingContact", EmitDefaultValue = false)]
        public Guid BillingContact { get; set; }

        /// <summary>
        /// Gets or Sets BillingAddress
        /// </summary>
        [DataMember(Name = "billingAddress", EmitDefaultValue = false)]
        public Guid BillingAddress { get; set; }

        /// <summary>
        /// Gets or Sets DeliveryContact
        /// </summary>
        [DataMember(Name = "deliveryContact", EmitDefaultValue = false)]
        public Guid DeliveryContact { get; set; }

        /// <summary>
        /// Gets or Sets DeliveryAddress
        /// </summary>
        [DataMember(Name = "deliveryAddress", EmitDefaultValue = false)]
        public Guid DeliveryAddress { get; set; }

        /// <summary>
        /// Gets or Sets VatNumber
        /// </summary>
        [DataMember(Name = "vatNumber", EmitDefaultValue = true)]
        public string VatNumber { get; set; }

        /// <summary>
        /// Gets or Sets Credit
        /// </summary>
        [DataMember(Name = "credit", EmitDefaultValue = false)]
        public double Credit { get; set; }

        /// <summary>
        /// Gets or Sets RegisteredOn
        /// </summary>
        [DataMember(Name = "registeredOn", EmitDefaultValue = true)]
        public DateTime? RegisteredOn { get; set; }

        /// <summary>
        /// Gets or Sets AdminRole
        /// </summary>
        [DataMember(Name = "adminRole", EmitDefaultValue = false)]
        public Guid AdminRole { get; set; }

        /// <summary>
        /// Gets or Sets ReadRole
        /// </summary>
        [DataMember(Name = "readRole", EmitDefaultValue = false)]
        public Guid ReadRole { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class OrganisationResponse {\n");
            sb.Append("  Success: ").Append(Success).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Disabled: ").Append(Disabled).Append("\n");
            sb.Append("  OrganisationNumber: ").Append(OrganisationNumber).Append("\n");
            sb.Append("  OrganisationName: ").Append(OrganisationName).Append("\n");
            sb.Append("  OrganisationHandle: ").Append(OrganisationHandle).Append("\n");
            sb.Append("  IsBusiness: ").Append(IsBusiness).Append("\n");
            sb.Append("  IsPartner: ").Append(IsPartner).Append("\n");
            sb.Append("  PartnerId: ").Append(PartnerId).Append("\n");
            sb.Append("  MainContact: ").Append(MainContact).Append("\n");
            sb.Append("  MainAddress: ").Append(MainAddress).Append("\n");
            sb.Append("  BillingContact: ").Append(BillingContact).Append("\n");
            sb.Append("  BillingAddress: ").Append(BillingAddress).Append("\n");
            sb.Append("  DeliveryContact: ").Append(DeliveryContact).Append("\n");
            sb.Append("  DeliveryAddress: ").Append(DeliveryAddress).Append("\n");
            sb.Append("  VatNumber: ").Append(VatNumber).Append("\n");
            sb.Append("  Credit: ").Append(Credit).Append("\n");
            sb.Append("  RegisteredOn: ").Append(RegisteredOn).Append("\n");
            sb.Append("  AdminRole: ").Append(AdminRole).Append("\n");
            sb.Append("  ReadRole: ").Append(ReadRole).Append("\n");
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
            return this.Equals(input as OrganisationResponse);
        }

        /// <summary>
        /// Returns true if OrganisationResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of OrganisationResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OrganisationResponse input)
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
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Disabled == input.Disabled ||
                    this.Disabled.Equals(input.Disabled)
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
                    this.OrganisationHandle == input.OrganisationHandle ||
                    (this.OrganisationHandle != null &&
                    this.OrganisationHandle.Equals(input.OrganisationHandle))
                ) && 
                (
                    this.IsBusiness == input.IsBusiness ||
                    this.IsBusiness.Equals(input.IsBusiness)
                ) && 
                (
                    this.IsPartner == input.IsPartner ||
                    this.IsPartner.Equals(input.IsPartner)
                ) && 
                (
                    this.PartnerId == input.PartnerId ||
                    (this.PartnerId != null &&
                    this.PartnerId.Equals(input.PartnerId))
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
                ) && 
                (
                    this.VatNumber == input.VatNumber ||
                    (this.VatNumber != null &&
                    this.VatNumber.Equals(input.VatNumber))
                ) && 
                (
                    this.Credit == input.Credit ||
                    this.Credit.Equals(input.Credit)
                ) && 
                (
                    this.RegisteredOn == input.RegisteredOn ||
                    (this.RegisteredOn != null &&
                    this.RegisteredOn.Equals(input.RegisteredOn))
                ) && 
                (
                    this.AdminRole == input.AdminRole ||
                    (this.AdminRole != null &&
                    this.AdminRole.Equals(input.AdminRole))
                ) && 
                (
                    this.ReadRole == input.ReadRole ||
                    (this.ReadRole != null &&
                    this.ReadRole.Equals(input.ReadRole))
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
                if (this.Id != null)
                {
                    hashCode = (hashCode * 59) + this.Id.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Disabled.GetHashCode();
                if (this.OrganisationNumber != null)
                {
                    hashCode = (hashCode * 59) + this.OrganisationNumber.GetHashCode();
                }
                if (this.OrganisationName != null)
                {
                    hashCode = (hashCode * 59) + this.OrganisationName.GetHashCode();
                }
                if (this.OrganisationHandle != null)
                {
                    hashCode = (hashCode * 59) + this.OrganisationHandle.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.IsBusiness.GetHashCode();
                hashCode = (hashCode * 59) + this.IsPartner.GetHashCode();
                if (this.PartnerId != null)
                {
                    hashCode = (hashCode * 59) + this.PartnerId.GetHashCode();
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
                if (this.VatNumber != null)
                {
                    hashCode = (hashCode * 59) + this.VatNumber.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Credit.GetHashCode();
                if (this.RegisteredOn != null)
                {
                    hashCode = (hashCode * 59) + this.RegisteredOn.GetHashCode();
                }
                if (this.AdminRole != null)
                {
                    hashCode = (hashCode * 59) + this.AdminRole.GetHashCode();
                }
                if (this.ReadRole != null)
                {
                    hashCode = (hashCode * 59) + this.ReadRole.GetHashCode();
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
