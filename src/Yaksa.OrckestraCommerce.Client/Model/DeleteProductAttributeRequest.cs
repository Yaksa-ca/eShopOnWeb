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
    /// Metadata are entities which represents additional definitions and attribute information.
    /// </summary>
    [DataContract(Name = "DeleteProductAttributeRequest")]
    public partial class DeleteProductAttributeRequest : IEquatable<DeleteProductAttributeRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteProductAttributeRequest" /> class.
        /// </summary>
        /// <param name="attributeName">The name of the attribute.</param>
        public DeleteProductAttributeRequest(string attributeName = default(string))
        {
            this.AttributeName = attributeName;
        }

        /// <summary>
        /// The name of the attribute
        /// </summary>
        /// <value>The name of the attribute</value>
        [DataMember(Name = "attributeName", EmitDefaultValue = false)]
        public string AttributeName { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DeleteProductAttributeRequest {\n");
            sb.Append("  AttributeName: ").Append(AttributeName).Append("\n");
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
            return this.Equals(input as DeleteProductAttributeRequest);
        }

        /// <summary>
        /// Returns true if DeleteProductAttributeRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of DeleteProductAttributeRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DeleteProductAttributeRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AttributeName == input.AttributeName ||
                    (this.AttributeName != null &&
                    this.AttributeName.Equals(input.AttributeName))
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
                if (this.AttributeName != null)
                    hashCode = hashCode * 59 + this.AttributeName.GetHashCode();
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
