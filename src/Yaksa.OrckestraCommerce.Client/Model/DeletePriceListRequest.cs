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
    /// Products are entities which represents a buyable item managed in a catalog.
    /// </summary>
    [DataContract(Name = "DeletePriceListRequest")]
    public partial class DeletePriceListRequest : IEquatable<DeletePriceListRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DeletePriceListRequest" /> class.
        /// </summary>
        /// <param name="scopeId">The id of the requested scope.</param>
        /// <param name="deletePriceListEntries">The value indicating whether the related price list entries should be deleted as well..</param>
        /// <param name="priceListId">The identifier of the price list..</param>
        public DeletePriceListRequest(string scopeId = default(string), bool deletePriceListEntries = default(bool), string priceListId = default(string))
        {
            this.ScopeId = scopeId;
            this.DeletePriceListEntries = deletePriceListEntries;
            this.PriceListId = priceListId;
        }

        /// <summary>
        /// The id of the requested scope
        /// </summary>
        /// <value>The id of the requested scope</value>
        [DataMember(Name = "scopeId", EmitDefaultValue = false)]
        public string ScopeId { get; set; }

        /// <summary>
        /// The value indicating whether the related price list entries should be deleted as well.
        /// </summary>
        /// <value>The value indicating whether the related price list entries should be deleted as well.</value>
        [DataMember(Name = "deletePriceListEntries", EmitDefaultValue = true)]
        public bool DeletePriceListEntries { get; set; }

        /// <summary>
        /// The identifier of the price list.
        /// </summary>
        /// <value>The identifier of the price list.</value>
        [DataMember(Name = "priceListId", EmitDefaultValue = false)]
        public string PriceListId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DeletePriceListRequest {\n");
            sb.Append("  ScopeId: ").Append(ScopeId).Append("\n");
            sb.Append("  DeletePriceListEntries: ").Append(DeletePriceListEntries).Append("\n");
            sb.Append("  PriceListId: ").Append(PriceListId).Append("\n");
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
            return this.Equals(input as DeletePriceListRequest);
        }

        /// <summary>
        /// Returns true if DeletePriceListRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of DeletePriceListRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DeletePriceListRequest input)
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
                    this.DeletePriceListEntries == input.DeletePriceListEntries ||
                    this.DeletePriceListEntries.Equals(input.DeletePriceListEntries)
                ) && 
                (
                    this.PriceListId == input.PriceListId ||
                    (this.PriceListId != null &&
                    this.PriceListId.Equals(input.PriceListId))
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
                hashCode = hashCode * 59 + this.DeletePriceListEntries.GetHashCode();
                if (this.PriceListId != null)
                    hashCode = hashCode * 59 + this.PriceListId.GetHashCode();
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
