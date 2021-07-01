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
    /// Recurring orders are orders that are created automatically by the system based on a schedule defined by the customer.
    /// </summary>
    [DataContract(Name = "DeleteRecurringCartLineItemsRequest")]
    public partial class DeleteRecurringCartLineItemsRequest : IEquatable<DeleteRecurringCartLineItemsRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteRecurringCartLineItemsRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected DeleteRecurringCartLineItemsRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteRecurringCartLineItemsRequest" /> class.
        /// </summary>
        /// <param name="customerId">The customer id of the recurring order line items (required).</param>
        /// <param name="lineItemIds">The list of line item ids to delete (required).</param>
        /// <param name="scopeId">The scope of the RecurringOrderLineItems to delete (required).</param>
        public DeleteRecurringCartLineItemsRequest(string customerId = default(string), List<string> lineItemIds = default(List<string>), string scopeId = default(string))
        {
            // to ensure "customerId" is required (not null)
            this.CustomerId = customerId ?? throw new ArgumentNullException("customerId is a required property for DeleteRecurringCartLineItemsRequest and cannot be null");
            // to ensure "lineItemIds" is required (not null)
            this.LineItemIds = lineItemIds ?? throw new ArgumentNullException("lineItemIds is a required property for DeleteRecurringCartLineItemsRequest and cannot be null");
            // to ensure "scopeId" is required (not null)
            this.ScopeId = scopeId ?? throw new ArgumentNullException("scopeId is a required property for DeleteRecurringCartLineItemsRequest and cannot be null");
        }

        /// <summary>
        /// The customer id of the recurring order line items
        /// </summary>
        /// <value>The customer id of the recurring order line items</value>
        [DataMember(Name = "customerId", IsRequired = true, EmitDefaultValue = false)]
        public string CustomerId { get; set; }

        /// <summary>
        /// The list of line item ids to delete
        /// </summary>
        /// <value>The list of line item ids to delete</value>
        [DataMember(Name = "lineItemIds", IsRequired = true, EmitDefaultValue = false)]
        public List<string> LineItemIds { get; set; }

        /// <summary>
        /// The scope of the RecurringOrderLineItems to delete
        /// </summary>
        /// <value>The scope of the RecurringOrderLineItems to delete</value>
        [DataMember(Name = "scopeId", IsRequired = true, EmitDefaultValue = false)]
        public string ScopeId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DeleteRecurringCartLineItemsRequest {\n");
            sb.Append("  CustomerId: ").Append(CustomerId).Append("\n");
            sb.Append("  LineItemIds: ").Append(LineItemIds).Append("\n");
            sb.Append("  ScopeId: ").Append(ScopeId).Append("\n");
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
            return this.Equals(input as DeleteRecurringCartLineItemsRequest);
        }

        /// <summary>
        /// Returns true if DeleteRecurringCartLineItemsRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of DeleteRecurringCartLineItemsRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DeleteRecurringCartLineItemsRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CustomerId == input.CustomerId ||
                    (this.CustomerId != null &&
                    this.CustomerId.Equals(input.CustomerId))
                ) && 
                (
                    this.LineItemIds == input.LineItemIds ||
                    this.LineItemIds != null &&
                    input.LineItemIds != null &&
                    this.LineItemIds.SequenceEqual(input.LineItemIds)
                ) && 
                (
                    this.ScopeId == input.ScopeId ||
                    (this.ScopeId != null &&
                    this.ScopeId.Equals(input.ScopeId))
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
                if (this.CustomerId != null)
                    hashCode = hashCode * 59 + this.CustomerId.GetHashCode();
                if (this.LineItemIds != null)
                    hashCode = hashCode * 59 + this.LineItemIds.GetHashCode();
                if (this.ScopeId != null)
                    hashCode = hashCode * 59 + this.ScopeId.GetHashCode();
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
