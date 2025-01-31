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
    /// Globalization are entities related to regional settings. Such as countries, regions, timezones and cultures.
    /// </summary>
    [DataContract(Name = "SetDefaultCultureRequest")]
    public partial class SetDefaultCultureRequest : IEquatable<SetDefaultCultureRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SetDefaultCultureRequest" /> class.
        /// </summary>
        /// <param name="cultureIso">The ISO code of the default culture.</param>
        public SetDefaultCultureRequest(string cultureIso = default(string))
        {
            this.CultureIso = cultureIso;
        }

        /// <summary>
        /// The ISO code of the default culture
        /// </summary>
        /// <value>The ISO code of the default culture</value>
        [DataMember(Name = "cultureIso", EmitDefaultValue = false)]
        public string CultureIso { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SetDefaultCultureRequest {\n");
            sb.Append("  CultureIso: ").Append(CultureIso).Append("\n");
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
            return this.Equals(input as SetDefaultCultureRequest);
        }

        /// <summary>
        /// Returns true if SetDefaultCultureRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of SetDefaultCultureRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SetDefaultCultureRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CultureIso == input.CultureIso ||
                    (this.CultureIso != null &&
                    this.CultureIso.Equals(input.CultureIso))
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
                if (this.CultureIso != null)
                    hashCode = hashCode * 59 + this.CultureIso.GetHashCode();
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
