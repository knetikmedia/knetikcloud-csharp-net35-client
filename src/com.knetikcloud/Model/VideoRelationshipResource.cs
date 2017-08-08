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
    /// VideoRelationshipResource
    /// </summary>
    [DataContract]
    public partial class VideoRelationshipResource :  IEquatable<VideoRelationshipResource>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VideoRelationshipResource" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected VideoRelationshipResource() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="VideoRelationshipResource" /> class.
        /// </summary>
        /// <param name="From">The owner of the relationship.</param>
        /// <param name="RelationshipDetails">Details about the relationship such as type or other information. Max length 10 characters (required).</param>
        /// <param name="To">The target of the relationship. (required).</param>
        public VideoRelationshipResource(SimpleReferenceResourcelong From = default(SimpleReferenceResourcelong), string RelationshipDetails = default(string), SimpleReferenceResourcelong To = default(SimpleReferenceResourcelong))
        {
            // to ensure "RelationshipDetails" is required (not null)
            if (RelationshipDetails == null)
            {
                throw new InvalidDataException("RelationshipDetails is a required property for VideoRelationshipResource and cannot be null");
            }
            else
            {
                this.RelationshipDetails = RelationshipDetails;
            }
            // to ensure "To" is required (not null)
            if (To == null)
            {
                throw new InvalidDataException("To is a required property for VideoRelationshipResource and cannot be null");
            }
            else
            {
                this.To = To;
            }
            this.From = From;
        }
        
        /// <summary>
        /// The owner of the relationship
        /// </summary>
        /// <value>The owner of the relationship</value>
        [DataMember(Name="from", EmitDefaultValue=false)]
        public SimpleReferenceResourcelong From { get; set; }

        /// <summary>
        /// The id of the relationship
        /// </summary>
        /// <value>The id of the relationship</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; private set; }

        /// <summary>
        /// Details about the relationship such as type or other information. Max length 10 characters
        /// </summary>
        /// <value>Details about the relationship such as type or other information. Max length 10 characters</value>
        [DataMember(Name="relationship_details", EmitDefaultValue=false)]
        public string RelationshipDetails { get; set; }

        /// <summary>
        /// The target of the relationship.
        /// </summary>
        /// <value>The target of the relationship.</value>
        [DataMember(Name="to", EmitDefaultValue=false)]
        public SimpleReferenceResourcelong To { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class VideoRelationshipResource {\n");
            sb.Append("  From: ").Append(From).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  RelationshipDetails: ").Append(RelationshipDetails).Append("\n");
            sb.Append("  To: ").Append(To).Append("\n");
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
            return this.Equals(input as VideoRelationshipResource);
        }

        /// <summary>
        /// Returns true if VideoRelationshipResource instances are equal
        /// </summary>
        /// <param name="input">Instance of VideoRelationshipResource to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(VideoRelationshipResource input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.From == input.From ||
                    (this.From != null &&
                    this.From.Equals(input.From))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.RelationshipDetails == input.RelationshipDetails ||
                    (this.RelationshipDetails != null &&
                    this.RelationshipDetails.Equals(input.RelationshipDetails))
                ) && 
                (
                    this.To == input.To ||
                    (this.To != null &&
                    this.To.Equals(input.To))
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
                if (this.From != null)
                    hashCode = hashCode * 59 + this.From.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.RelationshipDetails != null)
                    hashCode = hashCode * 59 + this.RelationshipDetails.GetHashCode();
                if (this.To != null)
                    hashCode = hashCode * 59 + this.To.GetHashCode();
                return hashCode;
            }
        }

    }

}
