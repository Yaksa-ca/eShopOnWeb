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
    /// Campaign
    /// </summary>
    [DataContract(Name = "Campaign")]
    public partial class Campaign : IEquatable<Campaign>, IValidatableObject
    {
        /// <summary>
        /// The status of the campaign.
        /// </summary>
        /// <value>The status of the campaign.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StatusEnum
        {
            /// <summary>
            /// Enum Unspecified for value: Unspecified
            /// </summary>
            [EnumMember(Value = "Unspecified")]
            Unspecified = 1,

            /// <summary>
            /// Enum Draft for value: Draft
            /// </summary>
            [EnumMember(Value = "Draft")]
            Draft = 2,

            /// <summary>
            /// Enum PendingApproval for value: PendingApproval
            /// </summary>
            [EnumMember(Value = "PendingApproval")]
            PendingApproval = 3,

            /// <summary>
            /// Enum Ready for value: Ready
            /// </summary>
            [EnumMember(Value = "Ready")]
            Ready = 4,

            /// <summary>
            /// Enum Live for value: Live
            /// </summary>
            [EnumMember(Value = "Live")]
            Live = 5,

            /// <summary>
            /// Enum Paused for value: Paused
            /// </summary>
            [EnumMember(Value = "Paused")]
            Paused = 6,

            /// <summary>
            /// Enum Cancelled for value: Cancelled
            /// </summary>
            [EnumMember(Value = "Cancelled")]
            Cancelled = 7,

            /// <summary>
            /// Enum Expired for value: Expired
            /// </summary>
            [EnumMember(Value = "Expired")]
            Expired = 8,

            /// <summary>
            /// Enum Rejected for value: Rejected
            /// </summary>
            [EnumMember(Value = "Rejected")]
            Rejected = 9

        }


        /// <summary>
        /// The status of the campaign.
        /// </summary>
        /// <value>The status of the campaign.</value>
        [DataMember(Name = "status", EmitDefaultValue = false)]
        public StatusEnum? Status { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Campaign" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Campaign() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Campaign" /> class.
        /// </summary>
        /// <param name="id">The unique identifier of the entity. (required).</param>
        /// <param name="propertyBag">propertyBag.</param>
        /// <param name="created">Date the entity was created.</param>
        /// <param name="createdBy">Identifier of the operator who created the entity.</param>
        /// <param name="lastModified">Date that the last modification was applied to the entity.</param>
        /// <param name="lastModifiedBy">Identifier of the operator who last modified the entity.</param>
        /// <param name="allowOptOut">Indicates whether the campaign allows opting out..</param>
        /// <param name="childScopesInheritance">Dictionary&lt;String,Boolean&gt;.</param>
        /// <param name="description">The description of the campaign..</param>
        /// <param name="endDate">The end date of the campaign..</param>
        /// <param name="isEditionStep1Completed">Indicates whether a person editing the campaign marked the step as complete..</param>
        /// <param name="isEditionStep2Completed">Indicates whether a person editing the campaign marked the step as complete..</param>
        /// <param name="isEditionStep3Completed">Indicates whether a person editing the campaign marked the step as complete..</param>
        /// <param name="name">The name of the campaign..</param>
        /// <param name="priority">The priority of the campaign..</param>
        /// <param name="promotions">The promotions that are in the campaign..</param>
        /// <param name="scope">The id of the scope of the campaign..</param>
        /// <param name="startDate">The start date of the campaign..</param>
        /// <param name="status">The status of the campaign..</param>
        /// <param name="timeZone">The time zone to use in conjunction with the date properties (Start/End) of this campaign..</param>
        /// <param name="type">The type of the campaign (CampaignType Lookup).</param>
        public Campaign(string id = default(string), Dictionary<string, Object> propertyBag = default(Dictionary<string, Object>), DateTime created = default(DateTime), string createdBy = default(string), DateTime lastModified = default(DateTime), string lastModifiedBy = default(string), bool allowOptOut = default(bool), Dictionary<string, bool> childScopesInheritance = default(Dictionary<string, bool>), string description = default(string), DateTime endDate = default(DateTime), bool isEditionStep1Completed = default(bool), bool isEditionStep2Completed = default(bool), bool isEditionStep3Completed = default(bool), string name = default(string), int priority = default(int), List<Promotion> promotions = default(List<Promotion>), string scope = default(string), DateTime startDate = default(DateTime), StatusEnum? status = default(StatusEnum?), string timeZone = default(string), string type = default(string))
        {
            // to ensure "id" is required (not null)
            this.Id = id ?? throw new ArgumentNullException("id is a required property for Campaign and cannot be null");
            this.PropertyBag = propertyBag;
            this.Created = created;
            this.CreatedBy = createdBy;
            this.LastModified = lastModified;
            this.LastModifiedBy = lastModifiedBy;
            this.AllowOptOut = allowOptOut;
            this.ChildScopesInheritance = childScopesInheritance;
            this.Description = description;
            this.EndDate = endDate;
            this.IsEditionStep1Completed = isEditionStep1Completed;
            this.IsEditionStep2Completed = isEditionStep2Completed;
            this.IsEditionStep3Completed = isEditionStep3Completed;
            this.Name = name;
            this.Priority = priority;
            this.Promotions = promotions;
            this.Scope = scope;
            this.StartDate = startDate;
            this.Status = status;
            this.TimeZone = timeZone;
            this.Type = type;
        }

        /// <summary>
        /// The unique identifier of the entity.
        /// </summary>
        /// <value>The unique identifier of the entity.</value>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets PropertyBag
        /// </summary>
        [DataMember(Name = "propertyBag", EmitDefaultValue = false)]
        public Dictionary<string, Object> PropertyBag { get; set; }

        /// <summary>
        /// Date the entity was created
        /// </summary>
        /// <value>Date the entity was created</value>
        [DataMember(Name = "created", EmitDefaultValue = false)]
        public DateTime Created { get; set; }

        /// <summary>
        /// Identifier of the operator who created the entity
        /// </summary>
        /// <value>Identifier of the operator who created the entity</value>
        [DataMember(Name = "createdBy", EmitDefaultValue = false)]
        public string CreatedBy { get; set; }

        /// <summary>
        /// Date that the last modification was applied to the entity
        /// </summary>
        /// <value>Date that the last modification was applied to the entity</value>
        [DataMember(Name = "lastModified", EmitDefaultValue = false)]
        public DateTime LastModified { get; set; }

        /// <summary>
        /// Identifier of the operator who last modified the entity
        /// </summary>
        /// <value>Identifier of the operator who last modified the entity</value>
        [DataMember(Name = "lastModifiedBy", EmitDefaultValue = false)]
        public string LastModifiedBy { get; set; }

        /// <summary>
        /// Indicates whether the campaign allows opting out.
        /// </summary>
        /// <value>Indicates whether the campaign allows opting out.</value>
        [DataMember(Name = "allowOptOut", EmitDefaultValue = true)]
        public bool AllowOptOut { get; set; }

        /// <summary>
        /// Dictionary&lt;String,Boolean&gt;
        /// </summary>
        /// <value>Dictionary&lt;String,Boolean&gt;</value>
        [DataMember(Name = "childScopesInheritance", EmitDefaultValue = false)]
        public Dictionary<string, bool> ChildScopesInheritance { get; set; }

        /// <summary>
        /// The description of the campaign.
        /// </summary>
        /// <value>The description of the campaign.</value>
        [DataMember(Name = "description", EmitDefaultValue = false)]
        public string Description { get; set; }

        /// <summary>
        /// The end date of the campaign.
        /// </summary>
        /// <value>The end date of the campaign.</value>
        [DataMember(Name = "endDate", EmitDefaultValue = false)]
        public DateTime EndDate { get; set; }

        /// <summary>
        /// Indicates whether a person editing the campaign marked the step as complete.
        /// </summary>
        /// <value>Indicates whether a person editing the campaign marked the step as complete.</value>
        [DataMember(Name = "isEditionStep1Completed", EmitDefaultValue = true)]
        public bool IsEditionStep1Completed { get; set; }

        /// <summary>
        /// Indicates whether a person editing the campaign marked the step as complete.
        /// </summary>
        /// <value>Indicates whether a person editing the campaign marked the step as complete.</value>
        [DataMember(Name = "isEditionStep2Completed", EmitDefaultValue = true)]
        public bool IsEditionStep2Completed { get; set; }

        /// <summary>
        /// Indicates whether a person editing the campaign marked the step as complete.
        /// </summary>
        /// <value>Indicates whether a person editing the campaign marked the step as complete.</value>
        [DataMember(Name = "isEditionStep3Completed", EmitDefaultValue = true)]
        public bool IsEditionStep3Completed { get; set; }

        /// <summary>
        /// The name of the campaign.
        /// </summary>
        /// <value>The name of the campaign.</value>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// The priority of the campaign.
        /// </summary>
        /// <value>The priority of the campaign.</value>
        [DataMember(Name = "priority", EmitDefaultValue = false)]
        public int Priority { get; set; }

        /// <summary>
        /// The promotions that are in the campaign.
        /// </summary>
        /// <value>The promotions that are in the campaign.</value>
        [DataMember(Name = "promotions", EmitDefaultValue = false)]
        public List<Promotion> Promotions { get; set; }

        /// <summary>
        /// The id of the scope of the campaign.
        /// </summary>
        /// <value>The id of the scope of the campaign.</value>
        [DataMember(Name = "scope", EmitDefaultValue = false)]
        public string Scope { get; set; }

        /// <summary>
        /// The start date of the campaign.
        /// </summary>
        /// <value>The start date of the campaign.</value>
        [DataMember(Name = "startDate", EmitDefaultValue = false)]
        public DateTime StartDate { get; set; }

        /// <summary>
        /// The time zone to use in conjunction with the date properties (Start/End) of this campaign.
        /// </summary>
        /// <value>The time zone to use in conjunction with the date properties (Start/End) of this campaign.</value>
        [DataMember(Name = "timeZone", EmitDefaultValue = false)]
        public string TimeZone { get; set; }

        /// <summary>
        /// The type of the campaign (CampaignType Lookup)
        /// </summary>
        /// <value>The type of the campaign (CampaignType Lookup)</value>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        public string Type { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Campaign {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  PropertyBag: ").Append(PropertyBag).Append("\n");
            sb.Append("  Created: ").Append(Created).Append("\n");
            sb.Append("  CreatedBy: ").Append(CreatedBy).Append("\n");
            sb.Append("  LastModified: ").Append(LastModified).Append("\n");
            sb.Append("  LastModifiedBy: ").Append(LastModifiedBy).Append("\n");
            sb.Append("  AllowOptOut: ").Append(AllowOptOut).Append("\n");
            sb.Append("  ChildScopesInheritance: ").Append(ChildScopesInheritance).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  EndDate: ").Append(EndDate).Append("\n");
            sb.Append("  IsEditionStep1Completed: ").Append(IsEditionStep1Completed).Append("\n");
            sb.Append("  IsEditionStep2Completed: ").Append(IsEditionStep2Completed).Append("\n");
            sb.Append("  IsEditionStep3Completed: ").Append(IsEditionStep3Completed).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Priority: ").Append(Priority).Append("\n");
            sb.Append("  Promotions: ").Append(Promotions).Append("\n");
            sb.Append("  Scope: ").Append(Scope).Append("\n");
            sb.Append("  StartDate: ").Append(StartDate).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  TimeZone: ").Append(TimeZone).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
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
            return this.Equals(input as Campaign);
        }

        /// <summary>
        /// Returns true if Campaign instances are equal
        /// </summary>
        /// <param name="input">Instance of Campaign to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Campaign input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.PropertyBag == input.PropertyBag ||
                    this.PropertyBag != null &&
                    input.PropertyBag != null &&
                    this.PropertyBag.SequenceEqual(input.PropertyBag)
                ) && 
                (
                    this.Created == input.Created ||
                    (this.Created != null &&
                    this.Created.Equals(input.Created))
                ) && 
                (
                    this.CreatedBy == input.CreatedBy ||
                    (this.CreatedBy != null &&
                    this.CreatedBy.Equals(input.CreatedBy))
                ) && 
                (
                    this.LastModified == input.LastModified ||
                    (this.LastModified != null &&
                    this.LastModified.Equals(input.LastModified))
                ) && 
                (
                    this.LastModifiedBy == input.LastModifiedBy ||
                    (this.LastModifiedBy != null &&
                    this.LastModifiedBy.Equals(input.LastModifiedBy))
                ) && 
                (
                    this.AllowOptOut == input.AllowOptOut ||
                    this.AllowOptOut.Equals(input.AllowOptOut)
                ) && 
                (
                    this.ChildScopesInheritance == input.ChildScopesInheritance ||
                    this.ChildScopesInheritance != null &&
                    input.ChildScopesInheritance != null &&
                    this.ChildScopesInheritance.SequenceEqual(input.ChildScopesInheritance)
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.EndDate == input.EndDate ||
                    (this.EndDate != null &&
                    this.EndDate.Equals(input.EndDate))
                ) && 
                (
                    this.IsEditionStep1Completed == input.IsEditionStep1Completed ||
                    this.IsEditionStep1Completed.Equals(input.IsEditionStep1Completed)
                ) && 
                (
                    this.IsEditionStep2Completed == input.IsEditionStep2Completed ||
                    this.IsEditionStep2Completed.Equals(input.IsEditionStep2Completed)
                ) && 
                (
                    this.IsEditionStep3Completed == input.IsEditionStep3Completed ||
                    this.IsEditionStep3Completed.Equals(input.IsEditionStep3Completed)
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Priority == input.Priority ||
                    this.Priority.Equals(input.Priority)
                ) && 
                (
                    this.Promotions == input.Promotions ||
                    this.Promotions != null &&
                    input.Promotions != null &&
                    this.Promotions.SequenceEqual(input.Promotions)
                ) && 
                (
                    this.Scope == input.Scope ||
                    (this.Scope != null &&
                    this.Scope.Equals(input.Scope))
                ) && 
                (
                    this.StartDate == input.StartDate ||
                    (this.StartDate != null &&
                    this.StartDate.Equals(input.StartDate))
                ) && 
                (
                    this.Status == input.Status ||
                    this.Status.Equals(input.Status)
                ) && 
                (
                    this.TimeZone == input.TimeZone ||
                    (this.TimeZone != null &&
                    this.TimeZone.Equals(input.TimeZone))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.PropertyBag != null)
                    hashCode = hashCode * 59 + this.PropertyBag.GetHashCode();
                if (this.Created != null)
                    hashCode = hashCode * 59 + this.Created.GetHashCode();
                if (this.CreatedBy != null)
                    hashCode = hashCode * 59 + this.CreatedBy.GetHashCode();
                if (this.LastModified != null)
                    hashCode = hashCode * 59 + this.LastModified.GetHashCode();
                if (this.LastModifiedBy != null)
                    hashCode = hashCode * 59 + this.LastModifiedBy.GetHashCode();
                hashCode = hashCode * 59 + this.AllowOptOut.GetHashCode();
                if (this.ChildScopesInheritance != null)
                    hashCode = hashCode * 59 + this.ChildScopesInheritance.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.EndDate != null)
                    hashCode = hashCode * 59 + this.EndDate.GetHashCode();
                hashCode = hashCode * 59 + this.IsEditionStep1Completed.GetHashCode();
                hashCode = hashCode * 59 + this.IsEditionStep2Completed.GetHashCode();
                hashCode = hashCode * 59 + this.IsEditionStep3Completed.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                hashCode = hashCode * 59 + this.Priority.GetHashCode();
                if (this.Promotions != null)
                    hashCode = hashCode * 59 + this.Promotions.GetHashCode();
                if (this.Scope != null)
                    hashCode = hashCode * 59 + this.Scope.GetHashCode();
                if (this.StartDate != null)
                    hashCode = hashCode * 59 + this.StartDate.GetHashCode();
                hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.TimeZone != null)
                    hashCode = hashCode * 59 + this.TimeZone.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
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
