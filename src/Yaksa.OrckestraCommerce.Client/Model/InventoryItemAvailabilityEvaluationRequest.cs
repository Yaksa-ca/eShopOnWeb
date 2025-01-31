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
    /// InventoryItemAvailabilityEvaluationRequest
    /// </summary>
    [DataContract(Name = "InventoryItemAvailabilityEvaluationRequest")]
    public partial class InventoryItemAvailabilityEvaluationRequest : IEquatable<InventoryItemAvailabilityEvaluationRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InventoryItemAvailabilityEvaluationRequest" /> class.
        /// </summary>
        /// <param name="inventoryLocationIds">The inventory location ids.</param>
        /// <param name="lineItemId">The line item identifier.</param>
        /// <param name="lineItemSku">The line item sku.</param>
        /// <param name="quantity">The quantity to evaluate.</param>
        public InventoryItemAvailabilityEvaluationRequest(List<string> inventoryLocationIds = default(List<string>), string lineItemId = default(string), string lineItemSku = default(string), double quantity = default(double))
        {
            this.InventoryLocationIds = inventoryLocationIds;
            this.LineItemId = lineItemId;
            this.LineItemSku = lineItemSku;
            this.Quantity = quantity;
        }

        /// <summary>
        /// The inventory location ids
        /// </summary>
        /// <value>The inventory location ids</value>
        [DataMember(Name = "inventoryLocationIds", EmitDefaultValue = false)]
        public List<string> InventoryLocationIds { get; set; }

        /// <summary>
        /// The line item identifier
        /// </summary>
        /// <value>The line item identifier</value>
        [DataMember(Name = "lineItemId", EmitDefaultValue = false)]
        public string LineItemId { get; set; }

        /// <summary>
        /// The line item sku
        /// </summary>
        /// <value>The line item sku</value>
        [DataMember(Name = "lineItemSku", EmitDefaultValue = false)]
        public string LineItemSku { get; set; }

        /// <summary>
        /// The quantity to evaluate
        /// </summary>
        /// <value>The quantity to evaluate</value>
        [DataMember(Name = "quantity", EmitDefaultValue = false)]
        public double Quantity { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InventoryItemAvailabilityEvaluationRequest {\n");
            sb.Append("  InventoryLocationIds: ").Append(InventoryLocationIds).Append("\n");
            sb.Append("  LineItemId: ").Append(LineItemId).Append("\n");
            sb.Append("  LineItemSku: ").Append(LineItemSku).Append("\n");
            sb.Append("  Quantity: ").Append(Quantity).Append("\n");
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
            return this.Equals(input as InventoryItemAvailabilityEvaluationRequest);
        }

        /// <summary>
        /// Returns true if InventoryItemAvailabilityEvaluationRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of InventoryItemAvailabilityEvaluationRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InventoryItemAvailabilityEvaluationRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.InventoryLocationIds == input.InventoryLocationIds ||
                    this.InventoryLocationIds != null &&
                    input.InventoryLocationIds != null &&
                    this.InventoryLocationIds.SequenceEqual(input.InventoryLocationIds)
                ) && 
                (
                    this.LineItemId == input.LineItemId ||
                    (this.LineItemId != null &&
                    this.LineItemId.Equals(input.LineItemId))
                ) && 
                (
                    this.LineItemSku == input.LineItemSku ||
                    (this.LineItemSku != null &&
                    this.LineItemSku.Equals(input.LineItemSku))
                ) && 
                (
                    this.Quantity == input.Quantity ||
                    this.Quantity.Equals(input.Quantity)
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
                if (this.InventoryLocationIds != null)
                    hashCode = hashCode * 59 + this.InventoryLocationIds.GetHashCode();
                if (this.LineItemId != null)
                    hashCode = hashCode * 59 + this.LineItemId.GetHashCode();
                if (this.LineItemSku != null)
                    hashCode = hashCode * 59 + this.LineItemSku.GetHashCode();
                hashCode = hashCode * 59 + this.Quantity.GetHashCode();
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
