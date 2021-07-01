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
    /// Orders are entities which represent an order of a customer.
    /// </summary>
    [DataContract(Name = "CreateRmaGuestRequest")]
    public partial class CreateRmaGuestRequest : IEquatable<CreateRmaGuestRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateRmaGuestRequest" /> class.
        /// </summary>
        /// <param name="id">the unique identifier of the RMA.</param>
        /// <param name="propertyBag">propertyBag.</param>
        /// <param name="rmaExternalNumber">the external number for RMA.</param>
        /// <param name="rmaItems">RMA item details.</param>
        /// <param name="email">the email address of the customer.</param>
        /// <param name="lastName">Gets or set the last name of the customer.</param>
        /// <param name="postalCode">Gets or sets the Postal code of the customer billing address.</param>
        public CreateRmaGuestRequest(string id = default(string), Dictionary<string, Object> propertyBag = default(Dictionary<string, Object>), string rmaExternalNumber = default(string), List<RmaItem> rmaItems = default(List<RmaItem>), string email = default(string), string lastName = default(string), string postalCode = default(string))
        {
            this.Id = id;
            this.PropertyBag = propertyBag;
            this.RmaExternalNumber = rmaExternalNumber;
            this.RmaItems = rmaItems;
            this.Email = email;
            this.LastName = lastName;
            this.PostalCode = postalCode;
        }

        /// <summary>
        /// the unique identifier of the RMA
        /// </summary>
        /// <value>the unique identifier of the RMA</value>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets PropertyBag
        /// </summary>
        [DataMember(Name = "propertyBag", EmitDefaultValue = false)]
        public Dictionary<string, Object> PropertyBag { get; set; }

        /// <summary>
        /// the external number for RMA
        /// </summary>
        /// <value>the external number for RMA</value>
        [DataMember(Name = "rmaExternalNumber", EmitDefaultValue = false)]
        public string RmaExternalNumber { get; set; }

        /// <summary>
        /// RMA item details
        /// </summary>
        /// <value>RMA item details</value>
        [DataMember(Name = "rmaItems", EmitDefaultValue = false)]
        public List<RmaItem> RmaItems { get; set; }

        /// <summary>
        /// the email address of the customer
        /// </summary>
        /// <value>the email address of the customer</value>
        [DataMember(Name = "email", EmitDefaultValue = false)]
        public string Email { get; set; }

        /// <summary>
        /// Gets or set the last name of the customer
        /// </summary>
        /// <value>Gets or set the last name of the customer</value>
        [DataMember(Name = "lastName", EmitDefaultValue = false)]
        public string LastName { get; set; }

        /// <summary>
        /// Gets or sets the Postal code of the customer billing address
        /// </summary>
        /// <value>Gets or sets the Postal code of the customer billing address</value>
        [DataMember(Name = "postalCode", EmitDefaultValue = false)]
        public string PostalCode { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateRmaGuestRequest {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  PropertyBag: ").Append(PropertyBag).Append("\n");
            sb.Append("  RmaExternalNumber: ").Append(RmaExternalNumber).Append("\n");
            sb.Append("  RmaItems: ").Append(RmaItems).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  LastName: ").Append(LastName).Append("\n");
            sb.Append("  PostalCode: ").Append(PostalCode).Append("\n");
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
            return this.Equals(input as CreateRmaGuestRequest);
        }

        /// <summary>
        /// Returns true if CreateRmaGuestRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of CreateRmaGuestRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateRmaGuestRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.PropertyBag == input.PropertyBag ||
                    this.PropertyBag != null &&
                    input.PropertyBag != null &&
                    this.PropertyBag.SequenceEqual(input.PropertyBag)
                ) && 
                (
                    this.RmaExternalNumber == input.RmaExternalNumber ||
                    (this.RmaExternalNumber != null &&
                    this.RmaExternalNumber.Equals(input.RmaExternalNumber))
                ) && 
                (
                    this.RmaItems == input.RmaItems ||
                    this.RmaItems != null &&
                    input.RmaItems != null &&
                    this.RmaItems.SequenceEqual(input.RmaItems)
                ) && 
                (
                    this.Email == input.Email ||
                    (this.Email != null &&
                    this.Email.Equals(input.Email))
                ) && 
                (
                    this.LastName == input.LastName ||
                    (this.LastName != null &&
                    this.LastName.Equals(input.LastName))
                ) && 
                (
                    this.PostalCode == input.PostalCode ||
                    (this.PostalCode != null &&
                    this.PostalCode.Equals(input.PostalCode))
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
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.PropertyBag != null)
                    hashCode = hashCode * 59 + this.PropertyBag.GetHashCode();
                if (this.RmaExternalNumber != null)
                    hashCode = hashCode * 59 + this.RmaExternalNumber.GetHashCode();
                if (this.RmaItems != null)
                    hashCode = hashCode * 59 + this.RmaItems.GetHashCode();
                if (this.Email != null)
                    hashCode = hashCode * 59 + this.Email.GetHashCode();
                if (this.LastName != null)
                    hashCode = hashCode * 59 + this.LastName.GetHashCode();
                if (this.PostalCode != null)
                    hashCode = hashCode * 59 + this.PostalCode.GetHashCode();
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
