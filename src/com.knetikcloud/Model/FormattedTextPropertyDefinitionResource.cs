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
    /// FormattedTextPropertyDefinitionResource
    /// </summary>
    [DataContract]
    public partial class FormattedTextPropertyDefinitionResource : PropertyDefinitionResource,  IEquatable<FormattedTextPropertyDefinitionResource>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FormattedTextPropertyDefinitionResource" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected FormattedTextPropertyDefinitionResource() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="FormattedTextPropertyDefinitionResource" /> class.
        /// </summary>
        /// <param name="FieldList">A list of the fields on both the property definition and property of this type.</param>
        /// <param name="Name">The name of the property (required).</param>
        /// <param name="Required">Whether the property is required (required).</param>
        /// <param name="Type">The type of the property. Used for polymorphic type recognition and thus must match an expected type with additional properties. (required).</param>
        /// <param name="MaxLength">If provided, the maximum length of the text.</param>
        public FormattedTextPropertyDefinitionResource(PropertyFieldListResource FieldList = default(PropertyFieldListResource), string Name = default(string), bool? Required = default(bool?), string Type = default(string), int? MaxLength = default(int?))
        {
            // to ensure "Name" is required (not null)
            if (Name == null)
            {
                throw new InvalidDataException("Name is a required property for FormattedTextPropertyDefinitionResource and cannot be null");
            }
            else
            {
                this.Name = Name;
            }
            // to ensure "Required" is required (not null)
            if (Required == null)
            {
                throw new InvalidDataException("Required is a required property for FormattedTextPropertyDefinitionResource and cannot be null");
            }
            else
            {
                this.Required = Required;
            }
            // to ensure "Type" is required (not null)
            if (Type == null)
            {
                throw new InvalidDataException("Type is a required property for FormattedTextPropertyDefinitionResource and cannot be null");
            }
            else
            {
                this.Type = Type;
            }
            this.FieldList = FieldList;
            this.MaxLength = MaxLength;
        }
        
        /// <summary>
        /// A list of the fields on both the property definition and property of this type
        /// </summary>
        /// <value>A list of the fields on both the property definition and property of this type</value>
        [DataMember(Name="field_list", EmitDefaultValue=false)]
        public PropertyFieldListResource FieldList { get; set; }

        /// <summary>
        /// The name of the property
        /// </summary>
        /// <value>The name of the property</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Whether the property is required
        /// </summary>
        /// <value>Whether the property is required</value>
        [DataMember(Name="required", EmitDefaultValue=false)]
        public bool? Required { get; set; }

        /// <summary>
        /// The type of the property. Used for polymorphic type recognition and thus must match an expected type with additional properties.
        /// </summary>
        /// <value>The type of the property. Used for polymorphic type recognition and thus must match an expected type with additional properties.</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }

        /// <summary>
        /// If provided, the maximum length of the text
        /// </summary>
        /// <value>If provided, the maximum length of the text</value>
        [DataMember(Name="max_length", EmitDefaultValue=false)]
        public int? MaxLength { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FormattedTextPropertyDefinitionResource {\n");
            sb.Append("  FieldList: ").Append(FieldList).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Required: ").Append(Required).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  MaxLength: ").Append(MaxLength).Append("\n");
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
            return this.Equals(input as FormattedTextPropertyDefinitionResource);
        }

        /// <summary>
        /// Returns true if FormattedTextPropertyDefinitionResource instances are equal
        /// </summary>
        /// <param name="input">Instance of FormattedTextPropertyDefinitionResource to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FormattedTextPropertyDefinitionResource input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.FieldList == input.FieldList ||
                    (this.FieldList != null &&
                    this.FieldList.Equals(input.FieldList))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Required == input.Required ||
                    (this.Required != null &&
                    this.Required.Equals(input.Required))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.MaxLength == input.MaxLength ||
                    (this.MaxLength != null &&
                    this.MaxLength.Equals(input.MaxLength))
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
                if (this.FieldList != null)
                    hashCode = hashCode * 59 + this.FieldList.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Required != null)
                    hashCode = hashCode * 59 + this.Required.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.MaxLength != null)
                    hashCode = hashCode * 59 + this.MaxLength.GetHashCode();
                return hashCode;
            }
        }

    }

}
