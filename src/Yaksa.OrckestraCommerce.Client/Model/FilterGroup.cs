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
    /// FilterGroup
    /// </summary>
    [DataContract(Name = "FilterGroup")]
    public partial class FilterGroup : IEquatable<FilterGroup>, IValidatableObject
    {
        /// <summary>
        /// The binary operator joining the condition together
        /// </summary>
        /// <value>The binary operator joining the condition together</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum BinaryOperatorEnum
        {
            /// <summary>
            /// Enum And for value: And
            /// </summary>
            [EnumMember(Value = "And")]
            And = 1,

            /// <summary>
            /// Enum Or for value: Or
            /// </summary>
            [EnumMember(Value = "Or")]
            Or = 2

        }


        /// <summary>
        /// The binary operator joining the condition together
        /// </summary>
        /// <value>The binary operator joining the condition together</value>
        [DataMember(Name = "binaryOperator", EmitDefaultValue = false)]
        public BinaryOperatorEnum? BinaryOperator { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="FilterGroup" /> class.
        /// </summary>
        /// <param name="binaryOperator">The binary operator joining the condition together.</param>
        /// <param name="filterGroups">The nested filter groups.</param>
        /// <param name="filters">The nested filters.</param>
        /// <param name="not">If the operation is negate.</param>
        public FilterGroup(BinaryOperatorEnum? binaryOperator = default(BinaryOperatorEnum?), List<FilterGroup> filterGroups = default(List<FilterGroup>), List<Filter> filters = default(List<Filter>), bool not = default(bool))
        {
            this.BinaryOperator = binaryOperator;
            this.FilterGroups = filterGroups;
            this.Filters = filters;
            this.Not = not;
        }

        /// <summary>
        /// The nested filter groups
        /// </summary>
        /// <value>The nested filter groups</value>
        [DataMember(Name = "filterGroups", EmitDefaultValue = false)]
        public List<FilterGroup> FilterGroups { get; set; }

        /// <summary>
        /// The nested filters
        /// </summary>
        /// <value>The nested filters</value>
        [DataMember(Name = "filters", EmitDefaultValue = false)]
        public List<Filter> Filters { get; set; }

        /// <summary>
        /// If the operation is negate
        /// </summary>
        /// <value>If the operation is negate</value>
        [DataMember(Name = "not", EmitDefaultValue = true)]
        public bool Not { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FilterGroup {\n");
            sb.Append("  BinaryOperator: ").Append(BinaryOperator).Append("\n");
            sb.Append("  FilterGroups: ").Append(FilterGroups).Append("\n");
            sb.Append("  Filters: ").Append(Filters).Append("\n");
            sb.Append("  Not: ").Append(Not).Append("\n");
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
            return this.Equals(input as FilterGroup);
        }

        /// <summary>
        /// Returns true if FilterGroup instances are equal
        /// </summary>
        /// <param name="input">Instance of FilterGroup to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FilterGroup input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.BinaryOperator == input.BinaryOperator ||
                    this.BinaryOperator.Equals(input.BinaryOperator)
                ) && 
                (
                    this.FilterGroups == input.FilterGroups ||
                    this.FilterGroups != null &&
                    input.FilterGroups != null &&
                    this.FilterGroups.SequenceEqual(input.FilterGroups)
                ) && 
                (
                    this.Filters == input.Filters ||
                    this.Filters != null &&
                    input.Filters != null &&
                    this.Filters.SequenceEqual(input.Filters)
                ) && 
                (
                    this.Not == input.Not ||
                    this.Not.Equals(input.Not)
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
                hashCode = hashCode * 59 + this.BinaryOperator.GetHashCode();
                if (this.FilterGroups != null)
                    hashCode = hashCode * 59 + this.FilterGroups.GetHashCode();
                if (this.Filters != null)
                    hashCode = hashCode * 59 + this.Filters.GetHashCode();
                hashCode = hashCode * 59 + this.Not.GetHashCode();
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
