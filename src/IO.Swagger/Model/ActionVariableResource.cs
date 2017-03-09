/* 
 * Knetik Platform API Documentation latest 
 *
 * This is the spec for the Knetik API.  Use this in conjunction with the documentation found at https://knetikcloud.com
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

namespace IO.Swagger.Model
{
    /// <summary>
    /// ActionVariableResource
    /// </summary>
    [DataContract]
    public partial class ActionVariableResource :  IEquatable<ActionVariableResource>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ActionVariableResource" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ActionVariableResource() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ActionVariableResource" /> class.
        /// </summary>
        /// <param name="Name">The name of the variable (required).</param>
        /// <param name="Optional">Whether this variable is optional and can be left out/null (required).</param>
        /// <param name="Type">The type of the variable (see variable type endpoint for list) (required).</param>
        public ActionVariableResource(string Name = default(string), bool? Optional = default(bool?), string Type = default(string))
        {
            // to ensure "Name" is required (not null)
            if (Name == null)
            {
                throw new InvalidDataException("Name is a required property for ActionVariableResource and cannot be null");
            }
            else
            {
                this.Name = Name;
            }
            // to ensure "Optional" is required (not null)
            if (Optional == null)
            {
                throw new InvalidDataException("Optional is a required property for ActionVariableResource and cannot be null");
            }
            else
            {
                this.Optional = Optional;
            }
            // to ensure "Type" is required (not null)
            if (Type == null)
            {
                throw new InvalidDataException("Type is a required property for ActionVariableResource and cannot be null");
            }
            else
            {
                this.Type = Type;
            }
        }
        
        /// <summary>
        /// The name of the variable
        /// </summary>
        /// <value>The name of the variable</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
        /// <summary>
        /// Whether this variable is optional and can be left out/null
        /// </summary>
        /// <value>Whether this variable is optional and can be left out/null</value>
        [DataMember(Name="optional", EmitDefaultValue=false)]
        public bool? Optional { get; set; }
        /// <summary>
        /// The type of the variable (see variable type endpoint for list)
        /// </summary>
        /// <value>The type of the variable (see variable type endpoint for list)</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ActionVariableResource {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Optional: ").Append(Optional).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
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
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as ActionVariableResource);
        }

        /// <summary>
        /// Returns true if ActionVariableResource instances are equal
        /// </summary>
        /// <param name="other">Instance of ActionVariableResource to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ActionVariableResource other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) && 
                (
                    this.Optional == other.Optional ||
                    this.Optional != null &&
                    this.Optional.Equals(other.Optional)
                ) && 
                (
                    this.Type == other.Type ||
                    this.Type != null &&
                    this.Type.Equals(other.Type)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            // credit: http://stackoverflow.com/a/263416/677735
            unchecked // Overflow is fine, just wrap
            {
                int hash = 41;
                // Suitable nullity checks etc, of course :)
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                if (this.Optional != null)
                    hash = hash * 59 + this.Optional.GetHashCode();
                if (this.Type != null)
                    hash = hash * 59 + this.Type.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
