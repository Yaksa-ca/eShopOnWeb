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
    /// MediaSettings
    /// </summary>
    [DataContract(Name = "MediaSettings")]
    public partial class MediaSettings : IEquatable<MediaSettings>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MediaSettings" /> class.
        /// </summary>
        /// <param name="mediaAcceptedFileTypes">accepted file types.</param>
        /// <param name="mediaCoverImageSize">this value is used for choosing the size of the of the image when returning ImageUrl for a product cover image.</param>
        /// <param name="mediaFallbackImageName">a fallback image name.</param>
        /// <param name="mediaProductFileNameConvention">a product filename convention.</param>
        /// <param name="mediaProductKeyVariantFileNameConvention">a product variant file name convention.</param>
        /// <param name="mediaProductVariantFileNameConvention"> a product variant file name convention.</param>
        /// <param name="mediaResizeUploadedImagesServerSide">a value indicating whether resize uploaded images server-side.</param>
        /// <param name="mediaServerUrl">media server url.</param>
        /// <param name="mediaSizes">mediaSizes.</param>
        public MediaSettings(string mediaAcceptedFileTypes = default(string), string mediaCoverImageSize = default(string), string mediaFallbackImageName = default(string), string mediaProductFileNameConvention = default(string), string mediaProductKeyVariantFileNameConvention = default(string), string mediaProductVariantFileNameConvention = default(string), bool mediaResizeUploadedImagesServerSide = default(bool), string mediaServerUrl = default(string), Dictionary<string, string> mediaSizes = default(Dictionary<string, string>))
        {
            this.MediaAcceptedFileTypes = mediaAcceptedFileTypes;
            this.MediaCoverImageSize = mediaCoverImageSize;
            this.MediaFallbackImageName = mediaFallbackImageName;
            this.MediaProductFileNameConvention = mediaProductFileNameConvention;
            this.MediaProductKeyVariantFileNameConvention = mediaProductKeyVariantFileNameConvention;
            this.MediaProductVariantFileNameConvention = mediaProductVariantFileNameConvention;
            this.MediaResizeUploadedImagesServerSide = mediaResizeUploadedImagesServerSide;
            this.MediaServerUrl = mediaServerUrl;
            this.MediaSizes = mediaSizes;
        }

        /// <summary>
        /// accepted file types
        /// </summary>
        /// <value>accepted file types</value>
        [DataMember(Name = "mediaAcceptedFileTypes", EmitDefaultValue = false)]
        public string MediaAcceptedFileTypes { get; set; }

        /// <summary>
        /// this value is used for choosing the size of the of the image when returning ImageUrl for a product cover image
        /// </summary>
        /// <value>this value is used for choosing the size of the of the image when returning ImageUrl for a product cover image</value>
        [DataMember(Name = "mediaCoverImageSize", EmitDefaultValue = false)]
        public string MediaCoverImageSize { get; set; }

        /// <summary>
        /// a fallback image name
        /// </summary>
        /// <value>a fallback image name</value>
        [DataMember(Name = "mediaFallbackImageName", EmitDefaultValue = false)]
        public string MediaFallbackImageName { get; set; }

        /// <summary>
        /// a product filename convention
        /// </summary>
        /// <value>a product filename convention</value>
        [DataMember(Name = "mediaProductFileNameConvention", EmitDefaultValue = false)]
        public string MediaProductFileNameConvention { get; set; }

        /// <summary>
        /// a product variant file name convention
        /// </summary>
        /// <value>a product variant file name convention</value>
        [DataMember(Name = "mediaProductKeyVariantFileNameConvention", EmitDefaultValue = false)]
        public string MediaProductKeyVariantFileNameConvention { get; set; }

        /// <summary>
        ///  a product variant file name convention
        /// </summary>
        /// <value> a product variant file name convention</value>
        [DataMember(Name = "mediaProductVariantFileNameConvention", EmitDefaultValue = false)]
        public string MediaProductVariantFileNameConvention { get; set; }

        /// <summary>
        /// a value indicating whether resize uploaded images server-side
        /// </summary>
        /// <value>a value indicating whether resize uploaded images server-side</value>
        [DataMember(Name = "mediaResizeUploadedImagesServerSide", EmitDefaultValue = true)]
        public bool MediaResizeUploadedImagesServerSide { get; set; }

        /// <summary>
        /// media server url
        /// </summary>
        /// <value>media server url</value>
        [DataMember(Name = "mediaServerUrl", EmitDefaultValue = false)]
        public string MediaServerUrl { get; set; }

        /// <summary>
        /// Gets or Sets MediaSizes
        /// </summary>
        [DataMember(Name = "mediaSizes", EmitDefaultValue = false)]
        public Dictionary<string, string> MediaSizes { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MediaSettings {\n");
            sb.Append("  MediaAcceptedFileTypes: ").Append(MediaAcceptedFileTypes).Append("\n");
            sb.Append("  MediaCoverImageSize: ").Append(MediaCoverImageSize).Append("\n");
            sb.Append("  MediaFallbackImageName: ").Append(MediaFallbackImageName).Append("\n");
            sb.Append("  MediaProductFileNameConvention: ").Append(MediaProductFileNameConvention).Append("\n");
            sb.Append("  MediaProductKeyVariantFileNameConvention: ").Append(MediaProductKeyVariantFileNameConvention).Append("\n");
            sb.Append("  MediaProductVariantFileNameConvention: ").Append(MediaProductVariantFileNameConvention).Append("\n");
            sb.Append("  MediaResizeUploadedImagesServerSide: ").Append(MediaResizeUploadedImagesServerSide).Append("\n");
            sb.Append("  MediaServerUrl: ").Append(MediaServerUrl).Append("\n");
            sb.Append("  MediaSizes: ").Append(MediaSizes).Append("\n");
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
            return this.Equals(input as MediaSettings);
        }

        /// <summary>
        /// Returns true if MediaSettings instances are equal
        /// </summary>
        /// <param name="input">Instance of MediaSettings to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MediaSettings input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.MediaAcceptedFileTypes == input.MediaAcceptedFileTypes ||
                    (this.MediaAcceptedFileTypes != null &&
                    this.MediaAcceptedFileTypes.Equals(input.MediaAcceptedFileTypes))
                ) && 
                (
                    this.MediaCoverImageSize == input.MediaCoverImageSize ||
                    (this.MediaCoverImageSize != null &&
                    this.MediaCoverImageSize.Equals(input.MediaCoverImageSize))
                ) && 
                (
                    this.MediaFallbackImageName == input.MediaFallbackImageName ||
                    (this.MediaFallbackImageName != null &&
                    this.MediaFallbackImageName.Equals(input.MediaFallbackImageName))
                ) && 
                (
                    this.MediaProductFileNameConvention == input.MediaProductFileNameConvention ||
                    (this.MediaProductFileNameConvention != null &&
                    this.MediaProductFileNameConvention.Equals(input.MediaProductFileNameConvention))
                ) && 
                (
                    this.MediaProductKeyVariantFileNameConvention == input.MediaProductKeyVariantFileNameConvention ||
                    (this.MediaProductKeyVariantFileNameConvention != null &&
                    this.MediaProductKeyVariantFileNameConvention.Equals(input.MediaProductKeyVariantFileNameConvention))
                ) && 
                (
                    this.MediaProductVariantFileNameConvention == input.MediaProductVariantFileNameConvention ||
                    (this.MediaProductVariantFileNameConvention != null &&
                    this.MediaProductVariantFileNameConvention.Equals(input.MediaProductVariantFileNameConvention))
                ) && 
                (
                    this.MediaResizeUploadedImagesServerSide == input.MediaResizeUploadedImagesServerSide ||
                    this.MediaResizeUploadedImagesServerSide.Equals(input.MediaResizeUploadedImagesServerSide)
                ) && 
                (
                    this.MediaServerUrl == input.MediaServerUrl ||
                    (this.MediaServerUrl != null &&
                    this.MediaServerUrl.Equals(input.MediaServerUrl))
                ) && 
                (
                    this.MediaSizes == input.MediaSizes ||
                    this.MediaSizes != null &&
                    input.MediaSizes != null &&
                    this.MediaSizes.SequenceEqual(input.MediaSizes)
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
                if (this.MediaAcceptedFileTypes != null)
                    hashCode = hashCode * 59 + this.MediaAcceptedFileTypes.GetHashCode();
                if (this.MediaCoverImageSize != null)
                    hashCode = hashCode * 59 + this.MediaCoverImageSize.GetHashCode();
                if (this.MediaFallbackImageName != null)
                    hashCode = hashCode * 59 + this.MediaFallbackImageName.GetHashCode();
                if (this.MediaProductFileNameConvention != null)
                    hashCode = hashCode * 59 + this.MediaProductFileNameConvention.GetHashCode();
                if (this.MediaProductKeyVariantFileNameConvention != null)
                    hashCode = hashCode * 59 + this.MediaProductKeyVariantFileNameConvention.GetHashCode();
                if (this.MediaProductVariantFileNameConvention != null)
                    hashCode = hashCode * 59 + this.MediaProductVariantFileNameConvention.GetHashCode();
                hashCode = hashCode * 59 + this.MediaResizeUploadedImagesServerSide.GetHashCode();
                if (this.MediaServerUrl != null)
                    hashCode = hashCode * 59 + this.MediaServerUrl.GetHashCode();
                if (this.MediaSizes != null)
                    hashCode = hashCode * 59 + this.MediaSizes.GetHashCode();
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
