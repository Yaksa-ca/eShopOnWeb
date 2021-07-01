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
    /// Order
    /// </summary>
    [DataContract(Name = "Order")]
    public partial class Order : IEquatable<Order>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Order" /> class.
        /// </summary>
        /// <param name="cart">cart.</param>
        /// <param name="created">the date when the order as created..</param>
        /// <param name="createdBy">the user id of the user that created the order..</param>
        /// <param name="customerId">the customer id who made the order..</param>
        /// <param name="customerName">the complete name of the customer who made the order..</param>
        /// <param name="id">the id of the order..</param>
        /// <param name="itemCount">the line item count..</param>
        /// <param name="lastModified">the date when the order was last modified..</param>
        /// <param name="lastModifiedBy">the user id of the user that last modified the order..</param>
        /// <param name="orderNumber">the order number..</param>
        /// <param name="orderStatus">the order status..</param>
        /// <param name="scopeId">the scope id..</param>
        /// <param name="source">the source of the order..</param>
        /// <param name="transactionOrderNumber">the transaction order number..</param>
        public Order(Cart cart = default(Cart), DateTime created = default(DateTime), string createdBy = default(string), string customerId = default(string), string customerName = default(string), string id = default(string), int itemCount = default(int), DateTime lastModified = default(DateTime), string lastModifiedBy = default(string), string orderNumber = default(string), string orderStatus = default(string), string scopeId = default(string), string source = default(string), int transactionOrderNumber = default(int))
        {
            this.Cart = cart;
            this.Created = created;
            this.CreatedBy = createdBy;
            this.CustomerId = customerId;
            this.CustomerName = customerName;
            this.Id = id;
            this.ItemCount = itemCount;
            this.LastModified = lastModified;
            this.LastModifiedBy = lastModifiedBy;
            this.OrderNumber = orderNumber;
            this.OrderStatus = orderStatus;
            this.ScopeId = scopeId;
            this.Source = source;
            this.TransactionOrderNumber = transactionOrderNumber;
        }

        /// <summary>
        /// Gets or Sets Cart
        /// </summary>
        [DataMember(Name = "cart", EmitDefaultValue = false)]
        public Cart Cart { get; set; }

        /// <summary>
        /// the date when the order as created.
        /// </summary>
        /// <value>the date when the order as created.</value>
        [DataMember(Name = "created", EmitDefaultValue = false)]
        public DateTime Created { get; set; }

        /// <summary>
        /// the user id of the user that created the order.
        /// </summary>
        /// <value>the user id of the user that created the order.</value>
        [DataMember(Name = "createdBy", EmitDefaultValue = false)]
        public string CreatedBy { get; set; }

        /// <summary>
        /// the customer id who made the order.
        /// </summary>
        /// <value>the customer id who made the order.</value>
        [DataMember(Name = "customerId", EmitDefaultValue = false)]
        public string CustomerId { get; set; }

        /// <summary>
        /// the complete name of the customer who made the order.
        /// </summary>
        /// <value>the complete name of the customer who made the order.</value>
        [DataMember(Name = "customerName", EmitDefaultValue = false)]
        public string CustomerName { get; set; }

        /// <summary>
        /// the id of the order.
        /// </summary>
        /// <value>the id of the order.</value>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        /// the line item count.
        /// </summary>
        /// <value>the line item count.</value>
        [DataMember(Name = "itemCount", EmitDefaultValue = false)]
        public int ItemCount { get; set; }

        /// <summary>
        /// the date when the order was last modified.
        /// </summary>
        /// <value>the date when the order was last modified.</value>
        [DataMember(Name = "lastModified", EmitDefaultValue = false)]
        public DateTime LastModified { get; set; }

        /// <summary>
        /// the user id of the user that last modified the order.
        /// </summary>
        /// <value>the user id of the user that last modified the order.</value>
        [DataMember(Name = "lastModifiedBy", EmitDefaultValue = false)]
        public string LastModifiedBy { get; set; }

        /// <summary>
        /// the order number.
        /// </summary>
        /// <value>the order number.</value>
        [DataMember(Name = "orderNumber", EmitDefaultValue = false)]
        public string OrderNumber { get; set; }

        /// <summary>
        /// the order status.
        /// </summary>
        /// <value>the order status.</value>
        [DataMember(Name = "orderStatus", EmitDefaultValue = false)]
        public string OrderStatus { get; set; }

        /// <summary>
        /// the scope id.
        /// </summary>
        /// <value>the scope id.</value>
        [DataMember(Name = "scopeId", EmitDefaultValue = false)]
        public string ScopeId { get; set; }

        /// <summary>
        /// the source of the order.
        /// </summary>
        /// <value>the source of the order.</value>
        [DataMember(Name = "source", EmitDefaultValue = false)]
        public string Source { get; set; }

        /// <summary>
        /// the transaction order number.
        /// </summary>
        /// <value>the transaction order number.</value>
        [DataMember(Name = "transactionOrderNumber", EmitDefaultValue = false)]
        public int TransactionOrderNumber { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Order {\n");
            sb.Append("  Cart: ").Append(Cart).Append("\n");
            sb.Append("  Created: ").Append(Created).Append("\n");
            sb.Append("  CreatedBy: ").Append(CreatedBy).Append("\n");
            sb.Append("  CustomerId: ").Append(CustomerId).Append("\n");
            sb.Append("  CustomerName: ").Append(CustomerName).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  ItemCount: ").Append(ItemCount).Append("\n");
            sb.Append("  LastModified: ").Append(LastModified).Append("\n");
            sb.Append("  LastModifiedBy: ").Append(LastModifiedBy).Append("\n");
            sb.Append("  OrderNumber: ").Append(OrderNumber).Append("\n");
            sb.Append("  OrderStatus: ").Append(OrderStatus).Append("\n");
            sb.Append("  ScopeId: ").Append(ScopeId).Append("\n");
            sb.Append("  Source: ").Append(Source).Append("\n");
            sb.Append("  TransactionOrderNumber: ").Append(TransactionOrderNumber).Append("\n");
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
            return this.Equals(input as Order);
        }

        /// <summary>
        /// Returns true if Order instances are equal
        /// </summary>
        /// <param name="input">Instance of Order to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Order input)
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
                    this.CustomerId == input.CustomerId ||
                    (this.CustomerId != null &&
                    this.CustomerId.Equals(input.CustomerId))
                ) && 
                (
                    this.CustomerName == input.CustomerName ||
                    (this.CustomerName != null &&
                    this.CustomerName.Equals(input.CustomerName))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.ItemCount == input.ItemCount ||
                    this.ItemCount.Equals(input.ItemCount)
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
                    this.OrderNumber == input.OrderNumber ||
                    (this.OrderNumber != null &&
                    this.OrderNumber.Equals(input.OrderNumber))
                ) && 
                (
                    this.OrderStatus == input.OrderStatus ||
                    (this.OrderStatus != null &&
                    this.OrderStatus.Equals(input.OrderStatus))
                ) && 
                (
                    this.ScopeId == input.ScopeId ||
                    (this.ScopeId != null &&
                    this.ScopeId.Equals(input.ScopeId))
                ) && 
                (
                    this.Source == input.Source ||
                    (this.Source != null &&
                    this.Source.Equals(input.Source))
                ) && 
                (
                    this.TransactionOrderNumber == input.TransactionOrderNumber ||
                    this.TransactionOrderNumber.Equals(input.TransactionOrderNumber)
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
                if (this.Created != null)
                    hashCode = hashCode * 59 + this.Created.GetHashCode();
                if (this.CreatedBy != null)
                    hashCode = hashCode * 59 + this.CreatedBy.GetHashCode();
                if (this.CustomerId != null)
                    hashCode = hashCode * 59 + this.CustomerId.GetHashCode();
                if (this.CustomerName != null)
                    hashCode = hashCode * 59 + this.CustomerName.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                hashCode = hashCode * 59 + this.ItemCount.GetHashCode();
                if (this.LastModified != null)
                    hashCode = hashCode * 59 + this.LastModified.GetHashCode();
                if (this.LastModifiedBy != null)
                    hashCode = hashCode * 59 + this.LastModifiedBy.GetHashCode();
                if (this.OrderNumber != null)
                    hashCode = hashCode * 59 + this.OrderNumber.GetHashCode();
                if (this.OrderStatus != null)
                    hashCode = hashCode * 59 + this.OrderStatus.GetHashCode();
                if (this.ScopeId != null)
                    hashCode = hashCode * 59 + this.ScopeId.GetHashCode();
                if (this.Source != null)
                    hashCode = hashCode * 59 + this.Source.GetHashCode();
                hashCode = hashCode * 59 + this.TransactionOrderNumber.GetHashCode();
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
