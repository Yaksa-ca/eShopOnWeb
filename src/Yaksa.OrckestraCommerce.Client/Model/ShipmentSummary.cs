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
    /// ShipmentSummary
    /// </summary>
    [DataContract(Name = "ShipmentSummary")]
    public partial class ShipmentSummary : IEquatable<ShipmentSummary>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ShipmentSummary" /> class.
        /// </summary>
        /// <param name="discountAmount">Reward amount applied on the shipment.</param>
        /// <param name="lineItems">The list of lineitems.</param>
        /// <param name="shipmentId">The unique identifier of the shipment.</param>
        /// <param name="total">The total of the shipment including discounts.</param>
        public ShipmentSummary(double discountAmount = default(double), List<LineItemSummary> lineItems = default(List<LineItemSummary>), string shipmentId = default(string), double total = default(double))
        {
            this.DiscountAmount = discountAmount;
            this.LineItems = lineItems;
            this.ShipmentId = shipmentId;
            this.Total = total;
        }

        /// <summary>
        /// Reward amount applied on the shipment
        /// </summary>
        /// <value>Reward amount applied on the shipment</value>
        [DataMember(Name = "discountAmount", EmitDefaultValue = false)]
        public double DiscountAmount { get; set; }

        /// <summary>
        /// The list of lineitems
        /// </summary>
        /// <value>The list of lineitems</value>
        [DataMember(Name = "lineItems", EmitDefaultValue = false)]
        public List<LineItemSummary> LineItems { get; set; }

        /// <summary>
        /// The unique identifier of the shipment
        /// </summary>
        /// <value>The unique identifier of the shipment</value>
        [DataMember(Name = "shipmentId", EmitDefaultValue = false)]
        public string ShipmentId { get; set; }

        /// <summary>
        /// The total of the shipment including discounts
        /// </summary>
        /// <value>The total of the shipment including discounts</value>
        [DataMember(Name = "total", EmitDefaultValue = false)]
        public double Total { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShipmentSummary {\n");
            sb.Append("  DiscountAmount: ").Append(DiscountAmount).Append("\n");
            sb.Append("  LineItems: ").Append(LineItems).Append("\n");
            sb.Append("  ShipmentId: ").Append(ShipmentId).Append("\n");
            sb.Append("  Total: ").Append(Total).Append("\n");
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
            return this.Equals(input as ShipmentSummary);
        }

        /// <summary>
        /// Returns true if ShipmentSummary instances are equal
        /// </summary>
        /// <param name="input">Instance of ShipmentSummary to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ShipmentSummary input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DiscountAmount == input.DiscountAmount ||
                    this.DiscountAmount.Equals(input.DiscountAmount)
                ) && 
                (
                    this.LineItems == input.LineItems ||
                    this.LineItems != null &&
                    input.LineItems != null &&
                    this.LineItems.SequenceEqual(input.LineItems)
                ) && 
                (
                    this.ShipmentId == input.ShipmentId ||
                    (this.ShipmentId != null &&
                    this.ShipmentId.Equals(input.ShipmentId))
                ) && 
                (
                    this.Total == input.Total ||
                    this.Total.Equals(input.Total)
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
                hashCode = hashCode * 59 + this.DiscountAmount.GetHashCode();
                if (this.LineItems != null)
                    hashCode = hashCode * 59 + this.LineItems.GetHashCode();
                if (this.ShipmentId != null)
                    hashCode = hashCode * 59 + this.ShipmentId.GetHashCode();
                hashCode = hashCode * 59 + this.Total.GetHashCode();
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
