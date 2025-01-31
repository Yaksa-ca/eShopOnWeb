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
    [DataContract(Name = "UpdateProductDraftRequest")]
    public partial class UpdateProductDraftRequest : IEquatable<UpdateProductDraftRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateProductDraftRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected UpdateProductDraftRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateProductDraftRequest" /> class.
        /// </summary>
        /// <param name="cultureName">Gets or sets the culture (language) name in which the product draft is processed (required).</param>
        /// <param name="deleteVariantModifications">Gets or sets the list of modifications that the draft should apply to the variants (required).</param>
        /// <param name="overwriteModifications">Gets or sets a value indicating wheter to clear the existing motifications and save only the list given in this request or add the given motifications to the existing list. The default value is &#39;true&#39;.</param>
        /// <param name="parentCategoriesModification">parentCategoriesModification (required).</param>
        /// <param name="primaryParentCategoryModification">primaryParentCategoryModification (required).</param>
        /// <param name="productPropertyModifications">Gets or sets the list of modifications that the draft should apply to the product (required).</param>
        /// <param name="variantPropertyModifications">Gets or sets the list of modifications that the draft should apply to the variants (required).</param>
        public UpdateProductDraftRequest(string cultureName = default(string), List<DeleteVariantModification> deleteVariantModifications = default(List<DeleteVariantModification>), bool overwriteModifications = default(bool), ParentCategoriesModification parentCategoriesModification = default(ParentCategoriesModification), PrimaryParentCategoryModification primaryParentCategoryModification = default(PrimaryParentCategoryModification), List<ProductPropertyModification> productPropertyModifications = default(List<ProductPropertyModification>), List<VariantPropertyModification> variantPropertyModifications = default(List<VariantPropertyModification>))
        {
            // to ensure "cultureName" is required (not null)
            this.CultureName = cultureName ?? throw new ArgumentNullException("cultureName is a required property for UpdateProductDraftRequest and cannot be null");
            // to ensure "deleteVariantModifications" is required (not null)
            this.DeleteVariantModifications = deleteVariantModifications ?? throw new ArgumentNullException("deleteVariantModifications is a required property for UpdateProductDraftRequest and cannot be null");
            // to ensure "parentCategoriesModification" is required (not null)
            this.ParentCategoriesModification = parentCategoriesModification ?? throw new ArgumentNullException("parentCategoriesModification is a required property for UpdateProductDraftRequest and cannot be null");
            // to ensure "primaryParentCategoryModification" is required (not null)
            this.PrimaryParentCategoryModification = primaryParentCategoryModification ?? throw new ArgumentNullException("primaryParentCategoryModification is a required property for UpdateProductDraftRequest and cannot be null");
            // to ensure "productPropertyModifications" is required (not null)
            this.ProductPropertyModifications = productPropertyModifications ?? throw new ArgumentNullException("productPropertyModifications is a required property for UpdateProductDraftRequest and cannot be null");
            // to ensure "variantPropertyModifications" is required (not null)
            this.VariantPropertyModifications = variantPropertyModifications ?? throw new ArgumentNullException("variantPropertyModifications is a required property for UpdateProductDraftRequest and cannot be null");
            this.OverwriteModifications = overwriteModifications;
        }

        /// <summary>
        /// Gets or sets the culture (language) name in which the product draft is processed
        /// </summary>
        /// <value>Gets or sets the culture (language) name in which the product draft is processed</value>
        [DataMember(Name = "cultureName", IsRequired = true, EmitDefaultValue = false)]
        public string CultureName { get; set; }

        /// <summary>
        /// Gets or sets the list of modifications that the draft should apply to the variants
        /// </summary>
        /// <value>Gets or sets the list of modifications that the draft should apply to the variants</value>
        [DataMember(Name = "deleteVariantModifications", IsRequired = true, EmitDefaultValue = false)]
        public List<DeleteVariantModification> DeleteVariantModifications { get; set; }

        /// <summary>
        /// Gets or sets a value indicating wheter to clear the existing motifications and save only the list given in this request or add the given motifications to the existing list. The default value is &#39;true&#39;
        /// </summary>
        /// <value>Gets or sets a value indicating wheter to clear the existing motifications and save only the list given in this request or add the given motifications to the existing list. The default value is &#39;true&#39;</value>
        [DataMember(Name = "overwriteModifications", EmitDefaultValue = true)]
        public bool OverwriteModifications { get; set; }

        /// <summary>
        /// Gets or Sets ParentCategoriesModification
        /// </summary>
        [DataMember(Name = "parentCategoriesModification", IsRequired = true, EmitDefaultValue = false)]
        public ParentCategoriesModification ParentCategoriesModification { get; set; }

        /// <summary>
        /// Gets or Sets PrimaryParentCategoryModification
        /// </summary>
        [DataMember(Name = "primaryParentCategoryModification", IsRequired = true, EmitDefaultValue = false)]
        public PrimaryParentCategoryModification PrimaryParentCategoryModification { get; set; }

        /// <summary>
        /// Gets or sets the list of modifications that the draft should apply to the product
        /// </summary>
        /// <value>Gets or sets the list of modifications that the draft should apply to the product</value>
        [DataMember(Name = "productPropertyModifications", IsRequired = true, EmitDefaultValue = false)]
        public List<ProductPropertyModification> ProductPropertyModifications { get; set; }

        /// <summary>
        /// Gets or sets the list of modifications that the draft should apply to the variants
        /// </summary>
        /// <value>Gets or sets the list of modifications that the draft should apply to the variants</value>
        [DataMember(Name = "variantPropertyModifications", IsRequired = true, EmitDefaultValue = false)]
        public List<VariantPropertyModification> VariantPropertyModifications { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateProductDraftRequest {\n");
            sb.Append("  CultureName: ").Append(CultureName).Append("\n");
            sb.Append("  DeleteVariantModifications: ").Append(DeleteVariantModifications).Append("\n");
            sb.Append("  OverwriteModifications: ").Append(OverwriteModifications).Append("\n");
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
            return this.Equals(input as UpdateProductDraftRequest);
        }

        /// <summary>
        /// Returns true if UpdateProductDraftRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of UpdateProductDraftRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UpdateProductDraftRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CultureName == input.CultureName ||
                    (this.CultureName != null &&
                    this.CultureName.Equals(input.CultureName))
                ) && 
                (
                    this.DeleteVariantModifications == input.DeleteVariantModifications ||
                    this.DeleteVariantModifications != null &&
                    input.DeleteVariantModifications != null &&
                    this.DeleteVariantModifications.SequenceEqual(input.DeleteVariantModifications)
                ) && 
                (
                    this.OverwriteModifications == input.OverwriteModifications ||
                    this.OverwriteModifications.Equals(input.OverwriteModifications)
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
                if (this.CultureName != null)
                    hashCode = hashCode * 59 + this.CultureName.GetHashCode();
                if (this.DeleteVariantModifications != null)
                    hashCode = hashCode * 59 + this.DeleteVariantModifications.GetHashCode();
                hashCode = hashCode * 59 + this.OverwriteModifications.GetHashCode();
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
