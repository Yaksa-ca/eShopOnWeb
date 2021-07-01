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
    /// Picking missions are entities which represent a list of items that need to be picked to fulfill order shipments.
    /// </summary>
    [DataContract(Name = "GetFulfillmentLocationPickingMissionsRequest")]
    public partial class GetFulfillmentLocationPickingMissionsRequest : IEquatable<GetFulfillmentLocationPickingMissionsRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetFulfillmentLocationPickingMissionsRequest" /> class.
        /// </summary>
        /// <param name="fulfillmentLocationId">the fulfillment location identifier..</param>
        /// <param name="scopeId">the scope id..</param>
        /// <param name="status">the picking mission status..</param>
        public GetFulfillmentLocationPickingMissionsRequest(string fulfillmentLocationId = default(string), string scopeId = default(string), string status = default(string))
        {
            this.FulfillmentLocationId = fulfillmentLocationId;
            this.ScopeId = scopeId;
            this.Status = status;
        }

        /// <summary>
        /// the fulfillment location identifier.
        /// </summary>
        /// <value>the fulfillment location identifier.</value>
        [DataMember(Name = "fulfillmentLocationId", EmitDefaultValue = false)]
        public string FulfillmentLocationId { get; set; }

        /// <summary>
        /// the scope id.
        /// </summary>
        /// <value>the scope id.</value>
        [DataMember(Name = "scopeId", EmitDefaultValue = false)]
        public string ScopeId { get; set; }

        /// <summary>
        /// the picking mission status.
        /// </summary>
        /// <value>the picking mission status.</value>
        [DataMember(Name = "status", EmitDefaultValue = false)]
        public string Status { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GetFulfillmentLocationPickingMissionsRequest {\n");
            sb.Append("  FulfillmentLocationId: ").Append(FulfillmentLocationId).Append("\n");
            sb.Append("  ScopeId: ").Append(ScopeId).Append("\n");
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
            return this.Equals(input as GetFulfillmentLocationPickingMissionsRequest);
        }

        /// <summary>
        /// Returns true if GetFulfillmentLocationPickingMissionsRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of GetFulfillmentLocationPickingMissionsRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetFulfillmentLocationPickingMissionsRequest input)
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
                    this.ScopeId == input.ScopeId ||
                    (this.ScopeId != null &&
                    this.ScopeId.Equals(input.ScopeId))
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
                if (this.FulfillmentLocationId != null)
                    hashCode = hashCode * 59 + this.FulfillmentLocationId.GetHashCode();
                if (this.ScopeId != null)
                    hashCode = hashCode * 59 + this.ScopeId.GetHashCode();
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
