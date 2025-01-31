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
    /// API calls used during the fulfillment process.
    /// </summary>
    [DataContract(Name = "FindFulfillmentCompetitionsCountRequest")]
    public partial class FindFulfillmentCompetitionsCountRequest : IEquatable<FindFulfillmentCompetitionsCountRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FindFulfillmentCompetitionsCountRequest" /> class.
        /// </summary>
        /// <param name="fulfillmentCompetitionLocationStatuses">The list of fulfillment competition location statuses..</param>
        /// <param name="fulfillmentCompetitionStatuses">The list of fulfillment competition statuses..</param>
        /// <param name="fulfillmentLocationId">The fulfillment location identifier..</param>
        /// <param name="orderId">The order identifier..</param>
        /// <param name="shipmentId">The shipment identifier..</param>
        public FindFulfillmentCompetitionsCountRequest(List<string> fulfillmentCompetitionLocationStatuses = default(List<string>), List<string> fulfillmentCompetitionStatuses = default(List<string>), string fulfillmentLocationId = default(string), string orderId = default(string), string shipmentId = default(string))
        {
            this.FulfillmentCompetitionLocationStatuses = fulfillmentCompetitionLocationStatuses;
            this.FulfillmentCompetitionStatuses = fulfillmentCompetitionStatuses;
            this.FulfillmentLocationId = fulfillmentLocationId;
            this.OrderId = orderId;
            this.ShipmentId = shipmentId;
        }

        /// <summary>
        /// The list of fulfillment competition location statuses.
        /// </summary>
        /// <value>The list of fulfillment competition location statuses.</value>
        [DataMember(Name = "fulfillmentCompetitionLocationStatuses", EmitDefaultValue = false)]
        public List<string> FulfillmentCompetitionLocationStatuses { get; set; }

        /// <summary>
        /// The list of fulfillment competition statuses.
        /// </summary>
        /// <value>The list of fulfillment competition statuses.</value>
        [DataMember(Name = "fulfillmentCompetitionStatuses", EmitDefaultValue = false)]
        public List<string> FulfillmentCompetitionStatuses { get; set; }

        /// <summary>
        /// The fulfillment location identifier.
        /// </summary>
        /// <value>The fulfillment location identifier.</value>
        [DataMember(Name = "fulfillmentLocationId", EmitDefaultValue = false)]
        public string FulfillmentLocationId { get; set; }

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
            sb.Append("class FindFulfillmentCompetitionsCountRequest {\n");
            sb.Append("  FulfillmentCompetitionLocationStatuses: ").Append(FulfillmentCompetitionLocationStatuses).Append("\n");
            sb.Append("  FulfillmentCompetitionStatuses: ").Append(FulfillmentCompetitionStatuses).Append("\n");
            sb.Append("  FulfillmentLocationId: ").Append(FulfillmentLocationId).Append("\n");
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
            return this.Equals(input as FindFulfillmentCompetitionsCountRequest);
        }

        /// <summary>
        /// Returns true if FindFulfillmentCompetitionsCountRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of FindFulfillmentCompetitionsCountRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FindFulfillmentCompetitionsCountRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.FulfillmentCompetitionLocationStatuses == input.FulfillmentCompetitionLocationStatuses ||
                    this.FulfillmentCompetitionLocationStatuses != null &&
                    input.FulfillmentCompetitionLocationStatuses != null &&
                    this.FulfillmentCompetitionLocationStatuses.SequenceEqual(input.FulfillmentCompetitionLocationStatuses)
                ) && 
                (
                    this.FulfillmentCompetitionStatuses == input.FulfillmentCompetitionStatuses ||
                    this.FulfillmentCompetitionStatuses != null &&
                    input.FulfillmentCompetitionStatuses != null &&
                    this.FulfillmentCompetitionStatuses.SequenceEqual(input.FulfillmentCompetitionStatuses)
                ) && 
                (
                    this.FulfillmentLocationId == input.FulfillmentLocationId ||
                    (this.FulfillmentLocationId != null &&
                    this.FulfillmentLocationId.Equals(input.FulfillmentLocationId))
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
                if (this.FulfillmentCompetitionLocationStatuses != null)
                    hashCode = hashCode * 59 + this.FulfillmentCompetitionLocationStatuses.GetHashCode();
                if (this.FulfillmentCompetitionStatuses != null)
                    hashCode = hashCode * 59 + this.FulfillmentCompetitionStatuses.GetHashCode();
                if (this.FulfillmentLocationId != null)
                    hashCode = hashCode * 59 + this.FulfillmentLocationId.GetHashCode();
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
