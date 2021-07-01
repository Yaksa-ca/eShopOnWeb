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
    /// Users represents the persons interacting with the system.
    /// </summary>
    [DataContract(Name = "DeactivateUsersRequest")]
    public partial class DeactivateUsersRequest : IEquatable<DeactivateUsersRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DeactivateUsersRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected DeactivateUsersRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="DeactivateUsersRequest" /> class.
        /// </summary>
        /// <param name="usersToDeactivate">The users to deactivate. (required).</param>
        public DeactivateUsersRequest(List<string> usersToDeactivate = default(List<string>))
        {
            // to ensure "usersToDeactivate" is required (not null)
            this.UsersToDeactivate = usersToDeactivate ?? throw new ArgumentNullException("usersToDeactivate is a required property for DeactivateUsersRequest and cannot be null");
        }

        /// <summary>
        /// The users to deactivate.
        /// </summary>
        /// <value>The users to deactivate.</value>
        [DataMember(Name = "usersToDeactivate", IsRequired = true, EmitDefaultValue = false)]
        public List<string> UsersToDeactivate { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DeactivateUsersRequest {\n");
            sb.Append("  UsersToDeactivate: ").Append(UsersToDeactivate).Append("\n");
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
            return this.Equals(input as DeactivateUsersRequest);
        }

        /// <summary>
        /// Returns true if DeactivateUsersRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of DeactivateUsersRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DeactivateUsersRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.UsersToDeactivate == input.UsersToDeactivate ||
                    this.UsersToDeactivate != null &&
                    input.UsersToDeactivate != null &&
                    this.UsersToDeactivate.SequenceEqual(input.UsersToDeactivate)
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
                if (this.UsersToDeactivate != null)
                    hashCode = hashCode * 59 + this.UsersToDeactivate.GetHashCode();
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
