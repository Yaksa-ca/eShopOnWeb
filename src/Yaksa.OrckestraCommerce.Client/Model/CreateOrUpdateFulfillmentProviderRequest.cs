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
    /// Providers are generic entities containing configuration settings for various need.
    /// </summary>
    [DataContract(Name = "CreateOrUpdateFulfillmentProviderRequest")]
    public partial class CreateOrUpdateFulfillmentProviderRequest : IEquatable<CreateOrUpdateFulfillmentProviderRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateOrUpdateFulfillmentProviderRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CreateOrUpdateFulfillmentProviderRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateOrUpdateFulfillmentProviderRequest" /> class.
        /// </summary>
        /// <param name="description">The description of the fulfillment provider..</param>
        /// <param name="displayName">displayName.</param>
        /// <param name="id">the unique identifier for the EntityTypeDefinition (generated if not specified).</param>
        /// <param name="implementationTypeName">The implementation type name of the fulfillment provider. (required).</param>
        /// <param name="isActive">A value indicating whether or not the fulfillment provider is active. (required).</param>
        /// <param name="name">The name of the fulfillment provider. (required).</param>
        /// <param name="propertyBag">propertyBag.</param>
        /// <param name="taxCategoryId">The tax category identifier of the fulfillment provider. (required).</param>
        public CreateOrUpdateFulfillmentProviderRequest(string description = default(string), Dictionary<string, string> displayName = default(Dictionary<string, string>), string id = default(string), string implementationTypeName = default(string), bool isActive = default(bool), string name = default(string), Dictionary<string, Object> propertyBag = default(Dictionary<string, Object>), string taxCategoryId = default(string))
        {
            // to ensure "implementationTypeName" is required (not null)
            this.ImplementationTypeName = implementationTypeName ?? throw new ArgumentNullException("implementationTypeName is a required property for CreateOrUpdateFulfillmentProviderRequest and cannot be null");
            this.IsActive = isActive;
            // to ensure "name" is required (not null)
            this.Name = name ?? throw new ArgumentNullException("name is a required property for CreateOrUpdateFulfillmentProviderRequest and cannot be null");
            // to ensure "taxCategoryId" is required (not null)
            this.TaxCategoryId = taxCategoryId ?? throw new ArgumentNullException("taxCategoryId is a required property for CreateOrUpdateFulfillmentProviderRequest and cannot be null");
            this.Description = description;
            this.DisplayName = displayName;
            this.Id = id;
            this.PropertyBag = propertyBag;
        }

        /// <summary>
        /// The description of the fulfillment provider.
        /// </summary>
        /// <value>The description of the fulfillment provider.</value>
        [DataMember(Name = "description", EmitDefaultValue = false)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets DisplayName
        /// </summary>
        [DataMember(Name = "displayName", EmitDefaultValue = false)]
        public Dictionary<string, string> DisplayName { get; set; }

        /// <summary>
        /// the unique identifier for the EntityTypeDefinition (generated if not specified)
        /// </summary>
        /// <value>the unique identifier for the EntityTypeDefinition (generated if not specified)</value>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        /// The implementation type name of the fulfillment provider.
        /// </summary>
        /// <value>The implementation type name of the fulfillment provider.</value>
        [DataMember(Name = "implementationTypeName", IsRequired = true, EmitDefaultValue = false)]
        public string ImplementationTypeName { get; set; }

        /// <summary>
        /// A value indicating whether or not the fulfillment provider is active.
        /// </summary>
        /// <value>A value indicating whether or not the fulfillment provider is active.</value>
        [DataMember(Name = "isActive", IsRequired = true, EmitDefaultValue = true)]
        public bool IsActive { get; set; }

        /// <summary>
        /// The name of the fulfillment provider.
        /// </summary>
        /// <value>The name of the fulfillment provider.</value>
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets PropertyBag
        /// </summary>
        [DataMember(Name = "propertyBag", EmitDefaultValue = false)]
        public Dictionary<string, Object> PropertyBag { get; set; }

        /// <summary>
        /// The tax category identifier of the fulfillment provider.
        /// </summary>
        /// <value>The tax category identifier of the fulfillment provider.</value>
        [DataMember(Name = "taxCategoryId", IsRequired = true, EmitDefaultValue = false)]
        public string TaxCategoryId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateOrUpdateFulfillmentProviderRequest {\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  ImplementationTypeName: ").Append(ImplementationTypeName).Append("\n");
            sb.Append("  IsActive: ").Append(IsActive).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  PropertyBag: ").Append(PropertyBag).Append("\n");
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
            return this.Equals(input as CreateOrUpdateFulfillmentProviderRequest);
        }

        /// <summary>
        /// Returns true if CreateOrUpdateFulfillmentProviderRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of CreateOrUpdateFulfillmentProviderRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateOrUpdateFulfillmentProviderRequest input)
        {
            if (input == null)
                return false;

            return 
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
