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
    /// FindPromoCodesResponse
    /// </summary>
    [DataContract(Name = "FindPromoCodesResponse")]
    public partial class FindPromoCodesResponse : IEquatable<FindPromoCodesResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FindPromoCodesResponse" /> class.
        /// </summary>
        /// <param name="promoCodes">The list of the promotion&#39;s promo codes..</param>
        public FindPromoCodesResponse(List<PromoCodeItem> promoCodes = default(List<PromoCodeItem>))
        {
            this.PromoCodes = promoCodes;
        }

        /// <summary>
        /// The list of the promotion&#39;s promo codes.
        /// </summary>
        /// <value>The list of the promotion&#39;s promo codes.</value>
        [DataMember(Name = "promoCodes", EmitDefaultValue = false)]
        public List<PromoCodeItem> PromoCodes { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FindPromoCodesResponse {\n");
            sb.Append("  PromoCodes: ").Append(PromoCodes).Append("\n");
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
            return this.Equals(input as FindPromoCodesResponse);
        }

        /// <summary>
        /// Returns true if FindPromoCodesResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of FindPromoCodesResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FindPromoCodesResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.PromoCodes == input.PromoCodes ||
                    this.PromoCodes != null &&
                    input.PromoCodes != null &&
                    this.PromoCodes.SequenceEqual(input.PromoCodes)
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
                if (this.PromoCodes != null)
                    hashCode = hashCode * 59 + this.PromoCodes.GetHashCode();
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
