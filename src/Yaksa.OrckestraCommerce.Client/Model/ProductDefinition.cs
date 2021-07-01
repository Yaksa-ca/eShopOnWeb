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
    /// ProductDefinition
    /// </summary>
    [DataContract(Name = "ProductDefinition")]
    public partial class ProductDefinition : IEquatable<ProductDefinition>, IValidatableObject
    {
        /// <summary>
        /// The type of entity for which the definition applies (Product or Category)
        /// </summary>
        /// <value>The type of entity for which the definition applies (Product or Category)</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ProductTypeEnum
        {
            /// <summary>
            /// Enum Product for value: Product
            /// </summary>
            [EnumMember(Value = "Product")]
            Product = 1,

            /// <summary>
            /// Enum Category for value: Category
            /// </summary>
            [EnumMember(Value = "Category")]
            Category = 2

        }


        /// <summary>
        /// The type of entity for which the definition applies (Product or Category)
        /// </summary>
        /// <value>The type of entity for which the definition applies (Product or Category)</value>
        [DataMember(Name = "productType", EmitDefaultValue = false)]
        public ProductTypeEnum? ProductType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ProductDefinition" /> class.
        /// </summary>
        /// <param name="allowPriceLists">Whether the entity can have list prices associated to it.</param>
        /// <param name="description">The description (non multilingual) of the entity definition.</param>
        /// <param name="displayName">displayName.</param>
        /// <param name="name">The name (business key) of the definition.</param>
        /// <param name="productType">The type of entity for which the definition applies (Product or Category).</param>
        /// <param name="properties">The non-grouped properties that are assigned to the definition.</param>
        /// <param name="propertyGroups">The groups containing properties that are assigned to the definition.</param>
        /// <param name="sequenceNumber">A number defining the order in which the definition appears in the list.</param>
        /// <param name="variantProperties">The list of attributes assigned to the definition allowing Variant of a product. An empty collection means that variants are not allowedOnly available for a Product definition, not a Category.</param>
        public ProductDefinition(bool allowPriceLists = default(bool), string description = default(string), Dictionary<string, string> displayName = default(Dictionary<string, string>), string name = default(string), ProductTypeEnum? productType = default(ProductTypeEnum?), List<ProductPropertyDefinition> properties = default(List<ProductPropertyDefinition>), List<ProductPropertyDefinitionGroup> propertyGroups = default(List<ProductPropertyDefinitionGroup>), int sequenceNumber = default(int), List<ProductPropertyDefinition> variantProperties = default(List<ProductPropertyDefinition>))
        {
            this.AllowPriceLists = allowPriceLists;
            this.Description = description;
            this.DisplayName = displayName;
            this.Name = name;
            this.ProductType = productType;
            this.Properties = properties;
            this.PropertyGroups = propertyGroups;
            this.SequenceNumber = sequenceNumber;
            this.VariantProperties = variantProperties;
        }

        /// <summary>
        /// Whether the entity can have list prices associated to it
        /// </summary>
        /// <value>Whether the entity can have list prices associated to it</value>
        [DataMember(Name = "allowPriceLists", EmitDefaultValue = true)]
        public bool AllowPriceLists { get; set; }

        /// <summary>
        /// The description (non multilingual) of the entity definition
        /// </summary>
        /// <value>The description (non multilingual) of the entity definition</value>
        [DataMember(Name = "description", EmitDefaultValue = false)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets DisplayName
        /// </summary>
        [DataMember(Name = "displayName", EmitDefaultValue = false)]
        public Dictionary<string, string> DisplayName { get; set; }

        /// <summary>
        /// The name (business key) of the definition
        /// </summary>
        /// <value>The name (business key) of the definition</value>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// The non-grouped properties that are assigned to the definition
        /// </summary>
        /// <value>The non-grouped properties that are assigned to the definition</value>
        [DataMember(Name = "properties", EmitDefaultValue = false)]
        public List<ProductPropertyDefinition> Properties { get; set; }

        /// <summary>
        /// The groups containing properties that are assigned to the definition
        /// </summary>
        /// <value>The groups containing properties that are assigned to the definition</value>
        [DataMember(Name = "propertyGroups", EmitDefaultValue = false)]
        public List<ProductPropertyDefinitionGroup> PropertyGroups { get; set; }

        /// <summary>
        /// A number defining the order in which the definition appears in the list
        /// </summary>
        /// <value>A number defining the order in which the definition appears in the list</value>
        [DataMember(Name = "sequenceNumber", EmitDefaultValue = false)]
        public int SequenceNumber { get; set; }

        /// <summary>
        /// The list of attributes assigned to the definition allowing Variant of a product. An empty collection means that variants are not allowedOnly available for a Product definition, not a Category
        /// </summary>
        /// <value>The list of attributes assigned to the definition allowing Variant of a product. An empty collection means that variants are not allowedOnly available for a Product definition, not a Category</value>
        [DataMember(Name = "variantProperties", EmitDefaultValue = false)]
        public List<ProductPropertyDefinition> VariantProperties { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ProductDefinition {\n");
            sb.Append("  AllowPriceLists: ").Append(AllowPriceLists).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  ProductType: ").Append(ProductType).Append("\n");
            sb.Append("  Properties: ").Append(Properties).Append("\n");
            sb.Append("  PropertyGroups: ").Append(PropertyGroups).Append("\n");
            sb.Append("  SequenceNumber: ").Append(SequenceNumber).Append("\n");
            sb.Append("  VariantProperties: ").Append(VariantProperties).Append("\n");
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
            return this.Equals(input as ProductDefinition);
        }

        /// <summary>
        /// Returns true if ProductDefinition instances are equal
        /// </summary>
        /// <param name="input">Instance of ProductDefinition to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ProductDefinition input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AllowPriceLists == input.AllowPriceLists ||
                    this.AllowPriceLists.Equals(input.AllowPriceLists)
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.DisplayName == input.DisplayName ||
                    this.DisplayName != null &&
                    input.DisplayName != null &&
                    this.DisplayName.SequenceEqual(input.DisplayName)
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.ProductType == input.ProductType ||
                    this.ProductType.Equals(input.ProductType)
                ) && 
                (
                    this.Properties == input.Properties ||
                    this.Properties != null &&
                    input.Properties != null &&
                    this.Properties.SequenceEqual(input.Properties)
                ) && 
                (
                    this.PropertyGroups == input.PropertyGroups ||
                    this.PropertyGroups != null &&
                    input.PropertyGroups != null &&
                    this.PropertyGroups.SequenceEqual(input.PropertyGroups)
                ) && 
                (
                    this.SequenceNumber == input.SequenceNumber ||
                    this.SequenceNumber.Equals(input.SequenceNumber)
                ) && 
                (
                    this.VariantProperties == input.VariantProperties ||
                    this.VariantProperties != null &&
                    input.VariantProperties != null &&
                    this.VariantProperties.SequenceEqual(input.VariantProperties)
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
                hashCode = hashCode * 59 + this.AllowPriceLists.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.DisplayName != null)
                    hashCode = hashCode * 59 + this.DisplayName.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                hashCode = hashCode * 59 + this.ProductType.GetHashCode();
                if (this.Properties != null)
                    hashCode = hashCode * 59 + this.Properties.GetHashCode();
                if (this.PropertyGroups != null)
                    hashCode = hashCode * 59 + this.PropertyGroups.GetHashCode();
                hashCode = hashCode * 59 + this.SequenceNumber.GetHashCode();
                if (this.VariantProperties != null)
                    hashCode = hashCode * 59 + this.VariantProperties.GetHashCode();
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
