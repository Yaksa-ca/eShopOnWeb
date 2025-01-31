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
    /// Campaigns are entities used to organize marketing promotions.
    /// </summary>
    [DataContract(Name = "GetPromotionRequest")]
    public partial class GetPromotionRequest : IEquatable<GetPromotionRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetPromotionRequest" /> class.
        /// </summary>
        /// <param name="scopeId">The id of the requested scope.</param>
        /// <param name="campaignId">The id of the promotion&#39;s campaign.</param>
        /// <param name="promotionId">The id of the promotion to retrieve..</param>
        /// <param name="validateTargeting">Indicates whether the targeting conditions in the promotion should be validated.</param>
        public GetPromotionRequest(string scopeId = default(string), string campaignId = default(string), string promotionId = default(string), bool validateTargeting = default(bool))
        {
            this.ScopeId = scopeId;
            this.CampaignId = campaignId;
            this.PromotionId = promotionId;
            this.ValidateTargeting = validateTargeting;
        }

        /// <summary>
        /// The id of the requested scope
        /// </summary>
        /// <value>The id of the requested scope</value>
        [DataMember(Name = "scopeId", EmitDefaultValue = false)]
        public string ScopeId { get; set; }

        /// <summary>
        /// The id of the promotion&#39;s campaign
        /// </summary>
        /// <value>The id of the promotion&#39;s campaign</value>
        [DataMember(Name = "campaignId", EmitDefaultValue = false)]
        public string CampaignId { get; set; }

        /// <summary>
        /// The id of the promotion to retrieve.
        /// </summary>
        /// <value>The id of the promotion to retrieve.</value>
        [DataMember(Name = "promotionId", EmitDefaultValue = false)]
        public string PromotionId { get; set; }

        /// <summary>
        /// Indicates whether the targeting conditions in the promotion should be validated
        /// </summary>
        /// <value>Indicates whether the targeting conditions in the promotion should be validated</value>
        [DataMember(Name = "validateTargeting", EmitDefaultValue = true)]
        public bool ValidateTargeting { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GetPromotionRequest {\n");
            sb.Append("  ScopeId: ").Append(ScopeId).Append("\n");
            sb.Append("  CampaignId: ").Append(CampaignId).Append("\n");
            sb.Append("  PromotionId: ").Append(PromotionId).Append("\n");
            sb.Append("  ValidateTargeting: ").Append(ValidateTargeting).Append("\n");
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
            return this.Equals(input as GetPromotionRequest);
        }

        /// <summary>
        /// Returns true if GetPromotionRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of GetPromotionRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetPromotionRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ScopeId == input.ScopeId ||
                    (this.ScopeId != null &&
                    this.ScopeId.Equals(input.ScopeId))
                ) && 
                (
                    this.CampaignId == input.CampaignId ||
                    (this.CampaignId != null &&
                    this.CampaignId.Equals(input.CampaignId))
                ) && 
                (
                    this.PromotionId == input.PromotionId ||
                    (this.PromotionId != null &&
                    this.PromotionId.Equals(input.PromotionId))
                ) && 
                (
                    this.ValidateTargeting == input.ValidateTargeting ||
                    this.ValidateTargeting.Equals(input.ValidateTargeting)
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
                if (this.ScopeId != null)
                    hashCode = hashCode * 59 + this.ScopeId.GetHashCode();
                if (this.CampaignId != null)
                    hashCode = hashCode * 59 + this.CampaignId.GetHashCode();
                if (this.PromotionId != null)
                    hashCode = hashCode * 59 + this.PromotionId.GetHashCode();
                hashCode = hashCode * 59 + this.ValidateTargeting.GetHashCode();
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
