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
    /// FulfillmentLocation
    /// </summary>
    [DataContract(Name = "FulfillmentLocation")]
    public partial class FulfillmentLocation : IEquatable<FulfillmentLocation>, IValidatableObject
    {
        /// <summary>
        /// The type of the fulfillment location.
        /// </summary>
        /// <value>The type of the fulfillment location.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Enum Unspecified for value: Unspecified
            /// </summary>
            [EnumMember(Value = "Unspecified")]
            Unspecified = 1,

            /// <summary>
            /// Enum Store for value: Store
            /// </summary>
            [EnumMember(Value = "Store")]
            Store = 2,

            /// <summary>
            /// Enum Warehouse for value: Warehouse
            /// </summary>
            [EnumMember(Value = "Warehouse")]
            Warehouse = 3

        }


        /// <summary>
        /// The type of the fulfillment location.
        /// </summary>
        /// <value>The type of the fulfillment location.</value>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="FulfillmentLocation" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected FulfillmentLocation() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="FulfillmentLocation" /> class.
        /// </summary>
        /// <param name="addresses">The fulfillment location&#39;s addresses..</param>
        /// <param name="addressIds">the unique identifiers of the addresses..</param>
        /// <param name="created">the date the Store/Warehouse was created..</param>
        /// <param name="createdBy">the identifier of the user who created the fulfillment location..</param>
        /// <param name="deliveryScheduleManaged">a value indicating whether this fulfillment location manage his own schedule for delivery.</param>
        /// <param name="displayName">displayName.</param>
        /// <param name="id">The unique identifier of the fulfillment location. (required).</param>
        /// <param name="inventoryLocationId">the inventory location identifier.</param>
        /// <param name="inventoryProviderId">the inventory provider identifier to use for this fulfillment location.</param>
        /// <param name="isActive">The state of the fulfillment location.</param>
        /// <param name="isAtpEnabled">a value indicating whether inventory availability to promise is enabled.</param>
        /// <param name="isInventoryEnabled">a value indicating whether this fulfillment location has inventory enabled.</param>
        /// <param name="isPickUpLocation">a value indicating whether this store is a pickup location..</param>
        /// <param name="lastModified">The date of the last modification to the fulfillment location..</param>
        /// <param name="lastModifiedBy">the identifier of the user who last modified the Store or Warehouse..</param>
        /// <param name="name">The name of the fulfillment location.</param>
        /// <param name="number">A business centric number to identify the fulfillment location.</param>
        /// <param name="pickUpScheduleManaged">a value indicating whether this fulfillment location manage his own schedule for pickup.</param>
        /// <param name="schedules">The list of &#39;Schedule&#39; of the fulfillment location..</param>
        /// <param name="supportDelivery">a value indicating whether this store supports delivery for order fulfillment..</param>
        /// <param name="supportedFulfillmentMethodTypes">ICollection&lt;FulfillmentMethodType&gt;.</param>
        /// <param name="supportPickUp">a value indicating whether this store supports pick-up for order fulfillment..</param>
        /// <param name="supportShipping">a value indicating whether this store supports shipping for order fulfillment..</param>
        /// <param name="supportShipToStore">a value indicating whether this store supports ship to store for order fulfillment..</param>
        /// <param name="timeZone">the timezone in which the schedule hours were set..</param>
        /// <param name="type">The type of the fulfillment location..</param>
        public FulfillmentLocation(List<Address> addresses = default(List<Address>), List<string> addressIds = default(List<string>), DateTime created = default(DateTime), string createdBy = default(string), bool deliveryScheduleManaged = default(bool), Dictionary<string, string> displayName = default(Dictionary<string, string>), string id = default(string), string inventoryLocationId = default(string), string inventoryProviderId = default(string), bool isActive = default(bool), bool isAtpEnabled = default(bool), bool isInventoryEnabled = default(bool), bool isPickUpLocation = default(bool), DateTime lastModified = default(DateTime), string lastModifiedBy = default(string), string name = default(string), string number = default(string), bool pickUpScheduleManaged = default(bool), List<FulfillmentSchedule> schedules = default(List<FulfillmentSchedule>), bool supportDelivery = default(bool), Object supportedFulfillmentMethodTypes = default(Object), bool supportPickUp = default(bool), bool supportShipping = default(bool), bool supportShipToStore = default(bool), string timeZone = default(string), TypeEnum? type = default(TypeEnum?))
        {
            // to ensure "id" is required (not null)
            this.Id = id ?? throw new ArgumentNullException("id is a required property for FulfillmentLocation and cannot be null");
            this.Addresses = addresses;
            this.AddressIds = addressIds;
            this.Created = created;
            this.CreatedBy = createdBy;
            this.DeliveryScheduleManaged = deliveryScheduleManaged;
            this.DisplayName = displayName;
            this.InventoryLocationId = inventoryLocationId;
            this.InventoryProviderId = inventoryProviderId;
            this.IsActive = isActive;
            this.IsAtpEnabled = isAtpEnabled;
            this.IsInventoryEnabled = isInventoryEnabled;
            this.IsPickUpLocation = isPickUpLocation;
            this.LastModified = lastModified;
            this.LastModifiedBy = lastModifiedBy;
            this.Name = name;
            this.Number = number;
            this.PickUpScheduleManaged = pickUpScheduleManaged;
            this.Schedules = schedules;
            this.SupportDelivery = supportDelivery;
            this.SupportedFulfillmentMethodTypes = supportedFulfillmentMethodTypes;
            this.SupportPickUp = supportPickUp;
            this.SupportShipping = supportShipping;
            this.SupportShipToStore = supportShipToStore;
            this.TimeZone = timeZone;
            this.Type = type;
        }

        /// <summary>
        /// The fulfillment location&#39;s addresses.
        /// </summary>
        /// <value>The fulfillment location&#39;s addresses.</value>
        [DataMember(Name = "addresses", EmitDefaultValue = false)]
        public List<Address> Addresses { get; set; }

        /// <summary>
        /// the unique identifiers of the addresses.
        /// </summary>
        /// <value>the unique identifiers of the addresses.</value>
        [DataMember(Name = "addressIds", EmitDefaultValue = false)]
        public List<string> AddressIds { get; set; }

        /// <summary>
        /// the date the Store/Warehouse was created.
        /// </summary>
        /// <value>the date the Store/Warehouse was created.</value>
        [DataMember(Name = "created", EmitDefaultValue = false)]
        public DateTime Created { get; set; }

        /// <summary>
        /// the identifier of the user who created the fulfillment location.
        /// </summary>
        /// <value>the identifier of the user who created the fulfillment location.</value>
        [DataMember(Name = "createdBy", EmitDefaultValue = false)]
        public string CreatedBy { get; set; }

        /// <summary>
        /// a value indicating whether this fulfillment location manage his own schedule for delivery
        /// </summary>
        /// <value>a value indicating whether this fulfillment location manage his own schedule for delivery</value>
        [DataMember(Name = "deliveryScheduleManaged", EmitDefaultValue = true)]
        public bool DeliveryScheduleManaged { get; set; }

        /// <summary>
        /// Gets or Sets DisplayName
        /// </summary>
        [DataMember(Name = "displayName", EmitDefaultValue = false)]
        public Dictionary<string, string> DisplayName { get; set; }

        /// <summary>
        /// The unique identifier of the fulfillment location.
        /// </summary>
        /// <value>The unique identifier of the fulfillment location.</value>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        /// the inventory location identifier
        /// </summary>
        /// <value>the inventory location identifier</value>
        [DataMember(Name = "inventoryLocationId", EmitDefaultValue = false)]
        public string InventoryLocationId { get; set; }

        /// <summary>
        /// the inventory provider identifier to use for this fulfillment location
        /// </summary>
        /// <value>the inventory provider identifier to use for this fulfillment location</value>
        [DataMember(Name = "inventoryProviderId", EmitDefaultValue = false)]
        public string InventoryProviderId { get; set; }

        /// <summary>
        /// The state of the fulfillment location
        /// </summary>
        /// <value>The state of the fulfillment location</value>
        [DataMember(Name = "isActive", EmitDefaultValue = true)]
        public bool IsActive { get; set; }

        /// <summary>
        /// a value indicating whether inventory availability to promise is enabled
        /// </summary>
        /// <value>a value indicating whether inventory availability to promise is enabled</value>
        [DataMember(Name = "isAtpEnabled", EmitDefaultValue = true)]
        public bool IsAtpEnabled { get; set; }

        /// <summary>
        /// a value indicating whether this fulfillment location has inventory enabled
        /// </summary>
        /// <value>a value indicating whether this fulfillment location has inventory enabled</value>
        [DataMember(Name = "isInventoryEnabled", EmitDefaultValue = true)]
        public bool IsInventoryEnabled { get; set; }

        /// <summary>
        /// a value indicating whether this store is a pickup location.
        /// </summary>
        /// <value>a value indicating whether this store is a pickup location.</value>
        [DataMember(Name = "isPickUpLocation", EmitDefaultValue = true)]
        public bool IsPickUpLocation { get; set; }

        /// <summary>
        /// The date of the last modification to the fulfillment location.
        /// </summary>
        /// <value>The date of the last modification to the fulfillment location.</value>
        [DataMember(Name = "lastModified", EmitDefaultValue = false)]
        public DateTime LastModified { get; set; }

        /// <summary>
        /// the identifier of the user who last modified the Store or Warehouse.
        /// </summary>
        /// <value>the identifier of the user who last modified the Store or Warehouse.</value>
        [DataMember(Name = "lastModifiedBy", EmitDefaultValue = false)]
        public string LastModifiedBy { get; set; }

        /// <summary>
        /// The name of the fulfillment location
        /// </summary>
        /// <value>The name of the fulfillment location</value>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// A business centric number to identify the fulfillment location
        /// </summary>
        /// <value>A business centric number to identify the fulfillment location</value>
        [DataMember(Name = "number", EmitDefaultValue = false)]
        public string Number { get; set; }

        /// <summary>
        /// a value indicating whether this fulfillment location manage his own schedule for pickup
        /// </summary>
        /// <value>a value indicating whether this fulfillment location manage his own schedule for pickup</value>
        [DataMember(Name = "pickUpScheduleManaged", EmitDefaultValue = true)]
        public bool PickUpScheduleManaged { get; set; }

        /// <summary>
        /// The list of &#39;Schedule&#39; of the fulfillment location.
        /// </summary>
        /// <value>The list of &#39;Schedule&#39; of the fulfillment location.</value>
        [DataMember(Name = "schedules", EmitDefaultValue = false)]
        public List<FulfillmentSchedule> Schedules { get; set; }

        /// <summary>
        /// a value indicating whether this store supports delivery for order fulfillment.
        /// </summary>
        /// <value>a value indicating whether this store supports delivery for order fulfillment.</value>
        [DataMember(Name = "supportDelivery", EmitDefaultValue = true)]
        public bool SupportDelivery { get; set; }

        /// <summary>
        /// ICollection&lt;FulfillmentMethodType&gt;
        /// </summary>
        /// <value>ICollection&lt;FulfillmentMethodType&gt;</value>
        [DataMember(Name = "supportedFulfillmentMethodTypes", EmitDefaultValue = false)]
        public Object SupportedFulfillmentMethodTypes { get; set; }

        /// <summary>
        /// a value indicating whether this store supports pick-up for order fulfillment.
        /// </summary>
        /// <value>a value indicating whether this store supports pick-up for order fulfillment.</value>
        [DataMember(Name = "supportPickUp", EmitDefaultValue = true)]
        public bool SupportPickUp { get; set; }

        /// <summary>
        /// a value indicating whether this store supports shipping for order fulfillment.
        /// </summary>
        /// <value>a value indicating whether this store supports shipping for order fulfillment.</value>
        [DataMember(Name = "supportShipping", EmitDefaultValue = true)]
        public bool SupportShipping { get; set; }

        /// <summary>
        /// a value indicating whether this store supports ship to store for order fulfillment.
        /// </summary>
        /// <value>a value indicating whether this store supports ship to store for order fulfillment.</value>
        [DataMember(Name = "supportShipToStore", EmitDefaultValue = true)]
        public bool SupportShipToStore { get; set; }

        /// <summary>
        /// the timezone in which the schedule hours were set.
        /// </summary>
        /// <value>the timezone in which the schedule hours were set.</value>
        [DataMember(Name = "timeZone", EmitDefaultValue = false)]
        public string TimeZone { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FulfillmentLocation {\n");
            sb.Append("  Addresses: ").Append(Addresses).Append("\n");
            sb.Append("  AddressIds: ").Append(AddressIds).Append("\n");
            sb.Append("  Created: ").Append(Created).Append("\n");
            sb.Append("  CreatedBy: ").Append(CreatedBy).Append("\n");
            sb.Append("  DeliveryScheduleManaged: ").Append(DeliveryScheduleManaged).Append("\n");
            sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  InventoryLocationId: ").Append(InventoryLocationId).Append("\n");
            sb.Append("  InventoryProviderId: ").Append(InventoryProviderId).Append("\n");
            sb.Append("  IsActive: ").Append(IsActive).Append("\n");
            sb.Append("  IsAtpEnabled: ").Append(IsAtpEnabled).Append("\n");
            sb.Append("  IsInventoryEnabled: ").Append(IsInventoryEnabled).Append("\n");
            sb.Append("  IsPickUpLocation: ").Append(IsPickUpLocation).Append("\n");
            sb.Append("  LastModified: ").Append(LastModified).Append("\n");
            sb.Append("  LastModifiedBy: ").Append(LastModifiedBy).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Number: ").Append(Number).Append("\n");
            sb.Append("  PickUpScheduleManaged: ").Append(PickUpScheduleManaged).Append("\n");
            sb.Append("  Schedules: ").Append(Schedules).Append("\n");
            sb.Append("  SupportDelivery: ").Append(SupportDelivery).Append("\n");
            sb.Append("  SupportedFulfillmentMethodTypes: ").Append(SupportedFulfillmentMethodTypes).Append("\n");
            sb.Append("  SupportPickUp: ").Append(SupportPickUp).Append("\n");
            sb.Append("  SupportShipping: ").Append(SupportShipping).Append("\n");
            sb.Append("  SupportShipToStore: ").Append(SupportShipToStore).Append("\n");
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
            return this.Equals(input as FulfillmentLocation);
        }

        /// <summary>
        /// Returns true if FulfillmentLocation instances are equal
        /// </summary>
        /// <param name="input">Instance of FulfillmentLocation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FulfillmentLocation input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Addresses == input.Addresses ||
                    this.Addresses != null &&
                    input.Addresses != null &&
                    this.Addresses.SequenceEqual(input.Addresses)
                ) && 
                (
                    this.AddressIds == input.AddressIds ||
                    this.AddressIds != null &&
                    input.AddressIds != null &&
                    this.AddressIds.SequenceEqual(input.AddressIds)
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
                    this.DeliveryScheduleManaged == input.DeliveryScheduleManaged ||
                    this.DeliveryScheduleManaged.Equals(input.DeliveryScheduleManaged)
                ) && 
                (
                    this.DisplayName == input.DisplayName ||
                    this.DisplayName != null &&
                    input.DisplayName != null &&
                    this.DisplayName.SequenceEqual(input.DisplayName)
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.InventoryLocationId == input.InventoryLocationId ||
                    (this.InventoryLocationId != null &&
                    this.InventoryLocationId.Equals(input.InventoryLocationId))
                ) && 
                (
                    this.InventoryProviderId == input.InventoryProviderId ||
                    (this.InventoryProviderId != null &&
                    this.InventoryProviderId.Equals(input.InventoryProviderId))
                ) && 
                (
                    this.IsActive == input.IsActive ||
                    this.IsActive.Equals(input.IsActive)
                ) && 
                (
                    this.IsAtpEnabled == input.IsAtpEnabled ||
                    this.IsAtpEnabled.Equals(input.IsAtpEnabled)
                ) && 
                (
                    this.IsInventoryEnabled == input.IsInventoryEnabled ||
                    this.IsInventoryEnabled.Equals(input.IsInventoryEnabled)
                ) && 
                (
                    this.IsPickUpLocation == input.IsPickUpLocation ||
                    this.IsPickUpLocation.Equals(input.IsPickUpLocation)
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
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Number == input.Number ||
                    (this.Number != null &&
                    this.Number.Equals(input.Number))
                ) && 
                (
                    this.PickUpScheduleManaged == input.PickUpScheduleManaged ||
                    this.PickUpScheduleManaged.Equals(input.PickUpScheduleManaged)
                ) && 
                (
                    this.Schedules == input.Schedules ||
                    this.Schedules != null &&
                    input.Schedules != null &&
                    this.Schedules.SequenceEqual(input.Schedules)
                ) && 
                (
                    this.SupportDelivery == input.SupportDelivery ||
                    this.SupportDelivery.Equals(input.SupportDelivery)
                ) && 
                (
                    this.SupportedFulfillmentMethodTypes == input.SupportedFulfillmentMethodTypes ||
                    (this.SupportedFulfillmentMethodTypes != null &&
                    this.SupportedFulfillmentMethodTypes.Equals(input.SupportedFulfillmentMethodTypes))
                ) && 
                (
                    this.SupportPickUp == input.SupportPickUp ||
                    this.SupportPickUp.Equals(input.SupportPickUp)
                ) && 
                (
                    this.SupportShipping == input.SupportShipping ||
                    this.SupportShipping.Equals(input.SupportShipping)
                ) && 
                (
                    this.SupportShipToStore == input.SupportShipToStore ||
                    this.SupportShipToStore.Equals(input.SupportShipToStore)
                ) && 
                (
                    this.TimeZone == input.TimeZone ||
                    (this.TimeZone != null &&
                    this.TimeZone.Equals(input.TimeZone))
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
                if (this.Addresses != null)
                    hashCode = hashCode * 59 + this.Addresses.GetHashCode();
                if (this.AddressIds != null)
                    hashCode = hashCode * 59 + this.AddressIds.GetHashCode();
                if (this.Created != null)
                    hashCode = hashCode * 59 + this.Created.GetHashCode();
                if (this.CreatedBy != null)
                    hashCode = hashCode * 59 + this.CreatedBy.GetHashCode();
                hashCode = hashCode * 59 + this.DeliveryScheduleManaged.GetHashCode();
                if (this.DisplayName != null)
                    hashCode = hashCode * 59 + this.DisplayName.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.InventoryLocationId != null)
                    hashCode = hashCode * 59 + this.InventoryLocationId.GetHashCode();
                if (this.InventoryProviderId != null)
                    hashCode = hashCode * 59 + this.InventoryProviderId.GetHashCode();
                hashCode = hashCode * 59 + this.IsActive.GetHashCode();
                hashCode = hashCode * 59 + this.IsAtpEnabled.GetHashCode();
                hashCode = hashCode * 59 + this.IsInventoryEnabled.GetHashCode();
                hashCode = hashCode * 59 + this.IsPickUpLocation.GetHashCode();
                if (this.LastModified != null)
                    hashCode = hashCode * 59 + this.LastModified.GetHashCode();
                if (this.LastModifiedBy != null)
                    hashCode = hashCode * 59 + this.LastModifiedBy.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Number != null)
                    hashCode = hashCode * 59 + this.Number.GetHashCode();
                hashCode = hashCode * 59 + this.PickUpScheduleManaged.GetHashCode();
                if (this.Schedules != null)
                    hashCode = hashCode * 59 + this.Schedules.GetHashCode();
                hashCode = hashCode * 59 + this.SupportDelivery.GetHashCode();
                if (this.SupportedFulfillmentMethodTypes != null)
                    hashCode = hashCode * 59 + this.SupportedFulfillmentMethodTypes.GetHashCode();
                hashCode = hashCode * 59 + this.SupportPickUp.GetHashCode();
                hashCode = hashCode * 59 + this.SupportShipping.GetHashCode();
                hashCode = hashCode * 59 + this.SupportShipToStore.GetHashCode();
                if (this.TimeZone != null)
                    hashCode = hashCode * 59 + this.TimeZone.GetHashCode();
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
