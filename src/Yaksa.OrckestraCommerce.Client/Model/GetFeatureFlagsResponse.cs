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
    /// GetFeatureFlagsResponse
    /// </summary>
    [DataContract(Name = "GetFeatureFlagsResponse")]
    public partial class GetFeatureFlagsResponse : IEquatable<GetFeatureFlagsResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetFeatureFlagsResponse" /> class.
        /// </summary>
        /// <param name="featureFlags">The list of feature flags defined in a given scope or inherited.</param>
        public GetFeatureFlagsResponse(List<FeatureFlag> featureFlags = default(List<FeatureFlag>))
        {
            this.FeatureFlags = featureFlags;
        }

        /// <summary>
        /// The list of feature flags defined in a given scope or inherited
        /// </summary>
        /// <value>The list of feature flags defined in a given scope or inherited</value>
        [DataMember(Name = "featureFlags", EmitDefaultValue = false)]
        public List<FeatureFlag> FeatureFlags { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GetFeatureFlagsResponse {\n");
            sb.Append("  FeatureFlags: ").Append(FeatureFlags).Append("\n");
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
            return this.Equals(input as GetFeatureFlagsResponse);
        }

        /// <summary>
        /// Returns true if GetFeatureFlagsResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of GetFeatureFlagsResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetFeatureFlagsResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.FeatureFlags == input.FeatureFlags ||
                    this.FeatureFlags != null &&
                    input.FeatureFlags != null &&
                    this.FeatureFlags.SequenceEqual(input.FeatureFlags)
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
                if (this.FeatureFlags != null)
                    hashCode = hashCode * 59 + this.FeatureFlags.GetHashCode();
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
