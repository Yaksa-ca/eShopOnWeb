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
    /// ShipmentDocumentSummary
    /// </summary>
    [DataContract(Name = "ShipmentDocumentSummary")]
    public partial class ShipmentDocumentSummary : IEquatable<ShipmentDocumentSummary>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ShipmentDocumentSummary" /> class.
        /// </summary>
        /// <param name="documentType">document type..</param>
        /// <param name="id">the id of the shipment document..</param>
        /// <param name="name">name of the document..</param>
        /// <param name="orderId">the id of the order associated to the shipment..</param>
        /// <param name="publicUri">public uri..</param>
        /// <param name="shipmentId">the id of the associated shipment..</param>
        public ShipmentDocumentSummary(string documentType = default(string), string id = default(string), string name = default(string), string orderId = default(string), string publicUri = default(string), string shipmentId = default(string))
        {
            this.DocumentType = documentType;
            this.Id = id;
            this.Name = name;
            this.OrderId = orderId;
            this.PublicUri = publicUri;
            this.ShipmentId = shipmentId;
        }

        /// <summary>
        /// document type.
        /// </summary>
        /// <value>document type.</value>
        [DataMember(Name = "documentType", EmitDefaultValue = false)]
        public string DocumentType { get; set; }

        /// <summary>
        /// the id of the shipment document.
        /// </summary>
        /// <value>the id of the shipment document.</value>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        /// name of the document.
        /// </summary>
        /// <value>name of the document.</value>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// the id of the order associated to the shipment.
        /// </summary>
        /// <value>the id of the order associated to the shipment.</value>
        [DataMember(Name = "orderId", EmitDefaultValue = false)]
        public string OrderId { get; set; }

        /// <summary>
        /// public uri.
        /// </summary>
        /// <value>public uri.</value>
        [DataMember(Name = "publicUri", EmitDefaultValue = false)]
        public string PublicUri { get; set; }

        /// <summary>
        /// the id of the associated shipment.
        /// </summary>
        /// <value>the id of the associated shipment.</value>
        [DataMember(Name = "shipmentId", EmitDefaultValue = false)]
        public string ShipmentId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShipmentDocumentSummary {\n");
            sb.Append("  DocumentType: ").Append(DocumentType).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  OrderId: ").Append(OrderId).Append("\n");
            sb.Append("  PublicUri: ").Append(PublicUri).Append("\n");
            sb.Append("  ShipmentId: ").Append(ShipmentId).Append("\n");
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
            return this.Equals(input as ShipmentDocumentSummary);
        }

        /// <summary>
        /// Returns true if ShipmentDocumentSummary instances are equal
        /// </summary>
        /// <param name="input">Instance of ShipmentDocumentSummary to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ShipmentDocumentSummary input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DocumentType == input.DocumentType ||
                    (this.DocumentType != null &&
                    this.DocumentType.Equals(input.DocumentType))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.OrderId == input.OrderId ||
                    (this.OrderId != null &&
                    this.OrderId.Equals(input.OrderId))
                ) && 
                (
                    this.PublicUri == input.PublicUri ||
                    (this.PublicUri != null &&
                    this.PublicUri.Equals(input.PublicUri))
                ) && 
                (
                    this.ShipmentId == input.ShipmentId ||
                    (this.ShipmentId != null &&
                    this.ShipmentId.Equals(input.ShipmentId))
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
                if (this.DocumentType != null)
                    hashCode = hashCode * 59 + this.DocumentType.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.OrderId != null)
                    hashCode = hashCode * 59 + this.OrderId.GetHashCode();
                if (this.PublicUri != null)
                    hashCode = hashCode * 59 + this.PublicUri.GetHashCode();
                if (this.ShipmentId != null)
                    hashCode = hashCode * 59 + this.ShipmentId.GetHashCode();
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
