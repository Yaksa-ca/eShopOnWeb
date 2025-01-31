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
    /// Membership represents a set of Authorization rules applied to a Customer.
    /// </summary>
    [DataContract(Name = "ChangePasswordRequest")]
    public partial class ChangePasswordRequest : IEquatable<ChangePasswordRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ChangePasswordRequest" /> class.
        /// </summary>
        /// <param name="newPassword">The new (replacement) password.</param>
        /// <param name="oldPassword">The old (current) password.</param>
        public ChangePasswordRequest(string newPassword = default(string), string oldPassword = default(string))
        {
            this.NewPassword = newPassword;
            this.OldPassword = oldPassword;
        }

        /// <summary>
        /// The new (replacement) password
        /// </summary>
        /// <value>The new (replacement) password</value>
        [DataMember(Name = "newPassword", EmitDefaultValue = false)]
        public string NewPassword { get; set; }

        /// <summary>
        /// The old (current) password
        /// </summary>
        /// <value>The old (current) password</value>
        [DataMember(Name = "oldPassword", EmitDefaultValue = false)]
        public string OldPassword { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ChangePasswordRequest {\n");
            sb.Append("  NewPassword: ").Append(NewPassword).Append("\n");
            sb.Append("  OldPassword: ").Append(OldPassword).Append("\n");
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
            return this.Equals(input as ChangePasswordRequest);
        }

        /// <summary>
        /// Returns true if ChangePasswordRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of ChangePasswordRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ChangePasswordRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.NewPassword == input.NewPassword ||
                    (this.NewPassword != null &&
                    this.NewPassword.Equals(input.NewPassword))
                ) && 
                (
                    this.OldPassword == input.OldPassword ||
                    (this.OldPassword != null &&
                    this.OldPassword.Equals(input.OldPassword))
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
                if (this.NewPassword != null)
                    hashCode = hashCode * 59 + this.NewPassword.GetHashCode();
                if (this.OldPassword != null)
                    hashCode = hashCode * 59 + this.OldPassword.GetHashCode();
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
