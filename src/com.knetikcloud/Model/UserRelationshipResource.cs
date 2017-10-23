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
    /// UserRelationshipResource
    /// </summary>
    [DataContract]
    public partial class UserRelationshipResource :  IEquatable<UserRelationshipResource>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserRelationshipResource" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected UserRelationshipResource() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="UserRelationshipResource" /> class.
        /// </summary>
        /// <param name="Child">The child in the relationship (required).</param>
        /// <param name="Context">Context about the relationship or its type.</param>
        /// <param name="Parent">The parent in the relationship (required).</param>
        public UserRelationshipResource(SimpleUserResource Child = default(SimpleUserResource), string Context = default(string), SimpleUserResource Parent = default(SimpleUserResource))
        {
            // to ensure "Child" is required (not null)
            if (Child == null)
            {
                throw new InvalidDataException("Child is a required property for UserRelationshipResource and cannot be null");
            }
            else
            {
                this.Child = Child;
            }
            // to ensure "Parent" is required (not null)
            if (Parent == null)
            {
                throw new InvalidDataException("Parent is a required property for UserRelationshipResource and cannot be null");
            }
            else
            {
                this.Parent = Parent;
            }
            this.Context = Context;
        }
        
        /// <summary>
        /// The child in the relationship
        /// </summary>
        /// <value>The child in the relationship</value>
        [DataMember(Name="child", EmitDefaultValue=false)]
        public SimpleUserResource Child { get; set; }

        /// <summary>
        /// Context about the relationship or its type
        /// </summary>
        /// <value>Context about the relationship or its type</value>
        [DataMember(Name="context", EmitDefaultValue=false)]
        public string Context { get; set; }

        /// <summary>
        /// A generated unique id. Read-Only
        /// </summary>
        /// <value>A generated unique id. Read-Only</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; private set; }

        /// <summary>
        /// The parent in the relationship
        /// </summary>
        /// <value>The parent in the relationship</value>
        [DataMember(Name="parent", EmitDefaultValue=false)]
        public SimpleUserResource Parent { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UserRelationshipResource {\n");
            sb.Append("  Child: ").Append(Child).Append("\n");
            sb.Append("  Context: ").Append(Context).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Parent: ").Append(Parent).Append("\n");
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
            return this.Equals(input as UserRelationshipResource);
        }

        /// <summary>
        /// Returns true if UserRelationshipResource instances are equal
        /// </summary>
        /// <param name="input">Instance of UserRelationshipResource to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UserRelationshipResource input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Child == input.Child ||
                    (this.Child != null &&
                    this.Child.Equals(input.Child))
                ) && 
                (
                    this.Context == input.Context ||
                    (this.Context != null &&
                    this.Context.Equals(input.Context))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Parent == input.Parent ||
                    (this.Parent != null &&
                    this.Parent.Equals(input.Parent))
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
                if (this.Child != null)
                    hashCode = hashCode * 59 + this.Child.GetHashCode();
                if (this.Context != null)
                    hashCode = hashCode * 59 + this.Context.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Parent != null)
                    hashCode = hashCode * 59 + this.Parent.GetHashCode();
                return hashCode;
            }
        }

    }

}
