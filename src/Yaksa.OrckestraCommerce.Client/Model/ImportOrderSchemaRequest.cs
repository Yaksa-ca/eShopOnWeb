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
    /// Integration resources dedicated to data exchanges across system boundaries or other systems.
    /// </summary>
    [DataContract(Name = "ImportOrderSchemaRequest")]
    public partial class ImportOrderSchemaRequest : IEquatable<ImportOrderSchemaRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ImportOrderSchemaRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ImportOrderSchemaRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ImportOrderSchemaRequest" /> class.
        /// </summary>
        /// <param name="correlationId">The correlation id for the durable task..</param>
        /// <param name="fileName">File name containing the order schema to import. (required).</param>
        public ImportOrderSchemaRequest(string correlationId = default(string), string fileName = default(string))
        {
            // to ensure "fileName" is required (not null)
            this.FileName = fileName ?? throw new ArgumentNullException("fileName is a required property for ImportOrderSchemaRequest and cannot be null");
            this.CorrelationId = correlationId;
        }

        /// <summary>
        /// The correlation id for the durable task.
        /// </summary>
        /// <value>The correlation id for the durable task.</value>
        [DataMember(Name = "correlationId", EmitDefaultValue = false)]
        public string CorrelationId { get; set; }

        /// <summary>
        /// File name containing the order schema to import.
        /// </summary>
        /// <value>File name containing the order schema to import.</value>
        [DataMember(Name = "fileName", IsRequired = true, EmitDefaultValue = false)]
        public string FileName { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ImportOrderSchemaRequest {\n");
            sb.Append("  CorrelationId: ").Append(CorrelationId).Append("\n");
            sb.Append("  FileName: ").Append(FileName).Append("\n");
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
            return this.Equals(input as ImportOrderSchemaRequest);
        }

        /// <summary>
        /// Returns true if ImportOrderSchemaRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of ImportOrderSchemaRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ImportOrderSchemaRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CorrelationId == input.CorrelationId ||
                    (this.CorrelationId != null &&
                    this.CorrelationId.Equals(input.CorrelationId))
                ) && 
                (
                    this.FileName == input.FileName ||
                    (this.FileName != null &&
                    this.FileName.Equals(input.FileName))
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
                if (this.CorrelationId != null)
                    hashCode = hashCode * 59 + this.CorrelationId.GetHashCode();
                if (this.FileName != null)
                    hashCode = hashCode * 59 + this.FileName.GetHashCode();
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
