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
    /// ItemTemplateResource
    /// </summary>
    [DataContract]
    public partial class ItemTemplateResource :  IEquatable<ItemTemplateResource>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ItemTemplateResource" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ItemTemplateResource() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ItemTemplateResource" /> class.
        /// </summary>
        /// <param name="AllowAdditional">Whether to allow additional properties beyond those specified or not.</param>
        /// <param name="Behaviors">The customized behaviors that are required or default for this type of item.</param>
        /// <param name="Name">The name of the template (required).</param>
        /// <param name="Properties">The customized properties that are present.</param>
        public ItemTemplateResource(bool? AllowAdditional = default(bool?), List<ItemBehaviorDefinitionResource> Behaviors = default(List<ItemBehaviorDefinitionResource>), string Name = default(string), List<PropertyDefinitionResource> Properties = default(List<PropertyDefinitionResource>))
        {
            // to ensure "Name" is required (not null)
            if (Name == null)
            {
                throw new InvalidDataException("Name is a required property for ItemTemplateResource and cannot be null");
            }
            else
            {
                this.Name = Name;
            }
            this.AllowAdditional = AllowAdditional;
            this.Behaviors = Behaviors;
            this.Properties = Properties;
        }
        
        /// <summary>
        /// Whether to allow additional properties beyond those specified or not
        /// </summary>
        /// <value>Whether to allow additional properties beyond those specified or not</value>
        [DataMember(Name="allow_additional", EmitDefaultValue=false)]
        public bool? AllowAdditional { get; set; }

        /// <summary>
        /// The customized behaviors that are required or default for this type of item
        /// </summary>
        /// <value>The customized behaviors that are required or default for this type of item</value>
        [DataMember(Name="behaviors", EmitDefaultValue=false)]
        public List<ItemBehaviorDefinitionResource> Behaviors { get; set; }

        /// <summary>
        /// The date/time this resource was created in seconds since unix epoch
        /// </summary>
        /// <value>The date/time this resource was created in seconds since unix epoch</value>
        [DataMember(Name="created_date", EmitDefaultValue=false)]
        public long? CreatedDate { get; private set; }

        /// <summary>
        /// The id of the template
        /// </summary>
        /// <value>The id of the template</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; private set; }

        /// <summary>
        /// The name of the template
        /// </summary>
        /// <value>The name of the template</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// The customized properties that are present
        /// </summary>
        /// <value>The customized properties that are present</value>
        [DataMember(Name="properties", EmitDefaultValue=false)]
        public List<PropertyDefinitionResource> Properties { get; set; }

        /// <summary>
        /// The date/time this resource was last updated in seconds since unix epoch
        /// </summary>
        /// <value>The date/time this resource was last updated in seconds since unix epoch</value>
        [DataMember(Name="updated_date", EmitDefaultValue=false)]
        public long? UpdatedDate { get; private set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ItemTemplateResource {\n");
            sb.Append("  AllowAdditional: ").Append(AllowAdditional).Append("\n");
            sb.Append("  Behaviors: ").Append(Behaviors).Append("\n");
            sb.Append("  CreatedDate: ").Append(CreatedDate).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Properties: ").Append(Properties).Append("\n");
            sb.Append("  UpdatedDate: ").Append(UpdatedDate).Append("\n");
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
            return this.Equals(input as ItemTemplateResource);
        }

        /// <summary>
        /// Returns true if ItemTemplateResource instances are equal
        /// </summary>
        /// <param name="input">Instance of ItemTemplateResource to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ItemTemplateResource input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AllowAdditional == input.AllowAdditional ||
                    (this.AllowAdditional != null &&
                    this.AllowAdditional.Equals(input.AllowAdditional))
                ) && 
                (
                    this.Behaviors == input.Behaviors ||
                    (this.Behaviors != null &&
                    this.Behaviors.SequenceEqual(input.Behaviors))
                ) && 
                (
                    this.CreatedDate == input.CreatedDate ||
                    (this.CreatedDate != null &&
                    this.CreatedDate.Equals(input.CreatedDate))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Properties == input.Properties ||
                    (this.Properties != null &&
                    this.Properties.SequenceEqual(input.Properties))
                ) && 
                (
                    this.UpdatedDate == input.UpdatedDate ||
                    (this.UpdatedDate != null &&
                    this.UpdatedDate.Equals(input.UpdatedDate))
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
                if (this.AllowAdditional != null)
                    hashCode = hashCode * 59 + this.AllowAdditional.GetHashCode();
                if (this.Behaviors != null)
                    hashCode = hashCode * 59 + this.Behaviors.GetHashCode();
                if (this.CreatedDate != null)
                    hashCode = hashCode * 59 + this.CreatedDate.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Properties != null)
                    hashCode = hashCode * 59 + this.Properties.GetHashCode();
                if (this.UpdatedDate != null)
                    hashCode = hashCode * 59 + this.UpdatedDate.GetHashCode();
                return hashCode;
            }
        }

    }

}
