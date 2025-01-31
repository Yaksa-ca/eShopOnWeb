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
    /// FulfillmentCarrierPackageItem
    /// </summary>
    [DataContract(Name = "FulfillmentCarrierPackageItem")]
    public partial class FulfillmentCarrierPackageItem : IEquatable<FulfillmentCarrierPackageItem>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FulfillmentCarrierPackageItem" /> class.
        /// </summary>
        /// <param name="name">name.</param>
        /// <param name="sku">sku.</param>
        /// <param name="quantity">quantity.</param>
        /// <param name="unitOfMeasure">unitOfMeasure.</param>
        /// <param name="weightUOM">weightUOM.</param>
        /// <param name="weight">weight.</param>
        /// <param name="valueAmount">valueAmount.</param>
        /// <param name="valueCurrency">valueCurrency.</param>
        /// <param name="countryCodeOfOrigin">countryCodeOfOrigin.</param>
        public FulfillmentCarrierPackageItem(string name = default(string), string sku = default(string), double quantity = default(double), string unitOfMeasure = default(string), string weightUOM = default(string), double weight = default(double), double valueAmount = default(double), string valueCurrency = default(string), string countryCodeOfOrigin = default(string))
        {
            this.Name = name;
            this.Sku = sku;
            this.Quantity = quantity;
            this.UnitOfMeasure = unitOfMeasure;
            this.WeightUOM = weightUOM;
            this.Weight = weight;
            this.ValueAmount = valueAmount;
            this.ValueCurrency = valueCurrency;
            this.CountryCodeOfOrigin = countryCodeOfOrigin;
        }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Sku
        /// </summary>
        [DataMember(Name = "sku", EmitDefaultValue = false)]
        public string Sku { get; set; }

        /// <summary>
        /// Gets or Sets Quantity
        /// </summary>
        [DataMember(Name = "quantity", EmitDefaultValue = false)]
        public double Quantity { get; set; }

        /// <summary>
        /// Gets or Sets UnitOfMeasure
        /// </summary>
        [DataMember(Name = "unitOfMeasure", EmitDefaultValue = false)]
        public string UnitOfMeasure { get; set; }

        /// <summary>
        /// Gets or Sets WeightUOM
        /// </summary>
        [DataMember(Name = "weightUOM", EmitDefaultValue = false)]
        public string WeightUOM { get; set; }

        /// <summary>
        /// Gets or Sets Weight
        /// </summary>
        [DataMember(Name = "weight", EmitDefaultValue = false)]
        public double Weight { get; set; }

        /// <summary>
        /// Gets or Sets ValueAmount
        /// </summary>
        [DataMember(Name = "valueAmount", EmitDefaultValue = false)]
        public double ValueAmount { get; set; }

        /// <summary>
        /// Gets or Sets ValueCurrency
        /// </summary>
        [DataMember(Name = "valueCurrency", EmitDefaultValue = false)]
        public string ValueCurrency { get; set; }

        /// <summary>
        /// Gets or Sets CountryCodeOfOrigin
        /// </summary>
        [DataMember(Name = "countryCodeOfOrigin", EmitDefaultValue = false)]
        public string CountryCodeOfOrigin { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FulfillmentCarrierPackageItem {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Sku: ").Append(Sku).Append("\n");
            sb.Append("  Quantity: ").Append(Quantity).Append("\n");
            sb.Append("  UnitOfMeasure: ").Append(UnitOfMeasure).Append("\n");
            sb.Append("  WeightUOM: ").Append(WeightUOM).Append("\n");
            sb.Append("  Weight: ").Append(Weight).Append("\n");
            sb.Append("  ValueAmount: ").Append(ValueAmount).Append("\n");
            sb.Append("  ValueCurrency: ").Append(ValueCurrency).Append("\n");
            sb.Append("  CountryCodeOfOrigin: ").Append(CountryCodeOfOrigin).Append("\n");
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
            return this.Equals(input as FulfillmentCarrierPackageItem);
        }

        /// <summary>
        /// Returns true if FulfillmentCarrierPackageItem instances are equal
        /// </summary>
        /// <param name="input">Instance of FulfillmentCarrierPackageItem to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FulfillmentCarrierPackageItem input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Sku == input.Sku ||
                    (this.Sku != null &&
                    this.Sku.Equals(input.Sku))
                ) && 
                (
                    this.Quantity == input.Quantity ||
                    this.Quantity.Equals(input.Quantity)
                ) && 
                (
                    this.UnitOfMeasure == input.UnitOfMeasure ||
                    (this.UnitOfMeasure != null &&
                    this.UnitOfMeasure.Equals(input.UnitOfMeasure))
                ) && 
                (
                    this.WeightUOM == input.WeightUOM ||
                    (this.WeightUOM != null &&
                    this.WeightUOM.Equals(input.WeightUOM))
                ) && 
                (
                    this.Weight == input.Weight ||
                    this.Weight.Equals(input.Weight)
                ) && 
                (
                    this.ValueAmount == input.ValueAmount ||
                    this.ValueAmount.Equals(input.ValueAmount)
                ) && 
                (
                    this.ValueCurrency == input.ValueCurrency ||
                    (this.ValueCurrency != null &&
                    this.ValueCurrency.Equals(input.ValueCurrency))
                ) && 
                (
                    this.CountryCodeOfOrigin == input.CountryCodeOfOrigin ||
                    (this.CountryCodeOfOrigin != null &&
                    this.CountryCodeOfOrigin.Equals(input.CountryCodeOfOrigin))
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
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Sku != null)
                    hashCode = hashCode * 59 + this.Sku.GetHashCode();
                hashCode = hashCode * 59 + this.Quantity.GetHashCode();
                if (this.UnitOfMeasure != null)
                    hashCode = hashCode * 59 + this.UnitOfMeasure.GetHashCode();
                if (this.WeightUOM != null)
                    hashCode = hashCode * 59 + this.WeightUOM.GetHashCode();
                hashCode = hashCode * 59 + this.Weight.GetHashCode();
                hashCode = hashCode * 59 + this.ValueAmount.GetHashCode();
                if (this.ValueCurrency != null)
                    hashCode = hashCode * 59 + this.ValueCurrency.GetHashCode();
                if (this.CountryCodeOfOrigin != null)
                    hashCode = hashCode * 59 + this.CountryCodeOfOrigin.GetHashCode();
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
