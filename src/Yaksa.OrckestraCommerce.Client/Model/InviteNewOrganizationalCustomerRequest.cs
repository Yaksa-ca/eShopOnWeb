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
    /// Regroupment of all custom CDMV services, notably for clinics related operations
    /// </summary>
    [DataContract(Name = "InviteNewOrganizationalCustomerRequest")]
    public partial class InviteNewOrganizationalCustomerRequest : IEquatable<InviteNewOrganizationalCustomerRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InviteNewOrganizationalCustomerRequest" /> class.
        /// </summary>
        /// <param name="firstName">The customer&#39;s first name..</param>
        /// <param name="lastName">The customer&#39;s last name..</param>
        /// <param name="emailAddress">The customer&#39;s email address.</param>
        /// <param name="language">The customer&#39;s preferred language..</param>
        /// <param name="productIdAuthorizations">The list of product authorizations that will be added to his account. The status here is meaningless and its value will be ignored, as it will always default to Authorized when the customer creates his account.</param>
        public InviteNewOrganizationalCustomerRequest(string firstName = default(string), string lastName = default(string), string emailAddress = default(string), string language = default(string), List<ProductIdAuthorization> productIdAuthorizations = default(List<ProductIdAuthorization>))
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.EmailAddress = emailAddress;
            this.Language = language;
            this.ProductIdAuthorizations = productIdAuthorizations;
        }

        /// <summary>
        /// The customer&#39;s first name.
        /// </summary>
        /// <value>The customer&#39;s first name.</value>
        [DataMember(Name = "firstName", EmitDefaultValue = false)]
        public string FirstName { get; set; }

        /// <summary>
        /// The customer&#39;s last name.
        /// </summary>
        /// <value>The customer&#39;s last name.</value>
        [DataMember(Name = "lastName", EmitDefaultValue = false)]
        public string LastName { get; set; }

        /// <summary>
        /// The customer&#39;s email address
        /// </summary>
        /// <value>The customer&#39;s email address</value>
        [DataMember(Name = "emailAddress", EmitDefaultValue = false)]
        public string EmailAddress { get; set; }

        /// <summary>
        /// The customer&#39;s preferred language.
        /// </summary>
        /// <value>The customer&#39;s preferred language.</value>
        [DataMember(Name = "language", EmitDefaultValue = false)]
        public string Language { get; set; }

        /// <summary>
        /// The list of product authorizations that will be added to his account. The status here is meaningless and its value will be ignored, as it will always default to Authorized when the customer creates his account
        /// </summary>
        /// <value>The list of product authorizations that will be added to his account. The status here is meaningless and its value will be ignored, as it will always default to Authorized when the customer creates his account</value>
        [DataMember(Name = "productIdAuthorizations", EmitDefaultValue = false)]
        public List<ProductIdAuthorization> ProductIdAuthorizations { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InviteNewOrganizationalCustomerRequest {\n");
            sb.Append("  FirstName: ").Append(FirstName).Append("\n");
            sb.Append("  LastName: ").Append(LastName).Append("\n");
            sb.Append("  EmailAddress: ").Append(EmailAddress).Append("\n");
            sb.Append("  Language: ").Append(Language).Append("\n");
            sb.Append("  ProductIdAuthorizations: ").Append(ProductIdAuthorizations).Append("\n");
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
            return this.Equals(input as InviteNewOrganizationalCustomerRequest);
        }

        /// <summary>
        /// Returns true if InviteNewOrganizationalCustomerRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of InviteNewOrganizationalCustomerRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InviteNewOrganizationalCustomerRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.FirstName == input.FirstName ||
                    (this.FirstName != null &&
                    this.FirstName.Equals(input.FirstName))
                ) && 
                (
                    this.LastName == input.LastName ||
                    (this.LastName != null &&
                    this.LastName.Equals(input.LastName))
                ) && 
                (
                    this.EmailAddress == input.EmailAddress ||
                    (this.EmailAddress != null &&
                    this.EmailAddress.Equals(input.EmailAddress))
                ) && 
                (
                    this.Language == input.Language ||
                    (this.Language != null &&
                    this.Language.Equals(input.Language))
                ) && 
                (
                    this.ProductIdAuthorizations == input.ProductIdAuthorizations ||
                    this.ProductIdAuthorizations != null &&
                    input.ProductIdAuthorizations != null &&
                    this.ProductIdAuthorizations.SequenceEqual(input.ProductIdAuthorizations)
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
                if (this.FirstName != null)
                    hashCode = hashCode * 59 + this.FirstName.GetHashCode();
                if (this.LastName != null)
                    hashCode = hashCode * 59 + this.LastName.GetHashCode();
                if (this.EmailAddress != null)
                    hashCode = hashCode * 59 + this.EmailAddress.GetHashCode();
                if (this.Language != null)
                    hashCode = hashCode * 59 + this.Language.GetHashCode();
                if (this.ProductIdAuthorizations != null)
                    hashCode = hashCode * 59 + this.ProductIdAuthorizations.GetHashCode();
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
