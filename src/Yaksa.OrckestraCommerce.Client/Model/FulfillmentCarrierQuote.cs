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
    /// FulfillmentCarrierQuote
    /// </summary>
    [DataContract(Name = "FulfillmentCarrierQuote")]
    public partial class FulfillmentCarrierQuote : IEquatable<FulfillmentCarrierQuote>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FulfillmentCarrierQuote" /> class.
        /// </summary>
        /// <param name="quoteId">quoteId.</param>
        /// <param name="fulfillmentCarrierId">fulfillmentCarrierId.</param>
        /// <param name="cost">cost.</param>
        /// <param name="currency">currency.</param>
        /// <param name="fulfillmentCarrierName">fulfillmentCarrierName.</param>
        /// <param name="fulfillmentCarrierService">fulfillmentCarrierService.</param>
        /// <param name="fulfillmentCarrierServiceDescription">fulfillmentCarrierServiceDescription.</param>
        /// <param name="fulfillmentCarrierServiceOther">fulfillmentCarrierServiceOther.</param>
        /// <param name="fulfillmentCarrierServiceOtherDescription">fulfillmentCarrierServiceOtherDescription.</param>
        /// <param name="fulfillmentCarrierDeliveryDuration">fulfillmentCarrierDeliveryDuration.</param>
        /// <param name="fulfillmentCarrierDeliveryDurationDescription">fulfillmentCarrierDeliveryDurationDescription.</param>
        /// <param name="fulfillmentCarrierImages">fulfillmentCarrierImages.</param>
        /// <param name="expectedDeliveryDate">expectedDeliveryDate.</param>
        /// <param name="isReturn">isReturn.</param>
        public FulfillmentCarrierQuote(string quoteId = default(string), string fulfillmentCarrierId = default(string), double cost = default(double), string currency = default(string), string fulfillmentCarrierName = default(string), string fulfillmentCarrierService = default(string), string fulfillmentCarrierServiceDescription = default(string), string fulfillmentCarrierServiceOther = default(string), string fulfillmentCarrierServiceOtherDescription = default(string), int fulfillmentCarrierDeliveryDuration = default(int), string fulfillmentCarrierDeliveryDurationDescription = default(string), List<FulfillmentCarrierImage> fulfillmentCarrierImages = default(List<FulfillmentCarrierImage>), DateTime expectedDeliveryDate = default(DateTime), bool isReturn = default(bool))
        {
            this.QuoteId = quoteId;
            this.FulfillmentCarrierId = fulfillmentCarrierId;
            this.Cost = cost;
            this.Currency = currency;
            this.FulfillmentCarrierName = fulfillmentCarrierName;
            this.FulfillmentCarrierService = fulfillmentCarrierService;
            this.FulfillmentCarrierServiceDescription = fulfillmentCarrierServiceDescription;
            this.FulfillmentCarrierServiceOther = fulfillmentCarrierServiceOther;
            this.FulfillmentCarrierServiceOtherDescription = fulfillmentCarrierServiceOtherDescription;
            this.FulfillmentCarrierDeliveryDuration = fulfillmentCarrierDeliveryDuration;
            this.FulfillmentCarrierDeliveryDurationDescription = fulfillmentCarrierDeliveryDurationDescription;
            this.FulfillmentCarrierImages = fulfillmentCarrierImages;
            this.ExpectedDeliveryDate = expectedDeliveryDate;
            this.IsReturn = isReturn;
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
        /// Gets or Sets Cost
        /// </summary>
        [DataMember(Name = "cost", EmitDefaultValue = false)]
        public double Cost { get; set; }

        /// <summary>
        /// Gets or Sets Currency
        /// </summary>
        [DataMember(Name = "currency", EmitDefaultValue = false)]
        public string Currency { get; set; }

        /// <summary>
        /// Gets or Sets FulfillmentCarrierName
        /// </summary>
        [DataMember(Name = "fulfillmentCarrierName", EmitDefaultValue = false)]
        public string FulfillmentCarrierName { get; set; }

        /// <summary>
        /// Gets or Sets FulfillmentCarrierService
        /// </summary>
        [DataMember(Name = "fulfillmentCarrierService", EmitDefaultValue = false)]
        public string FulfillmentCarrierService { get; set; }

        /// <summary>
        /// Gets or Sets FulfillmentCarrierServiceDescription
        /// </summary>
        [DataMember(Name = "fulfillmentCarrierServiceDescription", EmitDefaultValue = false)]
        public string FulfillmentCarrierServiceDescription { get; set; }

        /// <summary>
        /// Gets or Sets FulfillmentCarrierServiceOther
        /// </summary>
        [DataMember(Name = "fulfillmentCarrierServiceOther", EmitDefaultValue = false)]
        public string FulfillmentCarrierServiceOther { get; set; }

        /// <summary>
        /// Gets or Sets FulfillmentCarrierServiceOtherDescription
        /// </summary>
        [DataMember(Name = "fulfillmentCarrierServiceOtherDescription", EmitDefaultValue = false)]
        public string FulfillmentCarrierServiceOtherDescription { get; set; }

        /// <summary>
        /// Gets or Sets FulfillmentCarrierDeliveryDuration
        /// </summary>
        [DataMember(Name = "fulfillmentCarrierDeliveryDuration", EmitDefaultValue = false)]
        public int FulfillmentCarrierDeliveryDuration { get; set; }

        /// <summary>
        /// Gets or Sets FulfillmentCarrierDeliveryDurationDescription
        /// </summary>
        [DataMember(Name = "fulfillmentCarrierDeliveryDurationDescription", EmitDefaultValue = false)]
        public string FulfillmentCarrierDeliveryDurationDescription { get; set; }

        /// <summary>
        /// Gets or Sets FulfillmentCarrierImages
        /// </summary>
        [DataMember(Name = "fulfillmentCarrierImages", EmitDefaultValue = false)]
        public List<FulfillmentCarrierImage> FulfillmentCarrierImages { get; set; }

        /// <summary>
        /// Gets or Sets ExpectedDeliveryDate
        /// </summary>
        [DataMember(Name = "expectedDeliveryDate", EmitDefaultValue = false)]
        public DateTime ExpectedDeliveryDate { get; set; }

        /// <summary>
        /// Gets or Sets IsReturn
        /// </summary>
        [DataMember(Name = "isReturn", EmitDefaultValue = true)]
        public bool IsReturn { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FulfillmentCarrierQuote {\n");
            sb.Append("  QuoteId: ").Append(QuoteId).Append("\n");
            sb.Append("  FulfillmentCarrierId: ").Append(FulfillmentCarrierId).Append("\n");
            sb.Append("  Cost: ").Append(Cost).Append("\n");
            sb.Append("  Currency: ").Append(Currency).Append("\n");
            sb.Append("  FulfillmentCarrierName: ").Append(FulfillmentCarrierName).Append("\n");
            sb.Append("  FulfillmentCarrierService: ").Append(FulfillmentCarrierService).Append("\n");
            sb.Append("  FulfillmentCarrierServiceDescription: ").Append(FulfillmentCarrierServiceDescription).Append("\n");
            sb.Append("  FulfillmentCarrierServiceOther: ").Append(FulfillmentCarrierServiceOther).Append("\n");
            sb.Append("  FulfillmentCarrierServiceOtherDescription: ").Append(FulfillmentCarrierServiceOtherDescription).Append("\n");
            sb.Append("  FulfillmentCarrierDeliveryDuration: ").Append(FulfillmentCarrierDeliveryDuration).Append("\n");
            sb.Append("  FulfillmentCarrierDeliveryDurationDescription: ").Append(FulfillmentCarrierDeliveryDurationDescription).Append("\n");
            sb.Append("  FulfillmentCarrierImages: ").Append(FulfillmentCarrierImages).Append("\n");
            sb.Append("  ExpectedDeliveryDate: ").Append(ExpectedDeliveryDate).Append("\n");
            sb.Append("  IsReturn: ").Append(IsReturn).Append("\n");
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
            return this.Equals(input as FulfillmentCarrierQuote);
        }

        /// <summary>
        /// Returns true if FulfillmentCarrierQuote instances are equal
        /// </summary>
        /// <param name="input">Instance of FulfillmentCarrierQuote to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FulfillmentCarrierQuote input)
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
                    this.Cost == input.Cost ||
                    this.Cost.Equals(input.Cost)
                ) && 
                (
                    this.Currency == input.Currency ||
                    (this.Currency != null &&
                    this.Currency.Equals(input.Currency))
                ) && 
                (
                    this.FulfillmentCarrierName == input.FulfillmentCarrierName ||
                    (this.FulfillmentCarrierName != null &&
                    this.FulfillmentCarrierName.Equals(input.FulfillmentCarrierName))
                ) && 
                (
                    this.FulfillmentCarrierService == input.FulfillmentCarrierService ||
                    (this.FulfillmentCarrierService != null &&
                    this.FulfillmentCarrierService.Equals(input.FulfillmentCarrierService))
                ) && 
                (
                    this.FulfillmentCarrierServiceDescription == input.FulfillmentCarrierServiceDescription ||
                    (this.FulfillmentCarrierServiceDescription != null &&
                    this.FulfillmentCarrierServiceDescription.Equals(input.FulfillmentCarrierServiceDescription))
                ) && 
                (
                    this.FulfillmentCarrierServiceOther == input.FulfillmentCarrierServiceOther ||
                    (this.FulfillmentCarrierServiceOther != null &&
                    this.FulfillmentCarrierServiceOther.Equals(input.FulfillmentCarrierServiceOther))
                ) && 
                (
                    this.FulfillmentCarrierServiceOtherDescription == input.FulfillmentCarrierServiceOtherDescription ||
                    (this.FulfillmentCarrierServiceOtherDescription != null &&
                    this.FulfillmentCarrierServiceOtherDescription.Equals(input.FulfillmentCarrierServiceOtherDescription))
                ) && 
                (
                    this.FulfillmentCarrierDeliveryDuration == input.FulfillmentCarrierDeliveryDuration ||
                    this.FulfillmentCarrierDeliveryDuration.Equals(input.FulfillmentCarrierDeliveryDuration)
                ) && 
                (
                    this.FulfillmentCarrierDeliveryDurationDescription == input.FulfillmentCarrierDeliveryDurationDescription ||
                    (this.FulfillmentCarrierDeliveryDurationDescription != null &&
                    this.FulfillmentCarrierDeliveryDurationDescription.Equals(input.FulfillmentCarrierDeliveryDurationDescription))
                ) && 
                (
                    this.FulfillmentCarrierImages == input.FulfillmentCarrierImages ||
                    this.FulfillmentCarrierImages != null &&
                    input.FulfillmentCarrierImages != null &&
                    this.FulfillmentCarrierImages.SequenceEqual(input.FulfillmentCarrierImages)
                ) && 
                (
                    this.ExpectedDeliveryDate == input.ExpectedDeliveryDate ||
                    (this.ExpectedDeliveryDate != null &&
                    this.ExpectedDeliveryDate.Equals(input.ExpectedDeliveryDate))
                ) && 
                (
                    this.IsReturn == input.IsReturn ||
                    this.IsReturn.Equals(input.IsReturn)
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
                hashCode = hashCode * 59 + this.Cost.GetHashCode();
                if (this.Currency != null)
                    hashCode = hashCode * 59 + this.Currency.GetHashCode();
                if (this.FulfillmentCarrierName != null)
                    hashCode = hashCode * 59 + this.FulfillmentCarrierName.GetHashCode();
                if (this.FulfillmentCarrierService != null)
                    hashCode = hashCode * 59 + this.FulfillmentCarrierService.GetHashCode();
                if (this.FulfillmentCarrierServiceDescription != null)
                    hashCode = hashCode * 59 + this.FulfillmentCarrierServiceDescription.GetHashCode();
                if (this.FulfillmentCarrierServiceOther != null)
                    hashCode = hashCode * 59 + this.FulfillmentCarrierServiceOther.GetHashCode();
                if (this.FulfillmentCarrierServiceOtherDescription != null)
                    hashCode = hashCode * 59 + this.FulfillmentCarrierServiceOtherDescription.GetHashCode();
                hashCode = hashCode * 59 + this.FulfillmentCarrierDeliveryDuration.GetHashCode();
                if (this.FulfillmentCarrierDeliveryDurationDescription != null)
                    hashCode = hashCode * 59 + this.FulfillmentCarrierDeliveryDurationDescription.GetHashCode();
                if (this.FulfillmentCarrierImages != null)
                    hashCode = hashCode * 59 + this.FulfillmentCarrierImages.GetHashCode();
                if (this.ExpectedDeliveryDate != null)
                    hashCode = hashCode * 59 + this.ExpectedDeliveryDate.GetHashCode();
                hashCode = hashCode * 59 + this.IsReturn.GetHashCode();
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
