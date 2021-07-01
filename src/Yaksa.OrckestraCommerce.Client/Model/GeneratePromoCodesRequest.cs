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
    /// A promotion defines a set of rewards that can be applied to a Cart if a set of conditions are true.
    /// </summary>
    [DataContract(Name = "GeneratePromoCodesRequest")]
    public partial class GeneratePromoCodesRequest : IEquatable<GeneratePromoCodesRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GeneratePromoCodesRequest" /> class.
        /// </summary>
        /// <param name="prefix">The id of the promotion..</param>
        /// <param name="quantity">The number of promo codes to generate..</param>
        /// <param name="suffix">The id of the promotion..</param>
        public GeneratePromoCodesRequest(string prefix = default(string), int quantity = default(int), string suffix = default(string))
        {
            this.Prefix = prefix;
            this.Quantity = quantity;
            this.Suffix = suffix;
        }

        /// <summary>
        /// The id of the promotion.
        /// </summary>
        /// <value>The id of the promotion.</value>
        [DataMember(Name = "prefix", EmitDefaultValue = false)]
        public string Prefix { get; set; }

        /// <summary>
        /// The number of promo codes to generate.
        /// </summary>
        /// <value>The number of promo codes to generate.</value>
        [DataMember(Name = "quantity", EmitDefaultValue = false)]
        public int Quantity { get; set; }

        /// <summary>
        /// The id of the promotion.
        /// </summary>
        /// <value>The id of the promotion.</value>
        [DataMember(Name = "suffix", EmitDefaultValue = false)]
        public string Suffix { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GeneratePromoCodesRequest {\n");
            sb.Append("  Prefix: ").Append(Prefix).Append("\n");
            sb.Append("  Quantity: ").Append(Quantity).Append("\n");
            sb.Append("  Suffix: ").Append(Suffix).Append("\n");
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
            return this.Equals(input as GeneratePromoCodesRequest);
        }

        /// <summary>
        /// Returns true if GeneratePromoCodesRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of GeneratePromoCodesRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GeneratePromoCodesRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Prefix == input.Prefix ||
                    (this.Prefix != null &&
                    this.Prefix.Equals(input.Prefix))
                ) && 
                (
                    this.Quantity == input.Quantity ||
                    this.Quantity.Equals(input.Quantity)
                ) && 
                (
                    this.Suffix == input.Suffix ||
                    (this.Suffix != null &&
                    this.Suffix.Equals(input.Suffix))
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
                if (this.Prefix != null)
                    hashCode = hashCode * 59 + this.Prefix.GetHashCode();
                hashCode = hashCode * 59 + this.Quantity.GetHashCode();
                if (this.Suffix != null)
                    hashCode = hashCode * 59 + this.Suffix.GetHashCode();
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
