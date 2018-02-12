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
    /// MobileDeviceResource
    /// </summary>
    [DataContract]
    public partial class MobileDeviceResource : DeviceResource,  IEquatable<MobileDeviceResource>
    {
        /// <summary>
        /// The platform used for push notifications. Only Apple and Android are supported at the moment.
        /// </summary>
        /// <value>The platform used for push notifications. Only Apple and Android are supported at the moment.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum NotificationPlatformEnum
        {
            
            /// <summary>
            /// Enum APNS for "APNS"
            /// </summary>
            [EnumMember(Value = "APNS")]
            APNS,
            
            /// <summary>
            /// Enum GCM for "GCM"
            /// </summary>
            [EnumMember(Value = "GCM")]
            GCM
        }

        /// <summary>
        /// The platform used for push notifications. Only Apple and Android are supported at the moment.
        /// </summary>
        /// <value>The platform used for push notifications. Only Apple and Android are supported at the moment.</value>
        [DataMember(Name="notification_platform", EmitDefaultValue=false)]
        public NotificationPlatformEnum? NotificationPlatform { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="MobileDeviceResource" /> class.
        /// </summary>
        /// <param name="AdditionalProperties">A map of additional properties, keyed on the property name.  Must match the names and types defined in the template if one is specified.</param>
        /// <param name="Description">The description of the device.</param>
        /// <param name="DeviceType">The type of device. Use mobile_device to specifically register mobile devices. This particular type will be used to send and receive notifications.</param>
        /// <param name="Id">The unique ID for this device. Cannot be changed after creation. Default: random.</param>
        /// <param name="Location">The physical location of the device, coordinates or named place (office, living room, etc).</param>
        /// <param name="MacAddress">The MAC (media access control) address of the device.</param>
        /// <param name="Make">The make of the device.</param>
        /// <param name="Model">The model of the device.</param>
        /// <param name="Name">The name of the device.</param>
        /// <param name="Os">The OS (operating system) on the device.</param>
        /// <param name="Owner">The user that owns the device.</param>
        /// <param name="Serial">The serial number of the device.</param>
        /// <param name="Tags">Random tags to facilitate search.</param>
        /// <param name="Template">Use to describe and validate custom properties (custom schema). May be null and no validation of additional_properties will be done.</param>
        /// <param name="Users">The users currently using the device.</param>
        /// <param name="Authorization">The authorization code for push notifications provided by the provider platform (APNS, GCM, etc)..</param>
        /// <param name="Imei">Imei.</param>
        /// <param name="NotificationPlatform">The platform used for push notifications. Only Apple and Android are supported at the moment..</param>
        /// <param name="Number">The phone number associated with this device if applicable, in international format.</param>
        public MobileDeviceResource(Dictionary<string, Property> AdditionalProperties = default(Dictionary<string, Property>), string Description = default(string), string DeviceType = default(string), string Id = default(string), string Location = default(string), string MacAddress = default(string), string Make = default(string), string Model = default(string), string Name = default(string), string Os = default(string), SimpleUserResource Owner = default(SimpleUserResource), string Serial = default(string), List<string> Tags = default(List<string>), string Template = default(string), List<SimpleUserResource> Users = default(List<SimpleUserResource>), string Authorization = default(string), string Imei = default(string), NotificationPlatformEnum? NotificationPlatform = default(NotificationPlatformEnum?), string Number = default(string))
        {
            this.AdditionalProperties = AdditionalProperties;
            this.Description = Description;
            this.DeviceType = DeviceType;
            this.Id = Id;
            this.Location = Location;
            this.MacAddress = MacAddress;
            this.Make = Make;
            this.Model = Model;
            this.Name = Name;
            this.Os = Os;
            this.Owner = Owner;
            this.Serial = Serial;
            this.Tags = Tags;
            this.Template = Template;
            this.Users = Users;
            this.Authorization = Authorization;
            this.Imei = Imei;
            this.NotificationPlatform = NotificationPlatform;
            this.Number = Number;
        }
        
        /// <summary>
        /// A map of additional properties, keyed on the property name.  Must match the names and types defined in the template if one is specified
        /// </summary>
        /// <value>A map of additional properties, keyed on the property name.  Must match the names and types defined in the template if one is specified</value>
        [DataMember(Name="additional_properties", EmitDefaultValue=false)]
        public Dictionary<string, Property> AdditionalProperties { get; set; }

        /// <summary>
        /// The date the device log was created
        /// </summary>
        /// <value>The date the device log was created</value>
        [DataMember(Name="created_date", EmitDefaultValue=false)]
        public long? CreatedDate { get; private set; }

        /// <summary>
        /// The description of the device
        /// </summary>
        /// <value>The description of the device</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// The type of device. Use mobile_device to specifically register mobile devices. This particular type will be used to send and receive notifications
        /// </summary>
        /// <value>The type of device. Use mobile_device to specifically register mobile devices. This particular type will be used to send and receive notifications</value>
        [DataMember(Name="device_type", EmitDefaultValue=false)]
        public string DeviceType { get; set; }

        /// <summary>
        /// The unique ID for this device. Cannot be changed after creation. Default: random
        /// </summary>
        /// <value>The unique ID for this device. Cannot be changed after creation. Default: random</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// The physical location of the device, coordinates or named place (office, living room, etc)
        /// </summary>
        /// <value>The physical location of the device, coordinates or named place (office, living room, etc)</value>
        [DataMember(Name="location", EmitDefaultValue=false)]
        public string Location { get; set; }

        /// <summary>
        /// The MAC (media access control) address of the device
        /// </summary>
        /// <value>The MAC (media access control) address of the device</value>
        [DataMember(Name="mac_address", EmitDefaultValue=false)]
        public string MacAddress { get; set; }

        /// <summary>
        /// The make of the device
        /// </summary>
        /// <value>The make of the device</value>
        [DataMember(Name="make", EmitDefaultValue=false)]
        public string Make { get; set; }

        /// <summary>
        /// The model of the device
        /// </summary>
        /// <value>The model of the device</value>
        [DataMember(Name="model", EmitDefaultValue=false)]
        public string Model { get; set; }

        /// <summary>
        /// The name of the device
        /// </summary>
        /// <value>The name of the device</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// The OS (operating system) on the device
        /// </summary>
        /// <value>The OS (operating system) on the device</value>
        [DataMember(Name="os", EmitDefaultValue=false)]
        public string Os { get; set; }

        /// <summary>
        /// The user that owns the device
        /// </summary>
        /// <value>The user that owns the device</value>
        [DataMember(Name="owner", EmitDefaultValue=false)]
        public SimpleUserResource Owner { get; set; }

        /// <summary>
        /// The serial number of the device
        /// </summary>
        /// <value>The serial number of the device</value>
        [DataMember(Name="serial", EmitDefaultValue=false)]
        public string Serial { get; set; }

        /// <summary>
        /// Random tags to facilitate search
        /// </summary>
        /// <value>Random tags to facilitate search</value>
        [DataMember(Name="tags", EmitDefaultValue=false)]
        public List<string> Tags { get; set; }

        /// <summary>
        /// Use to describe and validate custom properties (custom schema). May be null and no validation of additional_properties will be done
        /// </summary>
        /// <value>Use to describe and validate custom properties (custom schema). May be null and no validation of additional_properties will be done</value>
        [DataMember(Name="template", EmitDefaultValue=false)]
        public string Template { get; set; }

        /// <summary>
        /// The date the device log was updated
        /// </summary>
        /// <value>The date the device log was updated</value>
        [DataMember(Name="updated_date", EmitDefaultValue=false)]
        public long? UpdatedDate { get; private set; }

        /// <summary>
        /// The users currently using the device
        /// </summary>
        /// <value>The users currently using the device</value>
        [DataMember(Name="users", EmitDefaultValue=false)]
        public List<SimpleUserResource> Users { get; set; }

        /// <summary>
        /// The authorization code for push notifications provided by the provider platform (APNS, GCM, etc).
        /// </summary>
        /// <value>The authorization code for push notifications provided by the provider platform (APNS, GCM, etc).</value>
        [DataMember(Name="authorization", EmitDefaultValue=false)]
        public string Authorization { get; set; }

        /// <summary>
        /// Gets or Sets Imei
        /// </summary>
        [DataMember(Name="imei", EmitDefaultValue=false)]
        public string Imei { get; set; }


        /// <summary>
        /// The phone number associated with this device if applicable, in international format
        /// </summary>
        /// <value>The phone number associated with this device if applicable, in international format</value>
        [DataMember(Name="number", EmitDefaultValue=false)]
        public string Number { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MobileDeviceResource {\n");
            sb.Append("  AdditionalProperties: ").Append(AdditionalProperties).Append("\n");
            sb.Append("  CreatedDate: ").Append(CreatedDate).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  DeviceType: ").Append(DeviceType).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Location: ").Append(Location).Append("\n");
            sb.Append("  MacAddress: ").Append(MacAddress).Append("\n");
            sb.Append("  Make: ").Append(Make).Append("\n");
            sb.Append("  Model: ").Append(Model).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Os: ").Append(Os).Append("\n");
            sb.Append("  Owner: ").Append(Owner).Append("\n");
            sb.Append("  Serial: ").Append(Serial).Append("\n");
            sb.Append("  Tags: ").Append(Tags).Append("\n");
            sb.Append("  Template: ").Append(Template).Append("\n");
            sb.Append("  UpdatedDate: ").Append(UpdatedDate).Append("\n");
            sb.Append("  Users: ").Append(Users).Append("\n");
            sb.Append("  Authorization: ").Append(Authorization).Append("\n");
            sb.Append("  Imei: ").Append(Imei).Append("\n");
            sb.Append("  NotificationPlatform: ").Append(NotificationPlatform).Append("\n");
            sb.Append("  Number: ").Append(Number).Append("\n");
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
            return this.Equals(input as MobileDeviceResource);
        }

        /// <summary>
        /// Returns true if MobileDeviceResource instances are equal
        /// </summary>
        /// <param name="input">Instance of MobileDeviceResource to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MobileDeviceResource input)
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
                    this.CreatedDate == input.CreatedDate ||
                    (this.CreatedDate != null &&
                    this.CreatedDate.Equals(input.CreatedDate))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.DeviceType == input.DeviceType ||
                    (this.DeviceType != null &&
                    this.DeviceType.Equals(input.DeviceType))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Location == input.Location ||
                    (this.Location != null &&
                    this.Location.Equals(input.Location))
                ) && 
                (
                    this.MacAddress == input.MacAddress ||
                    (this.MacAddress != null &&
                    this.MacAddress.Equals(input.MacAddress))
                ) && 
                (
                    this.Make == input.Make ||
                    (this.Make != null &&
                    this.Make.Equals(input.Make))
                ) && 
                (
                    this.Model == input.Model ||
                    (this.Model != null &&
                    this.Model.Equals(input.Model))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Os == input.Os ||
                    (this.Os != null &&
                    this.Os.Equals(input.Os))
                ) && 
                (
                    this.Owner == input.Owner ||
                    (this.Owner != null &&
                    this.Owner.Equals(input.Owner))
                ) && 
                (
                    this.Serial == input.Serial ||
                    (this.Serial != null &&
                    this.Serial.Equals(input.Serial))
                ) && 
                (
                    this.Tags == input.Tags ||
                    (this.Tags != null &&
                    this.Tags.SequenceEqual(input.Tags))
                ) && 
                (
                    this.Template == input.Template ||
                    (this.Template != null &&
                    this.Template.Equals(input.Template))
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
                ) && 
                (
                    this.Authorization == input.Authorization ||
                    (this.Authorization != null &&
                    this.Authorization.Equals(input.Authorization))
                ) && 
                (
                    this.Imei == input.Imei ||
                    (this.Imei != null &&
                    this.Imei.Equals(input.Imei))
                ) && 
                (
                    this.NotificationPlatform == input.NotificationPlatform ||
                    (this.NotificationPlatform != null &&
                    this.NotificationPlatform.Equals(input.NotificationPlatform))
                ) && 
                (
                    this.Number == input.Number ||
                    (this.Number != null &&
                    this.Number.Equals(input.Number))
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
                if (this.CreatedDate != null)
                    hashCode = hashCode * 59 + this.CreatedDate.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.DeviceType != null)
                    hashCode = hashCode * 59 + this.DeviceType.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Location != null)
                    hashCode = hashCode * 59 + this.Location.GetHashCode();
                if (this.MacAddress != null)
                    hashCode = hashCode * 59 + this.MacAddress.GetHashCode();
                if (this.Make != null)
                    hashCode = hashCode * 59 + this.Make.GetHashCode();
                if (this.Model != null)
                    hashCode = hashCode * 59 + this.Model.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Os != null)
                    hashCode = hashCode * 59 + this.Os.GetHashCode();
                if (this.Owner != null)
                    hashCode = hashCode * 59 + this.Owner.GetHashCode();
                if (this.Serial != null)
                    hashCode = hashCode * 59 + this.Serial.GetHashCode();
                if (this.Tags != null)
                    hashCode = hashCode * 59 + this.Tags.GetHashCode();
                if (this.Template != null)
                    hashCode = hashCode * 59 + this.Template.GetHashCode();
                if (this.UpdatedDate != null)
                    hashCode = hashCode * 59 + this.UpdatedDate.GetHashCode();
                if (this.Users != null)
                    hashCode = hashCode * 59 + this.Users.GetHashCode();
                if (this.Authorization != null)
                    hashCode = hashCode * 59 + this.Authorization.GetHashCode();
                if (this.Imei != null)
                    hashCode = hashCode * 59 + this.Imei.GetHashCode();
                if (this.NotificationPlatform != null)
                    hashCode = hashCode * 59 + this.NotificationPlatform.GetHashCode();
                if (this.Number != null)
                    hashCode = hashCode * 59 + this.Number.GetHashCode();
                return hashCode;
            }
        }

    }

}
