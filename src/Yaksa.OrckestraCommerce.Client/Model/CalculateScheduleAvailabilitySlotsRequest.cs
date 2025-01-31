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
    [DataContract(Name = "CalculateScheduleAvailabilitySlotsRequest")]
    public partial class CalculateScheduleAvailabilitySlotsRequest : IEquatable<CalculateScheduleAvailabilitySlotsRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CalculateScheduleAvailabilitySlotsRequest" /> class.
        /// </summary>
        /// <param name="scopeId">The id of the requested scope.</param>
        /// <param name="calculateReservationSummary">A value indicating whether the reservatiom summary will be calculated..</param>
        /// <param name="dayOfWeekFilter">The day of week to filter (default is all days). Valid entries are Sunday through Saturday..</param>
        /// <param name="endDate">The date of the last day to calculate for (time should not be included)..</param>
        /// <param name="endTime">The end time of the period to consider the availability..</param>
        /// <param name="excludeTimeSlotsOutsideTimeRange">A value indicating whether timeslots are returned if they are outside the time range..</param>
        /// <param name="orderId">the unique identifier of the Order..</param>
        /// <param name="overridenLeadTime">the optional override lead time, if set, the lead time for the store operating status will not be used..</param>
        /// <param name="shipmentId">the unique identifier of the Shipment..</param>
        /// <param name="startDate">The date of the first day to calculate for (time should not be included)..</param>
        /// <param name="startTime">The start time of the period to consider the availability..</param>
        public CalculateScheduleAvailabilitySlotsRequest(string scopeId = default(string), bool calculateReservationSummary = default(bool), List<string> dayOfWeekFilter = default(List<string>), DateTime endDate = default(DateTime), string endTime = default(string), bool excludeTimeSlotsOutsideTimeRange = default(bool), string orderId = default(string), string overridenLeadTime = default(string), string shipmentId = default(string), DateTime startDate = default(DateTime), string startTime = default(string))
        {
            this.ScopeId = scopeId;
            this.CalculateReservationSummary = calculateReservationSummary;
            this.DayOfWeekFilter = dayOfWeekFilter;
            this.EndDate = endDate;
            this.EndTime = endTime;
            this.ExcludeTimeSlotsOutsideTimeRange = excludeTimeSlotsOutsideTimeRange;
            this.OrderId = orderId;
            this.OverridenLeadTime = overridenLeadTime;
            this.ShipmentId = shipmentId;
            this.StartDate = startDate;
            this.StartTime = startTime;
        }

        /// <summary>
        /// The id of the requested scope
        /// </summary>
        /// <value>The id of the requested scope</value>
        [DataMember(Name = "scopeId", EmitDefaultValue = false)]
        public string ScopeId { get; set; }

        /// <summary>
        /// A value indicating whether the reservatiom summary will be calculated.
        /// </summary>
        /// <value>A value indicating whether the reservatiom summary will be calculated.</value>
        [DataMember(Name = "calculateReservationSummary", EmitDefaultValue = true)]
        public bool CalculateReservationSummary { get; set; }

        /// <summary>
        /// The day of week to filter (default is all days). Valid entries are Sunday through Saturday.
        /// </summary>
        /// <value>The day of week to filter (default is all days). Valid entries are Sunday through Saturday.</value>
        [DataMember(Name = "dayOfWeekFilter", EmitDefaultValue = false)]
        public List<string> DayOfWeekFilter { get; set; }

        /// <summary>
        /// The date of the last day to calculate for (time should not be included).
        /// </summary>
        /// <value>The date of the last day to calculate for (time should not be included).</value>
        [DataMember(Name = "endDate", EmitDefaultValue = false)]
        public DateTime EndDate { get; set; }

        /// <summary>
        /// The end time of the period to consider the availability.
        /// </summary>
        /// <value>The end time of the period to consider the availability.</value>
        [DataMember(Name = "endTime", EmitDefaultValue = false)]
        public string EndTime { get; set; }

        /// <summary>
        /// A value indicating whether timeslots are returned if they are outside the time range.
        /// </summary>
        /// <value>A value indicating whether timeslots are returned if they are outside the time range.</value>
        [DataMember(Name = "excludeTimeSlotsOutsideTimeRange", EmitDefaultValue = true)]
        public bool ExcludeTimeSlotsOutsideTimeRange { get; set; }

        /// <summary>
        /// the unique identifier of the Order.
        /// </summary>
        /// <value>the unique identifier of the Order.</value>
        [DataMember(Name = "orderId", EmitDefaultValue = false)]
        public string OrderId { get; set; }

        /// <summary>
        /// the optional override lead time, if set, the lead time for the store operating status will not be used.
        /// </summary>
        /// <value>the optional override lead time, if set, the lead time for the store operating status will not be used.</value>
        [DataMember(Name = "overridenLeadTime", EmitDefaultValue = false)]
        public string OverridenLeadTime { get; set; }

        /// <summary>
        /// the unique identifier of the Shipment.
        /// </summary>
        /// <value>the unique identifier of the Shipment.</value>
        [DataMember(Name = "shipmentId", EmitDefaultValue = false)]
        public string ShipmentId { get; set; }

        /// <summary>
        /// The date of the first day to calculate for (time should not be included).
        /// </summary>
        /// <value>The date of the first day to calculate for (time should not be included).</value>
        [DataMember(Name = "startDate", EmitDefaultValue = false)]
        public DateTime StartDate { get; set; }

        /// <summary>
        /// The start time of the period to consider the availability.
        /// </summary>
        /// <value>The start time of the period to consider the availability.</value>
        [DataMember(Name = "startTime", EmitDefaultValue = false)]
        public string StartTime { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CalculateScheduleAvailabilitySlotsRequest {\n");
            sb.Append("  ScopeId: ").Append(ScopeId).Append("\n");
            sb.Append("  CalculateReservationSummary: ").Append(CalculateReservationSummary).Append("\n");
            sb.Append("  DayOfWeekFilter: ").Append(DayOfWeekFilter).Append("\n");
            sb.Append("  EndDate: ").Append(EndDate).Append("\n");
            sb.Append("  EndTime: ").Append(EndTime).Append("\n");
            sb.Append("  ExcludeTimeSlotsOutsideTimeRange: ").Append(ExcludeTimeSlotsOutsideTimeRange).Append("\n");
            sb.Append("  OrderId: ").Append(OrderId).Append("\n");
            sb.Append("  OverridenLeadTime: ").Append(OverridenLeadTime).Append("\n");
            sb.Append("  ShipmentId: ").Append(ShipmentId).Append("\n");
            sb.Append("  StartDate: ").Append(StartDate).Append("\n");
            sb.Append("  StartTime: ").Append(StartTime).Append("\n");
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
            return this.Equals(input as CalculateScheduleAvailabilitySlotsRequest);
        }

        /// <summary>
        /// Returns true if CalculateScheduleAvailabilitySlotsRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of CalculateScheduleAvailabilitySlotsRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CalculateScheduleAvailabilitySlotsRequest input)
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
                    this.CalculateReservationSummary == input.CalculateReservationSummary ||
                    this.CalculateReservationSummary.Equals(input.CalculateReservationSummary)
                ) && 
                (
                    this.DayOfWeekFilter == input.DayOfWeekFilter ||
                    this.DayOfWeekFilter != null &&
                    input.DayOfWeekFilter != null &&
                    this.DayOfWeekFilter.SequenceEqual(input.DayOfWeekFilter)
                ) && 
                (
                    this.EndDate == input.EndDate ||
                    (this.EndDate != null &&
                    this.EndDate.Equals(input.EndDate))
                ) && 
                (
                    this.EndTime == input.EndTime ||
                    (this.EndTime != null &&
                    this.EndTime.Equals(input.EndTime))
                ) && 
                (
                    this.ExcludeTimeSlotsOutsideTimeRange == input.ExcludeTimeSlotsOutsideTimeRange ||
                    this.ExcludeTimeSlotsOutsideTimeRange.Equals(input.ExcludeTimeSlotsOutsideTimeRange)
                ) && 
                (
                    this.OrderId == input.OrderId ||
                    (this.OrderId != null &&
                    this.OrderId.Equals(input.OrderId))
                ) && 
                (
                    this.OverridenLeadTime == input.OverridenLeadTime ||
                    (this.OverridenLeadTime != null &&
                    this.OverridenLeadTime.Equals(input.OverridenLeadTime))
                ) && 
                (
                    this.ShipmentId == input.ShipmentId ||
                    (this.ShipmentId != null &&
                    this.ShipmentId.Equals(input.ShipmentId))
                ) && 
                (
                    this.StartDate == input.StartDate ||
                    (this.StartDate != null &&
                    this.StartDate.Equals(input.StartDate))
                ) && 
                (
                    this.StartTime == input.StartTime ||
                    (this.StartTime != null &&
                    this.StartTime.Equals(input.StartTime))
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
                hashCode = hashCode * 59 + this.CalculateReservationSummary.GetHashCode();
                if (this.DayOfWeekFilter != null)
                    hashCode = hashCode * 59 + this.DayOfWeekFilter.GetHashCode();
                if (this.EndDate != null)
                    hashCode = hashCode * 59 + this.EndDate.GetHashCode();
                if (this.EndTime != null)
                    hashCode = hashCode * 59 + this.EndTime.GetHashCode();
                hashCode = hashCode * 59 + this.ExcludeTimeSlotsOutsideTimeRange.GetHashCode();
                if (this.OrderId != null)
                    hashCode = hashCode * 59 + this.OrderId.GetHashCode();
                if (this.OverridenLeadTime != null)
                    hashCode = hashCode * 59 + this.OverridenLeadTime.GetHashCode();
                if (this.ShipmentId != null)
                    hashCode = hashCode * 59 + this.ShipmentId.GetHashCode();
                if (this.StartDate != null)
                    hashCode = hashCode * 59 + this.StartDate.GetHashCode();
                if (this.StartTime != null)
                    hashCode = hashCode * 59 + this.StartTime.GetHashCode();
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
