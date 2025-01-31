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
    /// Addresses are entities which are used as a billing or shipping address for a cart or an order.
    /// </summary>
    [DataContract(Name = "GetAddressesByIdsRequest")]
    public partial class GetAddressesByIdsRequest : IEquatable<GetAddressesByIdsRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetAddressesByIdsRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GetAddressesByIdsRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="GetAddressesByIdsRequest" /> class.
        /// </summary>
        /// <param name="ids">The list of system-wide unique identifier for the Addresses to retrieve. (required).</param>
        public GetAddressesByIdsRequest(List<string> ids = default(List<string>))
        {
            // to ensure "ids" is required (not null)
            this.Ids = ids ?? throw new ArgumentNullException("ids is a required property for GetAddressesByIdsRequest and cannot be null");
        }

        /// <summary>
        /// The list of system-wide unique identifier for the Addresses to retrieve.
        /// </summary>
        /// <value>The list of system-wide unique identifier for the Addresses to retrieve.</value>
        [DataMember(Name = "ids", IsRequired = true, EmitDefaultValue = false)]
        public List<string> Ids { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GetAddressesByIdsRequest {\n");
            sb.Append("  Ids: ").Append(Ids).Append("\n");
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
            return this.Equals(input as GetAddressesByIdsRequest);
        }

        /// <summary>
        /// Returns true if GetAddressesByIdsRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of GetAddressesByIdsRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetAddressesByIdsRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Ids == input.Ids ||
                    this.Ids != null &&
                    input.Ids != null &&
                    this.Ids.SequenceEqual(input.Ids)
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
                if (this.Ids != null)
                    hashCode = hashCode * 59 + this.Ids.GetHashCode();
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
