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
    [DataContract(Name = "GetUserRequest")]
    public partial class GetUserRequest : IEquatable<GetUserRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetUserRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GetUserRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="GetUserRequest" /> class.
        /// </summary>
        /// <param name="userName">The username of user. (required).</param>
        public GetUserRequest(string userName = default(string))
        {
            // to ensure "userName" is required (not null)
            this.UserName = userName ?? throw new ArgumentNullException("userName is a required property for GetUserRequest and cannot be null");
        }

        /// <summary>
        /// The username of user.
        /// </summary>
        /// <value>The username of user.</value>
        [DataMember(Name = "userName", IsRequired = true, EmitDefaultValue = false)]
        public string UserName { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GetUserRequest {\n");
            sb.Append("  UserName: ").Append(UserName).Append("\n");
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
            return this.Equals(input as GetUserRequest);
        }

        /// <summary>
        /// Returns true if GetUserRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of GetUserRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetUserRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.UserName == input.UserName ||
                    (this.UserName != null &&
                    this.UserName.Equals(input.UserName))
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
                if (this.UserName != null)
                    hashCode = hashCode * 59 + this.UserName.GetHashCode();
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
