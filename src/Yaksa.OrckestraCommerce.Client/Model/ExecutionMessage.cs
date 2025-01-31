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
    /// ExecutionMessage
    /// </summary>
    [DataContract(Name = "ExecutionMessage")]
    public partial class ExecutionMessage : IEquatable<ExecutionMessage>, IValidatableObject
    {
        /// <summary>
        /// The severity of the message.
        /// </summary>
        /// <value>The severity of the message.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum SeverityEnum
        {
            /// <summary>
            /// Enum Unspecified for value: Unspecified
            /// </summary>
            [EnumMember(Value = "Unspecified")]
            Unspecified = 1,

            /// <summary>
            /// Enum Info for value: Info
            /// </summary>
            [EnumMember(Value = "Info")]
            Info = 2,

            /// <summary>
            /// Enum Warning for value: Warning
            /// </summary>
            [EnumMember(Value = "Warning")]
            Warning = 3,

            /// <summary>
            /// Enum Error for value: Error
            /// </summary>
            [EnumMember(Value = "Error")]
            Error = 4,

            /// <summary>
            /// Enum Failure for value: Failure
            /// </summary>
            [EnumMember(Value = "Failure")]
            Failure = 5

        }


        /// <summary>
        /// The severity of the message.
        /// </summary>
        /// <value>The severity of the message.</value>
        [DataMember(Name = "severity", EmitDefaultValue = false)]
        public SeverityEnum? Severity { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ExecutionMessage" /> class.
        /// </summary>
        /// <param name="description">description.</param>
        /// <param name="messageId">The id of the message..</param>
        /// <param name="propertyBag">propertyBag.</param>
        /// <param name="severity">The severity of the message..</param>
        public ExecutionMessage(Dictionary<string, string> description = default(Dictionary<string, string>), string messageId = default(string), Dictionary<string, Object> propertyBag = default(Dictionary<string, Object>), SeverityEnum? severity = default(SeverityEnum?))
        {
            this.Description = description;
            this.MessageId = messageId;
            this.PropertyBag = propertyBag;
            this.Severity = severity;
        }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name = "description", EmitDefaultValue = false)]
        public Dictionary<string, string> Description { get; set; }

        /// <summary>
        /// The id of the message.
        /// </summary>
        /// <value>The id of the message.</value>
        [DataMember(Name = "messageId", EmitDefaultValue = false)]
        public string MessageId { get; set; }

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
            sb.Append("class ExecutionMessage {\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  MessageId: ").Append(MessageId).Append("\n");
            sb.Append("  PropertyBag: ").Append(PropertyBag).Append("\n");
            sb.Append("  Severity: ").Append(Severity).Append("\n");
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
            return this.Equals(input as ExecutionMessage);
        }

        /// <summary>
        /// Returns true if ExecutionMessage instances are equal
        /// </summary>
        /// <param name="input">Instance of ExecutionMessage to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ExecutionMessage input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Description == input.Description ||
                    this.Description != null &&
                    input.Description != null &&
                    this.Description.SequenceEqual(input.Description)
                ) && 
                (
                    this.MessageId == input.MessageId ||
                    (this.MessageId != null &&
                    this.MessageId.Equals(input.MessageId))
                ) && 
                (
                    this.PropertyBag == input.PropertyBag ||
                    this.PropertyBag != null &&
                    input.PropertyBag != null &&
                    this.PropertyBag.SequenceEqual(input.PropertyBag)
                ) && 
                (
                    this.Severity == input.Severity ||
                    this.Severity.Equals(input.Severity)
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
                if (this.MessageId != null)
                    hashCode = hashCode * 59 + this.MessageId.GetHashCode();
                if (this.PropertyBag != null)
                    hashCode = hashCode * 59 + this.PropertyBag.GetHashCode();
                hashCode = hashCode * 59 + this.Severity.GetHashCode();
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
