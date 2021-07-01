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
    /// ProductPriceEntry
    /// </summary>
    [DataContract(Name = "ProductPriceEntry")]
    public partial class ProductPriceEntry : IEquatable<ProductPriceEntry>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProductPriceEntry" /> class.
        /// </summary>
        /// <param name="endDate">The end date..</param>
        /// <param name="isInherited">Indicates whether the price is inherited from parent scope..</param>
        /// <param name="lastModified">lastModified.</param>
        /// <param name="lastModifiedBy">lastModifiedBy.</param>
        /// <param name="price">of the price of the Product.</param>
        /// <param name="priceListCategory">the price list category.</param>
        /// <param name="priceListId">the unique identifier of the PriceList associated to the Product.</param>
        /// <param name="priceListType">the price list type.</param>
        /// <param name="sequenceNumber">The sequence number..</param>
        /// <param name="startDate">The start date..</param>
        public ProductPriceEntry(DateTime endDate = default(DateTime), bool isInherited = default(bool), DateTime lastModified = default(DateTime), string lastModifiedBy = default(string), double price = default(double), string priceListCategory = default(string), string priceListId = default(string), string priceListType = default(string), int sequenceNumber = default(int), DateTime startDate = default(DateTime))
        {
            this.EndDate = endDate;
            this.IsInherited = isInherited;
            this.LastModified = lastModified;
            this.LastModifiedBy = lastModifiedBy;
            this.Price = price;
            this.PriceListCategory = priceListCategory;
            this.PriceListId = priceListId;
            this.PriceListType = priceListType;
            this.SequenceNumber = sequenceNumber;
            this.StartDate = startDate;
        }

        /// <summary>
        /// The end date.
        /// </summary>
        /// <value>The end date.</value>
        [DataMember(Name = "endDate", EmitDefaultValue = false)]
        public DateTime EndDate { get; set; }

        /// <summary>
        /// Indicates whether the price is inherited from parent scope.
        /// </summary>
        /// <value>Indicates whether the price is inherited from parent scope.</value>
        [DataMember(Name = "isInherited", EmitDefaultValue = true)]
        public bool IsInherited { get; set; }

        /// <summary>
        /// Gets or Sets LastModified
        /// </summary>
        [DataMember(Name = "lastModified", EmitDefaultValue = false)]
        public DateTime LastModified { get; set; }

        /// <summary>
        /// Gets or Sets LastModifiedBy
        /// </summary>
        [DataMember(Name = "lastModifiedBy", EmitDefaultValue = false)]
        public string LastModifiedBy { get; set; }

        /// <summary>
        /// of the price of the Product
        /// </summary>
        /// <value>of the price of the Product</value>
        [DataMember(Name = "price", EmitDefaultValue = false)]
        public double Price { get; set; }

        /// <summary>
        /// the price list category
        /// </summary>
        /// <value>the price list category</value>
        [DataMember(Name = "priceListCategory", EmitDefaultValue = false)]
        public string PriceListCategory { get; set; }

        /// <summary>
        /// the unique identifier of the PriceList associated to the Product
        /// </summary>
        /// <value>the unique identifier of the PriceList associated to the Product</value>
        [DataMember(Name = "priceListId", EmitDefaultValue = false)]
        public string PriceListId { get; set; }

        /// <summary>
        /// the price list type
        /// </summary>
        /// <value>the price list type</value>
        [DataMember(Name = "priceListType", EmitDefaultValue = false)]
        public string PriceListType { get; set; }

        /// <summary>
        /// The sequence number.
        /// </summary>
        /// <value>The sequence number.</value>
        [DataMember(Name = "sequenceNumber", EmitDefaultValue = false)]
        public int SequenceNumber { get; set; }

        /// <summary>
        /// The start date.
        /// </summary>
        /// <value>The start date.</value>
        [DataMember(Name = "startDate", EmitDefaultValue = false)]
        public DateTime StartDate { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ProductPriceEntry {\n");
            sb.Append("  EndDate: ").Append(EndDate).Append("\n");
            sb.Append("  IsInherited: ").Append(IsInherited).Append("\n");
            sb.Append("  LastModified: ").Append(LastModified).Append("\n");
            sb.Append("  LastModifiedBy: ").Append(LastModifiedBy).Append("\n");
            sb.Append("  Price: ").Append(Price).Append("\n");
            sb.Append("  PriceListCategory: ").Append(PriceListCategory).Append("\n");
            sb.Append("  PriceListId: ").Append(PriceListId).Append("\n");
            sb.Append("  PriceListType: ").Append(PriceListType).Append("\n");
            sb.Append("  SequenceNumber: ").Append(SequenceNumber).Append("\n");
            sb.Append("  StartDate: ").Append(StartDate).Append("\n");
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
            return this.Equals(input as ProductPriceEntry);
        }

        /// <summary>
        /// Returns true if ProductPriceEntry instances are equal
        /// </summary>
        /// <param name="input">Instance of ProductPriceEntry to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ProductPriceEntry input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.EndDate == input.EndDate ||
                    (this.EndDate != null &&
                    this.EndDate.Equals(input.EndDate))
                ) && 
                (
                    this.IsInherited == input.IsInherited ||
                    this.IsInherited.Equals(input.IsInherited)
                ) && 
                (
                    this.LastModified == input.LastModified ||
                    (this.LastModified != null &&
                    this.LastModified.Equals(input.LastModified))
                ) && 
                (
                    this.LastModifiedBy == input.LastModifiedBy ||
                    (this.LastModifiedBy != null &&
                    this.LastModifiedBy.Equals(input.LastModifiedBy))
                ) && 
                (
                    this.Price == input.Price ||
                    this.Price.Equals(input.Price)
                ) && 
                (
                    this.PriceListCategory == input.PriceListCategory ||
                    (this.PriceListCategory != null &&
                    this.PriceListCategory.Equals(input.PriceListCategory))
                ) && 
                (
                    this.PriceListId == input.PriceListId ||
                    (this.PriceListId != null &&
                    this.PriceListId.Equals(input.PriceListId))
                ) && 
                (
                    this.PriceListType == input.PriceListType ||
                    (this.PriceListType != null &&
                    this.PriceListType.Equals(input.PriceListType))
                ) && 
                (
                    this.SequenceNumber == input.SequenceNumber ||
                    this.SequenceNumber.Equals(input.SequenceNumber)
                ) && 
                (
                    this.StartDate == input.StartDate ||
                    (this.StartDate != null &&
                    this.StartDate.Equals(input.StartDate))
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
                if (this.EndDate != null)
                    hashCode = hashCode * 59 + this.EndDate.GetHashCode();
                hashCode = hashCode * 59 + this.IsInherited.GetHashCode();
                if (this.LastModified != null)
                    hashCode = hashCode * 59 + this.LastModified.GetHashCode();
                if (this.LastModifiedBy != null)
                    hashCode = hashCode * 59 + this.LastModifiedBy.GetHashCode();
                hashCode = hashCode * 59 + this.Price.GetHashCode();
                if (this.PriceListCategory != null)
                    hashCode = hashCode * 59 + this.PriceListCategory.GetHashCode();
                if (this.PriceListId != null)
                    hashCode = hashCode * 59 + this.PriceListId.GetHashCode();
                if (this.PriceListType != null)
                    hashCode = hashCode * 59 + this.PriceListType.GetHashCode();
                hashCode = hashCode * 59 + this.SequenceNumber.GetHashCode();
                if (this.StartDate != null)
                    hashCode = hashCode * 59 + this.StartDate.GetHashCode();
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
