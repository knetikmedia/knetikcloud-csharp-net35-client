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
    /// GroupResource
    /// </summary>
    [DataContract]
    public partial class GroupResource :  IEquatable<GroupResource>
    {
        /// <summary>
        /// The status which describes whether other users can freely join the group or not
        /// </summary>
        /// <value>The status which describes whether other users can freely join the group or not</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StatusEnum
        {
            
            /// <summary>
            /// Enum Open for "open"
            /// </summary>
            [EnumMember(Value = "open")]
            Open,
            
            /// <summary>
            /// Enum Closed for "closed"
            /// </summary>
            [EnumMember(Value = "closed")]
            Closed
        }

        /// <summary>
        /// The status which describes whether other users can freely join the group or not
        /// </summary>
        /// <value>The status which describes whether other users can freely join the group or not</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public StatusEnum? Status { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="GroupResource" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GroupResource() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="GroupResource" /> class.
        /// </summary>
        /// <param name="AdditionalProperties">A map of additional properties, keyed on the property name.  Must match the names and types defined in the template for this item type.</param>
        /// <param name="Description">A description of the group. Max 250 characters.</param>
        /// <param name="MessageOfTheDay">A message of the day for members of the group.</param>
        /// <param name="Name">The name of the group. Max 50 characters (required).</param>
        /// <param name="Parent">The unique name of another group that this group is a subset of.</param>
        /// <param name="Status">The status which describes whether other users can freely join the group or not (required).</param>
        /// <param name="Template">A group template this group is validated against. May be null and no validation of additional_properties will be done.</param>
        /// <param name="UniqueName">Unique name used in url and references. Uppercase, lowercase, numbers and hyphens only. Max 50 characters. Cannot be altered once created (required).</param>
        public GroupResource(Dictionary<string, Property> AdditionalProperties = default(Dictionary<string, Property>), string Description = default(string), string MessageOfTheDay = default(string), string Name = default(string), string Parent = default(string), StatusEnum? Status = default(StatusEnum?), string Template = default(string), string UniqueName = default(string))
        {
            // to ensure "Name" is required (not null)
            if (Name == null)
            {
                throw new InvalidDataException("Name is a required property for GroupResource and cannot be null");
            }
            else
            {
                this.Name = Name;
            }
            // to ensure "Status" is required (not null)
            if (Status == null)
            {
                throw new InvalidDataException("Status is a required property for GroupResource and cannot be null");
            }
            else
            {
                this.Status = Status;
            }
            // to ensure "UniqueName" is required (not null)
            if (UniqueName == null)
            {
                throw new InvalidDataException("UniqueName is a required property for GroupResource and cannot be null");
            }
            else
            {
                this.UniqueName = UniqueName;
            }
            this.AdditionalProperties = AdditionalProperties;
            this.Description = Description;
            this.MessageOfTheDay = MessageOfTheDay;
            this.Parent = Parent;
            this.Template = Template;
        }
        
        /// <summary>
        /// A map of additional properties, keyed on the property name.  Must match the names and types defined in the template for this item type
        /// </summary>
        /// <value>A map of additional properties, keyed on the property name.  Must match the names and types defined in the template for this item type</value>
        [DataMember(Name="additional_properties", EmitDefaultValue=false)]
        public Dictionary<string, Property> AdditionalProperties { get; set; }

        /// <summary>
        /// A description of the group. Max 250 characters
        /// </summary>
        /// <value>A description of the group. Max 250 characters</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// The number of users in the group
        /// </summary>
        /// <value>The number of users in the group</value>
        [DataMember(Name="member_count", EmitDefaultValue=false)]
        public int? MemberCount { get; private set; }

        /// <summary>
        /// A message of the day for members of the group
        /// </summary>
        /// <value>A message of the day for members of the group</value>
        [DataMember(Name="message_of_the_day", EmitDefaultValue=false)]
        public string MessageOfTheDay { get; set; }

        /// <summary>
        /// The name of the group. Max 50 characters
        /// </summary>
        /// <value>The name of the group. Max 50 characters</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// The unique name of another group that this group is a subset of
        /// </summary>
        /// <value>The unique name of another group that this group is a subset of</value>
        [DataMember(Name="parent", EmitDefaultValue=false)]
        public string Parent { get; set; }


        /// <summary>
        /// The number of users in child groups
        /// </summary>
        /// <value>The number of users in child groups</value>
        [DataMember(Name="sub_member_count", EmitDefaultValue=false)]
        public int? SubMemberCount { get; private set; }

        /// <summary>
        /// A group template this group is validated against. May be null and no validation of additional_properties will be done
        /// </summary>
        /// <value>A group template this group is validated against. May be null and no validation of additional_properties will be done</value>
        [DataMember(Name="template", EmitDefaultValue=false)]
        public string Template { get; set; }

        /// <summary>
        /// Unique name used in url and references. Uppercase, lowercase, numbers and hyphens only. Max 50 characters. Cannot be altered once created
        /// </summary>
        /// <value>Unique name used in url and references. Uppercase, lowercase, numbers and hyphens only. Max 50 characters. Cannot be altered once created</value>
        [DataMember(Name="unique_name", EmitDefaultValue=false)]
        public string UniqueName { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GroupResource {\n");
            sb.Append("  AdditionalProperties: ").Append(AdditionalProperties).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  MemberCount: ").Append(MemberCount).Append("\n");
            sb.Append("  MessageOfTheDay: ").Append(MessageOfTheDay).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Parent: ").Append(Parent).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  SubMemberCount: ").Append(SubMemberCount).Append("\n");
            sb.Append("  Template: ").Append(Template).Append("\n");
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
            return this.Equals(input as GroupResource);
        }

        /// <summary>
        /// Returns true if GroupResource instances are equal
        /// </summary>
        /// <param name="input">Instance of GroupResource to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GroupResource input)
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
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.MemberCount == input.MemberCount ||
                    (this.MemberCount != null &&
                    this.MemberCount.Equals(input.MemberCount))
                ) && 
                (
                    this.MessageOfTheDay == input.MessageOfTheDay ||
                    (this.MessageOfTheDay != null &&
                    this.MessageOfTheDay.Equals(input.MessageOfTheDay))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Parent == input.Parent ||
                    (this.Parent != null &&
                    this.Parent.Equals(input.Parent))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.SubMemberCount == input.SubMemberCount ||
                    (this.SubMemberCount != null &&
                    this.SubMemberCount.Equals(input.SubMemberCount))
                ) && 
                (
                    this.Template == input.Template ||
                    (this.Template != null &&
                    this.Template.Equals(input.Template))
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
                if (this.AdditionalProperties != null)
                    hashCode = hashCode * 59 + this.AdditionalProperties.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.MemberCount != null)
                    hashCode = hashCode * 59 + this.MemberCount.GetHashCode();
                if (this.MessageOfTheDay != null)
                    hashCode = hashCode * 59 + this.MessageOfTheDay.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Parent != null)
                    hashCode = hashCode * 59 + this.Parent.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.SubMemberCount != null)
                    hashCode = hashCode * 59 + this.SubMemberCount.GetHashCode();
                if (this.Template != null)
                    hashCode = hashCode * 59 + this.Template.GetHashCode();
                if (this.UniqueName != null)
                    hashCode = hashCode * 59 + this.UniqueName.GetHashCode();
                return hashCode;
            }
        }

    }

}