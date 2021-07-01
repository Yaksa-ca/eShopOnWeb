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
    [DataContract(Name = "AddOrUpdateProductAuthorizationsByUsernameRequest")]
    public partial class AddOrUpdateProductAuthorizationsByUsernameRequest : IEquatable<AddOrUpdateProductAuthorizationsByUsernameRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AddOrUpdateProductAuthorizationsByUsernameRequest" /> class.
        /// </summary>
        /// <param name="username">Customer&#39;s username..</param>
        /// <param name="productAuthorizations">Product authorization(s) to be added or updated..</param>
        /// <param name="includeProductDetails">Whether to include the details of the products.</param>
        /// <param name="includeVariants">Whether to include the variants of the authorized products. IncludeProductDetails must be set to true for this to be considered.</param>
        /// <param name="cultureName">The culture name which dictates in which language localized values are returned in.</param>
        public AddOrUpdateProductAuthorizationsByUsernameRequest(string username = default(string), List<ProductIdAuthorization> productAuthorizations = default(List<ProductIdAuthorization>), bool includeProductDetails = default(bool), bool includeVariants = default(bool), string cultureName = default(string))
        {
            this.Username = username;
            this.ProductAuthorizations = productAuthorizations;
            this.IncludeProductDetails = includeProductDetails;
            this.IncludeVariants = includeVariants;
            this.CultureName = cultureName;
        }

        /// <summary>
        /// Customer&#39;s username.
        /// </summary>
        /// <value>Customer&#39;s username.</value>
        [DataMember(Name = "username", EmitDefaultValue = false)]
        public string Username { get; set; }

        /// <summary>
        /// Product authorization(s) to be added or updated.
        /// </summary>
        /// <value>Product authorization(s) to be added or updated.</value>
        [DataMember(Name = "productAuthorizations", EmitDefaultValue = false)]
        public List<ProductIdAuthorization> ProductAuthorizations { get; set; }

        /// <summary>
        /// Whether to include the details of the products
        /// </summary>
        /// <value>Whether to include the details of the products</value>
        [DataMember(Name = "includeProductDetails", EmitDefaultValue = true)]
        public bool IncludeProductDetails { get; set; }

        /// <summary>
        /// Whether to include the variants of the authorized products. IncludeProductDetails must be set to true for this to be considered
        /// </summary>
        /// <value>Whether to include the variants of the authorized products. IncludeProductDetails must be set to true for this to be considered</value>
        [DataMember(Name = "includeVariants", EmitDefaultValue = true)]
        public bool IncludeVariants { get; set; }

        /// <summary>
        /// The culture name which dictates in which language localized values are returned in
        /// </summary>
        /// <value>The culture name which dictates in which language localized values are returned in</value>
        [DataMember(Name = "cultureName", EmitDefaultValue = false)]
        public string CultureName { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AddOrUpdateProductAuthorizationsByUsernameRequest {\n");
            sb.Append("  Username: ").Append(Username).Append("\n");
            sb.Append("  ProductAuthorizations: ").Append(ProductAuthorizations).Append("\n");
            sb.Append("  IncludeProductDetails: ").Append(IncludeProductDetails).Append("\n");
            sb.Append("  IncludeVariants: ").Append(IncludeVariants).Append("\n");
            sb.Append("  CultureName: ").Append(CultureName).Append("\n");
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
            return this.Equals(input as AddOrUpdateProductAuthorizationsByUsernameRequest);
        }

        /// <summary>
        /// Returns true if AddOrUpdateProductAuthorizationsByUsernameRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of AddOrUpdateProductAuthorizationsByUsernameRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AddOrUpdateProductAuthorizationsByUsernameRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Username == input.Username ||
                    (this.Username != null &&
                    this.Username.Equals(input.Username))
                ) && 
                (
                    this.ProductAuthorizations == input.ProductAuthorizations ||
                    this.ProductAuthorizations != null &&
                    input.ProductAuthorizations != null &&
                    this.ProductAuthorizations.SequenceEqual(input.ProductAuthorizations)
                ) && 
                (
                    this.IncludeProductDetails == input.IncludeProductDetails ||
                    this.IncludeProductDetails.Equals(input.IncludeProductDetails)
                ) && 
                (
                    this.IncludeVariants == input.IncludeVariants ||
                    this.IncludeVariants.Equals(input.IncludeVariants)
                ) && 
                (
                    this.CultureName == input.CultureName ||
                    (this.CultureName != null &&
                    this.CultureName.Equals(input.CultureName))
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
                if (this.Username != null)
                    hashCode = hashCode * 59 + this.Username.GetHashCode();
                if (this.ProductAuthorizations != null)
                    hashCode = hashCode * 59 + this.ProductAuthorizations.GetHashCode();
                hashCode = hashCode * 59 + this.IncludeProductDetails.GetHashCode();
                hashCode = hashCode * 59 + this.IncludeVariants.GetHashCode();
                if (this.CultureName != null)
                    hashCode = hashCode * 59 + this.CultureName.GetHashCode();
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
