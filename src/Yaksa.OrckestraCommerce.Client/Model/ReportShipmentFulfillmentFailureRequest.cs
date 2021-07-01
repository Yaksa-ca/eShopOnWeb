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
    /// Orders are entities which represent an order of a customer.
    /// </summary>
    [DataContract(Name = "ReportShipmentFulfillmentFailureRequest")]
    public partial class ReportShipmentFulfillmentFailureRequest : IEquatable<ReportShipmentFulfillmentFailureRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ReportShipmentFulfillmentFailureRequest" /> class.
        /// </summary>
        /// <param name="failureDate">The date and time at which the failure occured.</param>
        /// <param name="failureSource">The name of the source of the failure.</param>
        /// <param name="isResumable">a value indicating whether the workflow is resumable..</param>
        /// <param name="stackTrace">The stack trace.</param>
        /// <param name="transitioningState">the attempting state transition..</param>
        /// <param name="workflowInError">a value indicating whether the workflow is in error..</param>
        public ReportShipmentFulfillmentFailureRequest(DateTime failureDate = default(DateTime), string failureSource = default(string), bool isResumable = default(bool), string stackTrace = default(string), string transitioningState = default(string), bool workflowInError = default(bool))
        {
            this.FailureDate = failureDate;
            this.FailureSource = failureSource;
            this.IsResumable = isResumable;
            this.StackTrace = stackTrace;
            this.TransitioningState = transitioningState;
            this.WorkflowInError = workflowInError;
        }

        /// <summary>
        /// The date and time at which the failure occured
        /// </summary>
        /// <value>The date and time at which the failure occured</value>
        [DataMember(Name = "failureDate", EmitDefaultValue = false)]
        public DateTime FailureDate { get; set; }

        /// <summary>
        /// The name of the source of the failure
        /// </summary>
        /// <value>The name of the source of the failure</value>
        [DataMember(Name = "failureSource", EmitDefaultValue = false)]
        public string FailureSource { get; set; }

        /// <summary>
        /// a value indicating whether the workflow is resumable.
        /// </summary>
        /// <value>a value indicating whether the workflow is resumable.</value>
        [DataMember(Name = "isResumable", EmitDefaultValue = true)]
        public bool IsResumable { get; set; }

        /// <summary>
        /// The stack trace
        /// </summary>
        /// <value>The stack trace</value>
        [DataMember(Name = "stackTrace", EmitDefaultValue = false)]
        public string StackTrace { get; set; }

        /// <summary>
        /// the attempting state transition.
        /// </summary>
        /// <value>the attempting state transition.</value>
        [DataMember(Name = "transitioningState", EmitDefaultValue = false)]
        public string TransitioningState { get; set; }

        /// <summary>
        /// a value indicating whether the workflow is in error.
        /// </summary>
        /// <value>a value indicating whether the workflow is in error.</value>
        [DataMember(Name = "workflowInError", EmitDefaultValue = true)]
        public bool WorkflowInError { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ReportShipmentFulfillmentFailureRequest {\n");
            sb.Append("  FailureDate: ").Append(FailureDate).Append("\n");
            sb.Append("  FailureSource: ").Append(FailureSource).Append("\n");
            sb.Append("  IsResumable: ").Append(IsResumable).Append("\n");
            sb.Append("  StackTrace: ").Append(StackTrace).Append("\n");
            sb.Append("  TransitioningState: ").Append(TransitioningState).Append("\n");
            sb.Append("  WorkflowInError: ").Append(WorkflowInError).Append("\n");
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
            return this.Equals(input as ReportShipmentFulfillmentFailureRequest);
        }

        /// <summary>
        /// Returns true if ReportShipmentFulfillmentFailureRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of ReportShipmentFulfillmentFailureRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ReportShipmentFulfillmentFailureRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.FailureDate == input.FailureDate ||
                    (this.FailureDate != null &&
                    this.FailureDate.Equals(input.FailureDate))
                ) && 
                (
                    this.FailureSource == input.FailureSource ||
                    (this.FailureSource != null &&
                    this.FailureSource.Equals(input.FailureSource))
                ) && 
                (
                    this.IsResumable == input.IsResumable ||
                    this.IsResumable.Equals(input.IsResumable)
                ) && 
                (
                    this.StackTrace == input.StackTrace ||
                    (this.StackTrace != null &&
                    this.StackTrace.Equals(input.StackTrace))
                ) && 
                (
                    this.TransitioningState == input.TransitioningState ||
                    (this.TransitioningState != null &&
                    this.TransitioningState.Equals(input.TransitioningState))
                ) && 
                (
                    this.WorkflowInError == input.WorkflowInError ||
                    this.WorkflowInError.Equals(input.WorkflowInError)
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
                if (this.FailureDate != null)
                    hashCode = hashCode * 59 + this.FailureDate.GetHashCode();
                if (this.FailureSource != null)
                    hashCode = hashCode * 59 + this.FailureSource.GetHashCode();
                hashCode = hashCode * 59 + this.IsResumable.GetHashCode();
                if (this.StackTrace != null)
                    hashCode = hashCode * 59 + this.StackTrace.GetHashCode();
                if (this.TransitioningState != null)
                    hashCode = hashCode * 59 + this.TransitioningState.GetHashCode();
                hashCode = hashCode * 59 + this.WorkflowInError.GetHashCode();
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
