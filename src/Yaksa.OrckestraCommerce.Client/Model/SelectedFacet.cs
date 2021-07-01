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
    /// SelectedFacet
    /// </summary>
    [DataContract(Name = "SelectedFacet")]
    public partial class SelectedFacet : IEquatable<SelectedFacet>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SelectedFacet" /> class.
        /// </summary>
        /// <param name="facetName">Name of the facet.</param>
        /// <param name="values">Selected values for the facet.</param>
        public SelectedFacet(string facetName = default(string), List<string> values = default(List<string>))
        {
            this.FacetName = facetName;
            this.Values = values;
        }

        /// <summary>
        /// Name of the facet
        /// </summary>
        /// <value>Name of the facet</value>
        [DataMember(Name = "facetName", EmitDefaultValue = false)]
        public string FacetName { get; set; }

        /// <summary>
        /// Selected values for the facet
        /// </summary>
        /// <value>Selected values for the facet</value>
        [DataMember(Name = "values", EmitDefaultValue = false)]
        public List<string> Values { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SelectedFacet {\n");
            sb.Append("  FacetName: ").Append(FacetName).Append("\n");
            sb.Append("  Values: ").Append(Values).Append("\n");
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
            return this.Equals(input as SelectedFacet);
        }

        /// <summary>
        /// Returns true if SelectedFacet instances are equal
        /// </summary>
        /// <param name="input">Instance of SelectedFacet to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SelectedFacet input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.FacetName == input.FacetName ||
                    (this.FacetName != null &&
                    this.FacetName.Equals(input.FacetName))
                ) && 
                (
                    this.Values == input.Values ||
                    this.Values != null &&
                    input.Values != null &&
                    this.Values.SequenceEqual(input.Values)
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
                if (this.FacetName != null)
                    hashCode = hashCode * 59 + this.FacetName.GetHashCode();
                if (this.Values != null)
                    hashCode = hashCode * 59 + this.Values.GetHashCode();
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
