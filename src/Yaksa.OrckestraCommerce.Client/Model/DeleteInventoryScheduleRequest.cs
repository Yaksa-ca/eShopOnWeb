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
    /// Inventory locations are places which manage inventory.
    /// </summary>
    [DataContract(Name = "DeleteInventoryScheduleRequest")]
    public partial class DeleteInventoryScheduleRequest : IEquatable<DeleteInventoryScheduleRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteInventoryScheduleRequest" /> class.
        /// </summary>
        /// <param name="scopeId">The id of the requested scope.</param>
        /// <param name="inventoryLocationId">The inventory location identifier used to identify the right schedule to update.</param>
        /// <param name="scheduleId">The inventory schedule identifier used to find the right schedule to update.</param>
        public DeleteInventoryScheduleRequest(string scopeId = default(string), string inventoryLocationId = default(string), string scheduleId = default(string))
        {
            this.ScopeId = scopeId;
            this.InventoryLocationId = inventoryLocationId;
            this.ScheduleId = scheduleId;
        }

        /// <summary>
        /// The id of the requested scope
        /// </summary>
        /// <value>The id of the requested scope</value>
        [DataMember(Name = "scopeId", EmitDefaultValue = false)]
        public string ScopeId { get; set; }

        /// <summary>
        /// The inventory location identifier used to identify the right schedule to update
        /// </summary>
        /// <value>The inventory location identifier used to identify the right schedule to update</value>
        [DataMember(Name = "inventoryLocationId", EmitDefaultValue = false)]
        public string InventoryLocationId { get; set; }

        /// <summary>
        /// The inventory schedule identifier used to find the right schedule to update
        /// </summary>
        /// <value>The inventory schedule identifier used to find the right schedule to update</value>
        [DataMember(Name = "scheduleId", EmitDefaultValue = false)]
        public string ScheduleId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DeleteInventoryScheduleRequest {\n");
            sb.Append("  ScopeId: ").Append(ScopeId).Append("\n");
            sb.Append("  InventoryLocationId: ").Append(InventoryLocationId).Append("\n");
            sb.Append("  ScheduleId: ").Append(ScheduleId).Append("\n");
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
            return this.Equals(input as DeleteInventoryScheduleRequest);
        }

        /// <summary>
        /// Returns true if DeleteInventoryScheduleRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of DeleteInventoryScheduleRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DeleteInventoryScheduleRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ScopeId == input.ScopeId ||
                    (this.ScopeId != null &&
                    this.ScopeId.Equals(input.ScopeId))
                ) && 
                (
                    this.InventoryLocationId == input.InventoryLocationId ||
                    (this.InventoryLocationId != null &&
                    this.InventoryLocationId.Equals(input.InventoryLocationId))
                ) && 
                (
                    this.ScheduleId == input.ScheduleId ||
                    (this.ScheduleId != null &&
                    this.ScheduleId.Equals(input.ScheduleId))
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
                if (this.ScopeId != null)
                    hashCode = hashCode * 59 + this.ScopeId.GetHashCode();
                if (this.InventoryLocationId != null)
                    hashCode = hashCode * 59 + this.InventoryLocationId.GetHashCode();
                if (this.ScheduleId != null)
                    hashCode = hashCode * 59 + this.ScheduleId.GetHashCode();
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
