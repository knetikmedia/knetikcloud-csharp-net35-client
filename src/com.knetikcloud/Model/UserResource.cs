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
    /// UserResource
    /// </summary>
    [DataContract]
    public partial class UserResource :  IEquatable<UserResource>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserResource" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected UserResource() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="UserResource" /> class.
        /// </summary>
        /// <param name="AdditionalProperties">A map of additional properties, keyed on the property name (private). Must match the names and types defined in the template for this user type, or be an extra not from the template.</param>
        /// <param name="Address">The first line of the user&#39;s address (private).</param>
        /// <param name="Address2">The second line of user&#39;s address (private).</param>
        /// <param name="AvatarUrl">The url of the user&#39;s avatar image.</param>
        /// <param name="Children">Relationships where this user is the parent. Read-Only, manage through separate endpoints.</param>
        /// <param name="City">The user&#39;s city (private).</param>
        /// <param name="CountryCode">The ISO3 code for the country from the user&#39;s address (private). Will be filled in based on GeoIP country at registration if not provided..</param>
        /// <param name="CurrencyCode">The code for the user&#39;s real money currency (private).</param>
        /// <param name="DateOfBirth">The user&#39;s date of birth (private) as a unix timestamp.</param>
        /// <param name="Description">The user&#39;s self description (private).</param>
        /// <param name="DisplayName">The chosen display name of the user, defaults to username if not present.</param>
        /// <param name="Email">The user&#39;s email address (private). May be required and/or unique depending on system configuration (both on by default). Must match standard email requirements if provided (RFC 2822) (required).</param>
        /// <param name="FirstName">The user&#39;s first name (private).</param>
        /// <param name="Fullname">The user&#39;s full name (private).</param>
        /// <param name="Gender">The user&#39;s gender (private).</param>
        /// <param name="LanguageCode">The ISO3 code for the user&#39;s currency (private).</param>
        /// <param name="LastName">The user&#39;s last name (private).</param>
        /// <param name="MobileNumber">The user&#39;s mobile phone number (private).</param>
        /// <param name="Parents">Relationships where this user is the child. Read-Only, manage through separate endpoints.</param>
        /// <param name="Password">The plain text password for the new user account. Required for registration; ignored on profile update.  Use password specific endpoints for editing.</param>
        /// <param name="PostalCode">The user&#39;s postal code (private).</param>
        /// <param name="State">The user&#39;s state (private).</param>
        /// <param name="Tags">Tags on the user. Can only be set by admin. Max length per tag is 64 characters.</param>
        /// <param name="Template">A user template this user is validated against (private). May be null and no validation of properties will be done.</param>
        /// <param name="TimezoneCode">The code for the user&#39;s timezone (private).</param>
        /// <param name="Username">The login username for the user (private). May be set to match email if system does not require usernames separately. (required).</param>
        public UserResource(Dictionary<string, Property> AdditionalProperties = default(Dictionary<string, Property>), string Address = default(string), string Address2 = default(string), string AvatarUrl = default(string), List<UserRelationshipReferenceResource> Children = default(List<UserRelationshipReferenceResource>), string City = default(string), string CountryCode = default(string), string CurrencyCode = default(string), long? DateOfBirth = default(long?), string Description = default(string), string DisplayName = default(string), string Email = default(string), string FirstName = default(string), string Fullname = default(string), string Gender = default(string), string LanguageCode = default(string), string LastName = default(string), string MobileNumber = default(string), List<UserRelationshipReferenceResource> Parents = default(List<UserRelationshipReferenceResource>), string Password = default(string), string PostalCode = default(string), string State = default(string), List<string> Tags = default(List<string>), string Template = default(string), string TimezoneCode = default(string), string Username = default(string))
        {
            // to ensure "Email" is required (not null)
            if (Email == null)
            {
                throw new InvalidDataException("Email is a required property for UserResource and cannot be null");
            }
            else
            {
                this.Email = Email;
            }
            // to ensure "Username" is required (not null)
            if (Username == null)
            {
                throw new InvalidDataException("Username is a required property for UserResource and cannot be null");
            }
            else
            {
                this.Username = Username;
            }
            this.AdditionalProperties = AdditionalProperties;
            this.Address = Address;
            this.Address2 = Address2;
            this.AvatarUrl = AvatarUrl;
            this.Children = Children;
            this.City = City;
            this.CountryCode = CountryCode;
            this.CurrencyCode = CurrencyCode;
            this.DateOfBirth = DateOfBirth;
            this.Description = Description;
            this.DisplayName = DisplayName;
            this.FirstName = FirstName;
            this.Fullname = Fullname;
            this.Gender = Gender;
            this.LanguageCode = LanguageCode;
            this.LastName = LastName;
            this.MobileNumber = MobileNumber;
            this.Parents = Parents;
            this.Password = Password;
            this.PostalCode = PostalCode;
            this.State = State;
            this.Tags = Tags;
            this.Template = Template;
            this.TimezoneCode = TimezoneCode;
        }
        
        /// <summary>
        /// A map of additional properties, keyed on the property name (private). Must match the names and types defined in the template for this user type, or be an extra not from the template
        /// </summary>
        /// <value>A map of additional properties, keyed on the property name (private). Must match the names and types defined in the template for this user type, or be an extra not from the template</value>
        [DataMember(Name="additional_properties", EmitDefaultValue=false)]
        public Dictionary<string, Property> AdditionalProperties { get; set; }

        /// <summary>
        /// The first line of the user&#39;s address (private)
        /// </summary>
        /// <value>The first line of the user&#39;s address (private)</value>
        [DataMember(Name="address", EmitDefaultValue=false)]
        public string Address { get; set; }

        /// <summary>
        /// The second line of user&#39;s address (private)
        /// </summary>
        /// <value>The second line of user&#39;s address (private)</value>
        [DataMember(Name="address2", EmitDefaultValue=false)]
        public string Address2 { get; set; }

        /// <summary>
        /// The url of the user&#39;s avatar image
        /// </summary>
        /// <value>The url of the user&#39;s avatar image</value>
        [DataMember(Name="avatar_url", EmitDefaultValue=false)]
        public string AvatarUrl { get; set; }

        /// <summary>
        /// Relationships where this user is the parent. Read-Only, manage through separate endpoints
        /// </summary>
        /// <value>Relationships where this user is the parent. Read-Only, manage through separate endpoints</value>
        [DataMember(Name="children", EmitDefaultValue=false)]
        public List<UserRelationshipReferenceResource> Children { get; set; }

        /// <summary>
        /// The user&#39;s city (private)
        /// </summary>
        /// <value>The user&#39;s city (private)</value>
        [DataMember(Name="city", EmitDefaultValue=false)]
        public string City { get; set; }

        /// <summary>
        /// The ISO3 code for the country from the user&#39;s address (private). Will be filled in based on GeoIP country at registration if not provided.
        /// </summary>
        /// <value>The ISO3 code for the country from the user&#39;s address (private). Will be filled in based on GeoIP country at registration if not provided.</value>
        [DataMember(Name="country_code", EmitDefaultValue=false)]
        public string CountryCode { get; set; }

        /// <summary>
        /// The code for the user&#39;s real money currency (private)
        /// </summary>
        /// <value>The code for the user&#39;s real money currency (private)</value>
        [DataMember(Name="currency_code", EmitDefaultValue=false)]
        public string CurrencyCode { get; set; }

        /// <summary>
        /// The user&#39;s date of birth (private) as a unix timestamp
        /// </summary>
        /// <value>The user&#39;s date of birth (private) as a unix timestamp</value>
        [DataMember(Name="date_of_birth", EmitDefaultValue=false)]
        public long? DateOfBirth { get; set; }

        /// <summary>
        /// The user&#39;s self description (private)
        /// </summary>
        /// <value>The user&#39;s self description (private)</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// The chosen display name of the user, defaults to username if not present
        /// </summary>
        /// <value>The chosen display name of the user, defaults to username if not present</value>
        [DataMember(Name="display_name", EmitDefaultValue=false)]
        public string DisplayName { get; set; }

        /// <summary>
        /// The user&#39;s email address (private). May be required and/or unique depending on system configuration (both on by default). Must match standard email requirements if provided (RFC 2822)
        /// </summary>
        /// <value>The user&#39;s email address (private). May be required and/or unique depending on system configuration (both on by default). Must match standard email requirements if provided (RFC 2822)</value>
        [DataMember(Name="email", EmitDefaultValue=false)]
        public string Email { get; set; }

        /// <summary>
        /// The user&#39;s first name (private)
        /// </summary>
        /// <value>The user&#39;s first name (private)</value>
        [DataMember(Name="first_name", EmitDefaultValue=false)]
        public string FirstName { get; set; }

        /// <summary>
        /// The user&#39;s full name (private)
        /// </summary>
        /// <value>The user&#39;s full name (private)</value>
        [DataMember(Name="fullname", EmitDefaultValue=false)]
        public string Fullname { get; set; }

        /// <summary>
        /// The user&#39;s gender (private)
        /// </summary>
        /// <value>The user&#39;s gender (private)</value>
        [DataMember(Name="gender", EmitDefaultValue=false)]
        public string Gender { get; set; }

        /// <summary>
        /// The id of the user
        /// </summary>
        /// <value>The id of the user</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int? Id { get; private set; }

        /// <summary>
        /// The ISO3 code for the user&#39;s currency (private)
        /// </summary>
        /// <value>The ISO3 code for the user&#39;s currency (private)</value>
        [DataMember(Name="language_code", EmitDefaultValue=false)]
        public string LanguageCode { get; set; }

        /// <summary>
        /// The date the user last interacted with the API (private)
        /// </summary>
        /// <value>The date the user last interacted with the API (private)</value>
        [DataMember(Name="last_activity", EmitDefaultValue=false)]
        public long? LastActivity { get; private set; }

        /// <summary>
        /// The user&#39;s last name (private)
        /// </summary>
        /// <value>The user&#39;s last name (private)</value>
        [DataMember(Name="last_name", EmitDefaultValue=false)]
        public string LastName { get; set; }

        /// <summary>
        /// The date the user&#39;s info was last updated as a unix timestamp
        /// </summary>
        /// <value>The date the user&#39;s info was last updated as a unix timestamp</value>
        [DataMember(Name="last_updated", EmitDefaultValue=false)]
        public long? LastUpdated { get; private set; }

        /// <summary>
        /// The user&#39;s date of registration as a unix timestamp
        /// </summary>
        /// <value>The user&#39;s date of registration as a unix timestamp</value>
        [DataMember(Name="member_since", EmitDefaultValue=false)]
        public long? MemberSince { get; private set; }

        /// <summary>
        /// The user&#39;s mobile phone number (private)
        /// </summary>
        /// <value>The user&#39;s mobile phone number (private)</value>
        [DataMember(Name="mobile_number", EmitDefaultValue=false)]
        public string MobileNumber { get; set; }

        /// <summary>
        /// Relationships where this user is the child. Read-Only, manage through separate endpoints
        /// </summary>
        /// <value>Relationships where this user is the child. Read-Only, manage through separate endpoints</value>
        [DataMember(Name="parents", EmitDefaultValue=false)]
        public List<UserRelationshipReferenceResource> Parents { get; set; }

        /// <summary>
        /// The plain text password for the new user account. Required for registration; ignored on profile update.  Use password specific endpoints for editing
        /// </summary>
        /// <value>The plain text password for the new user account. Required for registration; ignored on profile update.  Use password specific endpoints for editing</value>
        [DataMember(Name="password", EmitDefaultValue=false)]
        public string Password { get; set; }

        /// <summary>
        /// The user&#39;s postal code (private)
        /// </summary>
        /// <value>The user&#39;s postal code (private)</value>
        [DataMember(Name="postal_code", EmitDefaultValue=false)]
        public string PostalCode { get; set; }

        /// <summary>
        /// The user&#39;s state (private)
        /// </summary>
        /// <value>The user&#39;s state (private)</value>
        [DataMember(Name="state", EmitDefaultValue=false)]
        public string State { get; set; }

        /// <summary>
        /// Tags on the user. Can only be set by admin. Max length per tag is 64 characters
        /// </summary>
        /// <value>Tags on the user. Can only be set by admin. Max length per tag is 64 characters</value>
        [DataMember(Name="tags", EmitDefaultValue=false)]
        public List<string> Tags { get; set; }

        /// <summary>
        /// A user template this user is validated against (private). May be null and no validation of properties will be done
        /// </summary>
        /// <value>A user template this user is validated against (private). May be null and no validation of properties will be done</value>
        [DataMember(Name="template", EmitDefaultValue=false)]
        public string Template { get; set; }

        /// <summary>
        /// The code for the user&#39;s timezone (private)
        /// </summary>
        /// <value>The code for the user&#39;s timezone (private)</value>
        [DataMember(Name="timezone_code", EmitDefaultValue=false)]
        public string TimezoneCode { get; set; }

        /// <summary>
        /// The login username for the user (private). May be set to match email if system does not require usernames separately.
        /// </summary>
        /// <value>The login username for the user (private). May be set to match email if system does not require usernames separately.</value>
        [DataMember(Name="username", EmitDefaultValue=false)]
        public string Username { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UserResource {\n");
            sb.Append("  AdditionalProperties: ").Append(AdditionalProperties).Append("\n");
            sb.Append("  Address: ").Append(Address).Append("\n");
            sb.Append("  Address2: ").Append(Address2).Append("\n");
            sb.Append("  AvatarUrl: ").Append(AvatarUrl).Append("\n");
            sb.Append("  Children: ").Append(Children).Append("\n");
            sb.Append("  City: ").Append(City).Append("\n");
            sb.Append("  CountryCode: ").Append(CountryCode).Append("\n");
            sb.Append("  CurrencyCode: ").Append(CurrencyCode).Append("\n");
            sb.Append("  DateOfBirth: ").Append(DateOfBirth).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  FirstName: ").Append(FirstName).Append("\n");
            sb.Append("  Fullname: ").Append(Fullname).Append("\n");
            sb.Append("  Gender: ").Append(Gender).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  LanguageCode: ").Append(LanguageCode).Append("\n");
            sb.Append("  LastActivity: ").Append(LastActivity).Append("\n");
            sb.Append("  LastName: ").Append(LastName).Append("\n");
            sb.Append("  LastUpdated: ").Append(LastUpdated).Append("\n");
            sb.Append("  MemberSince: ").Append(MemberSince).Append("\n");
            sb.Append("  MobileNumber: ").Append(MobileNumber).Append("\n");
            sb.Append("  Parents: ").Append(Parents).Append("\n");
            sb.Append("  Password: ").Append(Password).Append("\n");
            sb.Append("  PostalCode: ").Append(PostalCode).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  Tags: ").Append(Tags).Append("\n");
            sb.Append("  Template: ").Append(Template).Append("\n");
            sb.Append("  TimezoneCode: ").Append(TimezoneCode).Append("\n");
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
            return this.Equals(input as UserResource);
        }

        /// <summary>
        /// Returns true if UserResource instances are equal
        /// </summary>
        /// <param name="input">Instance of UserResource to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UserResource input)
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
                    this.Address == input.Address ||
                    (this.Address != null &&
                    this.Address.Equals(input.Address))
                ) && 
                (
                    this.Address2 == input.Address2 ||
                    (this.Address2 != null &&
                    this.Address2.Equals(input.Address2))
                ) && 
                (
                    this.AvatarUrl == input.AvatarUrl ||
                    (this.AvatarUrl != null &&
                    this.AvatarUrl.Equals(input.AvatarUrl))
                ) && 
                (
                    this.Children == input.Children ||
                    (this.Children != null &&
                    this.Children.SequenceEqual(input.Children))
                ) && 
                (
                    this.City == input.City ||
                    (this.City != null &&
                    this.City.Equals(input.City))
                ) && 
                (
                    this.CountryCode == input.CountryCode ||
                    (this.CountryCode != null &&
                    this.CountryCode.Equals(input.CountryCode))
                ) && 
                (
                    this.CurrencyCode == input.CurrencyCode ||
                    (this.CurrencyCode != null &&
                    this.CurrencyCode.Equals(input.CurrencyCode))
                ) && 
                (
                    this.DateOfBirth == input.DateOfBirth ||
                    (this.DateOfBirth != null &&
                    this.DateOfBirth.Equals(input.DateOfBirth))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.DisplayName == input.DisplayName ||
                    (this.DisplayName != null &&
                    this.DisplayName.Equals(input.DisplayName))
                ) && 
                (
                    this.Email == input.Email ||
                    (this.Email != null &&
                    this.Email.Equals(input.Email))
                ) && 
                (
                    this.FirstName == input.FirstName ||
                    (this.FirstName != null &&
                    this.FirstName.Equals(input.FirstName))
                ) && 
                (
                    this.Fullname == input.Fullname ||
                    (this.Fullname != null &&
                    this.Fullname.Equals(input.Fullname))
                ) && 
                (
                    this.Gender == input.Gender ||
                    (this.Gender != null &&
                    this.Gender.Equals(input.Gender))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.LanguageCode == input.LanguageCode ||
                    (this.LanguageCode != null &&
                    this.LanguageCode.Equals(input.LanguageCode))
                ) && 
                (
                    this.LastActivity == input.LastActivity ||
                    (this.LastActivity != null &&
                    this.LastActivity.Equals(input.LastActivity))
                ) && 
                (
                    this.LastName == input.LastName ||
                    (this.LastName != null &&
                    this.LastName.Equals(input.LastName))
                ) && 
                (
                    this.LastUpdated == input.LastUpdated ||
                    (this.LastUpdated != null &&
                    this.LastUpdated.Equals(input.LastUpdated))
                ) && 
                (
                    this.MemberSince == input.MemberSince ||
                    (this.MemberSince != null &&
                    this.MemberSince.Equals(input.MemberSince))
                ) && 
                (
                    this.MobileNumber == input.MobileNumber ||
                    (this.MobileNumber != null &&
                    this.MobileNumber.Equals(input.MobileNumber))
                ) && 
                (
                    this.Parents == input.Parents ||
                    (this.Parents != null &&
                    this.Parents.SequenceEqual(input.Parents))
                ) && 
                (
                    this.Password == input.Password ||
                    (this.Password != null &&
                    this.Password.Equals(input.Password))
                ) && 
                (
                    this.PostalCode == input.PostalCode ||
                    (this.PostalCode != null &&
                    this.PostalCode.Equals(input.PostalCode))
                ) && 
                (
                    this.State == input.State ||
                    (this.State != null &&
                    this.State.Equals(input.State))
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
                    this.TimezoneCode == input.TimezoneCode ||
                    (this.TimezoneCode != null &&
                    this.TimezoneCode.Equals(input.TimezoneCode))
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
                if (this.AdditionalProperties != null)
                    hashCode = hashCode * 59 + this.AdditionalProperties.GetHashCode();
                if (this.Address != null)
                    hashCode = hashCode * 59 + this.Address.GetHashCode();
                if (this.Address2 != null)
                    hashCode = hashCode * 59 + this.Address2.GetHashCode();
                if (this.AvatarUrl != null)
                    hashCode = hashCode * 59 + this.AvatarUrl.GetHashCode();
                if (this.Children != null)
                    hashCode = hashCode * 59 + this.Children.GetHashCode();
                if (this.City != null)
                    hashCode = hashCode * 59 + this.City.GetHashCode();
                if (this.CountryCode != null)
                    hashCode = hashCode * 59 + this.CountryCode.GetHashCode();
                if (this.CurrencyCode != null)
                    hashCode = hashCode * 59 + this.CurrencyCode.GetHashCode();
                if (this.DateOfBirth != null)
                    hashCode = hashCode * 59 + this.DateOfBirth.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.DisplayName != null)
                    hashCode = hashCode * 59 + this.DisplayName.GetHashCode();
                if (this.Email != null)
                    hashCode = hashCode * 59 + this.Email.GetHashCode();
                if (this.FirstName != null)
                    hashCode = hashCode * 59 + this.FirstName.GetHashCode();
                if (this.Fullname != null)
                    hashCode = hashCode * 59 + this.Fullname.GetHashCode();
                if (this.Gender != null)
                    hashCode = hashCode * 59 + this.Gender.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.LanguageCode != null)
                    hashCode = hashCode * 59 + this.LanguageCode.GetHashCode();
                if (this.LastActivity != null)
                    hashCode = hashCode * 59 + this.LastActivity.GetHashCode();
                if (this.LastName != null)
                    hashCode = hashCode * 59 + this.LastName.GetHashCode();
                if (this.LastUpdated != null)
                    hashCode = hashCode * 59 + this.LastUpdated.GetHashCode();
                if (this.MemberSince != null)
                    hashCode = hashCode * 59 + this.MemberSince.GetHashCode();
                if (this.MobileNumber != null)
                    hashCode = hashCode * 59 + this.MobileNumber.GetHashCode();
                if (this.Parents != null)
                    hashCode = hashCode * 59 + this.Parents.GetHashCode();
                if (this.Password != null)
                    hashCode = hashCode * 59 + this.Password.GetHashCode();
                if (this.PostalCode != null)
                    hashCode = hashCode * 59 + this.PostalCode.GetHashCode();
                if (this.State != null)
                    hashCode = hashCode * 59 + this.State.GetHashCode();
                if (this.Tags != null)
                    hashCode = hashCode * 59 + this.Tags.GetHashCode();
                if (this.Template != null)
                    hashCode = hashCode * 59 + this.Template.GetHashCode();
                if (this.TimezoneCode != null)
                    hashCode = hashCode * 59 + this.TimezoneCode.GetHashCode();
                if (this.Username != null)
                    hashCode = hashCode * 59 + this.Username.GetHashCode();
                return hashCode;
            }
        }

    }

}