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
    [DataContract(Name = "CalculatePricesofProductsRequest")]
    public partial class CalculatePricesofProductsRequest : IEquatable<CalculatePricesofProductsRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CalculatePricesofProductsRequest" /> class.
        /// </summary>
        /// <param name="includeVariants">whether or not to include the variants (if they exist) of the product..</param>
        /// <param name="productIds">the business id for the product to retrieve.</param>
        /// <param name="time">the price when the date must be computed..</param>
        public CalculatePricesofProductsRequest(bool includeVariants = default(bool), List<string> productIds = default(List<string>), DateTime time = default(DateTime))
        {
            this.IncludeVariants = includeVariants;
            this.ProductIds = productIds;
            this.Time = time;
        }

        /// <summary>
        /// whether or not to include the variants (if they exist) of the product.
        /// </summary>
        /// <value>whether or not to include the variants (if they exist) of the product.</value>
        [DataMember(Name = "includeVariants", EmitDefaultValue = true)]
        public bool IncludeVariants { get; set; }

        /// <summary>
        /// the business id for the product to retrieve
        /// </summary>
        /// <value>the business id for the product to retrieve</value>
        [DataMember(Name = "productIds", EmitDefaultValue = false)]
        public List<string> ProductIds { get; set; }

        /// <summary>
        /// the price when the date must be computed.
        /// </summary>
        /// <value>the price when the date must be computed.</value>
        [DataMember(Name = "time", EmitDefaultValue = false)]
        public DateTime Time { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CalculatePricesofProductsRequest {\n");
            sb.Append("  IncludeVariants: ").Append(IncludeVariants).Append("\n");
            sb.Append("  ProductIds: ").Append(ProductIds).Append("\n");
            sb.Append("  Time: ").Append(Time).Append("\n");
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
            return this.Equals(input as CalculatePricesofProductsRequest);
        }

        /// <summary>
        /// Returns true if CalculatePricesofProductsRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of CalculatePricesofProductsRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CalculatePricesofProductsRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.IncludeVariants == input.IncludeVariants ||
                    this.IncludeVariants.Equals(input.IncludeVariants)
                ) && 
                (
                    this.ProductIds == input.ProductIds ||
                    this.ProductIds != null &&
                    input.ProductIds != null &&
                    this.ProductIds.SequenceEqual(input.ProductIds)
                ) && 
                (
                    this.Time == input.Time ||
                    (this.Time != null &&
                    this.Time.Equals(input.Time))
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
                hashCode = hashCode * 59 + this.IncludeVariants.GetHashCode();
                if (this.ProductIds != null)
                    hashCode = hashCode * 59 + this.ProductIds.GetHashCode();
                if (this.Time != null)
                    hashCode = hashCode * 59 + this.Time.GetHashCode();
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
