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
    /// FulfillmentSchedule
    /// </summary>
    [DataContract(Name = "FulfillmentSchedule")]
    public partial class FulfillmentSchedule : IEquatable<FulfillmentSchedule>, IValidatableObject
    {
        /// <summary>
        /// the type of the schedule.
        /// </summary>
        /// <value>the type of the schedule.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ScheduleTypeEnum
        {
            /// <summary>
            /// Enum OpeningHours for value: OpeningHours
            /// </summary>
            [EnumMember(Value = "OpeningHours")]
            OpeningHours = 1,

            /// <summary>
            /// Enum Delivery for value: Delivery
            /// </summary>
            [EnumMember(Value = "Delivery")]
            Delivery = 2,

            /// <summary>
            /// Enum Pickup for value: Pickup
            /// </summary>
            [EnumMember(Value = "Pickup")]
            Pickup = 3

        }


        /// <summary>
        /// the type of the schedule.
        /// </summary>
        /// <value>the type of the schedule.</value>
        [DataMember(Name = "scheduleType", EmitDefaultValue = false)]
        public ScheduleTypeEnum? ScheduleType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="FulfillmentSchedule" /> class.
        /// </summary>
        /// <param name="fulfillmentLocationId">A unique identifier for the FulfillmentLocation..</param>
        /// <param name="openingHourExceptions">This collection will contain every exception of the regular hours entered for the store or warehouse..</param>
        /// <param name="openingHours">This collection will contain one OpeningHour for each calendar week day..</param>
        /// <param name="propertyBag">propertyBag.</param>
        /// <param name="scheduleType">the type of the schedule..</param>
        public FulfillmentSchedule(string fulfillmentLocationId = default(string), List<DailyScheduleException> openingHourExceptions = default(List<DailyScheduleException>), List<DailySchedule> openingHours = default(List<DailySchedule>), Dictionary<string, Object> propertyBag = default(Dictionary<string, Object>), ScheduleTypeEnum? scheduleType = default(ScheduleTypeEnum?))
        {
            this.FulfillmentLocationId = fulfillmentLocationId;
            this.OpeningHourExceptions = openingHourExceptions;
            this.OpeningHours = openingHours;
            this.PropertyBag = propertyBag;
            this.ScheduleType = scheduleType;
        }

        /// <summary>
        /// A unique identifier for the FulfillmentLocation.
        /// </summary>
        /// <value>A unique identifier for the FulfillmentLocation.</value>
        [DataMember(Name = "fulfillmentLocationId", EmitDefaultValue = false)]
        public string FulfillmentLocationId { get; set; }

        /// <summary>
        /// This collection will contain every exception of the regular hours entered for the store or warehouse.
        /// </summary>
        /// <value>This collection will contain every exception of the regular hours entered for the store or warehouse.</value>
        [DataMember(Name = "openingHourExceptions", EmitDefaultValue = false)]
        public List<DailyScheduleException> OpeningHourExceptions { get; set; }

        /// <summary>
        /// This collection will contain one OpeningHour for each calendar week day.
        /// </summary>
        /// <value>This collection will contain one OpeningHour for each calendar week day.</value>
        [DataMember(Name = "openingHours", EmitDefaultValue = false)]
        public List<DailySchedule> OpeningHours { get; set; }

        /// <summary>
        /// Gets or Sets PropertyBag
        /// </summary>
        [DataMember(Name = "propertyBag", EmitDefaultValue = false)]
        public Dictionary<string, Object> PropertyBag { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FulfillmentSchedule {\n");
            sb.Append("  FulfillmentLocationId: ").Append(FulfillmentLocationId).Append("\n");
            sb.Append("  OpeningHourExceptions: ").Append(OpeningHourExceptions).Append("\n");
            sb.Append("  OpeningHours: ").Append(OpeningHours).Append("\n");
            sb.Append("  PropertyBag: ").Append(PropertyBag).Append("\n");
            sb.Append("  ScheduleType: ").Append(ScheduleType).Append("\n");
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
            return this.Equals(input as FulfillmentSchedule);
        }

        /// <summary>
        /// Returns true if FulfillmentSchedule instances are equal
        /// </summary>
        /// <param name="input">Instance of FulfillmentSchedule to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FulfillmentSchedule input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.FulfillmentLocationId == input.FulfillmentLocationId ||
                    (this.FulfillmentLocationId != null &&
                    this.FulfillmentLocationId.Equals(input.FulfillmentLocationId))
                ) && 
                (
                    this.OpeningHourExceptions == input.OpeningHourExceptions ||
                    this.OpeningHourExceptions != null &&
                    input.OpeningHourExceptions != null &&
                    this.OpeningHourExceptions.SequenceEqual(input.OpeningHourExceptions)
                ) && 
                (
                    this.OpeningHours == input.OpeningHours ||
                    this.OpeningHours != null &&
                    input.OpeningHours != null &&
                    this.OpeningHours.SequenceEqual(input.OpeningHours)
                ) && 
                (
                    this.PropertyBag == input.PropertyBag ||
                    this.PropertyBag != null &&
                    input.PropertyBag != null &&
                    this.PropertyBag.SequenceEqual(input.PropertyBag)
                ) && 
                (
                    this.ScheduleType == input.ScheduleType ||
                    this.ScheduleType.Equals(input.ScheduleType)
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
                if (this.FulfillmentLocationId != null)
                    hashCode = hashCode * 59 + this.FulfillmentLocationId.GetHashCode();
                if (this.OpeningHourExceptions != null)
                    hashCode = hashCode * 59 + this.OpeningHourExceptions.GetHashCode();
                if (this.OpeningHours != null)
                    hashCode = hashCode * 59 + this.OpeningHours.GetHashCode();
                if (this.PropertyBag != null)
                    hashCode = hashCode * 59 + this.PropertyBag.GetHashCode();
                hashCode = hashCode * 59 + this.ScheduleType.GetHashCode();
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
