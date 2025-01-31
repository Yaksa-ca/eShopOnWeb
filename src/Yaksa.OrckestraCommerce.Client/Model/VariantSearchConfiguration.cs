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
    /// VariantSearchConfiguration
    /// </summary>
    [DataContract(Name = "VariantSearchConfiguration")]
    public partial class VariantSearchConfiguration : IEquatable<VariantSearchConfiguration>, IValidatableObject
    {
        /// <summary>
        /// the search option for the specified product definition.
        /// </summary>
        /// <value>the search option for the specified product definition.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum SearchOptionEnum
        {
            /// <summary>
            /// Enum SingleRecordPerProduct for value: SingleRecordPerProduct
            /// </summary>
            [EnumMember(Value = "SingleRecordPerProduct")]
            SingleRecordPerProduct = 1,

            /// <summary>
            /// Enum GroupByKvaValue for value: GroupByKvaValue
            /// </summary>
            [EnumMember(Value = "GroupByKvaValue")]
            GroupByKvaValue = 2,

            /// <summary>
            /// Enum SingleRecordPerVariant for value: SingleRecordPerVariant
            /// </summary>
            [EnumMember(Value = "SingleRecordPerVariant")]
            SingleRecordPerVariant = 3,

            /// <summary>
            /// Enum GroupByCustomAttribute for value: GroupByCustomAttribute
            /// </summary>
            [EnumMember(Value = "GroupByCustomAttribute")]
            GroupByCustomAttribute = 4

        }


        /// <summary>
        /// the search option for the specified product definition.
        /// </summary>
        /// <value>the search option for the specified product definition.</value>
        [DataMember(Name = "searchOption", EmitDefaultValue = false)]
        public SearchOptionEnum? SearchOption { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="VariantSearchConfiguration" /> class.
        /// </summary>
        /// <param name="groupingVariantAttributeId">the grouping attribute to be used with the specified search option..</param>
        /// <param name="productDefinitionName">the product definition name to apply this configuration..</param>
        /// <param name="scopeId">the scope for this configuration..</param>
        /// <param name="searchOption">the search option for the specified product definition..</param>
        public VariantSearchConfiguration(string groupingVariantAttributeId = default(string), string productDefinitionName = default(string), string scopeId = default(string), SearchOptionEnum? searchOption = default(SearchOptionEnum?))
        {
            this.GroupingVariantAttributeId = groupingVariantAttributeId;
            this.ProductDefinitionName = productDefinitionName;
            this.ScopeId = scopeId;
            this.SearchOption = searchOption;
        }

        /// <summary>
        /// the grouping attribute to be used with the specified search option.
        /// </summary>
        /// <value>the grouping attribute to be used with the specified search option.</value>
        [DataMember(Name = "groupingVariantAttributeId", EmitDefaultValue = false)]
        public string GroupingVariantAttributeId { get; set; }

        /// <summary>
        /// the product definition name to apply this configuration.
        /// </summary>
        /// <value>the product definition name to apply this configuration.</value>
        [DataMember(Name = "productDefinitionName", EmitDefaultValue = false)]
        public string ProductDefinitionName { get; set; }

        /// <summary>
        /// the scope for this configuration.
        /// </summary>
        /// <value>the scope for this configuration.</value>
        [DataMember(Name = "scopeId", EmitDefaultValue = false)]
        public string ScopeId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class VariantSearchConfiguration {\n");
            sb.Append("  GroupingVariantAttributeId: ").Append(GroupingVariantAttributeId).Append("\n");
            sb.Append("  ProductDefinitionName: ").Append(ProductDefinitionName).Append("\n");
            sb.Append("  ScopeId: ").Append(ScopeId).Append("\n");
            sb.Append("  SearchOption: ").Append(SearchOption).Append("\n");
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
            return this.Equals(input as VariantSearchConfiguration);
        }

        /// <summary>
        /// Returns true if VariantSearchConfiguration instances are equal
        /// </summary>
        /// <param name="input">Instance of VariantSearchConfiguration to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(VariantSearchConfiguration input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.GroupingVariantAttributeId == input.GroupingVariantAttributeId ||
                    (this.GroupingVariantAttributeId != null &&
                    this.GroupingVariantAttributeId.Equals(input.GroupingVariantAttributeId))
                ) && 
                (
                    this.ProductDefinitionName == input.ProductDefinitionName ||
                    (this.ProductDefinitionName != null &&
                    this.ProductDefinitionName.Equals(input.ProductDefinitionName))
                ) && 
                (
                    this.ScopeId == input.ScopeId ||
                    (this.ScopeId != null &&
                    this.ScopeId.Equals(input.ScopeId))
                ) && 
                (
                    this.SearchOption == input.SearchOption ||
                    this.SearchOption.Equals(input.SearchOption)
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
                if (this.GroupingVariantAttributeId != null)
                    hashCode = hashCode * 59 + this.GroupingVariantAttributeId.GetHashCode();
                if (this.ProductDefinitionName != null)
                    hashCode = hashCode * 59 + this.ProductDefinitionName.GetHashCode();
                if (this.ScopeId != null)
                    hashCode = hashCode * 59 + this.ScopeId.GetHashCode();
                hashCode = hashCode * 59 + this.SearchOption.GetHashCode();
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
