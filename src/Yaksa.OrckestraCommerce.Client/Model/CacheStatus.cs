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
    /// CacheStatus
    /// </summary>
    [DataContract(Name = "CacheStatus")]
    public partial class CacheStatus : IEquatable<CacheStatus>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CacheStatus" /> class.
        /// </summary>
        /// <param name="canEnumerateKeys">True if the cache can enumerate its keys.</param>
        /// <param name="itemCount">Number of items in the cache.</param>
        /// <param name="keys">Keys in the cache.</param>
        /// <param name="name">Name of the cache.</param>
        /// <param name="type">Type of the cache.</param>
        public CacheStatus(bool canEnumerateKeys = default(bool), int itemCount = default(int), List<string> keys = default(List<string>), string name = default(string), string type = default(string))
        {
            this.CanEnumerateKeys = canEnumerateKeys;
            this.ItemCount = itemCount;
            this.Keys = keys;
            this.Name = name;
            this.Type = type;
        }

        /// <summary>
        /// True if the cache can enumerate its keys
        /// </summary>
        /// <value>True if the cache can enumerate its keys</value>
        [DataMember(Name = "canEnumerateKeys", EmitDefaultValue = true)]
        public bool CanEnumerateKeys { get; set; }

        /// <summary>
        /// Number of items in the cache
        /// </summary>
        /// <value>Number of items in the cache</value>
        [DataMember(Name = "itemCount", EmitDefaultValue = false)]
        public int ItemCount { get; set; }

        /// <summary>
        /// Keys in the cache
        /// </summary>
        /// <value>Keys in the cache</value>
        [DataMember(Name = "keys", EmitDefaultValue = false)]
        public List<string> Keys { get; set; }

        /// <summary>
        /// Name of the cache
        /// </summary>
        /// <value>Name of the cache</value>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// Type of the cache
        /// </summary>
        /// <value>Type of the cache</value>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        public string Type { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CacheStatus {\n");
            sb.Append("  CanEnumerateKeys: ").Append(CanEnumerateKeys).Append("\n");
            sb.Append("  ItemCount: ").Append(ItemCount).Append("\n");
            sb.Append("  Keys: ").Append(Keys).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
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
            return this.Equals(input as CacheStatus);
        }

        /// <summary>
        /// Returns true if CacheStatus instances are equal
        /// </summary>
        /// <param name="input">Instance of CacheStatus to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CacheStatus input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CanEnumerateKeys == input.CanEnumerateKeys ||
                    this.CanEnumerateKeys.Equals(input.CanEnumerateKeys)
                ) && 
                (
                    this.ItemCount == input.ItemCount ||
                    this.ItemCount.Equals(input.ItemCount)
                ) && 
                (
                    this.Keys == input.Keys ||
                    this.Keys != null &&
                    input.Keys != null &&
                    this.Keys.SequenceEqual(input.Keys)
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
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
                hashCode = hashCode * 59 + this.CanEnumerateKeys.GetHashCode();
                hashCode = hashCode * 59 + this.ItemCount.GetHashCode();
                if (this.Keys != null)
                    hashCode = hashCode * 59 + this.Keys.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
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
