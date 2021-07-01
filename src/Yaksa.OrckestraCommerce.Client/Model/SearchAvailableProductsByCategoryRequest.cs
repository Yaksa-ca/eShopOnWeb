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
    /// The API used to query the search engine.
    /// </summary>
    [DataContract(Name = "SearchAvailableProductsByCategoryRequest")]
    public partial class SearchAvailableProductsByCategoryRequest : IEquatable<SearchAvailableProductsByCategoryRequest>, IValidatableObject
    {
        /// <summary>
        /// should the products found be available in all (AND) or in any (OR) of the inventory locations.
        /// </summary>
        /// <value>should the products found be available in all (AND) or in any (OR) of the inventory locations.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum InventoryLocationOperatorEnum
        {
            /// <summary>
            /// Enum Or for value: Or
            /// </summary>
            [EnumMember(Value = "Or")]
            Or = 1,

            /// <summary>
            /// Enum And for value: And
            /// </summary>
            [EnumMember(Value = "And")]
            And = 2

        }


        /// <summary>
        /// should the products found be available in all (AND) or in any (OR) of the inventory locations.
        /// </summary>
        /// <value>should the products found be available in all (AND) or in any (OR) of the inventory locations.</value>
        [DataMember(Name = "inventoryLocationOperator", EmitDefaultValue = false)]
        public InventoryLocationOperatorEnum? InventoryLocationOperator { get; set; }
        /// <summary>
        /// The variant grouping strategy
        /// </summary>
        /// <value>The variant grouping strategy</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum VariantGroupingStrategyEnum
        {
            /// <summary>
            /// Enum PerConfiguredSearchOption for value: PerConfiguredSearchOption
            /// </summary>
            [EnumMember(Value = "PerConfiguredSearchOption")]
            PerConfiguredSearchOption = 1,

            /// <summary>
            /// Enum PerProduct for value: PerProduct
            /// </summary>
            [EnumMember(Value = "PerProduct")]
            PerProduct = 2,

            /// <summary>
            /// Enum None for value: None
            /// </summary>
            [EnumMember(Value = "None")]
            None = 3

        }


        /// <summary>
        /// The variant grouping strategy
        /// </summary>
        /// <value>The variant grouping strategy</value>
        [DataMember(Name = "variantGroupingStrategy", EmitDefaultValue = false)]
        public VariantGroupingStrategyEnum? VariantGroupingStrategy { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="SearchAvailableProductsByCategoryRequest" /> class.
        /// </summary>
        /// <param name="configurationName">The name of the configuration to use to process this request.</param>
        /// <param name="query">query.</param>
        /// <param name="autoCorrect">Whether search term should be automatically corrected.</param>
        /// <param name="availabilityDate">the date at which the product should be available.</param>
        /// <param name="boostQueryParams">The boost query parameters for this search. This will append a &#39;bq&#39; parameter to the call to Solr for each param..</param>
        /// <param name="facetPredicates">List of FacetPredicates to apply on the search.</param>
        /// <param name="facets">The facets, a list of strings, that will be included in the results.</param>
        /// <param name="includeFacets">Whether facets are returned as part of the search results.</param>
        /// <param name="inventoryLocationIds">the Ids of the inventory locations where the products should be available..</param>
        /// <param name="inventoryLocationOperator">should the products found be available in all (AND) or in any (OR) of the inventory locations..</param>
        /// <param name="inventoryStatuses">The inventory statuses to filter by. If none are specified, the value will be taken from the product setting &#39;AvailableInventoryStatuses&#39; (InStock, OutOfStock, BackOrder)..</param>
        /// <param name="properties">The collection of properties, represented as a string. According to the search engine, a list of properties may be required to retrieve the document properties.</param>
        /// <param name="searchTerms">The search terms for this search query.</param>
        /// <param name="variantGroupingStrategy">The variant grouping strategy.</param>
        public SearchAvailableProductsByCategoryRequest(string configurationName = default(string), Query query = default(Query), bool autoCorrect = default(bool), DateTime availabilityDate = default(DateTime), List<string> boostQueryParams = default(List<string>), List<FacetPredicate> facetPredicates = default(List<FacetPredicate>), List<string> facets = default(List<string>), bool includeFacets = default(bool), List<string> inventoryLocationIds = default(List<string>), InventoryLocationOperatorEnum? inventoryLocationOperator = default(InventoryLocationOperatorEnum?), List<string> inventoryStatuses = default(List<string>), List<string> properties = default(List<string>), string searchTerms = default(string), VariantGroupingStrategyEnum? variantGroupingStrategy = default(VariantGroupingStrategyEnum?))
        {
            this.ConfigurationName = configurationName;
            this.Query = query;
            this.AutoCorrect = autoCorrect;
            this.AvailabilityDate = availabilityDate;
            this.BoostQueryParams = boostQueryParams;
            this.FacetPredicates = facetPredicates;
            this.Facets = facets;
            this.IncludeFacets = includeFacets;
            this.InventoryLocationIds = inventoryLocationIds;
            this.InventoryLocationOperator = inventoryLocationOperator;
            this.InventoryStatuses = inventoryStatuses;
            this.Properties = properties;
            this.SearchTerms = searchTerms;
            this.VariantGroupingStrategy = variantGroupingStrategy;
        }

        /// <summary>
        /// The name of the configuration to use to process this request
        /// </summary>
        /// <value>The name of the configuration to use to process this request</value>
        [DataMember(Name = "configurationName", EmitDefaultValue = false)]
        public string ConfigurationName { get; set; }

        /// <summary>
        /// Gets or Sets Query
        /// </summary>
        [DataMember(Name = "query", EmitDefaultValue = false)]
        public Query Query { get; set; }

        /// <summary>
        /// Whether search term should be automatically corrected
        /// </summary>
        /// <value>Whether search term should be automatically corrected</value>
        [DataMember(Name = "autoCorrect", EmitDefaultValue = true)]
        public bool AutoCorrect { get; set; }

        /// <summary>
        /// the date at which the product should be available
        /// </summary>
        /// <value>the date at which the product should be available</value>
        [DataMember(Name = "availabilityDate", EmitDefaultValue = false)]
        public DateTime AvailabilityDate { get; set; }

        /// <summary>
        /// The boost query parameters for this search. This will append a &#39;bq&#39; parameter to the call to Solr for each param.
        /// </summary>
        /// <value>The boost query parameters for this search. This will append a &#39;bq&#39; parameter to the call to Solr for each param.</value>
        [DataMember(Name = "boostQueryParams", EmitDefaultValue = false)]
        public List<string> BoostQueryParams { get; set; }

        /// <summary>
        /// List of FacetPredicates to apply on the search
        /// </summary>
        /// <value>List of FacetPredicates to apply on the search</value>
        [DataMember(Name = "facetPredicates", EmitDefaultValue = false)]
        public List<FacetPredicate> FacetPredicates { get; set; }

        /// <summary>
        /// The facets, a list of strings, that will be included in the results
        /// </summary>
        /// <value>The facets, a list of strings, that will be included in the results</value>
        [DataMember(Name = "facets", EmitDefaultValue = false)]
        public List<string> Facets { get; set; }

        /// <summary>
        /// Whether facets are returned as part of the search results
        /// </summary>
        /// <value>Whether facets are returned as part of the search results</value>
        [DataMember(Name = "includeFacets", EmitDefaultValue = true)]
        public bool IncludeFacets { get; set; }

        /// <summary>
        /// the Ids of the inventory locations where the products should be available.
        /// </summary>
        /// <value>the Ids of the inventory locations where the products should be available.</value>
        [DataMember(Name = "inventoryLocationIds", EmitDefaultValue = false)]
        public List<string> InventoryLocationIds { get; set; }

        /// <summary>
        /// The inventory statuses to filter by. If none are specified, the value will be taken from the product setting &#39;AvailableInventoryStatuses&#39; (InStock, OutOfStock, BackOrder).
        /// </summary>
        /// <value>The inventory statuses to filter by. If none are specified, the value will be taken from the product setting &#39;AvailableInventoryStatuses&#39; (InStock, OutOfStock, BackOrder).</value>
        [DataMember(Name = "inventoryStatuses", EmitDefaultValue = false)]
        public List<string> InventoryStatuses { get; set; }

        /// <summary>
        /// The collection of properties, represented as a string. According to the search engine, a list of properties may be required to retrieve the document properties
        /// </summary>
        /// <value>The collection of properties, represented as a string. According to the search engine, a list of properties may be required to retrieve the document properties</value>
        [DataMember(Name = "properties", EmitDefaultValue = false)]
        public List<string> Properties { get; set; }

        /// <summary>
        /// The search terms for this search query
        /// </summary>
        /// <value>The search terms for this search query</value>
        [DataMember(Name = "searchTerms", EmitDefaultValue = false)]
        public string SearchTerms { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SearchAvailableProductsByCategoryRequest {\n");
            sb.Append("  ConfigurationName: ").Append(ConfigurationName).Append("\n");
            sb.Append("  Query: ").Append(Query).Append("\n");
            sb.Append("  AutoCorrect: ").Append(AutoCorrect).Append("\n");
            sb.Append("  AvailabilityDate: ").Append(AvailabilityDate).Append("\n");
            sb.Append("  BoostQueryParams: ").Append(BoostQueryParams).Append("\n");
            sb.Append("  FacetPredicates: ").Append(FacetPredicates).Append("\n");
            sb.Append("  Facets: ").Append(Facets).Append("\n");
            sb.Append("  IncludeFacets: ").Append(IncludeFacets).Append("\n");
            sb.Append("  InventoryLocationIds: ").Append(InventoryLocationIds).Append("\n");
            sb.Append("  InventoryLocationOperator: ").Append(InventoryLocationOperator).Append("\n");
            sb.Append("  InventoryStatuses: ").Append(InventoryStatuses).Append("\n");
            sb.Append("  Properties: ").Append(Properties).Append("\n");
            sb.Append("  SearchTerms: ").Append(SearchTerms).Append("\n");
            sb.Append("  VariantGroupingStrategy: ").Append(VariantGroupingStrategy).Append("\n");
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
            return this.Equals(input as SearchAvailableProductsByCategoryRequest);
        }

        /// <summary>
        /// Returns true if SearchAvailableProductsByCategoryRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of SearchAvailableProductsByCategoryRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SearchAvailableProductsByCategoryRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ConfigurationName == input.ConfigurationName ||
                    (this.ConfigurationName != null &&
                    this.ConfigurationName.Equals(input.ConfigurationName))
                ) && 
                (
                    this.Query == input.Query ||
                    (this.Query != null &&
                    this.Query.Equals(input.Query))
                ) && 
                (
                    this.AutoCorrect == input.AutoCorrect ||
                    this.AutoCorrect.Equals(input.AutoCorrect)
                ) && 
                (
                    this.AvailabilityDate == input.AvailabilityDate ||
                    (this.AvailabilityDate != null &&
                    this.AvailabilityDate.Equals(input.AvailabilityDate))
                ) && 
                (
                    this.BoostQueryParams == input.BoostQueryParams ||
                    this.BoostQueryParams != null &&
                    input.BoostQueryParams != null &&
                    this.BoostQueryParams.SequenceEqual(input.BoostQueryParams)
                ) && 
                (
                    this.FacetPredicates == input.FacetPredicates ||
                    this.FacetPredicates != null &&
                    input.FacetPredicates != null &&
                    this.FacetPredicates.SequenceEqual(input.FacetPredicates)
                ) && 
                (
                    this.Facets == input.Facets ||
                    this.Facets != null &&
                    input.Facets != null &&
                    this.Facets.SequenceEqual(input.Facets)
                ) && 
                (
                    this.IncludeFacets == input.IncludeFacets ||
                    this.IncludeFacets.Equals(input.IncludeFacets)
                ) && 
                (
                    this.InventoryLocationIds == input.InventoryLocationIds ||
                    this.InventoryLocationIds != null &&
                    input.InventoryLocationIds != null &&
                    this.InventoryLocationIds.SequenceEqual(input.InventoryLocationIds)
                ) && 
                (
                    this.InventoryLocationOperator == input.InventoryLocationOperator ||
                    this.InventoryLocationOperator.Equals(input.InventoryLocationOperator)
                ) && 
                (
                    this.InventoryStatuses == input.InventoryStatuses ||
                    this.InventoryStatuses != null &&
                    input.InventoryStatuses != null &&
                    this.InventoryStatuses.SequenceEqual(input.InventoryStatuses)
                ) && 
                (
                    this.Properties == input.Properties ||
                    this.Properties != null &&
                    input.Properties != null &&
                    this.Properties.SequenceEqual(input.Properties)
                ) && 
                (
                    this.SearchTerms == input.SearchTerms ||
                    (this.SearchTerms != null &&
                    this.SearchTerms.Equals(input.SearchTerms))
                ) && 
                (
                    this.VariantGroupingStrategy == input.VariantGroupingStrategy ||
                    this.VariantGroupingStrategy.Equals(input.VariantGroupingStrategy)
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
                if (this.ConfigurationName != null)
                    hashCode = hashCode * 59 + this.ConfigurationName.GetHashCode();
                if (this.Query != null)
                    hashCode = hashCode * 59 + this.Query.GetHashCode();
                hashCode = hashCode * 59 + this.AutoCorrect.GetHashCode();
                if (this.AvailabilityDate != null)
                    hashCode = hashCode * 59 + this.AvailabilityDate.GetHashCode();
                if (this.BoostQueryParams != null)
                    hashCode = hashCode * 59 + this.BoostQueryParams.GetHashCode();
                if (this.FacetPredicates != null)
                    hashCode = hashCode * 59 + this.FacetPredicates.GetHashCode();
                if (this.Facets != null)
                    hashCode = hashCode * 59 + this.Facets.GetHashCode();
                hashCode = hashCode * 59 + this.IncludeFacets.GetHashCode();
                if (this.InventoryLocationIds != null)
                    hashCode = hashCode * 59 + this.InventoryLocationIds.GetHashCode();
                hashCode = hashCode * 59 + this.InventoryLocationOperator.GetHashCode();
                if (this.InventoryStatuses != null)
                    hashCode = hashCode * 59 + this.InventoryStatuses.GetHashCode();
                if (this.Properties != null)
                    hashCode = hashCode * 59 + this.Properties.GetHashCode();
                if (this.SearchTerms != null)
                    hashCode = hashCode * 59 + this.SearchTerms.GetHashCode();
                hashCode = hashCode * 59 + this.VariantGroupingStrategy.GetHashCode();
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
