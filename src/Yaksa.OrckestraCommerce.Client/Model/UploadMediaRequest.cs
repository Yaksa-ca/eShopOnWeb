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
    /// Products are entities which represents a buyable item managed in a catalog.
    /// </summary>
    [DataContract(Name = "UploadMediaRequest")]
    public partial class UploadMediaRequest : IEquatable<UploadMediaRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UploadMediaRequest" /> class.
        /// </summary>
        /// <param name="attributesToMatch">attributesToMatch.</param>
        /// <param name="description">description.</param>
        /// <param name="mediaType">the MediaType of the media.</param>
        /// <param name="tag">a tag of the Media.</param>
        /// <param name="title">title.</param>
        /// <param name="url">the Url instead upload image.</param>
        /// <param name="variantId">the id of the variant for which we want to upload media.</param>
        public UploadMediaRequest(Dictionary<string, Object> attributesToMatch = default(Dictionary<string, Object>), Dictionary<string, string> description = default(Dictionary<string, string>), string mediaType = default(string), string tag = default(string), Dictionary<string, string> title = default(Dictionary<string, string>), string url = default(string), string variantId = default(string))
        {
            this.AttributesToMatch = attributesToMatch;
            this.Description = description;
            this.MediaType = mediaType;
            this.Tag = tag;
            this.Title = title;
            this.Url = url;
            this.VariantId = variantId;
        }

        /// <summary>
        /// Gets or Sets AttributesToMatch
        /// </summary>
        [DataMember(Name = "attributesToMatch", EmitDefaultValue = false)]
        public Dictionary<string, Object> AttributesToMatch { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name = "description", EmitDefaultValue = false)]
        public Dictionary<string, string> Description { get; set; }

        /// <summary>
        /// the MediaType of the media
        /// </summary>
        /// <value>the MediaType of the media</value>
        [DataMember(Name = "mediaType", EmitDefaultValue = false)]
        public string MediaType { get; set; }

        /// <summary>
        /// a tag of the Media
        /// </summary>
        /// <value>a tag of the Media</value>
        [DataMember(Name = "tag", EmitDefaultValue = false)]
        public string Tag { get; set; }

        /// <summary>
        /// Gets or Sets Title
        /// </summary>
        [DataMember(Name = "title", EmitDefaultValue = false)]
        public Dictionary<string, string> Title { get; set; }

        /// <summary>
        /// the Url instead upload image
        /// </summary>
        /// <value>the Url instead upload image</value>
        [DataMember(Name = "url", EmitDefaultValue = false)]
        public string Url { get; set; }

        /// <summary>
        /// the id of the variant for which we want to upload media
        /// </summary>
        /// <value>the id of the variant for which we want to upload media</value>
        [DataMember(Name = "variantId", EmitDefaultValue = false)]
        public string VariantId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UploadMediaRequest {\n");
            sb.Append("  AttributesToMatch: ").Append(AttributesToMatch).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  MediaType: ").Append(MediaType).Append("\n");
            sb.Append("  Tag: ").Append(Tag).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  Url: ").Append(Url).Append("\n");
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
            return this.Equals(input as UploadMediaRequest);
        }

        /// <summary>
        /// Returns true if UploadMediaRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of UploadMediaRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UploadMediaRequest input)
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
                    this.Description == input.Description ||
                    this.Description != null &&
                    input.Description != null &&
                    this.Description.SequenceEqual(input.Description)
                ) && 
                (
                    this.MediaType == input.MediaType ||
                    (this.MediaType != null &&
                    this.MediaType.Equals(input.MediaType))
                ) && 
                (
                    this.Tag == input.Tag ||
                    (this.Tag != null &&
                    this.Tag.Equals(input.Tag))
                ) && 
                (
                    this.Title == input.Title ||
                    this.Title != null &&
                    input.Title != null &&
                    this.Title.SequenceEqual(input.Title)
                ) && 
                (
                    this.Url == input.Url ||
                    (this.Url != null &&
                    this.Url.Equals(input.Url))
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
                if (this.AttributesToMatch != null)
                    hashCode = hashCode * 59 + this.AttributesToMatch.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.MediaType != null)
                    hashCode = hashCode * 59 + this.MediaType.GetHashCode();
                if (this.Tag != null)
                    hashCode = hashCode * 59 + this.Tag.GetHashCode();
                if (this.Title != null)
                    hashCode = hashCode * 59 + this.Title.GetHashCode();
                if (this.Url != null)
                    hashCode = hashCode * 59 + this.Url.GetHashCode();
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
