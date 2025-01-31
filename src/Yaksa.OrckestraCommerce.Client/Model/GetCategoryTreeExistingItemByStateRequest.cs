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
    /// Categories are entities which represents a classification of products.
    /// </summary>
    [DataContract(Name = "GetCategoryTreeExistingItemByStateRequest")]
    public partial class GetCategoryTreeExistingItemByStateRequest : IEquatable<GetCategoryTreeExistingItemByStateRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetCategoryTreeExistingItemByStateRequest" /> class.
        /// </summary>
        /// <param name="scopeId">The id of the requested scope.</param>
        /// <param name="cultureName">The culture in which the data will be returned.</param>
        /// <param name="draftState">The draft state used to filter the products.</param>
        /// <param name="hasNotification">The flag to get only or not products with change notification.</param>
        /// <param name="isNew">The flag to get only new or not new products.</param>
        public GetCategoryTreeExistingItemByStateRequest(string scopeId = default(string), string cultureName = default(string), string draftState = default(string), bool hasNotification = default(bool), bool isNew = default(bool))
        {
            this.ScopeId = scopeId;
            this.CultureName = cultureName;
            this.DraftState = draftState;
            this.HasNotification = hasNotification;
            this.IsNew = isNew;
        }

        /// <summary>
        /// The id of the requested scope
        /// </summary>
        /// <value>The id of the requested scope</value>
        [DataMember(Name = "scopeId", EmitDefaultValue = false)]
        public string ScopeId { get; set; }

        /// <summary>
        /// The culture in which the data will be returned
        /// </summary>
        /// <value>The culture in which the data will be returned</value>
        [DataMember(Name = "cultureName", EmitDefaultValue = false)]
        public string CultureName { get; set; }

        /// <summary>
        /// The draft state used to filter the products
        /// </summary>
        /// <value>The draft state used to filter the products</value>
        [DataMember(Name = "draftState", EmitDefaultValue = false)]
        public string DraftState { get; set; }

        /// <summary>
        /// The flag to get only or not products with change notification
        /// </summary>
        /// <value>The flag to get only or not products with change notification</value>
        [DataMember(Name = "hasNotification", EmitDefaultValue = true)]
        public bool HasNotification { get; set; }

        /// <summary>
        /// The flag to get only new or not new products
        /// </summary>
        /// <value>The flag to get only new or not new products</value>
        [DataMember(Name = "isNew", EmitDefaultValue = true)]
        public bool IsNew { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GetCategoryTreeExistingItemByStateRequest {\n");
            sb.Append("  ScopeId: ").Append(ScopeId).Append("\n");
            sb.Append("  CultureName: ").Append(CultureName).Append("\n");
            sb.Append("  DraftState: ").Append(DraftState).Append("\n");
            sb.Append("  HasNotification: ").Append(HasNotification).Append("\n");
            sb.Append("  IsNew: ").Append(IsNew).Append("\n");
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
            return this.Equals(input as GetCategoryTreeExistingItemByStateRequest);
        }

        /// <summary>
        /// Returns true if GetCategoryTreeExistingItemByStateRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of GetCategoryTreeExistingItemByStateRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetCategoryTreeExistingItemByStateRequest input)
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
                    this.CultureName == input.CultureName ||
                    (this.CultureName != null &&
                    this.CultureName.Equals(input.CultureName))
                ) && 
                (
                    this.DraftState == input.DraftState ||
                    (this.DraftState != null &&
                    this.DraftState.Equals(input.DraftState))
                ) && 
                (
                    this.HasNotification == input.HasNotification ||
                    this.HasNotification.Equals(input.HasNotification)
                ) && 
                (
                    this.IsNew == input.IsNew ||
                    this.IsNew.Equals(input.IsNew)
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
                if (this.CultureName != null)
                    hashCode = hashCode * 59 + this.CultureName.GetHashCode();
                if (this.DraftState != null)
                    hashCode = hashCode * 59 + this.DraftState.GetHashCode();
                hashCode = hashCode * 59 + this.HasNotification.GetHashCode();
                hashCode = hashCode * 59 + this.IsNew.GetHashCode();
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
