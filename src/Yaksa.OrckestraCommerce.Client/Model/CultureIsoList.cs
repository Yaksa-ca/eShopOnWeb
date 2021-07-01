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
    /// CultureIsoList
    /// </summary>
    [DataContract(Name = "CultureIsoList")]
    public partial class CultureIsoList : IEquatable<CultureIsoList>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CultureIsoList" /> class.
        /// </summary>
        /// <param name="cultureIsoCodes">The list of culture ISO codes.</param>
        public CultureIsoList(List<string> cultureIsoCodes = default(List<string>))
        {
            this.CultureIsoCodes = cultureIsoCodes;
        }

        /// <summary>
        /// The list of culture ISO codes
        /// </summary>
        /// <value>The list of culture ISO codes</value>
        [DataMember(Name = "cultureIsoCodes", EmitDefaultValue = false)]
        public List<string> CultureIsoCodes { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CultureIsoList {\n");
            sb.Append("  CultureIsoCodes: ").Append(CultureIsoCodes).Append("\n");
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
            return this.Equals(input as CultureIsoList);
        }

        /// <summary>
        /// Returns true if CultureIsoList instances are equal
        /// </summary>
        /// <param name="input">Instance of CultureIsoList to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CultureIsoList input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CultureIsoCodes == input.CultureIsoCodes ||
                    this.CultureIsoCodes != null &&
                    input.CultureIsoCodes != null &&
                    this.CultureIsoCodes.SequenceEqual(input.CultureIsoCodes)
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
                if (this.CultureIsoCodes != null)
                    hashCode = hashCode * 59 + this.CultureIsoCodes.GetHashCode();
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
