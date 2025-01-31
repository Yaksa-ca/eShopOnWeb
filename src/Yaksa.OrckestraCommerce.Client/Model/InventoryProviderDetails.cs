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
    /// InventoryProviderDetails
    /// </summary>
    [DataContract(Name = "InventoryProviderDetails")]
    public partial class InventoryProviderDetails : IEquatable<InventoryProviderDetails>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InventoryProviderDetails" /> class.
        /// </summary>
        /// <param name="displayName">The display name of this inventory provider.</param>
        /// <param name="inventoryProviderId">The identifier for this provider.</param>
        /// <param name="name">The name of this provider.</param>
        public InventoryProviderDetails(string displayName = default(string), string inventoryProviderId = default(string), string name = default(string))
        {
            this.DisplayName = displayName;
            this.InventoryProviderId = inventoryProviderId;
            this.Name = name;
        }

        /// <summary>
        /// The display name of this inventory provider
        /// </summary>
        /// <value>The display name of this inventory provider</value>
        [DataMember(Name = "displayName", EmitDefaultValue = false)]
        public string DisplayName { get; set; }

        /// <summary>
        /// The identifier for this provider
        /// </summary>
        /// <value>The identifier for this provider</value>
        [DataMember(Name = "inventoryProviderId", EmitDefaultValue = false)]
        public string InventoryProviderId { get; set; }

        /// <summary>
        /// The name of this provider
        /// </summary>
        /// <value>The name of this provider</value>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InventoryProviderDetails {\n");
            sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
            sb.Append("  InventoryProviderId: ").Append(InventoryProviderId).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
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
            return this.Equals(input as InventoryProviderDetails);
        }

        /// <summary>
        /// Returns true if InventoryProviderDetails instances are equal
        /// </summary>
        /// <param name="input">Instance of InventoryProviderDetails to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InventoryProviderDetails input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DisplayName == input.DisplayName ||
                    (this.DisplayName != null &&
                    this.DisplayName.Equals(input.DisplayName))
                ) && 
                (
                    this.InventoryProviderId == input.InventoryProviderId ||
                    (this.InventoryProviderId != null &&
                    this.InventoryProviderId.Equals(input.InventoryProviderId))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
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
                if (this.DisplayName != null)
                    hashCode = hashCode * 59 + this.DisplayName.GetHashCode();
                if (this.InventoryProviderId != null)
                    hashCode = hashCode * 59 + this.InventoryProviderId.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
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
