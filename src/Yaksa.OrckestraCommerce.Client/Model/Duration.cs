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
    /// Duration
    /// </summary>
    [DataContract(Name = "Duration")]
    public partial class Duration : IEquatable<Duration>, IValidatableObject
    {
        /// <summary>
        ///  Gets or sets the time scale.
        /// </summary>
        /// <value> Gets or sets the time scale.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TimeScaleEnum
        {
            /// <summary>
            /// Enum Minutes for value: Minutes
            /// </summary>
            [EnumMember(Value = "Minutes")]
            Minutes = 1,

            /// <summary>
            /// Enum Hours for value: Hours
            /// </summary>
            [EnumMember(Value = "Hours")]
            Hours = 2,

            /// <summary>
            /// Enum Days for value: Days
            /// </summary>
            [EnumMember(Value = "Days")]
            Days = 3

        }


        /// <summary>
        ///  Gets or sets the time scale.
        /// </summary>
        /// <value> Gets or sets the time scale.</value>
        [DataMember(Name = "timeScale", EmitDefaultValue = false)]
        public TimeScaleEnum? TimeScale { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Duration" /> class.
        /// </summary>
        /// <param name="time">the number of minutes/hours/days for this duration..</param>
        /// <param name="timeScale"> Gets or sets the time scale..</param>
        public Duration(double time = default(double), TimeScaleEnum? timeScale = default(TimeScaleEnum?))
        {
            this.Time = time;
            this.TimeScale = timeScale;
        }

        /// <summary>
        /// the number of minutes/hours/days for this duration.
        /// </summary>
        /// <value>the number of minutes/hours/days for this duration.</value>
        [DataMember(Name = "time", EmitDefaultValue = false)]
        public double Time { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Duration {\n");
            sb.Append("  Time: ").Append(Time).Append("\n");
            sb.Append("  TimeScale: ").Append(TimeScale).Append("\n");
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
            return this.Equals(input as Duration);
        }

        /// <summary>
        /// Returns true if Duration instances are equal
        /// </summary>
        /// <param name="input">Instance of Duration to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Duration input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Time == input.Time ||
                    this.Time.Equals(input.Time)
                ) && 
                (
                    this.TimeScale == input.TimeScale ||
                    this.TimeScale.Equals(input.TimeScale)
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
                hashCode = hashCode * 59 + this.Time.GetHashCode();
                hashCode = hashCode * 59 + this.TimeScale.GetHashCode();
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
