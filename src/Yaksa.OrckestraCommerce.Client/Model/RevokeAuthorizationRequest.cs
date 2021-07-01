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
    /// Authorizations represents what an entity (Group, User...) is allowed to do.
    /// </summary>
    [DataContract(Name = "RevokeAuthorizationRequest")]
    public partial class RevokeAuthorizationRequest : IEquatable<RevokeAuthorizationRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RevokeAuthorizationRequest" /> class.
        /// </summary>
        /// <param name="objectId">The Object identifier..</param>
        /// <param name="objectType">The object type..</param>
        /// <param name="requestedScopeId">The Scope identifier..</param>
        /// <param name="roleId">The Role identifier..</param>
        public RevokeAuthorizationRequest(string objectId = default(string), string objectType = default(string), string requestedScopeId = default(string), int roleId = default(int))
        {
            this.ObjectId = objectId;
            this.ObjectType = objectType;
            this.RequestedScopeId = requestedScopeId;
            this.RoleId = roleId;
        }

        /// <summary>
        /// The Object identifier.
        /// </summary>
        /// <value>The Object identifier.</value>
        [DataMember(Name = "objectId", EmitDefaultValue = false)]
        public string ObjectId { get; set; }

        /// <summary>
        /// The object type.
        /// </summary>
        /// <value>The object type.</value>
        [DataMember(Name = "objectType", EmitDefaultValue = false)]
        public string ObjectType { get; set; }

        /// <summary>
        /// The Scope identifier.
        /// </summary>
        /// <value>The Scope identifier.</value>
        [DataMember(Name = "requestedScopeId", EmitDefaultValue = false)]
        public string RequestedScopeId { get; set; }

        /// <summary>
        /// The Role identifier.
        /// </summary>
        /// <value>The Role identifier.</value>
        [DataMember(Name = "roleId", EmitDefaultValue = false)]
        public int RoleId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RevokeAuthorizationRequest {\n");
            sb.Append("  ObjectId: ").Append(ObjectId).Append("\n");
            sb.Append("  ObjectType: ").Append(ObjectType).Append("\n");
            sb.Append("  RequestedScopeId: ").Append(RequestedScopeId).Append("\n");
            sb.Append("  RoleId: ").Append(RoleId).Append("\n");
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
            return this.Equals(input as RevokeAuthorizationRequest);
        }

        /// <summary>
        /// Returns true if RevokeAuthorizationRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of RevokeAuthorizationRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RevokeAuthorizationRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ObjectId == input.ObjectId ||
                    (this.ObjectId != null &&
                    this.ObjectId.Equals(input.ObjectId))
                ) && 
                (
                    this.ObjectType == input.ObjectType ||
                    (this.ObjectType != null &&
                    this.ObjectType.Equals(input.ObjectType))
                ) && 
                (
                    this.RequestedScopeId == input.RequestedScopeId ||
                    (this.RequestedScopeId != null &&
                    this.RequestedScopeId.Equals(input.RequestedScopeId))
                ) && 
                (
                    this.RoleId == input.RoleId ||
                    this.RoleId.Equals(input.RoleId)
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
                if (this.ObjectId != null)
                    hashCode = hashCode * 59 + this.ObjectId.GetHashCode();
                if (this.ObjectType != null)
                    hashCode = hashCode * 59 + this.ObjectType.GetHashCode();
                if (this.RequestedScopeId != null)
                    hashCode = hashCode * 59 + this.RequestedScopeId.GetHashCode();
                hashCode = hashCode * 59 + this.RoleId.GetHashCode();
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
