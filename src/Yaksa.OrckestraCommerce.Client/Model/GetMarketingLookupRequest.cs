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
    [DataContract(Name = "GetMarketingLookupRequest")]
    public partial class GetMarketingLookupRequest : IEquatable<GetMarketingLookupRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetMarketingLookupRequest" /> class.
        /// </summary>
        /// <param name="lookupName">The id to retrieve related lookup.</param>
        public GetMarketingLookupRequest(string lookupName = default(string))
        {
            this.LookupName = lookupName;
        }

        /// <summary>
        /// The id to retrieve related lookup
        /// </summary>
        /// <value>The id to retrieve related lookup</value>
        [DataMember(Name = "lookupName", EmitDefaultValue = false)]
        public string LookupName { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GetMarketingLookupRequest {\n");
            sb.Append("  LookupName: ").Append(LookupName).Append("\n");
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
            return this.Equals(input as GetMarketingLookupRequest);
        }

        /// <summary>
        /// Returns true if GetMarketingLookupRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of GetMarketingLookupRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetMarketingLookupRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.LookupName == input.LookupName ||
                    (this.LookupName != null &&
                    this.LookupName.Equals(input.LookupName))
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
                if (this.LookupName != null)
                    hashCode = hashCode * 59 + this.LookupName.GetHashCode();
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
