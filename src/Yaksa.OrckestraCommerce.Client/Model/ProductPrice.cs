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
    /// ProductPrice
    /// </summary>
    [DataContract(Name = "ProductPrice")]
    public partial class ProductPrice : IEquatable<ProductPrice>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProductPrice" /> class.
        /// </summary>
        /// <param name="defaultPrice">The default price of the product.</param>
        /// <param name="pricing">pricing.</param>
        /// <param name="productId">The unique identifier of the product to which the pricing is set.</param>
        /// <param name="regularPricing">regularPricing.</param>
        /// <param name="variantPrices">The price of the variants associated to the product. This list will be empty if the product is not associated to any variants.</param>
        public ProductPrice(double defaultPrice = default(double), ProductPriceEntry pricing = default(ProductPriceEntry), string productId = default(string), ProductPriceEntry regularPricing = default(ProductPriceEntry), List<VariantPrice> variantPrices = default(List<VariantPrice>))
        {
            this.DefaultPrice = defaultPrice;
            this.Pricing = pricing;
            this.ProductId = productId;
            this.RegularPricing = regularPricing;
            this.VariantPrices = variantPrices;
        }

        /// <summary>
        /// The default price of the product
        /// </summary>
        /// <value>The default price of the product</value>
        [DataMember(Name = "defaultPrice", EmitDefaultValue = false)]
        public double DefaultPrice { get; set; }

        /// <summary>
        /// Gets or Sets Pricing
        /// </summary>
        [DataMember(Name = "pricing", EmitDefaultValue = false)]
        public ProductPriceEntry Pricing { get; set; }

        /// <summary>
        /// The unique identifier of the product to which the pricing is set
        /// </summary>
        /// <value>The unique identifier of the product to which the pricing is set</value>
        [DataMember(Name = "productId", EmitDefaultValue = false)]
        public string ProductId { get; set; }

        /// <summary>
        /// Gets or Sets RegularPricing
        /// </summary>
        [DataMember(Name = "regularPricing", EmitDefaultValue = false)]
        public ProductPriceEntry RegularPricing { get; set; }

        /// <summary>
        /// The price of the variants associated to the product. This list will be empty if the product is not associated to any variants
        /// </summary>
        /// <value>The price of the variants associated to the product. This list will be empty if the product is not associated to any variants</value>
        [DataMember(Name = "variantPrices", EmitDefaultValue = false)]
        public List<VariantPrice> VariantPrices { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ProductPrice {\n");
            sb.Append("  DefaultPrice: ").Append(DefaultPrice).Append("\n");
            sb.Append("  Pricing: ").Append(Pricing).Append("\n");
            sb.Append("  ProductId: ").Append(ProductId).Append("\n");
            sb.Append("  RegularPricing: ").Append(RegularPricing).Append("\n");
            sb.Append("  VariantPrices: ").Append(VariantPrices).Append("\n");
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
            return this.Equals(input as ProductPrice);
        }

        /// <summary>
        /// Returns true if ProductPrice instances are equal
        /// </summary>
        /// <param name="input">Instance of ProductPrice to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ProductPrice input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DefaultPrice == input.DefaultPrice ||
                    this.DefaultPrice.Equals(input.DefaultPrice)
                ) && 
                (
                    this.Pricing == input.Pricing ||
                    (this.Pricing != null &&
                    this.Pricing.Equals(input.Pricing))
                ) && 
                (
                    this.ProductId == input.ProductId ||
                    (this.ProductId != null &&
                    this.ProductId.Equals(input.ProductId))
                ) && 
                (
                    this.RegularPricing == input.RegularPricing ||
                    (this.RegularPricing != null &&
                    this.RegularPricing.Equals(input.RegularPricing))
                ) && 
                (
                    this.VariantPrices == input.VariantPrices ||
                    this.VariantPrices != null &&
                    input.VariantPrices != null &&
                    this.VariantPrices.SequenceEqual(input.VariantPrices)
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
                hashCode = hashCode * 59 + this.DefaultPrice.GetHashCode();
                if (this.Pricing != null)
                    hashCode = hashCode * 59 + this.Pricing.GetHashCode();
                if (this.ProductId != null)
                    hashCode = hashCode * 59 + this.ProductId.GetHashCode();
                if (this.RegularPricing != null)
                    hashCode = hashCode * 59 + this.RegularPricing.GetHashCode();
                if (this.VariantPrices != null)
                    hashCode = hashCode * 59 + this.VariantPrices.GetHashCode();
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
