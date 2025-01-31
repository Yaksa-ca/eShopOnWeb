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
    /// Report
    /// </summary>
    [DataContract(Name = "Report")]
    public partial class Report : IEquatable<Report>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Report" /> class.
        /// </summary>
        /// <param name="category">The category of the report.</param>
        /// <param name="description">The description of the report.</param>
        /// <param name="displayName">The display name of the report.</param>
        /// <param name="name">The name of the report.</param>
        /// <param name="reportId">The unique identifier of the report.</param>
        /// <param name="reportType">The type of the report.</param>
        public Report(string category = default(string), string description = default(string), string displayName = default(string), string name = default(string), string reportId = default(string), string reportType = default(string))
        {
            this.Category = category;
            this.Description = description;
            this.DisplayName = displayName;
            this.Name = name;
            this.ReportId = reportId;
            this.ReportType = reportType;
        }

        /// <summary>
        /// The category of the report
        /// </summary>
        /// <value>The category of the report</value>
        [DataMember(Name = "category", EmitDefaultValue = false)]
        public string Category { get; set; }

        /// <summary>
        /// The description of the report
        /// </summary>
        /// <value>The description of the report</value>
        [DataMember(Name = "description", EmitDefaultValue = false)]
        public string Description { get; set; }

        /// <summary>
        /// The display name of the report
        /// </summary>
        /// <value>The display name of the report</value>
        [DataMember(Name = "displayName", EmitDefaultValue = false)]
        public string DisplayName { get; set; }

        /// <summary>
        /// The name of the report
        /// </summary>
        /// <value>The name of the report</value>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// The unique identifier of the report
        /// </summary>
        /// <value>The unique identifier of the report</value>
        [DataMember(Name = "reportId", EmitDefaultValue = false)]
        public string ReportId { get; set; }

        /// <summary>
        /// The type of the report
        /// </summary>
        /// <value>The type of the report</value>
        [DataMember(Name = "reportType", EmitDefaultValue = false)]
        public string ReportType { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Report {\n");
            sb.Append("  Category: ").Append(Category).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  ReportId: ").Append(ReportId).Append("\n");
            sb.Append("  ReportType: ").Append(ReportType).Append("\n");
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
            return this.Equals(input as Report);
        }

        /// <summary>
        /// Returns true if Report instances are equal
        /// </summary>
        /// <param name="input">Instance of Report to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Report input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Category == input.Category ||
                    (this.Category != null &&
                    this.Category.Equals(input.Category))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.DisplayName == input.DisplayName ||
                    (this.DisplayName != null &&
                    this.DisplayName.Equals(input.DisplayName))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.ReportId == input.ReportId ||
                    (this.ReportId != null &&
                    this.ReportId.Equals(input.ReportId))
                ) && 
                (
                    this.ReportType == input.ReportType ||
                    (this.ReportType != null &&
                    this.ReportType.Equals(input.ReportType))
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
                if (this.Category != null)
                    hashCode = hashCode * 59 + this.Category.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.DisplayName != null)
                    hashCode = hashCode * 59 + this.DisplayName.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.ReportId != null)
                    hashCode = hashCode * 59 + this.ReportId.GetHashCode();
                if (this.ReportType != null)
                    hashCode = hashCode * 59 + this.ReportType.GetHashCode();
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
