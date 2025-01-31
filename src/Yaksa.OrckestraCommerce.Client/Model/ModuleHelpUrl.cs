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
    /// ModuleHelpUrl
    /// </summary>
    [DataContract(Name = "ModuleHelpUrl")]
    public partial class ModuleHelpUrl : IEquatable<ModuleHelpUrl>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ModuleHelpUrl" /> class.
        /// </summary>
        /// <param name="moduleName">The Orckestra Commerce Cloud platform module name..</param>
        /// <param name="helpUrl">The Help Url for the module specified in the property ModuleName..</param>
        public ModuleHelpUrl(string moduleName = default(string), string helpUrl = default(string))
        {
            this.ModuleName = moduleName;
            this.HelpUrl = helpUrl;
        }

        /// <summary>
        /// The Orckestra Commerce Cloud platform module name.
        /// </summary>
        /// <value>The Orckestra Commerce Cloud platform module name.</value>
        [DataMember(Name = "moduleName", EmitDefaultValue = false)]
        public string ModuleName { get; set; }

        /// <summary>
        /// The Help Url for the module specified in the property ModuleName.
        /// </summary>
        /// <value>The Help Url for the module specified in the property ModuleName.</value>
        [DataMember(Name = "helpUrl", EmitDefaultValue = false)]
        public string HelpUrl { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ModuleHelpUrl {\n");
            sb.Append("  ModuleName: ").Append(ModuleName).Append("\n");
            sb.Append("  HelpUrl: ").Append(HelpUrl).Append("\n");
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
            return this.Equals(input as ModuleHelpUrl);
        }

        /// <summary>
        /// Returns true if ModuleHelpUrl instances are equal
        /// </summary>
        /// <param name="input">Instance of ModuleHelpUrl to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ModuleHelpUrl input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ModuleName == input.ModuleName ||
                    (this.ModuleName != null &&
                    this.ModuleName.Equals(input.ModuleName))
                ) && 
                (
                    this.HelpUrl == input.HelpUrl ||
                    (this.HelpUrl != null &&
                    this.HelpUrl.Equals(input.HelpUrl))
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
                if (this.ModuleName != null)
                    hashCode = hashCode * 59 + this.ModuleName.GetHashCode();
                if (this.HelpUrl != null)
                    hashCode = hashCode * 59 + this.HelpUrl.GetHashCode();
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
