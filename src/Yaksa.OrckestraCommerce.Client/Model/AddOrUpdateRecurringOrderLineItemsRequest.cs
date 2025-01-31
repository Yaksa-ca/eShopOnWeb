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
    [DataContract(Name = "AddOrUpdateRecurringOrderLineItemsRequest")]
    public partial class AddOrUpdateRecurringOrderLineItemsRequest : IEquatable<AddOrUpdateRecurringOrderLineItemsRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AddOrUpdateRecurringOrderLineItemsRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AddOrUpdateRecurringOrderLineItemsRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AddOrUpdateRecurringOrderLineItemsRequest" /> class.
        /// </summary>
        /// <param name="lineItems">The list of line items to update (required).</param>
        /// <param name="mustApplyUpdatesToRecurringCart">A value indicating whether the values from the RecurringOrderLineItem will be applied to the recurring carts as well.  New values will always be added to a recurring cart. (required).</param>
        public AddOrUpdateRecurringOrderLineItemsRequest(List<RecurringOrderLineItem> lineItems = default(List<RecurringOrderLineItem>), bool mustApplyUpdatesToRecurringCart = default(bool))
        {
            // to ensure "lineItems" is required (not null)
            this.LineItems = lineItems ?? throw new ArgumentNullException("lineItems is a required property for AddOrUpdateRecurringOrderLineItemsRequest and cannot be null");
            this.MustApplyUpdatesToRecurringCart = mustApplyUpdatesToRecurringCart;
        }

        /// <summary>
        /// The list of line items to update
        /// </summary>
        /// <value>The list of line items to update</value>
        [DataMember(Name = "lineItems", IsRequired = true, EmitDefaultValue = false)]
        public List<RecurringOrderLineItem> LineItems { get; set; }

        /// <summary>
        /// A value indicating whether the values from the RecurringOrderLineItem will be applied to the recurring carts as well.  New values will always be added to a recurring cart.
        /// </summary>
        /// <value>A value indicating whether the values from the RecurringOrderLineItem will be applied to the recurring carts as well.  New values will always be added to a recurring cart.</value>
        [DataMember(Name = "mustApplyUpdatesToRecurringCart", IsRequired = true, EmitDefaultValue = true)]
        public bool MustApplyUpdatesToRecurringCart { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AddOrUpdateRecurringOrderLineItemsRequest {\n");
            sb.Append("  LineItems: ").Append(LineItems).Append("\n");
            sb.Append("  MustApplyUpdatesToRecurringCart: ").Append(MustApplyUpdatesToRecurringCart).Append("\n");
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
            return this.Equals(input as AddOrUpdateRecurringOrderLineItemsRequest);
        }

        /// <summary>
        /// Returns true if AddOrUpdateRecurringOrderLineItemsRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of AddOrUpdateRecurringOrderLineItemsRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AddOrUpdateRecurringOrderLineItemsRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.LineItems == input.LineItems ||
                    this.LineItems != null &&
                    input.LineItems != null &&
                    this.LineItems.SequenceEqual(input.LineItems)
                ) && 
                (
                    this.MustApplyUpdatesToRecurringCart == input.MustApplyUpdatesToRecurringCart ||
                    this.MustApplyUpdatesToRecurringCart.Equals(input.MustApplyUpdatesToRecurringCart)
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
                if (this.LineItems != null)
                    hashCode = hashCode * 59 + this.LineItems.GetHashCode();
                hashCode = hashCode * 59 + this.MustApplyUpdatesToRecurringCart.GetHashCode();
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
