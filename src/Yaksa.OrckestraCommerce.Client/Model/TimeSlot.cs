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
    /// TimeSlot
    /// </summary>
    [DataContract(Name = "TimeSlot")]
    public partial class TimeSlot : IEquatable<TimeSlot>, IValidatableObject
    {
        /// <summary>
        /// The day of the time slot.
        /// </summary>
        /// <value>The day of the time slot.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum DayEnum
        {
            /// <summary>
            /// Enum Sunday for value: Sunday
            /// </summary>
            [EnumMember(Value = "Sunday")]
            Sunday = 1,

            /// <summary>
            /// Enum Monday for value: Monday
            /// </summary>
            [EnumMember(Value = "Monday")]
            Monday = 2,

            /// <summary>
            /// Enum Tuesday for value: Tuesday
            /// </summary>
            [EnumMember(Value = "Tuesday")]
            Tuesday = 3,

            /// <summary>
            /// Enum Wednesday for value: Wednesday
            /// </summary>
            [EnumMember(Value = "Wednesday")]
            Wednesday = 4,

            /// <summary>
            /// Enum Thursday for value: Thursday
            /// </summary>
            [EnumMember(Value = "Thursday")]
            Thursday = 5,

            /// <summary>
            /// Enum Friday for value: Friday
            /// </summary>
            [EnumMember(Value = "Friday")]
            Friday = 6,

            /// <summary>
            /// Enum Saturday for value: Saturday
            /// </summary>
            [EnumMember(Value = "Saturday")]
            Saturday = 7

        }


        /// <summary>
        /// The day of the time slot.
        /// </summary>
        /// <value>The day of the time slot.</value>
        [DataMember(Name = "day", IsRequired = true, EmitDefaultValue = false)]
        public DayEnum Day { get; set; }
        /// <summary>
        /// The fulfillment location type.
        /// </summary>
        /// <value>The fulfillment location type.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Enum Unspecified for value: Unspecified
            /// </summary>
            [EnumMember(Value = "Unspecified")]
            Unspecified = 1,

            /// <summary>
            /// Enum PickUp for value: PickUp
            /// </summary>
            [EnumMember(Value = "PickUp")]
            PickUp = 2,

            /// <summary>
            /// Enum Delivery for value: Delivery
            /// </summary>
            [EnumMember(Value = "Delivery")]
            Delivery = 3,

            /// <summary>
            /// Enum Shipping for value: Shipping
            /// </summary>
            [EnumMember(Value = "Shipping")]
            Shipping = 4,

            /// <summary>
            /// Enum ShipToStore for value: ShipToStore
            /// </summary>
            [EnumMember(Value = "ShipToStore")]
            ShipToStore = 5

        }


        /// <summary>
        /// The fulfillment location type.
        /// </summary>
        /// <value>The fulfillment location type.</value>
        [DataMember(Name = "type", IsRequired = true, EmitDefaultValue = false)]
        public TypeEnum Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="TimeSlot" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TimeSlot() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TimeSlot" /> class.
        /// </summary>
        /// <param name="comment">The comment of the time slot..</param>
        /// <param name="day">The day of the time slot. (required).</param>
        /// <param name="fulfillmentLocationlId">The unique identifier of a fulfillment location. (required).</param>
        /// <param name="id">The unique identifier of the time slot. (required).</param>
        /// <param name="quota">The quota of the time slot. (required).</param>
        /// <param name="slotBeginTime">The start time of the time slot. (required).</param>
        /// <param name="slotEndTime">The end time of the time slot. (required).</param>
        /// <param name="type">The fulfillment location type. (required).</param>
        public TimeSlot(string comment = default(string), DayEnum day = default(DayEnum), string fulfillmentLocationlId = default(string), string id = default(string), int quota = default(int), string slotBeginTime = default(string), string slotEndTime = default(string), TypeEnum type = default(TypeEnum))
        {
            this.Day = day;
            // to ensure "fulfillmentLocationlId" is required (not null)
            this.FulfillmentLocationlId = fulfillmentLocationlId ?? throw new ArgumentNullException("fulfillmentLocationlId is a required property for TimeSlot and cannot be null");
            // to ensure "id" is required (not null)
            this.Id = id ?? throw new ArgumentNullException("id is a required property for TimeSlot and cannot be null");
            this.Quota = quota;
            // to ensure "slotBeginTime" is required (not null)
            this.SlotBeginTime = slotBeginTime ?? throw new ArgumentNullException("slotBeginTime is a required property for TimeSlot and cannot be null");
            // to ensure "slotEndTime" is required (not null)
            this.SlotEndTime = slotEndTime ?? throw new ArgumentNullException("slotEndTime is a required property for TimeSlot and cannot be null");
            this.Type = type;
            this.Comment = comment;
        }

        /// <summary>
        /// The comment of the time slot.
        /// </summary>
        /// <value>The comment of the time slot.</value>
        [DataMember(Name = "comment", EmitDefaultValue = false)]
        public string Comment { get; set; }

        /// <summary>
        /// The unique identifier of a fulfillment location.
        /// </summary>
        /// <value>The unique identifier of a fulfillment location.</value>
        [DataMember(Name = "fulfillmentLocationlId", IsRequired = true, EmitDefaultValue = false)]
        public string FulfillmentLocationlId { get; set; }

        /// <summary>
        /// The unique identifier of the time slot.
        /// </summary>
        /// <value>The unique identifier of the time slot.</value>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        /// The quota of the time slot.
        /// </summary>
        /// <value>The quota of the time slot.</value>
        [DataMember(Name = "quota", IsRequired = true, EmitDefaultValue = false)]
        public int Quota { get; set; }

        /// <summary>
        /// The start time of the time slot.
        /// </summary>
        /// <value>The start time of the time slot.</value>
        [DataMember(Name = "slotBeginTime", IsRequired = true, EmitDefaultValue = false)]
        public string SlotBeginTime { get; set; }

        /// <summary>
        /// The end time of the time slot.
        /// </summary>
        /// <value>The end time of the time slot.</value>
        [DataMember(Name = "slotEndTime", IsRequired = true, EmitDefaultValue = false)]
        public string SlotEndTime { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TimeSlot {\n");
            sb.Append("  Comment: ").Append(Comment).Append("\n");
            sb.Append("  Day: ").Append(Day).Append("\n");
            sb.Append("  FulfillmentLocationlId: ").Append(FulfillmentLocationlId).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Quota: ").Append(Quota).Append("\n");
            sb.Append("  SlotBeginTime: ").Append(SlotBeginTime).Append("\n");
            sb.Append("  SlotEndTime: ").Append(SlotEndTime).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
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
            return this.Equals(input as TimeSlot);
        }

        /// <summary>
        /// Returns true if TimeSlot instances are equal
        /// </summary>
        /// <param name="input">Instance of TimeSlot to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TimeSlot input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Comment == input.Comment ||
                    (this.Comment != null &&
                    this.Comment.Equals(input.Comment))
                ) && 
                (
                    this.Day == input.Day ||
                    this.Day.Equals(input.Day)
                ) && 
                (
                    this.FulfillmentLocationlId == input.FulfillmentLocationlId ||
                    (this.FulfillmentLocationlId != null &&
                    this.FulfillmentLocationlId.Equals(input.FulfillmentLocationlId))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Quota == input.Quota ||
                    this.Quota.Equals(input.Quota)
                ) && 
                (
                    this.SlotBeginTime == input.SlotBeginTime ||
                    (this.SlotBeginTime != null &&
                    this.SlotBeginTime.Equals(input.SlotBeginTime))
                ) && 
                (
                    this.SlotEndTime == input.SlotEndTime ||
                    (this.SlotEndTime != null &&
                    this.SlotEndTime.Equals(input.SlotEndTime))
                ) && 
                (
                    this.Type == input.Type ||
                    this.Type.Equals(input.Type)
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
                if (this.Comment != null)
                    hashCode = hashCode * 59 + this.Comment.GetHashCode();
                hashCode = hashCode * 59 + this.Day.GetHashCode();
                if (this.FulfillmentLocationlId != null)
                    hashCode = hashCode * 59 + this.FulfillmentLocationlId.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                hashCode = hashCode * 59 + this.Quota.GetHashCode();
                if (this.SlotBeginTime != null)
                    hashCode = hashCode * 59 + this.SlotBeginTime.GetHashCode();
                if (this.SlotEndTime != null)
                    hashCode = hashCode * 59 + this.SlotEndTime.GetHashCode();
                hashCode = hashCode * 59 + this.Type.GetHashCode();
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
