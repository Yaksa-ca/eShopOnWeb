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
    /// CreateFulfillmentCarrierManifestResponse
    /// </summary>
    [DataContract(Name = "CreateFulfillmentCarrierManifestResponse")]
    public partial class CreateFulfillmentCarrierManifestResponse : IEquatable<CreateFulfillmentCarrierManifestResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateFulfillmentCarrierManifestResponse" /> class.
        /// </summary>
        /// <param name="manifests">The created manifests..</param>
        public CreateFulfillmentCarrierManifestResponse(List<FulfillmentCarrierManifest> manifests = default(List<FulfillmentCarrierManifest>))
        {
            this.Manifests = manifests;
        }

        /// <summary>
        /// The created manifests.
        /// </summary>
        /// <value>The created manifests.</value>
        [DataMember(Name = "manifests", EmitDefaultValue = false)]
        public List<FulfillmentCarrierManifest> Manifests { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateFulfillmentCarrierManifestResponse {\n");
            sb.Append("  Manifests: ").Append(Manifests).Append("\n");
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
            return this.Equals(input as CreateFulfillmentCarrierManifestResponse);
        }

        /// <summary>
        /// Returns true if CreateFulfillmentCarrierManifestResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of CreateFulfillmentCarrierManifestResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateFulfillmentCarrierManifestResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Manifests == input.Manifests ||
                    this.Manifests != null &&
                    input.Manifests != null &&
                    this.Manifests.SequenceEqual(input.Manifests)
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
                if (this.Manifests != null)
                    hashCode = hashCode * 59 + this.Manifests.GetHashCode();
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
