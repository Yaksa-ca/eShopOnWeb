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
    /// GetFulfillmentCarrierDocumentsResponse
    /// </summary>
    [DataContract(Name = "GetFulfillmentCarrierDocumentsResponse")]
    public partial class GetFulfillmentCarrierDocumentsResponse : IEquatable<GetFulfillmentCarrierDocumentsResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetFulfillmentCarrierDocumentsResponse" /> class.
        /// </summary>
        /// <param name="documents">The documents..</param>
        public GetFulfillmentCarrierDocumentsResponse(List<FulfillmentCarrierDocument> documents = default(List<FulfillmentCarrierDocument>))
        {
            this.Documents = documents;
        }

        /// <summary>
        /// The documents.
        /// </summary>
        /// <value>The documents.</value>
        [DataMember(Name = "documents", EmitDefaultValue = false)]
        public List<FulfillmentCarrierDocument> Documents { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GetFulfillmentCarrierDocumentsResponse {\n");
            sb.Append("  Documents: ").Append(Documents).Append("\n");
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
            return this.Equals(input as GetFulfillmentCarrierDocumentsResponse);
        }

        /// <summary>
        /// Returns true if GetFulfillmentCarrierDocumentsResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of GetFulfillmentCarrierDocumentsResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetFulfillmentCarrierDocumentsResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Documents == input.Documents ||
                    this.Documents != null &&
                    input.Documents != null &&
                    this.Documents.SequenceEqual(input.Documents)
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
                if (this.Documents != null)
                    hashCode = hashCode * 59 + this.Documents.GetHashCode();
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
