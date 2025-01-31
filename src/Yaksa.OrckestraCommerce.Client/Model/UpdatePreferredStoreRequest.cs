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
    /// Customers represents entities which have the ability to buy products.
    /// </summary>
    [DataContract(Name = "UpdatePreferredStoreRequest")]
    public partial class UpdatePreferredStoreRequest : IEquatable<UpdatePreferredStoreRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdatePreferredStoreRequest" /> class.
        /// </summary>
        /// <param name="storeId">The unique id of the store. Required when StoreNumber is empty. If both are provided, StoreId is used first and validates the match with StoreNumber..</param>
        /// <param name="storeNumber">The unique number of the store. Required when StoreId is empty. If both are provided, StoreId is used first and validates the match with StoreNumber..</param>
        public UpdatePreferredStoreRequest(string storeId = default(string), string storeNumber = default(string))
        {
            this.StoreId = storeId;
            this.StoreNumber = storeNumber;
        }

        /// <summary>
        /// The unique id of the store. Required when StoreNumber is empty. If both are provided, StoreId is used first and validates the match with StoreNumber.
        /// </summary>
        /// <value>The unique id of the store. Required when StoreNumber is empty. If both are provided, StoreId is used first and validates the match with StoreNumber.</value>
        [DataMember(Name = "storeId", EmitDefaultValue = false)]
        public string StoreId { get; set; }

        /// <summary>
        /// The unique number of the store. Required when StoreId is empty. If both are provided, StoreId is used first and validates the match with StoreNumber.
        /// </summary>
        /// <value>The unique number of the store. Required when StoreId is empty. If both are provided, StoreId is used first and validates the match with StoreNumber.</value>
        [DataMember(Name = "storeNumber", EmitDefaultValue = false)]
        public string StoreNumber { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdatePreferredStoreRequest {\n");
            sb.Append("  StoreId: ").Append(StoreId).Append("\n");
            sb.Append("  StoreNumber: ").Append(StoreNumber).Append("\n");
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
            return this.Equals(input as UpdatePreferredStoreRequest);
        }

        /// <summary>
        /// Returns true if UpdatePreferredStoreRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of UpdatePreferredStoreRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UpdatePreferredStoreRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.StoreId == input.StoreId ||
                    (this.StoreId != null &&
                    this.StoreId.Equals(input.StoreId))
                ) && 
                (
                    this.StoreNumber == input.StoreNumber ||
                    (this.StoreNumber != null &&
                    this.StoreNumber.Equals(input.StoreNumber))
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
                if (this.StoreId != null)
                    hashCode = hashCode * 59 + this.StoreId.GetHashCode();
                if (this.StoreNumber != null)
                    hashCode = hashCode * 59 + this.StoreNumber.GetHashCode();
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
