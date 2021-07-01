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
    [DataContract(Name = "UpdateCustomProfileRequest")]
    public partial class UpdateCustomProfileRequest : IEquatable<UpdateCustomProfileRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateCustomProfileRequest" /> class.
        /// </summary>
        /// <param name="created">The date and time the entity was created..</param>
        /// <param name="createdBy">The identifier of the operator who created the entity..</param>
        /// <param name="isActive">Whether this entity can be used in business processes or linked to a scope..</param>
        /// <param name="lastModified">Date and time that the last modification was applied to the entity..</param>
        /// <param name="lastModifiedBy">The identifier of the operator who last modified the entity..</param>
        /// <param name="name">The unique name given to identify the entity..</param>
        /// <param name="propertyBag">propertyBag.</param>
        /// <param name="sequenceNumber">The sort order..</param>
        public UpdateCustomProfileRequest(DateTime created = default(DateTime), string createdBy = default(string), bool isActive = default(bool), DateTime lastModified = default(DateTime), string lastModifiedBy = default(string), string name = default(string), Dictionary<string, Object> propertyBag = default(Dictionary<string, Object>), int sequenceNumber = default(int))
        {
            this.Created = created;
            this.CreatedBy = createdBy;
            this.IsActive = isActive;
            this.LastModified = lastModified;
            this.LastModifiedBy = lastModifiedBy;
            this.Name = name;
            this.PropertyBag = propertyBag;
            this.SequenceNumber = sequenceNumber;
        }

        /// <summary>
        /// The date and time the entity was created.
        /// </summary>
        /// <value>The date and time the entity was created.</value>
        [DataMember(Name = "created", EmitDefaultValue = false)]
        public DateTime Created { get; set; }

        /// <summary>
        /// The identifier of the operator who created the entity.
        /// </summary>
        /// <value>The identifier of the operator who created the entity.</value>
        [DataMember(Name = "createdBy", EmitDefaultValue = false)]
        public string CreatedBy { get; set; }

        /// <summary>
        /// Whether this entity can be used in business processes or linked to a scope.
        /// </summary>
        /// <value>Whether this entity can be used in business processes or linked to a scope.</value>
        [DataMember(Name = "isActive", EmitDefaultValue = true)]
        public bool IsActive { get; set; }

        /// <summary>
        /// Date and time that the last modification was applied to the entity.
        /// </summary>
        /// <value>Date and time that the last modification was applied to the entity.</value>
        [DataMember(Name = "lastModified", EmitDefaultValue = false)]
        public DateTime LastModified { get; set; }

        /// <summary>
        /// The identifier of the operator who last modified the entity.
        /// </summary>
        /// <value>The identifier of the operator who last modified the entity.</value>
        [DataMember(Name = "lastModifiedBy", EmitDefaultValue = false)]
        public string LastModifiedBy { get; set; }

        /// <summary>
        /// The unique name given to identify the entity.
        /// </summary>
        /// <value>The unique name given to identify the entity.</value>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets PropertyBag
        /// </summary>
        [DataMember(Name = "propertyBag", EmitDefaultValue = false)]
        public Dictionary<string, Object> PropertyBag { get; set; }

        /// <summary>
        /// The sort order.
        /// </summary>
        /// <value>The sort order.</value>
        [DataMember(Name = "sequenceNumber", EmitDefaultValue = false)]
        public int SequenceNumber { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateCustomProfileRequest {\n");
            sb.Append("  Created: ").Append(Created).Append("\n");
            sb.Append("  CreatedBy: ").Append(CreatedBy).Append("\n");
            sb.Append("  IsActive: ").Append(IsActive).Append("\n");
            sb.Append("  LastModified: ").Append(LastModified).Append("\n");
            sb.Append("  LastModifiedBy: ").Append(LastModifiedBy).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  PropertyBag: ").Append(PropertyBag).Append("\n");
            sb.Append("  SequenceNumber: ").Append(SequenceNumber).Append("\n");
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
            return this.Equals(input as UpdateCustomProfileRequest);
        }

        /// <summary>
        /// Returns true if UpdateCustomProfileRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of UpdateCustomProfileRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UpdateCustomProfileRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Created == input.Created ||
                    (this.Created != null &&
                    this.Created.Equals(input.Created))
                ) && 
                (
                    this.CreatedBy == input.CreatedBy ||
                    (this.CreatedBy != null &&
                    this.CreatedBy.Equals(input.CreatedBy))
                ) && 
                (
                    this.IsActive == input.IsActive ||
                    this.IsActive.Equals(input.IsActive)
                ) && 
                (
                    this.LastModified == input.LastModified ||
                    (this.LastModified != null &&
                    this.LastModified.Equals(input.LastModified))
                ) && 
                (
                    this.LastModifiedBy == input.LastModifiedBy ||
                    (this.LastModifiedBy != null &&
                    this.LastModifiedBy.Equals(input.LastModifiedBy))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.PropertyBag == input.PropertyBag ||
                    this.PropertyBag != null &&
                    input.PropertyBag != null &&
                    this.PropertyBag.SequenceEqual(input.PropertyBag)
                ) && 
                (
                    this.SequenceNumber == input.SequenceNumber ||
                    this.SequenceNumber.Equals(input.SequenceNumber)
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
                if (this.Created != null)
                    hashCode = hashCode * 59 + this.Created.GetHashCode();
                if (this.CreatedBy != null)
                    hashCode = hashCode * 59 + this.CreatedBy.GetHashCode();
                hashCode = hashCode * 59 + this.IsActive.GetHashCode();
                if (this.LastModified != null)
                    hashCode = hashCode * 59 + this.LastModified.GetHashCode();
                if (this.LastModifiedBy != null)
                    hashCode = hashCode * 59 + this.LastModifiedBy.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.PropertyBag != null)
                    hashCode = hashCode * 59 + this.PropertyBag.GetHashCode();
                hashCode = hashCode * 59 + this.SequenceNumber.GetHashCode();
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
