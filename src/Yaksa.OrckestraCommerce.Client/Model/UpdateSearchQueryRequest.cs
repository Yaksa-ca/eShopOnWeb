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
    /// The API used to handle saved Search queries.
    /// </summary>
    [DataContract(Name = "UpdateSearchQueryRequest")]
    public partial class UpdateSearchQueryRequest : IEquatable<UpdateSearchQueryRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateSearchQueryRequest" /> class.
        /// </summary>
        /// <param name="category">Category of the search query.</param>
        /// <param name="queryData">The data used to build a search request.</param>
        public UpdateSearchQueryRequest(string category = default(string), List<SearchQueryData> queryData = default(List<SearchQueryData>))
        {
            this.Category = category;
            this.QueryData = queryData;
        }

        /// <summary>
        /// Category of the search query
        /// </summary>
        /// <value>Category of the search query</value>
        [DataMember(Name = "category", EmitDefaultValue = false)]
        public string Category { get; set; }

        /// <summary>
        /// The data used to build a search request
        /// </summary>
        /// <value>The data used to build a search request</value>
        [DataMember(Name = "queryData", EmitDefaultValue = false)]
        public List<SearchQueryData> QueryData { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateSearchQueryRequest {\n");
            sb.Append("  Category: ").Append(Category).Append("\n");
            sb.Append("  QueryData: ").Append(QueryData).Append("\n");
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
            return this.Equals(input as UpdateSearchQueryRequest);
        }

        /// <summary>
        /// Returns true if UpdateSearchQueryRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of UpdateSearchQueryRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UpdateSearchQueryRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Category == input.Category ||
                    (this.Category != null &&
                    this.Category.Equals(input.Category))
                ) && 
                (
                    this.QueryData == input.QueryData ||
                    this.QueryData != null &&
                    input.QueryData != null &&
                    this.QueryData.SequenceEqual(input.QueryData)
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
                if (this.Category != null)
                    hashCode = hashCode * 59 + this.Category.GetHashCode();
                if (this.QueryData != null)
                    hashCode = hashCode * 59 + this.QueryData.GetHashCode();
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
