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
    /// This can be used to retrieve security token for guest customer.
    /// </summary>
    [DataContract(Name = "GetGuestTokenRequest")]
    public partial class GetGuestTokenRequest : IEquatable<GetGuestTokenRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetGuestTokenRequest" /> class.
        /// </summary>
        /// <param name="expiryDate">The expiry date of the token. It must be in the future..</param>
        public GetGuestTokenRequest(DateTime expiryDate = default(DateTime))
        {
            this.ExpiryDate = expiryDate;
        }

        /// <summary>
        /// The expiry date of the token. It must be in the future.
        /// </summary>
        /// <value>The expiry date of the token. It must be in the future.</value>
        [DataMember(Name = "expiryDate", EmitDefaultValue = false)]
        public DateTime ExpiryDate { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GetGuestTokenRequest {\n");
            sb.Append("  ExpiryDate: ").Append(ExpiryDate).Append("\n");
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
            return this.Equals(input as GetGuestTokenRequest);
        }

        /// <summary>
        /// Returns true if GetGuestTokenRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of GetGuestTokenRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetGuestTokenRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ExpiryDate == input.ExpiryDate ||
                    (this.ExpiryDate != null &&
                    this.ExpiryDate.Equals(input.ExpiryDate))
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
                if (this.ExpiryDate != null)
                    hashCode = hashCode * 59 + this.ExpiryDate.GetHashCode();
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
