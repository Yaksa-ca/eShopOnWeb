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
    [DataContract(Name = "DeleteSearchQueryRequest")]
    public partial class DeleteSearchQueryRequest : IEquatable<DeleteSearchQueryRequest>, IValidatableObject
    {
        /// <summary>
        /// The type of the requested search query
        /// </summary>
        /// <value>The type of the requested search query</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum QueryTypeEnum
        {
            /// <summary>
            /// Enum Category for value: Category
            /// </summary>
            [EnumMember(Value = "Category")]
            Category = 1,

            /// <summary>
            /// Enum Merchandising for value: Merchandising
            /// </summary>
            [EnumMember(Value = "Merchandising")]
            Merchandising = 2,

            /// <summary>
            /// Enum ProductSet for value: ProductSet
            /// </summary>
            [EnumMember(Value = "ProductSet")]
            ProductSet = 3

        }


        /// <summary>
        /// The type of the requested search query
        /// </summary>
        /// <value>The type of the requested search query</value>
        [DataMember(Name = "queryType", EmitDefaultValue = false)]
        public QueryTypeEnum? QueryType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteSearchQueryRequest" /> class.
        /// </summary>
        /// <param name="scopeId">The id of the requested scope.</param>
        /// <param name="name">The name of the requested search query.</param>
        /// <param name="queryType">The type of the requested search query.</param>
        public DeleteSearchQueryRequest(string scopeId = default(string), string name = default(string), QueryTypeEnum? queryType = default(QueryTypeEnum?))
        {
            this.ScopeId = scopeId;
            this.Name = name;
            this.QueryType = queryType;
        }

        /// <summary>
        /// The id of the requested scope
        /// </summary>
        /// <value>The id of the requested scope</value>
        [DataMember(Name = "scopeId", EmitDefaultValue = false)]
        public string ScopeId { get; set; }

        /// <summary>
        /// The name of the requested search query
        /// </summary>
        /// <value>The name of the requested search query</value>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DeleteSearchQueryRequest {\n");
            sb.Append("  ScopeId: ").Append(ScopeId).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  QueryType: ").Append(QueryType).Append("\n");
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
            return this.Equals(input as DeleteSearchQueryRequest);
        }

        /// <summary>
        /// Returns true if DeleteSearchQueryRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of DeleteSearchQueryRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DeleteSearchQueryRequest input)
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
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.QueryType == input.QueryType ||
                    this.QueryType.Equals(input.QueryType)
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
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                hashCode = hashCode * 59 + this.QueryType.GetHashCode();
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
