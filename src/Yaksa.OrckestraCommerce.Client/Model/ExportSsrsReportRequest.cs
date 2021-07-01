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
    /// Reporting API.
    /// </summary>
    [DataContract(Name = "ExportSsrsReportRequest")]
    public partial class ExportSsrsReportRequest : IEquatable<ExportSsrsReportRequest>, IValidatableObject
    {
        /// <summary>
        /// The export type (format) to be used.
        /// </summary>
        /// <value>The export type (format) to be used.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ExportTypeEnum
        {
            /// <summary>
            /// Enum Excel for value: Excel
            /// </summary>
            [EnumMember(Value = "Excel")]
            Excel = 1,

            /// <summary>
            /// Enum Csv for value: Csv
            /// </summary>
            [EnumMember(Value = "Csv")]
            Csv = 2,

            /// <summary>
            /// Enum Xml for value: Xml
            /// </summary>
            [EnumMember(Value = "Xml")]
            Xml = 3,

            /// <summary>
            /// Enum Html for value: Html
            /// </summary>
            [EnumMember(Value = "Html")]
            Html = 4,

            /// <summary>
            /// Enum Image for value: Image
            /// </summary>
            [EnumMember(Value = "Image")]
            Image = 5,

            /// <summary>
            /// Enum Word for value: Word
            /// </summary>
            [EnumMember(Value = "Word")]
            Word = 6,

            /// <summary>
            /// Enum Pdf for value: Pdf
            /// </summary>
            [EnumMember(Value = "Pdf")]
            Pdf = 7

        }


        /// <summary>
        /// The export type (format) to be used.
        /// </summary>
        /// <value>The export type (format) to be used.</value>
        [DataMember(Name = "exportType", EmitDefaultValue = false)]
        public ExportTypeEnum? ExportType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ExportSsrsReportRequest" /> class.
        /// </summary>
        /// <param name="correlationId">The correlation id for the durable task..</param>
        /// <param name="cultureName">The culture name in which language the data will be returned.</param>
        /// <param name="exportType">The export type (format) to be used..</param>
        /// <param name="reportName">The name of the report to be used as name for the background task..</param>
        /// <param name="reportParameters">The selected values for the parameters..</param>
        public ExportSsrsReportRequest(string correlationId = default(string), string cultureName = default(string), ExportTypeEnum? exportType = default(ExportTypeEnum?), string reportName = default(string), List<ReportParameterValue> reportParameters = default(List<ReportParameterValue>))
        {
            this.CorrelationId = correlationId;
            this.CultureName = cultureName;
            this.ExportType = exportType;
            this.ReportName = reportName;
            this.ReportParameters = reportParameters;
        }

        /// <summary>
        /// The correlation id for the durable task.
        /// </summary>
        /// <value>The correlation id for the durable task.</value>
        [DataMember(Name = "correlationId", EmitDefaultValue = false)]
        public string CorrelationId { get; set; }

        /// <summary>
        /// The culture name in which language the data will be returned
        /// </summary>
        /// <value>The culture name in which language the data will be returned</value>
        [DataMember(Name = "cultureName", EmitDefaultValue = false)]
        public string CultureName { get; set; }

        /// <summary>
        /// The name of the report to be used as name for the background task.
        /// </summary>
        /// <value>The name of the report to be used as name for the background task.</value>
        [DataMember(Name = "reportName", EmitDefaultValue = false)]
        public string ReportName { get; set; }

        /// <summary>
        /// The selected values for the parameters.
        /// </summary>
        /// <value>The selected values for the parameters.</value>
        [DataMember(Name = "reportParameters", EmitDefaultValue = false)]
        public List<ReportParameterValue> ReportParameters { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ExportSsrsReportRequest {\n");
            sb.Append("  CorrelationId: ").Append(CorrelationId).Append("\n");
            sb.Append("  CultureName: ").Append(CultureName).Append("\n");
            sb.Append("  ExportType: ").Append(ExportType).Append("\n");
            sb.Append("  ReportName: ").Append(ReportName).Append("\n");
            sb.Append("  ReportParameters: ").Append(ReportParameters).Append("\n");
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
            return this.Equals(input as ExportSsrsReportRequest);
        }

        /// <summary>
        /// Returns true if ExportSsrsReportRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of ExportSsrsReportRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ExportSsrsReportRequest input)
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
                    this.CultureName == input.CultureName ||
                    (this.CultureName != null &&
                    this.CultureName.Equals(input.CultureName))
                ) && 
                (
                    this.ExportType == input.ExportType ||
                    this.ExportType.Equals(input.ExportType)
                ) && 
                (
                    this.ReportName == input.ReportName ||
                    (this.ReportName != null &&
                    this.ReportName.Equals(input.ReportName))
                ) && 
                (
                    this.ReportParameters == input.ReportParameters ||
                    this.ReportParameters != null &&
                    input.ReportParameters != null &&
                    this.ReportParameters.SequenceEqual(input.ReportParameters)
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
                if (this.CultureName != null)
                    hashCode = hashCode * 59 + this.CultureName.GetHashCode();
                hashCode = hashCode * 59 + this.ExportType.GetHashCode();
                if (this.ReportName != null)
                    hashCode = hashCode * 59 + this.ReportName.GetHashCode();
                if (this.ReportParameters != null)
                    hashCode = hashCode * 59 + this.ReportParameters.GetHashCode();
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
