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
    /// Inventory locations are places which manage inventory.
    /// </summary>
    [DataContract(Name = "CreateInventoryLocationRequest")]
    public partial class CreateInventoryLocationRequest : IEquatable<CreateInventoryLocationRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateInventoryLocationRequest" /> class.
        /// </summary>
        /// <param name="associatedLocationId">the business id for the inventory location to retrieve.</param>
        public CreateInventoryLocationRequest(string associatedLocationId = default(string))
        {
            this.AssociatedLocationId = associatedLocationId;
        }

        /// <summary>
        /// the business id for the inventory location to retrieve
        /// </summary>
        /// <value>the business id for the inventory location to retrieve</value>
        [DataMember(Name = "associatedLocationId", EmitDefaultValue = false)]
        public string AssociatedLocationId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateInventoryLocationRequest {\n");
            sb.Append("  AssociatedLocationId: ").Append(AssociatedLocationId).Append("\n");
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
            return this.Equals(input as CreateInventoryLocationRequest);
        }

        /// <summary>
        /// Returns true if CreateInventoryLocationRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of CreateInventoryLocationRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateInventoryLocationRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AssociatedLocationId == input.AssociatedLocationId ||
                    (this.AssociatedLocationId != null &&
                    this.AssociatedLocationId.Equals(input.AssociatedLocationId))
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
                if (this.AssociatedLocationId != null)
                    hashCode = hashCode * 59 + this.AssociatedLocationId.GetHashCode();
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
