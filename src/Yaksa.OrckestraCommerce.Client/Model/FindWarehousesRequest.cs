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
    /// Warehouses are entities which represents physical warehouses.
    /// </summary>
    [DataContract(Name = "FindWarehousesRequest")]
    public partial class FindWarehousesRequest : IEquatable<FindWarehousesRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FindWarehousesRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected FindWarehousesRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="FindWarehousesRequest" /> class.
        /// </summary>
        /// <param name="configurationName">The name of the configuration to use to process this request.</param>
        /// <param name="cultureName">The culture (language) to use to process the request (en-US) (required).</param>
        /// <param name="query">query.</param>
        /// <param name="includeChildScopes">Includes the warehouses of the child score..</param>
        /// <param name="searchTerms">The word or phrase the warehouse name or number is beginning with.</param>
        public FindWarehousesRequest(string configurationName = default(string), string cultureName = default(string), Query query = default(Query), bool includeChildScopes = default(bool), string searchTerms = default(string))
        {
            // to ensure "cultureName" is required (not null)
            this.CultureName = cultureName ?? throw new ArgumentNullException("cultureName is a required property for FindWarehousesRequest and cannot be null");
            this.ConfigurationName = configurationName;
            this.Query = query;
            this.IncludeChildScopes = includeChildScopes;
            this.SearchTerms = searchTerms;
        }

        /// <summary>
        /// The name of the configuration to use to process this request
        /// </summary>
        /// <value>The name of the configuration to use to process this request</value>
        [DataMember(Name = "configurationName", EmitDefaultValue = false)]
        public string ConfigurationName { get; set; }

        /// <summary>
        /// The culture (language) to use to process the request (en-US)
        /// </summary>
        /// <value>The culture (language) to use to process the request (en-US)</value>
        [DataMember(Name = "cultureName", IsRequired = true, EmitDefaultValue = false)]
        public string CultureName { get; set; }

        /// <summary>
        /// Gets or Sets Query
        /// </summary>
        [DataMember(Name = "query", EmitDefaultValue = false)]
        public Query Query { get; set; }

        /// <summary>
        /// Includes the warehouses of the child score.
        /// </summary>
        /// <value>Includes the warehouses of the child score.</value>
        [DataMember(Name = "includeChildScopes", EmitDefaultValue = true)]
        public bool IncludeChildScopes { get; set; }

        /// <summary>
        /// The word or phrase the warehouse name or number is beginning with
        /// </summary>
        /// <value>The word or phrase the warehouse name or number is beginning with</value>
        [DataMember(Name = "searchTerms", EmitDefaultValue = false)]
        public string SearchTerms { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FindWarehousesRequest {\n");
            sb.Append("  ConfigurationName: ").Append(ConfigurationName).Append("\n");
            sb.Append("  CultureName: ").Append(CultureName).Append("\n");
            sb.Append("  Query: ").Append(Query).Append("\n");
            sb.Append("  IncludeChildScopes: ").Append(IncludeChildScopes).Append("\n");
            sb.Append("  SearchTerms: ").Append(SearchTerms).Append("\n");
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
            return this.Equals(input as FindWarehousesRequest);
        }

        /// <summary>
        /// Returns true if FindWarehousesRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of FindWarehousesRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FindWarehousesRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ConfigurationName == input.ConfigurationName ||
                    (this.ConfigurationName != null &&
                    this.ConfigurationName.Equals(input.ConfigurationName))
                ) && 
                (
                    this.CultureName == input.CultureName ||
                    (this.CultureName != null &&
                    this.CultureName.Equals(input.CultureName))
                ) && 
                (
                    this.Query == input.Query ||
                    (this.Query != null &&
                    this.Query.Equals(input.Query))
                ) && 
                (
                    this.IncludeChildScopes == input.IncludeChildScopes ||
                    this.IncludeChildScopes.Equals(input.IncludeChildScopes)
                ) && 
                (
                    this.SearchTerms == input.SearchTerms ||
                    (this.SearchTerms != null &&
                    this.SearchTerms.Equals(input.SearchTerms))
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
                if (this.ConfigurationName != null)
                    hashCode = hashCode * 59 + this.ConfigurationName.GetHashCode();
                if (this.CultureName != null)
                    hashCode = hashCode * 59 + this.CultureName.GetHashCode();
                if (this.Query != null)
                    hashCode = hashCode * 59 + this.Query.GetHashCode();
                hashCode = hashCode * 59 + this.IncludeChildScopes.GetHashCode();
                if (this.SearchTerms != null)
                    hashCode = hashCode * 59 + this.SearchTerms.GetHashCode();
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
