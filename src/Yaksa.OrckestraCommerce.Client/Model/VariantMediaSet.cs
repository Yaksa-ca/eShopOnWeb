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
    /// VariantMediaSet
    /// </summary>
    [DataContract(Name = "VariantMediaSet")]
    public partial class VariantMediaSet : IEquatable<VariantMediaSet>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VariantMediaSet" /> class.
        /// </summary>
        /// <param name="attributesToMatch">attributesToMatch.</param>
        /// <param name="media">the list of Media of the Product.</param>
        public VariantMediaSet(Dictionary<string, Object> attributesToMatch = default(Dictionary<string, Object>), List<ProductMedia> media = default(List<ProductMedia>))
        {
            this.AttributesToMatch = attributesToMatch;
            this.Media = media;
        }

        /// <summary>
        /// Gets or Sets AttributesToMatch
        /// </summary>
        [DataMember(Name = "attributesToMatch", EmitDefaultValue = false)]
        public Dictionary<string, Object> AttributesToMatch { get; set; }

        /// <summary>
        /// the list of Media of the Product
        /// </summary>
        /// <value>the list of Media of the Product</value>
        [DataMember(Name = "media", EmitDefaultValue = false)]
        public List<ProductMedia> Media { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class VariantMediaSet {\n");
            sb.Append("  AttributesToMatch: ").Append(AttributesToMatch).Append("\n");
            sb.Append("  Media: ").Append(Media).Append("\n");
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
            return this.Equals(input as VariantMediaSet);
        }

        /// <summary>
        /// Returns true if VariantMediaSet instances are equal
        /// </summary>
        /// <param name="input">Instance of VariantMediaSet to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(VariantMediaSet input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AttributesToMatch == input.AttributesToMatch ||
                    this.AttributesToMatch != null &&
                    input.AttributesToMatch != null &&
                    this.AttributesToMatch.SequenceEqual(input.AttributesToMatch)
                ) && 
                (
                    this.Media == input.Media ||
                    this.Media != null &&
                    input.Media != null &&
                    this.Media.SequenceEqual(input.Media)
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
                if (this.AttributesToMatch != null)
                    hashCode = hashCode * 59 + this.AttributesToMatch.GetHashCode();
                if (this.Media != null)
                    hashCode = hashCode * 59 + this.Media.GetHashCode();
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
