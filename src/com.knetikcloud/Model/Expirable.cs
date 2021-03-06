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
    /// Expirable
    /// </summary>
    [DataContract]
    public partial class Expirable : Behavior,  IEquatable<Expirable>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Expirable" /> class.
        /// </summary>
        /// <param name="Description">Description.</param>
        /// <param name="TypeHint">Used for polymorphic type recognition and thus must match an expected type with additional properties.</param>
        /// <param name="TimeLength">The length of time.</param>
        /// <param name="UnitOfTime">The unit of time.</param>
        public Expirable(string Description = default(string), string TypeHint = default(string), int? TimeLength = default(int?), string UnitOfTime = default(string))
        {
            this.Description = Description;
            this.TypeHint = TypeHint;
            this.TimeLength = TimeLength;
            this.UnitOfTime = UnitOfTime;
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
            sb.Append("class Expirable {\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  TypeHint: ").Append(TypeHint).Append("\n");
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
            return this.Equals(input as Expirable);
        }

        /// <summary>
        /// Returns true if Expirable instances are equal
        /// </summary>
        /// <param name="input">Instance of Expirable to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Expirable input)
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
                if (this.TimeLength != null)
                    hashCode = hashCode * 59 + this.TimeLength.GetHashCode();
                if (this.UnitOfTime != null)
                    hashCode = hashCode * 59 + this.UnitOfTime.GetHashCode();
                return hashCode;
            }
        }

    }

}
