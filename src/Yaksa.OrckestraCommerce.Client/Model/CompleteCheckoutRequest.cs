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
    /// Carts are entities used for assembling an order before submitting.
    /// </summary>
    [DataContract(Name = "CompleteCheckoutRequest")]
    public partial class CompleteCheckoutRequest : IEquatable<CompleteCheckoutRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CompleteCheckoutRequest" /> class.
        /// </summary>
        /// <param name="cultureName">The culture name in which language the data will be returned..</param>
        /// <param name="workflowToExecute">The name of the workflow that should be executed..</param>
        /// <param name="propertyBag">propertyBag.</param>
        public CompleteCheckoutRequest(string cultureName = default(string), string workflowToExecute = default(string), Dictionary<string, Object> propertyBag = default(Dictionary<string, Object>))
        {
            this.CultureName = cultureName;
            this.WorkflowToExecute = workflowToExecute;
            this.PropertyBag = propertyBag;
        }

        /// <summary>
        /// The culture name in which language the data will be returned.
        /// </summary>
        /// <value>The culture name in which language the data will be returned.</value>
        [DataMember(Name = "cultureName", EmitDefaultValue = false)]
        public string CultureName { get; set; }

        /// <summary>
        /// The name of the workflow that should be executed.
        /// </summary>
        /// <value>The name of the workflow that should be executed.</value>
        [DataMember(Name = "workflowToExecute", EmitDefaultValue = false)]
        public string WorkflowToExecute { get; set; }

        /// <summary>
        /// Gets or Sets PropertyBag
        /// </summary>
        [DataMember(Name = "propertyBag", EmitDefaultValue = false)]
        public Dictionary<string, Object> PropertyBag { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CompleteCheckoutRequest {\n");
            sb.Append("  CultureName: ").Append(CultureName).Append("\n");
            sb.Append("  WorkflowToExecute: ").Append(WorkflowToExecute).Append("\n");
            sb.Append("  PropertyBag: ").Append(PropertyBag).Append("\n");
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
            return this.Equals(input as CompleteCheckoutRequest);
        }

        /// <summary>
        /// Returns true if CompleteCheckoutRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of CompleteCheckoutRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CompleteCheckoutRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CultureName == input.CultureName ||
                    (this.CultureName != null &&
                    this.CultureName.Equals(input.CultureName))
                ) && 
                (
                    this.WorkflowToExecute == input.WorkflowToExecute ||
                    (this.WorkflowToExecute != null &&
                    this.WorkflowToExecute.Equals(input.WorkflowToExecute))
                ) && 
                (
                    this.PropertyBag == input.PropertyBag ||
                    this.PropertyBag != null &&
                    input.PropertyBag != null &&
                    this.PropertyBag.SequenceEqual(input.PropertyBag)
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
                if (this.CultureName != null)
                    hashCode = hashCode * 59 + this.CultureName.GetHashCode();
                if (this.WorkflowToExecute != null)
                    hashCode = hashCode * 59 + this.WorkflowToExecute.GetHashCode();
                if (this.PropertyBag != null)
                    hashCode = hashCode * 59 + this.PropertyBag.GetHashCode();
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
