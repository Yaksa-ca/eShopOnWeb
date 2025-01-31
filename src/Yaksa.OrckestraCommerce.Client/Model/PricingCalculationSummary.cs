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
    /// PricingCalculationSummary
    /// </summary>
    [DataContract(Name = "PricingCalculationSummary")]
    public partial class PricingCalculationSummary : IEquatable<PricingCalculationSummary>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PricingCalculationSummary" /> class.
        /// </summary>
        /// <param name="currentPricePriceListCategory">The category of the current price.</param>
        /// <param name="currentPricePriceListId">The id of the current price.</param>
        /// <param name="currentPricePriceListType">The type of the current price.</param>
        /// <param name="propertyBag">propertyBag.</param>
        /// <param name="regularPricePriceListCategory">The category of the regular price.</param>
        /// <param name="regularPricePriceListId">The id of the regular price.</param>
        public PricingCalculationSummary(string currentPricePriceListCategory = default(string), string currentPricePriceListId = default(string), string currentPricePriceListType = default(string), Dictionary<string, Object> propertyBag = default(Dictionary<string, Object>), string regularPricePriceListCategory = default(string), string regularPricePriceListId = default(string))
        {
            this.CurrentPricePriceListCategory = currentPricePriceListCategory;
            this.CurrentPricePriceListId = currentPricePriceListId;
            this.CurrentPricePriceListType = currentPricePriceListType;
            this.PropertyBag = propertyBag;
            this.RegularPricePriceListCategory = regularPricePriceListCategory;
            this.RegularPricePriceListId = regularPricePriceListId;
        }

        /// <summary>
        /// The category of the current price
        /// </summary>
        /// <value>The category of the current price</value>
        [DataMember(Name = "currentPricePriceListCategory", EmitDefaultValue = false)]
        public string CurrentPricePriceListCategory { get; set; }

        /// <summary>
        /// The id of the current price
        /// </summary>
        /// <value>The id of the current price</value>
        [DataMember(Name = "currentPricePriceListId", EmitDefaultValue = false)]
        public string CurrentPricePriceListId { get; set; }

        /// <summary>
        /// The type of the current price
        /// </summary>
        /// <value>The type of the current price</value>
        [DataMember(Name = "currentPricePriceListType", EmitDefaultValue = false)]
        public string CurrentPricePriceListType { get; set; }

        /// <summary>
        /// Gets or Sets PropertyBag
        /// </summary>
        [DataMember(Name = "propertyBag", EmitDefaultValue = false)]
        public Dictionary<string, Object> PropertyBag { get; set; }

        /// <summary>
        /// The category of the regular price
        /// </summary>
        /// <value>The category of the regular price</value>
        [DataMember(Name = "regularPricePriceListCategory", EmitDefaultValue = false)]
        public string RegularPricePriceListCategory { get; set; }

        /// <summary>
        /// The id of the regular price
        /// </summary>
        /// <value>The id of the regular price</value>
        [DataMember(Name = "regularPricePriceListId", EmitDefaultValue = false)]
        public string RegularPricePriceListId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PricingCalculationSummary {\n");
            sb.Append("  CurrentPricePriceListCategory: ").Append(CurrentPricePriceListCategory).Append("\n");
            sb.Append("  CurrentPricePriceListId: ").Append(CurrentPricePriceListId).Append("\n");
            sb.Append("  CurrentPricePriceListType: ").Append(CurrentPricePriceListType).Append("\n");
            sb.Append("  PropertyBag: ").Append(PropertyBag).Append("\n");
            sb.Append("  RegularPricePriceListCategory: ").Append(RegularPricePriceListCategory).Append("\n");
            sb.Append("  RegularPricePriceListId: ").Append(RegularPricePriceListId).Append("\n");
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
            return this.Equals(input as PricingCalculationSummary);
        }

        /// <summary>
        /// Returns true if PricingCalculationSummary instances are equal
        /// </summary>
        /// <param name="input">Instance of PricingCalculationSummary to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PricingCalculationSummary input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CurrentPricePriceListCategory == input.CurrentPricePriceListCategory ||
                    (this.CurrentPricePriceListCategory != null &&
                    this.CurrentPricePriceListCategory.Equals(input.CurrentPricePriceListCategory))
                ) && 
                (
                    this.CurrentPricePriceListId == input.CurrentPricePriceListId ||
                    (this.CurrentPricePriceListId != null &&
                    this.CurrentPricePriceListId.Equals(input.CurrentPricePriceListId))
                ) && 
                (
                    this.CurrentPricePriceListType == input.CurrentPricePriceListType ||
                    (this.CurrentPricePriceListType != null &&
                    this.CurrentPricePriceListType.Equals(input.CurrentPricePriceListType))
                ) && 
                (
                    this.PropertyBag == input.PropertyBag ||
                    this.PropertyBag != null &&
                    input.PropertyBag != null &&
                    this.PropertyBag.SequenceEqual(input.PropertyBag)
                ) && 
                (
                    this.RegularPricePriceListCategory == input.RegularPricePriceListCategory ||
                    (this.RegularPricePriceListCategory != null &&
                    this.RegularPricePriceListCategory.Equals(input.RegularPricePriceListCategory))
                ) && 
                (
                    this.RegularPricePriceListId == input.RegularPricePriceListId ||
                    (this.RegularPricePriceListId != null &&
                    this.RegularPricePriceListId.Equals(input.RegularPricePriceListId))
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
                if (this.CurrentPricePriceListCategory != null)
                    hashCode = hashCode * 59 + this.CurrentPricePriceListCategory.GetHashCode();
                if (this.CurrentPricePriceListId != null)
                    hashCode = hashCode * 59 + this.CurrentPricePriceListId.GetHashCode();
                if (this.CurrentPricePriceListType != null)
                    hashCode = hashCode * 59 + this.CurrentPricePriceListType.GetHashCode();
                if (this.PropertyBag != null)
                    hashCode = hashCode * 59 + this.PropertyBag.GetHashCode();
                if (this.RegularPricePriceListCategory != null)
                    hashCode = hashCode * 59 + this.RegularPricePriceListCategory.GetHashCode();
                if (this.RegularPricePriceListId != null)
                    hashCode = hashCode * 59 + this.RegularPricePriceListId.GetHashCode();
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
