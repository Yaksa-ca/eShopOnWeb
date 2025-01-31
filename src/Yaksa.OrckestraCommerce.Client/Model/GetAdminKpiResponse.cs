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
    /// GetAdminKpiResponse
    /// </summary>
    [DataContract(Name = "GetAdminKpiResponse")]
    public partial class GetAdminKpiResponse : IEquatable<GetAdminKpiResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetAdminKpiResponse" /> class.
        /// </summary>
        /// <param name="adminKpi">The list of Admin KPI.</param>
        public GetAdminKpiResponse(List<KpiInformations> adminKpi = default(List<KpiInformations>))
        {
            this.AdminKpi = adminKpi;
        }

        /// <summary>
        /// The list of Admin KPI
        /// </summary>
        /// <value>The list of Admin KPI</value>
        [DataMember(Name = "adminKpi", EmitDefaultValue = false)]
        public List<KpiInformations> AdminKpi { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GetAdminKpiResponse {\n");
            sb.Append("  AdminKpi: ").Append(AdminKpi).Append("\n");
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
            return this.Equals(input as GetAdminKpiResponse);
        }

        /// <summary>
        /// Returns true if GetAdminKpiResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of GetAdminKpiResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetAdminKpiResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AdminKpi == input.AdminKpi ||
                    this.AdminKpi != null &&
                    input.AdminKpi != null &&
                    this.AdminKpi.SequenceEqual(input.AdminKpi)
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
                if (this.AdminKpi != null)
                    hashCode = hashCode * 59 + this.AdminKpi.GetHashCode();
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
