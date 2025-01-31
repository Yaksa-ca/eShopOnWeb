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
    [DataContract(Name = "DeleteRecurringOrderProgramRequest")]
    public partial class DeleteRecurringOrderProgramRequest : IEquatable<DeleteRecurringOrderProgramRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteRecurringOrderProgramRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected DeleteRecurringOrderProgramRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteRecurringOrderProgramRequest" /> class.
        /// </summary>
        /// <param name="recurringOrderProgramName">The unique identifier of the recurring order program to delete (required).</param>
        public DeleteRecurringOrderProgramRequest(string recurringOrderProgramName = default(string))
        {
            // to ensure "recurringOrderProgramName" is required (not null)
            this.RecurringOrderProgramName = recurringOrderProgramName ?? throw new ArgumentNullException("recurringOrderProgramName is a required property for DeleteRecurringOrderProgramRequest and cannot be null");
        }

        /// <summary>
        /// The unique identifier of the recurring order program to delete
        /// </summary>
        /// <value>The unique identifier of the recurring order program to delete</value>
        [DataMember(Name = "recurringOrderProgramName", IsRequired = true, EmitDefaultValue = false)]
        public string RecurringOrderProgramName { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DeleteRecurringOrderProgramRequest {\n");
            sb.Append("  RecurringOrderProgramName: ").Append(RecurringOrderProgramName).Append("\n");
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
            return this.Equals(input as DeleteRecurringOrderProgramRequest);
        }

        /// <summary>
        /// Returns true if DeleteRecurringOrderProgramRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of DeleteRecurringOrderProgramRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DeleteRecurringOrderProgramRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.RecurringOrderProgramName == input.RecurringOrderProgramName ||
                    (this.RecurringOrderProgramName != null &&
                    this.RecurringOrderProgramName.Equals(input.RecurringOrderProgramName))
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
                if (this.RecurringOrderProgramName != null)
                    hashCode = hashCode * 59 + this.RecurringOrderProgramName.GetHashCode();
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
