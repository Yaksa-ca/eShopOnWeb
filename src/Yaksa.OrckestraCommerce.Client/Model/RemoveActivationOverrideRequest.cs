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
    [DataContract(Name = "RemoveActivationOverrideRequest")]
    public partial class RemoveActivationOverrideRequest : IEquatable<RemoveActivationOverrideRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RemoveActivationOverrideRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected RemoveActivationOverrideRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="RemoveActivationOverrideRequest" /> class.
        /// </summary>
        /// <param name="productId">The unique product Id (required).</param>
        /// <param name="scopeId">The id of the requested scope.</param>
        public RemoveActivationOverrideRequest(string productId = default(string), string scopeId = default(string))
        {
            // to ensure "productId" is required (not null)
            this.ProductId = productId ?? throw new ArgumentNullException("productId is a required property for RemoveActivationOverrideRequest and cannot be null");
            this.ScopeId = scopeId;
        }

        /// <summary>
        /// The unique product Id
        /// </summary>
        /// <value>The unique product Id</value>
        [DataMember(Name = "productId", IsRequired = true, EmitDefaultValue = false)]
        public string ProductId { get; set; }

        /// <summary>
        /// The id of the requested scope
        /// </summary>
        /// <value>The id of the requested scope</value>
        [DataMember(Name = "scopeId", EmitDefaultValue = false)]
        public string ScopeId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RemoveActivationOverrideRequest {\n");
            sb.Append("  ProductId: ").Append(ProductId).Append("\n");
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
            return this.Equals(input as RemoveActivationOverrideRequest);
        }

        /// <summary>
        /// Returns true if RemoveActivationOverrideRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of RemoveActivationOverrideRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RemoveActivationOverrideRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ProductId == input.ProductId ||
                    (this.ProductId != null &&
                    this.ProductId.Equals(input.ProductId))
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
                if (this.ProductId != null)
                    hashCode = hashCode * 59 + this.ProductId.GetHashCode();
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
