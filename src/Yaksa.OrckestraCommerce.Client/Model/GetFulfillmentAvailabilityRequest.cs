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
    [DataContract(Name = "GetFulfillmentAvailabilityRequest")]
    public partial class GetFulfillmentAvailabilityRequest : IEquatable<GetFulfillmentAvailabilityRequest>, IValidatableObject
    {
        /// <summary>
        /// The FulfillmentMethodType to test.
        /// </summary>
        /// <value>The FulfillmentMethodType to test.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum FulfillmentMethodTypeEnum
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
        /// The FulfillmentMethodType to test.
        /// </summary>
        /// <value>The FulfillmentMethodType to test.</value>
        [DataMember(Name = "fulfillmentMethodType", IsRequired = true, EmitDefaultValue = false)]
        public FulfillmentMethodTypeEnum FulfillmentMethodType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="GetFulfillmentAvailabilityRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GetFulfillmentAvailabilityRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="GetFulfillmentAvailabilityRequest" /> class.
        /// </summary>
        /// <param name="datetime">The datetime to test. (required).</param>
        /// <param name="fulfillmentLocationId">the unique identifier of the Fulfillment location. (required).</param>
        /// <param name="fulfillmentMethodType">The FulfillmentMethodType to test. (required).</param>
        public GetFulfillmentAvailabilityRequest(DateTime datetime = default(DateTime), string fulfillmentLocationId = default(string), FulfillmentMethodTypeEnum fulfillmentMethodType = default(FulfillmentMethodTypeEnum))
        {
            this.Datetime = datetime;
            // to ensure "fulfillmentLocationId" is required (not null)
            this.FulfillmentLocationId = fulfillmentLocationId ?? throw new ArgumentNullException("fulfillmentLocationId is a required property for GetFulfillmentAvailabilityRequest and cannot be null");
            this.FulfillmentMethodType = fulfillmentMethodType;
        }

        /// <summary>
        /// The datetime to test.
        /// </summary>
        /// <value>The datetime to test.</value>
        [DataMember(Name = "datetime", IsRequired = true, EmitDefaultValue = false)]
        public DateTime Datetime { get; set; }

        /// <summary>
        /// the unique identifier of the Fulfillment location.
        /// </summary>
        /// <value>the unique identifier of the Fulfillment location.</value>
        [DataMember(Name = "fulfillmentLocationId", IsRequired = true, EmitDefaultValue = false)]
        public string FulfillmentLocationId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GetFulfillmentAvailabilityRequest {\n");
            sb.Append("  Datetime: ").Append(Datetime).Append("\n");
            sb.Append("  FulfillmentLocationId: ").Append(FulfillmentLocationId).Append("\n");
            sb.Append("  FulfillmentMethodType: ").Append(FulfillmentMethodType).Append("\n");
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
            return this.Equals(input as GetFulfillmentAvailabilityRequest);
        }

        /// <summary>
        /// Returns true if GetFulfillmentAvailabilityRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of GetFulfillmentAvailabilityRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetFulfillmentAvailabilityRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Datetime == input.Datetime ||
                    (this.Datetime != null &&
                    this.Datetime.Equals(input.Datetime))
                ) && 
                (
                    this.FulfillmentLocationId == input.FulfillmentLocationId ||
                    (this.FulfillmentLocationId != null &&
                    this.FulfillmentLocationId.Equals(input.FulfillmentLocationId))
                ) && 
                (
                    this.FulfillmentMethodType == input.FulfillmentMethodType ||
                    this.FulfillmentMethodType.Equals(input.FulfillmentMethodType)
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
                if (this.Datetime != null)
                    hashCode = hashCode * 59 + this.Datetime.GetHashCode();
                if (this.FulfillmentLocationId != null)
                    hashCode = hashCode * 59 + this.FulfillmentLocationId.GetHashCode();
                hashCode = hashCode * 59 + this.FulfillmentMethodType.GetHashCode();
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
