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
    [DataContract(Name = "GetPriceListEntriesRequest")]
    public partial class GetPriceListEntriesRequest : IEquatable<GetPriceListEntriesRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetPriceListEntriesRequest" /> class.
        /// </summary>
        /// <param name="scopeId">The id of the requested scope.</param>
        /// <param name="includeExpiredEntries">Gets or sets a value indicating whether expired entries should be returned. Default is false..</param>
        /// <param name="productId">The id of the product for which we want to retrieve price list entries.</param>
        /// <param name="useParentScope">Returns values from the parent scope of the one provided in the request or not, default is false.</param>
        /// <param name="variantId">The id of the variant for which we want to retrieve price list entries.</param>
        public GetPriceListEntriesRequest(string scopeId = default(string), bool includeExpiredEntries = default(bool), string productId = default(string), bool useParentScope = default(bool), string variantId = default(string))
        {
            this.ScopeId = scopeId;
            this.IncludeExpiredEntries = includeExpiredEntries;
            this.ProductId = productId;
            this.UseParentScope = useParentScope;
            this.VariantId = variantId;
        }

        /// <summary>
        /// The id of the requested scope
        /// </summary>
        /// <value>The id of the requested scope</value>
        [DataMember(Name = "scopeId", EmitDefaultValue = false)]
        public string ScopeId { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether expired entries should be returned. Default is false.
        /// </summary>
        /// <value>Gets or sets a value indicating whether expired entries should be returned. Default is false.</value>
        [DataMember(Name = "includeExpiredEntries", EmitDefaultValue = true)]
        public bool IncludeExpiredEntries { get; set; }

        /// <summary>
        /// The id of the product for which we want to retrieve price list entries
        /// </summary>
        /// <value>The id of the product for which we want to retrieve price list entries</value>
        [DataMember(Name = "productId", EmitDefaultValue = false)]
        public string ProductId { get; set; }

        /// <summary>
        /// Returns values from the parent scope of the one provided in the request or not, default is false
        /// </summary>
        /// <value>Returns values from the parent scope of the one provided in the request or not, default is false</value>
        [DataMember(Name = "useParentScope", EmitDefaultValue = true)]
        public bool UseParentScope { get; set; }

        /// <summary>
        /// The id of the variant for which we want to retrieve price list entries
        /// </summary>
        /// <value>The id of the variant for which we want to retrieve price list entries</value>
        [DataMember(Name = "variantId", EmitDefaultValue = false)]
        public string VariantId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GetPriceListEntriesRequest {\n");
            sb.Append("  ScopeId: ").Append(ScopeId).Append("\n");
            sb.Append("  IncludeExpiredEntries: ").Append(IncludeExpiredEntries).Append("\n");
            sb.Append("  ProductId: ").Append(ProductId).Append("\n");
            sb.Append("  UseParentScope: ").Append(UseParentScope).Append("\n");
            sb.Append("  VariantId: ").Append(VariantId).Append("\n");
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
            return this.Equals(input as GetPriceListEntriesRequest);
        }

        /// <summary>
        /// Returns true if GetPriceListEntriesRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of GetPriceListEntriesRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetPriceListEntriesRequest input)
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
                    this.IncludeExpiredEntries == input.IncludeExpiredEntries ||
                    this.IncludeExpiredEntries.Equals(input.IncludeExpiredEntries)
                ) && 
                (
                    this.ProductId == input.ProductId ||
                    (this.ProductId != null &&
                    this.ProductId.Equals(input.ProductId))
                ) && 
                (
                    this.UseParentScope == input.UseParentScope ||
                    this.UseParentScope.Equals(input.UseParentScope)
                ) && 
                (
                    this.VariantId == input.VariantId ||
                    (this.VariantId != null &&
                    this.VariantId.Equals(input.VariantId))
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
                hashCode = hashCode * 59 + this.IncludeExpiredEntries.GetHashCode();
                if (this.ProductId != null)
                    hashCode = hashCode * 59 + this.ProductId.GetHashCode();
                hashCode = hashCode * 59 + this.UseParentScope.GetHashCode();
                if (this.VariantId != null)
                    hashCode = hashCode * 59 + this.VariantId.GetHashCode();
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
