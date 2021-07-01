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
    /// Long running tasks perform batch processing.
    /// </summary>
    [DataContract(Name = "RemoveScheduledTaskTriggerRequest")]
    public partial class RemoveScheduledTaskTriggerRequest : IEquatable<RemoveScheduledTaskTriggerRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RemoveScheduledTaskTriggerRequest" /> class.
        /// </summary>
        /// <param name="taskGroup">the affinity group of the scheduled job..</param>
        /// <param name="taskName">the name of the scheduled job..</param>
        /// <param name="triggerGroup">the trigger affinity group..</param>
        /// <param name="triggerName">the trigger name..</param>
        public RemoveScheduledTaskTriggerRequest(string taskGroup = default(string), string taskName = default(string), string triggerGroup = default(string), string triggerName = default(string))
        {
            this.TaskGroup = taskGroup;
            this.TaskName = taskName;
            this.TriggerGroup = triggerGroup;
            this.TriggerName = triggerName;
        }

        /// <summary>
        /// the affinity group of the scheduled job.
        /// </summary>
        /// <value>the affinity group of the scheduled job.</value>
        [DataMember(Name = "taskGroup", EmitDefaultValue = false)]
        public string TaskGroup { get; set; }

        /// <summary>
        /// the name of the scheduled job.
        /// </summary>
        /// <value>the name of the scheduled job.</value>
        [DataMember(Name = "taskName", EmitDefaultValue = false)]
        public string TaskName { get; set; }

        /// <summary>
        /// the trigger affinity group.
        /// </summary>
        /// <value>the trigger affinity group.</value>
        [DataMember(Name = "triggerGroup", EmitDefaultValue = false)]
        public string TriggerGroup { get; set; }

        /// <summary>
        /// the trigger name.
        /// </summary>
        /// <value>the trigger name.</value>
        [DataMember(Name = "triggerName", EmitDefaultValue = false)]
        public string TriggerName { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RemoveScheduledTaskTriggerRequest {\n");
            sb.Append("  TaskGroup: ").Append(TaskGroup).Append("\n");
            sb.Append("  TaskName: ").Append(TaskName).Append("\n");
            sb.Append("  TriggerGroup: ").Append(TriggerGroup).Append("\n");
            sb.Append("  TriggerName: ").Append(TriggerName).Append("\n");
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
            return this.Equals(input as RemoveScheduledTaskTriggerRequest);
        }

        /// <summary>
        /// Returns true if RemoveScheduledTaskTriggerRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of RemoveScheduledTaskTriggerRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RemoveScheduledTaskTriggerRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.TaskGroup == input.TaskGroup ||
                    (this.TaskGroup != null &&
                    this.TaskGroup.Equals(input.TaskGroup))
                ) && 
                (
                    this.TaskName == input.TaskName ||
                    (this.TaskName != null &&
                    this.TaskName.Equals(input.TaskName))
                ) && 
                (
                    this.TriggerGroup == input.TriggerGroup ||
                    (this.TriggerGroup != null &&
                    this.TriggerGroup.Equals(input.TriggerGroup))
                ) && 
                (
                    this.TriggerName == input.TriggerName ||
                    (this.TriggerName != null &&
                    this.TriggerName.Equals(input.TriggerName))
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
                if (this.TaskGroup != null)
                    hashCode = hashCode * 59 + this.TaskGroup.GetHashCode();
                if (this.TaskName != null)
                    hashCode = hashCode * 59 + this.TaskName.GetHashCode();
                if (this.TriggerGroup != null)
                    hashCode = hashCode * 59 + this.TriggerGroup.GetHashCode();
                if (this.TriggerName != null)
                    hashCode = hashCode * 59 + this.TriggerName.GetHashCode();
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
