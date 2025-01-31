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
    /// Carts are entities used for assembling an order before submitting.
    /// </summary>
    [DataContract(Name = "UpdateCartRequest")]
    public partial class UpdateCartRequest : IEquatable<UpdateCartRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateCartRequest" /> class.
        /// </summary>
        /// <param name="cultureName">The culture name in which language the data will be returned..</param>
        /// <param name="workflowToExecute">The name of the workflow that should be executed..</param>
        /// <param name="billingCurrency">the currency ISO code under which the items are sold &#39;Currency.IsoCode&#39;..</param>
        /// <param name="cartType">the cart type, according to the CartType lookup..</param>
        /// <param name="coupons">the collection of coupon codes included in the order..</param>
        /// <param name="customer">customer.</param>
        /// <param name="executeWorkflow">Whether or not to execute the specified workflow before returning the cart..</param>
        /// <param name="orderLocation">orderLocation.</param>
        /// <param name="payments">The collection of payments to use for this order..</param>
        /// <param name="propertyBag">propertyBag.</param>
        /// <param name="shipments">the collection of shipments associated to this order..</param>
        /// <param name="source">the cart source..</param>
        /// <param name="status">the status of the cart..</param>
        public UpdateCartRequest(string cultureName = default(string), string workflowToExecute = default(string), string billingCurrency = default(string), string cartType = default(string), List<Coupon> coupons = default(List<Coupon>), CustomerSummary customer = default(CustomerSummary), bool executeWorkflow = default(bool), OrderLocationSummary orderLocation = default(OrderLocationSummary), List<Payment> payments = default(List<Payment>), Dictionary<string, Object> propertyBag = default(Dictionary<string, Object>), List<Shipment> shipments = default(List<Shipment>), string source = default(string), string status = default(string))
        {
            this.CultureName = cultureName;
            this.WorkflowToExecute = workflowToExecute;
            this.BillingCurrency = billingCurrency;
            this.CartType = cartType;
            this.Coupons = coupons;
            this.Customer = customer;
            this.ExecuteWorkflow = executeWorkflow;
            this.OrderLocation = orderLocation;
            this.Payments = payments;
            this.PropertyBag = propertyBag;
            this.Shipments = shipments;
            this.Source = source;
            this.Status = status;
        }

        /// <summary>
        /// The culture name in which language the data will be returned.
        /// </summary>
        /// <value>The culture name in which language the data will be returned.</value>
        [DataMember(Name = "cultureName", EmitDefaultValue = false)]
        public string CultureName { get; set; }

        /// <summary>
        /// The name of the workflow that should be executed.
        /// </summary>
        /// <value>The name of the workflow that should be executed.</value>
        [DataMember(Name = "workflowToExecute", EmitDefaultValue = false)]
        public string WorkflowToExecute { get; set; }

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
        /// the collection of coupon codes included in the order.
        /// </summary>
        /// <value>the collection of coupon codes included in the order.</value>
        [DataMember(Name = "coupons", EmitDefaultValue = false)]
        public List<Coupon> Coupons { get; set; }

        /// <summary>
        /// Gets or Sets Customer
        /// </summary>
        [DataMember(Name = "customer", EmitDefaultValue = false)]
        public CustomerSummary Customer { get; set; }

        /// <summary>
        /// Whether or not to execute the specified workflow before returning the cart.
        /// </summary>
        /// <value>Whether or not to execute the specified workflow before returning the cart.</value>
        [DataMember(Name = "executeWorkflow", EmitDefaultValue = true)]
        public bool ExecuteWorkflow { get; set; }

        /// <summary>
        /// Gets or Sets OrderLocation
        /// </summary>
        [DataMember(Name = "orderLocation", EmitDefaultValue = false)]
        public OrderLocationSummary OrderLocation { get; set; }

        /// <summary>
        /// The collection of payments to use for this order.
        /// </summary>
        /// <value>The collection of payments to use for this order.</value>
        [DataMember(Name = "payments", EmitDefaultValue = false)]
        public List<Payment> Payments { get; set; }

        /// <summary>
        /// Gets or Sets PropertyBag
        /// </summary>
        [DataMember(Name = "propertyBag", EmitDefaultValue = false)]
        public Dictionary<string, Object> PropertyBag { get; set; }

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
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateCartRequest {\n");
            sb.Append("  CultureName: ").Append(CultureName).Append("\n");
            sb.Append("  WorkflowToExecute: ").Append(WorkflowToExecute).Append("\n");
            sb.Append("  BillingCurrency: ").Append(BillingCurrency).Append("\n");
            sb.Append("  CartType: ").Append(CartType).Append("\n");
            sb.Append("  Coupons: ").Append(Coupons).Append("\n");
            sb.Append("  Customer: ").Append(Customer).Append("\n");
            sb.Append("  ExecuteWorkflow: ").Append(ExecuteWorkflow).Append("\n");
            sb.Append("  OrderLocation: ").Append(OrderLocation).Append("\n");
            sb.Append("  Payments: ").Append(Payments).Append("\n");
            sb.Append("  PropertyBag: ").Append(PropertyBag).Append("\n");
            sb.Append("  Shipments: ").Append(Shipments).Append("\n");
            sb.Append("  Source: ").Append(Source).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
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
            return this.Equals(input as UpdateCartRequest);
        }

        /// <summary>
        /// Returns true if UpdateCartRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of UpdateCartRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UpdateCartRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CultureName == input.CultureName ||
                    (this.CultureName != null &&
                    this.CultureName.Equals(input.CultureName))
                ) && 
                (
                    this.WorkflowToExecute == input.WorkflowToExecute ||
                    (this.WorkflowToExecute != null &&
                    this.WorkflowToExecute.Equals(input.WorkflowToExecute))
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
                    this.Coupons == input.Coupons ||
                    this.Coupons != null &&
                    input.Coupons != null &&
                    this.Coupons.SequenceEqual(input.Coupons)
                ) && 
                (
                    this.Customer == input.Customer ||
                    (this.Customer != null &&
                    this.Customer.Equals(input.Customer))
                ) && 
                (
                    this.ExecuteWorkflow == input.ExecuteWorkflow ||
                    this.ExecuteWorkflow.Equals(input.ExecuteWorkflow)
                ) && 
                (
                    this.OrderLocation == input.OrderLocation ||
                    (this.OrderLocation != null &&
                    this.OrderLocation.Equals(input.OrderLocation))
                ) && 
                (
                    this.Payments == input.Payments ||
                    this.Payments != null &&
                    input.Payments != null &&
                    this.Payments.SequenceEqual(input.Payments)
                ) && 
                (
                    this.PropertyBag == input.PropertyBag ||
                    this.PropertyBag != null &&
                    input.PropertyBag != null &&
                    this.PropertyBag.SequenceEqual(input.PropertyBag)
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
                if (this.CultureName != null)
                    hashCode = hashCode * 59 + this.CultureName.GetHashCode();
                if (this.WorkflowToExecute != null)
                    hashCode = hashCode * 59 + this.WorkflowToExecute.GetHashCode();
                if (this.BillingCurrency != null)
                    hashCode = hashCode * 59 + this.BillingCurrency.GetHashCode();
                if (this.CartType != null)
                    hashCode = hashCode * 59 + this.CartType.GetHashCode();
                if (this.Coupons != null)
                    hashCode = hashCode * 59 + this.Coupons.GetHashCode();
                if (this.Customer != null)
                    hashCode = hashCode * 59 + this.Customer.GetHashCode();
                hashCode = hashCode * 59 + this.ExecuteWorkflow.GetHashCode();
                if (this.OrderLocation != null)
                    hashCode = hashCode * 59 + this.OrderLocation.GetHashCode();
                if (this.Payments != null)
                    hashCode = hashCode * 59 + this.Payments.GetHashCode();
                if (this.PropertyBag != null)
                    hashCode = hashCode * 59 + this.PropertyBag.GetHashCode();
                if (this.Shipments != null)
                    hashCode = hashCode * 59 + this.Shipments.GetHashCode();
                if (this.Source != null)
                    hashCode = hashCode * 59 + this.Source.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
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
