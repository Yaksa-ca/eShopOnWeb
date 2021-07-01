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
    /// OrderFulfillmentState
    /// </summary>
    [DataContract(Name = "OrderFulfillmentState")]
    public partial class OrderFulfillmentState : IEquatable<OrderFulfillmentState>, IValidatableObject
    {
        /// <summary>
        /// The execution result of the order post processing.
        /// </summary>
        /// <value>The execution result of the order post processing.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ProcessingExecutionResultEnum
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
        /// The execution result of the order post processing.
        /// </summary>
        /// <value>The execution result of the order post processing.</value>
        [DataMember(Name = "processingExecutionResult", EmitDefaultValue = false)]
        public ProcessingExecutionResultEnum? ProcessingExecutionResult { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="OrderFulfillmentState" /> class.
        /// </summary>
        /// <param name="isCancelable">a calculated value assessment whether the whole order can be put canceled. This occurs only if all shipments can be put on canceled..</param>
        /// <param name="isHoldable">a calculated value assessment whether the whole order can be put on hold. This occurs only if all shipments can be put on hold..</param>
        /// <param name="isProcessing">value indicating whether if the order is being processed..</param>
        /// <param name="orderId">the unique system identifier.</param>
        /// <param name="orderNumber">The order number..</param>
        /// <param name="processingExecutionResult">The execution result of the order post processing..</param>
        /// <param name="processingMessages">The execution messages when the order was processed..</param>
        /// <param name="processingValidationResults">The validation results when the order was processed..</param>
        /// <param name="shipmentFulfillmentStates">the list of the order&#39;s list of shipment fulfillment state..</param>
        /// <param name="status">the current order status..</param>
        public OrderFulfillmentState(bool isCancelable = default(bool), bool isHoldable = default(bool), bool isProcessing = default(bool), string orderId = default(string), string orderNumber = default(string), ProcessingExecutionResultEnum? processingExecutionResult = default(ProcessingExecutionResultEnum?), List<ExecutionMessage> processingMessages = default(List<ExecutionMessage>), List<ValidationResult> processingValidationResults = default(List<ValidationResult>), List<ShipmentFulfillmentState> shipmentFulfillmentStates = default(List<ShipmentFulfillmentState>), string status = default(string))
        {
            this.IsCancelable = isCancelable;
            this.IsHoldable = isHoldable;
            this.IsProcessing = isProcessing;
            this.OrderId = orderId;
            this.OrderNumber = orderNumber;
            this.ProcessingExecutionResult = processingExecutionResult;
            this.ProcessingMessages = processingMessages;
            this.ProcessingValidationResults = processingValidationResults;
            this.ShipmentFulfillmentStates = shipmentFulfillmentStates;
            this.Status = status;
        }

        /// <summary>
        /// a calculated value assessment whether the whole order can be put canceled. This occurs only if all shipments can be put on canceled.
        /// </summary>
        /// <value>a calculated value assessment whether the whole order can be put canceled. This occurs only if all shipments can be put on canceled.</value>
        [DataMember(Name = "isCancelable", EmitDefaultValue = true)]
        public bool IsCancelable { get; set; }

        /// <summary>
        /// a calculated value assessment whether the whole order can be put on hold. This occurs only if all shipments can be put on hold.
        /// </summary>
        /// <value>a calculated value assessment whether the whole order can be put on hold. This occurs only if all shipments can be put on hold.</value>
        [DataMember(Name = "isHoldable", EmitDefaultValue = true)]
        public bool IsHoldable { get; set; }

        /// <summary>
        /// value indicating whether if the order is being processed.
        /// </summary>
        /// <value>value indicating whether if the order is being processed.</value>
        [DataMember(Name = "isProcessing", EmitDefaultValue = true)]
        public bool IsProcessing { get; set; }

        /// <summary>
        /// the unique system identifier
        /// </summary>
        /// <value>the unique system identifier</value>
        [DataMember(Name = "orderId", EmitDefaultValue = false)]
        public string OrderId { get; set; }

        /// <summary>
        /// The order number.
        /// </summary>
        /// <value>The order number.</value>
        [DataMember(Name = "orderNumber", EmitDefaultValue = false)]
        public string OrderNumber { get; set; }

        /// <summary>
        /// The execution messages when the order was processed.
        /// </summary>
        /// <value>The execution messages when the order was processed.</value>
        [DataMember(Name = "processingMessages", EmitDefaultValue = false)]
        public List<ExecutionMessage> ProcessingMessages { get; set; }

        /// <summary>
        /// The validation results when the order was processed.
        /// </summary>
        /// <value>The validation results when the order was processed.</value>
        [DataMember(Name = "processingValidationResults", EmitDefaultValue = false)]
        public List<ValidationResult> ProcessingValidationResults { get; set; }

        /// <summary>
        /// the list of the order&#39;s list of shipment fulfillment state.
        /// </summary>
        /// <value>the list of the order&#39;s list of shipment fulfillment state.</value>
        [DataMember(Name = "shipmentFulfillmentStates", EmitDefaultValue = false)]
        public List<ShipmentFulfillmentState> ShipmentFulfillmentStates { get; set; }

        /// <summary>
        /// the current order status.
        /// </summary>
        /// <value>the current order status.</value>
        [DataMember(Name = "status", EmitDefaultValue = false)]
        public string Status { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OrderFulfillmentState {\n");
            sb.Append("  IsCancelable: ").Append(IsCancelable).Append("\n");
            sb.Append("  IsHoldable: ").Append(IsHoldable).Append("\n");
            sb.Append("  IsProcessing: ").Append(IsProcessing).Append("\n");
            sb.Append("  OrderId: ").Append(OrderId).Append("\n");
            sb.Append("  OrderNumber: ").Append(OrderNumber).Append("\n");
            sb.Append("  ProcessingExecutionResult: ").Append(ProcessingExecutionResult).Append("\n");
            sb.Append("  ProcessingMessages: ").Append(ProcessingMessages).Append("\n");
            sb.Append("  ProcessingValidationResults: ").Append(ProcessingValidationResults).Append("\n");
            sb.Append("  ShipmentFulfillmentStates: ").Append(ShipmentFulfillmentStates).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
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
            return this.Equals(input as OrderFulfillmentState);
        }

        /// <summary>
        /// Returns true if OrderFulfillmentState instances are equal
        /// </summary>
        /// <param name="input">Instance of OrderFulfillmentState to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OrderFulfillmentState input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.IsCancelable == input.IsCancelable ||
                    this.IsCancelable.Equals(input.IsCancelable)
                ) && 
                (
                    this.IsHoldable == input.IsHoldable ||
                    this.IsHoldable.Equals(input.IsHoldable)
                ) && 
                (
                    this.IsProcessing == input.IsProcessing ||
                    this.IsProcessing.Equals(input.IsProcessing)
                ) && 
                (
                    this.OrderId == input.OrderId ||
                    (this.OrderId != null &&
                    this.OrderId.Equals(input.OrderId))
                ) && 
                (
                    this.OrderNumber == input.OrderNumber ||
                    (this.OrderNumber != null &&
                    this.OrderNumber.Equals(input.OrderNumber))
                ) && 
                (
                    this.ProcessingExecutionResult == input.ProcessingExecutionResult ||
                    this.ProcessingExecutionResult.Equals(input.ProcessingExecutionResult)
                ) && 
                (
                    this.ProcessingMessages == input.ProcessingMessages ||
                    this.ProcessingMessages != null &&
                    input.ProcessingMessages != null &&
                    this.ProcessingMessages.SequenceEqual(input.ProcessingMessages)
                ) && 
                (
                    this.ProcessingValidationResults == input.ProcessingValidationResults ||
                    this.ProcessingValidationResults != null &&
                    input.ProcessingValidationResults != null &&
                    this.ProcessingValidationResults.SequenceEqual(input.ProcessingValidationResults)
                ) && 
                (
                    this.ShipmentFulfillmentStates == input.ShipmentFulfillmentStates ||
                    this.ShipmentFulfillmentStates != null &&
                    input.ShipmentFulfillmentStates != null &&
                    this.ShipmentFulfillmentStates.SequenceEqual(input.ShipmentFulfillmentStates)
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
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
                hashCode = hashCode * 59 + this.IsCancelable.GetHashCode();
                hashCode = hashCode * 59 + this.IsHoldable.GetHashCode();
                hashCode = hashCode * 59 + this.IsProcessing.GetHashCode();
                if (this.OrderId != null)
                    hashCode = hashCode * 59 + this.OrderId.GetHashCode();
                if (this.OrderNumber != null)
                    hashCode = hashCode * 59 + this.OrderNumber.GetHashCode();
                hashCode = hashCode * 59 + this.ProcessingExecutionResult.GetHashCode();
                if (this.ProcessingMessages != null)
                    hashCode = hashCode * 59 + this.ProcessingMessages.GetHashCode();
                if (this.ProcessingValidationResults != null)
                    hashCode = hashCode * 59 + this.ProcessingValidationResults.GetHashCode();
                if (this.ShipmentFulfillmentStates != null)
                    hashCode = hashCode * 59 + this.ShipmentFulfillmentStates.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
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
