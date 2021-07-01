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
    [DataContract(Name = "GetCategoryRequest")]
    public partial class GetCategoryRequest : IEquatable<GetCategoryRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetCategoryRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GetCategoryRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="GetCategoryRequest" /> class.
        /// </summary>
        /// <param name="scopeId">The id of the requested scope.</param>
        /// <param name="categoryId">The category id (required).</param>
        /// <param name="cultureName">The culture name in which language the data will be returned.</param>
        /// <param name="includeRelationships">Indicates if the relationships must be included in the response..</param>
        public GetCategoryRequest(string scopeId = default(string), string categoryId = default(string), string cultureName = default(string), bool includeRelationships = default(bool))
        {
            // to ensure "categoryId" is required (not null)
            this.CategoryId = categoryId ?? throw new ArgumentNullException("categoryId is a required property for GetCategoryRequest and cannot be null");
            this.ScopeId = scopeId;
            this.CultureName = cultureName;
            this.IncludeRelationships = includeRelationships;
        }

        /// <summary>
        /// The id of the requested scope
        /// </summary>
        /// <value>The id of the requested scope</value>
        [DataMember(Name = "scopeId", EmitDefaultValue = false)]
        public string ScopeId { get; set; }

        /// <summary>
        /// The category id
        /// </summary>
        /// <value>The category id</value>
        [DataMember(Name = "categoryId", IsRequired = true, EmitDefaultValue = false)]
        public string CategoryId { get; set; }

        /// <summary>
        /// The culture name in which language the data will be returned
        /// </summary>
        /// <value>The culture name in which language the data will be returned</value>
        [DataMember(Name = "cultureName", EmitDefaultValue = false)]
        public string CultureName { get; set; }

        /// <summary>
        /// Indicates if the relationships must be included in the response.
        /// </summary>
        /// <value>Indicates if the relationships must be included in the response.</value>
        [DataMember(Name = "includeRelationships", EmitDefaultValue = true)]
        public bool IncludeRelationships { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GetCategoryRequest {\n");
            sb.Append("  ScopeId: ").Append(ScopeId).Append("\n");
            sb.Append("  CategoryId: ").Append(CategoryId).Append("\n");
            sb.Append("  CultureName: ").Append(CultureName).Append("\n");
            sb.Append("  IncludeRelationships: ").Append(IncludeRelationships).Append("\n");
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
            return this.Equals(input as GetCategoryRequest);
        }

        /// <summary>
        /// Returns true if GetCategoryRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of GetCategoryRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetCategoryRequest input)
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
                    this.IncludeRelationships == input.IncludeRelationships ||
                    this.IncludeRelationships.Equals(input.IncludeRelationships)
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
                if (this.CategoryId != null)
                    hashCode = hashCode * 59 + this.CategoryId.GetHashCode();
                if (this.CultureName != null)
                    hashCode = hashCode * 59 + this.CultureName.GetHashCode();
                hashCode = hashCode * 59 + this.IncludeRelationships.GetHashCode();
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
