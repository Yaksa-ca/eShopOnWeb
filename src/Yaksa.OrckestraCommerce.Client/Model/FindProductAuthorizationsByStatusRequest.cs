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
    [DataContract(Name = "FindProductAuthorizationsByStatusRequest")]
    public partial class FindProductAuthorizationsByStatusRequest : IEquatable<FindProductAuthorizationsByStatusRequest>, IValidatableObject
    {
        /// <summary>
        /// The status to use for the search. Default value is Pending
        /// </summary>
        /// <value>The status to use for the search. Default value is Pending</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StatusEnum
        {
            /// <summary>
            /// Enum Pending for value: Pending
            /// </summary>
            [EnumMember(Value = "Pending")]
            Pending = 1,

            /// <summary>
            /// Enum Authorized for value: Authorized
            /// </summary>
            [EnumMember(Value = "Authorized")]
            Authorized = 2,

            /// <summary>
            /// Enum Refused for value: Refused
            /// </summary>
            [EnumMember(Value = "Refused")]
            Refused = 3

        }


        /// <summary>
        /// The status to use for the search. Default value is Pending
        /// </summary>
        /// <value>The status to use for the search. Default value is Pending</value>
        [DataMember(Name = "status", EmitDefaultValue = false)]
        public StatusEnum? Status { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="FindProductAuthorizationsByStatusRequest" /> class.
        /// </summary>
        /// <param name="status">The status to use for the search. Default value is Pending.</param>
        /// <param name="includeProductDetails">Whether to include the details of the products.</param>
        /// <param name="includeVariants">Whether to include the variants of the authorized products. IncludeProductDetails must be set to true for this to be considered.</param>
        /// <param name="cultureName">The culture name which dictates in which language localized values are returned in.</param>
        /// <param name="includeCustomerInfo">Whether to include the customer information for each of the product authorizations.</param>
        /// <param name="resultsPerPage">The maximum number of results that can be returned at once. Defaults to 50.</param>
        /// <param name="startingPage">If the results are returned on multiple pages, this indicates which page of results to return.</param>
        public FindProductAuthorizationsByStatusRequest(StatusEnum? status = default(StatusEnum?), bool includeProductDetails = default(bool), bool includeVariants = default(bool), string cultureName = default(string), bool includeCustomerInfo = default(bool), int resultsPerPage = default(int), int startingPage = default(int))
        {
            this.Status = status;
            this.IncludeProductDetails = includeProductDetails;
            this.IncludeVariants = includeVariants;
            this.CultureName = cultureName;
            this.IncludeCustomerInfo = includeCustomerInfo;
            this.ResultsPerPage = resultsPerPage;
            this.StartingPage = startingPage;
        }

        /// <summary>
        /// Whether to include the details of the products
        /// </summary>
        /// <value>Whether to include the details of the products</value>
        [DataMember(Name = "includeProductDetails", EmitDefaultValue = true)]
        public bool IncludeProductDetails { get; set; }

        /// <summary>
        /// Whether to include the variants of the authorized products. IncludeProductDetails must be set to true for this to be considered
        /// </summary>
        /// <value>Whether to include the variants of the authorized products. IncludeProductDetails must be set to true for this to be considered</value>
        [DataMember(Name = "includeVariants", EmitDefaultValue = true)]
        public bool IncludeVariants { get; set; }

        /// <summary>
        /// The culture name which dictates in which language localized values are returned in
        /// </summary>
        /// <value>The culture name which dictates in which language localized values are returned in</value>
        [DataMember(Name = "cultureName", EmitDefaultValue = false)]
        public string CultureName { get; set; }

        /// <summary>
        /// Whether to include the customer information for each of the product authorizations
        /// </summary>
        /// <value>Whether to include the customer information for each of the product authorizations</value>
        [DataMember(Name = "includeCustomerInfo", EmitDefaultValue = true)]
        public bool IncludeCustomerInfo { get; set; }

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
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FindProductAuthorizationsByStatusRequest {\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  IncludeProductDetails: ").Append(IncludeProductDetails).Append("\n");
            sb.Append("  IncludeVariants: ").Append(IncludeVariants).Append("\n");
            sb.Append("  CultureName: ").Append(CultureName).Append("\n");
            sb.Append("  IncludeCustomerInfo: ").Append(IncludeCustomerInfo).Append("\n");
            sb.Append("  ResultsPerPage: ").Append(ResultsPerPage).Append("\n");
            sb.Append("  StartingPage: ").Append(StartingPage).Append("\n");
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
            return this.Equals(input as FindProductAuthorizationsByStatusRequest);
        }

        /// <summary>
        /// Returns true if FindProductAuthorizationsByStatusRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of FindProductAuthorizationsByStatusRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FindProductAuthorizationsByStatusRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Status == input.Status ||
                    this.Status.Equals(input.Status)
                ) && 
                (
                    this.IncludeProductDetails == input.IncludeProductDetails ||
                    this.IncludeProductDetails.Equals(input.IncludeProductDetails)
                ) && 
                (
                    this.IncludeVariants == input.IncludeVariants ||
                    this.IncludeVariants.Equals(input.IncludeVariants)
                ) && 
                (
                    this.CultureName == input.CultureName ||
                    (this.CultureName != null &&
                    this.CultureName.Equals(input.CultureName))
                ) && 
                (
                    this.IncludeCustomerInfo == input.IncludeCustomerInfo ||
                    this.IncludeCustomerInfo.Equals(input.IncludeCustomerInfo)
                ) && 
                (
                    this.ResultsPerPage == input.ResultsPerPage ||
                    this.ResultsPerPage.Equals(input.ResultsPerPage)
                ) && 
                (
                    this.StartingPage == input.StartingPage ||
                    this.StartingPage.Equals(input.StartingPage)
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
                hashCode = hashCode * 59 + this.Status.GetHashCode();
                hashCode = hashCode * 59 + this.IncludeProductDetails.GetHashCode();
                hashCode = hashCode * 59 + this.IncludeVariants.GetHashCode();
                if (this.CultureName != null)
                    hashCode = hashCode * 59 + this.CultureName.GetHashCode();
                hashCode = hashCode * 59 + this.IncludeCustomerInfo.GetHashCode();
                hashCode = hashCode * 59 + this.ResultsPerPage.GetHashCode();
                hashCode = hashCode * 59 + this.StartingPage.GetHashCode();
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
