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
    /// The coupon can be applied on a cart or an order. When a promotion is associated with one or more coupon codes, one of the coupons must appear in the customer&#39;s Cart to get the promotional discount.
    /// </summary>
    [DataContract(Name = "ConsumeCouponRequest")]
    public partial class ConsumeCouponRequest : IEquatable<ConsumeCouponRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ConsumeCouponRequest" /> class.
        /// </summary>
        /// <param name="coupon">coupon.</param>
        /// <param name="customerId">The identifier of the customer that is consuming the coupon.</param>
        public ConsumeCouponRequest(Coupon coupon = default(Coupon), string customerId = default(string))
        {
            this.Coupon = coupon;
            this.CustomerId = customerId;
        }

        /// <summary>
        /// Gets or Sets Coupon
        /// </summary>
        [DataMember(Name = "coupon", EmitDefaultValue = false)]
        public Coupon Coupon { get; set; }

        /// <summary>
        /// The identifier of the customer that is consuming the coupon
        /// </summary>
        /// <value>The identifier of the customer that is consuming the coupon</value>
        [DataMember(Name = "customerId", EmitDefaultValue = false)]
        public string CustomerId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ConsumeCouponRequest {\n");
            sb.Append("  Coupon: ").Append(Coupon).Append("\n");
            sb.Append("  CustomerId: ").Append(CustomerId).Append("\n");
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
            return this.Equals(input as ConsumeCouponRequest);
        }

        /// <summary>
        /// Returns true if ConsumeCouponRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of ConsumeCouponRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ConsumeCouponRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Coupon == input.Coupon ||
                    (this.Coupon != null &&
                    this.Coupon.Equals(input.Coupon))
                ) && 
                (
                    this.CustomerId == input.CustomerId ||
                    (this.CustomerId != null &&
                    this.CustomerId.Equals(input.CustomerId))
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
                if (this.Coupon != null)
                    hashCode = hashCode * 59 + this.Coupon.GetHashCode();
                if (this.CustomerId != null)
                    hashCode = hashCode * 59 + this.CustomerId.GetHashCode();
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
