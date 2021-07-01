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
    /// Warehouses are entities which represents physical warehouses.
    /// </summary>
    [DataContract(Name = "CreateWarehouseRequest")]
    public partial class CreateWarehouseRequest : IEquatable<CreateWarehouseRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateWarehouseRequest" /> class.
        /// </summary>
        /// <param name="addresses">The warehouse&#39;s addresses..</param>
        /// <param name="associatedScopes">The warehouse&#39;s associated scopes..</param>
        /// <param name="deliverySchedule">deliverySchedule.</param>
        /// <param name="deliveryScheduleManaged">A value indicating whether this fulfillment location manage his own schedule for delivery.</param>
        /// <param name="description">description.</param>
        /// <param name="displayName">displayName.</param>
        /// <param name="email">the email of the warehouse. This could be a specific person&#39;s address or a general customerService@ address depending on the warehouse..</param>
        /// <param name="faxExtension">the extension for the fax number of the warehouse..</param>
        /// <param name="faxNumber">the fax number of the warehouse..</param>
        /// <param name="inventoryLocationId">The inventory location identifier related to this fulfillment location.</param>
        /// <param name="inventoryProviderId">The inventory provider identifier to use with this fulfillment location.</param>
        /// <param name="isActive">Is this warehouse currently active. Set this flag to false as an alternative to deleting it and then recreating it a a later date. This allows the warehouse to be hidden from many business processes until re-activated. .</param>
        /// <param name="isAtpEnabled">value indicating whether inventory availability to promise is enabled..</param>
        /// <param name="isInventoryEnabled">value indicating whether inventory is enabled for this fulfillment location..</param>
        /// <param name="manager">the full name of the manager of the warehouse..</param>
        /// <param name="name">the name of the warehouse. Each warehouse must have a name that unique in the system..</param>
        /// <param name="number">a business centric number to identify the warehouse that could be used to link the warehouse to external data..</param>
        /// <param name="operatingStatus">operatingStatus.</param>
        /// <param name="phoneExtension">the extension for the telephone number of the warehouse..</param>
        /// <param name="phoneNumber">the telephone number of the warehouse..</param>
        /// <param name="pickUpSchedule">pickUpSchedule.</param>
        /// <param name="pickUpScheduleManaged">A value indicating whether this fulfillment location manage his own schedule for pickup.</param>
        /// <param name="propertyBag">propertyBag.</param>
        /// <param name="schedule">schedule.</param>
        /// <param name="supportDelivery">a value indicating whether this warehouse supports delivery for order fulfillment..</param>
        /// <param name="supportPickUp">a value indicating whether this warehouse supports pickup for order fulfillment..</param>
        /// <param name="supportShipping">a value indicating whether this warehouse supports shipping for order fulfillment..</param>
        /// <param name="supportShipToStore">a value indicating whether this warehouse supports ship to store for order fulfillment..</param>
        /// <param name="timeZone">The time zone of the schedules..</param>
        /// <param name="id">the unique identifier of the Warehouse..</param>
        public CreateWarehouseRequest(List<Address> addresses = default(List<Address>), List<string> associatedScopes = default(List<string>), FulfillmentSchedule deliverySchedule = default(FulfillmentSchedule), bool deliveryScheduleManaged = default(bool), Dictionary<string, string> description = default(Dictionary<string, string>), Dictionary<string, string> displayName = default(Dictionary<string, string>), string email = default(string), string faxExtension = default(string), string faxNumber = default(string), string inventoryLocationId = default(string), string inventoryProviderId = default(string), bool isActive = default(bool), bool isAtpEnabled = default(bool), bool isInventoryEnabled = default(bool), string manager = default(string), string name = default(string), string number = default(string), OperatingStatus operatingStatus = default(OperatingStatus), string phoneExtension = default(string), string phoneNumber = default(string), FulfillmentSchedule pickUpSchedule = default(FulfillmentSchedule), bool pickUpScheduleManaged = default(bool), Dictionary<string, Object> propertyBag = default(Dictionary<string, Object>), FulfillmentSchedule schedule = default(FulfillmentSchedule), bool supportDelivery = default(bool), bool supportPickUp = default(bool), bool supportShipping = default(bool), bool supportShipToStore = default(bool), string timeZone = default(string), string id = default(string))
        {
            this.Addresses = addresses;
            this.AssociatedScopes = associatedScopes;
            this.DeliverySchedule = deliverySchedule;
            this.DeliveryScheduleManaged = deliveryScheduleManaged;
            this.Description = description;
            this.DisplayName = displayName;
            this.Email = email;
            this.FaxExtension = faxExtension;
            this.FaxNumber = faxNumber;
            this.InventoryLocationId = inventoryLocationId;
            this.InventoryProviderId = inventoryProviderId;
            this.IsActive = isActive;
            this.IsAtpEnabled = isAtpEnabled;
            this.IsInventoryEnabled = isInventoryEnabled;
            this.Manager = manager;
            this.Name = name;
            this.Number = number;
            this.OperatingStatus = operatingStatus;
            this.PhoneExtension = phoneExtension;
            this.PhoneNumber = phoneNumber;
            this.PickUpSchedule = pickUpSchedule;
            this.PickUpScheduleManaged = pickUpScheduleManaged;
            this.PropertyBag = propertyBag;
            this.Schedule = schedule;
            this.SupportDelivery = supportDelivery;
            this.SupportPickUp = supportPickUp;
            this.SupportShipping = supportShipping;
            this.SupportShipToStore = supportShipToStore;
            this.TimeZone = timeZone;
            this.Id = id;
        }

        /// <summary>
        /// The warehouse&#39;s addresses.
        /// </summary>
        /// <value>The warehouse&#39;s addresses.</value>
        [DataMember(Name = "addresses", EmitDefaultValue = false)]
        public List<Address> Addresses { get; set; }

        /// <summary>
        /// The warehouse&#39;s associated scopes.
        /// </summary>
        /// <value>The warehouse&#39;s associated scopes.</value>
        [DataMember(Name = "associatedScopes", EmitDefaultValue = false)]
        public List<string> AssociatedScopes { get; set; }

        /// <summary>
        /// Gets or Sets DeliverySchedule
        /// </summary>
        [DataMember(Name = "deliverySchedule", EmitDefaultValue = false)]
        public FulfillmentSchedule DeliverySchedule { get; set; }

        /// <summary>
        /// A value indicating whether this fulfillment location manage his own schedule for delivery
        /// </summary>
        /// <value>A value indicating whether this fulfillment location manage his own schedule for delivery</value>
        [DataMember(Name = "deliveryScheduleManaged", EmitDefaultValue = true)]
        public bool DeliveryScheduleManaged { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name = "description", EmitDefaultValue = false)]
        public Dictionary<string, string> Description { get; set; }

        /// <summary>
        /// Gets or Sets DisplayName
        /// </summary>
        [DataMember(Name = "displayName", EmitDefaultValue = false)]
        public Dictionary<string, string> DisplayName { get; set; }

        /// <summary>
        /// the email of the warehouse. This could be a specific person&#39;s address or a general customerService@ address depending on the warehouse.
        /// </summary>
        /// <value>the email of the warehouse. This could be a specific person&#39;s address or a general customerService@ address depending on the warehouse.</value>
        [DataMember(Name = "email", EmitDefaultValue = false)]
        public string Email { get; set; }

        /// <summary>
        /// the extension for the fax number of the warehouse.
        /// </summary>
        /// <value>the extension for the fax number of the warehouse.</value>
        [DataMember(Name = "faxExtension", EmitDefaultValue = false)]
        public string FaxExtension { get; set; }

        /// <summary>
        /// the fax number of the warehouse.
        /// </summary>
        /// <value>the fax number of the warehouse.</value>
        [DataMember(Name = "faxNumber", EmitDefaultValue = false)]
        public string FaxNumber { get; set; }

        /// <summary>
        /// The inventory location identifier related to this fulfillment location
        /// </summary>
        /// <value>The inventory location identifier related to this fulfillment location</value>
        [DataMember(Name = "inventoryLocationId", EmitDefaultValue = false)]
        public string InventoryLocationId { get; set; }

        /// <summary>
        /// The inventory provider identifier to use with this fulfillment location
        /// </summary>
        /// <value>The inventory provider identifier to use with this fulfillment location</value>
        [DataMember(Name = "inventoryProviderId", EmitDefaultValue = false)]
        public string InventoryProviderId { get; set; }

        /// <summary>
        /// Is this warehouse currently active. Set this flag to false as an alternative to deleting it and then recreating it a a later date. This allows the warehouse to be hidden from many business processes until re-activated. 
        /// </summary>
        /// <value>Is this warehouse currently active. Set this flag to false as an alternative to deleting it and then recreating it a a later date. This allows the warehouse to be hidden from many business processes until re-activated. </value>
        [DataMember(Name = "isActive", EmitDefaultValue = true)]
        public bool IsActive { get; set; }

        /// <summary>
        /// value indicating whether inventory availability to promise is enabled.
        /// </summary>
        /// <value>value indicating whether inventory availability to promise is enabled.</value>
        [DataMember(Name = "isAtpEnabled", EmitDefaultValue = true)]
        public bool IsAtpEnabled { get; set; }

        /// <summary>
        /// value indicating whether inventory is enabled for this fulfillment location.
        /// </summary>
        /// <value>value indicating whether inventory is enabled for this fulfillment location.</value>
        [DataMember(Name = "isInventoryEnabled", EmitDefaultValue = true)]
        public bool IsInventoryEnabled { get; set; }

        /// <summary>
        /// the full name of the manager of the warehouse.
        /// </summary>
        /// <value>the full name of the manager of the warehouse.</value>
        [DataMember(Name = "manager", EmitDefaultValue = false)]
        public string Manager { get; set; }

        /// <summary>
        /// the name of the warehouse. Each warehouse must have a name that unique in the system.
        /// </summary>
        /// <value>the name of the warehouse. Each warehouse must have a name that unique in the system.</value>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// a business centric number to identify the warehouse that could be used to link the warehouse to external data.
        /// </summary>
        /// <value>a business centric number to identify the warehouse that could be used to link the warehouse to external data.</value>
        [DataMember(Name = "number", EmitDefaultValue = false)]
        public string Number { get; set; }

        /// <summary>
        /// Gets or Sets OperatingStatus
        /// </summary>
        [DataMember(Name = "operatingStatus", EmitDefaultValue = false)]
        public OperatingStatus OperatingStatus { get; set; }

        /// <summary>
        /// the extension for the telephone number of the warehouse.
        /// </summary>
        /// <value>the extension for the telephone number of the warehouse.</value>
        [DataMember(Name = "phoneExtension", EmitDefaultValue = false)]
        public string PhoneExtension { get; set; }

        /// <summary>
        /// the telephone number of the warehouse.
        /// </summary>
        /// <value>the telephone number of the warehouse.</value>
        [DataMember(Name = "phoneNumber", EmitDefaultValue = false)]
        public string PhoneNumber { get; set; }

        /// <summary>
        /// Gets or Sets PickUpSchedule
        /// </summary>
        [DataMember(Name = "pickUpSchedule", EmitDefaultValue = false)]
        public FulfillmentSchedule PickUpSchedule { get; set; }

        /// <summary>
        /// A value indicating whether this fulfillment location manage his own schedule for pickup
        /// </summary>
        /// <value>A value indicating whether this fulfillment location manage his own schedule for pickup</value>
        [DataMember(Name = "pickUpScheduleManaged", EmitDefaultValue = true)]
        public bool PickUpScheduleManaged { get; set; }

        /// <summary>
        /// Gets or Sets PropertyBag
        /// </summary>
        [DataMember(Name = "propertyBag", EmitDefaultValue = false)]
        public Dictionary<string, Object> PropertyBag { get; set; }

        /// <summary>
        /// Gets or Sets Schedule
        /// </summary>
        [DataMember(Name = "schedule", EmitDefaultValue = false)]
        public FulfillmentSchedule Schedule { get; set; }

        /// <summary>
        /// a value indicating whether this warehouse supports delivery for order fulfillment.
        /// </summary>
        /// <value>a value indicating whether this warehouse supports delivery for order fulfillment.</value>
        [DataMember(Name = "supportDelivery", EmitDefaultValue = true)]
        public bool SupportDelivery { get; set; }

        /// <summary>
        /// a value indicating whether this warehouse supports pickup for order fulfillment.
        /// </summary>
        /// <value>a value indicating whether this warehouse supports pickup for order fulfillment.</value>
        [DataMember(Name = "supportPickUp", EmitDefaultValue = true)]
        public bool SupportPickUp { get; set; }

        /// <summary>
        /// a value indicating whether this warehouse supports shipping for order fulfillment.
        /// </summary>
        /// <value>a value indicating whether this warehouse supports shipping for order fulfillment.</value>
        [DataMember(Name = "supportShipping", EmitDefaultValue = true)]
        public bool SupportShipping { get; set; }

        /// <summary>
        /// a value indicating whether this warehouse supports ship to store for order fulfillment.
        /// </summary>
        /// <value>a value indicating whether this warehouse supports ship to store for order fulfillment.</value>
        [DataMember(Name = "supportShipToStore", EmitDefaultValue = true)]
        public bool SupportShipToStore { get; set; }

        /// <summary>
        /// The time zone of the schedules.
        /// </summary>
        /// <value>The time zone of the schedules.</value>
        [DataMember(Name = "timeZone", EmitDefaultValue = false)]
        public string TimeZone { get; set; }

        /// <summary>
        /// the unique identifier of the Warehouse.
        /// </summary>
        /// <value>the unique identifier of the Warehouse.</value>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateWarehouseRequest {\n");
            sb.Append("  Addresses: ").Append(Addresses).Append("\n");
            sb.Append("  AssociatedScopes: ").Append(AssociatedScopes).Append("\n");
            sb.Append("  DeliverySchedule: ").Append(DeliverySchedule).Append("\n");
            sb.Append("  DeliveryScheduleManaged: ").Append(DeliveryScheduleManaged).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  FaxExtension: ").Append(FaxExtension).Append("\n");
            sb.Append("  FaxNumber: ").Append(FaxNumber).Append("\n");
            sb.Append("  InventoryLocationId: ").Append(InventoryLocationId).Append("\n");
            sb.Append("  InventoryProviderId: ").Append(InventoryProviderId).Append("\n");
            sb.Append("  IsActive: ").Append(IsActive).Append("\n");
            sb.Append("  IsAtpEnabled: ").Append(IsAtpEnabled).Append("\n");
            sb.Append("  IsInventoryEnabled: ").Append(IsInventoryEnabled).Append("\n");
            sb.Append("  Manager: ").Append(Manager).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Number: ").Append(Number).Append("\n");
            sb.Append("  OperatingStatus: ").Append(OperatingStatus).Append("\n");
            sb.Append("  PhoneExtension: ").Append(PhoneExtension).Append("\n");
            sb.Append("  PhoneNumber: ").Append(PhoneNumber).Append("\n");
            sb.Append("  PickUpSchedule: ").Append(PickUpSchedule).Append("\n");
            sb.Append("  PickUpScheduleManaged: ").Append(PickUpScheduleManaged).Append("\n");
            sb.Append("  PropertyBag: ").Append(PropertyBag).Append("\n");
            sb.Append("  Schedule: ").Append(Schedule).Append("\n");
            sb.Append("  SupportDelivery: ").Append(SupportDelivery).Append("\n");
            sb.Append("  SupportPickUp: ").Append(SupportPickUp).Append("\n");
            sb.Append("  SupportShipping: ").Append(SupportShipping).Append("\n");
            sb.Append("  SupportShipToStore: ").Append(SupportShipToStore).Append("\n");
            sb.Append("  TimeZone: ").Append(TimeZone).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
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
            return this.Equals(input as CreateWarehouseRequest);
        }

        /// <summary>
        /// Returns true if CreateWarehouseRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of CreateWarehouseRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateWarehouseRequest input)
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
                    this.AssociatedScopes == input.AssociatedScopes ||
                    this.AssociatedScopes != null &&
                    input.AssociatedScopes != null &&
                    this.AssociatedScopes.SequenceEqual(input.AssociatedScopes)
                ) && 
                (
                    this.DeliverySchedule == input.DeliverySchedule ||
                    (this.DeliverySchedule != null &&
                    this.DeliverySchedule.Equals(input.DeliverySchedule))
                ) && 
                (
                    this.DeliveryScheduleManaged == input.DeliveryScheduleManaged ||
                    this.DeliveryScheduleManaged.Equals(input.DeliveryScheduleManaged)
                ) && 
                (
                    this.Description == input.Description ||
                    this.Description != null &&
                    input.Description != null &&
                    this.Description.SequenceEqual(input.Description)
                ) && 
                (
                    this.DisplayName == input.DisplayName ||
                    this.DisplayName != null &&
                    input.DisplayName != null &&
                    this.DisplayName.SequenceEqual(input.DisplayName)
                ) && 
                (
                    this.Email == input.Email ||
                    (this.Email != null &&
                    this.Email.Equals(input.Email))
                ) && 
                (
                    this.FaxExtension == input.FaxExtension ||
                    (this.FaxExtension != null &&
                    this.FaxExtension.Equals(input.FaxExtension))
                ) && 
                (
                    this.FaxNumber == input.FaxNumber ||
                    (this.FaxNumber != null &&
                    this.FaxNumber.Equals(input.FaxNumber))
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
                    this.Manager == input.Manager ||
                    (this.Manager != null &&
                    this.Manager.Equals(input.Manager))
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
                    this.OperatingStatus == input.OperatingStatus ||
                    (this.OperatingStatus != null &&
                    this.OperatingStatus.Equals(input.OperatingStatus))
                ) && 
                (
                    this.PhoneExtension == input.PhoneExtension ||
                    (this.PhoneExtension != null &&
                    this.PhoneExtension.Equals(input.PhoneExtension))
                ) && 
                (
                    this.PhoneNumber == input.PhoneNumber ||
                    (this.PhoneNumber != null &&
                    this.PhoneNumber.Equals(input.PhoneNumber))
                ) && 
                (
                    this.PickUpSchedule == input.PickUpSchedule ||
                    (this.PickUpSchedule != null &&
                    this.PickUpSchedule.Equals(input.PickUpSchedule))
                ) && 
                (
                    this.PickUpScheduleManaged == input.PickUpScheduleManaged ||
                    this.PickUpScheduleManaged.Equals(input.PickUpScheduleManaged)
                ) && 
                (
                    this.PropertyBag == input.PropertyBag ||
                    this.PropertyBag != null &&
                    input.PropertyBag != null &&
                    this.PropertyBag.SequenceEqual(input.PropertyBag)
                ) && 
                (
                    this.Schedule == input.Schedule ||
                    (this.Schedule != null &&
                    this.Schedule.Equals(input.Schedule))
                ) && 
                (
                    this.SupportDelivery == input.SupportDelivery ||
                    this.SupportDelivery.Equals(input.SupportDelivery)
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
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
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
                if (this.AssociatedScopes != null)
                    hashCode = hashCode * 59 + this.AssociatedScopes.GetHashCode();
                if (this.DeliverySchedule != null)
                    hashCode = hashCode * 59 + this.DeliverySchedule.GetHashCode();
                hashCode = hashCode * 59 + this.DeliveryScheduleManaged.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.DisplayName != null)
                    hashCode = hashCode * 59 + this.DisplayName.GetHashCode();
                if (this.Email != null)
                    hashCode = hashCode * 59 + this.Email.GetHashCode();
                if (this.FaxExtension != null)
                    hashCode = hashCode * 59 + this.FaxExtension.GetHashCode();
                if (this.FaxNumber != null)
                    hashCode = hashCode * 59 + this.FaxNumber.GetHashCode();
                if (this.InventoryLocationId != null)
                    hashCode = hashCode * 59 + this.InventoryLocationId.GetHashCode();
                if (this.InventoryProviderId != null)
                    hashCode = hashCode * 59 + this.InventoryProviderId.GetHashCode();
                hashCode = hashCode * 59 + this.IsActive.GetHashCode();
                hashCode = hashCode * 59 + this.IsAtpEnabled.GetHashCode();
                hashCode = hashCode * 59 + this.IsInventoryEnabled.GetHashCode();
                if (this.Manager != null)
                    hashCode = hashCode * 59 + this.Manager.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Number != null)
                    hashCode = hashCode * 59 + this.Number.GetHashCode();
                if (this.OperatingStatus != null)
                    hashCode = hashCode * 59 + this.OperatingStatus.GetHashCode();
                if (this.PhoneExtension != null)
                    hashCode = hashCode * 59 + this.PhoneExtension.GetHashCode();
                if (this.PhoneNumber != null)
                    hashCode = hashCode * 59 + this.PhoneNumber.GetHashCode();
                if (this.PickUpSchedule != null)
                    hashCode = hashCode * 59 + this.PickUpSchedule.GetHashCode();
                hashCode = hashCode * 59 + this.PickUpScheduleManaged.GetHashCode();
                if (this.PropertyBag != null)
                    hashCode = hashCode * 59 + this.PropertyBag.GetHashCode();
                if (this.Schedule != null)
                    hashCode = hashCode * 59 + this.Schedule.GetHashCode();
                hashCode = hashCode * 59 + this.SupportDelivery.GetHashCode();
                hashCode = hashCode * 59 + this.SupportPickUp.GetHashCode();
                hashCode = hashCode * 59 + this.SupportShipping.GetHashCode();
                hashCode = hashCode * 59 + this.SupportShipToStore.GetHashCode();
                if (this.TimeZone != null)
                    hashCode = hashCode * 59 + this.TimeZone.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
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
