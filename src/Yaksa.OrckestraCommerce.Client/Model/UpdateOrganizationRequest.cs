/*
 * Overture API
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 1.0.0
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
using OpenAPIDateConverter = Yaksa.OrckestraCommerce.Client.Client.OpenAPIDateConverter;

namespace Yaksa.OrckestraCommerce.Client.Model
{
    /// <summary>
    /// Operations related to organizations such as create an organization, get an organization, updating an organization, ...
    /// </summary>
    [DataContract(Name = "UpdateOrganizationRequest")]
    public partial class UpdateOrganizationRequest : IEquatable<UpdateOrganizationRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateOrganizationRequest" /> class.
        /// </summary>
        /// <param name="addressIds">The organization&#39;s addresses..</param>
        /// <param name="created">the date the organization was created..</param>
        /// <param name="createdBy">the identifier of the user who created the organization..</param>
        /// <param name="description">the description of the organization..</param>
        /// <param name="email">the email associated to the organization..</param>
        /// <param name="faxExtension">the fax extension of the organization..</param>
        /// <param name="faxNumber">the fax number of the organization..</param>
        /// <param name="isActive">whether or not this organization is currently active..</param>
        /// <param name="lastModified">the date of the last modification to the organization..</param>
        /// <param name="lastModifiedBy">the identifier of the user who last modified the organization..</param>
        /// <param name="manager">the full name of the organization manager.</param>
        /// <param name="name">the name of the organization. Must be unique..</param>
        /// <param name="phoneExtension">the phone extension of the organization..</param>
        /// <param name="phoneNumber">the phone number of the organization..</param>
        /// <param name="propertyBag">propertyBag.</param>
        /// <param name="tradingPartnerNumber">the trading partner number of the organization..</param>
        public UpdateOrganizationRequest(List<string> addressIds = default(List<string>), DateTime created = default(DateTime), string createdBy = default(string), string description = default(string), string email = default(string), string faxExtension = default(string), string faxNumber = default(string), bool isActive = default(bool), DateTime lastModified = default(DateTime), string lastModifiedBy = default(string), string manager = default(string), string name = default(string), string phoneExtension = default(string), string phoneNumber = default(string), Dictionary<string, Object> propertyBag = default(Dictionary<string, Object>), string tradingPartnerNumber = default(string))
        {
            this.AddressIds = addressIds;
            this.Created = created;
            this.CreatedBy = createdBy;
            this.Description = description;
            this.Email = email;
            this.FaxExtension = faxExtension;
            this.FaxNumber = faxNumber;
            this.IsActive = isActive;
            this.LastModified = lastModified;
            this.LastModifiedBy = lastModifiedBy;
            this.Manager = manager;
            this.Name = name;
            this.PhoneExtension = phoneExtension;
            this.PhoneNumber = phoneNumber;
            this.PropertyBag = propertyBag;
            this.TradingPartnerNumber = tradingPartnerNumber;
        }

        /// <summary>
        /// The organization&#39;s addresses.
        /// </summary>
        /// <value>The organization&#39;s addresses.</value>
        [DataMember(Name = "addressIds", EmitDefaultValue = false)]
        public List<string> AddressIds { get; set; }

        /// <summary>
        /// the date the organization was created.
        /// </summary>
        /// <value>the date the organization was created.</value>
        [DataMember(Name = "created", EmitDefaultValue = false)]
        public DateTime Created { get; set; }

        /// <summary>
        /// the identifier of the user who created the organization.
        /// </summary>
        /// <value>the identifier of the user who created the organization.</value>
        [DataMember(Name = "createdBy", EmitDefaultValue = false)]
        public string CreatedBy { get; set; }

        /// <summary>
        /// the description of the organization.
        /// </summary>
        /// <value>the description of the organization.</value>
        [DataMember(Name = "description", EmitDefaultValue = false)]
        public string Description { get; set; }

        /// <summary>
        /// the email associated to the organization.
        /// </summary>
        /// <value>the email associated to the organization.</value>
        [DataMember(Name = "email", EmitDefaultValue = false)]
        public string Email { get; set; }

        /// <summary>
        /// the fax extension of the organization.
        /// </summary>
        /// <value>the fax extension of the organization.</value>
        [DataMember(Name = "faxExtension", EmitDefaultValue = false)]
        public string FaxExtension { get; set; }

        /// <summary>
        /// the fax number of the organization.
        /// </summary>
        /// <value>the fax number of the organization.</value>
        [DataMember(Name = "faxNumber", EmitDefaultValue = false)]
        public string FaxNumber { get; set; }

        /// <summary>
        /// whether or not this organization is currently active.
        /// </summary>
        /// <value>whether or not this organization is currently active.</value>
        [DataMember(Name = "isActive", EmitDefaultValue = true)]
        public bool IsActive { get; set; }

        /// <summary>
        /// the date of the last modification to the organization.
        /// </summary>
        /// <value>the date of the last modification to the organization.</value>
        [DataMember(Name = "lastModified", EmitDefaultValue = false)]
        public DateTime LastModified { get; set; }

        /// <summary>
        /// the identifier of the user who last modified the organization.
        /// </summary>
        /// <value>the identifier of the user who last modified the organization.</value>
        [DataMember(Name = "lastModifiedBy", EmitDefaultValue = false)]
        public string LastModifiedBy { get; set; }

        /// <summary>
        /// the full name of the organization manager
        /// </summary>
        /// <value>the full name of the organization manager</value>
        [DataMember(Name = "manager", EmitDefaultValue = false)]
        public string Manager { get; set; }

        /// <summary>
        /// the name of the organization. Must be unique.
        /// </summary>
        /// <value>the name of the organization. Must be unique.</value>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// the phone extension of the organization.
        /// </summary>
        /// <value>the phone extension of the organization.</value>
        [DataMember(Name = "phoneExtension", EmitDefaultValue = false)]
        public string PhoneExtension { get; set; }

        /// <summary>
        /// the phone number of the organization.
        /// </summary>
        /// <value>the phone number of the organization.</value>
        [DataMember(Name = "phoneNumber", EmitDefaultValue = false)]
        public string PhoneNumber { get; set; }

        /// <summary>
        /// Gets or Sets PropertyBag
        /// </summary>
        [DataMember(Name = "propertyBag", EmitDefaultValue = false)]
        public Dictionary<string, Object> PropertyBag { get; set; }

        /// <summary>
        /// the trading partner number of the organization.
        /// </summary>
        /// <value>the trading partner number of the organization.</value>
        [DataMember(Name = "tradingPartnerNumber", EmitDefaultValue = false)]
        public string TradingPartnerNumber { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateOrganizationRequest {\n");
            sb.Append("  AddressIds: ").Append(AddressIds).Append("\n");
            sb.Append("  Created: ").Append(Created).Append("\n");
            sb.Append("  CreatedBy: ").Append(CreatedBy).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  FaxExtension: ").Append(FaxExtension).Append("\n");
            sb.Append("  FaxNumber: ").Append(FaxNumber).Append("\n");
            sb.Append("  IsActive: ").Append(IsActive).Append("\n");
            sb.Append("  LastModified: ").Append(LastModified).Append("\n");
            sb.Append("  LastModifiedBy: ").Append(LastModifiedBy).Append("\n");
            sb.Append("  Manager: ").Append(Manager).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  PhoneExtension: ").Append(PhoneExtension).Append("\n");
            sb.Append("  PhoneNumber: ").Append(PhoneNumber).Append("\n");
            sb.Append("  PropertyBag: ").Append(PropertyBag).Append("\n");
            sb.Append("  TradingPartnerNumber: ").Append(TradingPartnerNumber).Append("\n");
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
            return this.Equals(input as UpdateOrganizationRequest);
        }

        /// <summary>
        /// Returns true if UpdateOrganizationRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of UpdateOrganizationRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UpdateOrganizationRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AddressIds == input.AddressIds ||
                    this.AddressIds != null &&
                    input.AddressIds != null &&
                    this.AddressIds.SequenceEqual(input.AddressIds)
                ) && 
                (
                    this.Created == input.Created ||
                    (this.Created != null &&
                    this.Created.Equals(input.Created))
                ) && 
                (
                    this.CreatedBy == input.CreatedBy ||
                    (this.CreatedBy != null &&
                    this.CreatedBy.Equals(input.CreatedBy))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.Email == input.Email ||
                    (this.Email != null &&
                    this.Email.Equals(input.Email))
                ) && 
                (
                    this.FaxExtension == input.FaxExtension ||
                    (this.FaxExtension != null &&
                    this.FaxExtension.Equals(input.FaxExtension))
                ) && 
                (
                    this.FaxNumber == input.FaxNumber ||
                    (this.FaxNumber != null &&
                    this.FaxNumber.Equals(input.FaxNumber))
                ) && 
                (
                    this.IsActive == input.IsActive ||
                    this.IsActive.Equals(input.IsActive)
                ) && 
                (
                    this.LastModified == input.LastModified ||
                    (this.LastModified != null &&
                    this.LastModified.Equals(input.LastModified))
                ) && 
                (
                    this.LastModifiedBy == input.LastModifiedBy ||
                    (this.LastModifiedBy != null &&
                    this.LastModifiedBy.Equals(input.LastModifiedBy))
                ) && 
                (
                    this.Manager == input.Manager ||
                    (this.Manager != null &&
                    this.Manager.Equals(input.Manager))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.PhoneExtension == input.PhoneExtension ||
                    (this.PhoneExtension != null &&
                    this.PhoneExtension.Equals(input.PhoneExtension))
                ) && 
                (
                    this.PhoneNumber == input.PhoneNumber ||
                    (this.PhoneNumber != null &&
                    this.PhoneNumber.Equals(input.PhoneNumber))
                ) && 
                (
                    this.PropertyBag == input.PropertyBag ||
                    this.PropertyBag != null &&
                    input.PropertyBag != null &&
                    this.PropertyBag.SequenceEqual(input.PropertyBag)
                ) && 
                (
                    this.TradingPartnerNumber == input.TradingPartnerNumber ||
                    (this.TradingPartnerNumber != null &&
                    this.TradingPartnerNumber.Equals(input.TradingPartnerNumber))
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
                if (this.AddressIds != null)
                    hashCode = hashCode * 59 + this.AddressIds.GetHashCode();
                if (this.Created != null)
                    hashCode = hashCode * 59 + this.Created.GetHashCode();
                if (this.CreatedBy != null)
                    hashCode = hashCode * 59 + this.CreatedBy.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.Email != null)
                    hashCode = hashCode * 59 + this.Email.GetHashCode();
                if (this.FaxExtension != null)
                    hashCode = hashCode * 59 + this.FaxExtension.GetHashCode();
                if (this.FaxNumber != null)
                    hashCode = hashCode * 59 + this.FaxNumber.GetHashCode();
                hashCode = hashCode * 59 + this.IsActive.GetHashCode();
                if (this.LastModified != null)
                    hashCode = hashCode * 59 + this.LastModified.GetHashCode();
                if (this.LastModifiedBy != null)
                    hashCode = hashCode * 59 + this.LastModifiedBy.GetHashCode();
                if (this.Manager != null)
                    hashCode = hashCode * 59 + this.Manager.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.PhoneExtension != null)
                    hashCode = hashCode * 59 + this.PhoneExtension.GetHashCode();
                if (this.PhoneNumber != null)
                    hashCode = hashCode * 59 + this.PhoneNumber.GetHashCode();
                if (this.PropertyBag != null)
                    hashCode = hashCode * 59 + this.PropertyBag.GetHashCode();
                if (this.TradingPartnerNumber != null)
                    hashCode = hashCode * 59 + this.TradingPartnerNumber.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
