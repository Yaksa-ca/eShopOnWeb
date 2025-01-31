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
    /// Regroupment of all custom CDMV services, notably for clinics related operations
    /// </summary>
    [DataContract(Name = "UpdateProductAuthorizationRequest")]
    public partial class UpdateProductAuthorizationRequest : IEquatable<UpdateProductAuthorizationRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateProductAuthorizationRequest" /> class.
        /// </summary>
        /// <param name="status">The status to set on the product authorization.</param>
        /// <param name="expiryDate">The date an Authorized product authorization expires. Only used if the status is Authorized.</param>
        /// <param name="cultureName">The culture name which dictates in which language localized values are returned in.</param>
        public UpdateProductAuthorizationRequest(string status = default(string), DateTime expiryDate = default(DateTime), string cultureName = default(string))
        {
            this.Status = status;
            this.ExpiryDate = expiryDate;
            this.CultureName = cultureName;
        }

        /// <summary>
        /// The status to set on the product authorization
        /// </summary>
        /// <value>The status to set on the product authorization</value>
        [DataMember(Name = "status", EmitDefaultValue = false)]
        public string Status { get; set; }

        /// <summary>
        /// The date an Authorized product authorization expires. Only used if the status is Authorized
        /// </summary>
        /// <value>The date an Authorized product authorization expires. Only used if the status is Authorized</value>
        [DataMember(Name = "expiryDate", EmitDefaultValue = false)]
        public DateTime ExpiryDate { get; set; }

        /// <summary>
        /// The culture name which dictates in which language localized values are returned in
        /// </summary>
        /// <value>The culture name which dictates in which language localized values are returned in</value>
        [DataMember(Name = "cultureName", EmitDefaultValue = false)]
        public string CultureName { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateProductAuthorizationRequest {\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  ExpiryDate: ").Append(ExpiryDate).Append("\n");
            sb.Append("  CultureName: ").Append(CultureName).Append("\n");
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
            return this.Equals(input as UpdateProductAuthorizationRequest);
        }

        /// <summary>
        /// Returns true if UpdateProductAuthorizationRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of UpdateProductAuthorizationRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UpdateProductAuthorizationRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.ExpiryDate == input.ExpiryDate ||
                    (this.ExpiryDate != null &&
                    this.ExpiryDate.Equals(input.ExpiryDate))
                ) && 
                (
                    this.CultureName == input.CultureName ||
                    (this.CultureName != null &&
                    this.CultureName.Equals(input.CultureName))
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
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.ExpiryDate != null)
                    hashCode = hashCode * 59 + this.ExpiryDate.GetHashCode();
                if (this.CultureName != null)
                    hashCode = hashCode * 59 + this.CultureName.GetHashCode();
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
