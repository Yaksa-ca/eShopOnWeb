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
    /// AvailabilityStatus
    /// </summary>
    [DataContract(Name = "AvailabilityStatus")]
    public partial class AvailabilityStatus : IEquatable<AvailabilityStatus>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AvailabilityStatus" /> class.
        /// </summary>
        /// <param name="estimatedDuration">estimatedDuration.</param>
        /// <param name="isAvailable">Indicates whether the entity is available..</param>
        /// <param name="reason">The reason for the interruption..</param>
        public AvailabilityStatus(Duration estimatedDuration = default(Duration), bool isAvailable = default(bool), string reason = default(string))
        {
            this.EstimatedDuration = estimatedDuration;
            this.IsAvailable = isAvailable;
            this.Reason = reason;
        }

        /// <summary>
        /// Gets or Sets EstimatedDuration
        /// </summary>
        [DataMember(Name = "estimatedDuration", EmitDefaultValue = false)]
        public Duration EstimatedDuration { get; set; }

        /// <summary>
        /// Indicates whether the entity is available.
        /// </summary>
        /// <value>Indicates whether the entity is available.</value>
        [DataMember(Name = "isAvailable", EmitDefaultValue = true)]
        public bool IsAvailable { get; set; }

        /// <summary>
        /// The reason for the interruption.
        /// </summary>
        /// <value>The reason for the interruption.</value>
        [DataMember(Name = "reason", EmitDefaultValue = false)]
        public string Reason { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AvailabilityStatus {\n");
            sb.Append("  EstimatedDuration: ").Append(EstimatedDuration).Append("\n");
            sb.Append("  IsAvailable: ").Append(IsAvailable).Append("\n");
            sb.Append("  Reason: ").Append(Reason).Append("\n");
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
            return this.Equals(input as AvailabilityStatus);
        }

        /// <summary>
        /// Returns true if AvailabilityStatus instances are equal
        /// </summary>
        /// <param name="input">Instance of AvailabilityStatus to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AvailabilityStatus input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.EstimatedDuration == input.EstimatedDuration ||
                    (this.EstimatedDuration != null &&
                    this.EstimatedDuration.Equals(input.EstimatedDuration))
                ) && 
                (
                    this.IsAvailable == input.IsAvailable ||
                    this.IsAvailable.Equals(input.IsAvailable)
                ) && 
                (
                    this.Reason == input.Reason ||
                    (this.Reason != null &&
                    this.Reason.Equals(input.Reason))
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
                if (this.EstimatedDuration != null)
                    hashCode = hashCode * 59 + this.EstimatedDuration.GetHashCode();
                hashCode = hashCode * 59 + this.IsAvailable.GetHashCode();
                if (this.Reason != null)
                    hashCode = hashCode * 59 + this.Reason.GetHashCode();
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
