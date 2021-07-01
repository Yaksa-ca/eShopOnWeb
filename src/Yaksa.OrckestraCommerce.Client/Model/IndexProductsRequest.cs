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
    [DataContract(Name = "IndexProductsRequest")]
    public partial class IndexProductsRequest : IEquatable<IndexProductsRequest>, IValidatableObject
    {
        /// <summary>
        /// The possible indexing types are &#39;partial&#39;, &#39;full&#39; or &#39;clean&#39;. The &#39;clean&#39; indexing will clean the index and re-index all documents (default: &#39;partial&#39;).
        /// </summary>
        /// <value>The possible indexing types are &#39;partial&#39;, &#39;full&#39; or &#39;clean&#39;. The &#39;clean&#39; indexing will clean the index and re-index all documents (default: &#39;partial&#39;).</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum IndexingTypeEnum
        {
            /// <summary>
            /// Enum Partial for value: Partial
            /// </summary>
            [EnumMember(Value = "Partial")]
            Partial = 1,

            /// <summary>
            /// Enum Full for value: Full
            /// </summary>
            [EnumMember(Value = "Full")]
            Full = 2,

            /// <summary>
            /// Enum Clean for value: Clean
            /// </summary>
            [EnumMember(Value = "Clean")]
            Clean = 3

        }


        /// <summary>
        /// The possible indexing types are &#39;partial&#39;, &#39;full&#39; or &#39;clean&#39;. The &#39;clean&#39; indexing will clean the index and re-index all documents (default: &#39;partial&#39;).
        /// </summary>
        /// <value>The possible indexing types are &#39;partial&#39;, &#39;full&#39; or &#39;clean&#39;. The &#39;clean&#39; indexing will clean the index and re-index all documents (default: &#39;partial&#39;).</value>
        [DataMember(Name = "indexingType", EmitDefaultValue = false)]
        public IndexingTypeEnum? IndexingType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="IndexProductsRequest" /> class.
        /// </summary>
        /// <param name="ignoreSequenceQuota">Value indicating whether the task sequence quota should be ingored. Default value is TRUE.</param>
        /// <param name="indexingType">The possible indexing types are &#39;partial&#39;, &#39;full&#39; or &#39;clean&#39;. The &#39;clean&#39; indexing will clean the index and re-index all documents (default: &#39;partial&#39;)..</param>
        /// <param name="taskName">The name that will be given to task executing the indexing..</param>
        /// <param name="catalogIds">Optional. The list of catalogs to index. If not specified, all catalogs will be indexed..</param>
        /// <param name="cultureNames">Optional. The list of cultures to index. If not specified, all cultures will be indexed..</param>
        /// <param name="targetIndex">Optional. The indexes targetted by the rebuild. All by default..</param>
        public IndexProductsRequest(bool ignoreSequenceQuota = default(bool), IndexingTypeEnum? indexingType = default(IndexingTypeEnum?), string taskName = default(string), List<string> catalogIds = default(List<string>), List<string> cultureNames = default(List<string>), int targetIndex = default(int))
        {
            this.IgnoreSequenceQuota = ignoreSequenceQuota;
            this.IndexingType = indexingType;
            this.TaskName = taskName;
            this.CatalogIds = catalogIds;
            this.CultureNames = cultureNames;
            this.TargetIndex = targetIndex;
        }

        /// <summary>
        /// Value indicating whether the task sequence quota should be ingored. Default value is TRUE
        /// </summary>
        /// <value>Value indicating whether the task sequence quota should be ingored. Default value is TRUE</value>
        [DataMember(Name = "ignoreSequenceQuota", EmitDefaultValue = true)]
        public bool IgnoreSequenceQuota { get; set; }

        /// <summary>
        /// The name that will be given to task executing the indexing.
        /// </summary>
        /// <value>The name that will be given to task executing the indexing.</value>
        [DataMember(Name = "taskName", EmitDefaultValue = false)]
        public string TaskName { get; set; }

        /// <summary>
        /// Optional. The list of catalogs to index. If not specified, all catalogs will be indexed.
        /// </summary>
        /// <value>Optional. The list of catalogs to index. If not specified, all catalogs will be indexed.</value>
        [DataMember(Name = "catalogIds", EmitDefaultValue = false)]
        public List<string> CatalogIds { get; set; }

        /// <summary>
        /// Optional. The list of cultures to index. If not specified, all cultures will be indexed.
        /// </summary>
        /// <value>Optional. The list of cultures to index. If not specified, all cultures will be indexed.</value>
        [DataMember(Name = "cultureNames", EmitDefaultValue = false)]
        public List<string> CultureNames { get; set; }

        /// <summary>
        /// Optional. The indexes targetted by the rebuild. All by default.
        /// </summary>
        /// <value>Optional. The indexes targetted by the rebuild. All by default.</value>
        [DataMember(Name = "targetIndex", EmitDefaultValue = false)]
        public int TargetIndex { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class IndexProductsRequest {\n");
            sb.Append("  IgnoreSequenceQuota: ").Append(IgnoreSequenceQuota).Append("\n");
            sb.Append("  IndexingType: ").Append(IndexingType).Append("\n");
            sb.Append("  TaskName: ").Append(TaskName).Append("\n");
            sb.Append("  CatalogIds: ").Append(CatalogIds).Append("\n");
            sb.Append("  CultureNames: ").Append(CultureNames).Append("\n");
            sb.Append("  TargetIndex: ").Append(TargetIndex).Append("\n");
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
            return this.Equals(input as IndexProductsRequest);
        }

        /// <summary>
        /// Returns true if IndexProductsRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of IndexProductsRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(IndexProductsRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.IgnoreSequenceQuota == input.IgnoreSequenceQuota ||
                    this.IgnoreSequenceQuota.Equals(input.IgnoreSequenceQuota)
                ) && 
                (
                    this.IndexingType == input.IndexingType ||
                    this.IndexingType.Equals(input.IndexingType)
                ) && 
                (
                    this.TaskName == input.TaskName ||
                    (this.TaskName != null &&
                    this.TaskName.Equals(input.TaskName))
                ) && 
                (
                    this.CatalogIds == input.CatalogIds ||
                    this.CatalogIds != null &&
                    input.CatalogIds != null &&
                    this.CatalogIds.SequenceEqual(input.CatalogIds)
                ) && 
                (
                    this.CultureNames == input.CultureNames ||
                    this.CultureNames != null &&
                    input.CultureNames != null &&
                    this.CultureNames.SequenceEqual(input.CultureNames)
                ) && 
                (
                    this.TargetIndex == input.TargetIndex ||
                    this.TargetIndex.Equals(input.TargetIndex)
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
                hashCode = hashCode * 59 + this.IgnoreSequenceQuota.GetHashCode();
                hashCode = hashCode * 59 + this.IndexingType.GetHashCode();
                if (this.TaskName != null)
                    hashCode = hashCode * 59 + this.TaskName.GetHashCode();
                if (this.CatalogIds != null)
                    hashCode = hashCode * 59 + this.CatalogIds.GetHashCode();
                if (this.CultureNames != null)
                    hashCode = hashCode * 59 + this.CultureNames.GetHashCode();
                hashCode = hashCode * 59 + this.TargetIndex.GetHashCode();
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
