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
    /// Products are entities which represents a buyable item managed in a catalog.
    /// </summary>
    [DataContract(Name = "GetProductV2Request")]
    public partial class GetProductV2Request : IEquatable<GetProductV2Request>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetProductV2Request" /> class.
        /// </summary>
        /// <param name="scopeId">The id of the requested scope.</param>
        /// <param name="cultureName">The culture name in which language the data will be returned.</param>
        /// <param name="includeVariants">whether or not to include the variants (if they exists) of the product..</param>
        /// <param name="includeMedia"> Gets or sets a value indicating whether or not to include the media of the product..</param>
        /// <param name="includePriceLists">whether or not to include the price lists of the product..</param>
        /// <param name="includeRelationships"> Gets or sets a value indicating whether or not to include the relationships of the product..</param>
        /// <param name="includeImageUrl">A value indicating whether or not to include the image url..</param>
        /// <param name="includeInheritanceInformation">A value indicating whether to include the list of overridden properties and variants. Applicable for sales scopes..</param>
        /// <param name="productId">The business id for the product to retrieve.</param>
        /// <param name="publishedVersion">A value indicating whether the published version of the product should be returned..</param>
        public GetProductV2Request(string scopeId = default(string), string cultureName = default(string), bool includeVariants = default(bool), bool includeMedia = default(bool), bool includePriceLists = default(bool), bool includeRelationships = default(bool), bool includeImageUrl = default(bool), bool includeInheritanceInformation = default(bool), string productId = default(string), bool publishedVersion = default(bool))
        {
            this.ScopeId = scopeId;
            this.CultureName = cultureName;
            this.IncludeVariants = includeVariants;
            this.IncludeMedia = includeMedia;
            this.IncludePriceLists = includePriceLists;
            this.IncludeRelationships = includeRelationships;
            this.IncludeImageUrl = includeImageUrl;
            this.IncludeInheritanceInformation = includeInheritanceInformation;
            this.ProductId = productId;
            this.PublishedVersion = publishedVersion;
        }

        /// <summary>
        /// The id of the requested scope
        /// </summary>
        /// <value>The id of the requested scope</value>
        [DataMember(Name = "scopeId", EmitDefaultValue = false)]
        public string ScopeId { get; set; }

        /// <summary>
        /// The culture name in which language the data will be returned
        /// </summary>
        /// <value>The culture name in which language the data will be returned</value>
        [DataMember(Name = "cultureName", EmitDefaultValue = false)]
        public string CultureName { get; set; }

        /// <summary>
        /// whether or not to include the variants (if they exists) of the product.
        /// </summary>
        /// <value>whether or not to include the variants (if they exists) of the product.</value>
        [DataMember(Name = "includeVariants", EmitDefaultValue = true)]
        public bool IncludeVariants { get; set; }

        /// <summary>
        ///  Gets or sets a value indicating whether or not to include the media of the product.
        /// </summary>
        /// <value> Gets or sets a value indicating whether or not to include the media of the product.</value>
        [DataMember(Name = "includeMedia", EmitDefaultValue = true)]
        public bool IncludeMedia { get; set; }

        /// <summary>
        /// whether or not to include the price lists of the product.
        /// </summary>
        /// <value>whether or not to include the price lists of the product.</value>
        [DataMember(Name = "includePriceLists", EmitDefaultValue = true)]
        public bool IncludePriceLists { get; set; }

        /// <summary>
        ///  Gets or sets a value indicating whether or not to include the relationships of the product.
        /// </summary>
        /// <value> Gets or sets a value indicating whether or not to include the relationships of the product.</value>
        [DataMember(Name = "includeRelationships", EmitDefaultValue = true)]
        public bool IncludeRelationships { get; set; }

        /// <summary>
        /// A value indicating whether or not to include the image url.
        /// </summary>
        /// <value>A value indicating whether or not to include the image url.</value>
        [DataMember(Name = "includeImageUrl", EmitDefaultValue = true)]
        public bool IncludeImageUrl { get; set; }

        /// <summary>
        /// A value indicating whether to include the list of overridden properties and variants. Applicable for sales scopes.
        /// </summary>
        /// <value>A value indicating whether to include the list of overridden properties and variants. Applicable for sales scopes.</value>
        [DataMember(Name = "includeInheritanceInformation", EmitDefaultValue = true)]
        public bool IncludeInheritanceInformation { get; set; }

        /// <summary>
        /// The business id for the product to retrieve
        /// </summary>
        /// <value>The business id for the product to retrieve</value>
        [DataMember(Name = "productId", EmitDefaultValue = false)]
        public string ProductId { get; set; }

        /// <summary>
        /// A value indicating whether the published version of the product should be returned.
        /// </summary>
        /// <value>A value indicating whether the published version of the product should be returned.</value>
        [DataMember(Name = "publishedVersion", EmitDefaultValue = true)]
        public bool PublishedVersion { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GetProductV2Request {\n");
            sb.Append("  ScopeId: ").Append(ScopeId).Append("\n");
            sb.Append("  CultureName: ").Append(CultureName).Append("\n");
            sb.Append("  IncludeVariants: ").Append(IncludeVariants).Append("\n");
            sb.Append("  IncludeMedia: ").Append(IncludeMedia).Append("\n");
            sb.Append("  IncludePriceLists: ").Append(IncludePriceLists).Append("\n");
            sb.Append("  IncludeRelationships: ").Append(IncludeRelationships).Append("\n");
            sb.Append("  IncludeImageUrl: ").Append(IncludeImageUrl).Append("\n");
            sb.Append("  IncludeInheritanceInformation: ").Append(IncludeInheritanceInformation).Append("\n");
            sb.Append("  ProductId: ").Append(ProductId).Append("\n");
            sb.Append("  PublishedVersion: ").Append(PublishedVersion).Append("\n");
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
            return this.Equals(input as GetProductV2Request);
        }

        /// <summary>
        /// Returns true if GetProductV2Request instances are equal
        /// </summary>
        /// <param name="input">Instance of GetProductV2Request to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetProductV2Request input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ScopeId == input.ScopeId ||
                    (this.ScopeId != null &&
                    this.ScopeId.Equals(input.ScopeId))
                ) && 
                (
                    this.CultureName == input.CultureName ||
                    (this.CultureName != null &&
                    this.CultureName.Equals(input.CultureName))
                ) && 
                (
                    this.IncludeVariants == input.IncludeVariants ||
                    this.IncludeVariants.Equals(input.IncludeVariants)
                ) && 
                (
                    this.IncludeMedia == input.IncludeMedia ||
                    this.IncludeMedia.Equals(input.IncludeMedia)
                ) && 
                (
                    this.IncludePriceLists == input.IncludePriceLists ||
                    this.IncludePriceLists.Equals(input.IncludePriceLists)
                ) && 
                (
                    this.IncludeRelationships == input.IncludeRelationships ||
                    this.IncludeRelationships.Equals(input.IncludeRelationships)
                ) && 
                (
                    this.IncludeImageUrl == input.IncludeImageUrl ||
                    this.IncludeImageUrl.Equals(input.IncludeImageUrl)
                ) && 
                (
                    this.IncludeInheritanceInformation == input.IncludeInheritanceInformation ||
                    this.IncludeInheritanceInformation.Equals(input.IncludeInheritanceInformation)
                ) && 
                (
                    this.ProductId == input.ProductId ||
                    (this.ProductId != null &&
                    this.ProductId.Equals(input.ProductId))
                ) && 
                (
                    this.PublishedVersion == input.PublishedVersion ||
                    this.PublishedVersion.Equals(input.PublishedVersion)
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
                if (this.ScopeId != null)
                    hashCode = hashCode * 59 + this.ScopeId.GetHashCode();
                if (this.CultureName != null)
                    hashCode = hashCode * 59 + this.CultureName.GetHashCode();
                hashCode = hashCode * 59 + this.IncludeVariants.GetHashCode();
                hashCode = hashCode * 59 + this.IncludeMedia.GetHashCode();
                hashCode = hashCode * 59 + this.IncludePriceLists.GetHashCode();
                hashCode = hashCode * 59 + this.IncludeRelationships.GetHashCode();
                hashCode = hashCode * 59 + this.IncludeImageUrl.GetHashCode();
                hashCode = hashCode * 59 + this.IncludeInheritanceInformation.GetHashCode();
                if (this.ProductId != null)
                    hashCode = hashCode * 59 + this.ProductId.GetHashCode();
                hashCode = hashCode * 59 + this.PublishedVersion.GetHashCode();
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
