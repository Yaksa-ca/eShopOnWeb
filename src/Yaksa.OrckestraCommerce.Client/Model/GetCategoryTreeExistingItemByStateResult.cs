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
    /// GetCategoryTreeExistingItemByStateResult
    /// </summary>
    [DataContract(Name = "GetCategoryTreeExistingItemByStateResult")]
    public partial class GetCategoryTreeExistingItemByStateResult : IEquatable<GetCategoryTreeExistingItemByStateResult>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetCategoryTreeExistingItemByStateResult" /> class.
        /// </summary>
        /// <param name="categoryIds">categoryIds.</param>
        public GetCategoryTreeExistingItemByStateResult(List<string> categoryIds = default(List<string>))
        {
            this.CategoryIds = categoryIds;
        }

        /// <summary>
        /// Gets or Sets CategoryIds
        /// </summary>
        [DataMember(Name = "categoryIds", EmitDefaultValue = false)]
        public List<string> CategoryIds { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GetCategoryTreeExistingItemByStateResult {\n");
            sb.Append("  CategoryIds: ").Append(CategoryIds).Append("\n");
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
            return this.Equals(input as GetCategoryTreeExistingItemByStateResult);
        }

        /// <summary>
        /// Returns true if GetCategoryTreeExistingItemByStateResult instances are equal
        /// </summary>
        /// <param name="input">Instance of GetCategoryTreeExistingItemByStateResult to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetCategoryTreeExistingItemByStateResult input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CategoryIds == input.CategoryIds ||
                    this.CategoryIds != null &&
                    input.CategoryIds != null &&
                    this.CategoryIds.SequenceEqual(input.CategoryIds)
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
                if (this.CategoryIds != null)
                    hashCode = hashCode * 59 + this.CategoryIds.GetHashCode();
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
