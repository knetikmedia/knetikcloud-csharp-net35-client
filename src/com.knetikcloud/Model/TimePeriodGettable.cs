/* 
 * Knetik Platform API Documentation latest 
 *
 * This is the spec for the Knetik API.  Use this in conjunction with the documentation found at https://knetikcloud.com.
 *
 * OpenAPI spec version: latest 
 * Contact: support@knetik.com
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using SwaggerDateConverter = com.knetikcloud.Client.SwaggerDateConverter;

namespace com.knetikcloud.Model
{
    /// <summary>
    /// TimePeriodGettable
    /// </summary>
    [DataContract]
    public partial class TimePeriodGettable : Behavior,  IEquatable<TimePeriodGettable>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TimePeriodGettable" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TimePeriodGettable() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TimePeriodGettable" /> class.
        /// </summary>
        /// <param name="Description">Description.</param>
        /// <param name="TypeHint">Used for polymorphic type recognition and thus must match an expected type with additional properties.</param>
        /// <param name="GetLimit">The time period limit (required).</param>
        /// <param name="GroupName">The name of a group of items. Multiple items with the same group name will be limited together, leave null to be assigned a random unique name. It is typical that the other properties here will be the same for all, but this is not enforced and the item being recieved will use its settings..</param>
        /// <param name="TimeLength">The length of time (required).</param>
        /// <param name="UnitOfTime">The unit of time (required).</param>
        public TimePeriodGettable(string Description = default(string), string TypeHint = default(string), int? GetLimit = default(int?), string GroupName = default(string), int? TimeLength = default(int?), string UnitOfTime = default(string))
        {
            // to ensure "GetLimit" is required (not null)
            if (GetLimit == null)
            {
                throw new InvalidDataException("GetLimit is a required property for TimePeriodGettable and cannot be null");
            }
            else
            {
                this.GetLimit = GetLimit;
            }
            // to ensure "TimeLength" is required (not null)
            if (TimeLength == null)
            {
                throw new InvalidDataException("TimeLength is a required property for TimePeriodGettable and cannot be null");
            }
            else
            {
                this.TimeLength = TimeLength;
            }
            // to ensure "UnitOfTime" is required (not null)
            if (UnitOfTime == null)
            {
                throw new InvalidDataException("UnitOfTime is a required property for TimePeriodGettable and cannot be null");
            }
            else
            {
                this.UnitOfTime = UnitOfTime;
            }
            this.Description = Description;
            this.TypeHint = TypeHint;
            this.GroupName = GroupName;
        }
        
        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// Used for polymorphic type recognition and thus must match an expected type with additional properties
        /// </summary>
        /// <value>Used for polymorphic type recognition and thus must match an expected type with additional properties</value>
        [DataMember(Name="type_hint", EmitDefaultValue=false)]
        public string TypeHint { get; set; }

        /// <summary>
        /// The time period limit
        /// </summary>
        /// <value>The time period limit</value>
        [DataMember(Name="get_limit", EmitDefaultValue=false)]
        public int? GetLimit { get; set; }

        /// <summary>
        /// The name of a group of items. Multiple items with the same group name will be limited together, leave null to be assigned a random unique name. It is typical that the other properties here will be the same for all, but this is not enforced and the item being recieved will use its settings.
        /// </summary>
        /// <value>The name of a group of items. Multiple items with the same group name will be limited together, leave null to be assigned a random unique name. It is typical that the other properties here will be the same for all, but this is not enforced and the item being recieved will use its settings.</value>
        [DataMember(Name="group_name", EmitDefaultValue=false)]
        public string GroupName { get; set; }

        /// <summary>
        /// The length of time
        /// </summary>
        /// <value>The length of time</value>
        [DataMember(Name="time_length", EmitDefaultValue=false)]
        public int? TimeLength { get; set; }

        /// <summary>
        /// The unit of time
        /// </summary>
        /// <value>The unit of time</value>
        [DataMember(Name="unit_of_time", EmitDefaultValue=false)]
        public string UnitOfTime { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TimePeriodGettable {\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  TypeHint: ").Append(TypeHint).Append("\n");
            sb.Append("  GetLimit: ").Append(GetLimit).Append("\n");
            sb.Append("  GroupName: ").Append(GroupName).Append("\n");
            sb.Append("  TimeLength: ").Append(TimeLength).Append("\n");
            sb.Append("  UnitOfTime: ").Append(UnitOfTime).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public  new string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as TimePeriodGettable);
        }

        /// <summary>
        /// Returns true if TimePeriodGettable instances are equal
        /// </summary>
        /// <param name="input">Instance of TimePeriodGettable to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TimePeriodGettable input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.TypeHint == input.TypeHint ||
                    (this.TypeHint != null &&
                    this.TypeHint.Equals(input.TypeHint))
                ) && 
                (
                    this.GetLimit == input.GetLimit ||
                    (this.GetLimit != null &&
                    this.GetLimit.Equals(input.GetLimit))
                ) && 
                (
                    this.GroupName == input.GroupName ||
                    (this.GroupName != null &&
                    this.GroupName.Equals(input.GroupName))
                ) && 
                (
                    this.TimeLength == input.TimeLength ||
                    (this.TimeLength != null &&
                    this.TimeLength.Equals(input.TimeLength))
                ) && 
                (
                    this.UnitOfTime == input.UnitOfTime ||
                    (this.UnitOfTime != null &&
                    this.UnitOfTime.Equals(input.UnitOfTime))
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
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.TypeHint != null)
                    hashCode = hashCode * 59 + this.TypeHint.GetHashCode();
                if (this.GetLimit != null)
                    hashCode = hashCode * 59 + this.GetLimit.GetHashCode();
                if (this.GroupName != null)
                    hashCode = hashCode * 59 + this.GroupName.GetHashCode();
                if (this.TimeLength != null)
                    hashCode = hashCode * 59 + this.TimeLength.GetHashCode();
                if (this.UnitOfTime != null)
                    hashCode = hashCode * 59 + this.UnitOfTime.GetHashCode();
                return hashCode;
            }
        }

    }

}
