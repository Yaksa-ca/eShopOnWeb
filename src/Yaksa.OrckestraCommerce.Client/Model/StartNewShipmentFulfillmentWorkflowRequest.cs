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
    /// Orders are entities which represent an order of a customer.
    /// </summary>
    [DataContract(Name = "StartNewShipmentFulfillmentWorkflowRequest")]
    public partial class StartNewShipmentFulfillmentWorkflowRequest : IEquatable<StartNewShipmentFulfillmentWorkflowRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StartNewShipmentFulfillmentWorkflowRequest" /> class.
        /// </summary>
        /// <param name="workflowXamlPath">the path of the fulfillment workflow..</param>
        public StartNewShipmentFulfillmentWorkflowRequest(string workflowXamlPath = default(string))
        {
            this.WorkflowXamlPath = workflowXamlPath;
        }

        /// <summary>
        /// the path of the fulfillment workflow.
        /// </summary>
        /// <value>the path of the fulfillment workflow.</value>
        [DataMember(Name = "workflowXamlPath", EmitDefaultValue = false)]
        public string WorkflowXamlPath { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class StartNewShipmentFulfillmentWorkflowRequest {\n");
            sb.Append("  WorkflowXamlPath: ").Append(WorkflowXamlPath).Append("\n");
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
            return this.Equals(input as StartNewShipmentFulfillmentWorkflowRequest);
        }

        /// <summary>
        /// Returns true if StartNewShipmentFulfillmentWorkflowRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of StartNewShipmentFulfillmentWorkflowRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(StartNewShipmentFulfillmentWorkflowRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.WorkflowXamlPath == input.WorkflowXamlPath ||
                    (this.WorkflowXamlPath != null &&
                    this.WorkflowXamlPath.Equals(input.WorkflowXamlPath))
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
                if (this.WorkflowXamlPath != null)
                    hashCode = hashCode * 59 + this.WorkflowXamlPath.GetHashCode();
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
