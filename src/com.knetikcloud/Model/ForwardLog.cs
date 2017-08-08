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
    /// ForwardLog
    /// </summary>
    [DataContract]
    public partial class ForwardLog :  IEquatable<ForwardLog>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ForwardLog" /> class.
        /// </summary>
        /// <param name="ErrorMsg">ErrorMsg.</param>
        /// <param name="Payload">The payload of the forward log entry.</param>
        public ForwardLog(string ErrorMsg = default(string), Object Payload = default(Object))
        {
            this.ErrorMsg = ErrorMsg;
            this.Payload = Payload;
        }
        
        /// <summary>
        /// The end date of the forward log entry
        /// </summary>
        /// <value>The end date of the forward log entry</value>
        [DataMember(Name="end_date", EmitDefaultValue=false)]
        public long? EndDate { get; private set; }

        /// <summary>
        /// Gets or Sets ErrorMsg
        /// </summary>
        [DataMember(Name="error_msg", EmitDefaultValue=false)]
        public string ErrorMsg { get; set; }

        /// <summary>
        /// The http status code the forward log entry
        /// </summary>
        /// <value>The http status code the forward log entry</value>
        [DataMember(Name="http_status_code", EmitDefaultValue=false)]
        public int? HttpStatusCode { get; private set; }

        /// <summary>
        /// The id of the forward log entry
        /// </summary>
        /// <value>The id of the forward log entry</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; private set; }

        /// <summary>
        /// The payload of the forward log entry
        /// </summary>
        /// <value>The payload of the forward log entry</value>
        [DataMember(Name="payload", EmitDefaultValue=false)]
        public Object Payload { get; set; }

        /// <summary>
        /// The response string of the forward log entry
        /// </summary>
        /// <value>The response string of the forward log entry</value>
        [DataMember(Name="response", EmitDefaultValue=false)]
        public string Response { get; private set; }

        /// <summary>
        /// The retry count of the forward log entry
        /// </summary>
        /// <value>The retry count of the forward log entry</value>
        [DataMember(Name="retry_count", EmitDefaultValue=false)]
        public int? RetryCount { get; private set; }

        /// <summary>
        /// The start date of the forward log entry
        /// </summary>
        /// <value>The start date of the forward log entry</value>
        [DataMember(Name="start_date", EmitDefaultValue=false)]
        public long? StartDate { get; private set; }

        /// <summary>
        /// The endpoint url of the forward log entry
        /// </summary>
        /// <value>The endpoint url of the forward log entry</value>
        [DataMember(Name="url", EmitDefaultValue=false)]
        public string Url { get; private set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ForwardLog {\n");
            sb.Append("  EndDate: ").Append(EndDate).Append("\n");
            sb.Append("  ErrorMsg: ").Append(ErrorMsg).Append("\n");
            sb.Append("  HttpStatusCode: ").Append(HttpStatusCode).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Payload: ").Append(Payload).Append("\n");
            sb.Append("  Response: ").Append(Response).Append("\n");
            sb.Append("  RetryCount: ").Append(RetryCount).Append("\n");
            sb.Append("  StartDate: ").Append(StartDate).Append("\n");
            sb.Append("  Url: ").Append(Url).Append("\n");
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
            return this.Equals(input as ForwardLog);
        }

        /// <summary>
        /// Returns true if ForwardLog instances are equal
        /// </summary>
        /// <param name="input">Instance of ForwardLog to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ForwardLog input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.EndDate == input.EndDate ||
                    (this.EndDate != null &&
                    this.EndDate.Equals(input.EndDate))
                ) && 
                (
                    this.ErrorMsg == input.ErrorMsg ||
                    (this.ErrorMsg != null &&
                    this.ErrorMsg.Equals(input.ErrorMsg))
                ) && 
                (
                    this.HttpStatusCode == input.HttpStatusCode ||
                    (this.HttpStatusCode != null &&
                    this.HttpStatusCode.Equals(input.HttpStatusCode))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Payload == input.Payload ||
                    (this.Payload != null &&
                    this.Payload.Equals(input.Payload))
                ) && 
                (
                    this.Response == input.Response ||
                    (this.Response != null &&
                    this.Response.Equals(input.Response))
                ) && 
                (
                    this.RetryCount == input.RetryCount ||
                    (this.RetryCount != null &&
                    this.RetryCount.Equals(input.RetryCount))
                ) && 
                (
                    this.StartDate == input.StartDate ||
                    (this.StartDate != null &&
                    this.StartDate.Equals(input.StartDate))
                ) && 
                (
                    this.Url == input.Url ||
                    (this.Url != null &&
                    this.Url.Equals(input.Url))
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
                if (this.EndDate != null)
                    hashCode = hashCode * 59 + this.EndDate.GetHashCode();
                if (this.ErrorMsg != null)
                    hashCode = hashCode * 59 + this.ErrorMsg.GetHashCode();
                if (this.HttpStatusCode != null)
                    hashCode = hashCode * 59 + this.HttpStatusCode.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Payload != null)
                    hashCode = hashCode * 59 + this.Payload.GetHashCode();
                if (this.Response != null)
                    hashCode = hashCode * 59 + this.Response.GetHashCode();
                if (this.RetryCount != null)
                    hashCode = hashCode * 59 + this.RetryCount.GetHashCode();
                if (this.StartDate != null)
                    hashCode = hashCode * 59 + this.StartDate.GetHashCode();
                if (this.Url != null)
                    hashCode = hashCode * 59 + this.Url.GetHashCode();
                return hashCode;
            }
        }

    }

}