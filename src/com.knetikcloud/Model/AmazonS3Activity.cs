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
    /// AmazonS3Activity
    /// </summary>
    [DataContract]
    public partial class AmazonS3Activity :  IEquatable<AmazonS3Activity>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AmazonS3Activity" /> class.
        /// </summary>
        /// <param name="Action">S3 action (i.e., &#39;PUT&#39;) associated with the activity.</param>
        /// <param name="CdnUrl">URL for accessing the resource. Will use a CDN if configured, or direct to S3 if not.</param>
        /// <param name="CreatedDate">Date the resource was created in S3.</param>
        /// <param name="Filename">Name of the file being processed as a resource in S3.</param>
        /// <param name="ObjectKey">S3 object key for the resource.</param>
        /// <param name="Url">URL that one can PUT the file to, to upload it to S3.</param>
        /// <param name="UserId">The id of the user that created this S3 activity.</param>
        public AmazonS3Activity(string Action = default(string), string CdnUrl = default(string), long? CreatedDate = default(long?), string Filename = default(string), string ObjectKey = default(string), string Url = default(string), int? UserId = default(int?))
        {
            this.Action = Action;
            this.CdnUrl = CdnUrl;
            this.CreatedDate = CreatedDate;
            this.Filename = Filename;
            this.ObjectKey = ObjectKey;
            this.Url = Url;
            this.UserId = UserId;
        }
        
        /// <summary>
        /// S3 action (i.e., &#39;PUT&#39;) associated with the activity
        /// </summary>
        /// <value>S3 action (i.e., &#39;PUT&#39;) associated with the activity</value>
        [DataMember(Name="action", EmitDefaultValue=false)]
        public string Action { get; set; }

        /// <summary>
        /// URL for accessing the resource. Will use a CDN if configured, or direct to S3 if not
        /// </summary>
        /// <value>URL for accessing the resource. Will use a CDN if configured, or direct to S3 if not</value>
        [DataMember(Name="cdn_url", EmitDefaultValue=false)]
        public string CdnUrl { get; set; }

        /// <summary>
        /// Date the resource was created in S3
        /// </summary>
        /// <value>Date the resource was created in S3</value>
        [DataMember(Name="created_date", EmitDefaultValue=false)]
        public long? CreatedDate { get; set; }

        /// <summary>
        /// Name of the file being processed as a resource in S3
        /// </summary>
        /// <value>Name of the file being processed as a resource in S3</value>
        [DataMember(Name="filename", EmitDefaultValue=false)]
        public string Filename { get; set; }

        /// <summary>
        /// Unique id of the S3 activity
        /// </summary>
        /// <value>Unique id of the S3 activity</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; private set; }

        /// <summary>
        /// S3 object key for the resource
        /// </summary>
        /// <value>S3 object key for the resource</value>
        [DataMember(Name="object_key", EmitDefaultValue=false)]
        public string ObjectKey { get; set; }

        /// <summary>
        /// URL that one can PUT the file to, to upload it to S3
        /// </summary>
        /// <value>URL that one can PUT the file to, to upload it to S3</value>
        [DataMember(Name="url", EmitDefaultValue=false)]
        public string Url { get; set; }

        /// <summary>
        /// The id of the user that created this S3 activity
        /// </summary>
        /// <value>The id of the user that created this S3 activity</value>
        [DataMember(Name="user_id", EmitDefaultValue=false)]
        public int? UserId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AmazonS3Activity {\n");
            sb.Append("  Action: ").Append(Action).Append("\n");
            sb.Append("  CdnUrl: ").Append(CdnUrl).Append("\n");
            sb.Append("  CreatedDate: ").Append(CreatedDate).Append("\n");
            sb.Append("  Filename: ").Append(Filename).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  ObjectKey: ").Append(ObjectKey).Append("\n");
            sb.Append("  Url: ").Append(Url).Append("\n");
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
            return this.Equals(input as AmazonS3Activity);
        }

        /// <summary>
        /// Returns true if AmazonS3Activity instances are equal
        /// </summary>
        /// <param name="input">Instance of AmazonS3Activity to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AmazonS3Activity input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Action == input.Action ||
                    (this.Action != null &&
                    this.Action.Equals(input.Action))
                ) && 
                (
                    this.CdnUrl == input.CdnUrl ||
                    (this.CdnUrl != null &&
                    this.CdnUrl.Equals(input.CdnUrl))
                ) && 
                (
                    this.CreatedDate == input.CreatedDate ||
                    (this.CreatedDate != null &&
                    this.CreatedDate.Equals(input.CreatedDate))
                ) && 
                (
                    this.Filename == input.Filename ||
                    (this.Filename != null &&
                    this.Filename.Equals(input.Filename))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.ObjectKey == input.ObjectKey ||
                    (this.ObjectKey != null &&
                    this.ObjectKey.Equals(input.ObjectKey))
                ) && 
                (
                    this.Url == input.Url ||
                    (this.Url != null &&
                    this.Url.Equals(input.Url))
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
                if (this.Action != null)
                    hashCode = hashCode * 59 + this.Action.GetHashCode();
                if (this.CdnUrl != null)
                    hashCode = hashCode * 59 + this.CdnUrl.GetHashCode();
                if (this.CreatedDate != null)
                    hashCode = hashCode * 59 + this.CreatedDate.GetHashCode();
                if (this.Filename != null)
                    hashCode = hashCode * 59 + this.Filename.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.ObjectKey != null)
                    hashCode = hashCode * 59 + this.ObjectKey.GetHashCode();
                if (this.Url != null)
                    hashCode = hashCode * 59 + this.Url.GetHashCode();
                if (this.UserId != null)
                    hashCode = hashCode * 59 + this.UserId.GetHashCode();
                return hashCode;
            }
        }

    }

}
