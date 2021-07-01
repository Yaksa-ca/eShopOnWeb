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
    /// EntityDefinition
    /// </summary>
    [DataContract(Name = "EntityDefinition")]
    public partial class EntityDefinition : IEquatable<EntityDefinition>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EntityDefinition" /> class.
        /// </summary>
        /// <param name="attributes">The list of attributes for the EntityTypeDefinition..</param>
        /// <param name="description">The description for the EntityTypeDefinition..</param>
        /// <param name="displayName">displayName.</param>
        /// <param name="entityTypeName">The unique Overture name for the EntityTypeDefinition..</param>
        /// <param name="isBuiltIn">Whether the EntityTypeDefinition is built-in..</param>
        /// <param name="isSharedEntity">Whether the EntityTypeDefinition is a shared entity..</param>
        public EntityDefinition(List<AttributeDefinition> attributes = default(List<AttributeDefinition>), string description = default(string), Dictionary<string, string> displayName = default(Dictionary<string, string>), string entityTypeName = default(string), bool isBuiltIn = default(bool), bool isSharedEntity = default(bool))
        {
            this.Attributes = attributes;
            this.Description = description;
            this.DisplayName = displayName;
            this.EntityTypeName = entityTypeName;
            this.IsBuiltIn = isBuiltIn;
            this.IsSharedEntity = isSharedEntity;
        }

        /// <summary>
        /// The list of attributes for the EntityTypeDefinition.
        /// </summary>
        /// <value>The list of attributes for the EntityTypeDefinition.</value>
        [DataMember(Name = "attributes", EmitDefaultValue = false)]
        public List<AttributeDefinition> Attributes { get; set; }

        /// <summary>
        /// The description for the EntityTypeDefinition.
        /// </summary>
        /// <value>The description for the EntityTypeDefinition.</value>
        [DataMember(Name = "description", EmitDefaultValue = false)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets DisplayName
        /// </summary>
        [DataMember(Name = "displayName", EmitDefaultValue = false)]
        public Dictionary<string, string> DisplayName { get; set; }

        /// <summary>
        /// The unique Overture name for the EntityTypeDefinition.
        /// </summary>
        /// <value>The unique Overture name for the EntityTypeDefinition.</value>
        [DataMember(Name = "entityTypeName", EmitDefaultValue = false)]
        public string EntityTypeName { get; set; }

        /// <summary>
        /// Whether the EntityTypeDefinition is built-in.
        /// </summary>
        /// <value>Whether the EntityTypeDefinition is built-in.</value>
        [DataMember(Name = "isBuiltIn", EmitDefaultValue = true)]
        public bool IsBuiltIn { get; set; }

        /// <summary>
        /// Whether the EntityTypeDefinition is a shared entity.
        /// </summary>
        /// <value>Whether the EntityTypeDefinition is a shared entity.</value>
        [DataMember(Name = "isSharedEntity", EmitDefaultValue = true)]
        public bool IsSharedEntity { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EntityDefinition {\n");
            sb.Append("  Attributes: ").Append(Attributes).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
            sb.Append("  EntityTypeName: ").Append(EntityTypeName).Append("\n");
            sb.Append("  IsBuiltIn: ").Append(IsBuiltIn).Append("\n");
            sb.Append("  IsSharedEntity: ").Append(IsSharedEntity).Append("\n");
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
            return this.Equals(input as EntityDefinition);
        }

        /// <summary>
        /// Returns true if EntityDefinition instances are equal
        /// </summary>
        /// <param name="input">Instance of EntityDefinition to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EntityDefinition input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Attributes == input.Attributes ||
                    this.Attributes != null &&
                    input.Attributes != null &&
                    this.Attributes.SequenceEqual(input.Attributes)
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.DisplayName == input.DisplayName ||
                    this.DisplayName != null &&
                    input.DisplayName != null &&
                    this.DisplayName.SequenceEqual(input.DisplayName)
                ) && 
                (
                    this.EntityTypeName == input.EntityTypeName ||
                    (this.EntityTypeName != null &&
                    this.EntityTypeName.Equals(input.EntityTypeName))
                ) && 
                (
                    this.IsBuiltIn == input.IsBuiltIn ||
                    this.IsBuiltIn.Equals(input.IsBuiltIn)
                ) && 
                (
                    this.IsSharedEntity == input.IsSharedEntity ||
                    this.IsSharedEntity.Equals(input.IsSharedEntity)
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
                if (this.Attributes != null)
                    hashCode = hashCode * 59 + this.Attributes.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.DisplayName != null)
                    hashCode = hashCode * 59 + this.DisplayName.GetHashCode();
                if (this.EntityTypeName != null)
                    hashCode = hashCode * 59 + this.EntityTypeName.GetHashCode();
                hashCode = hashCode * 59 + this.IsBuiltIn.GetHashCode();
                hashCode = hashCode * 59 + this.IsSharedEntity.GetHashCode();
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
