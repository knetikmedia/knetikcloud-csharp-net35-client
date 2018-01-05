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
    /// FileGroupPropertyDefinitionResource
    /// </summary>
    [DataContract]
    public partial class FileGroupPropertyDefinitionResource : PropertyDefinitionResource,  IEquatable<FileGroupPropertyDefinitionResource>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FileGroupPropertyDefinitionResource" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected FileGroupPropertyDefinitionResource() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="FileGroupPropertyDefinitionResource" /> class.
        /// </summary>
        /// <param name="Description">The description of the property.</param>
        /// <param name="FieldList">A list of the fields on both the property definition and property of this type.</param>
        /// <param name="FriendlyName">The friendly front-facing name of the property.</param>
        /// <param name="Name">The name of the property (required).</param>
        /// <param name="OptionLabelPath">The JSON path to the option label.</param>
        /// <param name="OptionValuePath">The JSON path to the option value.</param>
        /// <param name="OptionsUrl">URL of service containing the property options (assumed JSON array).</param>
        /// <param name="Required">Whether the property is required (required).</param>
        /// <param name="Type">The type of the property. Used for polymorphic type recognition and thus must match an expected type with additional properties. (required).</param>
        /// <param name="FileType">If provided, a file type that the property must match.</param>
        /// <param name="MaxCount">If provided, the maximum number of files in the group.</param>
        /// <param name="MaxFileSize">If provided, the maximum allowed size per file in bytes.</param>
        /// <param name="MinCount">If provided, the minimum number of files in the group.</param>
        public FileGroupPropertyDefinitionResource(string Description = default(string), PropertyFieldListResource FieldList = default(PropertyFieldListResource), string FriendlyName = default(string), string Name = default(string), string OptionLabelPath = default(string), string OptionValuePath = default(string), string OptionsUrl = default(string), bool? Required = default(bool?), string Type = default(string), string FileType = default(string), int? MaxCount = default(int?), long? MaxFileSize = default(long?), int? MinCount = default(int?))
        {
            // to ensure "Name" is required (not null)
            if (Name == null)
            {
                throw new InvalidDataException("Name is a required property for FileGroupPropertyDefinitionResource and cannot be null");
            }
            else
            {
                this.Name = Name;
            }
            // to ensure "Required" is required (not null)
            if (Required == null)
            {
                throw new InvalidDataException("Required is a required property for FileGroupPropertyDefinitionResource and cannot be null");
            }
            else
            {
                this.Required = Required;
            }
            // to ensure "Type" is required (not null)
            if (Type == null)
            {
                throw new InvalidDataException("Type is a required property for FileGroupPropertyDefinitionResource and cannot be null");
            }
            else
            {
                this.Type = Type;
            }
            this.Description = Description;
            this.FieldList = FieldList;
            this.FriendlyName = FriendlyName;
            this.OptionLabelPath = OptionLabelPath;
            this.OptionValuePath = OptionValuePath;
            this.OptionsUrl = OptionsUrl;
            this.FileType = FileType;
            this.MaxCount = MaxCount;
            this.MaxFileSize = MaxFileSize;
            this.MinCount = MinCount;
        }
        
        /// <summary>
        /// The description of the property
        /// </summary>
        /// <value>The description of the property</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// A list of the fields on both the property definition and property of this type
        /// </summary>
        /// <value>A list of the fields on both the property definition and property of this type</value>
        [DataMember(Name="field_list", EmitDefaultValue=false)]
        public PropertyFieldListResource FieldList { get; set; }

        /// <summary>
        /// The friendly front-facing name of the property
        /// </summary>
        /// <value>The friendly front-facing name of the property</value>
        [DataMember(Name="friendly_name", EmitDefaultValue=false)]
        public string FriendlyName { get; set; }

        /// <summary>
        /// The name of the property
        /// </summary>
        /// <value>The name of the property</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// The JSON path to the option label
        /// </summary>
        /// <value>The JSON path to the option label</value>
        [DataMember(Name="option_label_path", EmitDefaultValue=false)]
        public string OptionLabelPath { get; set; }

        /// <summary>
        /// The JSON path to the option value
        /// </summary>
        /// <value>The JSON path to the option value</value>
        [DataMember(Name="option_value_path", EmitDefaultValue=false)]
        public string OptionValuePath { get; set; }

        /// <summary>
        /// URL of service containing the property options (assumed JSON array)
        /// </summary>
        /// <value>URL of service containing the property options (assumed JSON array)</value>
        [DataMember(Name="options_url", EmitDefaultValue=false)]
        public string OptionsUrl { get; set; }

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
        /// If provided, a file type that the property must match
        /// </summary>
        /// <value>If provided, a file type that the property must match</value>
        [DataMember(Name="file_type", EmitDefaultValue=false)]
        public string FileType { get; set; }

        /// <summary>
        /// If provided, the maximum number of files in the group
        /// </summary>
        /// <value>If provided, the maximum number of files in the group</value>
        [DataMember(Name="max_count", EmitDefaultValue=false)]
        public int? MaxCount { get; set; }

        /// <summary>
        /// If provided, the maximum allowed size per file in bytes
        /// </summary>
        /// <value>If provided, the maximum allowed size per file in bytes</value>
        [DataMember(Name="max_file_size", EmitDefaultValue=false)]
        public long? MaxFileSize { get; set; }

        /// <summary>
        /// If provided, the minimum number of files in the group
        /// </summary>
        /// <value>If provided, the minimum number of files in the group</value>
        [DataMember(Name="min_count", EmitDefaultValue=false)]
        public int? MinCount { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FileGroupPropertyDefinitionResource {\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  FieldList: ").Append(FieldList).Append("\n");
            sb.Append("  FriendlyName: ").Append(FriendlyName).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  OptionLabelPath: ").Append(OptionLabelPath).Append("\n");
            sb.Append("  OptionValuePath: ").Append(OptionValuePath).Append("\n");
            sb.Append("  OptionsUrl: ").Append(OptionsUrl).Append("\n");
            sb.Append("  Required: ").Append(Required).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  FileType: ").Append(FileType).Append("\n");
            sb.Append("  MaxCount: ").Append(MaxCount).Append("\n");
            sb.Append("  MaxFileSize: ").Append(MaxFileSize).Append("\n");
            sb.Append("  MinCount: ").Append(MinCount).Append("\n");
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
            return this.Equals(input as FileGroupPropertyDefinitionResource);
        }

        /// <summary>
        /// Returns true if FileGroupPropertyDefinitionResource instances are equal
        /// </summary>
        /// <param name="input">Instance of FileGroupPropertyDefinitionResource to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FileGroupPropertyDefinitionResource input)
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
                    this.FieldList == input.FieldList ||
                    (this.FieldList != null &&
                    this.FieldList.Equals(input.FieldList))
                ) && 
                (
                    this.FriendlyName == input.FriendlyName ||
                    (this.FriendlyName != null &&
                    this.FriendlyName.Equals(input.FriendlyName))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.OptionLabelPath == input.OptionLabelPath ||
                    (this.OptionLabelPath != null &&
                    this.OptionLabelPath.Equals(input.OptionLabelPath))
                ) && 
                (
                    this.OptionValuePath == input.OptionValuePath ||
                    (this.OptionValuePath != null &&
                    this.OptionValuePath.Equals(input.OptionValuePath))
                ) && 
                (
                    this.OptionsUrl == input.OptionsUrl ||
                    (this.OptionsUrl != null &&
                    this.OptionsUrl.Equals(input.OptionsUrl))
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
                    this.FileType == input.FileType ||
                    (this.FileType != null &&
                    this.FileType.Equals(input.FileType))
                ) && 
                (
                    this.MaxCount == input.MaxCount ||
                    (this.MaxCount != null &&
                    this.MaxCount.Equals(input.MaxCount))
                ) && 
                (
                    this.MaxFileSize == input.MaxFileSize ||
                    (this.MaxFileSize != null &&
                    this.MaxFileSize.Equals(input.MaxFileSize))
                ) && 
                (
                    this.MinCount == input.MinCount ||
                    (this.MinCount != null &&
                    this.MinCount.Equals(input.MinCount))
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
                if (this.FieldList != null)
                    hashCode = hashCode * 59 + this.FieldList.GetHashCode();
                if (this.FriendlyName != null)
                    hashCode = hashCode * 59 + this.FriendlyName.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.OptionLabelPath != null)
                    hashCode = hashCode * 59 + this.OptionLabelPath.GetHashCode();
                if (this.OptionValuePath != null)
                    hashCode = hashCode * 59 + this.OptionValuePath.GetHashCode();
                if (this.OptionsUrl != null)
                    hashCode = hashCode * 59 + this.OptionsUrl.GetHashCode();
                if (this.Required != null)
                    hashCode = hashCode * 59 + this.Required.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.FileType != null)
                    hashCode = hashCode * 59 + this.FileType.GetHashCode();
                if (this.MaxCount != null)
                    hashCode = hashCode * 59 + this.MaxCount.GetHashCode();
                if (this.MaxFileSize != null)
                    hashCode = hashCode * 59 + this.MaxFileSize.GetHashCode();
                if (this.MinCount != null)
                    hashCode = hashCode * 59 + this.MinCount.GetHashCode();
                return hashCode;
            }
        }

    }

}
