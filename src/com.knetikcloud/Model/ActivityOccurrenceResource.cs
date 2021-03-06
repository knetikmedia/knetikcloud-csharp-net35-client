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
    /// A occurrence of an activity (the actual game for example). Used to track scores, participants, and provide settings
    /// </summary>
    [DataContract]
    public partial class ActivityOccurrenceResource :  IEquatable<ActivityOccurrenceResource>
    {
        /// <summary>
        /// Indicate if the rewards have been given out already
        /// </summary>
        /// <value>Indicate if the rewards have been given out already</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum RewardStatusEnum
        {
            
            /// <summary>
            /// Enum Pending for "pending"
            /// </summary>
            [EnumMember(Value = "pending")]
            Pending,
            
            /// <summary>
            /// Enum Failed for "failed"
            /// </summary>
            [EnumMember(Value = "failed")]
            Failed,
            
            /// <summary>
            /// Enum Complete for "complete"
            /// </summary>
            [EnumMember(Value = "complete")]
            Complete,
            
            /// <summary>
            /// Enum Partial for "partial"
            /// </summary>
            [EnumMember(Value = "partial")]
            Partial
        }

        /// <summary>
        /// The current status of the occurrence (default: OPEN)
        /// </summary>
        /// <value>The current status of the occurrence (default: OPEN)</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StatusEnum
        {
            
            /// <summary>
            /// Enum SETUP for "SETUP"
            /// </summary>
            [EnumMember(Value = "SETUP")]
            SETUP,
            
            /// <summary>
            /// Enum OPEN for "OPEN"
            /// </summary>
            [EnumMember(Value = "OPEN")]
            OPEN,
            
            /// <summary>
            /// Enum LAUNCHING for "LAUNCHING"
            /// </summary>
            [EnumMember(Value = "LAUNCHING")]
            LAUNCHING,
            
            /// <summary>
            /// Enum PLAYING for "PLAYING"
            /// </summary>
            [EnumMember(Value = "PLAYING")]
            PLAYING,
            
            /// <summary>
            /// Enum FINISHED for "FINISHED"
            /// </summary>
            [EnumMember(Value = "FINISHED")]
            FINISHED,
            
            /// <summary>
            /// Enum ABANDONED for "ABANDONED"
            /// </summary>
            [EnumMember(Value = "ABANDONED")]
            ABANDONED
        }

        /// <summary>
        /// Indicate if the rewards have been given out already
        /// </summary>
        /// <value>Indicate if the rewards have been given out already</value>
        [DataMember(Name="reward_status", EmitDefaultValue=false)]
        public RewardStatusEnum? RewardStatus { get; set; }
        /// <summary>
        /// The current status of the occurrence (default: OPEN)
        /// </summary>
        /// <value>The current status of the occurrence (default: OPEN)</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public StatusEnum? Status { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ActivityOccurrenceResource" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ActivityOccurrenceResource() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ActivityOccurrenceResource" /> class.
        /// </summary>
        /// <param name="ActivityId">The id of the activity (required).</param>
        /// <param name="Bans">The ids of banned users that cannot join the occurrence. See occurrence-user delete endpoint.</param>
        /// <param name="ChallengeActivityId">The id of the challenge activity (as part of the event, required if eventId set).</param>
        /// <param name="CoreSettings">Defines core settings about the activity occurrence that affect how it behaves in the system. Validated against core settings in activity/challenge-activity..</param>
        /// <param name="Entitlement">The entitlement item required to enter the occurrence. Required if not part of an event. Must come from the set of entitlement items listed in the activity.</param>
        /// <param name="EventId">The id of the event.</param>
        /// <param name="Host">The host of the occurrence, if not a participant (will be left out of users array). Must be the caller that creates the occurrence unless admin. Requires activity/challenge to allow host_option of &#39;non_player&#39; if not admin as well.</param>
        /// <param name="Settings">The values selected from the available settings defined for the activity. Ex: difficulty: hard. Can be left out if the activity is played during an event and the settings are already set at the event level. Ex: every monday, difficulty: hard, number of questions: 10, category: sport. Otherwise, the set must exactly match those of the activity..</param>
        /// <param name="Simulated">Whether this occurrence will be ran as a simulation. Simulations will not be rewarded. Useful for bot play or trials.</param>
        /// <param name="Status">The current status of the occurrence (default: OPEN).</param>
        /// <param name="Users">The list of users participating in this occurrence. Can only be set directly with ACTIVITIES_ADMIN permission.</param>
        public ActivityOccurrenceResource(long? ActivityId = default(long?), List<int?> Bans = default(List<int?>), long? ChallengeActivityId = default(long?), CoreActivityOccurrenceSettings CoreSettings = default(CoreActivityOccurrenceSettings), ActivityEntitlementResource Entitlement = default(ActivityEntitlementResource), long? EventId = default(long?), SimpleUserResource Host = default(SimpleUserResource), List<SelectedSettingResource> Settings = default(List<SelectedSettingResource>), bool? Simulated = default(bool?), StatusEnum? Status = default(StatusEnum?), List<ActivityUserResource> Users = default(List<ActivityUserResource>))
        {
            // to ensure "ActivityId" is required (not null)
            if (ActivityId == null)
            {
                throw new InvalidDataException("ActivityId is a required property for ActivityOccurrenceResource and cannot be null");
            }
            else
            {
                this.ActivityId = ActivityId;
            }
            this.Bans = Bans;
            this.ChallengeActivityId = ChallengeActivityId;
            this.CoreSettings = CoreSettings;
            this.Entitlement = Entitlement;
            this.EventId = EventId;
            this.Host = Host;
            this.Settings = Settings;
            this.Simulated = Simulated;
            this.Status = Status;
            this.Users = Users;
        }
        
        /// <summary>
        /// The id of the activity
        /// </summary>
        /// <value>The id of the activity</value>
        [DataMember(Name="activity_id", EmitDefaultValue=false)]
        public long? ActivityId { get; set; }

        /// <summary>
        /// The ids of banned users that cannot join the occurrence. See occurrence-user delete endpoint
        /// </summary>
        /// <value>The ids of banned users that cannot join the occurrence. See occurrence-user delete endpoint</value>
        [DataMember(Name="bans", EmitDefaultValue=false)]
        public List<int?> Bans { get; set; }

        /// <summary>
        /// The id of the challenge activity (as part of the event, required if eventId set)
        /// </summary>
        /// <value>The id of the challenge activity (as part of the event, required if eventId set)</value>
        [DataMember(Name="challenge_activity_id", EmitDefaultValue=false)]
        public long? ChallengeActivityId { get; set; }

        /// <summary>
        /// Defines core settings about the activity occurrence that affect how it behaves in the system. Validated against core settings in activity/challenge-activity.
        /// </summary>
        /// <value>Defines core settings about the activity occurrence that affect how it behaves in the system. Validated against core settings in activity/challenge-activity.</value>
        [DataMember(Name="core_settings", EmitDefaultValue=false)]
        public CoreActivityOccurrenceSettings CoreSettings { get; set; }

        /// <summary>
        /// The date this occurrence was created, unix timestamp in seconds
        /// </summary>
        /// <value>The date this occurrence was created, unix timestamp in seconds</value>
        [DataMember(Name="created_date", EmitDefaultValue=false)]
        public long? CreatedDate { get; private set; }

        /// <summary>
        /// The entitlement item required to enter the occurrence. Required if not part of an event. Must come from the set of entitlement items listed in the activity
        /// </summary>
        /// <value>The entitlement item required to enter the occurrence. Required if not part of an event. Must come from the set of entitlement items listed in the activity</value>
        [DataMember(Name="entitlement", EmitDefaultValue=false)]
        public ActivityEntitlementResource Entitlement { get; set; }

        /// <summary>
        /// The id of the event
        /// </summary>
        /// <value>The id of the event</value>
        [DataMember(Name="event_id", EmitDefaultValue=false)]
        public long? EventId { get; set; }

        /// <summary>
        /// The host of the occurrence, if not a participant (will be left out of users array). Must be the caller that creates the occurrence unless admin. Requires activity/challenge to allow host_option of &#39;non_player&#39; if not admin as well
        /// </summary>
        /// <value>The host of the occurrence, if not a participant (will be left out of users array). Must be the caller that creates the occurrence unless admin. Requires activity/challenge to allow host_option of &#39;non_player&#39; if not admin as well</value>
        [DataMember(Name="host", EmitDefaultValue=false)]
        public SimpleUserResource Host { get; set; }

        /// <summary>
        /// The id of the activity occurrence
        /// </summary>
        /// <value>The id of the activity occurrence</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; private set; }


        /// <summary>
        /// The values selected from the available settings defined for the activity. Ex: difficulty: hard. Can be left out if the activity is played during an event and the settings are already set at the event level. Ex: every monday, difficulty: hard, number of questions: 10, category: sport. Otherwise, the set must exactly match those of the activity.
        /// </summary>
        /// <value>The values selected from the available settings defined for the activity. Ex: difficulty: hard. Can be left out if the activity is played during an event and the settings are already set at the event level. Ex: every monday, difficulty: hard, number of questions: 10, category: sport. Otherwise, the set must exactly match those of the activity.</value>
        [DataMember(Name="settings", EmitDefaultValue=false)]
        public List<SelectedSettingResource> Settings { get; set; }

        /// <summary>
        /// Whether this occurrence will be ran as a simulation. Simulations will not be rewarded. Useful for bot play or trials
        /// </summary>
        /// <value>Whether this occurrence will be ran as a simulation. Simulations will not be rewarded. Useful for bot play or trials</value>
        [DataMember(Name="simulated", EmitDefaultValue=false)]
        public bool? Simulated { get; set; }

        /// <summary>
        /// The date this occurrence was started, unix timestamp in seconds. null if not yet started
        /// </summary>
        /// <value>The date this occurrence was started, unix timestamp in seconds. null if not yet started</value>
        [DataMember(Name="start_date", EmitDefaultValue=false)]
        public long? StartDate { get; private set; }


        /// <summary>
        /// The date this occurrence was last updated, unix timestamp in seconds
        /// </summary>
        /// <value>The date this occurrence was last updated, unix timestamp in seconds</value>
        [DataMember(Name="updated_date", EmitDefaultValue=false)]
        public long? UpdatedDate { get; private set; }

        /// <summary>
        /// The list of users participating in this occurrence. Can only be set directly with ACTIVITIES_ADMIN permission
        /// </summary>
        /// <value>The list of users participating in this occurrence. Can only be set directly with ACTIVITIES_ADMIN permission</value>
        [DataMember(Name="users", EmitDefaultValue=false)]
        public List<ActivityUserResource> Users { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ActivityOccurrenceResource {\n");
            sb.Append("  ActivityId: ").Append(ActivityId).Append("\n");
            sb.Append("  Bans: ").Append(Bans).Append("\n");
            sb.Append("  ChallengeActivityId: ").Append(ChallengeActivityId).Append("\n");
            sb.Append("  CoreSettings: ").Append(CoreSettings).Append("\n");
            sb.Append("  CreatedDate: ").Append(CreatedDate).Append("\n");
            sb.Append("  Entitlement: ").Append(Entitlement).Append("\n");
            sb.Append("  EventId: ").Append(EventId).Append("\n");
            sb.Append("  Host: ").Append(Host).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  RewardStatus: ").Append(RewardStatus).Append("\n");
            sb.Append("  Settings: ").Append(Settings).Append("\n");
            sb.Append("  Simulated: ").Append(Simulated).Append("\n");
            sb.Append("  StartDate: ").Append(StartDate).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  UpdatedDate: ").Append(UpdatedDate).Append("\n");
            sb.Append("  Users: ").Append(Users).Append("\n");
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
            return this.Equals(input as ActivityOccurrenceResource);
        }

        /// <summary>
        /// Returns true if ActivityOccurrenceResource instances are equal
        /// </summary>
        /// <param name="input">Instance of ActivityOccurrenceResource to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ActivityOccurrenceResource input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ActivityId == input.ActivityId ||
                    (this.ActivityId != null &&
                    this.ActivityId.Equals(input.ActivityId))
                ) && 
                (
                    this.Bans == input.Bans ||
                    (this.Bans != null &&
                    this.Bans.SequenceEqual(input.Bans))
                ) && 
                (
                    this.ChallengeActivityId == input.ChallengeActivityId ||
                    (this.ChallengeActivityId != null &&
                    this.ChallengeActivityId.Equals(input.ChallengeActivityId))
                ) && 
                (
                    this.CoreSettings == input.CoreSettings ||
                    (this.CoreSettings != null &&
                    this.CoreSettings.Equals(input.CoreSettings))
                ) && 
                (
                    this.CreatedDate == input.CreatedDate ||
                    (this.CreatedDate != null &&
                    this.CreatedDate.Equals(input.CreatedDate))
                ) && 
                (
                    this.Entitlement == input.Entitlement ||
                    (this.Entitlement != null &&
                    this.Entitlement.Equals(input.Entitlement))
                ) && 
                (
                    this.EventId == input.EventId ||
                    (this.EventId != null &&
                    this.EventId.Equals(input.EventId))
                ) && 
                (
                    this.Host == input.Host ||
                    (this.Host != null &&
                    this.Host.Equals(input.Host))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.RewardStatus == input.RewardStatus ||
                    (this.RewardStatus != null &&
                    this.RewardStatus.Equals(input.RewardStatus))
                ) && 
                (
                    this.Settings == input.Settings ||
                    (this.Settings != null &&
                    this.Settings.SequenceEqual(input.Settings))
                ) && 
                (
                    this.Simulated == input.Simulated ||
                    (this.Simulated != null &&
                    this.Simulated.Equals(input.Simulated))
                ) && 
                (
                    this.StartDate == input.StartDate ||
                    (this.StartDate != null &&
                    this.StartDate.Equals(input.StartDate))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.UpdatedDate == input.UpdatedDate ||
                    (this.UpdatedDate != null &&
                    this.UpdatedDate.Equals(input.UpdatedDate))
                ) && 
                (
                    this.Users == input.Users ||
                    (this.Users != null &&
                    this.Users.SequenceEqual(input.Users))
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
                if (this.ActivityId != null)
                    hashCode = hashCode * 59 + this.ActivityId.GetHashCode();
                if (this.Bans != null)
                    hashCode = hashCode * 59 + this.Bans.GetHashCode();
                if (this.ChallengeActivityId != null)
                    hashCode = hashCode * 59 + this.ChallengeActivityId.GetHashCode();
                if (this.CoreSettings != null)
                    hashCode = hashCode * 59 + this.CoreSettings.GetHashCode();
                if (this.CreatedDate != null)
                    hashCode = hashCode * 59 + this.CreatedDate.GetHashCode();
                if (this.Entitlement != null)
                    hashCode = hashCode * 59 + this.Entitlement.GetHashCode();
                if (this.EventId != null)
                    hashCode = hashCode * 59 + this.EventId.GetHashCode();
                if (this.Host != null)
                    hashCode = hashCode * 59 + this.Host.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.RewardStatus != null)
                    hashCode = hashCode * 59 + this.RewardStatus.GetHashCode();
                if (this.Settings != null)
                    hashCode = hashCode * 59 + this.Settings.GetHashCode();
                if (this.Simulated != null)
                    hashCode = hashCode * 59 + this.Simulated.GetHashCode();
                if (this.StartDate != null)
                    hashCode = hashCode * 59 + this.StartDate.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.UpdatedDate != null)
                    hashCode = hashCode * 59 + this.UpdatedDate.GetHashCode();
                if (this.Users != null)
                    hashCode = hashCode * 59 + this.Users.GetHashCode();
                return hashCode;
            }
        }

    }

}
