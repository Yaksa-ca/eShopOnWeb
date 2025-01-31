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
    /// GetFulfillmentMethodsResponse
    /// </summary>
    [DataContract(Name = "GetFulfillmentMethodsResponse")]
    public partial class GetFulfillmentMethodsResponse : IEquatable<GetFulfillmentMethodsResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetFulfillmentMethodsResponse" /> class.
        /// </summary>
        /// <param name="fulfillmentMethods">List of fulfillment mnethods..</param>
        public GetFulfillmentMethodsResponse(List<FulfillmentMethodInfo> fulfillmentMethods = default(List<FulfillmentMethodInfo>))
        {
            this.FulfillmentMethods = fulfillmentMethods;
        }

        /// <summary>
        /// List of fulfillment mnethods.
        /// </summary>
        /// <value>List of fulfillment mnethods.</value>
        [DataMember(Name = "fulfillmentMethods", EmitDefaultValue = false)]
        public List<FulfillmentMethodInfo> FulfillmentMethods { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GetFulfillmentMethodsResponse {\n");
            sb.Append("  FulfillmentMethods: ").Append(FulfillmentMethods).Append("\n");
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
            return this.Equals(input as GetFulfillmentMethodsResponse);
        }

        /// <summary>
        /// Returns true if GetFulfillmentMethodsResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of GetFulfillmentMethodsResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetFulfillmentMethodsResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.FulfillmentMethods == input.FulfillmentMethods ||
                    this.FulfillmentMethods != null &&
                    input.FulfillmentMethods != null &&
                    this.FulfillmentMethods.SequenceEqual(input.FulfillmentMethods)
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
                if (this.FulfillmentMethods != null)
                    hashCode = hashCode * 59 + this.FulfillmentMethods.GetHashCode();
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
