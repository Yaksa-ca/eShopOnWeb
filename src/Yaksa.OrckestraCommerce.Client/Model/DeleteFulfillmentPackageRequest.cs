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
    /// API calls used during the fulfillment process.
    /// </summary>
    [DataContract(Name = "DeleteFulfillmentPackageRequest")]
    public partial class DeleteFulfillmentPackageRequest : IEquatable<DeleteFulfillmentPackageRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteFulfillmentPackageRequest" /> class.
        /// </summary>
        /// <param name="id">The fulfillment package id..</param>
        /// <param name="scopeId">The scope identifier..</param>
        public DeleteFulfillmentPackageRequest(string id = default(string), string scopeId = default(string))
        {
            this.Id = id;
            this.ScopeId = scopeId;
        }

        /// <summary>
        /// The fulfillment package id.
        /// </summary>
        /// <value>The fulfillment package id.</value>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        /// The scope identifier.
        /// </summary>
        /// <value>The scope identifier.</value>
        [DataMember(Name = "scopeId", EmitDefaultValue = false)]
        public string ScopeId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DeleteFulfillmentPackageRequest {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  ScopeId: ").Append(ScopeId).Append("\n");
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
            return this.Equals(input as DeleteFulfillmentPackageRequest);
        }

        /// <summary>
        /// Returns true if DeleteFulfillmentPackageRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of DeleteFulfillmentPackageRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DeleteFulfillmentPackageRequest input)
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
                    this.ScopeId == input.ScopeId ||
                    (this.ScopeId != null &&
                    this.ScopeId.Equals(input.ScopeId))
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
                if (this.ScopeId != null)
                    hashCode = hashCode * 59 + this.ScopeId.GetHashCode();
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
