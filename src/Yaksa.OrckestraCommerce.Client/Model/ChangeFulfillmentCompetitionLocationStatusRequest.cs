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
    /// API calls used during the fulfillment process.
    /// </summary>
    [DataContract(Name = "ChangeFulfillmentCompetitionLocationStatusRequest")]
    public partial class ChangeFulfillmentCompetitionLocationStatusRequest : IEquatable<ChangeFulfillmentCompetitionLocationStatusRequest>, IValidatableObject
    {
        /// <summary>
        /// The new status of the fulfillment competition location.
        /// </summary>
        /// <value>The new status of the fulfillment competition location.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StatusEnum
        {
            /// <summary>
            /// Enum Participant for value: Participant
            /// </summary>
            [EnumMember(Value = "Participant")]
            Participant = 1,

            /// <summary>
            /// Enum Winner for value: Winner
            /// </summary>
            [EnumMember(Value = "Winner")]
            Winner = 2,

            /// <summary>
            /// Enum OptedOut for value: OptedOut
            /// </summary>
            [EnumMember(Value = "OptedOut")]
            OptedOut = 3

        }


        /// <summary>
        /// The new status of the fulfillment competition location.
        /// </summary>
        /// <value>The new status of the fulfillment competition location.</value>
        [DataMember(Name = "status", EmitDefaultValue = false)]
        public StatusEnum? Status { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ChangeFulfillmentCompetitionLocationStatusRequest" /> class.
        /// </summary>
        /// <param name="status">The new status of the fulfillment competition location..</param>
        public ChangeFulfillmentCompetitionLocationStatusRequest(StatusEnum? status = default(StatusEnum?))
        {
            this.Status = status;
        }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ChangeFulfillmentCompetitionLocationStatusRequest {\n");
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
            return this.Equals(input as ChangeFulfillmentCompetitionLocationStatusRequest);
        }

        /// <summary>
        /// Returns true if ChangeFulfillmentCompetitionLocationStatusRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of ChangeFulfillmentCompetitionLocationStatusRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ChangeFulfillmentCompetitionLocationStatusRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Status == input.Status ||
                    this.Status.Equals(input.Status)
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
