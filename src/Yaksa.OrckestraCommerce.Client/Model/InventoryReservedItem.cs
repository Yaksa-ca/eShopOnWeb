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
    /// InventoryReservedItem
    /// </summary>
    [DataContract(Name = "InventoryReservedItem")]
    public partial class InventoryReservedItem : IEquatable<InventoryReservedItem>, IValidatableObject
    {
        /// <summary>
        /// The Owner type
        /// </summary>
        /// <value>The Owner type</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum OwnerTypeEnum
        {
            /// <summary>
            /// Enum Order for value: Order
            /// </summary>
            [EnumMember(Value = "Order")]
            Order = 1,

            /// <summary>
            /// Enum Cart for value: Cart
            /// </summary>
            [EnumMember(Value = "Cart")]
            Cart = 2,

            /// <summary>
            /// Enum OrderDraft for value: OrderDraft
            /// </summary>
            [EnumMember(Value = "OrderDraft")]
            OrderDraft = 3

        }


        /// <summary>
        /// The Owner type
        /// </summary>
        /// <value>The Owner type</value>
        [DataMember(Name = "ownerType", EmitDefaultValue = false)]
        public OwnerTypeEnum? OwnerType { get; set; }
        /// <summary>
        /// The inventory reservation status
        /// </summary>
        /// <value>The inventory reservation status</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ReservationStatusEnum
        {
            /// <summary>
            /// Enum Planned for value: Planned
            /// </summary>
            [EnumMember(Value = "Planned")]
            Planned = 1,

            /// <summary>
            /// Enum Confirmed for value: Confirmed
            /// </summary>
            [EnumMember(Value = "Confirmed")]
            Confirmed = 2,

            /// <summary>
            /// Enum Canceled for value: Canceled
            /// </summary>
            [EnumMember(Value = "Canceled")]
            Canceled = 3

        }


        /// <summary>
        /// The inventory reservation status
        /// </summary>
        /// <value>The inventory reservation status</value>
        [DataMember(Name = "reservationStatus", EmitDefaultValue = false)]
        public ReservationStatusEnum? ReservationStatus { get; set; }
        /// <summary>
        /// The inventory reservation stock status
        /// </summary>
        /// <value>The inventory reservation stock status</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StockStatusEnum
        {
            /// <summary>
            /// Enum InStock for value: InStock
            /// </summary>
            [EnumMember(Value = "InStock")]
            InStock = 1,

            /// <summary>
            /// Enum PreOrder for value: PreOrder
            /// </summary>
            [EnumMember(Value = "PreOrder")]
            PreOrder = 2,

            /// <summary>
            /// Enum BackOrder for value: BackOrder
            /// </summary>
            [EnumMember(Value = "BackOrder")]
            BackOrder = 3

        }


        /// <summary>
        /// The inventory reservation stock status
        /// </summary>
        /// <value>The inventory reservation stock status</value>
        [DataMember(Name = "stockStatus", EmitDefaultValue = false)]
        public StockStatusEnum? StockStatus { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="InventoryReservedItem" /> class.
        /// </summary>
        /// <param name="created">The created date.</param>
        /// <param name="id">The reservation identifier.</param>
        /// <param name="inventoryLocationId">The inventory location Id.</param>
        /// <param name="lastModifiedBy">The last user who modified the item.</param>
        /// <param name="lineItemId">The line item identifier.</param>
        /// <param name="modified">The last modified date.</param>
        /// <param name="ownerId">The unique identifier of the order, order draft or cart (according to the owner type).</param>
        /// <param name="ownerType">The Owner type.</param>
        /// <param name="quantity">The quantity of the reservation.</param>
        /// <param name="reservationStatus">The inventory reservation status.</param>
        /// <param name="sku">The line item sku.</param>
        /// <param name="stockStatus">The inventory reservation stock status.</param>
        public InventoryReservedItem(DateTime created = default(DateTime), string id = default(string), string inventoryLocationId = default(string), string lastModifiedBy = default(string), string lineItemId = default(string), DateTime modified = default(DateTime), string ownerId = default(string), OwnerTypeEnum? ownerType = default(OwnerTypeEnum?), double quantity = default(double), ReservationStatusEnum? reservationStatus = default(ReservationStatusEnum?), string sku = default(string), StockStatusEnum? stockStatus = default(StockStatusEnum?))
        {
            this.Created = created;
            this.Id = id;
            this.InventoryLocationId = inventoryLocationId;
            this.LastModifiedBy = lastModifiedBy;
            this.LineItemId = lineItemId;
            this.Modified = modified;
            this.OwnerId = ownerId;
            this.OwnerType = ownerType;
            this.Quantity = quantity;
            this.ReservationStatus = reservationStatus;
            this.Sku = sku;
            this.StockStatus = stockStatus;
        }

        /// <summary>
        /// The created date
        /// </summary>
        /// <value>The created date</value>
        [DataMember(Name = "created", EmitDefaultValue = false)]
        public DateTime Created { get; set; }

        /// <summary>
        /// The reservation identifier
        /// </summary>
        /// <value>The reservation identifier</value>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        /// The inventory location Id
        /// </summary>
        /// <value>The inventory location Id</value>
        [DataMember(Name = "inventoryLocationId", EmitDefaultValue = false)]
        public string InventoryLocationId { get; set; }

        /// <summary>
        /// The last user who modified the item
        /// </summary>
        /// <value>The last user who modified the item</value>
        [DataMember(Name = "lastModifiedBy", EmitDefaultValue = false)]
        public string LastModifiedBy { get; set; }

        /// <summary>
        /// The line item identifier
        /// </summary>
        /// <value>The line item identifier</value>
        [DataMember(Name = "lineItemId", EmitDefaultValue = false)]
        public string LineItemId { get; set; }

        /// <summary>
        /// The last modified date
        /// </summary>
        /// <value>The last modified date</value>
        [DataMember(Name = "modified", EmitDefaultValue = false)]
        public DateTime Modified { get; set; }

        /// <summary>
        /// The unique identifier of the order, order draft or cart (according to the owner type)
        /// </summary>
        /// <value>The unique identifier of the order, order draft or cart (according to the owner type)</value>
        [DataMember(Name = "ownerId", EmitDefaultValue = false)]
        public string OwnerId { get; set; }

        /// <summary>
        /// The quantity of the reservation
        /// </summary>
        /// <value>The quantity of the reservation</value>
        [DataMember(Name = "quantity", EmitDefaultValue = false)]
        public double Quantity { get; set; }

        /// <summary>
        /// The line item sku
        /// </summary>
        /// <value>The line item sku</value>
        [DataMember(Name = "sku", EmitDefaultValue = false)]
        public string Sku { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InventoryReservedItem {\n");
            sb.Append("  Created: ").Append(Created).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  InventoryLocationId: ").Append(InventoryLocationId).Append("\n");
            sb.Append("  LastModifiedBy: ").Append(LastModifiedBy).Append("\n");
            sb.Append("  LineItemId: ").Append(LineItemId).Append("\n");
            sb.Append("  Modified: ").Append(Modified).Append("\n");
            sb.Append("  OwnerId: ").Append(OwnerId).Append("\n");
            sb.Append("  OwnerType: ").Append(OwnerType).Append("\n");
            sb.Append("  Quantity: ").Append(Quantity).Append("\n");
            sb.Append("  ReservationStatus: ").Append(ReservationStatus).Append("\n");
            sb.Append("  Sku: ").Append(Sku).Append("\n");
            sb.Append("  StockStatus: ").Append(StockStatus).Append("\n");
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
            return this.Equals(input as InventoryReservedItem);
        }

        /// <summary>
        /// Returns true if InventoryReservedItem instances are equal
        /// </summary>
        /// <param name="input">Instance of InventoryReservedItem to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InventoryReservedItem input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Created == input.Created ||
                    (this.Created != null &&
                    this.Created.Equals(input.Created))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.InventoryLocationId == input.InventoryLocationId ||
                    (this.InventoryLocationId != null &&
                    this.InventoryLocationId.Equals(input.InventoryLocationId))
                ) && 
                (
                    this.LastModifiedBy == input.LastModifiedBy ||
                    (this.LastModifiedBy != null &&
                    this.LastModifiedBy.Equals(input.LastModifiedBy))
                ) && 
                (
                    this.LineItemId == input.LineItemId ||
                    (this.LineItemId != null &&
                    this.LineItemId.Equals(input.LineItemId))
                ) && 
                (
                    this.Modified == input.Modified ||
                    (this.Modified != null &&
                    this.Modified.Equals(input.Modified))
                ) && 
                (
                    this.OwnerId == input.OwnerId ||
                    (this.OwnerId != null &&
                    this.OwnerId.Equals(input.OwnerId))
                ) && 
                (
                    this.OwnerType == input.OwnerType ||
                    this.OwnerType.Equals(input.OwnerType)
                ) && 
                (
                    this.Quantity == input.Quantity ||
                    this.Quantity.Equals(input.Quantity)
                ) && 
                (
                    this.ReservationStatus == input.ReservationStatus ||
                    this.ReservationStatus.Equals(input.ReservationStatus)
                ) && 
                (
                    this.Sku == input.Sku ||
                    (this.Sku != null &&
                    this.Sku.Equals(input.Sku))
                ) && 
                (
                    this.StockStatus == input.StockStatus ||
                    this.StockStatus.Equals(input.StockStatus)
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
                if (this.Created != null)
                    hashCode = hashCode * 59 + this.Created.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.InventoryLocationId != null)
                    hashCode = hashCode * 59 + this.InventoryLocationId.GetHashCode();
                if (this.LastModifiedBy != null)
                    hashCode = hashCode * 59 + this.LastModifiedBy.GetHashCode();
                if (this.LineItemId != null)
                    hashCode = hashCode * 59 + this.LineItemId.GetHashCode();
                if (this.Modified != null)
                    hashCode = hashCode * 59 + this.Modified.GetHashCode();
                if (this.OwnerId != null)
                    hashCode = hashCode * 59 + this.OwnerId.GetHashCode();
                hashCode = hashCode * 59 + this.OwnerType.GetHashCode();
                hashCode = hashCode * 59 + this.Quantity.GetHashCode();
                hashCode = hashCode * 59 + this.ReservationStatus.GetHashCode();
                if (this.Sku != null)
                    hashCode = hashCode * 59 + this.Sku.GetHashCode();
                hashCode = hashCode * 59 + this.StockStatus.GetHashCode();
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
