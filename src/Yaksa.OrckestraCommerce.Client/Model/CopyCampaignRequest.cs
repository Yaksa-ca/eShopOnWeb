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
    /// Campaigns are entities used to organize marketing promotions.
    /// </summary>
    [DataContract(Name = "CopyCampaignRequest")]
    public partial class CopyCampaignRequest : IEquatable<CopyCampaignRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CopyCampaignRequest" /> class.
        /// </summary>
        /// <param name="newCampaignDescription">The description of the new campaign.</param>
        /// <param name="newCampaignEndDate">The end date in the time zone of the campaign..</param>
        /// <param name="newCampaignName">The name of the new campaign.</param>
        /// <param name="newCampaignStartDate">The start date in the time zone of the campaign..</param>
        /// <param name="priority">The priority of the Campaign.</param>
        /// <param name="timeZone">The timezone fo the campaign.</param>
        /// <param name="type">The type of the campaign.</param>
        public CopyCampaignRequest(string newCampaignDescription = default(string), DateTime newCampaignEndDate = default(DateTime), string newCampaignName = default(string), DateTime newCampaignStartDate = default(DateTime), int priority = default(int), string timeZone = default(string), string type = default(string))
        {
            this.NewCampaignDescription = newCampaignDescription;
            this.NewCampaignEndDate = newCampaignEndDate;
            this.NewCampaignName = newCampaignName;
            this.NewCampaignStartDate = newCampaignStartDate;
            this.Priority = priority;
            this.TimeZone = timeZone;
            this.Type = type;
        }

        /// <summary>
        /// The description of the new campaign
        /// </summary>
        /// <value>The description of the new campaign</value>
        [DataMember(Name = "newCampaignDescription", EmitDefaultValue = false)]
        public string NewCampaignDescription { get; set; }

        /// <summary>
        /// The end date in the time zone of the campaign.
        /// </summary>
        /// <value>The end date in the time zone of the campaign.</value>
        [DataMember(Name = "newCampaignEndDate", EmitDefaultValue = false)]
        public DateTime NewCampaignEndDate { get; set; }

        /// <summary>
        /// The name of the new campaign
        /// </summary>
        /// <value>The name of the new campaign</value>
        [DataMember(Name = "newCampaignName", EmitDefaultValue = false)]
        public string NewCampaignName { get; set; }

        /// <summary>
        /// The start date in the time zone of the campaign.
        /// </summary>
        /// <value>The start date in the time zone of the campaign.</value>
        [DataMember(Name = "newCampaignStartDate", EmitDefaultValue = false)]
        public DateTime NewCampaignStartDate { get; set; }

        /// <summary>
        /// The priority of the Campaign
        /// </summary>
        /// <value>The priority of the Campaign</value>
        [DataMember(Name = "priority", EmitDefaultValue = false)]
        public int Priority { get; set; }

        /// <summary>
        /// The timezone fo the campaign
        /// </summary>
        /// <value>The timezone fo the campaign</value>
        [DataMember(Name = "timeZone", EmitDefaultValue = false)]
        public string TimeZone { get; set; }

        /// <summary>
        /// The type of the campaign
        /// </summary>
        /// <value>The type of the campaign</value>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        public string Type { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CopyCampaignRequest {\n");
            sb.Append("  NewCampaignDescription: ").Append(NewCampaignDescription).Append("\n");
            sb.Append("  NewCampaignEndDate: ").Append(NewCampaignEndDate).Append("\n");
            sb.Append("  NewCampaignName: ").Append(NewCampaignName).Append("\n");
            sb.Append("  NewCampaignStartDate: ").Append(NewCampaignStartDate).Append("\n");
            sb.Append("  Priority: ").Append(Priority).Append("\n");
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
            return this.Equals(input as CopyCampaignRequest);
        }

        /// <summary>
        /// Returns true if CopyCampaignRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of CopyCampaignRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CopyCampaignRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.NewCampaignDescription == input.NewCampaignDescription ||
                    (this.NewCampaignDescription != null &&
                    this.NewCampaignDescription.Equals(input.NewCampaignDescription))
                ) && 
                (
                    this.NewCampaignEndDate == input.NewCampaignEndDate ||
                    (this.NewCampaignEndDate != null &&
                    this.NewCampaignEndDate.Equals(input.NewCampaignEndDate))
                ) && 
                (
                    this.NewCampaignName == input.NewCampaignName ||
                    (this.NewCampaignName != null &&
                    this.NewCampaignName.Equals(input.NewCampaignName))
                ) && 
                (
                    this.NewCampaignStartDate == input.NewCampaignStartDate ||
                    (this.NewCampaignStartDate != null &&
                    this.NewCampaignStartDate.Equals(input.NewCampaignStartDate))
                ) && 
                (
                    this.Priority == input.Priority ||
                    this.Priority.Equals(input.Priority)
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
                if (this.NewCampaignDescription != null)
                    hashCode = hashCode * 59 + this.NewCampaignDescription.GetHashCode();
                if (this.NewCampaignEndDate != null)
                    hashCode = hashCode * 59 + this.NewCampaignEndDate.GetHashCode();
                if (this.NewCampaignName != null)
                    hashCode = hashCode * 59 + this.NewCampaignName.GetHashCode();
                if (this.NewCampaignStartDate != null)
                    hashCode = hashCode * 59 + this.NewCampaignStartDate.GetHashCode();
                hashCode = hashCode * 59 + this.Priority.GetHashCode();
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
