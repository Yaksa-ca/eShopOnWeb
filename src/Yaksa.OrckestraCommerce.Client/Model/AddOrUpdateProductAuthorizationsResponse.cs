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
    /// AddOrUpdateProductAuthorizationsResponse
    /// </summary>
    [DataContract(Name = "AddOrUpdateProductAuthorizationsResponse")]
    public partial class AddOrUpdateProductAuthorizationsResponse : IEquatable<AddOrUpdateProductAuthorizationsResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AddOrUpdateProductAuthorizationsResponse" /> class.
        /// </summary>
        /// <param name="authorizations">The details of the product authorizations that were added or updated..</param>
        public AddOrUpdateProductAuthorizationsResponse(List<ProductAuthorization> authorizations = default(List<ProductAuthorization>))
        {
            this.Authorizations = authorizations;
        }

        /// <summary>
        /// The details of the product authorizations that were added or updated.
        /// </summary>
        /// <value>The details of the product authorizations that were added or updated.</value>
        [DataMember(Name = "authorizations", EmitDefaultValue = false)]
        public List<ProductAuthorization> Authorizations { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AddOrUpdateProductAuthorizationsResponse {\n");
            sb.Append("  Authorizations: ").Append(Authorizations).Append("\n");
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
            return this.Equals(input as AddOrUpdateProductAuthorizationsResponse);
        }

        /// <summary>
        /// Returns true if AddOrUpdateProductAuthorizationsResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of AddOrUpdateProductAuthorizationsResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AddOrUpdateProductAuthorizationsResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Authorizations == input.Authorizations ||
                    this.Authorizations != null &&
                    input.Authorizations != null &&
                    this.Authorizations.SequenceEqual(input.Authorizations)
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
                if (this.Authorizations != null)
                    hashCode = hashCode * 59 + this.Authorizations.GetHashCode();
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
