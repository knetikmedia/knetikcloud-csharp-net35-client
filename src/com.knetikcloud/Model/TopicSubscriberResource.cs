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
    /// TopicSubscriberResource
    /// </summary>
    [DataContract]
    public partial class TopicSubscriberResource :  IEquatable<TopicSubscriberResource>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TopicSubscriberResource" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TopicSubscriberResource() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TopicSubscriberResource" /> class.
        /// </summary>
        /// <param name="Disabled">Whether the user has disabled messages from the topic.</param>
        /// <param name="TopicId">The ID for this topic (required).</param>
        /// <param name="UserId">The user ID subscribed to the topic.</param>
        /// <param name="Username">The username subscribed to the topic.</param>
        public TopicSubscriberResource(bool? Disabled = default(bool?), string TopicId = default(string), int? UserId = default(int?), string Username = default(string))
        {
            // to ensure "TopicId" is required (not null)
            if (TopicId == null)
            {
                throw new InvalidDataException("TopicId is a required property for TopicSubscriberResource and cannot be null");
            }
            else
            {
                this.TopicId = TopicId;
            }
            this.Disabled = Disabled;
            this.UserId = UserId;
            this.Username = Username;
        }
        
        /// <summary>
        /// Whether the user has disabled messages from the topic
        /// </summary>
        /// <value>Whether the user has disabled messages from the topic</value>
        [DataMember(Name="disabled", EmitDefaultValue=false)]
        public bool? Disabled { get; set; }

        /// <summary>
        /// The ID for this topic
        /// </summary>
        /// <value>The ID for this topic</value>
        [DataMember(Name="topic_id", EmitDefaultValue=false)]
        public string TopicId { get; set; }

        /// <summary>
        /// The user ID subscribed to the topic
        /// </summary>
        /// <value>The user ID subscribed to the topic</value>
        [DataMember(Name="user_id", EmitDefaultValue=false)]
        public int? UserId { get; set; }

        /// <summary>
        /// The username subscribed to the topic
        /// </summary>
        /// <value>The username subscribed to the topic</value>
        [DataMember(Name="username", EmitDefaultValue=false)]
        public string Username { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TopicSubscriberResource {\n");
            sb.Append("  Disabled: ").Append(Disabled).Append("\n");
            sb.Append("  TopicId: ").Append(TopicId).Append("\n");
            sb.Append("  UserId: ").Append(UserId).Append("\n");
            sb.Append("  Username: ").Append(Username).Append("\n");
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
            return this.Equals(input as TopicSubscriberResource);
        }

        /// <summary>
        /// Returns true if TopicSubscriberResource instances are equal
        /// </summary>
        /// <param name="input">Instance of TopicSubscriberResource to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TopicSubscriberResource input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Disabled == input.Disabled ||
                    (this.Disabled != null &&
                    this.Disabled.Equals(input.Disabled))
                ) && 
                (
                    this.TopicId == input.TopicId ||
                    (this.TopicId != null &&
                    this.TopicId.Equals(input.TopicId))
                ) && 
                (
                    this.UserId == input.UserId ||
                    (this.UserId != null &&
                    this.UserId.Equals(input.UserId))
                ) && 
                (
                    this.Username == input.Username ||
                    (this.Username != null &&
                    this.Username.Equals(input.Username))
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
                if (this.Disabled != null)
                    hashCode = hashCode * 59 + this.Disabled.GetHashCode();
                if (this.TopicId != null)
                    hashCode = hashCode * 59 + this.TopicId.GetHashCode();
                if (this.UserId != null)
                    hashCode = hashCode * 59 + this.UserId.GetHashCode();
                if (this.Username != null)
                    hashCode = hashCode * 59 + this.Username.GetHashCode();
                return hashCode;
            }
        }

    }

}
