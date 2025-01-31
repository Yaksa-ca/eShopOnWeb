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
    /// FulfillmentProviderInfo
    /// </summary>
    [DataContract(Name = "FulfillmentProviderInfo")]
    public partial class FulfillmentProviderInfo : IEquatable<FulfillmentProviderInfo>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FulfillmentProviderInfo" /> class.
        /// </summary>
        /// <param name="availableFulfillmentMethodTypes">the available fulfillment method types for this provider.</param>
        /// <param name="description">the description for this provider.</param>
        /// <param name="displayName">displayName.</param>
        /// <param name="id">the unique identifier for this provider.</param>
        /// <param name="implementationTypeName">the implementation type name of this provider.</param>
        /// <param name="isActive">a value indicating whether this provider is currently enabled and can be used.</param>
        /// <param name="name">the name for this provider.</param>
        /// <param name="propertyBag">propertyBag.</param>
        /// <param name="scopeId">the scope for this provider.</param>
        /// <param name="taxCategoryId">the tax category identifier for this provider.</param>
        public FulfillmentProviderInfo(List<string> availableFulfillmentMethodTypes = default(List<string>), string description = default(string), Dictionary<string, string> displayName = default(Dictionary<string, string>), string id = default(string), string implementationTypeName = default(string), bool isActive = default(bool), string name = default(string), Dictionary<string, Object> propertyBag = default(Dictionary<string, Object>), string scopeId = default(string), string taxCategoryId = default(string))
        {
            this.AvailableFulfillmentMethodTypes = availableFulfillmentMethodTypes;
            this.Description = description;
            this.DisplayName = displayName;
            this.Id = id;
            this.ImplementationTypeName = implementationTypeName;
            this.IsActive = isActive;
            this.Name = name;
            this.PropertyBag = propertyBag;
            this.ScopeId = scopeId;
            this.TaxCategoryId = taxCategoryId;
        }

        /// <summary>
        /// the available fulfillment method types for this provider
        /// </summary>
        /// <value>the available fulfillment method types for this provider</value>
        [DataMember(Name = "availableFulfillmentMethodTypes", EmitDefaultValue = false)]
        public List<string> AvailableFulfillmentMethodTypes { get; set; }

        /// <summary>
        /// the description for this provider
        /// </summary>
        /// <value>the description for this provider</value>
        [DataMember(Name = "description", EmitDefaultValue = false)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets DisplayName
        /// </summary>
        [DataMember(Name = "displayName", EmitDefaultValue = false)]
        public Dictionary<string, string> DisplayName { get; set; }

        /// <summary>
        /// the unique identifier for this provider
        /// </summary>
        /// <value>the unique identifier for this provider</value>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        /// the implementation type name of this provider
        /// </summary>
        /// <value>the implementation type name of this provider</value>
        [DataMember(Name = "implementationTypeName", EmitDefaultValue = false)]
        public string ImplementationTypeName { get; set; }

        /// <summary>
        /// a value indicating whether this provider is currently enabled and can be used
        /// </summary>
        /// <value>a value indicating whether this provider is currently enabled and can be used</value>
        [DataMember(Name = "isActive", EmitDefaultValue = true)]
        public bool IsActive { get; set; }

        /// <summary>
        /// the name for this provider
        /// </summary>
        /// <value>the name for this provider</value>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets PropertyBag
        /// </summary>
        [DataMember(Name = "propertyBag", EmitDefaultValue = false)]
        public Dictionary<string, Object> PropertyBag { get; set; }

        /// <summary>
        /// the scope for this provider
        /// </summary>
        /// <value>the scope for this provider</value>
        [DataMember(Name = "scopeId", EmitDefaultValue = false)]
        public string ScopeId { get; set; }

        /// <summary>
        /// the tax category identifier for this provider
        /// </summary>
        /// <value>the tax category identifier for this provider</value>
        [DataMember(Name = "taxCategoryId", EmitDefaultValue = false)]
        public string TaxCategoryId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FulfillmentProviderInfo {\n");
            sb.Append("  AvailableFulfillmentMethodTypes: ").Append(AvailableFulfillmentMethodTypes).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  ImplementationTypeName: ").Append(ImplementationTypeName).Append("\n");
            sb.Append("  IsActive: ").Append(IsActive).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  PropertyBag: ").Append(PropertyBag).Append("\n");
            sb.Append("  ScopeId: ").Append(ScopeId).Append("\n");
            sb.Append("  TaxCategoryId: ").Append(TaxCategoryId).Append("\n");
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
            return this.Equals(input as FulfillmentProviderInfo);
        }

        /// <summary>
        /// Returns true if FulfillmentProviderInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of FulfillmentProviderInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FulfillmentProviderInfo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AvailableFulfillmentMethodTypes == input.AvailableFulfillmentMethodTypes ||
                    this.AvailableFulfillmentMethodTypes != null &&
                    input.AvailableFulfillmentMethodTypes != null &&
                    this.AvailableFulfillmentMethodTypes.SequenceEqual(input.AvailableFulfillmentMethodTypes)
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.DisplayName == input.DisplayName ||
                    this.DisplayName != null &&
                    input.DisplayName != null &&
                    this.DisplayName.SequenceEqual(input.DisplayName)
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.ImplementationTypeName == input.ImplementationTypeName ||
                    (this.ImplementationTypeName != null &&
                    this.ImplementationTypeName.Equals(input.ImplementationTypeName))
                ) && 
                (
                    this.IsActive == input.IsActive ||
                    this.IsActive.Equals(input.IsActive)
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.PropertyBag == input.PropertyBag ||
                    this.PropertyBag != null &&
                    input.PropertyBag != null &&
                    this.PropertyBag.SequenceEqual(input.PropertyBag)
                ) && 
                (
                    this.ScopeId == input.ScopeId ||
                    (this.ScopeId != null &&
                    this.ScopeId.Equals(input.ScopeId))
                ) && 
                (
                    this.TaxCategoryId == input.TaxCategoryId ||
                    (this.TaxCategoryId != null &&
                    this.TaxCategoryId.Equals(input.TaxCategoryId))
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
                if (this.AvailableFulfillmentMethodTypes != null)
                    hashCode = hashCode * 59 + this.AvailableFulfillmentMethodTypes.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.DisplayName != null)
                    hashCode = hashCode * 59 + this.DisplayName.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.ImplementationTypeName != null)
                    hashCode = hashCode * 59 + this.ImplementationTypeName.GetHashCode();
                hashCode = hashCode * 59 + this.IsActive.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.PropertyBag != null)
                    hashCode = hashCode * 59 + this.PropertyBag.GetHashCode();
                if (this.ScopeId != null)
                    hashCode = hashCode * 59 + this.ScopeId.GetHashCode();
                if (this.TaxCategoryId != null)
                    hashCode = hashCode * 59 + this.TaxCategoryId.GetHashCode();
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
