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
    /// DeleteVariantModification
    /// </summary>
    [DataContract(Name = "DeleteVariantModification")]
    public partial class DeleteVariantModification : IEquatable<DeleteVariantModification>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteVariantModification" /> class.
        /// </summary>
        /// <param name="isLocalized">isLocalized.</param>
        /// <param name="lastModified">lastModified.</param>
        /// <param name="variantId">variantId.</param>
        public DeleteVariantModification(bool isLocalized = default(bool), DateTime lastModified = default(DateTime), string variantId = default(string))
        {
            this.IsLocalized = isLocalized;
            this.LastModified = lastModified;
            this.VariantId = variantId;
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
        /// Gets or Sets VariantId
        /// </summary>
        [DataMember(Name = "variantId", EmitDefaultValue = false)]
        public string VariantId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DeleteVariantModification {\n");
            sb.Append("  IsLocalized: ").Append(IsLocalized).Append("\n");
            sb.Append("  LastModified: ").Append(LastModified).Append("\n");
            sb.Append("  VariantId: ").Append(VariantId).Append("\n");
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
            return this.Equals(input as DeleteVariantModification);
        }

        /// <summary>
        /// Returns true if DeleteVariantModification instances are equal
        /// </summary>
        /// <param name="input">Instance of DeleteVariantModification to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DeleteVariantModification input)
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
                    this.VariantId == input.VariantId ||
                    (this.VariantId != null &&
                    this.VariantId.Equals(input.VariantId))
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
                if (this.VariantId != null)
                    hashCode = hashCode * 59 + this.VariantId.GetHashCode();
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
