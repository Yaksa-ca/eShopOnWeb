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
    /// FulfillmentPackageItem
    /// </summary>
    [DataContract(Name = "FulfillmentPackageItem")]
    public partial class FulfillmentPackageItem : IEquatable<FulfillmentPackageItem>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FulfillmentPackageItem" /> class.
        /// </summary>
        /// <param name="id">The fulfillment package item identifier..</param>
        /// <param name="lineItemId">The line item identifier..</param>
        /// <param name="orderId">The order identifier..</param>
        /// <param name="pickingMissionItemId">The picking mission item identifier..</param>
        /// <param name="propertyBag">propertyBag.</param>
        /// <param name="shipmentId">The shipment identifier..</param>
        public FulfillmentPackageItem(string id = default(string), string lineItemId = default(string), string orderId = default(string), string pickingMissionItemId = default(string), Dictionary<string, Object> propertyBag = default(Dictionary<string, Object>), string shipmentId = default(string))
        {
            this.Id = id;
            this.LineItemId = lineItemId;
            this.OrderId = orderId;
            this.PickingMissionItemId = pickingMissionItemId;
            this.PropertyBag = propertyBag;
            this.ShipmentId = shipmentId;
        }

        /// <summary>
        /// The fulfillment package item identifier.
        /// </summary>
        /// <value>The fulfillment package item identifier.</value>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        /// The line item identifier.
        /// </summary>
        /// <value>The line item identifier.</value>
        [DataMember(Name = "lineItemId", EmitDefaultValue = false)]
        public string LineItemId { get; set; }

        /// <summary>
        /// The order identifier.
        /// </summary>
        /// <value>The order identifier.</value>
        [DataMember(Name = "orderId", EmitDefaultValue = false)]
        public string OrderId { get; set; }

        /// <summary>
        /// The picking mission item identifier.
        /// </summary>
        /// <value>The picking mission item identifier.</value>
        [DataMember(Name = "pickingMissionItemId", EmitDefaultValue = false)]
        public string PickingMissionItemId { get; set; }

        /// <summary>
        /// Gets or Sets PropertyBag
        /// </summary>
        [DataMember(Name = "propertyBag", EmitDefaultValue = false)]
        public Dictionary<string, Object> PropertyBag { get; set; }

        /// <summary>
        /// The shipment identifier.
        /// </summary>
        /// <value>The shipment identifier.</value>
        [DataMember(Name = "shipmentId", EmitDefaultValue = false)]
        public string ShipmentId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FulfillmentPackageItem {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  LineItemId: ").Append(LineItemId).Append("\n");
            sb.Append("  OrderId: ").Append(OrderId).Append("\n");
            sb.Append("  PickingMissionItemId: ").Append(PickingMissionItemId).Append("\n");
            sb.Append("  PropertyBag: ").Append(PropertyBag).Append("\n");
            sb.Append("  ShipmentId: ").Append(ShipmentId).Append("\n");
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
            return this.Equals(input as FulfillmentPackageItem);
        }

        /// <summary>
        /// Returns true if FulfillmentPackageItem instances are equal
        /// </summary>
        /// <param name="input">Instance of FulfillmentPackageItem to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FulfillmentPackageItem input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.LineItemId == input.LineItemId ||
                    (this.LineItemId != null &&
                    this.LineItemId.Equals(input.LineItemId))
                ) && 
                (
                    this.OrderId == input.OrderId ||
                    (this.OrderId != null &&
                    this.OrderId.Equals(input.OrderId))
                ) && 
                (
                    this.PickingMissionItemId == input.PickingMissionItemId ||
                    (this.PickingMissionItemId != null &&
                    this.PickingMissionItemId.Equals(input.PickingMissionItemId))
                ) && 
                (
                    this.PropertyBag == input.PropertyBag ||
                    this.PropertyBag != null &&
                    input.PropertyBag != null &&
                    this.PropertyBag.SequenceEqual(input.PropertyBag)
                ) && 
                (
                    this.ShipmentId == input.ShipmentId ||
                    (this.ShipmentId != null &&
                    this.ShipmentId.Equals(input.ShipmentId))
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.LineItemId != null)
                    hashCode = hashCode * 59 + this.LineItemId.GetHashCode();
                if (this.OrderId != null)
                    hashCode = hashCode * 59 + this.OrderId.GetHashCode();
                if (this.PickingMissionItemId != null)
                    hashCode = hashCode * 59 + this.PickingMissionItemId.GetHashCode();
                if (this.PropertyBag != null)
                    hashCode = hashCode * 59 + this.PropertyBag.GetHashCode();
                if (this.ShipmentId != null)
                    hashCode = hashCode * 59 + this.ShipmentId.GetHashCode();
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
