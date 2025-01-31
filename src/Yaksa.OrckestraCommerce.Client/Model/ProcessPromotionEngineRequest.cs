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
    /// A promotion defines a set of rewards that can be applied to a Cart if a set of conditions are true.
    /// </summary>
    [DataContract(Name = "ProcessPromotionEngineRequest")]
    public partial class ProcessPromotionEngineRequest : IEquatable<ProcessPromotionEngineRequest>, IValidatableObject
    {
        /// <summary>
        /// The process mode of the PromotionEngine
        /// </summary>
        /// <value>The process mode of the PromotionEngine</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ProcessPromotionEngineModeEnum
        {
            /// <summary>
            /// Enum Live for value: Live
            /// </summary>
            [EnumMember(Value = "Live")]
            Live = 1,

            /// <summary>
            /// Enum OnlySavedPromotionsInCart for value: OnlySavedPromotionsInCart
            /// </summary>
            [EnumMember(Value = "OnlySavedPromotionsInCart")]
            OnlySavedPromotionsInCart = 2

        }


        /// <summary>
        /// The process mode of the PromotionEngine
        /// </summary>
        /// <value>The process mode of the PromotionEngine</value>
        [DataMember(Name = "processPromotionEngineMode", EmitDefaultValue = false)]
        public ProcessPromotionEngineModeEnum? ProcessPromotionEngineMode { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ProcessPromotionEngineRequest" /> class.
        /// </summary>
        /// <param name="cart">cart.</param>
        /// <param name="customer">customer.</param>
        /// <param name="orderOrCartDateTime">The Order Creation date if exists or the cart modification date.</param>
        /// <param name="processPromotionEngineMode">The process mode of the PromotionEngine.</param>
        public ProcessPromotionEngineRequest(Cart cart = default(Cart), Customer customer = default(Customer), DateTime orderOrCartDateTime = default(DateTime), ProcessPromotionEngineModeEnum? processPromotionEngineMode = default(ProcessPromotionEngineModeEnum?))
        {
            this.Cart = cart;
            this.Customer = customer;
            this.OrderOrCartDateTime = orderOrCartDateTime;
            this.ProcessPromotionEngineMode = processPromotionEngineMode;
        }

        /// <summary>
        /// Gets or Sets Cart
        /// </summary>
        [DataMember(Name = "cart", EmitDefaultValue = false)]
        public Cart Cart { get; set; }

        /// <summary>
        /// Gets or Sets Customer
        /// </summary>
        [DataMember(Name = "customer", EmitDefaultValue = false)]
        public Customer Customer { get; set; }

        /// <summary>
        /// The Order Creation date if exists or the cart modification date
        /// </summary>
        /// <value>The Order Creation date if exists or the cart modification date</value>
        [DataMember(Name = "orderOrCartDateTime", EmitDefaultValue = false)]
        public DateTime OrderOrCartDateTime { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ProcessPromotionEngineRequest {\n");
            sb.Append("  Cart: ").Append(Cart).Append("\n");
            sb.Append("  Customer: ").Append(Customer).Append("\n");
            sb.Append("  OrderOrCartDateTime: ").Append(OrderOrCartDateTime).Append("\n");
            sb.Append("  ProcessPromotionEngineMode: ").Append(ProcessPromotionEngineMode).Append("\n");
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
            return this.Equals(input as ProcessPromotionEngineRequest);
        }

        /// <summary>
        /// Returns true if ProcessPromotionEngineRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of ProcessPromotionEngineRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ProcessPromotionEngineRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Cart == input.Cart ||
                    (this.Cart != null &&
                    this.Cart.Equals(input.Cart))
                ) && 
                (
                    this.Customer == input.Customer ||
                    (this.Customer != null &&
                    this.Customer.Equals(input.Customer))
                ) && 
                (
                    this.OrderOrCartDateTime == input.OrderOrCartDateTime ||
                    (this.OrderOrCartDateTime != null &&
                    this.OrderOrCartDateTime.Equals(input.OrderOrCartDateTime))
                ) && 
                (
                    this.ProcessPromotionEngineMode == input.ProcessPromotionEngineMode ||
                    this.ProcessPromotionEngineMode.Equals(input.ProcessPromotionEngineMode)
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
                if (this.Cart != null)
                    hashCode = hashCode * 59 + this.Cart.GetHashCode();
                if (this.Customer != null)
                    hashCode = hashCode * 59 + this.Customer.GetHashCode();
                if (this.OrderOrCartDateTime != null)
                    hashCode = hashCode * 59 + this.OrderOrCartDateTime.GetHashCode();
                hashCode = hashCode * 59 + this.ProcessPromotionEngineMode.GetHashCode();
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
