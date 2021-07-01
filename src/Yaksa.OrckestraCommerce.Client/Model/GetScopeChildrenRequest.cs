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
    /// Scopes are entities that allow you to organize and search data and settings for a given market.
    /// </summary>
    [DataContract(Name = "GetScopeChildrenRequest")]
    public partial class GetScopeChildrenRequest : IEquatable<GetScopeChildrenRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetScopeChildrenRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GetScopeChildrenRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="GetScopeChildrenRequest" /> class.
        /// </summary>
        /// <param name="cultureName">The culture name in which language the data will be returned.</param>
        /// <param name="includeCurrency">Whether to include the associated currency.</param>
        /// <param name="scopeId">The id of the requested scope. (required).</param>
        public GetScopeChildrenRequest(string cultureName = default(string), bool includeCurrency = default(bool), string scopeId = default(string))
        {
            // to ensure "scopeId" is required (not null)
            this.ScopeId = scopeId ?? throw new ArgumentNullException("scopeId is a required property for GetScopeChildrenRequest and cannot be null");
            this.CultureName = cultureName;
            this.IncludeCurrency = includeCurrency;
        }

        /// <summary>
        /// The culture name in which language the data will be returned
        /// </summary>
        /// <value>The culture name in which language the data will be returned</value>
        [DataMember(Name = "cultureName", EmitDefaultValue = false)]
        public string CultureName { get; set; }

        /// <summary>
        /// Whether to include the associated currency
        /// </summary>
        /// <value>Whether to include the associated currency</value>
        [DataMember(Name = "includeCurrency", EmitDefaultValue = true)]
        public bool IncludeCurrency { get; set; }

        /// <summary>
        /// The id of the requested scope.
        /// </summary>
        /// <value>The id of the requested scope.</value>
        [DataMember(Name = "scopeId", IsRequired = true, EmitDefaultValue = false)]
        public string ScopeId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GetScopeChildrenRequest {\n");
            sb.Append("  CultureName: ").Append(CultureName).Append("\n");
            sb.Append("  IncludeCurrency: ").Append(IncludeCurrency).Append("\n");
            sb.Append("  ScopeId: ").Append(ScopeId).Append("\n");
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
            return this.Equals(input as GetScopeChildrenRequest);
        }

        /// <summary>
        /// Returns true if GetScopeChildrenRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of GetScopeChildrenRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetScopeChildrenRequest input)
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
                    this.IncludeCurrency == input.IncludeCurrency ||
                    this.IncludeCurrency.Equals(input.IncludeCurrency)
                ) && 
                (
                    this.ScopeId == input.ScopeId ||
                    (this.ScopeId != null &&
                    this.ScopeId.Equals(input.ScopeId))
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
                hashCode = hashCode * 59 + this.IncludeCurrency.GetHashCode();
                if (this.ScopeId != null)
                    hashCode = hashCode * 59 + this.ScopeId.GetHashCode();
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
