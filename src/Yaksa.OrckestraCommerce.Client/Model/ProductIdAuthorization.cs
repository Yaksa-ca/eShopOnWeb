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
    /// ProductIdAuthorization
    /// </summary>
    [DataContract(Name = "ProductIdAuthorization")]
    public partial class ProductIdAuthorization : IEquatable<ProductIdAuthorization>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProductIdAuthorization" /> class.
        /// </summary>
        /// <param name="productID">The ID of the product the authorization is about.</param>
        /// <param name="status">The status of the product authorization.</param>
        /// <param name="expiryDate">The date an Authorized product authorization expires.</param>
        public ProductIdAuthorization(string productID = default(string), string status = default(string), DateTime expiryDate = default(DateTime))
        {
            this.ProductID = productID;
            this.Status = status;
            this.ExpiryDate = expiryDate;
        }

        /// <summary>
        /// The ID of the product the authorization is about
        /// </summary>
        /// <value>The ID of the product the authorization is about</value>
        [DataMember(Name = "productID", EmitDefaultValue = false)]
        public string ProductID { get; set; }

        /// <summary>
        /// The status of the product authorization
        /// </summary>
        /// <value>The status of the product authorization</value>
        [DataMember(Name = "status", EmitDefaultValue = false)]
        public string Status { get; set; }

        /// <summary>
        /// The date an Authorized product authorization expires
        /// </summary>
        /// <value>The date an Authorized product authorization expires</value>
        [DataMember(Name = "expiryDate", EmitDefaultValue = false)]
        public DateTime ExpiryDate { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ProductIdAuthorization {\n");
            sb.Append("  ProductID: ").Append(ProductID).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  ExpiryDate: ").Append(ExpiryDate).Append("\n");
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
            return this.Equals(input as ProductIdAuthorization);
        }

        /// <summary>
        /// Returns true if ProductIdAuthorization instances are equal
        /// </summary>
        /// <param name="input">Instance of ProductIdAuthorization to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ProductIdAuthorization input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ProductID == input.ProductID ||
                    (this.ProductID != null &&
                    this.ProductID.Equals(input.ProductID))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.ExpiryDate == input.ExpiryDate ||
                    (this.ExpiryDate != null &&
                    this.ExpiryDate.Equals(input.ExpiryDate))
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
                if (this.ProductID != null)
                    hashCode = hashCode * 59 + this.ProductID.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.ExpiryDate != null)
                    hashCode = hashCode * 59 + this.ExpiryDate.GetHashCode();
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
