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
    /// UrlInfo
    /// </summary>
    [DataContract(Name = "UrlInfo")]
    public partial class UrlInfo : IEquatable<UrlInfo>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UrlInfo" /> class.
        /// </summary>
        /// <param name="websiteUrl">The website URL of the clinic. The host is retrieved from the Template variables..</param>
        /// <param name="logoPath">logoPath.</param>
        /// <param name="logoUrl">logoUrl.</param>
        /// <param name="imageUrl">The URL for the clinic&#39;s image.</param>
        /// <param name="externalLogoUrl">externalLogoUrl.</param>
        public UrlInfo(string websiteUrl = default(string), Dictionary<string, string> logoPath = default(Dictionary<string, string>), Dictionary<string, string> logoUrl = default(Dictionary<string, string>), string imageUrl = default(string), Dictionary<string, string> externalLogoUrl = default(Dictionary<string, string>))
        {
            this.WebsiteUrl = websiteUrl;
            this.LogoPath = logoPath;
            this.LogoUrl = logoUrl;
            this.ImageUrl = imageUrl;
            this.ExternalLogoUrl = externalLogoUrl;
        }

        /// <summary>
        /// The website URL of the clinic. The host is retrieved from the Template variables.
        /// </summary>
        /// <value>The website URL of the clinic. The host is retrieved from the Template variables.</value>
        [DataMember(Name = "websiteUrl", EmitDefaultValue = false)]
        public string WebsiteUrl { get; set; }

        /// <summary>
        /// Gets or Sets LogoPath
        /// </summary>
        [DataMember(Name = "logoPath", EmitDefaultValue = false)]
        public Dictionary<string, string> LogoPath { get; set; }

        /// <summary>
        /// Gets or Sets LogoUrl
        /// </summary>
        [DataMember(Name = "logoUrl", EmitDefaultValue = false)]
        public Dictionary<string, string> LogoUrl { get; set; }

        /// <summary>
        /// The URL for the clinic&#39;s image
        /// </summary>
        /// <value>The URL for the clinic&#39;s image</value>
        [DataMember(Name = "imageUrl", EmitDefaultValue = false)]
        public string ImageUrl { get; set; }

        /// <summary>
        /// Gets or Sets ExternalLogoUrl
        /// </summary>
        [DataMember(Name = "externalLogoUrl", EmitDefaultValue = false)]
        public Dictionary<string, string> ExternalLogoUrl { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UrlInfo {\n");
            sb.Append("  WebsiteUrl: ").Append(WebsiteUrl).Append("\n");
            sb.Append("  LogoPath: ").Append(LogoPath).Append("\n");
            sb.Append("  LogoUrl: ").Append(LogoUrl).Append("\n");
            sb.Append("  ImageUrl: ").Append(ImageUrl).Append("\n");
            sb.Append("  ExternalLogoUrl: ").Append(ExternalLogoUrl).Append("\n");
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
            return this.Equals(input as UrlInfo);
        }

        /// <summary>
        /// Returns true if UrlInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of UrlInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UrlInfo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.WebsiteUrl == input.WebsiteUrl ||
                    (this.WebsiteUrl != null &&
                    this.WebsiteUrl.Equals(input.WebsiteUrl))
                ) && 
                (
                    this.LogoPath == input.LogoPath ||
                    this.LogoPath != null &&
                    input.LogoPath != null &&
                    this.LogoPath.SequenceEqual(input.LogoPath)
                ) && 
                (
                    this.LogoUrl == input.LogoUrl ||
                    this.LogoUrl != null &&
                    input.LogoUrl != null &&
                    this.LogoUrl.SequenceEqual(input.LogoUrl)
                ) && 
                (
                    this.ImageUrl == input.ImageUrl ||
                    (this.ImageUrl != null &&
                    this.ImageUrl.Equals(input.ImageUrl))
                ) && 
                (
                    this.ExternalLogoUrl == input.ExternalLogoUrl ||
                    this.ExternalLogoUrl != null &&
                    input.ExternalLogoUrl != null &&
                    this.ExternalLogoUrl.SequenceEqual(input.ExternalLogoUrl)
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
                if (this.WebsiteUrl != null)
                    hashCode = hashCode * 59 + this.WebsiteUrl.GetHashCode();
                if (this.LogoPath != null)
                    hashCode = hashCode * 59 + this.LogoPath.GetHashCode();
                if (this.LogoUrl != null)
                    hashCode = hashCode * 59 + this.LogoUrl.GetHashCode();
                if (this.ImageUrl != null)
                    hashCode = hashCode * 59 + this.ImageUrl.GetHashCode();
                if (this.ExternalLogoUrl != null)
                    hashCode = hashCode * 59 + this.ExternalLogoUrl.GetHashCode();
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
