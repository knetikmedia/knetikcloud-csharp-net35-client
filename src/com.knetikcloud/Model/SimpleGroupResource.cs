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
    /// SimpleGroupResource
    /// </summary>
    [DataContract]
    public partial class SimpleGroupResource :  IEquatable<SimpleGroupResource>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SimpleGroupResource" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SimpleGroupResource() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SimpleGroupResource" /> class.
        /// </summary>
        /// <param name="Name">The name of the group. Max 50 characters (required).</param>
        /// <param name="UniqueName">Unique name used in url and references. Uppercase, lowercase, numbers and hyphens only. Max 50 characters. Cannot be altered once created. Default: random UUID.</param>
        public SimpleGroupResource(string Name = default(string), string UniqueName = default(string))
        {
            // to ensure "Name" is required (not null)
            if (Name == null)
            {
                throw new InvalidDataException("Name is a required property for SimpleGroupResource and cannot be null");
            }
            else
            {
                this.Name = Name;
            }
            this.UniqueName = UniqueName;
        }
        
        /// <summary>
        /// The name of the group. Max 50 characters
        /// </summary>
        /// <value>The name of the group. Max 50 characters</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Unique name used in url and references. Uppercase, lowercase, numbers and hyphens only. Max 50 characters. Cannot be altered once created. Default: random UUID
        /// </summary>
        /// <value>Unique name used in url and references. Uppercase, lowercase, numbers and hyphens only. Max 50 characters. Cannot be altered once created. Default: random UUID</value>
        [DataMember(Name="unique_name", EmitDefaultValue=false)]
        public string UniqueName { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SimpleGroupResource {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  UniqueName: ").Append(UniqueName).Append("\n");
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
            return this.Equals(input as SimpleGroupResource);
        }

        /// <summary>
        /// Returns true if SimpleGroupResource instances are equal
        /// </summary>
        /// <param name="input">Instance of SimpleGroupResource to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SimpleGroupResource input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.UniqueName == input.UniqueName ||
                    (this.UniqueName != null &&
                    this.UniqueName.Equals(input.UniqueName))
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
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.UniqueName != null)
                    hashCode = hashCode * 59 + this.UniqueName.GetHashCode();
                return hashCode;
            }
        }

    }

}
