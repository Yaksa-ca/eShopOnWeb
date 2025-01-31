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
    /// Custom Profiles are entities which represents a custom classification of entity defined in the system.
    /// </summary>
    [DataContract(Name = "GetAssociatedScopesRequest")]
    public partial class GetAssociatedScopesRequest : IEquatable<GetAssociatedScopesRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetAssociatedScopesRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GetAssociatedScopesRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="GetAssociatedScopesRequest" /> class.
        /// </summary>
        /// <param name="entityId">The identifier (business key) of the instance of entity to which the scopes are associated. (required).</param>
        /// <param name="entityTypeName">The EntityTypeName of the profile instance to which the scopes are linked. (required).</param>
        /// <param name="scopeId">The identifier of the scope. (required).</param>
        public GetAssociatedScopesRequest(string entityId = default(string), string entityTypeName = default(string), string scopeId = default(string))
        {
            // to ensure "entityId" is required (not null)
            this.EntityId = entityId ?? throw new ArgumentNullException("entityId is a required property for GetAssociatedScopesRequest and cannot be null");
            // to ensure "entityTypeName" is required (not null)
            this.EntityTypeName = entityTypeName ?? throw new ArgumentNullException("entityTypeName is a required property for GetAssociatedScopesRequest and cannot be null");
            // to ensure "scopeId" is required (not null)
            this.ScopeId = scopeId ?? throw new ArgumentNullException("scopeId is a required property for GetAssociatedScopesRequest and cannot be null");
        }

        /// <summary>
        /// The identifier (business key) of the instance of entity to which the scopes are associated.
        /// </summary>
        /// <value>The identifier (business key) of the instance of entity to which the scopes are associated.</value>
        [DataMember(Name = "entityId", IsRequired = true, EmitDefaultValue = false)]
        public string EntityId { get; set; }

        /// <summary>
        /// The EntityTypeName of the profile instance to which the scopes are linked.
        /// </summary>
        /// <value>The EntityTypeName of the profile instance to which the scopes are linked.</value>
        [DataMember(Name = "entityTypeName", IsRequired = true, EmitDefaultValue = false)]
        public string EntityTypeName { get; set; }

        /// <summary>
        /// The identifier of the scope.
        /// </summary>
        /// <value>The identifier of the scope.</value>
        [DataMember(Name = "scopeId", IsRequired = true, EmitDefaultValue = false)]
        public string ScopeId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GetAssociatedScopesRequest {\n");
            sb.Append("  EntityId: ").Append(EntityId).Append("\n");
            sb.Append("  EntityTypeName: ").Append(EntityTypeName).Append("\n");
            sb.Append("  ScopeId: ").Append(ScopeId).Append("\n");
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
            return this.Equals(input as GetAssociatedScopesRequest);
        }

        /// <summary>
        /// Returns true if GetAssociatedScopesRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of GetAssociatedScopesRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetAssociatedScopesRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.EntityId == input.EntityId ||
                    (this.EntityId != null &&
                    this.EntityId.Equals(input.EntityId))
                ) && 
                (
                    this.EntityTypeName == input.EntityTypeName ||
                    (this.EntityTypeName != null &&
                    this.EntityTypeName.Equals(input.EntityTypeName))
                ) && 
                (
                    this.ScopeId == input.ScopeId ||
                    (this.ScopeId != null &&
                    this.ScopeId.Equals(input.ScopeId))
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
                if (this.EntityId != null)
                    hashCode = hashCode * 59 + this.EntityId.GetHashCode();
                if (this.EntityTypeName != null)
                    hashCode = hashCode * 59 + this.EntityTypeName.GetHashCode();
                if (this.ScopeId != null)
                    hashCode = hashCode * 59 + this.ScopeId.GetHashCode();
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
