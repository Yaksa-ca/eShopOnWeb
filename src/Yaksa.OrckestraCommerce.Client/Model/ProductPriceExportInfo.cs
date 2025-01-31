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
    /// ProductPriceExportInfo
    /// </summary>
    [DataContract(Name = "ProductPriceExportInfo")]
    public partial class ProductPriceExportInfo : IEquatable<ProductPriceExportInfo>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProductPriceExportInfo" /> class.
        /// </summary>
        /// <param name="pid">The unique identifier of the product to which the pricing is set.</param>
        /// <param name="prs">The prices for each price list..</param>
        /// <param name="vs">The prices for the product variants..</param>
        public ProductPriceExportInfo(string pid = default(string), List<PriceExportInfo> prs = default(List<PriceExportInfo>), List<VariantPriceExportInfo> vs = default(List<VariantPriceExportInfo>))
        {
            this.Pid = pid;
            this.Prs = prs;
            this.Vs = vs;
        }

        /// <summary>
        /// The unique identifier of the product to which the pricing is set
        /// </summary>
        /// <value>The unique identifier of the product to which the pricing is set</value>
        [DataMember(Name = "pid", EmitDefaultValue = false)]
        public string Pid { get; set; }

        /// <summary>
        /// The prices for each price list.
        /// </summary>
        /// <value>The prices for each price list.</value>
        [DataMember(Name = "prs", EmitDefaultValue = false)]
        public List<PriceExportInfo> Prs { get; set; }

        /// <summary>
        /// The prices for the product variants.
        /// </summary>
        /// <value>The prices for the product variants.</value>
        [DataMember(Name = "vs", EmitDefaultValue = false)]
        public List<VariantPriceExportInfo> Vs { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ProductPriceExportInfo {\n");
            sb.Append("  Pid: ").Append(Pid).Append("\n");
            sb.Append("  Prs: ").Append(Prs).Append("\n");
            sb.Append("  Vs: ").Append(Vs).Append("\n");
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
            return this.Equals(input as ProductPriceExportInfo);
        }

        /// <summary>
        /// Returns true if ProductPriceExportInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of ProductPriceExportInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ProductPriceExportInfo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Pid == input.Pid ||
                    (this.Pid != null &&
                    this.Pid.Equals(input.Pid))
                ) && 
                (
                    this.Prs == input.Prs ||
                    this.Prs != null &&
                    input.Prs != null &&
                    this.Prs.SequenceEqual(input.Prs)
                ) && 
                (
                    this.Vs == input.Vs ||
                    this.Vs != null &&
                    input.Vs != null &&
                    this.Vs.SequenceEqual(input.Vs)
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
                if (this.Pid != null)
                    hashCode = hashCode * 59 + this.Pid.GetHashCode();
                if (this.Prs != null)
                    hashCode = hashCode * 59 + this.Prs.GetHashCode();
                if (this.Vs != null)
                    hashCode = hashCode * 59 + this.Vs.GetHashCode();
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
