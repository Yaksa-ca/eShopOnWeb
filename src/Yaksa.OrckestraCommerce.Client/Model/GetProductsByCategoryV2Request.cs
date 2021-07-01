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
    /// Categories are entities which represents a classification of products.
    /// </summary>
    [DataContract(Name = "GetProductsByCategoryV2Request")]
    public partial class GetProductsByCategoryV2Request : IEquatable<GetProductsByCategoryV2Request>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetProductsByCategoryV2Request" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GetProductsByCategoryV2Request() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="GetProductsByCategoryV2Request" /> class.
        /// </summary>
        /// <param name="scopeId">The id of the requested scope.</param>
        /// <param name="cultureName">The culture name in which language the data will be returned.</param>
        /// <param name="includeVariants">whether or not to include the variants (if they exists) of the product..</param>
        /// <param name="includeMedia"> Gets or sets a value indicating whether or not to include the media of the product..</param>
        /// <param name="includePriceLists">whether or not to include the price lists of the product..</param>
        /// <param name="includeRelationships"> Gets or sets a value indicating whether or not to include the relationships of the product..</param>
        /// <param name="categoryId">The category id at which point in the category hierarchy should the &#39;get products&#39; be started. (required).</param>
        /// <param name="continuationToken">The continuation token used for pagination.</param>
        /// <param name="pageSize">The maximum number of products to return. Default value : 10.</param>
        public GetProductsByCategoryV2Request(string scopeId = default(string), string cultureName = default(string), bool includeVariants = default(bool), bool includeMedia = default(bool), bool includePriceLists = default(bool), bool includeRelationships = default(bool), string categoryId = default(string), string continuationToken = default(string), int pageSize = default(int))
        {
            // to ensure "categoryId" is required (not null)
            this.CategoryId = categoryId ?? throw new ArgumentNullException("categoryId is a required property for GetProductsByCategoryV2Request and cannot be null");
            this.ScopeId = scopeId;
            this.CultureName = cultureName;
            this.IncludeVariants = includeVariants;
            this.IncludeMedia = includeMedia;
            this.IncludePriceLists = includePriceLists;
            this.IncludeRelationships = includeRelationships;
            this.ContinuationToken = continuationToken;
            this.PageSize = pageSize;
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
        /// The category id at which point in the category hierarchy should the &#39;get products&#39; be started.
        /// </summary>
        /// <value>The category id at which point in the category hierarchy should the &#39;get products&#39; be started.</value>
        [DataMember(Name = "categoryId", IsRequired = true, EmitDefaultValue = false)]
        public string CategoryId { get; set; }

        /// <summary>
        /// The continuation token used for pagination
        /// </summary>
        /// <value>The continuation token used for pagination</value>
        [DataMember(Name = "continuationToken", EmitDefaultValue = false)]
        public string ContinuationToken { get; set; }

        /// <summary>
        /// The maximum number of products to return. Default value : 10
        /// </summary>
        /// <value>The maximum number of products to return. Default value : 10</value>
        [DataMember(Name = "pageSize", EmitDefaultValue = false)]
        public int PageSize { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GetProductsByCategoryV2Request {\n");
            sb.Append("  ScopeId: ").Append(ScopeId).Append("\n");
            sb.Append("  CultureName: ").Append(CultureName).Append("\n");
            sb.Append("  IncludeVariants: ").Append(IncludeVariants).Append("\n");
            sb.Append("  IncludeMedia: ").Append(IncludeMedia).Append("\n");
            sb.Append("  IncludePriceLists: ").Append(IncludePriceLists).Append("\n");
            sb.Append("  IncludeRelationships: ").Append(IncludeRelationships).Append("\n");
            sb.Append("  CategoryId: ").Append(CategoryId).Append("\n");
            sb.Append("  ContinuationToken: ").Append(ContinuationToken).Append("\n");
            sb.Append("  PageSize: ").Append(PageSize).Append("\n");
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
            return this.Equals(input as GetProductsByCategoryV2Request);
        }

        /// <summary>
        /// Returns true if GetProductsByCategoryV2Request instances are equal
        /// </summary>
        /// <param name="input">Instance of GetProductsByCategoryV2Request to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetProductsByCategoryV2Request input)
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
                    this.CategoryId == input.CategoryId ||
                    (this.CategoryId != null &&
                    this.CategoryId.Equals(input.CategoryId))
                ) && 
                (
                    this.ContinuationToken == input.ContinuationToken ||
                    (this.ContinuationToken != null &&
                    this.ContinuationToken.Equals(input.ContinuationToken))
                ) && 
                (
                    this.PageSize == input.PageSize ||
                    this.PageSize.Equals(input.PageSize)
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
                if (this.CategoryId != null)
                    hashCode = hashCode * 59 + this.CategoryId.GetHashCode();
                if (this.ContinuationToken != null)
                    hashCode = hashCode * 59 + this.ContinuationToken.GetHashCode();
                hashCode = hashCode * 59 + this.PageSize.GetHashCode();
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
