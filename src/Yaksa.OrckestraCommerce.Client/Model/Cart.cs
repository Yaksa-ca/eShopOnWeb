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
    /// Cart
    /// </summary>
    [DataContract(Name = "Cart")]
    public partial class Cart : IEquatable<Cart>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Cart" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Cart() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Cart" /> class.
        /// </summary>
        /// <param name="id">The unique identifier of the entity. (required).</param>
        /// <param name="propertyBag">propertyBag.</param>
        /// <param name="created">Date the entity was created.</param>
        /// <param name="createdBy">Identifier of the operator who created the entity.</param>
        /// <param name="lastModified">Date that the last modification was applied to the entity.</param>
        /// <param name="lastModifiedBy">Identifier of the operator who last modified the entity.</param>
        /// <param name="additionalFeeTotal">the sum of LineItems totals..</param>
        /// <param name="adjustmentTotal">the total amount of adjustments.  This value is usually computed during the workflow execution. When null, indicates that the value has not been calculated..</param>
        /// <param name="billingCurrency">the currency ISO code under which the items are sold &#39;Currency.IsoCode&#39;..</param>
        /// <param name="cartType">the cart type, according to the CartType lookup..</param>
        /// <param name="cartVersion">the version of the cart.</param>
        /// <param name="coupons">the collection of coupon codes included in the order..</param>
        /// <param name="cultureName">the culture in which the cart is being processed..</param>
        /// <param name="customer">customer.</param>
        /// <param name="customerId">the ID of the customer owning this cart. (required).</param>
        /// <param name="discountTotal">the computed sum of all discounts applied to the cart (including order, line item and fulfillment level discounts). This value is usually computed during the workflow execution. When null, indicates that the value has not been calculated..</param>
        /// <param name="fulfillmentCost">the computed sum of all shipment cost. This value is usually computed during the workflow execution. When null, indicates that the value has not been calculated..</param>
        /// <param name="fulfillmentCostWithoutDiscount">the fulfillment cost without discount..</param>
        /// <param name="fulfillmentLevelDiscountTotal">the sum of Shipments discounts. Shipment.DiscountAmount..</param>
        /// <param name="itemCount">the line item count..</param>
        /// <param name="lineItemLevelDiscount">the minimum value between the sum of LineItem.DiscountAmount and LineItemsTotalWithoutDiscount..</param>
        /// <param name="lineItemsTotal">the sum of LineItems totals..</param>
        /// <param name="lineItemsTotalWithoutDiscount">the sum of LineItems totals without discount..</param>
        /// <param name="merchandiseTotal">the total amount of all line items merchandise without discounts. This value is usually computed during the workflow execution. When null, indicates that the value has not been calculated..</param>
        /// <param name="name">the name of the cart. (required).</param>
        /// <param name="orderLocation">orderLocation.</param>
        /// <param name="originalPromotions">the promotion versions applied for the original order..</param>
        /// <param name="payments">The collection of payments to use for this order..</param>
        /// <param name="scopeId">the unique identifier of the scope associated to the cart..</param>
        /// <param name="shipmentLevelDiscountTotal">the sum of Discounts amounts..</param>
        /// <param name="shipments">the collection of shipments associated to this order..</param>
        /// <param name="source">the cart source..</param>
        /// <param name="status">the status of the cart..</param>
        /// <param name="subTotal">the computed sum of all line items totals, including line item and order level discount. This value is usually computed during the workflow execution. When null, indicates that the value has not been calculated..</param>
        /// <param name="subTotalDiscount">the sum of LineItems totals without discount..</param>
        /// <param name="taxTotal">the computed sum of all tax amount for the order. This value is usually computed during the workflow execution. When null, indicates that the value has not been calculated..</param>
        /// <param name="total">the grand total for the cart. This value is usually computed during the workflow execution. When null, indicates that the value has not been calculated..</param>
        public Cart(string id = default(string), Dictionary<string, Object> propertyBag = default(Dictionary<string, Object>), DateTime created = default(DateTime), string createdBy = default(string), DateTime lastModified = default(DateTime), string lastModifiedBy = default(string), double additionalFeeTotal = default(double), double adjustmentTotal = default(double), string billingCurrency = default(string), string cartType = default(string), string cartVersion = default(string), List<Coupon> coupons = default(List<Coupon>), string cultureName = default(string), CustomerSummary customer = default(CustomerSummary), string customerId = default(string), double discountTotal = default(double), double fulfillmentCost = default(double), double fulfillmentCostWithoutDiscount = default(double), double fulfillmentLevelDiscountTotal = default(double), int itemCount = default(int), double lineItemLevelDiscount = default(double), double lineItemsTotal = default(double), double lineItemsTotalWithoutDiscount = default(double), double merchandiseTotal = default(double), string name = default(string), OrderLocationSummary orderLocation = default(OrderLocationSummary), List<PromotionVersion> originalPromotions = default(List<PromotionVersion>), List<Payment> payments = default(List<Payment>), string scopeId = default(string), double shipmentLevelDiscountTotal = default(double), List<Shipment> shipments = default(List<Shipment>), string source = default(string), string status = default(string), double subTotal = default(double), double subTotalDiscount = default(double), double taxTotal = default(double), double total = default(double))
        {
            // to ensure "id" is required (not null)
            this.Id = id ?? throw new ArgumentNullException("id is a required property for Cart and cannot be null");
            // to ensure "customerId" is required (not null)
            this.CustomerId = customerId ?? throw new ArgumentNullException("customerId is a required property for Cart and cannot be null");
            // to ensure "name" is required (not null)
            this.Name = name ?? throw new ArgumentNullException("name is a required property for Cart and cannot be null");
            this.PropertyBag = propertyBag;
            this.Created = created;
            this.CreatedBy = createdBy;
            this.LastModified = lastModified;
            this.LastModifiedBy = lastModifiedBy;
            this.AdditionalFeeTotal = additionalFeeTotal;
            this.AdjustmentTotal = adjustmentTotal;
            this.BillingCurrency = billingCurrency;
            this.CartType = cartType;
            this.CartVersion = cartVersion;
            this.Coupons = coupons;
            this.CultureName = cultureName;
            this.Customer = customer;
            this.DiscountTotal = discountTotal;
            this.FulfillmentCost = fulfillmentCost;
            this.FulfillmentCostWithoutDiscount = fulfillmentCostWithoutDiscount;
            this.FulfillmentLevelDiscountTotal = fulfillmentLevelDiscountTotal;
            this.ItemCount = itemCount;
            this.LineItemLevelDiscount = lineItemLevelDiscount;
            this.LineItemsTotal = lineItemsTotal;
            this.LineItemsTotalWithoutDiscount = lineItemsTotalWithoutDiscount;
            this.MerchandiseTotal = merchandiseTotal;
            this.OrderLocation = orderLocation;
            this.OriginalPromotions = originalPromotions;
            this.Payments = payments;
            this.ScopeId = scopeId;
            this.ShipmentLevelDiscountTotal = shipmentLevelDiscountTotal;
            this.Shipments = shipments;
            this.Source = source;
            this.Status = status;
            this.SubTotal = subTotal;
            this.SubTotalDiscount = subTotalDiscount;
            this.TaxTotal = taxTotal;
            this.Total = total;
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
        /// Date the entity was created
        /// </summary>
        /// <value>Date the entity was created</value>
        [DataMember(Name = "created", EmitDefaultValue = false)]
        public DateTime Created { get; set; }

        /// <summary>
        /// Identifier of the operator who created the entity
        /// </summary>
        /// <value>Identifier of the operator who created the entity</value>
        [DataMember(Name = "createdBy", EmitDefaultValue = false)]
        public string CreatedBy { get; set; }

        /// <summary>
        /// Date that the last modification was applied to the entity
        /// </summary>
        /// <value>Date that the last modification was applied to the entity</value>
        [DataMember(Name = "lastModified", EmitDefaultValue = false)]
        public DateTime LastModified { get; set; }

        /// <summary>
        /// Identifier of the operator who last modified the entity
        /// </summary>
        /// <value>Identifier of the operator who last modified the entity</value>
        [DataMember(Name = "lastModifiedBy", EmitDefaultValue = false)]
        public string LastModifiedBy { get; set; }

        /// <summary>
        /// the sum of LineItems totals.
        /// </summary>
        /// <value>the sum of LineItems totals.</value>
        [DataMember(Name = "additionalFeeTotal", EmitDefaultValue = false)]
        public double AdditionalFeeTotal { get; set; }

        /// <summary>
        /// the total amount of adjustments.  This value is usually computed during the workflow execution. When null, indicates that the value has not been calculated.
        /// </summary>
        /// <value>the total amount of adjustments.  This value is usually computed during the workflow execution. When null, indicates that the value has not been calculated.</value>
        [DataMember(Name = "adjustmentTotal", EmitDefaultValue = false)]
        public double AdjustmentTotal { get; set; }

        /// <summary>
        /// the currency ISO code under which the items are sold &#39;Currency.IsoCode&#39;.
        /// </summary>
        /// <value>the currency ISO code under which the items are sold &#39;Currency.IsoCode&#39;.</value>
        [DataMember(Name = "billingCurrency", EmitDefaultValue = false)]
        public string BillingCurrency { get; set; }

        /// <summary>
        /// the cart type, according to the CartType lookup.
        /// </summary>
        /// <value>the cart type, according to the CartType lookup.</value>
        [DataMember(Name = "cartType", EmitDefaultValue = false)]
        public string CartType { get; set; }

        /// <summary>
        /// the version of the cart
        /// </summary>
        /// <value>the version of the cart</value>
        [DataMember(Name = "cartVersion", EmitDefaultValue = false)]
        public string CartVersion { get; set; }

        /// <summary>
        /// the collection of coupon codes included in the order.
        /// </summary>
        /// <value>the collection of coupon codes included in the order.</value>
        [DataMember(Name = "coupons", EmitDefaultValue = false)]
        public List<Coupon> Coupons { get; set; }

        /// <summary>
        /// the culture in which the cart is being processed.
        /// </summary>
        /// <value>the culture in which the cart is being processed.</value>
        [DataMember(Name = "cultureName", EmitDefaultValue = false)]
        public string CultureName { get; set; }

        /// <summary>
        /// Gets or Sets Customer
        /// </summary>
        [DataMember(Name = "customer", EmitDefaultValue = false)]
        public CustomerSummary Customer { get; set; }

        /// <summary>
        /// the ID of the customer owning this cart.
        /// </summary>
        /// <value>the ID of the customer owning this cart.</value>
        [DataMember(Name = "customerId", IsRequired = true, EmitDefaultValue = false)]
        public string CustomerId { get; set; }

        /// <summary>
        /// the computed sum of all discounts applied to the cart (including order, line item and fulfillment level discounts). This value is usually computed during the workflow execution. When null, indicates that the value has not been calculated.
        /// </summary>
        /// <value>the computed sum of all discounts applied to the cart (including order, line item and fulfillment level discounts). This value is usually computed during the workflow execution. When null, indicates that the value has not been calculated.</value>
        [DataMember(Name = "discountTotal", EmitDefaultValue = false)]
        public double DiscountTotal { get; set; }

        /// <summary>
        /// the computed sum of all shipment cost. This value is usually computed during the workflow execution. When null, indicates that the value has not been calculated.
        /// </summary>
        /// <value>the computed sum of all shipment cost. This value is usually computed during the workflow execution. When null, indicates that the value has not been calculated.</value>
        [DataMember(Name = "fulfillmentCost", EmitDefaultValue = false)]
        public double FulfillmentCost { get; set; }

        /// <summary>
        /// the fulfillment cost without discount.
        /// </summary>
        /// <value>the fulfillment cost without discount.</value>
        [DataMember(Name = "fulfillmentCostWithoutDiscount", EmitDefaultValue = false)]
        public double FulfillmentCostWithoutDiscount { get; set; }

        /// <summary>
        /// the sum of Shipments discounts. Shipment.DiscountAmount.
        /// </summary>
        /// <value>the sum of Shipments discounts. Shipment.DiscountAmount.</value>
        [DataMember(Name = "fulfillmentLevelDiscountTotal", EmitDefaultValue = false)]
        public double FulfillmentLevelDiscountTotal { get; set; }

        /// <summary>
        /// the line item count.
        /// </summary>
        /// <value>the line item count.</value>
        [DataMember(Name = "itemCount", EmitDefaultValue = false)]
        public int ItemCount { get; set; }

        /// <summary>
        /// the minimum value between the sum of LineItem.DiscountAmount and LineItemsTotalWithoutDiscount.
        /// </summary>
        /// <value>the minimum value between the sum of LineItem.DiscountAmount and LineItemsTotalWithoutDiscount.</value>
        [DataMember(Name = "lineItemLevelDiscount", EmitDefaultValue = false)]
        public double LineItemLevelDiscount { get; set; }

        /// <summary>
        /// the sum of LineItems totals.
        /// </summary>
        /// <value>the sum of LineItems totals.</value>
        [DataMember(Name = "lineItemsTotal", EmitDefaultValue = false)]
        public double LineItemsTotal { get; set; }

        /// <summary>
        /// the sum of LineItems totals without discount.
        /// </summary>
        /// <value>the sum of LineItems totals without discount.</value>
        [DataMember(Name = "lineItemsTotalWithoutDiscount", EmitDefaultValue = false)]
        public double LineItemsTotalWithoutDiscount { get; set; }

        /// <summary>
        /// the total amount of all line items merchandise without discounts. This value is usually computed during the workflow execution. When null, indicates that the value has not been calculated.
        /// </summary>
        /// <value>the total amount of all line items merchandise without discounts. This value is usually computed during the workflow execution. When null, indicates that the value has not been calculated.</value>
        [DataMember(Name = "merchandiseTotal", EmitDefaultValue = false)]
        public double MerchandiseTotal { get; set; }

        /// <summary>
        /// the name of the cart.
        /// </summary>
        /// <value>the name of the cart.</value>
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets OrderLocation
        /// </summary>
        [DataMember(Name = "orderLocation", EmitDefaultValue = false)]
        public OrderLocationSummary OrderLocation { get; set; }

        /// <summary>
        /// the promotion versions applied for the original order.
        /// </summary>
        /// <value>the promotion versions applied for the original order.</value>
        [DataMember(Name = "originalPromotions", EmitDefaultValue = false)]
        public List<PromotionVersion> OriginalPromotions { get; set; }

        /// <summary>
        /// The collection of payments to use for this order.
        /// </summary>
        /// <value>The collection of payments to use for this order.</value>
        [DataMember(Name = "payments", EmitDefaultValue = false)]
        public List<Payment> Payments { get; set; }

        /// <summary>
        /// the unique identifier of the scope associated to the cart.
        /// </summary>
        /// <value>the unique identifier of the scope associated to the cart.</value>
        [DataMember(Name = "scopeId", EmitDefaultValue = false)]
        public string ScopeId { get; set; }

        /// <summary>
        /// the sum of Discounts amounts.
        /// </summary>
        /// <value>the sum of Discounts amounts.</value>
        [DataMember(Name = "shipmentLevelDiscountTotal", EmitDefaultValue = false)]
        public double ShipmentLevelDiscountTotal { get; set; }

        /// <summary>
        /// the collection of shipments associated to this order.
        /// </summary>
        /// <value>the collection of shipments associated to this order.</value>
        [DataMember(Name = "shipments", EmitDefaultValue = false)]
        public List<Shipment> Shipments { get; set; }

        /// <summary>
        /// the cart source.
        /// </summary>
        /// <value>the cart source.</value>
        [DataMember(Name = "source", EmitDefaultValue = false)]
        public string Source { get; set; }

        /// <summary>
        /// the status of the cart.
        /// </summary>
        /// <value>the status of the cart.</value>
        [DataMember(Name = "status", EmitDefaultValue = false)]
        public string Status { get; set; }

        /// <summary>
        /// the computed sum of all line items totals, including line item and order level discount. This value is usually computed during the workflow execution. When null, indicates that the value has not been calculated.
        /// </summary>
        /// <value>the computed sum of all line items totals, including line item and order level discount. This value is usually computed during the workflow execution. When null, indicates that the value has not been calculated.</value>
        [DataMember(Name = "subTotal", EmitDefaultValue = false)]
        public double SubTotal { get; set; }

        /// <summary>
        /// the sum of LineItems totals without discount.
        /// </summary>
        /// <value>the sum of LineItems totals without discount.</value>
        [DataMember(Name = "subTotalDiscount", EmitDefaultValue = false)]
        public double SubTotalDiscount { get; set; }

        /// <summary>
        /// the computed sum of all tax amount for the order. This value is usually computed during the workflow execution. When null, indicates that the value has not been calculated.
        /// </summary>
        /// <value>the computed sum of all tax amount for the order. This value is usually computed during the workflow execution. When null, indicates that the value has not been calculated.</value>
        [DataMember(Name = "taxTotal", EmitDefaultValue = false)]
        public double TaxTotal { get; set; }

        /// <summary>
        /// the grand total for the cart. This value is usually computed during the workflow execution. When null, indicates that the value has not been calculated.
        /// </summary>
        /// <value>the grand total for the cart. This value is usually computed during the workflow execution. When null, indicates that the value has not been calculated.</value>
        [DataMember(Name = "total", EmitDefaultValue = false)]
        public double Total { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Cart {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  PropertyBag: ").Append(PropertyBag).Append("\n");
            sb.Append("  Created: ").Append(Created).Append("\n");
            sb.Append("  CreatedBy: ").Append(CreatedBy).Append("\n");
            sb.Append("  LastModified: ").Append(LastModified).Append("\n");
            sb.Append("  LastModifiedBy: ").Append(LastModifiedBy).Append("\n");
            sb.Append("  AdditionalFeeTotal: ").Append(AdditionalFeeTotal).Append("\n");
            sb.Append("  AdjustmentTotal: ").Append(AdjustmentTotal).Append("\n");
            sb.Append("  BillingCurrency: ").Append(BillingCurrency).Append("\n");
            sb.Append("  CartType: ").Append(CartType).Append("\n");
            sb.Append("  CartVersion: ").Append(CartVersion).Append("\n");
            sb.Append("  Coupons: ").Append(Coupons).Append("\n");
            sb.Append("  CultureName: ").Append(CultureName).Append("\n");
            sb.Append("  Customer: ").Append(Customer).Append("\n");
            sb.Append("  CustomerId: ").Append(CustomerId).Append("\n");
            sb.Append("  DiscountTotal: ").Append(DiscountTotal).Append("\n");
            sb.Append("  FulfillmentCost: ").Append(FulfillmentCost).Append("\n");
            sb.Append("  FulfillmentCostWithoutDiscount: ").Append(FulfillmentCostWithoutDiscount).Append("\n");
            sb.Append("  FulfillmentLevelDiscountTotal: ").Append(FulfillmentLevelDiscountTotal).Append("\n");
            sb.Append("  ItemCount: ").Append(ItemCount).Append("\n");
            sb.Append("  LineItemLevelDiscount: ").Append(LineItemLevelDiscount).Append("\n");
            sb.Append("  LineItemsTotal: ").Append(LineItemsTotal).Append("\n");
            sb.Append("  LineItemsTotalWithoutDiscount: ").Append(LineItemsTotalWithoutDiscount).Append("\n");
            sb.Append("  MerchandiseTotal: ").Append(MerchandiseTotal).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  OrderLocation: ").Append(OrderLocation).Append("\n");
            sb.Append("  OriginalPromotions: ").Append(OriginalPromotions).Append("\n");
            sb.Append("  Payments: ").Append(Payments).Append("\n");
            sb.Append("  ScopeId: ").Append(ScopeId).Append("\n");
            sb.Append("  ShipmentLevelDiscountTotal: ").Append(ShipmentLevelDiscountTotal).Append("\n");
            sb.Append("  Shipments: ").Append(Shipments).Append("\n");
            sb.Append("  Source: ").Append(Source).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  SubTotal: ").Append(SubTotal).Append("\n");
            sb.Append("  SubTotalDiscount: ").Append(SubTotalDiscount).Append("\n");
            sb.Append("  TaxTotal: ").Append(TaxTotal).Append("\n");
            sb.Append("  Total: ").Append(Total).Append("\n");
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
            return this.Equals(input as Cart);
        }

        /// <summary>
        /// Returns true if Cart instances are equal
        /// </summary>
        /// <param name="input">Instance of Cart to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Cart input)
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
                    this.AdditionalFeeTotal == input.AdditionalFeeTotal ||
                    this.AdditionalFeeTotal.Equals(input.AdditionalFeeTotal)
                ) && 
                (
                    this.AdjustmentTotal == input.AdjustmentTotal ||
                    this.AdjustmentTotal.Equals(input.AdjustmentTotal)
                ) && 
                (
                    this.BillingCurrency == input.BillingCurrency ||
                    (this.BillingCurrency != null &&
                    this.BillingCurrency.Equals(input.BillingCurrency))
                ) && 
                (
                    this.CartType == input.CartType ||
                    (this.CartType != null &&
                    this.CartType.Equals(input.CartType))
                ) && 
                (
                    this.CartVersion == input.CartVersion ||
                    (this.CartVersion != null &&
                    this.CartVersion.Equals(input.CartVersion))
                ) && 
                (
                    this.Coupons == input.Coupons ||
                    this.Coupons != null &&
                    input.Coupons != null &&
                    this.Coupons.SequenceEqual(input.Coupons)
                ) && 
                (
                    this.CultureName == input.CultureName ||
                    (this.CultureName != null &&
                    this.CultureName.Equals(input.CultureName))
                ) && 
                (
                    this.Customer == input.Customer ||
                    (this.Customer != null &&
                    this.Customer.Equals(input.Customer))
                ) && 
                (
                    this.CustomerId == input.CustomerId ||
                    (this.CustomerId != null &&
                    this.CustomerId.Equals(input.CustomerId))
                ) && 
                (
                    this.DiscountTotal == input.DiscountTotal ||
                    this.DiscountTotal.Equals(input.DiscountTotal)
                ) && 
                (
                    this.FulfillmentCost == input.FulfillmentCost ||
                    this.FulfillmentCost.Equals(input.FulfillmentCost)
                ) && 
                (
                    this.FulfillmentCostWithoutDiscount == input.FulfillmentCostWithoutDiscount ||
                    this.FulfillmentCostWithoutDiscount.Equals(input.FulfillmentCostWithoutDiscount)
                ) && 
                (
                    this.FulfillmentLevelDiscountTotal == input.FulfillmentLevelDiscountTotal ||
                    this.FulfillmentLevelDiscountTotal.Equals(input.FulfillmentLevelDiscountTotal)
                ) && 
                (
                    this.ItemCount == input.ItemCount ||
                    this.ItemCount.Equals(input.ItemCount)
                ) && 
                (
                    this.LineItemLevelDiscount == input.LineItemLevelDiscount ||
                    this.LineItemLevelDiscount.Equals(input.LineItemLevelDiscount)
                ) && 
                (
                    this.LineItemsTotal == input.LineItemsTotal ||
                    this.LineItemsTotal.Equals(input.LineItemsTotal)
                ) && 
                (
                    this.LineItemsTotalWithoutDiscount == input.LineItemsTotalWithoutDiscount ||
                    this.LineItemsTotalWithoutDiscount.Equals(input.LineItemsTotalWithoutDiscount)
                ) && 
                (
                    this.MerchandiseTotal == input.MerchandiseTotal ||
                    this.MerchandiseTotal.Equals(input.MerchandiseTotal)
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.OrderLocation == input.OrderLocation ||
                    (this.OrderLocation != null &&
                    this.OrderLocation.Equals(input.OrderLocation))
                ) && 
                (
                    this.OriginalPromotions == input.OriginalPromotions ||
                    this.OriginalPromotions != null &&
                    input.OriginalPromotions != null &&
                    this.OriginalPromotions.SequenceEqual(input.OriginalPromotions)
                ) && 
                (
                    this.Payments == input.Payments ||
                    this.Payments != null &&
                    input.Payments != null &&
                    this.Payments.SequenceEqual(input.Payments)
                ) && 
                (
                    this.ScopeId == input.ScopeId ||
                    (this.ScopeId != null &&
                    this.ScopeId.Equals(input.ScopeId))
                ) && 
                (
                    this.ShipmentLevelDiscountTotal == input.ShipmentLevelDiscountTotal ||
                    this.ShipmentLevelDiscountTotal.Equals(input.ShipmentLevelDiscountTotal)
                ) && 
                (
                    this.Shipments == input.Shipments ||
                    this.Shipments != null &&
                    input.Shipments != null &&
                    this.Shipments.SequenceEqual(input.Shipments)
                ) && 
                (
                    this.Source == input.Source ||
                    (this.Source != null &&
                    this.Source.Equals(input.Source))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.SubTotal == input.SubTotal ||
                    this.SubTotal.Equals(input.SubTotal)
                ) && 
                (
                    this.SubTotalDiscount == input.SubTotalDiscount ||
                    this.SubTotalDiscount.Equals(input.SubTotalDiscount)
                ) && 
                (
                    this.TaxTotal == input.TaxTotal ||
                    this.TaxTotal.Equals(input.TaxTotal)
                ) && 
                (
                    this.Total == input.Total ||
                    this.Total.Equals(input.Total)
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
                if (this.Created != null)
                    hashCode = hashCode * 59 + this.Created.GetHashCode();
                if (this.CreatedBy != null)
                    hashCode = hashCode * 59 + this.CreatedBy.GetHashCode();
                if (this.LastModified != null)
                    hashCode = hashCode * 59 + this.LastModified.GetHashCode();
                if (this.LastModifiedBy != null)
                    hashCode = hashCode * 59 + this.LastModifiedBy.GetHashCode();
                hashCode = hashCode * 59 + this.AdditionalFeeTotal.GetHashCode();
                hashCode = hashCode * 59 + this.AdjustmentTotal.GetHashCode();
                if (this.BillingCurrency != null)
                    hashCode = hashCode * 59 + this.BillingCurrency.GetHashCode();
                if (this.CartType != null)
                    hashCode = hashCode * 59 + this.CartType.GetHashCode();
                if (this.CartVersion != null)
                    hashCode = hashCode * 59 + this.CartVersion.GetHashCode();
                if (this.Coupons != null)
                    hashCode = hashCode * 59 + this.Coupons.GetHashCode();
                if (this.CultureName != null)
                    hashCode = hashCode * 59 + this.CultureName.GetHashCode();
                if (this.Customer != null)
                    hashCode = hashCode * 59 + this.Customer.GetHashCode();
                if (this.CustomerId != null)
                    hashCode = hashCode * 59 + this.CustomerId.GetHashCode();
                hashCode = hashCode * 59 + this.DiscountTotal.GetHashCode();
                hashCode = hashCode * 59 + this.FulfillmentCost.GetHashCode();
                hashCode = hashCode * 59 + this.FulfillmentCostWithoutDiscount.GetHashCode();
                hashCode = hashCode * 59 + this.FulfillmentLevelDiscountTotal.GetHashCode();
                hashCode = hashCode * 59 + this.ItemCount.GetHashCode();
                hashCode = hashCode * 59 + this.LineItemLevelDiscount.GetHashCode();
                hashCode = hashCode * 59 + this.LineItemsTotal.GetHashCode();
                hashCode = hashCode * 59 + this.LineItemsTotalWithoutDiscount.GetHashCode();
                hashCode = hashCode * 59 + this.MerchandiseTotal.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.OrderLocation != null)
                    hashCode = hashCode * 59 + this.OrderLocation.GetHashCode();
                if (this.OriginalPromotions != null)
                    hashCode = hashCode * 59 + this.OriginalPromotions.GetHashCode();
                if (this.Payments != null)
                    hashCode = hashCode * 59 + this.Payments.GetHashCode();
                if (this.ScopeId != null)
                    hashCode = hashCode * 59 + this.ScopeId.GetHashCode();
                hashCode = hashCode * 59 + this.ShipmentLevelDiscountTotal.GetHashCode();
                if (this.Shipments != null)
                    hashCode = hashCode * 59 + this.Shipments.GetHashCode();
                if (this.Source != null)
                    hashCode = hashCode * 59 + this.Source.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                hashCode = hashCode * 59 + this.SubTotal.GetHashCode();
                hashCode = hashCode * 59 + this.SubTotalDiscount.GetHashCode();
                hashCode = hashCode * 59 + this.TaxTotal.GetHashCode();
                hashCode = hashCode * 59 + this.Total.GetHashCode();
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
