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
    [DataContract(Name = "GetPendingApprovalAccountsRequest")]
    public partial class GetPendingApprovalAccountsRequest : IEquatable<GetPendingApprovalAccountsRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetPendingApprovalAccountsRequest" /> class.
        /// </summary>
        /// <param name="includePendingOrderCount">Whether to include the number of pending orders for each customer.</param>
        /// <param name="resultsPerPage">The maximum number of results that can be returned at once. Defaults to 50.</param>
        /// <param name="startingPage">If the results are returned on multiple pages, this indicates which page of results to return.</param>
        /// <param name="scopeId">The id of the requested scope.</param>
        public GetPendingApprovalAccountsRequest(bool includePendingOrderCount = default(bool), int resultsPerPage = default(int), int startingPage = default(int), string scopeId = default(string))
        {
            this.IncludePendingOrderCount = includePendingOrderCount;
            this.ResultsPerPage = resultsPerPage;
            this.StartingPage = startingPage;
            this.ScopeId = scopeId;
        }

        /// <summary>
        /// Whether to include the number of pending orders for each customer
        /// </summary>
        /// <value>Whether to include the number of pending orders for each customer</value>
        [DataMember(Name = "includePendingOrderCount", EmitDefaultValue = true)]
        public bool IncludePendingOrderCount { get; set; }

        /// <summary>
        /// The maximum number of results that can be returned at once. Defaults to 50
        /// </summary>
        /// <value>The maximum number of results that can be returned at once. Defaults to 50</value>
        [DataMember(Name = "resultsPerPage", EmitDefaultValue = false)]
        public int ResultsPerPage { get; set; }

        /// <summary>
        /// If the results are returned on multiple pages, this indicates which page of results to return
        /// </summary>
        /// <value>If the results are returned on multiple pages, this indicates which page of results to return</value>
        [DataMember(Name = "startingPage", EmitDefaultValue = false)]
        public int StartingPage { get; set; }

        /// <summary>
        /// The id of the requested scope
        /// </summary>
        /// <value>The id of the requested scope</value>
        [DataMember(Name = "scopeId", EmitDefaultValue = false)]
        public string ScopeId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GetPendingApprovalAccountsRequest {\n");
            sb.Append("  IncludePendingOrderCount: ").Append(IncludePendingOrderCount).Append("\n");
            sb.Append("  ResultsPerPage: ").Append(ResultsPerPage).Append("\n");
            sb.Append("  StartingPage: ").Append(StartingPage).Append("\n");
            sb.Append("  ScopeId: ").Append(ScopeId).Append("\n");
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
            return this.Equals(input as GetPendingApprovalAccountsRequest);
        }

        /// <summary>
        /// Returns true if GetPendingApprovalAccountsRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of GetPendingApprovalAccountsRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetPendingApprovalAccountsRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.IncludePendingOrderCount == input.IncludePendingOrderCount ||
                    this.IncludePendingOrderCount.Equals(input.IncludePendingOrderCount)
                ) && 
                (
                    this.ResultsPerPage == input.ResultsPerPage ||
                    this.ResultsPerPage.Equals(input.ResultsPerPage)
                ) && 
                (
                    this.StartingPage == input.StartingPage ||
                    this.StartingPage.Equals(input.StartingPage)
                ) && 
                (
                    this.ScopeId == input.ScopeId ||
                    (this.ScopeId != null &&
                    this.ScopeId.Equals(input.ScopeId))
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
                hashCode = hashCode * 59 + this.IncludePendingOrderCount.GetHashCode();
                hashCode = hashCode * 59 + this.ResultsPerPage.GetHashCode();
                hashCode = hashCode * 59 + this.StartingPage.GetHashCode();
                if (this.ScopeId != null)
                    hashCode = hashCode * 59 + this.ScopeId.GetHashCode();
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
