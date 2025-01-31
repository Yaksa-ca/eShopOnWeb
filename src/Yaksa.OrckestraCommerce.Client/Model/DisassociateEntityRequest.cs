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
    [DataContract(Name = "DisassociateEntityRequest")]
    public partial class DisassociateEntityRequest : IEquatable<DisassociateEntityRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DisassociateEntityRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected DisassociateEntityRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="DisassociateEntityRequest" /> class.
        /// </summary>
        /// <param name="attributeName">The name of the attribute in the parent definition under which the association is kept. (required).</param>
        /// <param name="entityId">The unique identifier for the associated entity. (required).</param>
        /// <param name="parentEntityTypeName">Gets the name (business key) of the custom type of the profile instance to which the entity will be associated. (required).</param>
        /// <param name="parentId">The unique identifier for the parent entity. (required).</param>
        /// <param name="scopeId">The identifier of scope in which the parent entity belong. (required).</param>
        public DisassociateEntityRequest(string attributeName = default(string), string entityId = default(string), string parentEntityTypeName = default(string), string parentId = default(string), string scopeId = default(string))
        {
            // to ensure "attributeName" is required (not null)
            this.AttributeName = attributeName ?? throw new ArgumentNullException("attributeName is a required property for DisassociateEntityRequest and cannot be null");
            // to ensure "entityId" is required (not null)
            this.EntityId = entityId ?? throw new ArgumentNullException("entityId is a required property for DisassociateEntityRequest and cannot be null");
            // to ensure "parentEntityTypeName" is required (not null)
            this.ParentEntityTypeName = parentEntityTypeName ?? throw new ArgumentNullException("parentEntityTypeName is a required property for DisassociateEntityRequest and cannot be null");
            // to ensure "parentId" is required (not null)
            this.ParentId = parentId ?? throw new ArgumentNullException("parentId is a required property for DisassociateEntityRequest and cannot be null");
            // to ensure "scopeId" is required (not null)
            this.ScopeId = scopeId ?? throw new ArgumentNullException("scopeId is a required property for DisassociateEntityRequest and cannot be null");
        }

        /// <summary>
        /// The name of the attribute in the parent definition under which the association is kept.
        /// </summary>
        /// <value>The name of the attribute in the parent definition under which the association is kept.</value>
        [DataMember(Name = "attributeName", IsRequired = true, EmitDefaultValue = false)]
        public string AttributeName { get; set; }

        /// <summary>
        /// The unique identifier for the associated entity.
        /// </summary>
        /// <value>The unique identifier for the associated entity.</value>
        [DataMember(Name = "entityId", IsRequired = true, EmitDefaultValue = false)]
        public string EntityId { get; set; }

        /// <summary>
        /// Gets the name (business key) of the custom type of the profile instance to which the entity will be associated.
        /// </summary>
        /// <value>Gets the name (business key) of the custom type of the profile instance to which the entity will be associated.</value>
        [DataMember(Name = "parentEntityTypeName", IsRequired = true, EmitDefaultValue = false)]
        public string ParentEntityTypeName { get; set; }

        /// <summary>
        /// The unique identifier for the parent entity.
        /// </summary>
        /// <value>The unique identifier for the parent entity.</value>
        [DataMember(Name = "parentId", IsRequired = true, EmitDefaultValue = false)]
        public string ParentId { get; set; }

        /// <summary>
        /// The identifier of scope in which the parent entity belong.
        /// </summary>
        /// <value>The identifier of scope in which the parent entity belong.</value>
        [DataMember(Name = "scopeId", IsRequired = true, EmitDefaultValue = false)]
        public string ScopeId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DisassociateEntityRequest {\n");
            sb.Append("  AttributeName: ").Append(AttributeName).Append("\n");
            sb.Append("  EntityId: ").Append(EntityId).Append("\n");
            sb.Append("  ParentEntityTypeName: ").Append(ParentEntityTypeName).Append("\n");
            sb.Append("  ParentId: ").Append(ParentId).Append("\n");
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
            return this.Equals(input as DisassociateEntityRequest);
        }

        /// <summary>
        /// Returns true if DisassociateEntityRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of DisassociateEntityRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DisassociateEntityRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AttributeName == input.AttributeName ||
                    (this.AttributeName != null &&
                    this.AttributeName.Equals(input.AttributeName))
                ) && 
                (
                    this.EntityId == input.EntityId ||
                    (this.EntityId != null &&
                    this.EntityId.Equals(input.EntityId))
                ) && 
                (
                    this.ParentEntityTypeName == input.ParentEntityTypeName ||
                    (this.ParentEntityTypeName != null &&
                    this.ParentEntityTypeName.Equals(input.ParentEntityTypeName))
                ) && 
                (
                    this.ParentId == input.ParentId ||
                    (this.ParentId != null &&
                    this.ParentId.Equals(input.ParentId))
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
                if (this.AttributeName != null)
                    hashCode = hashCode * 59 + this.AttributeName.GetHashCode();
                if (this.EntityId != null)
                    hashCode = hashCode * 59 + this.EntityId.GetHashCode();
                if (this.ParentEntityTypeName != null)
                    hashCode = hashCode * 59 + this.ParentEntityTypeName.GetHashCode();
                if (this.ParentId != null)
                    hashCode = hashCode * 59 + this.ParentId.GetHashCode();
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
