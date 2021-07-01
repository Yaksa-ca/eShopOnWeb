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
    /// GetMonerisCaptureSettingsResponse
    /// </summary>
    [DataContract(Name = "GetMonerisCaptureSettingsResponse")]
    public partial class GetMonerisCaptureSettingsResponse : IEquatable<GetMonerisCaptureSettingsResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetMonerisCaptureSettingsResponse" /> class.
        /// </summary>
        /// <param name="paymentCaptureUrl">Gets of sets the Moneris payment capture URL.</param>
        /// <param name="tokenizationBaseUrl">Gets of sets the Moneris tokenization base URL.</param>
        /// <param name="tokenizationProfileId">Gets of sets the Moneris tokenization profile Id.</param>
        /// <param name="tokenizationStyleParameters">Gets of sets the Moneris tokenization style parameters.</param>
        public GetMonerisCaptureSettingsResponse(string paymentCaptureUrl = default(string), string tokenizationBaseUrl = default(string), string tokenizationProfileId = default(string), string tokenizationStyleParameters = default(string))
        {
            this.PaymentCaptureUrl = paymentCaptureUrl;
            this.TokenizationBaseUrl = tokenizationBaseUrl;
            this.TokenizationProfileId = tokenizationProfileId;
            this.TokenizationStyleParameters = tokenizationStyleParameters;
        }

        /// <summary>
        /// Gets of sets the Moneris payment capture URL
        /// </summary>
        /// <value>Gets of sets the Moneris payment capture URL</value>
        [DataMember(Name = "paymentCaptureUrl", EmitDefaultValue = false)]
        public string PaymentCaptureUrl { get; set; }

        /// <summary>
        /// Gets of sets the Moneris tokenization base URL
        /// </summary>
        /// <value>Gets of sets the Moneris tokenization base URL</value>
        [DataMember(Name = "tokenizationBaseUrl", EmitDefaultValue = false)]
        public string TokenizationBaseUrl { get; set; }

        /// <summary>
        /// Gets of sets the Moneris tokenization profile Id
        /// </summary>
        /// <value>Gets of sets the Moneris tokenization profile Id</value>
        [DataMember(Name = "tokenizationProfileId", EmitDefaultValue = false)]
        public string TokenizationProfileId { get; set; }

        /// <summary>
        /// Gets of sets the Moneris tokenization style parameters
        /// </summary>
        /// <value>Gets of sets the Moneris tokenization style parameters</value>
        [DataMember(Name = "tokenizationStyleParameters", EmitDefaultValue = false)]
        public string TokenizationStyleParameters { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GetMonerisCaptureSettingsResponse {\n");
            sb.Append("  PaymentCaptureUrl: ").Append(PaymentCaptureUrl).Append("\n");
            sb.Append("  TokenizationBaseUrl: ").Append(TokenizationBaseUrl).Append("\n");
            sb.Append("  TokenizationProfileId: ").Append(TokenizationProfileId).Append("\n");
            sb.Append("  TokenizationStyleParameters: ").Append(TokenizationStyleParameters).Append("\n");
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
            return this.Equals(input as GetMonerisCaptureSettingsResponse);
        }

        /// <summary>
        /// Returns true if GetMonerisCaptureSettingsResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of GetMonerisCaptureSettingsResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetMonerisCaptureSettingsResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.PaymentCaptureUrl == input.PaymentCaptureUrl ||
                    (this.PaymentCaptureUrl != null &&
                    this.PaymentCaptureUrl.Equals(input.PaymentCaptureUrl))
                ) && 
                (
                    this.TokenizationBaseUrl == input.TokenizationBaseUrl ||
                    (this.TokenizationBaseUrl != null &&
                    this.TokenizationBaseUrl.Equals(input.TokenizationBaseUrl))
                ) && 
                (
                    this.TokenizationProfileId == input.TokenizationProfileId ||
                    (this.TokenizationProfileId != null &&
                    this.TokenizationProfileId.Equals(input.TokenizationProfileId))
                ) && 
                (
                    this.TokenizationStyleParameters == input.TokenizationStyleParameters ||
                    (this.TokenizationStyleParameters != null &&
                    this.TokenizationStyleParameters.Equals(input.TokenizationStyleParameters))
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
                if (this.PaymentCaptureUrl != null)
                    hashCode = hashCode * 59 + this.PaymentCaptureUrl.GetHashCode();
                if (this.TokenizationBaseUrl != null)
                    hashCode = hashCode * 59 + this.TokenizationBaseUrl.GetHashCode();
                if (this.TokenizationProfileId != null)
                    hashCode = hashCode * 59 + this.TokenizationProfileId.GetHashCode();
                if (this.TokenizationStyleParameters != null)
                    hashCode = hashCode * 59 + this.TokenizationStyleParameters.GetHashCode();
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
