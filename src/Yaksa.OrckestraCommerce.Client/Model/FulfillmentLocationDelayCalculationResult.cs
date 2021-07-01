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
    /// FulfillmentLocationDelayCalculationResult
    /// </summary>
    [DataContract(Name = "FulfillmentLocationDelayCalculationResult")]
    public partial class FulfillmentLocationDelayCalculationResult : IEquatable<FulfillmentLocationDelayCalculationResult>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FulfillmentLocationDelayCalculationResult" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected FulfillmentLocationDelayCalculationResult() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="FulfillmentLocationDelayCalculationResult" /> class.
        /// </summary>
        /// <param name="endDate">the end date and time for the delay in utc. (required).</param>
        /// <param name="fulfillmentLocationId">the fulfillment location id. (required).</param>
        /// <param name="startDate">the start date and time for the delayin utc. (required).</param>
        public FulfillmentLocationDelayCalculationResult(DateTime endDate = default(DateTime), string fulfillmentLocationId = default(string), DateTime startDate = default(DateTime))
        {
            this.EndDate = endDate;
            // to ensure "fulfillmentLocationId" is required (not null)
            this.FulfillmentLocationId = fulfillmentLocationId ?? throw new ArgumentNullException("fulfillmentLocationId is a required property for FulfillmentLocationDelayCalculationResult and cannot be null");
            this.StartDate = startDate;
        }

        /// <summary>
        /// the end date and time for the delay in utc.
        /// </summary>
        /// <value>the end date and time for the delay in utc.</value>
        [DataMember(Name = "endDate", IsRequired = true, EmitDefaultValue = false)]
        public DateTime EndDate { get; set; }

        /// <summary>
        /// the fulfillment location id.
        /// </summary>
        /// <value>the fulfillment location id.</value>
        [DataMember(Name = "fulfillmentLocationId", IsRequired = true, EmitDefaultValue = false)]
        public string FulfillmentLocationId { get; set; }

        /// <summary>
        /// the start date and time for the delayin utc.
        /// </summary>
        /// <value>the start date and time for the delayin utc.</value>
        [DataMember(Name = "startDate", IsRequired = true, EmitDefaultValue = false)]
        public DateTime StartDate { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FulfillmentLocationDelayCalculationResult {\n");
            sb.Append("  EndDate: ").Append(EndDate).Append("\n");
            sb.Append("  FulfillmentLocationId: ").Append(FulfillmentLocationId).Append("\n");
            sb.Append("  StartDate: ").Append(StartDate).Append("\n");
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
            return this.Equals(input as FulfillmentLocationDelayCalculationResult);
        }

        /// <summary>
        /// Returns true if FulfillmentLocationDelayCalculationResult instances are equal
        /// </summary>
        /// <param name="input">Instance of FulfillmentLocationDelayCalculationResult to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FulfillmentLocationDelayCalculationResult input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.EndDate == input.EndDate ||
                    (this.EndDate != null &&
                    this.EndDate.Equals(input.EndDate))
                ) && 
                (
                    this.FulfillmentLocationId == input.FulfillmentLocationId ||
                    (this.FulfillmentLocationId != null &&
                    this.FulfillmentLocationId.Equals(input.FulfillmentLocationId))
                ) && 
                (
                    this.StartDate == input.StartDate ||
                    (this.StartDate != null &&
                    this.StartDate.Equals(input.StartDate))
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
                if (this.EndDate != null)
                    hashCode = hashCode * 59 + this.EndDate.GetHashCode();
                if (this.FulfillmentLocationId != null)
                    hashCode = hashCode * 59 + this.FulfillmentLocationId.GetHashCode();
                if (this.StartDate != null)
                    hashCode = hashCode * 59 + this.StartDate.GetHashCode();
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
