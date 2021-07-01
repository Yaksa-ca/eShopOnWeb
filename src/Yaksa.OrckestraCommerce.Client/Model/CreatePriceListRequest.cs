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
    /// Products are entities which represents a buyable item managed in a catalog.
    /// </summary>
    [DataContract(Name = "CreatePriceListRequest")]
    public partial class CreatePriceListRequest : IEquatable<CreatePriceListRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreatePriceListRequest" /> class.
        /// </summary>
        /// <param name="cultureName">The culture name in which language the data will be returned.</param>
        /// <param name="displayName">displayName.</param>
        /// <param name="endDate">The end date of the PriceList.</param>
        /// <param name="nextHigherPriorityPriceListId">The identifier of the price list with the next higher priority. If null, the price list will have the highest priority..</param>
        /// <param name="rebuildSearchIndex">Whether or not the product prices search index will be built rollowing the import. The default value is False..</param>
        /// <param name="startDate">The start date of the PriceList.</param>
        /// <param name="type">The type of the PriceList..</param>
        /// <param name="category">The category of the PriceList..</param>
        public CreatePriceListRequest(string cultureName = default(string), Dictionary<string, string> displayName = default(Dictionary<string, string>), DateTime endDate = default(DateTime), string nextHigherPriorityPriceListId = default(string), bool rebuildSearchIndex = default(bool), DateTime startDate = default(DateTime), string type = default(string), string category = default(string))
        {
            this.CultureName = cultureName;
            this.DisplayName = displayName;
            this.EndDate = endDate;
            this.NextHigherPriorityPriceListId = nextHigherPriorityPriceListId;
            this.RebuildSearchIndex = rebuildSearchIndex;
            this.StartDate = startDate;
            this.Type = type;
            this.Category = category;
        }

        /// <summary>
        /// The culture name in which language the data will be returned
        /// </summary>
        /// <value>The culture name in which language the data will be returned</value>
        [DataMember(Name = "cultureName", EmitDefaultValue = false)]
        public string CultureName { get; set; }

        /// <summary>
        /// Gets or Sets DisplayName
        /// </summary>
        [DataMember(Name = "displayName", EmitDefaultValue = false)]
        public Dictionary<string, string> DisplayName { get; set; }

        /// <summary>
        /// The end date of the PriceList
        /// </summary>
        /// <value>The end date of the PriceList</value>
        [DataMember(Name = "endDate", EmitDefaultValue = false)]
        public DateTime EndDate { get; set; }

        /// <summary>
        /// The identifier of the price list with the next higher priority. If null, the price list will have the highest priority.
        /// </summary>
        /// <value>The identifier of the price list with the next higher priority. If null, the price list will have the highest priority.</value>
        [DataMember(Name = "nextHigherPriorityPriceListId", EmitDefaultValue = false)]
        public string NextHigherPriorityPriceListId { get; set; }

        /// <summary>
        /// Whether or not the product prices search index will be built rollowing the import. The default value is False.
        /// </summary>
        /// <value>Whether or not the product prices search index will be built rollowing the import. The default value is False.</value>
        [DataMember(Name = "rebuildSearchIndex", EmitDefaultValue = true)]
        public bool RebuildSearchIndex { get; set; }

        /// <summary>
        /// The start date of the PriceList
        /// </summary>
        /// <value>The start date of the PriceList</value>
        [DataMember(Name = "startDate", EmitDefaultValue = false)]
        public DateTime StartDate { get; set; }

        /// <summary>
        /// The type of the PriceList.
        /// </summary>
        /// <value>The type of the PriceList.</value>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        public string Type { get; set; }

        /// <summary>
        /// The category of the PriceList.
        /// </summary>
        /// <value>The category of the PriceList.</value>
        [DataMember(Name = "category", EmitDefaultValue = false)]
        public string Category { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreatePriceListRequest {\n");
            sb.Append("  CultureName: ").Append(CultureName).Append("\n");
            sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
            sb.Append("  EndDate: ").Append(EndDate).Append("\n");
            sb.Append("  NextHigherPriorityPriceListId: ").Append(NextHigherPriorityPriceListId).Append("\n");
            sb.Append("  RebuildSearchIndex: ").Append(RebuildSearchIndex).Append("\n");
            sb.Append("  StartDate: ").Append(StartDate).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Category: ").Append(Category).Append("\n");
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
            return this.Equals(input as CreatePriceListRequest);
        }

        /// <summary>
        /// Returns true if CreatePriceListRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of CreatePriceListRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreatePriceListRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CultureName == input.CultureName ||
                    (this.CultureName != null &&
                    this.CultureName.Equals(input.CultureName))
                ) && 
                (
                    this.DisplayName == input.DisplayName ||
                    this.DisplayName != null &&
                    input.DisplayName != null &&
                    this.DisplayName.SequenceEqual(input.DisplayName)
                ) && 
                (
                    this.EndDate == input.EndDate ||
                    (this.EndDate != null &&
                    this.EndDate.Equals(input.EndDate))
                ) && 
                (
                    this.NextHigherPriorityPriceListId == input.NextHigherPriorityPriceListId ||
                    (this.NextHigherPriorityPriceListId != null &&
                    this.NextHigherPriorityPriceListId.Equals(input.NextHigherPriorityPriceListId))
                ) && 
                (
                    this.RebuildSearchIndex == input.RebuildSearchIndex ||
                    this.RebuildSearchIndex.Equals(input.RebuildSearchIndex)
                ) && 
                (
                    this.StartDate == input.StartDate ||
                    (this.StartDate != null &&
                    this.StartDate.Equals(input.StartDate))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.Category == input.Category ||
                    (this.Category != null &&
                    this.Category.Equals(input.Category))
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
                if (this.CultureName != null)
                    hashCode = hashCode * 59 + this.CultureName.GetHashCode();
                if (this.DisplayName != null)
                    hashCode = hashCode * 59 + this.DisplayName.GetHashCode();
                if (this.EndDate != null)
                    hashCode = hashCode * 59 + this.EndDate.GetHashCode();
                if (this.NextHigherPriorityPriceListId != null)
                    hashCode = hashCode * 59 + this.NextHigherPriorityPriceListId.GetHashCode();
                hashCode = hashCode * 59 + this.RebuildSearchIndex.GetHashCode();
                if (this.StartDate != null)
                    hashCode = hashCode * 59 + this.StartDate.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Category != null)
                    hashCode = hashCode * 59 + this.Category.GetHashCode();
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
