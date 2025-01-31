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
    /// Customers represents entities which have the ability to buy products.
    /// </summary>
    [DataContract(Name = "DeleteCustomerPaymentMethodRequest")]
    public partial class DeleteCustomerPaymentMethodRequest : IEquatable<DeleteCustomerPaymentMethodRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteCustomerPaymentMethodRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected DeleteCustomerPaymentMethodRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteCustomerPaymentMethodRequest" /> class.
        /// </summary>
        /// <param name="scopeId">The id of the requested scope.</param>
        /// <param name="customerId">the unique identifier of the Customer owning the cart. (required).</param>
        /// <param name="paymentMethodId">the unique identifier of the payment method to be removed (required).</param>
        /// <param name="paymentProviderName">the name of the payment provider to use. If null, all methods will be returned (required).</param>
        public DeleteCustomerPaymentMethodRequest(string scopeId = default(string), string customerId = default(string), string paymentMethodId = default(string), string paymentProviderName = default(string))
        {
            // to ensure "customerId" is required (not null)
            this.CustomerId = customerId ?? throw new ArgumentNullException("customerId is a required property for DeleteCustomerPaymentMethodRequest and cannot be null");
            // to ensure "paymentMethodId" is required (not null)
            this.PaymentMethodId = paymentMethodId ?? throw new ArgumentNullException("paymentMethodId is a required property for DeleteCustomerPaymentMethodRequest and cannot be null");
            // to ensure "paymentProviderName" is required (not null)
            this.PaymentProviderName = paymentProviderName ?? throw new ArgumentNullException("paymentProviderName is a required property for DeleteCustomerPaymentMethodRequest and cannot be null");
            this.ScopeId = scopeId;
        }

        /// <summary>
        /// The id of the requested scope
        /// </summary>
        /// <value>The id of the requested scope</value>
        [DataMember(Name = "scopeId", EmitDefaultValue = false)]
        public string ScopeId { get; set; }

        /// <summary>
        /// the unique identifier of the Customer owning the cart.
        /// </summary>
        /// <value>the unique identifier of the Customer owning the cart.</value>
        [DataMember(Name = "customerId", IsRequired = true, EmitDefaultValue = false)]
        public string CustomerId { get; set; }

        /// <summary>
        /// the unique identifier of the payment method to be removed
        /// </summary>
        /// <value>the unique identifier of the payment method to be removed</value>
        [DataMember(Name = "paymentMethodId", IsRequired = true, EmitDefaultValue = false)]
        public string PaymentMethodId { get; set; }

        /// <summary>
        /// the name of the payment provider to use. If null, all methods will be returned
        /// </summary>
        /// <value>the name of the payment provider to use. If null, all methods will be returned</value>
        [DataMember(Name = "paymentProviderName", IsRequired = true, EmitDefaultValue = false)]
        public string PaymentProviderName { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DeleteCustomerPaymentMethodRequest {\n");
            sb.Append("  ScopeId: ").Append(ScopeId).Append("\n");
            sb.Append("  CustomerId: ").Append(CustomerId).Append("\n");
            sb.Append("  PaymentMethodId: ").Append(PaymentMethodId).Append("\n");
            sb.Append("  PaymentProviderName: ").Append(PaymentProviderName).Append("\n");
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
            return this.Equals(input as DeleteCustomerPaymentMethodRequest);
        }

        /// <summary>
        /// Returns true if DeleteCustomerPaymentMethodRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of DeleteCustomerPaymentMethodRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DeleteCustomerPaymentMethodRequest input)
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
                    this.CustomerId == input.CustomerId ||
                    (this.CustomerId != null &&
                    this.CustomerId.Equals(input.CustomerId))
                ) && 
                (
                    this.PaymentMethodId == input.PaymentMethodId ||
                    (this.PaymentMethodId != null &&
                    this.PaymentMethodId.Equals(input.PaymentMethodId))
                ) && 
                (
                    this.PaymentProviderName == input.PaymentProviderName ||
                    (this.PaymentProviderName != null &&
                    this.PaymentProviderName.Equals(input.PaymentProviderName))
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
                if (this.CustomerId != null)
                    hashCode = hashCode * 59 + this.CustomerId.GetHashCode();
                if (this.PaymentMethodId != null)
                    hashCode = hashCode * 59 + this.PaymentMethodId.GetHashCode();
                if (this.PaymentProviderName != null)
                    hashCode = hashCode * 59 + this.PaymentProviderName.GetHashCode();
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
