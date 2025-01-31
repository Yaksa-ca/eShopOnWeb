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
    /// FindUsersByNameResult
    /// </summary>
    [DataContract(Name = "FindUsersByNameResult")]
    public partial class FindUsersByNameResult : IEquatable<FindUsersByNameResult>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FindUsersByNameResult" /> class.
        /// </summary>
        /// <param name="moreUsersAvailable">If there are more users available than the Users list.</param>
        /// <param name="totalResults">Shows the total number of users matching the provided name.</param>
        /// <param name="users">The list of user.</param>
        public FindUsersByNameResult(bool moreUsersAvailable = default(bool), int totalResults = default(int), List<User> users = default(List<User>))
        {
            this.MoreUsersAvailable = moreUsersAvailable;
            this.TotalResults = totalResults;
            this.Users = users;
        }

        /// <summary>
        /// If there are more users available than the Users list
        /// </summary>
        /// <value>If there are more users available than the Users list</value>
        [DataMember(Name = "moreUsersAvailable", EmitDefaultValue = true)]
        public bool MoreUsersAvailable { get; set; }

        /// <summary>
        /// Shows the total number of users matching the provided name
        /// </summary>
        /// <value>Shows the total number of users matching the provided name</value>
        [DataMember(Name = "totalResults", EmitDefaultValue = false)]
        public int TotalResults { get; set; }

        /// <summary>
        /// The list of user
        /// </summary>
        /// <value>The list of user</value>
        [DataMember(Name = "users", EmitDefaultValue = false)]
        public List<User> Users { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FindUsersByNameResult {\n");
            sb.Append("  MoreUsersAvailable: ").Append(MoreUsersAvailable).Append("\n");
            sb.Append("  TotalResults: ").Append(TotalResults).Append("\n");
            sb.Append("  Users: ").Append(Users).Append("\n");
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
            return this.Equals(input as FindUsersByNameResult);
        }

        /// <summary>
        /// Returns true if FindUsersByNameResult instances are equal
        /// </summary>
        /// <param name="input">Instance of FindUsersByNameResult to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FindUsersByNameResult input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.MoreUsersAvailable == input.MoreUsersAvailable ||
                    this.MoreUsersAvailable.Equals(input.MoreUsersAvailable)
                ) && 
                (
                    this.TotalResults == input.TotalResults ||
                    this.TotalResults.Equals(input.TotalResults)
                ) && 
                (
                    this.Users == input.Users ||
                    this.Users != null &&
                    input.Users != null &&
                    this.Users.SequenceEqual(input.Users)
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
                hashCode = hashCode * 59 + this.MoreUsersAvailable.GetHashCode();
                hashCode = hashCode * 59 + this.TotalResults.GetHashCode();
                if (this.Users != null)
                    hashCode = hashCode * 59 + this.Users.GetHashCode();
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
