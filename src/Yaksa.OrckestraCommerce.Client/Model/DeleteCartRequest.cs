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
    [DataContract(Name = "DeleteCartRequest")]
    public partial class DeleteCartRequest : IEquatable<DeleteCartRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteCartRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected DeleteCartRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteCartRequest" /> class.
        /// </summary>
        /// <param name="scopeId">The id of the requested scope.</param>
        /// <param name="cartName">The name associated to the requested cart (required).</param>
        /// <param name="cultureName">The culture name in which language the data will be returned..</param>
        /// <param name="customerId">The unique identifier of the Customer owning the cart (required).</param>
        public DeleteCartRequest(string scopeId = default(string), string cartName = default(string), string cultureName = default(string), string customerId = default(string))
        {
            // to ensure "cartName" is required (not null)
            this.CartName = cartName ?? throw new ArgumentNullException("cartName is a required property for DeleteCartRequest and cannot be null");
            // to ensure "customerId" is required (not null)
            this.CustomerId = customerId ?? throw new ArgumentNullException("customerId is a required property for DeleteCartRequest and cannot be null");
            this.ScopeId = scopeId;
            this.CultureName = cultureName;
        }

        /// <summary>
        /// The id of the requested scope
        /// </summary>
        /// <value>The id of the requested scope</value>
        [DataMember(Name = "scopeId", EmitDefaultValue = false)]
        public string ScopeId { get; set; }

        /// <summary>
        /// The name associated to the requested cart
        /// </summary>
        /// <value>The name associated to the requested cart</value>
        [DataMember(Name = "cartName", IsRequired = true, EmitDefaultValue = false)]
        public string CartName { get; set; }

        /// <summary>
        /// The culture name in which language the data will be returned.
        /// </summary>
        /// <value>The culture name in which language the data will be returned.</value>
        [DataMember(Name = "cultureName", EmitDefaultValue = false)]
        public string CultureName { get; set; }

        /// <summary>
        /// The unique identifier of the Customer owning the cart
        /// </summary>
        /// <value>The unique identifier of the Customer owning the cart</value>
        [DataMember(Name = "customerId", IsRequired = true, EmitDefaultValue = false)]
        public string CustomerId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DeleteCartRequest {\n");
            sb.Append("  ScopeId: ").Append(ScopeId).Append("\n");
            sb.Append("  CartName: ").Append(CartName).Append("\n");
            sb.Append("  CultureName: ").Append(CultureName).Append("\n");
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
            return this.Equals(input as DeleteCartRequest);
        }

        /// <summary>
        /// Returns true if DeleteCartRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of DeleteCartRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DeleteCartRequest input)
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
                    this.CartName == input.CartName ||
                    (this.CartName != null &&
                    this.CartName.Equals(input.CartName))
                ) && 
                (
                    this.CultureName == input.CultureName ||
                    (this.CultureName != null &&
                    this.CultureName.Equals(input.CultureName))
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
                if (this.ScopeId != null)
                    hashCode = hashCode * 59 + this.ScopeId.GetHashCode();
                if (this.CartName != null)
                    hashCode = hashCode * 59 + this.CartName.GetHashCode();
                if (this.CultureName != null)
                    hashCode = hashCode * 59 + this.CultureName.GetHashCode();
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
