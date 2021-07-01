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
    /// FulfillmentExceptionResult
    /// </summary>
    [DataContract(Name = "FulfillmentExceptionResult")]
    public partial class FulfillmentExceptionResult : IEquatable<FulfillmentExceptionResult>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FulfillmentExceptionResult" /> class.
        /// </summary>
        /// <param name="fulfillmentExceptions">The list of fulfillment exceptions..</param>
        public FulfillmentExceptionResult(List<FulfillmentException> fulfillmentExceptions = default(List<FulfillmentException>))
        {
            this.FulfillmentExceptions = fulfillmentExceptions;
        }

        /// <summary>
        /// The list of fulfillment exceptions.
        /// </summary>
        /// <value>The list of fulfillment exceptions.</value>
        [DataMember(Name = "fulfillmentExceptions", EmitDefaultValue = false)]
        public List<FulfillmentException> FulfillmentExceptions { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FulfillmentExceptionResult {\n");
            sb.Append("  FulfillmentExceptions: ").Append(FulfillmentExceptions).Append("\n");
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
            return this.Equals(input as FulfillmentExceptionResult);
        }

        /// <summary>
        /// Returns true if FulfillmentExceptionResult instances are equal
        /// </summary>
        /// <param name="input">Instance of FulfillmentExceptionResult to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FulfillmentExceptionResult input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.FulfillmentExceptions == input.FulfillmentExceptions ||
                    this.FulfillmentExceptions != null &&
                    input.FulfillmentExceptions != null &&
                    this.FulfillmentExceptions.SequenceEqual(input.FulfillmentExceptions)
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
                if (this.FulfillmentExceptions != null)
                    hashCode = hashCode * 59 + this.FulfillmentExceptions.GetHashCode();
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
