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
    /// Fulfillment locations are entities which handles fulfillment for a shipment.
    /// </summary>
    [DataContract(Name = "GetFulfillmentLocationTimeSlotReservationsRequest")]
    public partial class GetFulfillmentLocationTimeSlotReservationsRequest : IEquatable<GetFulfillmentLocationTimeSlotReservationsRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetFulfillmentLocationTimeSlotReservationsRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GetFulfillmentLocationTimeSlotReservationsRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="GetFulfillmentLocationTimeSlotReservationsRequest" /> class.
        /// </summary>
        /// <param name="scopeId">The id of the requested scope.</param>
        /// <param name="fulfillmentLocationId">the unique identifier of the Fulfillment location. (required).</param>
        /// <param name="reservationDate">The reservation date. (required).</param>
        /// <param name="slotId">The unique identifier of the time slot to be found (if not set, all timeslot ids are retrieved). (required).</param>
        public GetFulfillmentLocationTimeSlotReservationsRequest(string scopeId = default(string), string fulfillmentLocationId = default(string), DateTime reservationDate = default(DateTime), string slotId = default(string))
        {
            // to ensure "fulfillmentLocationId" is required (not null)
            this.FulfillmentLocationId = fulfillmentLocationId ?? throw new ArgumentNullException("fulfillmentLocationId is a required property for GetFulfillmentLocationTimeSlotReservationsRequest and cannot be null");
            this.ReservationDate = reservationDate;
            // to ensure "slotId" is required (not null)
            this.SlotId = slotId ?? throw new ArgumentNullException("slotId is a required property for GetFulfillmentLocationTimeSlotReservationsRequest and cannot be null");
            this.ScopeId = scopeId;
        }

        /// <summary>
        /// The id of the requested scope
        /// </summary>
        /// <value>The id of the requested scope</value>
        [DataMember(Name = "scopeId", EmitDefaultValue = false)]
        public string ScopeId { get; set; }

        /// <summary>
        /// the unique identifier of the Fulfillment location.
        /// </summary>
        /// <value>the unique identifier of the Fulfillment location.</value>
        [DataMember(Name = "fulfillmentLocationId", IsRequired = true, EmitDefaultValue = false)]
        public string FulfillmentLocationId { get; set; }

        /// <summary>
        /// The reservation date.
        /// </summary>
        /// <value>The reservation date.</value>
        [DataMember(Name = "reservationDate", IsRequired = true, EmitDefaultValue = false)]
        public DateTime ReservationDate { get; set; }

        /// <summary>
        /// The unique identifier of the time slot to be found (if not set, all timeslot ids are retrieved).
        /// </summary>
        /// <value>The unique identifier of the time slot to be found (if not set, all timeslot ids are retrieved).</value>
        [DataMember(Name = "slotId", IsRequired = true, EmitDefaultValue = false)]
        public string SlotId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GetFulfillmentLocationTimeSlotReservationsRequest {\n");
            sb.Append("  ScopeId: ").Append(ScopeId).Append("\n");
            sb.Append("  FulfillmentLocationId: ").Append(FulfillmentLocationId).Append("\n");
            sb.Append("  ReservationDate: ").Append(ReservationDate).Append("\n");
            sb.Append("  SlotId: ").Append(SlotId).Append("\n");
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
            return this.Equals(input as GetFulfillmentLocationTimeSlotReservationsRequest);
        }

        /// <summary>
        /// Returns true if GetFulfillmentLocationTimeSlotReservationsRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of GetFulfillmentLocationTimeSlotReservationsRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetFulfillmentLocationTimeSlotReservationsRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ScopeId == input.ScopeId ||
                    (this.ScopeId != null &&
                    this.ScopeId.Equals(input.ScopeId))
                ) && 
                (
                    this.FulfillmentLocationId == input.FulfillmentLocationId ||
                    (this.FulfillmentLocationId != null &&
                    this.FulfillmentLocationId.Equals(input.FulfillmentLocationId))
                ) && 
                (
                    this.ReservationDate == input.ReservationDate ||
                    (this.ReservationDate != null &&
                    this.ReservationDate.Equals(input.ReservationDate))
                ) && 
                (
                    this.SlotId == input.SlotId ||
                    (this.SlotId != null &&
                    this.SlotId.Equals(input.SlotId))
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
                if (this.ScopeId != null)
                    hashCode = hashCode * 59 + this.ScopeId.GetHashCode();
                if (this.FulfillmentLocationId != null)
                    hashCode = hashCode * 59 + this.FulfillmentLocationId.GetHashCode();
                if (this.ReservationDate != null)
                    hashCode = hashCode * 59 + this.ReservationDate.GetHashCode();
                if (this.SlotId != null)
                    hashCode = hashCode * 59 + this.SlotId.GetHashCode();
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
