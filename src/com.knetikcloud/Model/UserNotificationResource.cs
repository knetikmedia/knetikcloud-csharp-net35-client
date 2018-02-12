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
    /// UserNotificationResource
    /// </summary>
    [DataContract]
    public partial class UserNotificationResource :  IEquatable<UserNotificationResource>
    {
        /// <summary>
        /// The type of recipient for the notification. Either a user, or all users in a topic
        /// </summary>
        /// <value>The type of recipient for the notification. Either a user, or all users in a topic</value>
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
        /// The user&#39;s status for this notification
        /// </summary>
        /// <value>The user&#39;s status for this notification</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StatusEnum
        {
            
            /// <summary>
            /// Enum Pending for "pending"
            /// </summary>
            [EnumMember(Value = "pending")]
            Pending,
            
            /// <summary>
            /// Enum Read for "read"
            /// </summary>
            [EnumMember(Value = "read")]
            Read,
            
            /// <summary>
            /// Enum Hidden for "hidden"
            /// </summary>
            [EnumMember(Value = "hidden")]
            Hidden
        }

        /// <summary>
        /// The type of recipient for the notification. Either a user, or all users in a topic
        /// </summary>
        /// <value>The type of recipient for the notification. Either a user, or all users in a topic</value>
        [DataMember(Name="recipient_type", EmitDefaultValue=false)]
        public RecipientTypeEnum? RecipientType { get; set; }
        /// <summary>
        /// The user&#39;s status for this notification
        /// </summary>
        /// <value>The user&#39;s status for this notification</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public StatusEnum? Status { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="UserNotificationResource" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected UserNotificationResource() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="UserNotificationResource" /> class.
        /// </summary>
        /// <param name="Data">The data to send and fill templates.</param>
        /// <param name="NotificationId">The id of the notification (required).</param>
        /// <param name="NotificationTypeId">The id of the notification type (required).</param>
        /// <param name="Recipient">The id of the recipient, dependent on the recipient_type. The user&#39;s id or the topic&#39;s id (required).</param>
        /// <param name="RecipientType">The type of recipient for the notification. Either a user, or all users in a topic (required).</param>
        /// <param name="Status">The user&#39;s status for this notification.</param>
        /// <param name="UserId">The id of the user (required).</param>
        public UserNotificationResource(Object Data = default(Object), string NotificationId = default(string), string NotificationTypeId = default(string), string Recipient = default(string), RecipientTypeEnum? RecipientType = default(RecipientTypeEnum?), StatusEnum? Status = default(StatusEnum?), int? UserId = default(int?))
        {
            // to ensure "NotificationId" is required (not null)
            if (NotificationId == null)
            {
                throw new InvalidDataException("NotificationId is a required property for UserNotificationResource and cannot be null");
            }
            else
            {
                this.NotificationId = NotificationId;
            }
            // to ensure "NotificationTypeId" is required (not null)
            if (NotificationTypeId == null)
            {
                throw new InvalidDataException("NotificationTypeId is a required property for UserNotificationResource and cannot be null");
            }
            else
            {
                this.NotificationTypeId = NotificationTypeId;
            }
            // to ensure "Recipient" is required (not null)
            if (Recipient == null)
            {
                throw new InvalidDataException("Recipient is a required property for UserNotificationResource and cannot be null");
            }
            else
            {
                this.Recipient = Recipient;
            }
            // to ensure "RecipientType" is required (not null)
            if (RecipientType == null)
            {
                throw new InvalidDataException("RecipientType is a required property for UserNotificationResource and cannot be null");
            }
            else
            {
                this.RecipientType = RecipientType;
            }
            // to ensure "UserId" is required (not null)
            if (UserId == null)
            {
                throw new InvalidDataException("UserId is a required property for UserNotificationResource and cannot be null");
            }
            else
            {
                this.UserId = UserId;
            }
            this.Data = Data;
            this.Status = Status;
        }
        
        /// <summary>
        /// The data to send and fill templates
        /// </summary>
        /// <value>The data to send and fill templates</value>
        [DataMember(Name="data", EmitDefaultValue=false)]
        public Object Data { get; set; }

        /// <summary>
        /// The id of the notification
        /// </summary>
        /// <value>The id of the notification</value>
        [DataMember(Name="notification_id", EmitDefaultValue=false)]
        public string NotificationId { get; set; }

        /// <summary>
        /// The id of the notification type
        /// </summary>
        /// <value>The id of the notification type</value>
        [DataMember(Name="notification_type_id", EmitDefaultValue=false)]
        public string NotificationTypeId { get; set; }

        /// <summary>
        /// The id of the recipient, dependent on the recipient_type. The user&#39;s id or the topic&#39;s id
        /// </summary>
        /// <value>The id of the recipient, dependent on the recipient_type. The user&#39;s id or the topic&#39;s id</value>
        [DataMember(Name="recipient", EmitDefaultValue=false)]
        public string Recipient { get; set; }


        /// <summary>
        /// The date this notification was first retrieved
        /// </summary>
        /// <value>The date this notification was first retrieved</value>
        [DataMember(Name="retrieve_date", EmitDefaultValue=false)]
        public long? RetrieveDate { get; private set; }

        /// <summary>
        /// The date this notification was sent
        /// </summary>
        /// <value>The date this notification was sent</value>
        [DataMember(Name="send_date", EmitDefaultValue=false)]
        public long? SendDate { get; private set; }


        /// <summary>
        /// The id of the user
        /// </summary>
        /// <value>The id of the user</value>
        [DataMember(Name="user_id", EmitDefaultValue=false)]
        public int? UserId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UserNotificationResource {\n");
            sb.Append("  Data: ").Append(Data).Append("\n");
            sb.Append("  NotificationId: ").Append(NotificationId).Append("\n");
            sb.Append("  NotificationTypeId: ").Append(NotificationTypeId).Append("\n");
            sb.Append("  Recipient: ").Append(Recipient).Append("\n");
            sb.Append("  RecipientType: ").Append(RecipientType).Append("\n");
            sb.Append("  RetrieveDate: ").Append(RetrieveDate).Append("\n");
            sb.Append("  SendDate: ").Append(SendDate).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  UserId: ").Append(UserId).Append("\n");
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
            return this.Equals(input as UserNotificationResource);
        }

        /// <summary>
        /// Returns true if UserNotificationResource instances are equal
        /// </summary>
        /// <param name="input">Instance of UserNotificationResource to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UserNotificationResource input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Data == input.Data ||
                    (this.Data != null &&
                    this.Data.Equals(input.Data))
                ) && 
                (
                    this.NotificationId == input.NotificationId ||
                    (this.NotificationId != null &&
                    this.NotificationId.Equals(input.NotificationId))
                ) && 
                (
                    this.NotificationTypeId == input.NotificationTypeId ||
                    (this.NotificationTypeId != null &&
                    this.NotificationTypeId.Equals(input.NotificationTypeId))
                ) && 
                (
                    this.Recipient == input.Recipient ||
                    (this.Recipient != null &&
                    this.Recipient.Equals(input.Recipient))
                ) && 
                (
                    this.RecipientType == input.RecipientType ||
                    (this.RecipientType != null &&
                    this.RecipientType.Equals(input.RecipientType))
                ) && 
                (
                    this.RetrieveDate == input.RetrieveDate ||
                    (this.RetrieveDate != null &&
                    this.RetrieveDate.Equals(input.RetrieveDate))
                ) && 
                (
                    this.SendDate == input.SendDate ||
                    (this.SendDate != null &&
                    this.SendDate.Equals(input.SendDate))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.UserId == input.UserId ||
                    (this.UserId != null &&
                    this.UserId.Equals(input.UserId))
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
                if (this.Data != null)
                    hashCode = hashCode * 59 + this.Data.GetHashCode();
                if (this.NotificationId != null)
                    hashCode = hashCode * 59 + this.NotificationId.GetHashCode();
                if (this.NotificationTypeId != null)
                    hashCode = hashCode * 59 + this.NotificationTypeId.GetHashCode();
                if (this.Recipient != null)
                    hashCode = hashCode * 59 + this.Recipient.GetHashCode();
                if (this.RecipientType != null)
                    hashCode = hashCode * 59 + this.RecipientType.GetHashCode();
                if (this.RetrieveDate != null)
                    hashCode = hashCode * 59 + this.RetrieveDate.GetHashCode();
                if (this.SendDate != null)
                    hashCode = hashCode * 59 + this.SendDate.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.UserId != null)
                    hashCode = hashCode * 59 + this.UserId.GetHashCode();
                return hashCode;
            }
        }

    }

}