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
    /// FulfillmentLocationInfo
    /// </summary>
    [DataContract(Name = "FulfillmentLocationInfo")]
    public partial class FulfillmentLocationInfo : IEquatable<FulfillmentLocationInfo>, IValidatableObject
    {
        /// <summary>
        /// The type of the fulfillment location
        /// </summary>
        /// <value>The type of the fulfillment location</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Enum Unspecified for value: Unspecified
            /// </summary>
            [EnumMember(Value = "Unspecified")]
            Unspecified = 1,

            /// <summary>
            /// Enum Store for value: Store
            /// </summary>
            [EnumMember(Value = "Store")]
            Store = 2,

            /// <summary>
            /// Enum Warehouse for value: Warehouse
            /// </summary>
            [EnumMember(Value = "Warehouse")]
            Warehouse = 3

        }


        /// <summary>
        /// The type of the fulfillment location
        /// </summary>
        /// <value>The type of the fulfillment location</value>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="FulfillmentLocationInfo" /> class.
        /// </summary>
        /// <param name="id">The fulfillment location&#39;s identifier.</param>
        /// <param name="name">The fulfillment location&#39;s name.</param>
        /// <param name="inventoryLocationId">The id of the inventory location associated to this fulfillment location.</param>
        /// <param name="type">The type of the fulfillment location.</param>
        /// <param name="number">The Number of the fulfillment&#39;s location type.</param>
        public FulfillmentLocationInfo(string id = default(string), string name = default(string), string inventoryLocationId = default(string), TypeEnum? type = default(TypeEnum?), string number = default(string))
        {
            this.Id = id;
            this.Name = name;
            this.InventoryLocationId = inventoryLocationId;
            this.Type = type;
            this.Number = number;
        }

        /// <summary>
        /// The fulfillment location&#39;s identifier
        /// </summary>
        /// <value>The fulfillment location&#39;s identifier</value>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        /// The fulfillment location&#39;s name
        /// </summary>
        /// <value>The fulfillment location&#39;s name</value>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// The id of the inventory location associated to this fulfillment location
        /// </summary>
        /// <value>The id of the inventory location associated to this fulfillment location</value>
        [DataMember(Name = "inventoryLocationId", EmitDefaultValue = false)]
        public string InventoryLocationId { get; set; }

        /// <summary>
        /// The Number of the fulfillment&#39;s location type
        /// </summary>
        /// <value>The Number of the fulfillment&#39;s location type</value>
        [DataMember(Name = "number", EmitDefaultValue = false)]
        public string Number { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FulfillmentLocationInfo {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  InventoryLocationId: ").Append(InventoryLocationId).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Number: ").Append(Number).Append("\n");
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
            return this.Equals(input as FulfillmentLocationInfo);
        }

        /// <summary>
        /// Returns true if FulfillmentLocationInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of FulfillmentLocationInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FulfillmentLocationInfo input)
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
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.InventoryLocationId == input.InventoryLocationId ||
                    (this.InventoryLocationId != null &&
                    this.InventoryLocationId.Equals(input.InventoryLocationId))
                ) && 
                (
                    this.Type == input.Type ||
                    this.Type.Equals(input.Type)
                ) && 
                (
                    this.Number == input.Number ||
                    (this.Number != null &&
                    this.Number.Equals(input.Number))
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
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.InventoryLocationId != null)
                    hashCode = hashCode * 59 + this.InventoryLocationId.GetHashCode();
                hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Number != null)
                    hashCode = hashCode * 59 + this.Number.GetHashCode();
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
