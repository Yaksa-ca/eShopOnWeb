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
    [DataContract(Name = "UpdateRmaRequest")]
    public partial class UpdateRmaRequest : IEquatable<UpdateRmaRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateRmaRequest" /> class.
        /// </summary>
        /// <param name="isFinished">whether the RMA is finished..</param>
        /// <param name="rmaExternalNumber">the RMA external Number.</param>
        /// <param name="rmaItems">RMA item details.</param>
        /// <param name="status">the process status of the RMA.</param>
        /// <param name="totalAmountRefunded">Total amount of refunded items, if applicable.</param>
        public UpdateRmaRequest(bool isFinished = default(bool), string rmaExternalNumber = default(string), List<RmaItem> rmaItems = default(List<RmaItem>), string status = default(string), double totalAmountRefunded = default(double))
        {
            this.IsFinished = isFinished;
            this.RmaExternalNumber = rmaExternalNumber;
            this.RmaItems = rmaItems;
            this.Status = status;
            this.TotalAmountRefunded = totalAmountRefunded;
        }

        /// <summary>
        /// whether the RMA is finished.
        /// </summary>
        /// <value>whether the RMA is finished.</value>
        [DataMember(Name = "isFinished", EmitDefaultValue = true)]
        public bool IsFinished { get; set; }

        /// <summary>
        /// the RMA external Number
        /// </summary>
        /// <value>the RMA external Number</value>
        [DataMember(Name = "rmaExternalNumber", EmitDefaultValue = false)]
        public string RmaExternalNumber { get; set; }

        /// <summary>
        /// RMA item details
        /// </summary>
        /// <value>RMA item details</value>
        [DataMember(Name = "rmaItems", EmitDefaultValue = false)]
        public List<RmaItem> RmaItems { get; set; }

        /// <summary>
        /// the process status of the RMA
        /// </summary>
        /// <value>the process status of the RMA</value>
        [DataMember(Name = "status", EmitDefaultValue = false)]
        public string Status { get; set; }

        /// <summary>
        /// Total amount of refunded items, if applicable
        /// </summary>
        /// <value>Total amount of refunded items, if applicable</value>
        [DataMember(Name = "totalAmountRefunded", EmitDefaultValue = false)]
        public double TotalAmountRefunded { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateRmaRequest {\n");
            sb.Append("  IsFinished: ").Append(IsFinished).Append("\n");
            sb.Append("  RmaExternalNumber: ").Append(RmaExternalNumber).Append("\n");
            sb.Append("  RmaItems: ").Append(RmaItems).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  TotalAmountRefunded: ").Append(TotalAmountRefunded).Append("\n");
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
            return this.Equals(input as UpdateRmaRequest);
        }

        /// <summary>
        /// Returns true if UpdateRmaRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of UpdateRmaRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UpdateRmaRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.IsFinished == input.IsFinished ||
                    this.IsFinished.Equals(input.IsFinished)
                ) && 
                (
                    this.RmaExternalNumber == input.RmaExternalNumber ||
                    (this.RmaExternalNumber != null &&
                    this.RmaExternalNumber.Equals(input.RmaExternalNumber))
                ) && 
                (
                    this.RmaItems == input.RmaItems ||
                    this.RmaItems != null &&
                    input.RmaItems != null &&
                    this.RmaItems.SequenceEqual(input.RmaItems)
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.TotalAmountRefunded == input.TotalAmountRefunded ||
                    this.TotalAmountRefunded.Equals(input.TotalAmountRefunded)
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
                hashCode = hashCode * 59 + this.IsFinished.GetHashCode();
                if (this.RmaExternalNumber != null)
                    hashCode = hashCode * 59 + this.RmaExternalNumber.GetHashCode();
                if (this.RmaItems != null)
                    hashCode = hashCode * 59 + this.RmaItems.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                hashCode = hashCode * 59 + this.TotalAmountRefunded.GetHashCode();
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
