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
    /// AuthenticationConfiguration
    /// </summary>
    [DataContract(Name = "AuthenticationConfiguration")]
    public partial class AuthenticationConfiguration : IEquatable<AuthenticationConfiguration>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AuthenticationConfiguration" /> class.
        /// </summary>
        /// <param name="federationConfiguration">federationConfiguration.</param>
        public AuthenticationConfiguration(FederationConfiguration federationConfiguration = default(FederationConfiguration))
        {
            this.FederationConfiguration = federationConfiguration;
        }

        /// <summary>
        /// Gets or Sets FederationConfiguration
        /// </summary>
        [DataMember(Name = "federationConfiguration", EmitDefaultValue = false)]
        public FederationConfiguration FederationConfiguration { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AuthenticationConfiguration {\n");
            sb.Append("  FederationConfiguration: ").Append(FederationConfiguration).Append("\n");
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
            return this.Equals(input as AuthenticationConfiguration);
        }

        /// <summary>
        /// Returns true if AuthenticationConfiguration instances are equal
        /// </summary>
        /// <param name="input">Instance of AuthenticationConfiguration to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AuthenticationConfiguration input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.FederationConfiguration == input.FederationConfiguration ||
                    (this.FederationConfiguration != null &&
                    this.FederationConfiguration.Equals(input.FederationConfiguration))
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
                if (this.FederationConfiguration != null)
                    hashCode = hashCode * 59 + this.FederationConfiguration.GetHashCode();
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
