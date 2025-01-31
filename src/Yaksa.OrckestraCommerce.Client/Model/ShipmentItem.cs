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
    /// ShipmentItem
    /// </summary>
    [DataContract(Name = "ShipmentItem")]
    public partial class ShipmentItem : IEquatable<ShipmentItem>, IValidatableObject
    {
        /// <summary>
        /// The execution result of the shipment processing.
        /// </summary>
        /// <value>The execution result of the shipment processing.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ExecutionResultEnum
        {
            /// <summary>
            /// Enum Success for value: Success
            /// </summary>
            [EnumMember(Value = "Success")]
            Success = 1,

            /// <summary>
            /// Enum Warning for value: Warning
            /// </summary>
            [EnumMember(Value = "Warning")]
            Warning = 2,

            /// <summary>
            /// Enum Error for value: Error
            /// </summary>
            [EnumMember(Value = "Error")]
            Error = 3,

            /// <summary>
            /// Enum Critical for value: Critical
            /// </summary>
            [EnumMember(Value = "Critical")]
            Critical = 4,

            /// <summary>
            /// Enum Failure for value: Failure
            /// </summary>
            [EnumMember(Value = "Failure")]
            Failure = 5

        }


        /// <summary>
        /// The execution result of the shipment processing.
        /// </summary>
        /// <value>The execution result of the shipment processing.</value>
        [DataMember(Name = "executionResult", EmitDefaultValue = false)]
        public ExecutionResultEnum? ExecutionResult { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ShipmentItem" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ShipmentItem() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ShipmentItem" /> class.
        /// </summary>
        /// <param name="id">The unique identifier of the entity. (required).</param>
        /// <param name="propertyBag">propertyBag.</param>
        /// <param name="executionResult">The execution result of the shipment processing..</param>
        /// <param name="expectedDeliveryDate">The expected delivery date..</param>
        /// <param name="fulfillmentLocationId">The fulfillment location id..</param>
        /// <param name="fulfillmentScheduledTimeBeginDate">The begin date and time scheduled for the fulfillment..</param>
        /// <param name="fulfillmentScheduledTimeEndDate">The end date and time scheduled for the fulfillment..</param>
        /// <param name="messages">The execution messages when the shipment was processed..</param>
        /// <param name="pickUpLocationId">The pick-up location identifier required when the selected shipping method type is ship to store; any value will be ignored otherwise..</param>
        /// <param name="shippingAddress">shippingAddress.</param>
        /// <param name="validationResults">The validation results when the shipment was processed..</param>
        /// <param name="slAs">slAs.</param>
        public ShipmentItem(string id = default(string), Dictionary<string, Object> propertyBag = default(Dictionary<string, Object>), ExecutionResultEnum? executionResult = default(ExecutionResultEnum?), DateTime expectedDeliveryDate = default(DateTime), string fulfillmentLocationId = default(string), DateTime fulfillmentScheduledTimeBeginDate = default(DateTime), DateTime fulfillmentScheduledTimeEndDate = default(DateTime), List<ExecutionMessage> messages = default(List<ExecutionMessage>), string pickUpLocationId = default(string), Address shippingAddress = default(Address), List<ValidationResult> validationResults = default(List<ValidationResult>), List<OrderFulfillmentSLA> slAs = default(List<OrderFulfillmentSLA>))
        {
            // to ensure "id" is required (not null)
            this.Id = id ?? throw new ArgumentNullException("id is a required property for ShipmentItem and cannot be null");
            this.PropertyBag = propertyBag;
            this.ExecutionResult = executionResult;
            this.ExpectedDeliveryDate = expectedDeliveryDate;
            this.FulfillmentLocationId = fulfillmentLocationId;
            this.FulfillmentScheduledTimeBeginDate = fulfillmentScheduledTimeBeginDate;
            this.FulfillmentScheduledTimeEndDate = fulfillmentScheduledTimeEndDate;
            this.Messages = messages;
            this.PickUpLocationId = pickUpLocationId;
            this.ShippingAddress = shippingAddress;
            this.ValidationResults = validationResults;
            this.SlAs = slAs;
        }

        /// <summary>
        /// The unique identifier of the entity.
        /// </summary>
        /// <value>The unique identifier of the entity.</value>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets PropertyBag
        /// </summary>
        [DataMember(Name = "propertyBag", EmitDefaultValue = false)]
        public Dictionary<string, Object> PropertyBag { get; set; }

        /// <summary>
        /// The expected delivery date.
        /// </summary>
        /// <value>The expected delivery date.</value>
        [DataMember(Name = "expectedDeliveryDate", EmitDefaultValue = false)]
        public DateTime ExpectedDeliveryDate { get; set; }

        /// <summary>
        /// The fulfillment location id.
        /// </summary>
        /// <value>The fulfillment location id.</value>
        [DataMember(Name = "fulfillmentLocationId", EmitDefaultValue = false)]
        public string FulfillmentLocationId { get; set; }

        /// <summary>
        /// The begin date and time scheduled for the fulfillment.
        /// </summary>
        /// <value>The begin date and time scheduled for the fulfillment.</value>
        [DataMember(Name = "fulfillmentScheduledTimeBeginDate", EmitDefaultValue = false)]
        public DateTime FulfillmentScheduledTimeBeginDate { get; set; }

        /// <summary>
        /// The end date and time scheduled for the fulfillment.
        /// </summary>
        /// <value>The end date and time scheduled for the fulfillment.</value>
        [DataMember(Name = "fulfillmentScheduledTimeEndDate", EmitDefaultValue = false)]
        public DateTime FulfillmentScheduledTimeEndDate { get; set; }

        /// <summary>
        /// The execution messages when the shipment was processed.
        /// </summary>
        /// <value>The execution messages when the shipment was processed.</value>
        [DataMember(Name = "messages", EmitDefaultValue = false)]
        public List<ExecutionMessage> Messages { get; set; }

        /// <summary>
        /// The pick-up location identifier required when the selected shipping method type is ship to store; any value will be ignored otherwise.
        /// </summary>
        /// <value>The pick-up location identifier required when the selected shipping method type is ship to store; any value will be ignored otherwise.</value>
        [DataMember(Name = "pickUpLocationId", EmitDefaultValue = false)]
        public string PickUpLocationId { get; set; }

        /// <summary>
        /// Gets or Sets ShippingAddress
        /// </summary>
        [DataMember(Name = "shippingAddress", EmitDefaultValue = false)]
        public Address ShippingAddress { get; set; }

        /// <summary>
        /// The validation results when the shipment was processed.
        /// </summary>
        /// <value>The validation results when the shipment was processed.</value>
        [DataMember(Name = "validationResults", EmitDefaultValue = false)]
        public List<ValidationResult> ValidationResults { get; set; }

        /// <summary>
        /// Gets or Sets SlAs
        /// </summary>
        [DataMember(Name = "slAs", EmitDefaultValue = false)]
        public List<OrderFulfillmentSLA> SlAs { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShipmentItem {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  PropertyBag: ").Append(PropertyBag).Append("\n");
            sb.Append("  ExecutionResult: ").Append(ExecutionResult).Append("\n");
            sb.Append("  ExpectedDeliveryDate: ").Append(ExpectedDeliveryDate).Append("\n");
            sb.Append("  FulfillmentLocationId: ").Append(FulfillmentLocationId).Append("\n");
            sb.Append("  FulfillmentScheduledTimeBeginDate: ").Append(FulfillmentScheduledTimeBeginDate).Append("\n");
            sb.Append("  FulfillmentScheduledTimeEndDate: ").Append(FulfillmentScheduledTimeEndDate).Append("\n");
            sb.Append("  Messages: ").Append(Messages).Append("\n");
            sb.Append("  PickUpLocationId: ").Append(PickUpLocationId).Append("\n");
            sb.Append("  ShippingAddress: ").Append(ShippingAddress).Append("\n");
            sb.Append("  ValidationResults: ").Append(ValidationResults).Append("\n");
            sb.Append("  SlAs: ").Append(SlAs).Append("\n");
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
            return this.Equals(input as ShipmentItem);
        }

        /// <summary>
        /// Returns true if ShipmentItem instances are equal
        /// </summary>
        /// <param name="input">Instance of ShipmentItem to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ShipmentItem input)
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
                    this.PropertyBag == input.PropertyBag ||
                    this.PropertyBag != null &&
                    input.PropertyBag != null &&
                    this.PropertyBag.SequenceEqual(input.PropertyBag)
                ) && 
                (
                    this.ExecutionResult == input.ExecutionResult ||
                    this.ExecutionResult.Equals(input.ExecutionResult)
                ) && 
                (
                    this.ExpectedDeliveryDate == input.ExpectedDeliveryDate ||
                    (this.ExpectedDeliveryDate != null &&
                    this.ExpectedDeliveryDate.Equals(input.ExpectedDeliveryDate))
                ) && 
                (
                    this.FulfillmentLocationId == input.FulfillmentLocationId ||
                    (this.FulfillmentLocationId != null &&
                    this.FulfillmentLocationId.Equals(input.FulfillmentLocationId))
                ) && 
                (
                    this.FulfillmentScheduledTimeBeginDate == input.FulfillmentScheduledTimeBeginDate ||
                    (this.FulfillmentScheduledTimeBeginDate != null &&
                    this.FulfillmentScheduledTimeBeginDate.Equals(input.FulfillmentScheduledTimeBeginDate))
                ) && 
                (
                    this.FulfillmentScheduledTimeEndDate == input.FulfillmentScheduledTimeEndDate ||
                    (this.FulfillmentScheduledTimeEndDate != null &&
                    this.FulfillmentScheduledTimeEndDate.Equals(input.FulfillmentScheduledTimeEndDate))
                ) && 
                (
                    this.Messages == input.Messages ||
                    this.Messages != null &&
                    input.Messages != null &&
                    this.Messages.SequenceEqual(input.Messages)
                ) && 
                (
                    this.PickUpLocationId == input.PickUpLocationId ||
                    (this.PickUpLocationId != null &&
                    this.PickUpLocationId.Equals(input.PickUpLocationId))
                ) && 
                (
                    this.ShippingAddress == input.ShippingAddress ||
                    (this.ShippingAddress != null &&
                    this.ShippingAddress.Equals(input.ShippingAddress))
                ) && 
                (
                    this.ValidationResults == input.ValidationResults ||
                    this.ValidationResults != null &&
                    input.ValidationResults != null &&
                    this.ValidationResults.SequenceEqual(input.ValidationResults)
                ) && 
                (
                    this.SlAs == input.SlAs ||
                    this.SlAs != null &&
                    input.SlAs != null &&
                    this.SlAs.SequenceEqual(input.SlAs)
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
                if (this.PropertyBag != null)
                    hashCode = hashCode * 59 + this.PropertyBag.GetHashCode();
                hashCode = hashCode * 59 + this.ExecutionResult.GetHashCode();
                if (this.ExpectedDeliveryDate != null)
                    hashCode = hashCode * 59 + this.ExpectedDeliveryDate.GetHashCode();
                if (this.FulfillmentLocationId != null)
                    hashCode = hashCode * 59 + this.FulfillmentLocationId.GetHashCode();
                if (this.FulfillmentScheduledTimeBeginDate != null)
                    hashCode = hashCode * 59 + this.FulfillmentScheduledTimeBeginDate.GetHashCode();
                if (this.FulfillmentScheduledTimeEndDate != null)
                    hashCode = hashCode * 59 + this.FulfillmentScheduledTimeEndDate.GetHashCode();
                if (this.Messages != null)
                    hashCode = hashCode * 59 + this.Messages.GetHashCode();
                if (this.PickUpLocationId != null)
                    hashCode = hashCode * 59 + this.PickUpLocationId.GetHashCode();
                if (this.ShippingAddress != null)
                    hashCode = hashCode * 59 + this.ShippingAddress.GetHashCode();
                if (this.ValidationResults != null)
                    hashCode = hashCode * 59 + this.ValidationResults.GetHashCode();
                if (this.SlAs != null)
                    hashCode = hashCode * 59 + this.SlAs.GetHashCode();
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
