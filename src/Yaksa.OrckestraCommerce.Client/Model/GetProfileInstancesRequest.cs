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
    /// Custom Profiles are entities which represents a custom classification of entity defined in the system.
    /// </summary>
    [DataContract(Name = "GetProfileInstancesRequest")]
    public partial class GetProfileInstancesRequest : IEquatable<GetProfileInstancesRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetProfileInstancesRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GetProfileInstancesRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="GetProfileInstancesRequest" /> class.
        /// </summary>
        /// <param name="ids">Unique identifiers for the entities. (required).</param>
        public GetProfileInstancesRequest(List<string> ids = default(List<string>))
        {
            // to ensure "ids" is required (not null)
            this.Ids = ids ?? throw new ArgumentNullException("ids is a required property for GetProfileInstancesRequest and cannot be null");
        }

        /// <summary>
        /// Unique identifiers for the entities.
        /// </summary>
        /// <value>Unique identifiers for the entities.</value>
        [DataMember(Name = "ids", IsRequired = true, EmitDefaultValue = false)]
        public List<string> Ids { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GetProfileInstancesRequest {\n");
            sb.Append("  Ids: ").Append(Ids).Append("\n");
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
            return this.Equals(input as GetProfileInstancesRequest);
        }

        /// <summary>
        /// Returns true if GetProfileInstancesRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of GetProfileInstancesRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetProfileInstancesRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Ids == input.Ids ||
                    this.Ids != null &&
                    input.Ids != null &&
                    this.Ids.SequenceEqual(input.Ids)
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
                if (this.Ids != null)
                    hashCode = hashCode * 59 + this.Ids.GetHashCode();
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
