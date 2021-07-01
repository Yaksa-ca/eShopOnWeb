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
    /// ValueTypeWrapper
    /// </summary>
    [DataContract(Name = "ValueTypeWrapper")]
    public partial class ValueTypeWrapper : IEquatable<ValueTypeWrapper>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ValueTypeWrapper" /> class.
        /// </summary>
        /// <param name="type">Data type of the value based on the name of the C# type. For example: ValueOfBoolean, ValueOfInt32, ValueOfDateTime, ValueOfString, ValueOfSingle, ValueOfDouble, ValueOfDecimal.</param>
        /// <param name="value">Value of the property as a string. The value should use the invariant format for all types except dates which should use ISO8601..</param>
        public ValueTypeWrapper(string type = default(string), string value = default(string))
        {
            this.Type = type;
            this.Value = value;
        }

        /// <summary>
        /// Data type of the value based on the name of the C# type. For example: ValueOfBoolean, ValueOfInt32, ValueOfDateTime, ValueOfString, ValueOfSingle, ValueOfDouble, ValueOfDecimal
        /// </summary>
        /// <value>Data type of the value based on the name of the C# type. For example: ValueOfBoolean, ValueOfInt32, ValueOfDateTime, ValueOfString, ValueOfSingle, ValueOfDouble, ValueOfDecimal</value>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        public string Type { get; set; }

        /// <summary>
        /// Value of the property as a string. The value should use the invariant format for all types except dates which should use ISO8601.
        /// </summary>
        /// <value>Value of the property as a string. The value should use the invariant format for all types except dates which should use ISO8601.</value>
        [DataMember(Name = "value", EmitDefaultValue = false)]
        public string Value { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ValueTypeWrapper {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
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
            return this.Equals(input as ValueTypeWrapper);
        }

        /// <summary>
        /// Returns true if ValueTypeWrapper instances are equal
        /// </summary>
        /// <param name="input">Instance of ValueTypeWrapper to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ValueTypeWrapper input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.Value == input.Value ||
                    (this.Value != null &&
                    this.Value.Equals(input.Value))
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
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Value != null)
                    hashCode = hashCode * 59 + this.Value.GetHashCode();
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
