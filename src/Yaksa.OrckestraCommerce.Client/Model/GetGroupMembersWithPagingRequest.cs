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
    /// Groups are entities wrapping identities objects (users or groups).
    /// </summary>
    [DataContract(Name = "GetGroupMembersWithPagingRequest")]
    public partial class GetGroupMembersWithPagingRequest : IEquatable<GetGroupMembersWithPagingRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetGroupMembersWithPagingRequest" /> class.
        /// </summary>
        /// <param name="groupId">The group identifier..</param>
        /// <param name="maximumItems">The maximum of items to be returned..</param>
        /// <param name="startingIndex">The starting index..</param>
        public GetGroupMembersWithPagingRequest(string groupId = default(string), int maximumItems = default(int), int startingIndex = default(int))
        {
            this.GroupId = groupId;
            this.MaximumItems = maximumItems;
            this.StartingIndex = startingIndex;
        }

        /// <summary>
        /// The group identifier.
        /// </summary>
        /// <value>The group identifier.</value>
        [DataMember(Name = "groupId", EmitDefaultValue = false)]
        public string GroupId { get; set; }

        /// <summary>
        /// The maximum of items to be returned.
        /// </summary>
        /// <value>The maximum of items to be returned.</value>
        [DataMember(Name = "maximumItems", EmitDefaultValue = false)]
        public int MaximumItems { get; set; }

        /// <summary>
        /// The starting index.
        /// </summary>
        /// <value>The starting index.</value>
        [DataMember(Name = "startingIndex", EmitDefaultValue = false)]
        public int StartingIndex { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GetGroupMembersWithPagingRequest {\n");
            sb.Append("  GroupId: ").Append(GroupId).Append("\n");
            sb.Append("  MaximumItems: ").Append(MaximumItems).Append("\n");
            sb.Append("  StartingIndex: ").Append(StartingIndex).Append("\n");
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
            return this.Equals(input as GetGroupMembersWithPagingRequest);
        }

        /// <summary>
        /// Returns true if GetGroupMembersWithPagingRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of GetGroupMembersWithPagingRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetGroupMembersWithPagingRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.GroupId == input.GroupId ||
                    (this.GroupId != null &&
                    this.GroupId.Equals(input.GroupId))
                ) && 
                (
                    this.MaximumItems == input.MaximumItems ||
                    this.MaximumItems.Equals(input.MaximumItems)
                ) && 
                (
                    this.StartingIndex == input.StartingIndex ||
                    this.StartingIndex.Equals(input.StartingIndex)
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
                if (this.GroupId != null)
                    hashCode = hashCode * 59 + this.GroupId.GetHashCode();
                hashCode = hashCode * 59 + this.MaximumItems.GetHashCode();
                hashCode = hashCode * 59 + this.StartingIndex.GetHashCode();
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
