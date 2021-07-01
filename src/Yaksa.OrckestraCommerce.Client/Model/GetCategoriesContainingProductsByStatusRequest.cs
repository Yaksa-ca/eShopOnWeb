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
    [DataContract(Name = "GetCategoriesContainingProductsByStatusRequest")]
    public partial class GetCategoriesContainingProductsByStatusRequest : IEquatable<GetCategoriesContainingProductsByStatusRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetCategoriesContainingProductsByStatusRequest" /> class.
        /// </summary>
        /// <param name="scopeId">The id of the requested scope.</param>
        /// <param name="publicationStatus">The publication status to filter the products.</param>
        public GetCategoriesContainingProductsByStatusRequest(string scopeId = default(string), string publicationStatus = default(string))
        {
            this.ScopeId = scopeId;
            this.PublicationStatus = publicationStatus;
        }

        /// <summary>
        /// The id of the requested scope
        /// </summary>
        /// <value>The id of the requested scope</value>
        [DataMember(Name = "scopeId", EmitDefaultValue = false)]
        public string ScopeId { get; set; }

        /// <summary>
        /// The publication status to filter the products
        /// </summary>
        /// <value>The publication status to filter the products</value>
        [DataMember(Name = "publicationStatus", EmitDefaultValue = false)]
        public string PublicationStatus { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GetCategoriesContainingProductsByStatusRequest {\n");
            sb.Append("  ScopeId: ").Append(ScopeId).Append("\n");
            sb.Append("  PublicationStatus: ").Append(PublicationStatus).Append("\n");
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
            return this.Equals(input as GetCategoriesContainingProductsByStatusRequest);
        }

        /// <summary>
        /// Returns true if GetCategoriesContainingProductsByStatusRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of GetCategoriesContainingProductsByStatusRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetCategoriesContainingProductsByStatusRequest input)
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
                    this.PublicationStatus == input.PublicationStatus ||
                    (this.PublicationStatus != null &&
                    this.PublicationStatus.Equals(input.PublicationStatus))
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
                if (this.PublicationStatus != null)
                    hashCode = hashCode * 59 + this.PublicationStatus.GetHashCode();
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
