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
    [DataContract(Name = "GetOrderDefinitionRequest")]
    public partial class GetOrderDefinitionRequest : IEquatable<GetOrderDefinitionRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetOrderDefinitionRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GetOrderDefinitionRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="GetOrderDefinitionRequest" /> class.
        /// </summary>
        /// <param name="cultureName">The culture name in which language the data will be returned.</param>
        /// <param name="name">The id to retrieve related entity definition (required).</param>
        public GetOrderDefinitionRequest(string cultureName = default(string), string name = default(string))
        {
            // to ensure "name" is required (not null)
            this.Name = name ?? throw new ArgumentNullException("name is a required property for GetOrderDefinitionRequest and cannot be null");
            this.CultureName = cultureName;
        }

        /// <summary>
        /// The culture name in which language the data will be returned
        /// </summary>
        /// <value>The culture name in which language the data will be returned</value>
        [DataMember(Name = "cultureName", EmitDefaultValue = false)]
        public string CultureName { get; set; }

        /// <summary>
        /// The id to retrieve related entity definition
        /// </summary>
        /// <value>The id to retrieve related entity definition</value>
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GetOrderDefinitionRequest {\n");
            sb.Append("  CultureName: ").Append(CultureName).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
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
            return this.Equals(input as GetOrderDefinitionRequest);
        }

        /// <summary>
        /// Returns true if GetOrderDefinitionRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of GetOrderDefinitionRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetOrderDefinitionRequest input)
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
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
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
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
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
