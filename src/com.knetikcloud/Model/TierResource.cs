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
    /// TierResource
    /// </summary>
    [DataContract]
    public partial class TierResource :  IEquatable<TierResource>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TierResource" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TierResource() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TierResource" /> class.
        /// </summary>
        /// <param name="AdditionalProperties">A map of additional properties, keyed on the property name.  Must match the names and types defined in the template for this item type.</param>
        /// <param name="Name">The name of the tier.</param>
        /// <param name="RequiredProgress">The required progress for the tier (required).</param>
        public TierResource(Dictionary<string, Property> AdditionalProperties = default(Dictionary<string, Property>), string Name = default(string), int? RequiredProgress = default(int?))
        {
            // to ensure "RequiredProgress" is required (not null)
            if (RequiredProgress == null)
            {
                throw new InvalidDataException("RequiredProgress is a required property for TierResource and cannot be null");
            }
            else
            {
                this.RequiredProgress = RequiredProgress;
            }
            this.AdditionalProperties = AdditionalProperties;
            this.Name = Name;
        }
        
        /// <summary>
        /// A map of additional properties, keyed on the property name.  Must match the names and types defined in the template for this item type
        /// </summary>
        /// <value>A map of additional properties, keyed on the property name.  Must match the names and types defined in the template for this item type</value>
        [DataMember(Name="additional_properties", EmitDefaultValue=false)]
        public Dictionary<string, Property> AdditionalProperties { get; set; }

        /// <summary>
        /// The name of the tier
        /// </summary>
        /// <value>The name of the tier</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// The required progress for the tier
        /// </summary>
        /// <value>The required progress for the tier</value>
        [DataMember(Name="required_progress", EmitDefaultValue=false)]
        public int? RequiredProgress { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TierResource {\n");
            sb.Append("  AdditionalProperties: ").Append(AdditionalProperties).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  RequiredProgress: ").Append(RequiredProgress).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
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
            return this.Equals(input as TierResource);
        }

        /// <summary>
        /// Returns true if TierResource instances are equal
        /// </summary>
        /// <param name="input">Instance of TierResource to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TierResource input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AdditionalProperties == input.AdditionalProperties ||
                    (this.AdditionalProperties != null &&
                    this.AdditionalProperties.SequenceEqual(input.AdditionalProperties))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.RequiredProgress == input.RequiredProgress ||
                    (this.RequiredProgress != null &&
                    this.RequiredProgress.Equals(input.RequiredProgress))
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
                if (this.AdditionalProperties != null)
                    hashCode = hashCode * 59 + this.AdditionalProperties.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.RequiredProgress != null)
                    hashCode = hashCode * 59 + this.RequiredProgress.GetHashCode();
                return hashCode;
            }
        }

    }

}
