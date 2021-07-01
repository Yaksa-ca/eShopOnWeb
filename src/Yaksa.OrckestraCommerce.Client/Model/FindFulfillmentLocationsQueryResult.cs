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
    /// FindFulfillmentLocationsQueryResult
    /// </summary>
    [DataContract(Name = "FindFulfillmentLocationsQueryResult")]
    public partial class FindFulfillmentLocationsQueryResult : IEquatable<FindFulfillmentLocationsQueryResult>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FindFulfillmentLocationsQueryResult" /> class.
        /// </summary>
        /// <param name="results">The current results. If the service request uses paging, this will be one page of items..</param>
        /// <param name="totalCount">The total number of records available. If the service request is using paging, this should be used to calculate the number of pages of data..</param>
        public FindFulfillmentLocationsQueryResult(List<FulfillmentLocation> results = default(List<FulfillmentLocation>), int totalCount = default(int))
        {
            this.Results = results;
            this.TotalCount = totalCount;
        }

        /// <summary>
        /// The current results. If the service request uses paging, this will be one page of items.
        /// </summary>
        /// <value>The current results. If the service request uses paging, this will be one page of items.</value>
        [DataMember(Name = "results", EmitDefaultValue = false)]
        public List<FulfillmentLocation> Results { get; set; }

        /// <summary>
        /// The total number of records available. If the service request is using paging, this should be used to calculate the number of pages of data.
        /// </summary>
        /// <value>The total number of records available. If the service request is using paging, this should be used to calculate the number of pages of data.</value>
        [DataMember(Name = "totalCount", EmitDefaultValue = false)]
        public int TotalCount { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FindFulfillmentLocationsQueryResult {\n");
            sb.Append("  Results: ").Append(Results).Append("\n");
            sb.Append("  TotalCount: ").Append(TotalCount).Append("\n");
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
            return this.Equals(input as FindFulfillmentLocationsQueryResult);
        }

        /// <summary>
        /// Returns true if FindFulfillmentLocationsQueryResult instances are equal
        /// </summary>
        /// <param name="input">Instance of FindFulfillmentLocationsQueryResult to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FindFulfillmentLocationsQueryResult input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Results == input.Results ||
                    this.Results != null &&
                    input.Results != null &&
                    this.Results.SequenceEqual(input.Results)
                ) && 
                (
                    this.TotalCount == input.TotalCount ||
                    this.TotalCount.Equals(input.TotalCount)
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
                if (this.Results != null)
                    hashCode = hashCode * 59 + this.Results.GetHashCode();
                hashCode = hashCode * 59 + this.TotalCount.GetHashCode();
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
