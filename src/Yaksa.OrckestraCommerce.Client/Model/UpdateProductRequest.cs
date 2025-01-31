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
    [DataContract(Name = "UpdateProductRequest")]
    public partial class UpdateProductRequest : IEquatable<UpdateProductRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateProductRequest" /> class.
        /// </summary>
        /// <param name="addMediaModifications">Gets or sets the list of media that should be added to the media.</param>
        /// <param name="addVariantModifications">Gets or sets the list of variants that should be added to the product.</param>
        /// <param name="deleteMediaModifications">Gets or sets the list of delete modifications that the draft should apply to the media..</param>
        /// <param name="deleteVariantModifications">Gets or sets the list of modifications that the draft should apply to the variants.</param>
        /// <param name="mediaPropertyModifications">Gets or sets the list of modifications that the draft should apply to the media.</param>
        /// <param name="parentCategoriesModification">parentCategoriesModification.</param>
        /// <param name="primaryParentCategoryModification">primaryParentCategoryModification.</param>
        /// <param name="productPropertyModifications">Gets or sets the list of modifications that the draft should apply to the product.</param>
        /// <param name="variantPropertyModifications">Gets or sets the list of modifications that the draft should apply to the variants.</param>
        public UpdateProductRequest(List<AddMediaModification> addMediaModifications = default(List<AddMediaModification>), List<AddVariantModification> addVariantModifications = default(List<AddVariantModification>), List<DeleteMediaModification> deleteMediaModifications = default(List<DeleteMediaModification>), List<DeleteVariantModification> deleteVariantModifications = default(List<DeleteVariantModification>), List<MediaPropertyModification> mediaPropertyModifications = default(List<MediaPropertyModification>), ParentCategoriesModification parentCategoriesModification = default(ParentCategoriesModification), PrimaryParentCategoryModification primaryParentCategoryModification = default(PrimaryParentCategoryModification), List<ProductPropertyModification> productPropertyModifications = default(List<ProductPropertyModification>), List<VariantPropertyModification> variantPropertyModifications = default(List<VariantPropertyModification>))
        {
            this.AddMediaModifications = addMediaModifications;
            this.AddVariantModifications = addVariantModifications;
            this.DeleteMediaModifications = deleteMediaModifications;
            this.DeleteVariantModifications = deleteVariantModifications;
            this.MediaPropertyModifications = mediaPropertyModifications;
            this.ParentCategoriesModification = parentCategoriesModification;
            this.PrimaryParentCategoryModification = primaryParentCategoryModification;
            this.ProductPropertyModifications = productPropertyModifications;
            this.VariantPropertyModifications = variantPropertyModifications;
        }

        /// <summary>
        /// Gets or sets the list of media that should be added to the media
        /// </summary>
        /// <value>Gets or sets the list of media that should be added to the media</value>
        [DataMember(Name = "addMediaModifications", EmitDefaultValue = false)]
        public List<AddMediaModification> AddMediaModifications { get; set; }

        /// <summary>
        /// Gets or sets the list of variants that should be added to the product
        /// </summary>
        /// <value>Gets or sets the list of variants that should be added to the product</value>
        [DataMember(Name = "addVariantModifications", EmitDefaultValue = false)]
        public List<AddVariantModification> AddVariantModifications { get; set; }

        /// <summary>
        /// Gets or sets the list of delete modifications that the draft should apply to the media.
        /// </summary>
        /// <value>Gets or sets the list of delete modifications that the draft should apply to the media.</value>
        [DataMember(Name = "deleteMediaModifications", EmitDefaultValue = false)]
        public List<DeleteMediaModification> DeleteMediaModifications { get; set; }

        /// <summary>
        /// Gets or sets the list of modifications that the draft should apply to the variants
        /// </summary>
        /// <value>Gets or sets the list of modifications that the draft should apply to the variants</value>
        [DataMember(Name = "deleteVariantModifications", EmitDefaultValue = false)]
        public List<DeleteVariantModification> DeleteVariantModifications { get; set; }

        /// <summary>
        /// Gets or sets the list of modifications that the draft should apply to the media
        /// </summary>
        /// <value>Gets or sets the list of modifications that the draft should apply to the media</value>
        [DataMember(Name = "mediaPropertyModifications", EmitDefaultValue = false)]
        public List<MediaPropertyModification> MediaPropertyModifications { get; set; }

        /// <summary>
        /// Gets or Sets ParentCategoriesModification
        /// </summary>
        [DataMember(Name = "parentCategoriesModification", EmitDefaultValue = false)]
        public ParentCategoriesModification ParentCategoriesModification { get; set; }

        /// <summary>
        /// Gets or Sets PrimaryParentCategoryModification
        /// </summary>
        [DataMember(Name = "primaryParentCategoryModification", EmitDefaultValue = false)]
        public PrimaryParentCategoryModification PrimaryParentCategoryModification { get; set; }

        /// <summary>
        /// Gets or sets the list of modifications that the draft should apply to the product
        /// </summary>
        /// <value>Gets or sets the list of modifications that the draft should apply to the product</value>
        [DataMember(Name = "productPropertyModifications", EmitDefaultValue = false)]
        public List<ProductPropertyModification> ProductPropertyModifications { get; set; }

        /// <summary>
        /// Gets or sets the list of modifications that the draft should apply to the variants
        /// </summary>
        /// <value>Gets or sets the list of modifications that the draft should apply to the variants</value>
        [DataMember(Name = "variantPropertyModifications", EmitDefaultValue = false)]
        public List<VariantPropertyModification> VariantPropertyModifications { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateProductRequest {\n");
            sb.Append("  AddMediaModifications: ").Append(AddMediaModifications).Append("\n");
            sb.Append("  AddVariantModifications: ").Append(AddVariantModifications).Append("\n");
            sb.Append("  DeleteMediaModifications: ").Append(DeleteMediaModifications).Append("\n");
            sb.Append("  DeleteVariantModifications: ").Append(DeleteVariantModifications).Append("\n");
            sb.Append("  MediaPropertyModifications: ").Append(MediaPropertyModifications).Append("\n");
            sb.Append("  ParentCategoriesModification: ").Append(ParentCategoriesModification).Append("\n");
            sb.Append("  PrimaryParentCategoryModification: ").Append(PrimaryParentCategoryModification).Append("\n");
            sb.Append("  ProductPropertyModifications: ").Append(ProductPropertyModifications).Append("\n");
            sb.Append("  VariantPropertyModifications: ").Append(VariantPropertyModifications).Append("\n");
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
            return this.Equals(input as UpdateProductRequest);
        }

        /// <summary>
        /// Returns true if UpdateProductRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of UpdateProductRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UpdateProductRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AddMediaModifications == input.AddMediaModifications ||
                    this.AddMediaModifications != null &&
                    input.AddMediaModifications != null &&
                    this.AddMediaModifications.SequenceEqual(input.AddMediaModifications)
                ) && 
                (
                    this.AddVariantModifications == input.AddVariantModifications ||
                    this.AddVariantModifications != null &&
                    input.AddVariantModifications != null &&
                    this.AddVariantModifications.SequenceEqual(input.AddVariantModifications)
                ) && 
                (
                    this.DeleteMediaModifications == input.DeleteMediaModifications ||
                    this.DeleteMediaModifications != null &&
                    input.DeleteMediaModifications != null &&
                    this.DeleteMediaModifications.SequenceEqual(input.DeleteMediaModifications)
                ) && 
                (
                    this.DeleteVariantModifications == input.DeleteVariantModifications ||
                    this.DeleteVariantModifications != null &&
                    input.DeleteVariantModifications != null &&
                    this.DeleteVariantModifications.SequenceEqual(input.DeleteVariantModifications)
                ) && 
                (
                    this.MediaPropertyModifications == input.MediaPropertyModifications ||
                    this.MediaPropertyModifications != null &&
                    input.MediaPropertyModifications != null &&
                    this.MediaPropertyModifications.SequenceEqual(input.MediaPropertyModifications)
                ) && 
                (
                    this.ParentCategoriesModification == input.ParentCategoriesModification ||
                    (this.ParentCategoriesModification != null &&
                    this.ParentCategoriesModification.Equals(input.ParentCategoriesModification))
                ) && 
                (
                    this.PrimaryParentCategoryModification == input.PrimaryParentCategoryModification ||
                    (this.PrimaryParentCategoryModification != null &&
                    this.PrimaryParentCategoryModification.Equals(input.PrimaryParentCategoryModification))
                ) && 
                (
                    this.ProductPropertyModifications == input.ProductPropertyModifications ||
                    this.ProductPropertyModifications != null &&
                    input.ProductPropertyModifications != null &&
                    this.ProductPropertyModifications.SequenceEqual(input.ProductPropertyModifications)
                ) && 
                (
                    this.VariantPropertyModifications == input.VariantPropertyModifications ||
                    this.VariantPropertyModifications != null &&
                    input.VariantPropertyModifications != null &&
                    this.VariantPropertyModifications.SequenceEqual(input.VariantPropertyModifications)
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
                if (this.AddMediaModifications != null)
                    hashCode = hashCode * 59 + this.AddMediaModifications.GetHashCode();
                if (this.AddVariantModifications != null)
                    hashCode = hashCode * 59 + this.AddVariantModifications.GetHashCode();
                if (this.DeleteMediaModifications != null)
                    hashCode = hashCode * 59 + this.DeleteMediaModifications.GetHashCode();
                if (this.DeleteVariantModifications != null)
                    hashCode = hashCode * 59 + this.DeleteVariantModifications.GetHashCode();
                if (this.MediaPropertyModifications != null)
                    hashCode = hashCode * 59 + this.MediaPropertyModifications.GetHashCode();
                if (this.ParentCategoriesModification != null)
                    hashCode = hashCode * 59 + this.ParentCategoriesModification.GetHashCode();
                if (this.PrimaryParentCategoryModification != null)
                    hashCode = hashCode * 59 + this.PrimaryParentCategoryModification.GetHashCode();
                if (this.ProductPropertyModifications != null)
                    hashCode = hashCode * 59 + this.ProductPropertyModifications.GetHashCode();
                if (this.VariantPropertyModifications != null)
                    hashCode = hashCode * 59 + this.VariantPropertyModifications.GetHashCode();
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
