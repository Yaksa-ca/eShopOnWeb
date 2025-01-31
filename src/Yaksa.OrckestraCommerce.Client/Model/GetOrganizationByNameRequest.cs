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
    /// Operations related to organizations such as create an organization, get an organization, updating an organization, ...
    /// </summary>
    [DataContract(Name = "GetOrganizationByNameRequest")]
    public partial class GetOrganizationByNameRequest : IEquatable<GetOrganizationByNameRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetOrganizationByNameRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GetOrganizationByNameRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="GetOrganizationByNameRequest" /> class.
        /// </summary>
        /// <param name="scopeId">The id of the requested scope.</param>
        /// <param name="includeAddresses">Specifies whether or not to fully load the addresses..</param>
        /// <param name="name">The name of the organization to retrieve. (required).</param>
        public GetOrganizationByNameRequest(string scopeId = default(string), bool includeAddresses = default(bool), string name = default(string))
        {
            // to ensure "name" is required (not null)
            this.Name = name ?? throw new ArgumentNullException("name is a required property for GetOrganizationByNameRequest and cannot be null");
            this.ScopeId = scopeId;
            this.IncludeAddresses = includeAddresses;
        }

        /// <summary>
        /// The id of the requested scope
        /// </summary>
        /// <value>The id of the requested scope</value>
        [DataMember(Name = "scopeId", EmitDefaultValue = false)]
        public string ScopeId { get; set; }

        /// <summary>
        /// Specifies whether or not to fully load the addresses.
        /// </summary>
        /// <value>Specifies whether or not to fully load the addresses.</value>
        [DataMember(Name = "includeAddresses", EmitDefaultValue = true)]
        public bool IncludeAddresses { get; set; }

        /// <summary>
        /// The name of the organization to retrieve.
        /// </summary>
        /// <value>The name of the organization to retrieve.</value>
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GetOrganizationByNameRequest {\n");
            sb.Append("  ScopeId: ").Append(ScopeId).Append("\n");
            sb.Append("  IncludeAddresses: ").Append(IncludeAddresses).Append("\n");
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
            return this.Equals(input as GetOrganizationByNameRequest);
        }

        /// <summary>
        /// Returns true if GetOrganizationByNameRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of GetOrganizationByNameRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetOrganizationByNameRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ScopeId == input.ScopeId ||
                    (this.ScopeId != null &&
                    this.ScopeId.Equals(input.ScopeId))
                ) && 
                (
                    this.IncludeAddresses == input.IncludeAddresses ||
                    this.IncludeAddresses.Equals(input.IncludeAddresses)
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
                if (this.ScopeId != null)
                    hashCode = hashCode * 59 + this.ScopeId.GetHashCode();
                hashCode = hashCode * 59 + this.IncludeAddresses.GetHashCode();
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
