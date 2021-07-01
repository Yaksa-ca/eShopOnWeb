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
    [DataContract(Name = "GetCategoryTreeNodesV2Request")]
    public partial class GetCategoryTreeNodesV2Request : IEquatable<GetCategoryTreeNodesV2Request>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetCategoryTreeNodesV2Request" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GetCategoryTreeNodesV2Request() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="GetCategoryTreeNodesV2Request" /> class.
        /// </summary>
        /// <param name="categoryId">The root node category unique identifier.</param>
        /// <param name="cultureName">The name of the culture (language) to use to process the request. (required).</param>
        /// <param name="maximumItems">A hint that the service will use to determine the maximum number of nodes to return.</param>
        /// <param name="scopeId">The Scope of the request..</param>
        public GetCategoryTreeNodesV2Request(string categoryId = default(string), string cultureName = default(string), int maximumItems = default(int), string scopeId = default(string))
        {
            // to ensure "cultureName" is required (not null)
            this.CultureName = cultureName ?? throw new ArgumentNullException("cultureName is a required property for GetCategoryTreeNodesV2Request and cannot be null");
            this.CategoryId = categoryId;
            this.MaximumItems = maximumItems;
            this.ScopeId = scopeId;
        }

        /// <summary>
        /// The root node category unique identifier
        /// </summary>
        /// <value>The root node category unique identifier</value>
        [DataMember(Name = "categoryId", EmitDefaultValue = false)]
        public string CategoryId { get; set; }

        /// <summary>
        /// The name of the culture (language) to use to process the request.
        /// </summary>
        /// <value>The name of the culture (language) to use to process the request.</value>
        [DataMember(Name = "cultureName", IsRequired = true, EmitDefaultValue = false)]
        public string CultureName { get; set; }

        /// <summary>
        /// A hint that the service will use to determine the maximum number of nodes to return
        /// </summary>
        /// <value>A hint that the service will use to determine the maximum number of nodes to return</value>
        [DataMember(Name = "maximumItems", EmitDefaultValue = false)]
        public int MaximumItems { get; set; }

        /// <summary>
        /// The Scope of the request.
        /// </summary>
        /// <value>The Scope of the request.</value>
        [DataMember(Name = "scopeId", EmitDefaultValue = false)]
        public string ScopeId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GetCategoryTreeNodesV2Request {\n");
            sb.Append("  CategoryId: ").Append(CategoryId).Append("\n");
            sb.Append("  CultureName: ").Append(CultureName).Append("\n");
            sb.Append("  MaximumItems: ").Append(MaximumItems).Append("\n");
            sb.Append("  ScopeId: ").Append(ScopeId).Append("\n");
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
            return this.Equals(input as GetCategoryTreeNodesV2Request);
        }

        /// <summary>
        /// Returns true if GetCategoryTreeNodesV2Request instances are equal
        /// </summary>
        /// <param name="input">Instance of GetCategoryTreeNodesV2Request to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetCategoryTreeNodesV2Request input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CategoryId == input.CategoryId ||
                    (this.CategoryId != null &&
                    this.CategoryId.Equals(input.CategoryId))
                ) && 
                (
                    this.CultureName == input.CultureName ||
                    (this.CultureName != null &&
                    this.CultureName.Equals(input.CultureName))
                ) && 
                (
                    this.MaximumItems == input.MaximumItems ||
                    this.MaximumItems.Equals(input.MaximumItems)
                ) && 
                (
                    this.ScopeId == input.ScopeId ||
                    (this.ScopeId != null &&
                    this.ScopeId.Equals(input.ScopeId))
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
                if (this.CategoryId != null)
                    hashCode = hashCode * 59 + this.CategoryId.GetHashCode();
                if (this.CultureName != null)
                    hashCode = hashCode * 59 + this.CultureName.GetHashCode();
                hashCode = hashCode * 59 + this.MaximumItems.GetHashCode();
                if (this.ScopeId != null)
                    hashCode = hashCode * 59 + this.ScopeId.GetHashCode();
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
