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
    /// DailyScheduleException
    /// </summary>
    [DataContract(Name = "DailyScheduleException")]
    public partial class DailyScheduleException : IEquatable<DailyScheduleException>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DailyScheduleException" /> class.
        /// </summary>
        /// <param name="endDate">Gets or sets the date on which the exception ends..</param>
        /// <param name="id">The unique identifier for this exception..</param>
        /// <param name="isClosed">Indicates whether the Store/Warehouse is closed on that day..</param>
        /// <param name="isRecurrent">Indicating whether the exception is recurrent, thus applying on the same date every year..</param>
        /// <param name="name">The name given for the exception for identification purpose..</param>
        /// <param name="openingTime">openingTime.</param>
        /// <param name="startDate">The date on which the exception starts..</param>
        public DailyScheduleException(DateTime endDate = default(DateTime), string id = default(string), bool isClosed = default(bool), bool isRecurrent = default(bool), string name = default(string), ScheduleInterval openingTime = default(ScheduleInterval), DateTime startDate = default(DateTime))
        {
            this.EndDate = endDate;
            this.Id = id;
            this.IsClosed = isClosed;
            this.IsRecurrent = isRecurrent;
            this.Name = name;
            this.OpeningTime = openingTime;
            this.StartDate = startDate;
        }

        /// <summary>
        /// Gets or sets the date on which the exception ends.
        /// </summary>
        /// <value>Gets or sets the date on which the exception ends.</value>
        [DataMember(Name = "endDate", EmitDefaultValue = false)]
        public DateTime EndDate { get; set; }

        /// <summary>
        /// The unique identifier for this exception.
        /// </summary>
        /// <value>The unique identifier for this exception.</value>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        /// Indicates whether the Store/Warehouse is closed on that day.
        /// </summary>
        /// <value>Indicates whether the Store/Warehouse is closed on that day.</value>
        [DataMember(Name = "isClosed", EmitDefaultValue = true)]
        public bool IsClosed { get; set; }

        /// <summary>
        /// Indicating whether the exception is recurrent, thus applying on the same date every year.
        /// </summary>
        /// <value>Indicating whether the exception is recurrent, thus applying on the same date every year.</value>
        [DataMember(Name = "isRecurrent", EmitDefaultValue = true)]
        public bool IsRecurrent { get; set; }

        /// <summary>
        /// The name given for the exception for identification purpose.
        /// </summary>
        /// <value>The name given for the exception for identification purpose.</value>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets OpeningTime
        /// </summary>
        [DataMember(Name = "openingTime", EmitDefaultValue = false)]
        public ScheduleInterval OpeningTime { get; set; }

        /// <summary>
        /// The date on which the exception starts.
        /// </summary>
        /// <value>The date on which the exception starts.</value>
        [DataMember(Name = "startDate", EmitDefaultValue = false)]
        public DateTime StartDate { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DailyScheduleException {\n");
            sb.Append("  EndDate: ").Append(EndDate).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  IsClosed: ").Append(IsClosed).Append("\n");
            sb.Append("  IsRecurrent: ").Append(IsRecurrent).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  OpeningTime: ").Append(OpeningTime).Append("\n");
            sb.Append("  StartDate: ").Append(StartDate).Append("\n");
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
            return this.Equals(input as DailyScheduleException);
        }

        /// <summary>
        /// Returns true if DailyScheduleException instances are equal
        /// </summary>
        /// <param name="input">Instance of DailyScheduleException to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DailyScheduleException input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.EndDate == input.EndDate ||
                    (this.EndDate != null &&
                    this.EndDate.Equals(input.EndDate))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.IsClosed == input.IsClosed ||
                    this.IsClosed.Equals(input.IsClosed)
                ) && 
                (
                    this.IsRecurrent == input.IsRecurrent ||
                    this.IsRecurrent.Equals(input.IsRecurrent)
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.OpeningTime == input.OpeningTime ||
                    (this.OpeningTime != null &&
                    this.OpeningTime.Equals(input.OpeningTime))
                ) && 
                (
                    this.StartDate == input.StartDate ||
                    (this.StartDate != null &&
                    this.StartDate.Equals(input.StartDate))
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
                if (this.EndDate != null)
                    hashCode = hashCode * 59 + this.EndDate.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                hashCode = hashCode * 59 + this.IsClosed.GetHashCode();
                hashCode = hashCode * 59 + this.IsRecurrent.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.OpeningTime != null)
                    hashCode = hashCode * 59 + this.OpeningTime.GetHashCode();
                if (this.StartDate != null)
                    hashCode = hashCode * 59 + this.StartDate.GetHashCode();
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
