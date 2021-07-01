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
    /// DeleteMediaModification
    /// </summary>
    [DataContract(Name = "DeleteMediaModification")]
    public partial class DeleteMediaModification : IEquatable<DeleteMediaModification>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteMediaModification" /> class.
        /// </summary>
        /// <param name="isLocalized">isLocalized.</param>
        /// <param name="lastModified">lastModified.</param>
        /// <param name="id">id.</param>
        /// <param name="isHardDelete">isHardDelete.</param>
        public DeleteMediaModification(bool isLocalized = default(bool), DateTime lastModified = default(DateTime), string id = default(string), bool isHardDelete = default(bool))
        {
            this.IsLocalized = isLocalized;
            this.LastModified = lastModified;
            this.Id = id;
            this.IsHardDelete = isHardDelete;
        }

        /// <summary>
        /// Gets or Sets IsLocalized
        /// </summary>
        [DataMember(Name = "isLocalized", EmitDefaultValue = true)]
        public bool IsLocalized { get; set; }

        /// <summary>
        /// Gets or Sets LastModified
        /// </summary>
        [DataMember(Name = "lastModified", EmitDefaultValue = false)]
        public DateTime LastModified { get; set; }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets IsHardDelete
        /// </summary>
        [DataMember(Name = "isHardDelete", EmitDefaultValue = true)]
        public bool IsHardDelete { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DeleteMediaModification {\n");
            sb.Append("  IsLocalized: ").Append(IsLocalized).Append("\n");
            sb.Append("  LastModified: ").Append(LastModified).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  IsHardDelete: ").Append(IsHardDelete).Append("\n");
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
            return this.Equals(input as DeleteMediaModification);
        }

        /// <summary>
        /// Returns true if DeleteMediaModification instances are equal
        /// </summary>
        /// <param name="input">Instance of DeleteMediaModification to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DeleteMediaModification input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.IsLocalized == input.IsLocalized ||
                    this.IsLocalized.Equals(input.IsLocalized)
                ) && 
                (
                    this.LastModified == input.LastModified ||
                    (this.LastModified != null &&
                    this.LastModified.Equals(input.LastModified))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.IsHardDelete == input.IsHardDelete ||
                    this.IsHardDelete.Equals(input.IsHardDelete)
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
                hashCode = hashCode * 59 + this.IsLocalized.GetHashCode();
                if (this.LastModified != null)
                    hashCode = hashCode * 59 + this.LastModified.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                hashCode = hashCode * 59 + this.IsHardDelete.GetHashCode();
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
