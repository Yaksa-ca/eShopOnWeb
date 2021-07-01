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
    /// Requests related to the marketing application.
    /// </summary>
    [DataContract(Name = "UpdateMarketingSettingsRequest")]
    public partial class UpdateMarketingSettingsRequest : IEquatable<UpdateMarketingSettingsRequest>, IValidatableObject
    {
        /// <summary>
        /// Gets or sets a value indicating whether the product picker fetch products by IDs or by skus.
        /// </summary>
        /// <value>Gets or sets a value indicating whether the product picker fetch products by IDs or by skus.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ProductPickerModeEnum
        {
            /// <summary>
            /// Enum ById for value: ById
            /// </summary>
            [EnumMember(Value = "ById")]
            ById = 1,

            /// <summary>
            /// Enum BySku for value: BySku
            /// </summary>
            [EnumMember(Value = "BySku")]
            BySku = 2

        }


        /// <summary>
        /// Gets or sets a value indicating whether the product picker fetch products by IDs or by skus.
        /// </summary>
        /// <value>Gets or sets a value indicating whether the product picker fetch products by IDs or by skus.</value>
        [DataMember(Name = "productPickerMode", EmitDefaultValue = false)]
        public ProductPickerModeEnum? ProductPickerMode { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateMarketingSettingsRequest" /> class.
        /// </summary>
        /// <param name="allowCampaignLevelInheritanceManagement">Gets or sets a value indicating whether campaign inheritance is managed at the campaign-level..</param>
        /// <param name="campaignsAreInheritedByDefault">Gets or sets a value indicating whether campaign are inherited by default..</param>
        /// <param name="orderRewardsAreSplittedOnLineItem">Gets or sets a value indicating whether Order rewards are splitted on LineItems or applied on shipment..</param>
        /// <param name="productPickerMode">Gets or sets a value indicating whether the product picker fetch products by IDs or by skus..</param>
        public UpdateMarketingSettingsRequest(bool allowCampaignLevelInheritanceManagement = default(bool), bool campaignsAreInheritedByDefault = default(bool), bool orderRewardsAreSplittedOnLineItem = default(bool), ProductPickerModeEnum? productPickerMode = default(ProductPickerModeEnum?))
        {
            this.AllowCampaignLevelInheritanceManagement = allowCampaignLevelInheritanceManagement;
            this.CampaignsAreInheritedByDefault = campaignsAreInheritedByDefault;
            this.OrderRewardsAreSplittedOnLineItem = orderRewardsAreSplittedOnLineItem;
            this.ProductPickerMode = productPickerMode;
        }

        /// <summary>
        /// Gets or sets a value indicating whether campaign inheritance is managed at the campaign-level.
        /// </summary>
        /// <value>Gets or sets a value indicating whether campaign inheritance is managed at the campaign-level.</value>
        [DataMember(Name = "allowCampaignLevelInheritanceManagement", EmitDefaultValue = true)]
        public bool AllowCampaignLevelInheritanceManagement { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether campaign are inherited by default.
        /// </summary>
        /// <value>Gets or sets a value indicating whether campaign are inherited by default.</value>
        [DataMember(Name = "campaignsAreInheritedByDefault", EmitDefaultValue = true)]
        public bool CampaignsAreInheritedByDefault { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether Order rewards are splitted on LineItems or applied on shipment.
        /// </summary>
        /// <value>Gets or sets a value indicating whether Order rewards are splitted on LineItems or applied on shipment.</value>
        [DataMember(Name = "orderRewardsAreSplittedOnLineItem", EmitDefaultValue = true)]
        public bool OrderRewardsAreSplittedOnLineItem { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateMarketingSettingsRequest {\n");
            sb.Append("  AllowCampaignLevelInheritanceManagement: ").Append(AllowCampaignLevelInheritanceManagement).Append("\n");
            sb.Append("  CampaignsAreInheritedByDefault: ").Append(CampaignsAreInheritedByDefault).Append("\n");
            sb.Append("  OrderRewardsAreSplittedOnLineItem: ").Append(OrderRewardsAreSplittedOnLineItem).Append("\n");
            sb.Append("  ProductPickerMode: ").Append(ProductPickerMode).Append("\n");
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
            return this.Equals(input as UpdateMarketingSettingsRequest);
        }

        /// <summary>
        /// Returns true if UpdateMarketingSettingsRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of UpdateMarketingSettingsRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UpdateMarketingSettingsRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AllowCampaignLevelInheritanceManagement == input.AllowCampaignLevelInheritanceManagement ||
                    this.AllowCampaignLevelInheritanceManagement.Equals(input.AllowCampaignLevelInheritanceManagement)
                ) && 
                (
                    this.CampaignsAreInheritedByDefault == input.CampaignsAreInheritedByDefault ||
                    this.CampaignsAreInheritedByDefault.Equals(input.CampaignsAreInheritedByDefault)
                ) && 
                (
                    this.OrderRewardsAreSplittedOnLineItem == input.OrderRewardsAreSplittedOnLineItem ||
                    this.OrderRewardsAreSplittedOnLineItem.Equals(input.OrderRewardsAreSplittedOnLineItem)
                ) && 
                (
                    this.ProductPickerMode == input.ProductPickerMode ||
                    this.ProductPickerMode.Equals(input.ProductPickerMode)
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
                hashCode = hashCode * 59 + this.AllowCampaignLevelInheritanceManagement.GetHashCode();
                hashCode = hashCode * 59 + this.CampaignsAreInheritedByDefault.GetHashCode();
                hashCode = hashCode * 59 + this.OrderRewardsAreSplittedOnLineItem.GetHashCode();
                hashCode = hashCode * 59 + this.ProductPickerMode.GetHashCode();
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
