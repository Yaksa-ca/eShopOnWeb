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
    /// Addresses are entities which are used as a billing or shipping address for a cart or an order.
    /// </summary>
    [DataContract(Name = "UpdateAddressRequest")]
    public partial class UpdateAddressRequest : IEquatable<UpdateAddressRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateAddressRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected UpdateAddressRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateAddressRequest" /> class.
        /// </summary>
        /// <param name="addressName">Name of the address. A customer cannot have two addresses with the same name..</param>
        /// <param name="city">City of the address.</param>
        /// <param name="countryCode">2 letter country ISO code.</param>
        /// <param name="email">Email.</param>
        /// <param name="firstName">Resident first name.</param>
        /// <param name="isPreferredBilling">a boolean which specifies whether this address is the customer&#39;s preferred choice for Billing. (Only applicable to Customer addresses).</param>
        /// <param name="isPreferredShipping">a boolean which specifies whether this address is the customer&#39;s preferred choice for Shipping. (Only applicable to Customer addresses).</param>
        /// <param name="lastName">Resident last name.</param>
        /// <param name="latitude">Latitude coordinate of the Address.</param>
        /// <param name="line1">First line of the address.</param>
        /// <param name="line2">Second line of the address.</param>
        /// <param name="longitude">Longitude coordinate of the address.</param>
        /// <param name="notes">Notes.</param>
        /// <param name="phoneExtension">Phone extension of the address.</param>
        /// <param name="phoneNumber">Phone number of the address.</param>
        /// <param name="postalCode">Postal code of the address.</param>
        /// <param name="propertyBag">propertyBag.</param>
        /// <param name="regionCode">2 letter region ISO code.</param>
        /// <param name="relatedEntityId">The unique Id of the entity (such as a customer) that owns the address. (required).</param>
        /// <param name="relatedEntityType">The type string of the entity (such as a customer) that owns the address. (required).</param>
        public UpdateAddressRequest(string addressName = default(string), string city = default(string), string countryCode = default(string), string email = default(string), string firstName = default(string), bool isPreferredBilling = default(bool), bool isPreferredShipping = default(bool), string lastName = default(string), double latitude = default(double), string line1 = default(string), string line2 = default(string), double longitude = default(double), string notes = default(string), string phoneExtension = default(string), string phoneNumber = default(string), string postalCode = default(string), Dictionary<string, Object> propertyBag = default(Dictionary<string, Object>), string regionCode = default(string), string relatedEntityId = default(string), string relatedEntityType = default(string))
        {
            // to ensure "relatedEntityId" is required (not null)
            this.RelatedEntityId = relatedEntityId ?? throw new ArgumentNullException("relatedEntityId is a required property for UpdateAddressRequest and cannot be null");
            // to ensure "relatedEntityType" is required (not null)
            this.RelatedEntityType = relatedEntityType ?? throw new ArgumentNullException("relatedEntityType is a required property for UpdateAddressRequest and cannot be null");
            this.AddressName = addressName;
            this.City = city;
            this.CountryCode = countryCode;
            this.Email = email;
            this.FirstName = firstName;
            this.IsPreferredBilling = isPreferredBilling;
            this.IsPreferredShipping = isPreferredShipping;
            this.LastName = lastName;
            this.Latitude = latitude;
            this.Line1 = line1;
            this.Line2 = line2;
            this.Longitude = longitude;
            this.Notes = notes;
            this.PhoneExtension = phoneExtension;
            this.PhoneNumber = phoneNumber;
            this.PostalCode = postalCode;
            this.PropertyBag = propertyBag;
            this.RegionCode = regionCode;
        }

        /// <summary>
        /// Name of the address. A customer cannot have two addresses with the same name.
        /// </summary>
        /// <value>Name of the address. A customer cannot have two addresses with the same name.</value>
        [DataMember(Name = "addressName", EmitDefaultValue = false)]
        public string AddressName { get; set; }

        /// <summary>
        /// City of the address
        /// </summary>
        /// <value>City of the address</value>
        [DataMember(Name = "city", EmitDefaultValue = false)]
        public string City { get; set; }

        /// <summary>
        /// 2 letter country ISO code
        /// </summary>
        /// <value>2 letter country ISO code</value>
        [DataMember(Name = "countryCode", EmitDefaultValue = false)]
        public string CountryCode { get; set; }

        /// <summary>
        /// Email
        /// </summary>
        /// <value>Email</value>
        [DataMember(Name = "email", EmitDefaultValue = false)]
        public string Email { get; set; }

        /// <summary>
        /// Resident first name
        /// </summary>
        /// <value>Resident first name</value>
        [DataMember(Name = "firstName", EmitDefaultValue = false)]
        public string FirstName { get; set; }

        /// <summary>
        /// a boolean which specifies whether this address is the customer&#39;s preferred choice for Billing. (Only applicable to Customer addresses)
        /// </summary>
        /// <value>a boolean which specifies whether this address is the customer&#39;s preferred choice for Billing. (Only applicable to Customer addresses)</value>
        [DataMember(Name = "isPreferredBilling", EmitDefaultValue = true)]
        public bool IsPreferredBilling { get; set; }

        /// <summary>
        /// a boolean which specifies whether this address is the customer&#39;s preferred choice for Shipping. (Only applicable to Customer addresses)
        /// </summary>
        /// <value>a boolean which specifies whether this address is the customer&#39;s preferred choice for Shipping. (Only applicable to Customer addresses)</value>
        [DataMember(Name = "isPreferredShipping", EmitDefaultValue = true)]
        public bool IsPreferredShipping { get; set; }

        /// <summary>
        /// Resident last name
        /// </summary>
        /// <value>Resident last name</value>
        [DataMember(Name = "lastName", EmitDefaultValue = false)]
        public string LastName { get; set; }

        /// <summary>
        /// Latitude coordinate of the Address
        /// </summary>
        /// <value>Latitude coordinate of the Address</value>
        [DataMember(Name = "latitude", EmitDefaultValue = false)]
        public double Latitude { get; set; }

        /// <summary>
        /// First line of the address
        /// </summary>
        /// <value>First line of the address</value>
        [DataMember(Name = "line1", EmitDefaultValue = false)]
        public string Line1 { get; set; }

        /// <summary>
        /// Second line of the address
        /// </summary>
        /// <value>Second line of the address</value>
        [DataMember(Name = "line2", EmitDefaultValue = false)]
        public string Line2 { get; set; }

        /// <summary>
        /// Longitude coordinate of the address
        /// </summary>
        /// <value>Longitude coordinate of the address</value>
        [DataMember(Name = "longitude", EmitDefaultValue = false)]
        public double Longitude { get; set; }

        /// <summary>
        /// Notes
        /// </summary>
        /// <value>Notes</value>
        [DataMember(Name = "notes", EmitDefaultValue = false)]
        public string Notes { get; set; }

        /// <summary>
        /// Phone extension of the address
        /// </summary>
        /// <value>Phone extension of the address</value>
        [DataMember(Name = "phoneExtension", EmitDefaultValue = false)]
        public string PhoneExtension { get; set; }

        /// <summary>
        /// Phone number of the address
        /// </summary>
        /// <value>Phone number of the address</value>
        [DataMember(Name = "phoneNumber", EmitDefaultValue = false)]
        public string PhoneNumber { get; set; }

        /// <summary>
        /// Postal code of the address
        /// </summary>
        /// <value>Postal code of the address</value>
        [DataMember(Name = "postalCode", EmitDefaultValue = false)]
        public string PostalCode { get; set; }

        /// <summary>
        /// Gets or Sets PropertyBag
        /// </summary>
        [DataMember(Name = "propertyBag", EmitDefaultValue = false)]
        public Dictionary<string, Object> PropertyBag { get; set; }

        /// <summary>
        /// 2 letter region ISO code
        /// </summary>
        /// <value>2 letter region ISO code</value>
        [DataMember(Name = "regionCode", EmitDefaultValue = false)]
        public string RegionCode { get; set; }

        /// <summary>
        /// The unique Id of the entity (such as a customer) that owns the address.
        /// </summary>
        /// <value>The unique Id of the entity (such as a customer) that owns the address.</value>
        [DataMember(Name = "relatedEntityId", IsRequired = true, EmitDefaultValue = false)]
        public string RelatedEntityId { get; set; }

        /// <summary>
        /// The type string of the entity (such as a customer) that owns the address.
        /// </summary>
        /// <value>The type string of the entity (such as a customer) that owns the address.</value>
        [DataMember(Name = "relatedEntityType", IsRequired = true, EmitDefaultValue = false)]
        public string RelatedEntityType { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateAddressRequest {\n");
            sb.Append("  AddressName: ").Append(AddressName).Append("\n");
            sb.Append("  City: ").Append(City).Append("\n");
            sb.Append("  CountryCode: ").Append(CountryCode).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  FirstName: ").Append(FirstName).Append("\n");
            sb.Append("  IsPreferredBilling: ").Append(IsPreferredBilling).Append("\n");
            sb.Append("  IsPreferredShipping: ").Append(IsPreferredShipping).Append("\n");
            sb.Append("  LastName: ").Append(LastName).Append("\n");
            sb.Append("  Latitude: ").Append(Latitude).Append("\n");
            sb.Append("  Line1: ").Append(Line1).Append("\n");
            sb.Append("  Line2: ").Append(Line2).Append("\n");
            sb.Append("  Longitude: ").Append(Longitude).Append("\n");
            sb.Append("  Notes: ").Append(Notes).Append("\n");
            sb.Append("  PhoneExtension: ").Append(PhoneExtension).Append("\n");
            sb.Append("  PhoneNumber: ").Append(PhoneNumber).Append("\n");
            sb.Append("  PostalCode: ").Append(PostalCode).Append("\n");
            sb.Append("  PropertyBag: ").Append(PropertyBag).Append("\n");
            sb.Append("  RegionCode: ").Append(RegionCode).Append("\n");
            sb.Append("  RelatedEntityId: ").Append(RelatedEntityId).Append("\n");
            sb.Append("  RelatedEntityType: ").Append(RelatedEntityType).Append("\n");
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
            return this.Equals(input as UpdateAddressRequest);
        }

        /// <summary>
        /// Returns true if UpdateAddressRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of UpdateAddressRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UpdateAddressRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AddressName == input.AddressName ||
                    (this.AddressName != null &&
                    this.AddressName.Equals(input.AddressName))
                ) && 
                (
                    this.City == input.City ||
                    (this.City != null &&
                    this.City.Equals(input.City))
                ) && 
                (
                    this.CountryCode == input.CountryCode ||
                    (this.CountryCode != null &&
                    this.CountryCode.Equals(input.CountryCode))
                ) && 
                (
                    this.Email == input.Email ||
                    (this.Email != null &&
                    this.Email.Equals(input.Email))
                ) && 
                (
                    this.FirstName == input.FirstName ||
                    (this.FirstName != null &&
                    this.FirstName.Equals(input.FirstName))
                ) && 
                (
                    this.IsPreferredBilling == input.IsPreferredBilling ||
                    this.IsPreferredBilling.Equals(input.IsPreferredBilling)
                ) && 
                (
                    this.IsPreferredShipping == input.IsPreferredShipping ||
                    this.IsPreferredShipping.Equals(input.IsPreferredShipping)
                ) && 
                (
                    this.LastName == input.LastName ||
                    (this.LastName != null &&
                    this.LastName.Equals(input.LastName))
                ) && 
                (
                    this.Latitude == input.Latitude ||
                    this.Latitude.Equals(input.Latitude)
                ) && 
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
                    this.Longitude == input.Longitude ||
                    this.Longitude.Equals(input.Longitude)
                ) && 
                (
                    this.Notes == input.Notes ||
                    (this.Notes != null &&
                    this.Notes.Equals(input.Notes))
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
                    this.PostalCode == input.PostalCode ||
                    (this.PostalCode != null &&
                    this.PostalCode.Equals(input.PostalCode))
                ) && 
                (
                    this.PropertyBag == input.PropertyBag ||
                    this.PropertyBag != null &&
                    input.PropertyBag != null &&
                    this.PropertyBag.SequenceEqual(input.PropertyBag)
                ) && 
                (
                    this.RegionCode == input.RegionCode ||
                    (this.RegionCode != null &&
                    this.RegionCode.Equals(input.RegionCode))
                ) && 
                (
                    this.RelatedEntityId == input.RelatedEntityId ||
                    (this.RelatedEntityId != null &&
                    this.RelatedEntityId.Equals(input.RelatedEntityId))
                ) && 
                (
                    this.RelatedEntityType == input.RelatedEntityType ||
                    (this.RelatedEntityType != null &&
                    this.RelatedEntityType.Equals(input.RelatedEntityType))
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
                if (this.AddressName != null)
                    hashCode = hashCode * 59 + this.AddressName.GetHashCode();
                if (this.City != null)
                    hashCode = hashCode * 59 + this.City.GetHashCode();
                if (this.CountryCode != null)
                    hashCode = hashCode * 59 + this.CountryCode.GetHashCode();
                if (this.Email != null)
                    hashCode = hashCode * 59 + this.Email.GetHashCode();
                if (this.FirstName != null)
                    hashCode = hashCode * 59 + this.FirstName.GetHashCode();
                hashCode = hashCode * 59 + this.IsPreferredBilling.GetHashCode();
                hashCode = hashCode * 59 + this.IsPreferredShipping.GetHashCode();
                if (this.LastName != null)
                    hashCode = hashCode * 59 + this.LastName.GetHashCode();
                hashCode = hashCode * 59 + this.Latitude.GetHashCode();
                if (this.Line1 != null)
                    hashCode = hashCode * 59 + this.Line1.GetHashCode();
                if (this.Line2 != null)
                    hashCode = hashCode * 59 + this.Line2.GetHashCode();
                hashCode = hashCode * 59 + this.Longitude.GetHashCode();
                if (this.Notes != null)
                    hashCode = hashCode * 59 + this.Notes.GetHashCode();
                if (this.PhoneExtension != null)
                    hashCode = hashCode * 59 + this.PhoneExtension.GetHashCode();
                if (this.PhoneNumber != null)
                    hashCode = hashCode * 59 + this.PhoneNumber.GetHashCode();
                if (this.PostalCode != null)
                    hashCode = hashCode * 59 + this.PostalCode.GetHashCode();
                if (this.PropertyBag != null)
                    hashCode = hashCode * 59 + this.PropertyBag.GetHashCode();
                if (this.RegionCode != null)
                    hashCode = hashCode * 59 + this.RegionCode.GetHashCode();
                if (this.RelatedEntityId != null)
                    hashCode = hashCode * 59 + this.RelatedEntityId.GetHashCode();
                if (this.RelatedEntityType != null)
                    hashCode = hashCode * 59 + this.RelatedEntityType.GetHashCode();
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
