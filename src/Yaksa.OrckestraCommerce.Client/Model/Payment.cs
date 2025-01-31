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
    /// Payment
    /// </summary>
    [DataContract(Name = "Payment")]
    public partial class Payment : IEquatable<Payment>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Payment" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Payment() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Payment" /> class.
        /// </summary>
        /// <param name="id">The unique identifier of the entity. (required).</param>
        /// <param name="propertyBag">propertyBag.</param>
        /// <param name="amount">The amount of this payment..</param>
        /// <param name="billingAddress">billingAddress.</param>
        /// <param name="billingAddressId">The unique identifier of the billing address to use for this payment..</param>
        /// <param name="created">The creation date..</param>
        /// <param name="createdBy">The identity of the user who created the payment..</param>
        /// <param name="lastModified">The last modification date..</param>
        /// <param name="lastModifiedBy">The identity of the user who modified the payment..</param>
        /// <param name="paymentCaptureAction">paymentCaptureAction.</param>
        /// <param name="paymentDate">the date when the payment was made..</param>
        /// <param name="paymentMethod">paymentMethod.</param>
        /// <param name="paymentStatus">The status of the payment. Typical values will include: Outstanding, Verified, Authorized, Paid.</param>
        public Payment(string id = default(string), Dictionary<string, Object> propertyBag = default(Dictionary<string, Object>), double amount = default(double), Address billingAddress = default(Address), string billingAddressId = default(string), DateTime created = default(DateTime), string createdBy = default(string), DateTime lastModified = default(DateTime), string lastModifiedBy = default(string), PaymentCaptureAction paymentCaptureAction = default(PaymentCaptureAction), DateTime paymentDate = default(DateTime), PaymentMethod paymentMethod = default(PaymentMethod), string paymentStatus = default(string))
        {
            // to ensure "id" is required (not null)
            this.Id = id ?? throw new ArgumentNullException("id is a required property for Payment and cannot be null");
            this.PropertyBag = propertyBag;
            this.Amount = amount;
            this.BillingAddress = billingAddress;
            this.BillingAddressId = billingAddressId;
            this.Created = created;
            this.CreatedBy = createdBy;
            this.LastModified = lastModified;
            this.LastModifiedBy = lastModifiedBy;
            this.PaymentCaptureAction = paymentCaptureAction;
            this.PaymentDate = paymentDate;
            this.PaymentMethod = paymentMethod;
            this.PaymentStatus = paymentStatus;
        }

        /// <summary>
        /// The unique identifier of the entity.
        /// </summary>
        /// <value>The unique identifier of the entity.</value>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets PropertyBag
        /// </summary>
        [DataMember(Name = "propertyBag", EmitDefaultValue = false)]
        public Dictionary<string, Object> PropertyBag { get; set; }

        /// <summary>
        /// The amount of this payment.
        /// </summary>
        /// <value>The amount of this payment.</value>
        [DataMember(Name = "amount", EmitDefaultValue = false)]
        public double Amount { get; set; }

        /// <summary>
        /// Gets or Sets BillingAddress
        /// </summary>
        [DataMember(Name = "billingAddress", EmitDefaultValue = false)]
        public Address BillingAddress { get; set; }

        /// <summary>
        /// The unique identifier of the billing address to use for this payment.
        /// </summary>
        /// <value>The unique identifier of the billing address to use for this payment.</value>
        [DataMember(Name = "billingAddressId", EmitDefaultValue = false)]
        public string BillingAddressId { get; set; }

        /// <summary>
        /// The creation date.
        /// </summary>
        /// <value>The creation date.</value>
        [DataMember(Name = "created", EmitDefaultValue = false)]
        public DateTime Created { get; set; }

        /// <summary>
        /// The identity of the user who created the payment.
        /// </summary>
        /// <value>The identity of the user who created the payment.</value>
        [DataMember(Name = "createdBy", EmitDefaultValue = false)]
        public string CreatedBy { get; set; }

        /// <summary>
        /// The last modification date.
        /// </summary>
        /// <value>The last modification date.</value>
        [DataMember(Name = "lastModified", EmitDefaultValue = false)]
        public DateTime LastModified { get; set; }

        /// <summary>
        /// The identity of the user who modified the payment.
        /// </summary>
        /// <value>The identity of the user who modified the payment.</value>
        [DataMember(Name = "lastModifiedBy", EmitDefaultValue = false)]
        public string LastModifiedBy { get; set; }

        /// <summary>
        /// Gets or Sets PaymentCaptureAction
        /// </summary>
        [DataMember(Name = "paymentCaptureAction", EmitDefaultValue = false)]
        public PaymentCaptureAction PaymentCaptureAction { get; set; }

        /// <summary>
        /// the date when the payment was made.
        /// </summary>
        /// <value>the date when the payment was made.</value>
        [DataMember(Name = "paymentDate", EmitDefaultValue = false)]
        public DateTime PaymentDate { get; set; }

        /// <summary>
        /// Gets or Sets PaymentMethod
        /// </summary>
        [DataMember(Name = "paymentMethod", EmitDefaultValue = false)]
        public PaymentMethod PaymentMethod { get; set; }

        /// <summary>
        /// The status of the payment. Typical values will include: Outstanding, Verified, Authorized, Paid
        /// </summary>
        /// <value>The status of the payment. Typical values will include: Outstanding, Verified, Authorized, Paid</value>
        [DataMember(Name = "paymentStatus", EmitDefaultValue = false)]
        public string PaymentStatus { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Payment {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  PropertyBag: ").Append(PropertyBag).Append("\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  BillingAddress: ").Append(BillingAddress).Append("\n");
            sb.Append("  BillingAddressId: ").Append(BillingAddressId).Append("\n");
            sb.Append("  Created: ").Append(Created).Append("\n");
            sb.Append("  CreatedBy: ").Append(CreatedBy).Append("\n");
            sb.Append("  LastModified: ").Append(LastModified).Append("\n");
            sb.Append("  LastModifiedBy: ").Append(LastModifiedBy).Append("\n");
            sb.Append("  PaymentCaptureAction: ").Append(PaymentCaptureAction).Append("\n");
            sb.Append("  PaymentDate: ").Append(PaymentDate).Append("\n");
            sb.Append("  PaymentMethod: ").Append(PaymentMethod).Append("\n");
            sb.Append("  PaymentStatus: ").Append(PaymentStatus).Append("\n");
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
            return this.Equals(input as Payment);
        }

        /// <summary>
        /// Returns true if Payment instances are equal
        /// </summary>
        /// <param name="input">Instance of Payment to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Payment input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.PropertyBag == input.PropertyBag ||
                    this.PropertyBag != null &&
                    input.PropertyBag != null &&
                    this.PropertyBag.SequenceEqual(input.PropertyBag)
                ) && 
                (
                    this.Amount == input.Amount ||
                    this.Amount.Equals(input.Amount)
                ) && 
                (
                    this.BillingAddress == input.BillingAddress ||
                    (this.BillingAddress != null &&
                    this.BillingAddress.Equals(input.BillingAddress))
                ) && 
                (
                    this.BillingAddressId == input.BillingAddressId ||
                    (this.BillingAddressId != null &&
                    this.BillingAddressId.Equals(input.BillingAddressId))
                ) && 
                (
                    this.Created == input.Created ||
                    (this.Created != null &&
                    this.Created.Equals(input.Created))
                ) && 
                (
                    this.CreatedBy == input.CreatedBy ||
                    (this.CreatedBy != null &&
                    this.CreatedBy.Equals(input.CreatedBy))
                ) && 
                (
                    this.LastModified == input.LastModified ||
                    (this.LastModified != null &&
                    this.LastModified.Equals(input.LastModified))
                ) && 
                (
                    this.LastModifiedBy == input.LastModifiedBy ||
                    (this.LastModifiedBy != null &&
                    this.LastModifiedBy.Equals(input.LastModifiedBy))
                ) && 
                (
                    this.PaymentCaptureAction == input.PaymentCaptureAction ||
                    (this.PaymentCaptureAction != null &&
                    this.PaymentCaptureAction.Equals(input.PaymentCaptureAction))
                ) && 
                (
                    this.PaymentDate == input.PaymentDate ||
                    (this.PaymentDate != null &&
                    this.PaymentDate.Equals(input.PaymentDate))
                ) && 
                (
                    this.PaymentMethod == input.PaymentMethod ||
                    (this.PaymentMethod != null &&
                    this.PaymentMethod.Equals(input.PaymentMethod))
                ) && 
                (
                    this.PaymentStatus == input.PaymentStatus ||
                    (this.PaymentStatus != null &&
                    this.PaymentStatus.Equals(input.PaymentStatus))
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.PropertyBag != null)
                    hashCode = hashCode * 59 + this.PropertyBag.GetHashCode();
                hashCode = hashCode * 59 + this.Amount.GetHashCode();
                if (this.BillingAddress != null)
                    hashCode = hashCode * 59 + this.BillingAddress.GetHashCode();
                if (this.BillingAddressId != null)
                    hashCode = hashCode * 59 + this.BillingAddressId.GetHashCode();
                if (this.Created != null)
                    hashCode = hashCode * 59 + this.Created.GetHashCode();
                if (this.CreatedBy != null)
                    hashCode = hashCode * 59 + this.CreatedBy.GetHashCode();
                if (this.LastModified != null)
                    hashCode = hashCode * 59 + this.LastModified.GetHashCode();
                if (this.LastModifiedBy != null)
                    hashCode = hashCode * 59 + this.LastModifiedBy.GetHashCode();
                if (this.PaymentCaptureAction != null)
                    hashCode = hashCode * 59 + this.PaymentCaptureAction.GetHashCode();
                if (this.PaymentDate != null)
                    hashCode = hashCode * 59 + this.PaymentDate.GetHashCode();
                if (this.PaymentMethod != null)
                    hashCode = hashCode * 59 + this.PaymentMethod.GetHashCode();
                if (this.PaymentStatus != null)
                    hashCode = hashCode * 59 + this.PaymentStatus.GetHashCode();
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
