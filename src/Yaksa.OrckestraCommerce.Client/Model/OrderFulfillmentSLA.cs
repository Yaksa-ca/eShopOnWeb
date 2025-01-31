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
    /// OrderFulfillmentSLA
    /// </summary>
    [DataContract(Name = "OrderFulfillmentSLA")]
    public partial class OrderFulfillmentSLA : IEquatable<OrderFulfillmentSLA>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OrderFulfillmentSLA" /> class.
        /// </summary>
        /// <param name="expirationDate">The time when the sla will expire..</param>
        /// <param name="expiryWarningTimeInMinutes">The expiry warning time in minutes..</param>
        /// <param name="fulfillmentLocationId">The fulfillment location identifier..</param>
        /// <param name="id">The fulfillment sla identifier..</param>
        /// <param name="name">The name..</param>
        /// <param name="orderId">The order identifier..</param>
        /// <param name="shipmentId">The shipment identifier..</param>
        public OrderFulfillmentSLA(DateTime expirationDate = default(DateTime), int expiryWarningTimeInMinutes = default(int), string fulfillmentLocationId = default(string), string id = default(string), string name = default(string), string orderId = default(string), string shipmentId = default(string))
        {
            this.ExpirationDate = expirationDate;
            this.ExpiryWarningTimeInMinutes = expiryWarningTimeInMinutes;
            this.FulfillmentLocationId = fulfillmentLocationId;
            this.Id = id;
            this.Name = name;
            this.OrderId = orderId;
            this.ShipmentId = shipmentId;
        }

        /// <summary>
        /// The time when the sla will expire.
        /// </summary>
        /// <value>The time when the sla will expire.</value>
        [DataMember(Name = "expirationDate", EmitDefaultValue = false)]
        public DateTime ExpirationDate { get; set; }

        /// <summary>
        /// The expiry warning time in minutes.
        /// </summary>
        /// <value>The expiry warning time in minutes.</value>
        [DataMember(Name = "expiryWarningTimeInMinutes", EmitDefaultValue = false)]
        public int ExpiryWarningTimeInMinutes { get; set; }

        /// <summary>
        /// The fulfillment location identifier.
        /// </summary>
        /// <value>The fulfillment location identifier.</value>
        [DataMember(Name = "fulfillmentLocationId", EmitDefaultValue = false)]
        public string FulfillmentLocationId { get; set; }

        /// <summary>
        /// The fulfillment sla identifier.
        /// </summary>
        /// <value>The fulfillment sla identifier.</value>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        /// The name.
        /// </summary>
        /// <value>The name.</value>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// The order identifier.
        /// </summary>
        /// <value>The order identifier.</value>
        [DataMember(Name = "orderId", EmitDefaultValue = false)]
        public string OrderId { get; set; }

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
            sb.Append("class OrderFulfillmentSLA {\n");
            sb.Append("  ExpirationDate: ").Append(ExpirationDate).Append("\n");
            sb.Append("  ExpiryWarningTimeInMinutes: ").Append(ExpiryWarningTimeInMinutes).Append("\n");
            sb.Append("  FulfillmentLocationId: ").Append(FulfillmentLocationId).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  OrderId: ").Append(OrderId).Append("\n");
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
            return this.Equals(input as OrderFulfillmentSLA);
        }

        /// <summary>
        /// Returns true if OrderFulfillmentSLA instances are equal
        /// </summary>
        /// <param name="input">Instance of OrderFulfillmentSLA to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OrderFulfillmentSLA input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ExpirationDate == input.ExpirationDate ||
                    (this.ExpirationDate != null &&
                    this.ExpirationDate.Equals(input.ExpirationDate))
                ) && 
                (
                    this.ExpiryWarningTimeInMinutes == input.ExpiryWarningTimeInMinutes ||
                    this.ExpiryWarningTimeInMinutes.Equals(input.ExpiryWarningTimeInMinutes)
                ) && 
                (
                    this.FulfillmentLocationId == input.FulfillmentLocationId ||
                    (this.FulfillmentLocationId != null &&
                    this.FulfillmentLocationId.Equals(input.FulfillmentLocationId))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.OrderId == input.OrderId ||
                    (this.OrderId != null &&
                    this.OrderId.Equals(input.OrderId))
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
                if (this.ExpirationDate != null)
                    hashCode = hashCode * 59 + this.ExpirationDate.GetHashCode();
                hashCode = hashCode * 59 + this.ExpiryWarningTimeInMinutes.GetHashCode();
                if (this.FulfillmentLocationId != null)
                    hashCode = hashCode * 59 + this.FulfillmentLocationId.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.OrderId != null)
                    hashCode = hashCode * 59 + this.OrderId.GetHashCode();
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
