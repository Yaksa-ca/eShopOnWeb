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
    /// LineItemSummary
    /// </summary>
    [DataContract(Name = "LineItemSummary")]
    public partial class LineItemSummary : IEquatable<LineItemSummary>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LineItemSummary" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected LineItemSummary() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="LineItemSummary" /> class.
        /// </summary>
        /// <param name="id">The unique identifier of the entity. (required).</param>
        /// <param name="propertyBag">propertyBag.</param>
        /// <param name="additionalFeeAmount">The amount for all discounts applied to this line item. This value is usually computed during the workflow execution. When null, indicates that the value has not been calculated..</param>
        /// <param name="catalogId">The unique identifier of the catalog where the product belongs. (required).</param>
        /// <param name="currentPrice">The price for one instance of the item (quantity &#x3D; 1), at the moment that the item is to be processed by the workflow..</param>
        /// <param name="currentPricePriceListCategory">The category of the current price.</param>
        /// <param name="currentPricePriceListId">The id of the current price.</param>
        /// <param name="currentPricePriceListType">The type of the current price.</param>
        /// <param name="discountAmount">The amount for all discounts applied to this line item. This value is usually computed during the workflow execution. When null, indicates that the value has not been calculated..</param>
        /// <param name="itemFormat">the ItemFormat of the product..</param>
        /// <param name="listPrice">The price for one instance of the item (quantity &#x3D; 1), at the moment that the item is to be processed by the workflow..</param>
        /// <param name="productDisplayName">The UI-friendly display name for the product..</param>
        /// <param name="productId">The unique identifier of the product (required).</param>
        /// <param name="quantity">The quantity of product to purchase. A decimal number can be used for products sold with a unit of measure (pounds, kilos, etc.)..</param>
        /// <param name="recurringOrderFrequencyName">recurringOrderFrequencyName.</param>
        /// <param name="recurringOrderProgramName">recurringOrderProgramName.</param>
        /// <param name="regularPrice">The current regular price for one instance of the item (quantity &#x3D; 1), at the moment that the item is to be processed by the workflow..</param>
        /// <param name="regularPricePriceListCategory">The category of the regular price.</param>
        /// <param name="regularPricePriceListId">The id of the regular price.</param>
        /// <param name="shipmentId">The unique identifier of the shipment to use for this item.</param>
        /// <param name="sku">The LineItem Sku.</param>
        /// <param name="status">status.</param>
        /// <param name="total">The total amount for this line item, including discounts (list price * quantity - discounts). This value is usually computed during the workflow execution. When null, indicates that the value has not been calculated..</param>
        /// <param name="unitOfMeasure">the UnitOfMeasure of the product..</param>
        /// <param name="variantId">The unique identifier of the product variant if the purchased product is a variant.</param>
        public LineItemSummary(string id = default(string), Dictionary<string, Object> propertyBag = default(Dictionary<string, Object>), double additionalFeeAmount = default(double), string catalogId = default(string), double currentPrice = default(double), string currentPricePriceListCategory = default(string), string currentPricePriceListId = default(string), string currentPricePriceListType = default(string), double discountAmount = default(double), double itemFormat = default(double), double listPrice = default(double), string productDisplayName = default(string), string productId = default(string), double quantity = default(double), string recurringOrderFrequencyName = default(string), string recurringOrderProgramName = default(string), double regularPrice = default(double), string regularPricePriceListCategory = default(string), string regularPricePriceListId = default(string), string shipmentId = default(string), string sku = default(string), string status = default(string), double total = default(double), string unitOfMeasure = default(string), string variantId = default(string))
        {
            // to ensure "id" is required (not null)
            this.Id = id ?? throw new ArgumentNullException("id is a required property for LineItemSummary and cannot be null");
            // to ensure "catalogId" is required (not null)
            this.CatalogId = catalogId ?? throw new ArgumentNullException("catalogId is a required property for LineItemSummary and cannot be null");
            // to ensure "productId" is required (not null)
            this.ProductId = productId ?? throw new ArgumentNullException("productId is a required property for LineItemSummary and cannot be null");
            this.PropertyBag = propertyBag;
            this.AdditionalFeeAmount = additionalFeeAmount;
            this.CurrentPrice = currentPrice;
            this.CurrentPricePriceListCategory = currentPricePriceListCategory;
            this.CurrentPricePriceListId = currentPricePriceListId;
            this.CurrentPricePriceListType = currentPricePriceListType;
            this.DiscountAmount = discountAmount;
            this.ItemFormat = itemFormat;
            this.ListPrice = listPrice;
            this.ProductDisplayName = productDisplayName;
            this.Quantity = quantity;
            this.RecurringOrderFrequencyName = recurringOrderFrequencyName;
            this.RecurringOrderProgramName = recurringOrderProgramName;
            this.RegularPrice = regularPrice;
            this.RegularPricePriceListCategory = regularPricePriceListCategory;
            this.RegularPricePriceListId = regularPricePriceListId;
            this.ShipmentId = shipmentId;
            this.Sku = sku;
            this.Status = status;
            this.Total = total;
            this.UnitOfMeasure = unitOfMeasure;
            this.VariantId = variantId;
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
        /// The amount for all discounts applied to this line item. This value is usually computed during the workflow execution. When null, indicates that the value has not been calculated.
        /// </summary>
        /// <value>The amount for all discounts applied to this line item. This value is usually computed during the workflow execution. When null, indicates that the value has not been calculated.</value>
        [DataMember(Name = "additionalFeeAmount", EmitDefaultValue = false)]
        public double AdditionalFeeAmount { get; set; }

        /// <summary>
        /// The unique identifier of the catalog where the product belongs.
        /// </summary>
        /// <value>The unique identifier of the catalog where the product belongs.</value>
        [DataMember(Name = "catalogId", IsRequired = true, EmitDefaultValue = false)]
        public string CatalogId { get; set; }

        /// <summary>
        /// The price for one instance of the item (quantity &#x3D; 1), at the moment that the item is to be processed by the workflow.
        /// </summary>
        /// <value>The price for one instance of the item (quantity &#x3D; 1), at the moment that the item is to be processed by the workflow.</value>
        [DataMember(Name = "currentPrice", EmitDefaultValue = false)]
        public double CurrentPrice { get; set; }

        /// <summary>
        /// The category of the current price
        /// </summary>
        /// <value>The category of the current price</value>
        [DataMember(Name = "currentPricePriceListCategory", EmitDefaultValue = false)]
        public string CurrentPricePriceListCategory { get; set; }

        /// <summary>
        /// The id of the current price
        /// </summary>
        /// <value>The id of the current price</value>
        [DataMember(Name = "currentPricePriceListId", EmitDefaultValue = false)]
        public string CurrentPricePriceListId { get; set; }

        /// <summary>
        /// The type of the current price
        /// </summary>
        /// <value>The type of the current price</value>
        [DataMember(Name = "currentPricePriceListType", EmitDefaultValue = false)]
        public string CurrentPricePriceListType { get; set; }

        /// <summary>
        /// The amount for all discounts applied to this line item. This value is usually computed during the workflow execution. When null, indicates that the value has not been calculated.
        /// </summary>
        /// <value>The amount for all discounts applied to this line item. This value is usually computed during the workflow execution. When null, indicates that the value has not been calculated.</value>
        [DataMember(Name = "discountAmount", EmitDefaultValue = false)]
        public double DiscountAmount { get; set; }

        /// <summary>
        /// the ItemFormat of the product.
        /// </summary>
        /// <value>the ItemFormat of the product.</value>
        [DataMember(Name = "itemFormat", EmitDefaultValue = false)]
        public double ItemFormat { get; set; }

        /// <summary>
        /// The price for one instance of the item (quantity &#x3D; 1), at the moment that the item is to be processed by the workflow.
        /// </summary>
        /// <value>The price for one instance of the item (quantity &#x3D; 1), at the moment that the item is to be processed by the workflow.</value>
        [DataMember(Name = "listPrice", EmitDefaultValue = false)]
        public double ListPrice { get; set; }

        /// <summary>
        /// The UI-friendly display name for the product.
        /// </summary>
        /// <value>The UI-friendly display name for the product.</value>
        [DataMember(Name = "productDisplayName", EmitDefaultValue = false)]
        public string ProductDisplayName { get; set; }

        /// <summary>
        /// The unique identifier of the product
        /// </summary>
        /// <value>The unique identifier of the product</value>
        [DataMember(Name = "productId", IsRequired = true, EmitDefaultValue = false)]
        public string ProductId { get; set; }

        /// <summary>
        /// The quantity of product to purchase. A decimal number can be used for products sold with a unit of measure (pounds, kilos, etc.).
        /// </summary>
        /// <value>The quantity of product to purchase. A decimal number can be used for products sold with a unit of measure (pounds, kilos, etc.).</value>
        [DataMember(Name = "quantity", EmitDefaultValue = false)]
        public double Quantity { get; set; }

        /// <summary>
        /// Gets or Sets RecurringOrderFrequencyName
        /// </summary>
        [DataMember(Name = "recurringOrderFrequencyName", EmitDefaultValue = false)]
        public string RecurringOrderFrequencyName { get; set; }

        /// <summary>
        /// Gets or Sets RecurringOrderProgramName
        /// </summary>
        [DataMember(Name = "recurringOrderProgramName", EmitDefaultValue = false)]
        public string RecurringOrderProgramName { get; set; }

        /// <summary>
        /// The current regular price for one instance of the item (quantity &#x3D; 1), at the moment that the item is to be processed by the workflow.
        /// </summary>
        /// <value>The current regular price for one instance of the item (quantity &#x3D; 1), at the moment that the item is to be processed by the workflow.</value>
        [DataMember(Name = "regularPrice", EmitDefaultValue = false)]
        public double RegularPrice { get; set; }

        /// <summary>
        /// The category of the regular price
        /// </summary>
        /// <value>The category of the regular price</value>
        [DataMember(Name = "regularPricePriceListCategory", EmitDefaultValue = false)]
        public string RegularPricePriceListCategory { get; set; }

        /// <summary>
        /// The id of the regular price
        /// </summary>
        /// <value>The id of the regular price</value>
        [DataMember(Name = "regularPricePriceListId", EmitDefaultValue = false)]
        public string RegularPricePriceListId { get; set; }

        /// <summary>
        /// The unique identifier of the shipment to use for this item
        /// </summary>
        /// <value>The unique identifier of the shipment to use for this item</value>
        [DataMember(Name = "shipmentId", EmitDefaultValue = false)]
        public string ShipmentId { get; set; }

        /// <summary>
        /// The LineItem Sku
        /// </summary>
        /// <value>The LineItem Sku</value>
        [DataMember(Name = "sku", EmitDefaultValue = false)]
        public string Sku { get; set; }

        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name = "status", EmitDefaultValue = false)]
        public string Status { get; set; }

        /// <summary>
        /// The total amount for this line item, including discounts (list price * quantity - discounts). This value is usually computed during the workflow execution. When null, indicates that the value has not been calculated.
        /// </summary>
        /// <value>The total amount for this line item, including discounts (list price * quantity - discounts). This value is usually computed during the workflow execution. When null, indicates that the value has not been calculated.</value>
        [DataMember(Name = "total", EmitDefaultValue = false)]
        public double Total { get; set; }

        /// <summary>
        /// the UnitOfMeasure of the product.
        /// </summary>
        /// <value>the UnitOfMeasure of the product.</value>
        [DataMember(Name = "unitOfMeasure", EmitDefaultValue = false)]
        public string UnitOfMeasure { get; set; }

        /// <summary>
        /// The unique identifier of the product variant if the purchased product is a variant
        /// </summary>
        /// <value>The unique identifier of the product variant if the purchased product is a variant</value>
        [DataMember(Name = "variantId", EmitDefaultValue = false)]
        public string VariantId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LineItemSummary {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  PropertyBag: ").Append(PropertyBag).Append("\n");
            sb.Append("  AdditionalFeeAmount: ").Append(AdditionalFeeAmount).Append("\n");
            sb.Append("  CatalogId: ").Append(CatalogId).Append("\n");
            sb.Append("  CurrentPrice: ").Append(CurrentPrice).Append("\n");
            sb.Append("  CurrentPricePriceListCategory: ").Append(CurrentPricePriceListCategory).Append("\n");
            sb.Append("  CurrentPricePriceListId: ").Append(CurrentPricePriceListId).Append("\n");
            sb.Append("  CurrentPricePriceListType: ").Append(CurrentPricePriceListType).Append("\n");
            sb.Append("  DiscountAmount: ").Append(DiscountAmount).Append("\n");
            sb.Append("  ItemFormat: ").Append(ItemFormat).Append("\n");
            sb.Append("  ListPrice: ").Append(ListPrice).Append("\n");
            sb.Append("  ProductDisplayName: ").Append(ProductDisplayName).Append("\n");
            sb.Append("  ProductId: ").Append(ProductId).Append("\n");
            sb.Append("  Quantity: ").Append(Quantity).Append("\n");
            sb.Append("  RecurringOrderFrequencyName: ").Append(RecurringOrderFrequencyName).Append("\n");
            sb.Append("  RecurringOrderProgramName: ").Append(RecurringOrderProgramName).Append("\n");
            sb.Append("  RegularPrice: ").Append(RegularPrice).Append("\n");
            sb.Append("  RegularPricePriceListCategory: ").Append(RegularPricePriceListCategory).Append("\n");
            sb.Append("  RegularPricePriceListId: ").Append(RegularPricePriceListId).Append("\n");
            sb.Append("  ShipmentId: ").Append(ShipmentId).Append("\n");
            sb.Append("  Sku: ").Append(Sku).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Total: ").Append(Total).Append("\n");
            sb.Append("  UnitOfMeasure: ").Append(UnitOfMeasure).Append("\n");
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
            return this.Equals(input as LineItemSummary);
        }

        /// <summary>
        /// Returns true if LineItemSummary instances are equal
        /// </summary>
        /// <param name="input">Instance of LineItemSummary to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LineItemSummary input)
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
                    this.AdditionalFeeAmount == input.AdditionalFeeAmount ||
                    this.AdditionalFeeAmount.Equals(input.AdditionalFeeAmount)
                ) && 
                (
                    this.CatalogId == input.CatalogId ||
                    (this.CatalogId != null &&
                    this.CatalogId.Equals(input.CatalogId))
                ) && 
                (
                    this.CurrentPrice == input.CurrentPrice ||
                    this.CurrentPrice.Equals(input.CurrentPrice)
                ) && 
                (
                    this.CurrentPricePriceListCategory == input.CurrentPricePriceListCategory ||
                    (this.CurrentPricePriceListCategory != null &&
                    this.CurrentPricePriceListCategory.Equals(input.CurrentPricePriceListCategory))
                ) && 
                (
                    this.CurrentPricePriceListId == input.CurrentPricePriceListId ||
                    (this.CurrentPricePriceListId != null &&
                    this.CurrentPricePriceListId.Equals(input.CurrentPricePriceListId))
                ) && 
                (
                    this.CurrentPricePriceListType == input.CurrentPricePriceListType ||
                    (this.CurrentPricePriceListType != null &&
                    this.CurrentPricePriceListType.Equals(input.CurrentPricePriceListType))
                ) && 
                (
                    this.DiscountAmount == input.DiscountAmount ||
                    this.DiscountAmount.Equals(input.DiscountAmount)
                ) && 
                (
                    this.ItemFormat == input.ItemFormat ||
                    this.ItemFormat.Equals(input.ItemFormat)
                ) && 
                (
                    this.ListPrice == input.ListPrice ||
                    this.ListPrice.Equals(input.ListPrice)
                ) && 
                (
                    this.ProductDisplayName == input.ProductDisplayName ||
                    (this.ProductDisplayName != null &&
                    this.ProductDisplayName.Equals(input.ProductDisplayName))
                ) && 
                (
                    this.ProductId == input.ProductId ||
                    (this.ProductId != null &&
                    this.ProductId.Equals(input.ProductId))
                ) && 
                (
                    this.Quantity == input.Quantity ||
                    this.Quantity.Equals(input.Quantity)
                ) && 
                (
                    this.RecurringOrderFrequencyName == input.RecurringOrderFrequencyName ||
                    (this.RecurringOrderFrequencyName != null &&
                    this.RecurringOrderFrequencyName.Equals(input.RecurringOrderFrequencyName))
                ) && 
                (
                    this.RecurringOrderProgramName == input.RecurringOrderProgramName ||
                    (this.RecurringOrderProgramName != null &&
                    this.RecurringOrderProgramName.Equals(input.RecurringOrderProgramName))
                ) && 
                (
                    this.RegularPrice == input.RegularPrice ||
                    this.RegularPrice.Equals(input.RegularPrice)
                ) && 
                (
                    this.RegularPricePriceListCategory == input.RegularPricePriceListCategory ||
                    (this.RegularPricePriceListCategory != null &&
                    this.RegularPricePriceListCategory.Equals(input.RegularPricePriceListCategory))
                ) && 
                (
                    this.RegularPricePriceListId == input.RegularPricePriceListId ||
                    (this.RegularPricePriceListId != null &&
                    this.RegularPricePriceListId.Equals(input.RegularPricePriceListId))
                ) && 
                (
                    this.ShipmentId == input.ShipmentId ||
                    (this.ShipmentId != null &&
                    this.ShipmentId.Equals(input.ShipmentId))
                ) && 
                (
                    this.Sku == input.Sku ||
                    (this.Sku != null &&
                    this.Sku.Equals(input.Sku))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.Total == input.Total ||
                    this.Total.Equals(input.Total)
                ) && 
                (
                    this.UnitOfMeasure == input.UnitOfMeasure ||
                    (this.UnitOfMeasure != null &&
                    this.UnitOfMeasure.Equals(input.UnitOfMeasure))
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.PropertyBag != null)
                    hashCode = hashCode * 59 + this.PropertyBag.GetHashCode();
                hashCode = hashCode * 59 + this.AdditionalFeeAmount.GetHashCode();
                if (this.CatalogId != null)
                    hashCode = hashCode * 59 + this.CatalogId.GetHashCode();
                hashCode = hashCode * 59 + this.CurrentPrice.GetHashCode();
                if (this.CurrentPricePriceListCategory != null)
                    hashCode = hashCode * 59 + this.CurrentPricePriceListCategory.GetHashCode();
                if (this.CurrentPricePriceListId != null)
                    hashCode = hashCode * 59 + this.CurrentPricePriceListId.GetHashCode();
                if (this.CurrentPricePriceListType != null)
                    hashCode = hashCode * 59 + this.CurrentPricePriceListType.GetHashCode();
                hashCode = hashCode * 59 + this.DiscountAmount.GetHashCode();
                hashCode = hashCode * 59 + this.ItemFormat.GetHashCode();
                hashCode = hashCode * 59 + this.ListPrice.GetHashCode();
                if (this.ProductDisplayName != null)
                    hashCode = hashCode * 59 + this.ProductDisplayName.GetHashCode();
                if (this.ProductId != null)
                    hashCode = hashCode * 59 + this.ProductId.GetHashCode();
                hashCode = hashCode * 59 + this.Quantity.GetHashCode();
                if (this.RecurringOrderFrequencyName != null)
                    hashCode = hashCode * 59 + this.RecurringOrderFrequencyName.GetHashCode();
                if (this.RecurringOrderProgramName != null)
                    hashCode = hashCode * 59 + this.RecurringOrderProgramName.GetHashCode();
                hashCode = hashCode * 59 + this.RegularPrice.GetHashCode();
                if (this.RegularPricePriceListCategory != null)
                    hashCode = hashCode * 59 + this.RegularPricePriceListCategory.GetHashCode();
                if (this.RegularPricePriceListId != null)
                    hashCode = hashCode * 59 + this.RegularPricePriceListId.GetHashCode();
                if (this.ShipmentId != null)
                    hashCode = hashCode * 59 + this.ShipmentId.GetHashCode();
                if (this.Sku != null)
                    hashCode = hashCode * 59 + this.Sku.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                hashCode = hashCode * 59 + this.Total.GetHashCode();
                if (this.UnitOfMeasure != null)
                    hashCode = hashCode * 59 + this.UnitOfMeasure.GetHashCode();
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
