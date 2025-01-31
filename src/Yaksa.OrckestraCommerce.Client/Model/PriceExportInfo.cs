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
    /// PriceExportInfo
    /// </summary>
    [DataContract(Name = "PriceExportInfo")]
    public partial class PriceExportInfo : IEquatable<PriceExportInfo>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PriceExportInfo" /> class.
        /// </summary>
        /// <param name="p">of the price of the Product.</param>
        /// <param name="plid">the unique identifier of the PriceList.</param>
        public PriceExportInfo(double p = default(double), string plid = default(string))
        {
            this.P = p;
            this.Plid = plid;
        }

        /// <summary>
        /// of the price of the Product
        /// </summary>
        /// <value>of the price of the Product</value>
        [DataMember(Name = "p", EmitDefaultValue = false)]
        public double P { get; set; }

        /// <summary>
        /// the unique identifier of the PriceList
        /// </summary>
        /// <value>the unique identifier of the PriceList</value>
        [DataMember(Name = "plid", EmitDefaultValue = false)]
        public string Plid { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PriceExportInfo {\n");
            sb.Append("  P: ").Append(P).Append("\n");
            sb.Append("  Plid: ").Append(Plid).Append("\n");
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
            return this.Equals(input as PriceExportInfo);
        }

        /// <summary>
        /// Returns true if PriceExportInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of PriceExportInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PriceExportInfo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.P == input.P ||
                    this.P.Equals(input.P)
                ) && 
                (
                    this.Plid == input.Plid ||
                    (this.Plid != null &&
                    this.Plid.Equals(input.Plid))
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
                hashCode = hashCode * 59 + this.P.GetHashCode();
                if (this.Plid != null)
                    hashCode = hashCode * 59 + this.Plid.GetHashCode();
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
