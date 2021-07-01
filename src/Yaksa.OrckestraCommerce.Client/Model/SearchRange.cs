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
    /// SearchRange
    /// </summary>
    [DataContract(Name = "SearchRange")]
    public partial class SearchRange : IEquatable<SearchRange>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SearchRange" /> class.
        /// </summary>
        /// <param name="displayName">the display name of the filter..</param>
        /// <param name="name">the name of the field to filter..</param>
        /// <param name="selectedMax">the maximum value to use to filter the data..</param>
        /// <param name="selectedMin">the minimum value to use to filter the data..</param>
        public SearchRange(string displayName = default(string), string name = default(string), double selectedMax = default(double), double selectedMin = default(double))
        {
            this.DisplayName = displayName;
            this.Name = name;
            this.SelectedMax = selectedMax;
            this.SelectedMin = selectedMin;
        }

        /// <summary>
        /// the display name of the filter.
        /// </summary>
        /// <value>the display name of the filter.</value>
        [DataMember(Name = "displayName", EmitDefaultValue = false)]
        public string DisplayName { get; set; }

        /// <summary>
        /// the name of the field to filter.
        /// </summary>
        /// <value>the name of the field to filter.</value>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// the maximum value to use to filter the data.
        /// </summary>
        /// <value>the maximum value to use to filter the data.</value>
        [DataMember(Name = "selectedMax", EmitDefaultValue = false)]
        public double SelectedMax { get; set; }

        /// <summary>
        /// the minimum value to use to filter the data.
        /// </summary>
        /// <value>the minimum value to use to filter the data.</value>
        [DataMember(Name = "selectedMin", EmitDefaultValue = false)]
        public double SelectedMin { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SearchRange {\n");
            sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  SelectedMax: ").Append(SelectedMax).Append("\n");
            sb.Append("  SelectedMin: ").Append(SelectedMin).Append("\n");
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
            return this.Equals(input as SearchRange);
        }

        /// <summary>
        /// Returns true if SearchRange instances are equal
        /// </summary>
        /// <param name="input">Instance of SearchRange to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SearchRange input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DisplayName == input.DisplayName ||
                    (this.DisplayName != null &&
                    this.DisplayName.Equals(input.DisplayName))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.SelectedMax == input.SelectedMax ||
                    this.SelectedMax.Equals(input.SelectedMax)
                ) && 
                (
                    this.SelectedMin == input.SelectedMin ||
                    this.SelectedMin.Equals(input.SelectedMin)
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
                if (this.DisplayName != null)
                    hashCode = hashCode * 59 + this.DisplayName.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                hashCode = hashCode * 59 + this.SelectedMax.GetHashCode();
                hashCode = hashCode * 59 + this.SelectedMin.GetHashCode();
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
