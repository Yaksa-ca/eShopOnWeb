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
    /// PurchaseConditionTarget
    /// </summary>
    [DataContract(Name = "PurchaseConditionTarget")]
    public partial class PurchaseConditionTarget : IEquatable<PurchaseConditionTarget>, IValidatableObject
    {
        /// <summary>
        /// the type of the target PurchaseConditionTargetType.
        /// </summary>
        /// <value>the type of the target PurchaseConditionTargetType.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TargetTypeEnum
        {
            /// <summary>
            /// Enum Product for value: Product
            /// </summary>
            [EnumMember(Value = "Product")]
            Product = 1,

            /// <summary>
            /// Enum Category for value: Category
            /// </summary>
            [EnumMember(Value = "Category")]
            Category = 2,

            /// <summary>
            /// Enum Variant for value: Variant
            /// </summary>
            [EnumMember(Value = "Variant")]
            Variant = 3,

            /// <summary>
            /// Enum FulfillmentMethod for value: FulfillmentMethod
            /// </summary>
            [EnumMember(Value = "FulfillmentMethod")]
            FulfillmentMethod = 4,

            /// <summary>
            /// Enum PaymentMethod for value: PaymentMethod
            /// </summary>
            [EnumMember(Value = "PaymentMethod")]
            PaymentMethod = 5

        }


        /// <summary>
        /// the type of the target PurchaseConditionTargetType.
        /// </summary>
        /// <value>the type of the target PurchaseConditionTargetType.</value>
        [DataMember(Name = "targetType", EmitDefaultValue = false)]
        public TargetTypeEnum? TargetType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="PurchaseConditionTarget" /> class.
        /// </summary>
        /// <param name="catalogId"> the catalog name of the entity necessary to get the promotion..</param>
        /// <param name="categoryId">the identifier of the category necessary to get the promotion..</param>
        /// <param name="displayName">the display name..</param>
        /// <param name="fulfillmentMethodName">the shipping method necessary to get the promotion..</param>
        /// <param name="paymentMethodType">the payment method necessary to get the promotion..</param>
        /// <param name="paymentProviderName">the payment method necessary to get the promotion..</param>
        /// <param name="productId">the unique identifier of the product necessary to get the promotion..</param>
        /// <param name="shippingProviderId">the shipping provider necessary to get the promotion..</param>
        /// <param name="targetType">the type of the target PurchaseConditionTargetType..</param>
        /// <param name="variantId"> the unique identifier of the variant necessary to get the promotion..</param>
        public PurchaseConditionTarget(string catalogId = default(string), string categoryId = default(string), string displayName = default(string), string fulfillmentMethodName = default(string), string paymentMethodType = default(string), string paymentProviderName = default(string), string productId = default(string), string shippingProviderId = default(string), TargetTypeEnum? targetType = default(TargetTypeEnum?), string variantId = default(string))
        {
            this.CatalogId = catalogId;
            this.CategoryId = categoryId;
            this.DisplayName = displayName;
            this.FulfillmentMethodName = fulfillmentMethodName;
            this.PaymentMethodType = paymentMethodType;
            this.PaymentProviderName = paymentProviderName;
            this.ProductId = productId;
            this.ShippingProviderId = shippingProviderId;
            this.TargetType = targetType;
            this.VariantId = variantId;
        }

        /// <summary>
        ///  the catalog name of the entity necessary to get the promotion.
        /// </summary>
        /// <value> the catalog name of the entity necessary to get the promotion.</value>
        [DataMember(Name = "catalogId", EmitDefaultValue = false)]
        public string CatalogId { get; set; }

        /// <summary>
        /// the identifier of the category necessary to get the promotion.
        /// </summary>
        /// <value>the identifier of the category necessary to get the promotion.</value>
        [DataMember(Name = "categoryId", EmitDefaultValue = false)]
        public string CategoryId { get; set; }

        /// <summary>
        /// the display name.
        /// </summary>
        /// <value>the display name.</value>
        [DataMember(Name = "displayName", EmitDefaultValue = false)]
        public string DisplayName { get; set; }

        /// <summary>
        /// the shipping method necessary to get the promotion.
        /// </summary>
        /// <value>the shipping method necessary to get the promotion.</value>
        [DataMember(Name = "fulfillmentMethodName", EmitDefaultValue = false)]
        public string FulfillmentMethodName { get; set; }

        /// <summary>
        /// the payment method necessary to get the promotion.
        /// </summary>
        /// <value>the payment method necessary to get the promotion.</value>
        [DataMember(Name = "paymentMethodType", EmitDefaultValue = false)]
        public string PaymentMethodType { get; set; }

        /// <summary>
        /// the payment method necessary to get the promotion.
        /// </summary>
        /// <value>the payment method necessary to get the promotion.</value>
        [DataMember(Name = "paymentProviderName", EmitDefaultValue = false)]
        public string PaymentProviderName { get; set; }

        /// <summary>
        /// the unique identifier of the product necessary to get the promotion.
        /// </summary>
        /// <value>the unique identifier of the product necessary to get the promotion.</value>
        [DataMember(Name = "productId", EmitDefaultValue = false)]
        public string ProductId { get; set; }

        /// <summary>
        /// the shipping provider necessary to get the promotion.
        /// </summary>
        /// <value>the shipping provider necessary to get the promotion.</value>
        [DataMember(Name = "shippingProviderId", EmitDefaultValue = false)]
        public string ShippingProviderId { get; set; }

        /// <summary>
        ///  the unique identifier of the variant necessary to get the promotion.
        /// </summary>
        /// <value> the unique identifier of the variant necessary to get the promotion.</value>
        [DataMember(Name = "variantId", EmitDefaultValue = false)]
        public string VariantId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PurchaseConditionTarget {\n");
            sb.Append("  CatalogId: ").Append(CatalogId).Append("\n");
            sb.Append("  CategoryId: ").Append(CategoryId).Append("\n");
            sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
            sb.Append("  FulfillmentMethodName: ").Append(FulfillmentMethodName).Append("\n");
            sb.Append("  PaymentMethodType: ").Append(PaymentMethodType).Append("\n");
            sb.Append("  PaymentProviderName: ").Append(PaymentProviderName).Append("\n");
            sb.Append("  ProductId: ").Append(ProductId).Append("\n");
            sb.Append("  ShippingProviderId: ").Append(ShippingProviderId).Append("\n");
            sb.Append("  TargetType: ").Append(TargetType).Append("\n");
            sb.Append("  VariantId: ").Append(VariantId).Append("\n");
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
            return this.Equals(input as PurchaseConditionTarget);
        }

        /// <summary>
        /// Returns true if PurchaseConditionTarget instances are equal
        /// </summary>
        /// <param name="input">Instance of PurchaseConditionTarget to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PurchaseConditionTarget input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CatalogId == input.CatalogId ||
                    (this.CatalogId != null &&
                    this.CatalogId.Equals(input.CatalogId))
                ) && 
                (
                    this.CategoryId == input.CategoryId ||
                    (this.CategoryId != null &&
                    this.CategoryId.Equals(input.CategoryId))
                ) && 
                (
                    this.DisplayName == input.DisplayName ||
                    (this.DisplayName != null &&
                    this.DisplayName.Equals(input.DisplayName))
                ) && 
                (
                    this.FulfillmentMethodName == input.FulfillmentMethodName ||
                    (this.FulfillmentMethodName != null &&
                    this.FulfillmentMethodName.Equals(input.FulfillmentMethodName))
                ) && 
                (
                    this.PaymentMethodType == input.PaymentMethodType ||
                    (this.PaymentMethodType != null &&
                    this.PaymentMethodType.Equals(input.PaymentMethodType))
                ) && 
                (
                    this.PaymentProviderName == input.PaymentProviderName ||
                    (this.PaymentProviderName != null &&
                    this.PaymentProviderName.Equals(input.PaymentProviderName))
                ) && 
                (
                    this.ProductId == input.ProductId ||
                    (this.ProductId != null &&
                    this.ProductId.Equals(input.ProductId))
                ) && 
                (
                    this.ShippingProviderId == input.ShippingProviderId ||
                    (this.ShippingProviderId != null &&
                    this.ShippingProviderId.Equals(input.ShippingProviderId))
                ) && 
                (
                    this.TargetType == input.TargetType ||
                    this.TargetType.Equals(input.TargetType)
                ) && 
                (
                    this.VariantId == input.VariantId ||
                    (this.VariantId != null &&
                    this.VariantId.Equals(input.VariantId))
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
                if (this.CatalogId != null)
                    hashCode = hashCode * 59 + this.CatalogId.GetHashCode();
                if (this.CategoryId != null)
                    hashCode = hashCode * 59 + this.CategoryId.GetHashCode();
                if (this.DisplayName != null)
                    hashCode = hashCode * 59 + this.DisplayName.GetHashCode();
                if (this.FulfillmentMethodName != null)
                    hashCode = hashCode * 59 + this.FulfillmentMethodName.GetHashCode();
                if (this.PaymentMethodType != null)
                    hashCode = hashCode * 59 + this.PaymentMethodType.GetHashCode();
                if (this.PaymentProviderName != null)
                    hashCode = hashCode * 59 + this.PaymentProviderName.GetHashCode();
                if (this.ProductId != null)
                    hashCode = hashCode * 59 + this.ProductId.GetHashCode();
                if (this.ShippingProviderId != null)
                    hashCode = hashCode * 59 + this.ShippingProviderId.GetHashCode();
                hashCode = hashCode * 59 + this.TargetType.GetHashCode();
                if (this.VariantId != null)
                    hashCode = hashCode * 59 + this.VariantId.GetHashCode();
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
