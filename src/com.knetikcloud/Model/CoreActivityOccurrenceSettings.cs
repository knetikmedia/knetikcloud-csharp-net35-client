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
    /// CoreActivityOccurrenceSettings
    /// </summary>
    [DataContract]
    public partial class CoreActivityOccurrenceSettings :  IEquatable<CoreActivityOccurrenceSettings>
    {
        /// <summary>
        /// Restriction for who is able to report game end and results. Admin is always able to send results as well. Must be equal or more restrictive than activity (or must match challenge if applicable). Default inherits
        /// </summary>
        /// <value>Restriction for who is able to report game end and results. Admin is always able to send results as well. Must be equal or more restrictive than activity (or must match challenge if applicable). Default inherits</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ResultsTrustEnum
        {
            
            /// <summary>
            /// Enum None for "none"
            /// </summary>
            [EnumMember(Value = "none")]
            None,
            
            /// <summary>
            /// Enum Host for "host"
            /// </summary>
            [EnumMember(Value = "host")]
            Host,
            
            /// <summary>
            /// Enum All for "all"
            /// </summary>
            [EnumMember(Value = "all")]
            All
        }

        /// <summary>
        /// Restriction for who is able to report game end and results. Admin is always able to send results as well. Must be equal or more restrictive than activity (or must match challenge if applicable). Default inherits
        /// </summary>
        /// <value>Restriction for who is able to report game end and results. Admin is always able to send results as well. Must be equal or more restrictive than activity (or must match challenge if applicable). Default inherits</value>
        [DataMember(Name="results_trust", EmitDefaultValue=false)]
        public ResultsTrustEnum? ResultsTrust { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="CoreActivityOccurrenceSettings" /> class.
        /// </summary>
        /// <param name="BootInPlay">Whether the host can boot another user while the status is PLAYING. Must be false or null unless this setting is true in activity (or challenge if applicable). Null to inherit.</param>
        /// <param name="CustomLaunchAddress">A custom address (url, ip or whatever is needed in your game) that users should connect to to play in this occurrence rather than the usual game server. Could be the ip address of the host for peer-to-peer play. Can only be set if the activity/challenge custom_launch_address_allowed is true. Max length: 255.</param>
        /// <param name="HostStatusControl">Restriction for whether the host has control of the status once the game launches. If false they can only manage the game before (when setup and open). Cannot be true if activity/challenge has it false. Null to inherit.</param>
        /// <param name="JoinInPlay">Whether users can join while the status is PLAYING. Must be false or null unless this setting is true in activity (or challenge if applicable). Null to inherit.</param>
        /// <param name="LeaveInPlay">Whether users can leave while the status is PLAYING. Must be false or null unless this setting is true in activity (or challenge if applicable). Null to inherit.</param>
        /// <param name="MaxPlayers">The maximum number of players the game can hold. Must be equal or less than activity (or must match challenge if applicable).</param>
        /// <param name="MinPlayers">The minimum number of players the game can hold. Must be equal or greater than activity (or must match challenge if applicable).</param>
        /// <param name="NonHostStatusControl">Restriction for whether the non-host players can control of the status in place of the host. Default: false.</param>
        /// <param name="ResultsTrust">Restriction for who is able to report game end and results. Admin is always able to send results as well. Must be equal or more restrictive than activity (or must match challenge if applicable). Default inherits.</param>
        public CoreActivityOccurrenceSettings(bool? BootInPlay = default(bool?), string CustomLaunchAddress = default(string), bool? HostStatusControl = default(bool?), bool? JoinInPlay = default(bool?), bool? LeaveInPlay = default(bool?), int? MaxPlayers = default(int?), int? MinPlayers = default(int?), bool? NonHostStatusControl = default(bool?), ResultsTrustEnum? ResultsTrust = default(ResultsTrustEnum?))
        {
            this.BootInPlay = BootInPlay;
            this.CustomLaunchAddress = CustomLaunchAddress;
            this.HostStatusControl = HostStatusControl;
            this.JoinInPlay = JoinInPlay;
            this.LeaveInPlay = LeaveInPlay;
            this.MaxPlayers = MaxPlayers;
            this.MinPlayers = MinPlayers;
            this.NonHostStatusControl = NonHostStatusControl;
            this.ResultsTrust = ResultsTrust;
        }
        
        /// <summary>
        /// Whether the host can boot another user while the status is PLAYING. Must be false or null unless this setting is true in activity (or challenge if applicable). Null to inherit
        /// </summary>
        /// <value>Whether the host can boot another user while the status is PLAYING. Must be false or null unless this setting is true in activity (or challenge if applicable). Null to inherit</value>
        [DataMember(Name="boot_in_play", EmitDefaultValue=false)]
        public bool? BootInPlay { get; set; }

        /// <summary>
        /// A custom address (url, ip or whatever is needed in your game) that users should connect to to play in this occurrence rather than the usual game server. Could be the ip address of the host for peer-to-peer play. Can only be set if the activity/challenge custom_launch_address_allowed is true. Max length: 255
        /// </summary>
        /// <value>A custom address (url, ip or whatever is needed in your game) that users should connect to to play in this occurrence rather than the usual game server. Could be the ip address of the host for peer-to-peer play. Can only be set if the activity/challenge custom_launch_address_allowed is true. Max length: 255</value>
        [DataMember(Name="custom_launch_address", EmitDefaultValue=false)]
        public string CustomLaunchAddress { get; set; }

        /// <summary>
        /// Restriction for whether the host has control of the status once the game launches. If false they can only manage the game before (when setup and open). Cannot be true if activity/challenge has it false. Null to inherit
        /// </summary>
        /// <value>Restriction for whether the host has control of the status once the game launches. If false they can only manage the game before (when setup and open). Cannot be true if activity/challenge has it false. Null to inherit</value>
        [DataMember(Name="host_status_control", EmitDefaultValue=false)]
        public bool? HostStatusControl { get; set; }

        /// <summary>
        /// Whether users can join while the status is PLAYING. Must be false or null unless this setting is true in activity (or challenge if applicable). Null to inherit
        /// </summary>
        /// <value>Whether users can join while the status is PLAYING. Must be false or null unless this setting is true in activity (or challenge if applicable). Null to inherit</value>
        [DataMember(Name="join_in_play", EmitDefaultValue=false)]
        public bool? JoinInPlay { get; set; }

        /// <summary>
        /// Whether users can leave while the status is PLAYING. Must be false or null unless this setting is true in activity (or challenge if applicable). Null to inherit
        /// </summary>
        /// <value>Whether users can leave while the status is PLAYING. Must be false or null unless this setting is true in activity (or challenge if applicable). Null to inherit</value>
        [DataMember(Name="leave_in_play", EmitDefaultValue=false)]
        public bool? LeaveInPlay { get; set; }

        /// <summary>
        /// The maximum number of players the game can hold. Must be equal or less than activity (or must match challenge if applicable)
        /// </summary>
        /// <value>The maximum number of players the game can hold. Must be equal or less than activity (or must match challenge if applicable)</value>
        [DataMember(Name="max_players", EmitDefaultValue=false)]
        public int? MaxPlayers { get; set; }

        /// <summary>
        /// The minimum number of players the game can hold. Must be equal or greater than activity (or must match challenge if applicable)
        /// </summary>
        /// <value>The minimum number of players the game can hold. Must be equal or greater than activity (or must match challenge if applicable)</value>
        [DataMember(Name="min_players", EmitDefaultValue=false)]
        public int? MinPlayers { get; set; }

        /// <summary>
        /// Restriction for whether the non-host players can control of the status in place of the host. Default: false
        /// </summary>
        /// <value>Restriction for whether the non-host players can control of the status in place of the host. Default: false</value>
        [DataMember(Name="non_host_status_control", EmitDefaultValue=false)]
        public bool? NonHostStatusControl { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CoreActivityOccurrenceSettings {\n");
            sb.Append("  BootInPlay: ").Append(BootInPlay).Append("\n");
            sb.Append("  CustomLaunchAddress: ").Append(CustomLaunchAddress).Append("\n");
            sb.Append("  HostStatusControl: ").Append(HostStatusControl).Append("\n");
            sb.Append("  JoinInPlay: ").Append(JoinInPlay).Append("\n");
            sb.Append("  LeaveInPlay: ").Append(LeaveInPlay).Append("\n");
            sb.Append("  MaxPlayers: ").Append(MaxPlayers).Append("\n");
            sb.Append("  MinPlayers: ").Append(MinPlayers).Append("\n");
            sb.Append("  NonHostStatusControl: ").Append(NonHostStatusControl).Append("\n");
            sb.Append("  ResultsTrust: ").Append(ResultsTrust).Append("\n");
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
            return this.Equals(input as CoreActivityOccurrenceSettings);
        }

        /// <summary>
        /// Returns true if CoreActivityOccurrenceSettings instances are equal
        /// </summary>
        /// <param name="input">Instance of CoreActivityOccurrenceSettings to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CoreActivityOccurrenceSettings input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.BootInPlay == input.BootInPlay ||
                    (this.BootInPlay != null &&
                    this.BootInPlay.Equals(input.BootInPlay))
                ) && 
                (
                    this.CustomLaunchAddress == input.CustomLaunchAddress ||
                    (this.CustomLaunchAddress != null &&
                    this.CustomLaunchAddress.Equals(input.CustomLaunchAddress))
                ) && 
                (
                    this.HostStatusControl == input.HostStatusControl ||
                    (this.HostStatusControl != null &&
                    this.HostStatusControl.Equals(input.HostStatusControl))
                ) && 
                (
                    this.JoinInPlay == input.JoinInPlay ||
                    (this.JoinInPlay != null &&
                    this.JoinInPlay.Equals(input.JoinInPlay))
                ) && 
                (
                    this.LeaveInPlay == input.LeaveInPlay ||
                    (this.LeaveInPlay != null &&
                    this.LeaveInPlay.Equals(input.LeaveInPlay))
                ) && 
                (
                    this.MaxPlayers == input.MaxPlayers ||
                    (this.MaxPlayers != null &&
                    this.MaxPlayers.Equals(input.MaxPlayers))
                ) && 
                (
                    this.MinPlayers == input.MinPlayers ||
                    (this.MinPlayers != null &&
                    this.MinPlayers.Equals(input.MinPlayers))
                ) && 
                (
                    this.NonHostStatusControl == input.NonHostStatusControl ||
                    (this.NonHostStatusControl != null &&
                    this.NonHostStatusControl.Equals(input.NonHostStatusControl))
                ) && 
                (
                    this.ResultsTrust == input.ResultsTrust ||
                    (this.ResultsTrust != null &&
                    this.ResultsTrust.Equals(input.ResultsTrust))
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
                if (this.BootInPlay != null)
                    hashCode = hashCode * 59 + this.BootInPlay.GetHashCode();
                if (this.CustomLaunchAddress != null)
                    hashCode = hashCode * 59 + this.CustomLaunchAddress.GetHashCode();
                if (this.HostStatusControl != null)
                    hashCode = hashCode * 59 + this.HostStatusControl.GetHashCode();
                if (this.JoinInPlay != null)
                    hashCode = hashCode * 59 + this.JoinInPlay.GetHashCode();
                if (this.LeaveInPlay != null)
                    hashCode = hashCode * 59 + this.LeaveInPlay.GetHashCode();
                if (this.MaxPlayers != null)
                    hashCode = hashCode * 59 + this.MaxPlayers.GetHashCode();
                if (this.MinPlayers != null)
                    hashCode = hashCode * 59 + this.MinPlayers.GetHashCode();
                if (this.NonHostStatusControl != null)
                    hashCode = hashCode * 59 + this.NonHostStatusControl.GetHashCode();
                if (this.ResultsTrust != null)
                    hashCode = hashCode * 59 + this.ResultsTrust.GetHashCode();
                return hashCode;
            }
        }

    }

}