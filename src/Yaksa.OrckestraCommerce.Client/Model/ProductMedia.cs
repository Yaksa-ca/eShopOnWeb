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
    /// ProductMedia
    /// </summary>
    [DataContract(Name = "ProductMedia")]
    public partial class ProductMedia : IEquatable<ProductMedia>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProductMedia" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ProductMedia() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ProductMedia" /> class.
        /// </summary>
        /// <param name="id">The unique identifier of the entity. (required).</param>
        /// <param name="propertyBag">propertyBag.</param>
        /// <param name="created">Date the entity was created.</param>
        /// <param name="createdBy">Identifier of the operator who created the entity.</param>
        /// <param name="lastModified">Date that the last modification was applied to the entity.</param>
        /// <param name="lastModifiedBy">Identifier of the operator who last modified the entity.</param>
        /// <param name="cleanUpOnDelete">Indicates whether the related media file should be deleted from the Azure Storage when this reference to it is removed..</param>
        /// <param name="description">description.</param>
        /// <param name="isCover">a cover of the Product..</param>
        /// <param name="mediaType">the MediaType of the media..</param>
        /// <param name="position">a position of the Media..</param>
        /// <param name="resizedInstances">a resized instances of the Media.</param>
        /// <param name="role">a role of the Media..</param>
        /// <param name="tag">a tag of the Media..</param>
        /// <param name="title">title.</param>
        /// <param name="url">the Url of the media..</param>
        /// <param name="isRemoved">isRemoved.</param>
        public ProductMedia(string id = default(string), Dictionary<string, Object> propertyBag = default(Dictionary<string, Object>), DateTime created = default(DateTime), string createdBy = default(string), DateTime lastModified = default(DateTime), string lastModifiedBy = default(string), bool cleanUpOnDelete = default(bool), Dictionary<string, string> description = default(Dictionary<string, string>), bool isCover = default(bool), string mediaType = default(string), int position = default(int), List<ResizedMediaLink> resizedInstances = default(List<ResizedMediaLink>), string role = default(string), string tag = default(string), Dictionary<string, string> title = default(Dictionary<string, string>), string url = default(string), bool isRemoved = default(bool))
        {
            // to ensure "id" is required (not null)
            this.Id = id ?? throw new ArgumentNullException("id is a required property for ProductMedia and cannot be null");
            this.PropertyBag = propertyBag;
            this.Created = created;
            this.CreatedBy = createdBy;
            this.LastModified = lastModified;
            this.LastModifiedBy = lastModifiedBy;
            this.CleanUpOnDelete = cleanUpOnDelete;
            this.Description = description;
            this.IsCover = isCover;
            this.MediaType = mediaType;
            this.Position = position;
            this.ResizedInstances = resizedInstances;
            this.Role = role;
            this.Tag = tag;
            this.Title = title;
            this.Url = url;
            this.IsRemoved = isRemoved;
        }

        /// <summary>
        /// The unique identifier of the entity.
        /// </summary>
        /// <value>The unique identifier of the entity.</value>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets PropertyBag
        /// </summary>
        [DataMember(Name = "propertyBag", EmitDefaultValue = false)]
        public Dictionary<string, Object> PropertyBag { get; set; }

        /// <summary>
        /// Date the entity was created
        /// </summary>
        /// <value>Date the entity was created</value>
        [DataMember(Name = "created", EmitDefaultValue = false)]
        public DateTime Created { get; set; }

        /// <summary>
        /// Identifier of the operator who created the entity
        /// </summary>
        /// <value>Identifier of the operator who created the entity</value>
        [DataMember(Name = "createdBy", EmitDefaultValue = false)]
        public string CreatedBy { get; set; }

        /// <summary>
        /// Date that the last modification was applied to the entity
        /// </summary>
        /// <value>Date that the last modification was applied to the entity</value>
        [DataMember(Name = "lastModified", EmitDefaultValue = false)]
        public DateTime LastModified { get; set; }

        /// <summary>
        /// Identifier of the operator who last modified the entity
        /// </summary>
        /// <value>Identifier of the operator who last modified the entity</value>
        [DataMember(Name = "lastModifiedBy", EmitDefaultValue = false)]
        public string LastModifiedBy { get; set; }

        /// <summary>
        /// Indicates whether the related media file should be deleted from the Azure Storage when this reference to it is removed.
        /// </summary>
        /// <value>Indicates whether the related media file should be deleted from the Azure Storage when this reference to it is removed.</value>
        [DataMember(Name = "cleanUpOnDelete", EmitDefaultValue = true)]
        public bool CleanUpOnDelete { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name = "description", EmitDefaultValue = false)]
        public Dictionary<string, string> Description { get; set; }

        /// <summary>
        /// a cover of the Product.
        /// </summary>
        /// <value>a cover of the Product.</value>
        [DataMember(Name = "isCover", EmitDefaultValue = true)]
        public bool IsCover { get; set; }

        /// <summary>
        /// the MediaType of the media.
        /// </summary>
        /// <value>the MediaType of the media.</value>
        [DataMember(Name = "mediaType", EmitDefaultValue = false)]
        public string MediaType { get; set; }

        /// <summary>
        /// a position of the Media.
        /// </summary>
        /// <value>a position of the Media.</value>
        [DataMember(Name = "position", EmitDefaultValue = false)]
        public int Position { get; set; }

        /// <summary>
        /// a resized instances of the Media
        /// </summary>
        /// <value>a resized instances of the Media</value>
        [DataMember(Name = "resizedInstances", EmitDefaultValue = false)]
        public List<ResizedMediaLink> ResizedInstances { get; set; }

        /// <summary>
        /// a role of the Media.
        /// </summary>
        /// <value>a role of the Media.</value>
        [DataMember(Name = "role", EmitDefaultValue = false)]
        public string Role { get; set; }

        /// <summary>
        /// a tag of the Media.
        /// </summary>
        /// <value>a tag of the Media.</value>
        [DataMember(Name = "tag", EmitDefaultValue = false)]
        public string Tag { get; set; }

        /// <summary>
        /// Gets or Sets Title
        /// </summary>
        [DataMember(Name = "title", EmitDefaultValue = false)]
        public Dictionary<string, string> Title { get; set; }

        /// <summary>
        /// the Url of the media.
        /// </summary>
        /// <value>the Url of the media.</value>
        [DataMember(Name = "url", EmitDefaultValue = false)]
        public string Url { get; set; }

        /// <summary>
        /// Gets or Sets IsRemoved
        /// </summary>
        [DataMember(Name = "isRemoved", EmitDefaultValue = true)]
        public bool IsRemoved { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ProductMedia {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  PropertyBag: ").Append(PropertyBag).Append("\n");
            sb.Append("  Created: ").Append(Created).Append("\n");
            sb.Append("  CreatedBy: ").Append(CreatedBy).Append("\n");
            sb.Append("  LastModified: ").Append(LastModified).Append("\n");
            sb.Append("  LastModifiedBy: ").Append(LastModifiedBy).Append("\n");
            sb.Append("  CleanUpOnDelete: ").Append(CleanUpOnDelete).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  IsCover: ").Append(IsCover).Append("\n");
            sb.Append("  MediaType: ").Append(MediaType).Append("\n");
            sb.Append("  Position: ").Append(Position).Append("\n");
            sb.Append("  ResizedInstances: ").Append(ResizedInstances).Append("\n");
            sb.Append("  Role: ").Append(Role).Append("\n");
            sb.Append("  Tag: ").Append(Tag).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  Url: ").Append(Url).Append("\n");
            sb.Append("  IsRemoved: ").Append(IsRemoved).Append("\n");
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
            return this.Equals(input as ProductMedia);
        }

        /// <summary>
        /// Returns true if ProductMedia instances are equal
        /// </summary>
        /// <param name="input">Instance of ProductMedia to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ProductMedia input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.PropertyBag == input.PropertyBag ||
                    this.PropertyBag != null &&
                    input.PropertyBag != null &&
                    this.PropertyBag.SequenceEqual(input.PropertyBag)
                ) && 
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
                    this.CleanUpOnDelete == input.CleanUpOnDelete ||
                    this.CleanUpOnDelete.Equals(input.CleanUpOnDelete)
                ) && 
                (
                    this.Description == input.Description ||
                    this.Description != null &&
                    input.Description != null &&
                    this.Description.SequenceEqual(input.Description)
                ) && 
                (
                    this.IsCover == input.IsCover ||
                    this.IsCover.Equals(input.IsCover)
                ) && 
                (
                    this.MediaType == input.MediaType ||
                    (this.MediaType != null &&
                    this.MediaType.Equals(input.MediaType))
                ) && 
                (
                    this.Position == input.Position ||
                    this.Position.Equals(input.Position)
                ) && 
                (
                    this.ResizedInstances == input.ResizedInstances ||
                    this.ResizedInstances != null &&
                    input.ResizedInstances != null &&
                    this.ResizedInstances.SequenceEqual(input.ResizedInstances)
                ) && 
                (
                    this.Role == input.Role ||
                    (this.Role != null &&
                    this.Role.Equals(input.Role))
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
                    this.IsRemoved == input.IsRemoved ||
                    this.IsRemoved.Equals(input.IsRemoved)
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.PropertyBag != null)
                    hashCode = hashCode * 59 + this.PropertyBag.GetHashCode();
                if (this.Created != null)
                    hashCode = hashCode * 59 + this.Created.GetHashCode();
                if (this.CreatedBy != null)
                    hashCode = hashCode * 59 + this.CreatedBy.GetHashCode();
                if (this.LastModified != null)
                    hashCode = hashCode * 59 + this.LastModified.GetHashCode();
                if (this.LastModifiedBy != null)
                    hashCode = hashCode * 59 + this.LastModifiedBy.GetHashCode();
                hashCode = hashCode * 59 + this.CleanUpOnDelete.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                hashCode = hashCode * 59 + this.IsCover.GetHashCode();
                if (this.MediaType != null)
                    hashCode = hashCode * 59 + this.MediaType.GetHashCode();
                hashCode = hashCode * 59 + this.Position.GetHashCode();
                if (this.ResizedInstances != null)
                    hashCode = hashCode * 59 + this.ResizedInstances.GetHashCode();
                if (this.Role != null)
                    hashCode = hashCode * 59 + this.Role.GetHashCode();
                if (this.Tag != null)
                    hashCode = hashCode * 59 + this.Tag.GetHashCode();
                if (this.Title != null)
                    hashCode = hashCode * 59 + this.Title.GetHashCode();
                if (this.Url != null)
                    hashCode = hashCode * 59 + this.Url.GetHashCode();
                hashCode = hashCode * 59 + this.IsRemoved.GetHashCode();
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
