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
    /// Metadata are entities which represents additional definitions and attribute information.
    /// </summary>
    [DataContract(Name = "UpdateProductAttributeGroupRequest")]
    public partial class UpdateProductAttributeGroupRequest : IEquatable<UpdateProductAttributeGroupRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateProductAttributeGroupRequest" /> class.
        /// </summary>
        /// <param name="description">The description of the attribute group.</param>
        /// <param name="displayName">displayName.</param>
        /// <param name="displayOrder">The display order of the attribute group.</param>
        public UpdateProductAttributeGroupRequest(string description = default(string), Dictionary<string, string> displayName = default(Dictionary<string, string>), int displayOrder = default(int))
        {
            this.Description = description;
            this.DisplayName = displayName;
            this.DisplayOrder = displayOrder;
        }

        /// <summary>
        /// The description of the attribute group
        /// </summary>
        /// <value>The description of the attribute group</value>
        [DataMember(Name = "description", EmitDefaultValue = false)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets DisplayName
        /// </summary>
        [DataMember(Name = "displayName", EmitDefaultValue = false)]
        public Dictionary<string, string> DisplayName { get; set; }

        /// <summary>
        /// The display order of the attribute group
        /// </summary>
        /// <value>The display order of the attribute group</value>
        [DataMember(Name = "displayOrder", EmitDefaultValue = false)]
        public int DisplayOrder { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateProductAttributeGroupRequest {\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
            sb.Append("  DisplayOrder: ").Append(DisplayOrder).Append("\n");
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
            return this.Equals(input as UpdateProductAttributeGroupRequest);
        }

        /// <summary>
        /// Returns true if UpdateProductAttributeGroupRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of UpdateProductAttributeGroupRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UpdateProductAttributeGroupRequest input)
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
                    this.DisplayOrder == input.DisplayOrder ||
                    this.DisplayOrder.Equals(input.DisplayOrder)
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
                hashCode = hashCode * 59 + this.DisplayOrder.GetHashCode();
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
