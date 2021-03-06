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
    /// BatchReturn
    /// </summary>
    [DataContract]
    public partial class BatchReturn :  IEquatable<BatchReturn>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BatchReturn" /> class.
        /// </summary>
        /// <param name="Body">The result body.</param>
        public BatchReturn(Object Body = default(Object))
        {
            this.Body = Body;
        }
        
        /// <summary>
        /// The result body
        /// </summary>
        /// <value>The result body</value>
        [DataMember(Name="body", EmitDefaultValue=false)]
        public Object Body { get; set; }

        /// <summary>
        /// The HTTP response code
        /// </summary>
        /// <value>The HTTP response code</value>
        [DataMember(Name="code", EmitDefaultValue=false)]
        public int? Code { get; private set; }

        /// <summary>
        /// Full URI of REST call
        /// </summary>
        /// <value>Full URI of REST call</value>
        [DataMember(Name="uri", EmitDefaultValue=false)]
        public string Uri { get; private set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BatchReturn {\n");
            sb.Append("  Body: ").Append(Body).Append("\n");
            sb.Append("  Code: ").Append(Code).Append("\n");
            sb.Append("  Uri: ").Append(Uri).Append("\n");
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
            return this.Equals(input as BatchReturn);
        }

        /// <summary>
        /// Returns true if BatchReturn instances are equal
        /// </summary>
        /// <param name="input">Instance of BatchReturn to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BatchReturn input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Body == input.Body ||
                    (this.Body != null &&
                    this.Body.Equals(input.Body))
                ) && 
                (
                    this.Code == input.Code ||
                    (this.Code != null &&
                    this.Code.Equals(input.Code))
                ) && 
                (
                    this.Uri == input.Uri ||
                    (this.Uri != null &&
                    this.Uri.Equals(input.Uri))
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
                if (this.Body != null)
                    hashCode = hashCode * 59 + this.Body.GetHashCode();
                if (this.Code != null)
                    hashCode = hashCode * 59 + this.Code.GetHashCode();
                if (this.Uri != null)
                    hashCode = hashCode * 59 + this.Uri.GetHashCode();
                return hashCode;
            }
        }

    }

}
