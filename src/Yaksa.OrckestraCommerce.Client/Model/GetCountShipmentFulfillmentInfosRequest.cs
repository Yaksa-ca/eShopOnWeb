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
    /// ShipmentFulfillmentInfos are entities which represent the Shipment Fulfillment Informations of a customer.
    /// </summary>
    [DataContract(Name = "GetCountShipmentFulfillmentInfosRequest")]
    public partial class GetCountShipmentFulfillmentInfosRequest : IEquatable<GetCountShipmentFulfillmentInfosRequest>, IValidatableObject
    {
        /// <summary>
        /// the date Range filter
        /// </summary>
        /// <value>the date Range filter</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum DateRangeFilterEnum
        {
            /// <summary>
            /// Enum FulfillmentBeginDate for value: FulfillmentBeginDate
            /// </summary>
            [EnumMember(Value = "FulfillmentBeginDate")]
            FulfillmentBeginDate = 1,

            /// <summary>
            /// Enum OrderCreatedDate for value: OrderCreatedDate
            /// </summary>
            [EnumMember(Value = "OrderCreatedDate")]
            OrderCreatedDate = 2,

            /// <summary>
            /// Enum FulfillmentLastAssignedDate for value: FulfillmentLastAssignedDate
            /// </summary>
            [EnumMember(Value = "FulfillmentLastAssignedDate")]
            FulfillmentLastAssignedDate = 3

        }


        /// <summary>
        /// the date Range filter
        /// </summary>
        /// <value>the date Range filter</value>
        [DataMember(Name = "dateRangeFilter", EmitDefaultValue = false)]
        public DateRangeFilterEnum? DateRangeFilter { get; set; }
        /// <summary>
        /// the FulfillmentMethodType
        /// </summary>
        /// <value>the FulfillmentMethodType</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Enum Unspecified for value: Unspecified
            /// </summary>
            [EnumMember(Value = "Unspecified")]
            Unspecified = 1,

            /// <summary>
            /// Enum PickUp for value: PickUp
            /// </summary>
            [EnumMember(Value = "PickUp")]
            PickUp = 2,

            /// <summary>
            /// Enum Delivery for value: Delivery
            /// </summary>
            [EnumMember(Value = "Delivery")]
            Delivery = 3,

            /// <summary>
            /// Enum Shipping for value: Shipping
            /// </summary>
            [EnumMember(Value = "Shipping")]
            Shipping = 4,

            /// <summary>
            /// Enum ShipToStore for value: ShipToStore
            /// </summary>
            [EnumMember(Value = "ShipToStore")]
            ShipToStore = 5

        }


        /// <summary>
        /// the FulfillmentMethodType
        /// </summary>
        /// <value>the FulfillmentMethodType</value>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="GetCountShipmentFulfillmentInfosRequest" /> class.
        /// </summary>
        /// <param name="scopeId">The id of the requested scope.</param>
        /// <param name="dateRangeFilter">the date Range filter.</param>
        /// <param name="endDate">the EndDate, ISO-8601 format.</param>
        /// <param name="excludeShipmentInFinalState">value indicating whether or not shipments in final state of the workflow will be returned.</param>
        /// <param name="flaggedOnly">true if you just want to get flagged Shipments.</param>
        /// <param name="fulfillmentLocationId">the FulfillmentLocationId.</param>
        /// <param name="orderId">the order id.</param>
        /// <param name="pickUpLocationId">the PickUpLocationId.</param>
        /// <param name="searchText">the SearchText.</param>
        /// <param name="startDate">the StartDate, ISO-8601 format.</param>
        /// <param name="statuses">the Statuses.</param>
        /// <param name="type">the FulfillmentMethodType.</param>
        public GetCountShipmentFulfillmentInfosRequest(string scopeId = default(string), DateRangeFilterEnum? dateRangeFilter = default(DateRangeFilterEnum?), DateTime endDate = default(DateTime), bool excludeShipmentInFinalState = default(bool), bool flaggedOnly = default(bool), string fulfillmentLocationId = default(string), string orderId = default(string), string pickUpLocationId = default(string), string searchText = default(string), DateTime startDate = default(DateTime), List<string> statuses = default(List<string>), TypeEnum? type = default(TypeEnum?))
        {
            this.ScopeId = scopeId;
            this.DateRangeFilter = dateRangeFilter;
            this.EndDate = endDate;
            this.ExcludeShipmentInFinalState = excludeShipmentInFinalState;
            this.FlaggedOnly = flaggedOnly;
            this.FulfillmentLocationId = fulfillmentLocationId;
            this.OrderId = orderId;
            this.PickUpLocationId = pickUpLocationId;
            this.SearchText = searchText;
            this.StartDate = startDate;
            this.Statuses = statuses;
            this.Type = type;
        }

        /// <summary>
        /// The id of the requested scope
        /// </summary>
        /// <value>The id of the requested scope</value>
        [DataMember(Name = "scopeId", EmitDefaultValue = false)]
        public string ScopeId { get; set; }

        /// <summary>
        /// the EndDate, ISO-8601 format
        /// </summary>
        /// <value>the EndDate, ISO-8601 format</value>
        [DataMember(Name = "endDate", EmitDefaultValue = false)]
        public DateTime EndDate { get; set; }

        /// <summary>
        /// value indicating whether or not shipments in final state of the workflow will be returned
        /// </summary>
        /// <value>value indicating whether or not shipments in final state of the workflow will be returned</value>
        [DataMember(Name = "excludeShipmentInFinalState", EmitDefaultValue = true)]
        public bool ExcludeShipmentInFinalState { get; set; }

        /// <summary>
        /// true if you just want to get flagged Shipments
        /// </summary>
        /// <value>true if you just want to get flagged Shipments</value>
        [DataMember(Name = "flaggedOnly", EmitDefaultValue = true)]
        public bool FlaggedOnly { get; set; }

        /// <summary>
        /// the FulfillmentLocationId
        /// </summary>
        /// <value>the FulfillmentLocationId</value>
        [DataMember(Name = "fulfillmentLocationId", EmitDefaultValue = false)]
        public string FulfillmentLocationId { get; set; }

        /// <summary>
        /// the order id
        /// </summary>
        /// <value>the order id</value>
        [DataMember(Name = "orderId", EmitDefaultValue = false)]
        public string OrderId { get; set; }

        /// <summary>
        /// the PickUpLocationId
        /// </summary>
        /// <value>the PickUpLocationId</value>
        [DataMember(Name = "pickUpLocationId", EmitDefaultValue = false)]
        public string PickUpLocationId { get; set; }

        /// <summary>
        /// the SearchText
        /// </summary>
        /// <value>the SearchText</value>
        [DataMember(Name = "searchText", EmitDefaultValue = false)]
        public string SearchText { get; set; }

        /// <summary>
        /// the StartDate, ISO-8601 format
        /// </summary>
        /// <value>the StartDate, ISO-8601 format</value>
        [DataMember(Name = "startDate", EmitDefaultValue = false)]
        public DateTime StartDate { get; set; }

        /// <summary>
        /// the Statuses
        /// </summary>
        /// <value>the Statuses</value>
        [DataMember(Name = "statuses", EmitDefaultValue = false)]
        public List<string> Statuses { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GetCountShipmentFulfillmentInfosRequest {\n");
            sb.Append("  ScopeId: ").Append(ScopeId).Append("\n");
            sb.Append("  DateRangeFilter: ").Append(DateRangeFilter).Append("\n");
            sb.Append("  EndDate: ").Append(EndDate).Append("\n");
            sb.Append("  ExcludeShipmentInFinalState: ").Append(ExcludeShipmentInFinalState).Append("\n");
            sb.Append("  FlaggedOnly: ").Append(FlaggedOnly).Append("\n");
            sb.Append("  FulfillmentLocationId: ").Append(FulfillmentLocationId).Append("\n");
            sb.Append("  OrderId: ").Append(OrderId).Append("\n");
            sb.Append("  PickUpLocationId: ").Append(PickUpLocationId).Append("\n");
            sb.Append("  SearchText: ").Append(SearchText).Append("\n");
            sb.Append("  StartDate: ").Append(StartDate).Append("\n");
            sb.Append("  Statuses: ").Append(Statuses).Append("\n");
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
            return this.Equals(input as GetCountShipmentFulfillmentInfosRequest);
        }

        /// <summary>
        /// Returns true if GetCountShipmentFulfillmentInfosRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of GetCountShipmentFulfillmentInfosRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetCountShipmentFulfillmentInfosRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ScopeId == input.ScopeId ||
                    (this.ScopeId != null &&
                    this.ScopeId.Equals(input.ScopeId))
                ) && 
                (
                    this.DateRangeFilter == input.DateRangeFilter ||
                    this.DateRangeFilter.Equals(input.DateRangeFilter)
                ) && 
                (
                    this.EndDate == input.EndDate ||
                    (this.EndDate != null &&
                    this.EndDate.Equals(input.EndDate))
                ) && 
                (
                    this.ExcludeShipmentInFinalState == input.ExcludeShipmentInFinalState ||
                    this.ExcludeShipmentInFinalState.Equals(input.ExcludeShipmentInFinalState)
                ) && 
                (
                    this.FlaggedOnly == input.FlaggedOnly ||
                    this.FlaggedOnly.Equals(input.FlaggedOnly)
                ) && 
                (
                    this.FulfillmentLocationId == input.FulfillmentLocationId ||
                    (this.FulfillmentLocationId != null &&
                    this.FulfillmentLocationId.Equals(input.FulfillmentLocationId))
                ) && 
                (
                    this.OrderId == input.OrderId ||
                    (this.OrderId != null &&
                    this.OrderId.Equals(input.OrderId))
                ) && 
                (
                    this.PickUpLocationId == input.PickUpLocationId ||
                    (this.PickUpLocationId != null &&
                    this.PickUpLocationId.Equals(input.PickUpLocationId))
                ) && 
                (
                    this.SearchText == input.SearchText ||
                    (this.SearchText != null &&
                    this.SearchText.Equals(input.SearchText))
                ) && 
                (
                    this.StartDate == input.StartDate ||
                    (this.StartDate != null &&
                    this.StartDate.Equals(input.StartDate))
                ) && 
                (
                    this.Statuses == input.Statuses ||
                    this.Statuses != null &&
                    input.Statuses != null &&
                    this.Statuses.SequenceEqual(input.Statuses)
                ) && 
                (
                    this.Type == input.Type ||
                    this.Type.Equals(input.Type)
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
                if (this.ScopeId != null)
                    hashCode = hashCode * 59 + this.ScopeId.GetHashCode();
                hashCode = hashCode * 59 + this.DateRangeFilter.GetHashCode();
                if (this.EndDate != null)
                    hashCode = hashCode * 59 + this.EndDate.GetHashCode();
                hashCode = hashCode * 59 + this.ExcludeShipmentInFinalState.GetHashCode();
                hashCode = hashCode * 59 + this.FlaggedOnly.GetHashCode();
                if (this.FulfillmentLocationId != null)
                    hashCode = hashCode * 59 + this.FulfillmentLocationId.GetHashCode();
                if (this.OrderId != null)
                    hashCode = hashCode * 59 + this.OrderId.GetHashCode();
                if (this.PickUpLocationId != null)
                    hashCode = hashCode * 59 + this.PickUpLocationId.GetHashCode();
                if (this.SearchText != null)
                    hashCode = hashCode * 59 + this.SearchText.GetHashCode();
                if (this.StartDate != null)
                    hashCode = hashCode * 59 + this.StartDate.GetHashCode();
                if (this.Statuses != null)
                    hashCode = hashCode * 59 + this.Statuses.GetHashCode();
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
