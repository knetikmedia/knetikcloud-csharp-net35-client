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
    /// ChatMessageResource
    /// </summary>
    [DataContract]
    public partial class ChatMessageResource :  IEquatable<ChatMessageResource>
    {
        /// <summary>
        /// The recipient type of the message
        /// </summary>
        /// <value>The recipient type of the message</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum RecipientTypeEnum
        {
            
            /// <summary>
            /// Enum User for "user"
            /// </summary>
            [EnumMember(Value = "user")]
            User,
            
            /// <summary>
            /// Enum Topic for "topic"
            /// </summary>
            [EnumMember(Value = "topic")]
            Topic
        }

        /// <summary>
        /// The recipient type of the message
        /// </summary>
        /// <value>The recipient type of the message</value>
        [DataMember(Name="recipient_type", EmitDefaultValue=false)]
        public RecipientTypeEnum? RecipientType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ChatMessageResource" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ChatMessageResource() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ChatMessageResource" /> class.
        /// </summary>
        /// <param name="Content">The content of the message (required).</param>
        /// <param name="MessageType">The type of the message set by the client (required).</param>
        /// <param name="RecipientId">The id of the recipient: user id or topic id (required).</param>
        /// <param name="RecipientType">The recipient type of the message (required).</param>
        public ChatMessageResource(Object Content = default(Object), string MessageType = default(string), string RecipientId = default(string), RecipientTypeEnum? RecipientType = default(RecipientTypeEnum?))
        {
            // to ensure "Content" is required (not null)
            if (Content == null)
            {
                throw new InvalidDataException("Content is a required property for ChatMessageResource and cannot be null");
            }
            else
            {
                this.Content = Content;
            }
            // to ensure "MessageType" is required (not null)
            if (MessageType == null)
            {
                throw new InvalidDataException("MessageType is a required property for ChatMessageResource and cannot be null");
            }
            else
            {
                this.MessageType = MessageType;
            }
            // to ensure "RecipientId" is required (not null)
            if (RecipientId == null)
            {
                throw new InvalidDataException("RecipientId is a required property for ChatMessageResource and cannot be null");
            }
            else
            {
                this.RecipientId = RecipientId;
            }
            // to ensure "RecipientType" is required (not null)
            if (RecipientType == null)
            {
                throw new InvalidDataException("RecipientType is a required property for ChatMessageResource and cannot be null");
            }
            else
            {
                this.RecipientType = RecipientType;
            }
        }
        
        /// <summary>
        /// The content of the message
        /// </summary>
        /// <value>The content of the message</value>
        [DataMember(Name="content", EmitDefaultValue=false)]
        public Object Content { get; set; }

        /// <summary>
        /// The date the chat message was created
        /// </summary>
        /// <value>The date the chat message was created</value>
        [DataMember(Name="created_date", EmitDefaultValue=false)]
        public long? CreatedDate { get; private set; }

        /// <summary>
        /// Whether the message has been edited
        /// </summary>
        /// <value>Whether the message has been edited</value>
        [DataMember(Name="edited", EmitDefaultValue=false)]
        public bool? Edited { get; private set; }

        /// <summary>
        /// The id for this message
        /// </summary>
        /// <value>The id for this message</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; private set; }

        /// <summary>
        /// The type of the message set by the client
        /// </summary>
        /// <value>The type of the message set by the client</value>
        [DataMember(Name="message_type", EmitDefaultValue=false)]
        public string MessageType { get; set; }

        /// <summary>
        /// The id of the recipient: user id or topic id
        /// </summary>
        /// <value>The id of the recipient: user id or topic id</value>
        [DataMember(Name="recipient_id", EmitDefaultValue=false)]
        public string RecipientId { get; set; }


        /// <summary>
        /// The id of the sender
        /// </summary>
        /// <value>The id of the sender</value>
        [DataMember(Name="sender_id", EmitDefaultValue=false)]
        public int? SenderId { get; private set; }

        /// <summary>
        /// The id of the thread
        /// </summary>
        /// <value>The id of the thread</value>
        [DataMember(Name="thread_id", EmitDefaultValue=false)]
        public string ThreadId { get; private set; }

        /// <summary>
        /// The date the chat message was updated
        /// </summary>
        /// <value>The date the chat message was updated</value>
        [DataMember(Name="updated_date", EmitDefaultValue=false)]
        public long? UpdatedDate { get; private set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ChatMessageResource {\n");
            sb.Append("  Content: ").Append(Content).Append("\n");
            sb.Append("  CreatedDate: ").Append(CreatedDate).Append("\n");
            sb.Append("  Edited: ").Append(Edited).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  MessageType: ").Append(MessageType).Append("\n");
            sb.Append("  RecipientId: ").Append(RecipientId).Append("\n");
            sb.Append("  RecipientType: ").Append(RecipientType).Append("\n");
            sb.Append("  SenderId: ").Append(SenderId).Append("\n");
            sb.Append("  ThreadId: ").Append(ThreadId).Append("\n");
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
            return this.Equals(input as ChatMessageResource);
        }

        /// <summary>
        /// Returns true if ChatMessageResource instances are equal
        /// </summary>
        /// <param name="input">Instance of ChatMessageResource to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ChatMessageResource input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Content == input.Content ||
                    (this.Content != null &&
                    this.Content.Equals(input.Content))
                ) && 
                (
                    this.CreatedDate == input.CreatedDate ||
                    (this.CreatedDate != null &&
                    this.CreatedDate.Equals(input.CreatedDate))
                ) && 
                (
                    this.Edited == input.Edited ||
                    (this.Edited != null &&
                    this.Edited.Equals(input.Edited))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.MessageType == input.MessageType ||
                    (this.MessageType != null &&
                    this.MessageType.Equals(input.MessageType))
                ) && 
                (
                    this.RecipientId == input.RecipientId ||
                    (this.RecipientId != null &&
                    this.RecipientId.Equals(input.RecipientId))
                ) && 
                (
                    this.RecipientType == input.RecipientType ||
                    (this.RecipientType != null &&
                    this.RecipientType.Equals(input.RecipientType))
                ) && 
                (
                    this.SenderId == input.SenderId ||
                    (this.SenderId != null &&
                    this.SenderId.Equals(input.SenderId))
                ) && 
                (
                    this.ThreadId == input.ThreadId ||
                    (this.ThreadId != null &&
                    this.ThreadId.Equals(input.ThreadId))
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
                if (this.Content != null)
                    hashCode = hashCode * 59 + this.Content.GetHashCode();
                if (this.CreatedDate != null)
                    hashCode = hashCode * 59 + this.CreatedDate.GetHashCode();
                if (this.Edited != null)
                    hashCode = hashCode * 59 + this.Edited.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.MessageType != null)
                    hashCode = hashCode * 59 + this.MessageType.GetHashCode();
                if (this.RecipientId != null)
                    hashCode = hashCode * 59 + this.RecipientId.GetHashCode();
                if (this.RecipientType != null)
                    hashCode = hashCode * 59 + this.RecipientType.GetHashCode();
                if (this.SenderId != null)
                    hashCode = hashCode * 59 + this.SenderId.GetHashCode();
                if (this.ThreadId != null)
                    hashCode = hashCode * 59 + this.ThreadId.GetHashCode();
                if (this.UpdatedDate != null)
                    hashCode = hashCode * 59 + this.UpdatedDate.GetHashCode();
                return hashCode;
            }
        }

    }

}
