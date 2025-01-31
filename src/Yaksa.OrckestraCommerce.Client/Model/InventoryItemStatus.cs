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
    /// InventoryItemStatus
    /// </summary>
    [DataContract(Name = "InventoryItemStatus")]
    public partial class InventoryItemStatus : IEquatable<InventoryItemStatus>, IValidatableObject
    {
        /// <summary>
        /// The quantified information of this item
        /// </summary>
        /// <value>The quantified information of this item</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StatusEnum
        {
            /// <summary>
            /// Enum InStock for value: InStock
            /// </summary>
            [EnumMember(Value = "InStock")]
            InStock = 1,

            /// <summary>
            /// Enum OutOfStock for value: OutOfStock
            /// </summary>
            [EnumMember(Value = "OutOfStock")]
            OutOfStock = 2,

            /// <summary>
            /// Enum PreOrder for value: PreOrder
            /// </summary>
            [EnumMember(Value = "PreOrder")]
            PreOrder = 3,

            /// <summary>
            /// Enum BackOrder for value: BackOrder
            /// </summary>
            [EnumMember(Value = "BackOrder")]
            BackOrder = 4

        }


        /// <summary>
        /// The quantified information of this item
        /// </summary>
        /// <value>The quantified information of this item</value>
        [DataMember(Name = "status", EmitDefaultValue = false)]
        public StatusEnum? Status { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="InventoryItemStatus" /> class.
        /// </summary>
        /// <param name="quantity">The quantity.</param>
        /// <param name="status">The quantified information of this item.</param>
        public InventoryItemStatus(double quantity = default(double), StatusEnum? status = default(StatusEnum?))
        {
            this.Quantity = quantity;
            this.Status = status;
        }

        /// <summary>
        /// The quantity
        /// </summary>
        /// <value>The quantity</value>
        [DataMember(Name = "quantity", EmitDefaultValue = false)]
        public double Quantity { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InventoryItemStatus {\n");
            sb.Append("  Quantity: ").Append(Quantity).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
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
            return this.Equals(input as InventoryItemStatus);
        }

        /// <summary>
        /// Returns true if InventoryItemStatus instances are equal
        /// </summary>
        /// <param name="input">Instance of InventoryItemStatus to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InventoryItemStatus input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Quantity == input.Quantity ||
                    this.Quantity.Equals(input.Quantity)
                ) && 
                (
                    this.Status == input.Status ||
                    this.Status.Equals(input.Status)
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
                hashCode = hashCode * 59 + this.Quantity.GetHashCode();
                hashCode = hashCode * 59 + this.Status.GetHashCode();
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
