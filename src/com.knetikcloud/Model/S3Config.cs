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
    /// S3Config
    /// </summary>
    [DataContract]
    public partial class S3Config :  IEquatable<S3Config>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="S3Config" /> class.
        /// </summary>
        /// <param name="BucketName">BucketName.</param>
        /// <param name="CdnUrl">CdnUrl.</param>
        /// <param name="Region">Region.</param>
        /// <param name="UploadPrefix">UploadPrefix.</param>
        public S3Config(string BucketName = default(string), string CdnUrl = default(string), string Region = default(string), string UploadPrefix = default(string))
        {
            this.BucketName = BucketName;
            this.CdnUrl = CdnUrl;
            this.Region = Region;
            this.UploadPrefix = UploadPrefix;
        }
        
        /// <summary>
        /// Gets or Sets BucketName
        /// </summary>
        [DataMember(Name="bucket_name", EmitDefaultValue=false)]
        public string BucketName { get; set; }

        /// <summary>
        /// Gets or Sets CdnUrl
        /// </summary>
        [DataMember(Name="cdn_url", EmitDefaultValue=false)]
        public string CdnUrl { get; set; }

        /// <summary>
        /// Gets or Sets Region
        /// </summary>
        [DataMember(Name="region", EmitDefaultValue=false)]
        public string Region { get; set; }

        /// <summary>
        /// Gets or Sets UploadPrefix
        /// </summary>
        [DataMember(Name="upload_prefix", EmitDefaultValue=false)]
        public string UploadPrefix { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class S3Config {\n");
            sb.Append("  BucketName: ").Append(BucketName).Append("\n");
            sb.Append("  CdnUrl: ").Append(CdnUrl).Append("\n");
            sb.Append("  Region: ").Append(Region).Append("\n");
            sb.Append("  UploadPrefix: ").Append(UploadPrefix).Append("\n");
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
            return this.Equals(input as S3Config);
        }

        /// <summary>
        /// Returns true if S3Config instances are equal
        /// </summary>
        /// <param name="input">Instance of S3Config to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(S3Config input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.BucketName == input.BucketName ||
                    (this.BucketName != null &&
                    this.BucketName.Equals(input.BucketName))
                ) && 
                (
                    this.CdnUrl == input.CdnUrl ||
                    (this.CdnUrl != null &&
                    this.CdnUrl.Equals(input.CdnUrl))
                ) && 
                (
                    this.Region == input.Region ||
                    (this.Region != null &&
                    this.Region.Equals(input.Region))
                ) && 
                (
                    this.UploadPrefix == input.UploadPrefix ||
                    (this.UploadPrefix != null &&
                    this.UploadPrefix.Equals(input.UploadPrefix))
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
                if (this.BucketName != null)
                    hashCode = hashCode * 59 + this.BucketName.GetHashCode();
                if (this.CdnUrl != null)
                    hashCode = hashCode * 59 + this.CdnUrl.GetHashCode();
                if (this.Region != null)
                    hashCode = hashCode * 59 + this.Region.GetHashCode();
                if (this.UploadPrefix != null)
                    hashCode = hashCode * 59 + this.UploadPrefix.GetHashCode();
                return hashCode;
            }
        }

    }

}
