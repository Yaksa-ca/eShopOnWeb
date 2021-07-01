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
    /// User
    /// </summary>
    [DataContract(Name = "User")]
    public partial class User : IEquatable<User>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="User" /> class.
        /// </summary>
        /// <param name="address">the address..</param>
        /// <param name="city">the city..</param>
        /// <param name="country">the country..</param>
        /// <param name="department">the department..</param>
        /// <param name="displayName">the display name..</param>
        /// <param name="enabled">a value indicating whether or not user is enabled..</param>
        /// <param name="firstName">the first name..</param>
        /// <param name="jobTitle">the job title..</param>
        /// <param name="lastName">the last name..</param>
        /// <param name="mobile">the mobile..</param>
        /// <param name="passwordProfile">passwordProfile.</param>
        /// <param name="phone">the phone..</param>
        /// <param name="postalCode">the postal code..</param>
        /// <param name="preferredLanguage">the preferred language..</param>
        /// <param name="state">the state..</param>
        /// <param name="userId">the user identifier..</param>
        /// <param name="userName">the name of the user..</param>
        public User(string address = default(string), string city = default(string), string country = default(string), string department = default(string), string displayName = default(string), bool enabled = default(bool), string firstName = default(string), string jobTitle = default(string), string lastName = default(string), string mobile = default(string), PasswordProfile passwordProfile = default(PasswordProfile), string phone = default(string), string postalCode = default(string), string preferredLanguage = default(string), string state = default(string), string userId = default(string), string userName = default(string))
        {
            this.Address = address;
            this.City = city;
            this.Country = country;
            this.Department = department;
            this.DisplayName = displayName;
            this.Enabled = enabled;
            this.FirstName = firstName;
            this.JobTitle = jobTitle;
            this.LastName = lastName;
            this.Mobile = mobile;
            this.PasswordProfile = passwordProfile;
            this.Phone = phone;
            this.PostalCode = postalCode;
            this.PreferredLanguage = preferredLanguage;
            this.State = state;
            this.UserId = userId;
            this.UserName = userName;
        }

        /// <summary>
        /// the address.
        /// </summary>
        /// <value>the address.</value>
        [DataMember(Name = "address", EmitDefaultValue = false)]
        public string Address { get; set; }

        /// <summary>
        /// the city.
        /// </summary>
        /// <value>the city.</value>
        [DataMember(Name = "city", EmitDefaultValue = false)]
        public string City { get; set; }

        /// <summary>
        /// the country.
        /// </summary>
        /// <value>the country.</value>
        [DataMember(Name = "country", EmitDefaultValue = false)]
        public string Country { get; set; }

        /// <summary>
        /// the department.
        /// </summary>
        /// <value>the department.</value>
        [DataMember(Name = "department", EmitDefaultValue = false)]
        public string Department { get; set; }

        /// <summary>
        /// the display name.
        /// </summary>
        /// <value>the display name.</value>
        [DataMember(Name = "displayName", EmitDefaultValue = false)]
        public string DisplayName { get; set; }

        /// <summary>
        /// a value indicating whether or not user is enabled.
        /// </summary>
        /// <value>a value indicating whether or not user is enabled.</value>
        [DataMember(Name = "enabled", EmitDefaultValue = true)]
        public bool Enabled { get; set; }

        /// <summary>
        /// the first name.
        /// </summary>
        /// <value>the first name.</value>
        [DataMember(Name = "firstName", EmitDefaultValue = false)]
        public string FirstName { get; set; }

        /// <summary>
        /// the job title.
        /// </summary>
        /// <value>the job title.</value>
        [DataMember(Name = "jobTitle", EmitDefaultValue = false)]
        public string JobTitle { get; set; }

        /// <summary>
        /// the last name.
        /// </summary>
        /// <value>the last name.</value>
        [DataMember(Name = "lastName", EmitDefaultValue = false)]
        public string LastName { get; set; }

        /// <summary>
        /// the mobile.
        /// </summary>
        /// <value>the mobile.</value>
        [DataMember(Name = "mobile", EmitDefaultValue = false)]
        public string Mobile { get; set; }

        /// <summary>
        /// Gets or Sets PasswordProfile
        /// </summary>
        [DataMember(Name = "passwordProfile", EmitDefaultValue = false)]
        public PasswordProfile PasswordProfile { get; set; }

        /// <summary>
        /// the phone.
        /// </summary>
        /// <value>the phone.</value>
        [DataMember(Name = "phone", EmitDefaultValue = false)]
        public string Phone { get; set; }

        /// <summary>
        /// the postal code.
        /// </summary>
        /// <value>the postal code.</value>
        [DataMember(Name = "postalCode", EmitDefaultValue = false)]
        public string PostalCode { get; set; }

        /// <summary>
        /// the preferred language.
        /// </summary>
        /// <value>the preferred language.</value>
        [DataMember(Name = "preferredLanguage", EmitDefaultValue = false)]
        public string PreferredLanguage { get; set; }

        /// <summary>
        /// the state.
        /// </summary>
        /// <value>the state.</value>
        [DataMember(Name = "state", EmitDefaultValue = false)]
        public string State { get; set; }

        /// <summary>
        /// the user identifier.
        /// </summary>
        /// <value>the user identifier.</value>
        [DataMember(Name = "userId", EmitDefaultValue = false)]
        public string UserId { get; set; }

        /// <summary>
        /// the name of the user.
        /// </summary>
        /// <value>the name of the user.</value>
        [DataMember(Name = "userName", EmitDefaultValue = false)]
        public string UserName { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class User {\n");
            sb.Append("  Address: ").Append(Address).Append("\n");
            sb.Append("  City: ").Append(City).Append("\n");
            sb.Append("  Country: ").Append(Country).Append("\n");
            sb.Append("  Department: ").Append(Department).Append("\n");
            sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
            sb.Append("  Enabled: ").Append(Enabled).Append("\n");
            sb.Append("  FirstName: ").Append(FirstName).Append("\n");
            sb.Append("  JobTitle: ").Append(JobTitle).Append("\n");
            sb.Append("  LastName: ").Append(LastName).Append("\n");
            sb.Append("  Mobile: ").Append(Mobile).Append("\n");
            sb.Append("  PasswordProfile: ").Append(PasswordProfile).Append("\n");
            sb.Append("  Phone: ").Append(Phone).Append("\n");
            sb.Append("  PostalCode: ").Append(PostalCode).Append("\n");
            sb.Append("  PreferredLanguage: ").Append(PreferredLanguage).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  UserId: ").Append(UserId).Append("\n");
            sb.Append("  UserName: ").Append(UserName).Append("\n");
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
            return this.Equals(input as User);
        }

        /// <summary>
        /// Returns true if User instances are equal
        /// </summary>
        /// <param name="input">Instance of User to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(User input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Address == input.Address ||
                    (this.Address != null &&
                    this.Address.Equals(input.Address))
                ) && 
                (
                    this.City == input.City ||
                    (this.City != null &&
                    this.City.Equals(input.City))
                ) && 
                (
                    this.Country == input.Country ||
                    (this.Country != null &&
                    this.Country.Equals(input.Country))
                ) && 
                (
                    this.Department == input.Department ||
                    (this.Department != null &&
                    this.Department.Equals(input.Department))
                ) && 
                (
                    this.DisplayName == input.DisplayName ||
                    (this.DisplayName != null &&
                    this.DisplayName.Equals(input.DisplayName))
                ) && 
                (
                    this.Enabled == input.Enabled ||
                    this.Enabled.Equals(input.Enabled)
                ) && 
                (
                    this.FirstName == input.FirstName ||
                    (this.FirstName != null &&
                    this.FirstName.Equals(input.FirstName))
                ) && 
                (
                    this.JobTitle == input.JobTitle ||
                    (this.JobTitle != null &&
                    this.JobTitle.Equals(input.JobTitle))
                ) && 
                (
                    this.LastName == input.LastName ||
                    (this.LastName != null &&
                    this.LastName.Equals(input.LastName))
                ) && 
                (
                    this.Mobile == input.Mobile ||
                    (this.Mobile != null &&
                    this.Mobile.Equals(input.Mobile))
                ) && 
                (
                    this.PasswordProfile == input.PasswordProfile ||
                    (this.PasswordProfile != null &&
                    this.PasswordProfile.Equals(input.PasswordProfile))
                ) && 
                (
                    this.Phone == input.Phone ||
                    (this.Phone != null &&
                    this.Phone.Equals(input.Phone))
                ) && 
                (
                    this.PostalCode == input.PostalCode ||
                    (this.PostalCode != null &&
                    this.PostalCode.Equals(input.PostalCode))
                ) && 
                (
                    this.PreferredLanguage == input.PreferredLanguage ||
                    (this.PreferredLanguage != null &&
                    this.PreferredLanguage.Equals(input.PreferredLanguage))
                ) && 
                (
                    this.State == input.State ||
                    (this.State != null &&
                    this.State.Equals(input.State))
                ) && 
                (
                    this.UserId == input.UserId ||
                    (this.UserId != null &&
                    this.UserId.Equals(input.UserId))
                ) && 
                (
                    this.UserName == input.UserName ||
                    (this.UserName != null &&
                    this.UserName.Equals(input.UserName))
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
                if (this.Address != null)
                    hashCode = hashCode * 59 + this.Address.GetHashCode();
                if (this.City != null)
                    hashCode = hashCode * 59 + this.City.GetHashCode();
                if (this.Country != null)
                    hashCode = hashCode * 59 + this.Country.GetHashCode();
                if (this.Department != null)
                    hashCode = hashCode * 59 + this.Department.GetHashCode();
                if (this.DisplayName != null)
                    hashCode = hashCode * 59 + this.DisplayName.GetHashCode();
                hashCode = hashCode * 59 + this.Enabled.GetHashCode();
                if (this.FirstName != null)
                    hashCode = hashCode * 59 + this.FirstName.GetHashCode();
                if (this.JobTitle != null)
                    hashCode = hashCode * 59 + this.JobTitle.GetHashCode();
                if (this.LastName != null)
                    hashCode = hashCode * 59 + this.LastName.GetHashCode();
                if (this.Mobile != null)
                    hashCode = hashCode * 59 + this.Mobile.GetHashCode();
                if (this.PasswordProfile != null)
                    hashCode = hashCode * 59 + this.PasswordProfile.GetHashCode();
                if (this.Phone != null)
                    hashCode = hashCode * 59 + this.Phone.GetHashCode();
                if (this.PostalCode != null)
                    hashCode = hashCode * 59 + this.PostalCode.GetHashCode();
                if (this.PreferredLanguage != null)
                    hashCode = hashCode * 59 + this.PreferredLanguage.GetHashCode();
                if (this.State != null)
                    hashCode = hashCode * 59 + this.State.GetHashCode();
                if (this.UserId != null)
                    hashCode = hashCode * 59 + this.UserId.GetHashCode();
                if (this.UserName != null)
                    hashCode = hashCode * 59 + this.UserName.GetHashCode();
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
