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
    /// FulfillmentCarrierManifest
    /// </summary>
    [DataContract(Name = "FulfillmentCarrierManifest")]
    public partial class FulfillmentCarrierManifest : IEquatable<FulfillmentCarrierManifest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FulfillmentCarrierManifest" /> class.
        /// </summary>
        /// <param name="quoteId">quoteId.</param>
        /// <param name="fulfillmentCarrierId">fulfillmentCarrierId.</param>
        /// <param name="carrierAccountIdOutbound">carrierAccountIdOutbound.</param>
        /// <param name="carrierNameOutbound">carrierNameOutbound.</param>
        /// <param name="carrierServiceLevelOutbound">carrierServiceLevelOutbound.</param>
        /// <param name="cultureName">cultureName.</param>
        /// <param name="documents">documents.</param>
        /// <param name="issues">issues.</param>
        public FulfillmentCarrierManifest(string quoteId = default(string), string fulfillmentCarrierId = default(string), string carrierAccountIdOutbound = default(string), string carrierNameOutbound = default(string), string carrierServiceLevelOutbound = default(string), string cultureName = default(string), List<FulfillmentCarrierDocument> documents = default(List<FulfillmentCarrierDocument>), List<FulfillmentCarrierManifestIssue> issues = default(List<FulfillmentCarrierManifestIssue>))
        {
            this.QuoteId = quoteId;
            this.FulfillmentCarrierId = fulfillmentCarrierId;
            this.CarrierAccountIdOutbound = carrierAccountIdOutbound;
            this.CarrierNameOutbound = carrierNameOutbound;
            this.CarrierServiceLevelOutbound = carrierServiceLevelOutbound;
            this.CultureName = cultureName;
            this.Documents = documents;
            this.Issues = issues;
        }

        /// <summary>
        /// Gets or Sets QuoteId
        /// </summary>
        [DataMember(Name = "quoteId", EmitDefaultValue = false)]
        public string QuoteId { get; set; }

        /// <summary>
        /// Gets or Sets FulfillmentCarrierId
        /// </summary>
        [DataMember(Name = "fulfillmentCarrierId", EmitDefaultValue = false)]
        public string FulfillmentCarrierId { get; set; }

        /// <summary>
        /// Gets or Sets CarrierAccountIdOutbound
        /// </summary>
        [DataMember(Name = "carrierAccountIdOutbound", EmitDefaultValue = false)]
        public string CarrierAccountIdOutbound { get; set; }

        /// <summary>
        /// Gets or Sets CarrierNameOutbound
        /// </summary>
        [DataMember(Name = "carrierNameOutbound", EmitDefaultValue = false)]
        public string CarrierNameOutbound { get; set; }

        /// <summary>
        /// Gets or Sets CarrierServiceLevelOutbound
        /// </summary>
        [DataMember(Name = "carrierServiceLevelOutbound", EmitDefaultValue = false)]
        public string CarrierServiceLevelOutbound { get; set; }

        /// <summary>
        /// Gets or Sets CultureName
        /// </summary>
        [DataMember(Name = "cultureName", EmitDefaultValue = false)]
        public string CultureName { get; set; }

        /// <summary>
        /// Gets or Sets Documents
        /// </summary>
        [DataMember(Name = "documents", EmitDefaultValue = false)]
        public List<FulfillmentCarrierDocument> Documents { get; set; }

        /// <summary>
        /// Gets or Sets Issues
        /// </summary>
        [DataMember(Name = "issues", EmitDefaultValue = false)]
        public List<FulfillmentCarrierManifestIssue> Issues { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FulfillmentCarrierManifest {\n");
            sb.Append("  QuoteId: ").Append(QuoteId).Append("\n");
            sb.Append("  FulfillmentCarrierId: ").Append(FulfillmentCarrierId).Append("\n");
            sb.Append("  CarrierAccountIdOutbound: ").Append(CarrierAccountIdOutbound).Append("\n");
            sb.Append("  CarrierNameOutbound: ").Append(CarrierNameOutbound).Append("\n");
            sb.Append("  CarrierServiceLevelOutbound: ").Append(CarrierServiceLevelOutbound).Append("\n");
            sb.Append("  CultureName: ").Append(CultureName).Append("\n");
            sb.Append("  Documents: ").Append(Documents).Append("\n");
            sb.Append("  Issues: ").Append(Issues).Append("\n");
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
            return this.Equals(input as FulfillmentCarrierManifest);
        }

        /// <summary>
        /// Returns true if FulfillmentCarrierManifest instances are equal
        /// </summary>
        /// <param name="input">Instance of FulfillmentCarrierManifest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FulfillmentCarrierManifest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.QuoteId == input.QuoteId ||
                    (this.QuoteId != null &&
                    this.QuoteId.Equals(input.QuoteId))
                ) && 
                (
                    this.FulfillmentCarrierId == input.FulfillmentCarrierId ||
                    (this.FulfillmentCarrierId != null &&
                    this.FulfillmentCarrierId.Equals(input.FulfillmentCarrierId))
                ) && 
                (
                    this.CarrierAccountIdOutbound == input.CarrierAccountIdOutbound ||
                    (this.CarrierAccountIdOutbound != null &&
                    this.CarrierAccountIdOutbound.Equals(input.CarrierAccountIdOutbound))
                ) && 
                (
                    this.CarrierNameOutbound == input.CarrierNameOutbound ||
                    (this.CarrierNameOutbound != null &&
                    this.CarrierNameOutbound.Equals(input.CarrierNameOutbound))
                ) && 
                (
                    this.CarrierServiceLevelOutbound == input.CarrierServiceLevelOutbound ||
                    (this.CarrierServiceLevelOutbound != null &&
                    this.CarrierServiceLevelOutbound.Equals(input.CarrierServiceLevelOutbound))
                ) && 
                (
                    this.CultureName == input.CultureName ||
                    (this.CultureName != null &&
                    this.CultureName.Equals(input.CultureName))
                ) && 
                (
                    this.Documents == input.Documents ||
                    this.Documents != null &&
                    input.Documents != null &&
                    this.Documents.SequenceEqual(input.Documents)
                ) && 
                (
                    this.Issues == input.Issues ||
                    this.Issues != null &&
                    input.Issues != null &&
                    this.Issues.SequenceEqual(input.Issues)
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
                if (this.QuoteId != null)
                    hashCode = hashCode * 59 + this.QuoteId.GetHashCode();
                if (this.FulfillmentCarrierId != null)
                    hashCode = hashCode * 59 + this.FulfillmentCarrierId.GetHashCode();
                if (this.CarrierAccountIdOutbound != null)
                    hashCode = hashCode * 59 + this.CarrierAccountIdOutbound.GetHashCode();
                if (this.CarrierNameOutbound != null)
                    hashCode = hashCode * 59 + this.CarrierNameOutbound.GetHashCode();
                if (this.CarrierServiceLevelOutbound != null)
                    hashCode = hashCode * 59 + this.CarrierServiceLevelOutbound.GetHashCode();
                if (this.CultureName != null)
                    hashCode = hashCode * 59 + this.CultureName.GetHashCode();
                if (this.Documents != null)
                    hashCode = hashCode * 59 + this.Documents.GetHashCode();
                if (this.Issues != null)
                    hashCode = hashCode * 59 + this.Issues.GetHashCode();
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
